using System;
using System.Collections.Generic; // Để dùng List
using System.Linq; // Để dùng LINQ (tìm kiếm, xóa)
using System.Windows.Forms;
using QuanLyThuCung.Class; // Namespace chứa FileXml và Models (ThuCung, NhaCungCap)

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmQuanLyThuCung : Form
    {
        // Khai báo List để chứa dữ liệu XML
        List<ThuCung> listTC = new List<ThuCung>();
        List<NhaCungCap> listNCC = new List<NhaCungCap>();

        public frmQuanLyThuCung()
        {
            InitializeComponent();
        }

        private void frmQuanLyThuCung_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
            LoadData();

            // Giả định ComboBox đã được điền item. Set mặc định index 0
            if (cboLoai.Items.Count > 0) cboLoai.SelectedIndex = 0;
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;
        }

        // 1. TẢI DỮ LIỆU THÚ CƯNG
        private void LoadData()
        {
            try
            {
                // Đọc file XML Thú cưng
                listTC = FileXml.DocFile<ThuCung>("ThuCung.xml");

                // Đổ vào DataGridView
                dgvThuCung.DataSource = null;
                dgvThuCung.DataSource = listTC;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu thú cưng: " + ex.Message);
            }
        }

        // 2. TẢI DANH MỤC NHÀ CUNG CẤP (XML)
        private void LoadNhaCungCap()
        {
            try
            {
                // Đọc file XML Nhà Cung Cấp
                listNCC = FileXml.DocFile<NhaCungCap>("NhaCungCap.xml");

                cboNCC.DataSource = listNCC;
                cboNCC.DisplayMember = "TenNCC";
                cboNCC.ValueMember = "MaNCC";
            }
            catch { }
        }

        // 3. HIỂN THỊ LÊN Ô NHẬP KHI CLICK
        private void dgvThuCung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvThuCung.Rows[e.RowIndex];

                txtMaTC.Text = row.Cells["MaThuCung"].Value?.ToString();
                txtTenTC.Text = row.Cells["TenThuCung"].Value?.ToString();

                // Lấy giá trị string cho các ComboBox
                if (row.Cells["LoaiThuCung"].Value != null)
                    cboLoai.Text = row.Cells["LoaiThuCung"].Value.ToString();

                txtGiong.Text = row.Cells["Giong"].Value?.ToString();

                // Chuyển đổi giá trị số
                if (row.Cells["GiaBan"].Value != null)
                    numGiaBan.Value = Convert.ToDecimal(row.Cells["GiaBan"].Value);

                if (row.Cells["TrangThai"].Value != null)
                    cboTrangThai.Text = row.Cells["TrangThai"].Value.ToString();

                // Set MaNCC cho ComboBox (Sử dụng ValueMember)
                if (row.Cells["MaNCC"].Value != null)
                    cboNCC.SelectedValue = row.Cells["MaNCC"].Value.ToString();

                txtMaTC.Enabled = false;
            }
        }

        // 4. THÊM (INSERT XML)
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaTC.Text == "" || txtTenTC.Text == "") return;

            // Kiểm tra trùng mã
            if (listTC.Any(x => x.MaThuCung == txtMaTC.Text.Trim()))
            {
                MessageBox.Show("Mã thú cưng đã tồn tại!");
                return;
            }

            try
            {
                ThuCung tc = new ThuCung()
                {
                    MaThuCung = txtMaTC.Text.Trim(),
                    TenThuCung = txtTenTC.Text.Trim(),
                    LoaiThuCung = cboLoai.Text,
                    Giong = txtGiong.Text.Trim(),
                    GioiTinh = "Chưa rõ", // Chưa có ô nhập, gán mặc định
                    NgaySinh = DateTime.Now, // Chưa có ô nhập, gán mặc định
                    GiaNhap = 0, // Chưa có ô nhập, gán mặc định
                    GiaBan = (int)numGiaBan.Value,
                    TrangThai = cboTrangThai.Text,
                    MaNCC = cboNCC.SelectedValue?.ToString(),
                    SoLuong = 1 // Thú cưng thường là đơn chiếc
                };

                // Thêm vào List và Ghi File
                listTC.Add(tc);
                FileXml.GhiFile("ThuCung.xml", listTC);

                MessageBox.Show("Thêm thành công!");
                LoadData();
                btnLamMoi_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // 5. SỬA (UPDATE XML)
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaTC.Text == "") return;

            try
            {
                // Tìm thú cưng trong List
                var tc = listTC.FirstOrDefault(x => x.MaThuCung == txtMaTC.Text);

                if (tc != null)
                {
                    // Cập nhật thông tin
                    tc.TenThuCung = txtTenTC.Text.Trim();
                    tc.LoaiThuCung = cboLoai.Text;
                    tc.Giong = txtGiong.Text.Trim();
                    tc.GiaBan = (int)numGiaBan.Value;
                    tc.TrangThai = cboTrangThai.Text;
                    tc.MaNCC = cboNCC.SelectedValue?.ToString();

                    // Lưu lại File
                    FileXml.GhiFile("ThuCung.xml", listTC);

                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                    btnLamMoi_Click(sender, e);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // 6. XÓA (DELETE XML)
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTC.Text == "") return;

            if (MessageBox.Show("Xóa thú cưng này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var tc = listTC.FirstOrDefault(x => x.MaThuCung == txtMaTC.Text);

                    if (tc != null)
                    {
                        listTC.Remove(tc);
                        FileXml.GhiFile("ThuCung.xml", listTC);

                        MessageBox.Show("Đã xóa!");
                        LoadData();
                        btnLamMoi_Click(sender, e);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTC.Enabled = true;
            txtMaTC.Clear();
            txtTenTC.Clear();
            txtGiong.Clear();
            numGiaBan.Value = 0;

            if (cboLoai.Items.Count > 0) cboLoai.SelectedIndex = 0;
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;

            txtMaTC.Focus();
        }
    }
}