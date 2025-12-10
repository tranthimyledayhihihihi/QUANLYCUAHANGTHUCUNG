using QuanLyCuaHangThuCung.Class;
using System;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmDangNhap : Form
    {
        DangNhap dn = new DangNhap(); // class xử lý XML

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        // Nút Đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            // Kiểm tra trống
            if (user == "" || pass == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trong XML
            bool kq = dn.kiemtraDangNhap(user, pass);

            if (!kq)
            {
                MessageBox.Show("Sai mã nhân viên hoặc mật khẩu!", "Lỗi đăng nhập",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtPass.Focus();
                return;
            }

            // Lấy thông tin từ XML
            var info = dn.layThongTinNguoiDung(user);

            // 💥 Không dùng Session nữa — dùng biến static của frmMainNew
            frmMainNew.maNVMain = info.MaNhanVien;
            frmMainNew.QuyenMain = info.Quyen;

            MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Mở form chính
            frmMainNew main = new frmMainNew();
            main.Show();

            this.Hide(); // ẩn form đăng nhập
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
