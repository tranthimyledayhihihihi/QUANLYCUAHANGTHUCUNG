using System;
using System.Collections.Generic;
using System.Linq; // Để dùng LINQ
using System.Windows.Forms;
using QuanLyThuCung.Class; // Namespace chứa FileXml và Model

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmNhanVien : Form
    {
        // Danh sách nhân viên lưu trên RAM
        List<NhanVien> listNV = new List<NhanVien>();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // Cấu hình ComboBox Quyền nếu chưa có item
            if (cboQuyen.Items.Count == 0)
            {
                cboQuyen.Items.Add("Nhân viên"); // Index 0
                cboQuyen.Items.Add("Quản lý");   // Index 1
            }
            cboQuyen.SelectedIndex = 0;

            LoadData();
        }

        // --- HÀM TẢI DỮ LIỆU ---
        private void LoadData()
        {
            try
            {
                // 1. Đọc file XML
                listNV = FileXml.DocFile<NhanVien>("NhanVien.xml");

                // 2. Đổ vào GridView
                dgvNhanVien.DataSource = null;
                dgvNhanVien.DataSource = listNV;

                // Ẩn cột Mật khẩu để bảo mật
                if (dgvNhanVien.Columns["MatKhau"] != null)
                    dgvNhanVien.Columns["MatKhau"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // --- CLICK VÀO LƯỚI ĐỂ HIỆN THÔNG TIN ---
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                txtMaNV.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNhanVien"].Value.ToString();

                if (row.Cells["NgaySinh"].Value != null)
                    dtpNgaySinh.Value = (DateTime)row.Cells["NgaySinh"].Value;

                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();

                // Xử lý Quyền (Hiển thị lên ComboBox)
                if (row.Cells["Quyen"].Value != null)
                {
                    int quyen = Convert.ToInt32(row.Cells["Quyen"].Value);
                    // 1: Quản lý, 0: Nhân viên
                    cboQuyen.SelectedIndex = (quyen == 1) ? 1 : 0;
                }

                txtMaNV.Enabled = false; // Khóa mã khi đang xem/sửa
            }
        }

        // --- NÚT THÊM ---
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã và Tên nhân viên!");
                return;
            }

            // Kiểm tra trùng mã
            if (listNV.Any(x => x.MaNhanVien == txtMaNV.Text.Trim()))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }

            try
            {
                // Tạo nhân viên mới
                NhanVien nv = new NhanVien()
                {
                    MaNhanVien = txtMaNV.Text.Trim(),
                    TenNhanVien = txtTenNV.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    SDT = txtSDT.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),

                    // Tự động set mật khẩu mặc định và quyền
                    MatKhau = "123",
                    Quyen = cboQuyen.SelectedIndex // 0: NV, 1: QL
                };

                // Thêm vào List và Ghi File
                listNV.Add(nv);
                FileXml.GhiFile("NhanVien.xml", listNV);

                MessageBox.Show("Thêm thành công! Mật khẩu mặc định là: 123");
                LoadData();
                btnLamMoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        // --- NÚT SỬA ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "") return;

            try
            {
                // Tìm nhân viên trong List
                var nv = listNV.FirstOrDefault(x => x.MaNhanVien == txtMaNV.Text);

                if (nv != null)
                {
                    // Cập nhật thông tin
                    nv.TenNhanVien = txtTenNV.Text.Trim();
                    nv.NgaySinh = dtpNgaySinh.Value;
                    nv.SDT = txtSDT.Text.Trim();
                    nv.DiaChi = txtDiaChi.Text.Trim();
                    nv.Quyen = cboQuyen.SelectedIndex;

                    // Lưu lại File
                    FileXml.GhiFile("NhanVien.xml", listNV);

                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                    btnLamMoi_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        // --- NÚT XÓA ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "") return;

            // Kiểm tra không cho xóa chính mình (người đang đăng nhập)
            if (HeThong.NhanVienDangNhap != null && txtMaNV.Text == HeThong.NhanVienDangNhap.MaNhanVien)
            {
                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    var nv = listNV.FirstOrDefault(x => x.MaNhanVien == txtMaNV.Text);
                    if (nv != null)
                    {
                        listNV.Remove(nv);
                        FileXml.GhiFile("NhanVien.xml", listNV);

                        MessageBox.Show("Đã xóa!");
                        LoadData();
                        btnLamMoi_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
            }
        }

        // --- NÚT LÀM MỚI ---
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = true; // Mở lại ô Mã để nhập mới
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            cboQuyen.SelectedIndex = 0; // Reset về Nhân viên
            txtMaNV.Focus();
        }
    }
}