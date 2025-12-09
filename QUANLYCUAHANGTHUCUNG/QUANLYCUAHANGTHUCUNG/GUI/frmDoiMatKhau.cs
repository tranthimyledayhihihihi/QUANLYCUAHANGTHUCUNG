using System;
using System.Collections.Generic;
using System.Linq; // Cần thiết để tìm kiếm trong List
using System.Windows.Forms;
using QuanLyThuCung.Class; // Namespace chứa FileXml và HeThong

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            // Kiểm tra xem đã đăng nhập chưa để tránh lỗi
            if (HeThong.NhanVienDangNhap != null)
            {
                lblTaiKhoan.Text = "Tài khoản: " + HeThong.NhanVienDangNhap.MaNhanVien;
            }
            else
            {
                MessageBox.Show("Chưa đăng nhập!");
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string passOld = txtMatKhauCu.Text.Trim();
            string passNew = txtMatKhauMoi.Text.Trim();
            string passConfirm = txtXacNhan.Text.Trim();

            // 1. Kiểm tra nhập thiếu
            if (passOld == "" || passNew == "" || passConfirm == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo");
                return;
            }

            // 2. Kiểm tra mật khẩu xác nhận
            if (passNew != passConfirm)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Kiểm tra mật khẩu cũ (So sánh với mật khẩu đang lưu trong Hệ thống)
            if (HeThong.NhanVienDangNhap.MatKhau != passOld)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 4. Tiến hành cập nhật vào XML
                // B1: Đọc toàn bộ danh sách nhân viên lên
                List<NhanVien> listNV = FileXml.DocFile<NhanVien>("NhanVien.xml");

                // B2: Tìm nhân viên đang đăng nhập trong danh sách đó
                var nv = listNV.FirstOrDefault(x => x.MaNhanVien == HeThong.NhanVienDangNhap.MaNhanVien);

                if (nv != null)
                {
                    // B3: Đổi mật khẩu
                    nv.MatKhau = passNew;

                    // B4: Ghi đè lại file XML
                    FileXml.GhiFile("NhanVien.xml", listNV);

                    // B5: Cập nhật luôn mật khẩu trong phiên đăng nhập hiện tại
                    HeThong.NhanVienDangNhap.MatKhau = passNew;

                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản trong dữ liệu gốc!", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Checkbox hiển thị mật khẩu
        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                txtMatKhauCu.PasswordChar = '\0'; // Hiện chữ
                txtMatKhauMoi.PasswordChar = '\0';
                txtXacNhan.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauCu.PasswordChar = '*'; // Hiện dấu sao
                txtMatKhauMoi.PasswordChar = '*';
                txtXacNhan.PasswordChar = '*';
            }
        }
    }
}