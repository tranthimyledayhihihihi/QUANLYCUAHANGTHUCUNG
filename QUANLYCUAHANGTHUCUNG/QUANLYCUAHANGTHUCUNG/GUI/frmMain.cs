using System;
using System.Windows.Forms;
using QuanLyThuCung.Class; // Quan trọng: Để dùng HeThong và các Class Model

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // 1. Kiểm tra an toàn: Nếu chưa đăng nhập thì đuổi ra
            if (HeThong.NhanVienDangNhap == null)
            {
                MessageBox.Show("Phiên đăng nhập không hợp lệ. Vui lòng đăng nhập lại!");
                this.Close();
                return;
            }

            // 2. Hiển thị thông tin người dùng
            if (lblNguoiDung != null)
                lblNguoiDung.Text = "Xin chào: " + HeThong.NhanVienDangNhap.TenNhanVien;

            // 3. Kích hoạt Timer để chạy đồng hồ
            timer1.Start();

            // 4. Phân quyền
            PhanQuyen();
        }

        // --- HÀM PHÂN QUYỀN (LOGIC XML) ---
        private void PhanQuyen()
        {
            int quyen = HeThong.NhanVienDangNhap.Quyen;

            if (quyen == 0) // Nhân viên (Bị hạn chế)
            {
                // Ẩn/Khóa các menu quản lý cấp cao
                if (menuNhanVien != null) menuNhanVien.Enabled = false;
                if (menuSaoLuu != null) menuSaoLuu.Enabled = false;
                if (menuDoanhThu != null) menuDoanhThu.Enabled = false;
            }
        }

        // --- HÀM MỞ FORM CON ---
        private void OpenChildForm(Form childForm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == childForm.Name)
                {
                    f.Activate();
                    return;
                }
            }
            childForm.MdiParent = this;
            childForm.Show();
        }

        // --- CÁC SỰ KIỆN CLICK MENU ---

        // 1. Hệ thống
        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            HeThong.NhanVienDangNhap = null;
            this.Hide();
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
            this.Close();
        }

        private void menuDoiMatKhau_Click(object sender, EventArgs e)
        {
            // Code form này đã được sửa
            OpenChildForm(new frmDoiMatKhau());
        }

        private void menuSaoLuu_Click(object sender, EventArgs e)
        {
            // Code form này đã được sửa
            OpenChildForm(new frmHeThong());
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 2. Quản lý (Danh mục) - TẤT CẢ ĐÃ ĐƯỢC MỞ KHÓA
        private void menuNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }

        private void menuKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
        }

        private void menuThuCung_Click(object sender, EventArgs e)
        {
            // Code form này đã được sửa
            OpenChildForm(new frmQuanLyThuCung());
        }

        private void menuSanPham_Click(object sender, EventArgs e)
        {
            // Code form này đã được sửa
            OpenChildForm(new frmQuanLySanPham());
        }

        private void menuDichVu_Click(object sender, EventArgs e)
        {
            // Code form này đã được sửa
            OpenChildForm(new frmQuanLyDichVu());
        }

        // 3. Giao dịch (Nghiệp vụ) - TẤT CẢ ĐÃ ĐƯỢC MỞ KHÓA
        private void menuBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBanHang());
        }

        private void menuLichHen_Click(object sender, EventArgs e)
        {
            // Code form này đã được sửa
            OpenChildForm(new frmLichHen());
        }

        private void menuNhapHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhieuNhap());
        }

        // 4. Báo cáo - TẤT CẢ ĐÃ ĐƯỢC MỞ KHÓA
        private void menuDoanhThu_Click(object sender, EventArgs e)
        {
            // Code form này đã được sửa
            OpenChildForm(new frmBaoCao());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblThoiGian != null)
                lblThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}