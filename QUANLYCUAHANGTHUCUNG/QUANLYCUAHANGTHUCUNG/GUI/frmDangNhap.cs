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

            // 1. Kiểm tra trống
            if (user == "" || pass == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra đăng nhập trong XML
            bool kq = dn.kiemtraDangNhap(user, pass);

            if (!kq)
            {
                MessageBox.Show("Sai mã nhân viên hoặc mật khẩu!", "Lỗi đăng nhập",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtPass.Focus();
                return;
            }

            // 3. LẤY THÔNG TIN NGƯỜI DÙNG TỪ XML
            var info = dn.layThongTinNguoiDung(user);
            // info.MaNhanVien
            // info.TenNhanVien
            // info.Quyen

            // 4. GÁN BIẾN STATIC (DÙNG NẾU CẦN)
            frmMainNew.maNVMain = info.MaNhanVien;
            frmMainNew.QuyenMain = info.Quyen;

            // 5. MỞ FORM MAIN
            frmMainNew main = new frmMainNew();

            // ⭐⭐⭐ DÒNG QUAN TRỌNG NHẤT ⭐⭐⭐
            main.HienThiThongTinDangNhap(
                info.TenNhanVien,
                info.Quyen == 1 ? "Quản lý" : "Nhân viên"
            );

            MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            main.Show();
            this.Hide();
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

        private void lblPass_Click(object sender, EventArgs e)
        {

        }
    }
}
