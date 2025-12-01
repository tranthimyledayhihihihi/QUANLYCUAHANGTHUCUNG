using QuanLyCuaHangThuCung.Class;
using QuanLyThuCung.Class; // Namespace chứa FileXml và các Class Model (KhachHang, DichVu, LichHen)
using System;
using System.Collections.Generic;
using System.Linq; // Để dùng LINQ (tìm kiếm, lọc, join)
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmLichHen : Form
    {
        // Khai báo List để chứa dữ liệu XML
        List<LichHen> listLichHen;
        List<KhachHang> listKhachHang;
        List<DichVu> listDichVu;

        public frmLichHen()
        {
            InitializeComponent();
        }

        private void frmLichHen_Load(object sender, EventArgs e)
        {
            // Đặt ngày mặc định trước khi load dữ liệu
            dtpNgayXem.Value = DateTime.Now;

            LoadComboBoxData();
            LoadLichHen();
        }

        // --- LOAD DỮ LIỆU CƠ SỞ (ComboBox) TỪ XML ---
        private void LoadComboBoxData()
        {
            try
            {
                // Load Khách hàng
                listKhachHang = FileXml.DocFile<KhachHang>("KhachHang.xml");
                cboKhachHang.DataSource = listKhachHang;
                cboKhachHang.DisplayMember = "TenKhachHang";
                cboKhachHang.ValueMember = "MaKhachHang";

                // Load Dịch vụ
                listDichVu = FileXml.DocFile<DichVu>("DichVu.xml");
                cboDichVu.DataSource = listDichVu;
                cboDichVu.DisplayMember = "TenDV";
                cboDichVu.ValueMember = "MaDV";

                // Giả định ComboBox Trạng thái đã được điền sẵn
                if (cboTrangThai.Items.Count > 0)
                    cboTrangThai.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu danh mục: " + ex.Message);
            }
        }

        // --- LOAD LỊCH HẸN (Dùng LINQ Join - Đã Fix lỗi GioHen NULL) ---
        private void LoadLichHen()
        {
            try
            {
                // Tải lịch hẹn và kiểm tra an toàn dữ liệu
                listLichHen = FileXml.DocFile<LichHen>("LichHen.xml");

                // Lọc theo ngày xem và kiểm tra các khóa ngoại + GioHen không bị null trước khi join
                DateTime ngayXem = dtpNgayXem.Value.Date;
                var lichLoc = listLichHen
                    .Where(l => l.MaKhachHang != null && l.MaDichVu != null) // Kiểm tra khóa ngoại
                    .Where(l => l.NgayHen.Date == ngayXem)
                    .Where(l => l.GioHen != null) // <--- FIX LỖI: Đảm bảo GioHen không null khi sắp xếp
                    .ToList();

                // Dùng LINQ Join để lấy Tên Khách hàng và Tên Dịch vụ
                var hienThi = from lh in lichLoc
                              join kh in listKhachHang on lh.MaKhachHang equals kh.MaKhachHang
                              join dv in listDichVu on lh.MaDichVu equals dv.MaDV
                              orderby lh.GioHen ascending // Sắp xếp sau khi đã loại bỏ các bản ghi null
                              select new
                              {
                                  lh.MaLichHen,
                                  TenKhachHang = kh.TenKhachHang,
                                  TenDV = dv.TenDV,
                                  lh.NgayHen,
                                  lh.GioHen,
                                  lh.TrangThai
                              };

                dgvLichHen.DataSource = null;
                dgvLichHen.DataSource = hienThi.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch hẹn: " + ex.Message);
            }
        }

        private void dtpNgayXem_ValueChanged(object sender, EventArgs e)
        {
            LoadLichHen(); // Tự động load lại lịch khi đổi ngày
        }

        private void dgvLichHen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLichHen.Rows[e.RowIndex];

                // Lấy các giá trị hiển thị
                txtMaLich.Text = row.Cells["MaLichHen"].Value?.ToString();

                // Set ComboBox dựa trên giá trị text
                cboKhachHang.Text = row.Cells["TenKhachHang"].Value?.ToString();
                cboDichVu.Text = row.Cells["TenDV"].Value?.ToString();

                if (row.Cells["NgayHen"].Value != null)
                    dtpNgayHen.Value = Convert.ToDateTime(row.Cells["NgayHen"].Value);

                if (row.Cells["GioHen"].Value != null)
                    dtpGioHen.Value = DateTime.Today.Add((TimeSpan)row.Cells["GioHen"].Value);

                cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
            }
        }

        // --- NÚT ĐẶT LỊCH (INSERT XML) ---
        private void btnDatLich_Click(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedValue == null || cboDichVu.SelectedValue == null) return;

            try
            {
                // Tạo ID tự tăng (Giả lập Identity)
                int nextId = 1;
                if (listLichHen.Count > 0)
                    nextId = listLichHen.Max(l => l.MaLichHen) + 1;

                LichHen lh = new LichHen()
                {
                    MaLichHen = nextId,
                    MaKhachHang = cboKhachHang.SelectedValue.ToString(),
                    MaDichVu = cboDichVu.SelectedValue.ToString(),
                    NgayHen = dtpNgayHen.Value.Date,
                    GioHen = dtpGioHen.Value.TimeOfDay,
                    TrangThai = "Chờ xác nhận"
                };

                listLichHen.Add(lh);
                FileXml.GhiFile("LichHen.xml", listLichHen); // Lưu XML

                MessageBox.Show("Đặt lịch thành công!");
                LoadLichHen();
                btnLamMoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đặt lịch: " + ex.Message);
            }
        }

        // --- NÚT CẬP NHẬT (UPDATE XML) ---
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaLich.Text == "") return;

            try
            {
                int maLich = Convert.ToInt32(txtMaLich.Text);

                // Tìm lịch hẹn cần sửa
                var lh = listLichHen.FirstOrDefault(l => l.MaLichHen == maLich);

                if (lh != null)
                {
                    // Cập nhật thông tin mới
                    lh.MaKhachHang = cboKhachHang.SelectedValue.ToString();
                    lh.MaDichVu = cboDichVu.SelectedValue.ToString();
                    lh.NgayHen = dtpNgayHen.Value.Date;
                    lh.GioHen = dtpGioHen.Value.TimeOfDay;
                    lh.TrangThai = cboTrangThai.Text;

                    FileXml.GhiFile("LichHen.xml", listLichHen); // Lưu XML

                    MessageBox.Show("Cập nhật thành công!");
                    LoadLichHen();
                    btnLamMoi_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        // --- NÚT HỦY (DELETE XML) ---
        private void btnHuyLich_Click(object sender, EventArgs e)
        {
            if (txtMaLich.Text == "") return;

            if (MessageBox.Show("Hủy lịch này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int maLich = Convert.ToInt32(txtMaLich.Text);

                    var lh = listLichHen.FirstOrDefault(l => l.MaLichHen == maLich);

                    if (lh != null)
                    {
                        listLichHen.Remove(lh);
                        FileXml.GhiFile("LichHen.xml", listLichHen); // Lưu XML
                        LoadLichHen();
                        btnLamMoi_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hủy lịch: " + ex.Message);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLich.Clear();
            cboTrangThai.SelectedIndex = 0;
            dtpNgayHen.Value = DateTime.Now;
            dtpGioHen.Value = DateTime.Now;
        }
    }
}