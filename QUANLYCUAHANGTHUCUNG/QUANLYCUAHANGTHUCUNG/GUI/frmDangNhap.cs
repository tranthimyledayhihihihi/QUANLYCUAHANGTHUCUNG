using System;
using System.Collections.Generic;
using System.Linq; // Dùng LINQ để tìm tài khoản
using System.Windows.Forms;
using QuanLyThuCung.Class; // Namespace chứa FileXml và Models

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string u = txtUser.Text.Trim();
            string p = txtPass.Text.Trim();

            if (u == "" || p == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                // 1. Đọc danh sách nhân viên từ file XML
                List<NhanVien> listNV = FileXml.DocFile<NhanVien>("NhanVien.xml");

                // 2. Tìm nhân viên có Mã và Mật khẩu trùng khớp
                // (Sử dụng LINQ thay cho câu lệnh SELECT của SQL)
                var taiKhoan = listNV.FirstOrDefault(x => x.MaNhanVien == u && x.MatKhau == p);

                if (taiKhoan != null)
                {
                    // 3. Đăng nhập thành công
                    MessageBox.Show("Đăng nhập thành công! Xin chào " + taiKhoan.TenNhanVien, "Thông báo");

                    // QUAN TRỌNG: Gán toàn bộ đối tượng tìm được vào Hệ Thống
                    // (Lệnh này sửa lỗi NullReferenceException của bạn)
                    HeThong.NhanVienDangNhap = taiKhoan;

                    // 4. Mở Form Chính (frmMain)
                    this.Hide();
                    frmMain f = new frmMain();
                    f.ShowDialog();

                    // Khi Form Main đóng thì đóng luôn ứng dụng
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}