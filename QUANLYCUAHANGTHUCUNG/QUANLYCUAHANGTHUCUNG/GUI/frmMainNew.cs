using QuanLyCuaHangThuCung.Class;
using System;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmMainNew : Form
    {
        public static string tenDNMain = "";
        public static string maNVMain = "";
        public static int QuyenMain = 0;

        public frmMainNew()
        {
            InitializeComponent();
            GanSuKienMenu();
        }

        private void frmMainNew_Load(object sender, EventArgs e)
        {
            // Load trang chủ mặc định nếu muốn
            //LoadForm(new frmTrangChu());
        }

        //====================================================
        // LOAD FORM CON VÀO PANEL
        //====================================================
        private void LoadForm(Form frm)
        {
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }

        //====================================================
        // GÁN SỰ KIỆN MENU
        //====================================================
        private void GanSuKienMenu()
        {
            // HỆ THỐNG
            mnuTrangChu.Click += (s, e) => LoadForm(new frmHeThong());
            mnuChuyenDoi.Click += (s, e) => LoadForm(new frmHeThong());
            mnuThoat.Click += (s, e) => Application.Exit();
            mnuTaiKhoan.Click += (s, e) => LoadForm(new frmDoiMatKhau());

            // QUẢN LÝ
            mnuNhanVien.Click += (s, e) => LoadForm(new frmNhanVien());
            mnuChamCong.Click += (s, e) => LoadForm(new frmNhanVien()); // Nếu bạn có frmChamCong → đổi lại
            mnuKhachHang.Click += (s, e) => LoadForm(new frmKhachHang());

            // SẢN PHẨM – DỊCH VỤ
            mnuThuCung.Click += (s, e) => LoadForm(new frmQuanLyThuCung());
            mnuSanPham.Click += (s, e) => LoadForm(new frmQuanLySanPham());
            mnuDichVu.Click += (s, e) => LoadForm(new frmQuanLyDichVu());

            // GIAO DỊCH
            mnuBanHang.Click += (s, e) => LoadForm(new frmBanHang());
            mnuLichHen.Click += (s, e) => LoadForm(new frmLichHen());
            mnuPhieuNhap.Click += (s, e) => LoadForm(new frmPhieuNhap());
            mnuHoaDon.Click += (s, e) => LoadForm(new frmBanHang()); // Nếu có frmHoaDon → đổi lại

            // BÁO CÁO
            mnuBaoCao.Click += (s, e) => LoadForm(new frmBaoCao());
        }

        //====================================================
        // HIỂN THỊ THÔNG TIN ĐĂNG NHẬP
        //====================================================
        public void HienThiThongTinDangNhap(string tenNV, string quyen)
        {
            lblTenNV.Text = "Nhân viên: " + tenNV;
            lblQuyen.Text = "Quyền: " + quyen;
            lblGioDN.Text = "Giờ đăng nhập: " + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }
    }
}
