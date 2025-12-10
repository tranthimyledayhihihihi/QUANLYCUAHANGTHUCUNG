namespace QuanLyCuaHangThuCung.GUI
{
    partial class frmMainNew
    {
        private System.ComponentModel.IContainer components = null;

        // ===== KHAI BÁO CONTROL =====
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.Label lblGioDN;
        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuTrangChu;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenDoi;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;

        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;

        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;   // ⭐ THÊM MENU KHÁCH HÀNG

        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuChamCong;

        private System.Windows.Forms.ToolStripMenuItem mnuSanPhamDichVu;
        private System.Windows.Forms.ToolStripMenuItem mnuThuCung;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuDichVu;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaCungCap;

        private System.Windows.Forms.ToolStripMenuItem mnuGiaoDich;
        private System.Windows.Forms.ToolStripMenuItem mnuBanHang;
        private System.Windows.Forms.ToolStripMenuItem mnuLichHen;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;

        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenDoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();

            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();

            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();   // ⭐ KHAI TẠO MENU KHÁCH HÀNG

            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChamCong = new System.Windows.Forms.ToolStripMenuItem();

            this.mnuSanPhamDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuCung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();

            this.mnuGiaoDich = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLichHen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();

            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblGioDN = new System.Windows.Forms.Label();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();

            this.pnlMain = new System.Windows.Forms.Panel();

            this.menuStrip1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // ================== MENU STRIP ==================
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(200, 247, 220);
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuHeThong,
                this.mnuQuanLy,
                this.mnuSanPhamDichVu,
                this.mnuGiaoDich,
                this.mnuBaoCao
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 44);

            // ================== MENU HỆ THỐNG ==================
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuTrangChu,
                this.mnuChuyenDoi,
                this.mnuThoat
            });
            this.mnuHeThong.Text = "🏠 Hệ thống";

            this.mnuTrangChu.Text = "🐾 Trang chủ";
            this.mnuChuyenDoi.Text = "🔄 Chuyển đổi dữ liệu";
            this.mnuThoat.Text = "🚪 Thoát";

            // ================== MENU QUẢN LÝ ==================
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuNhanVien,
                this.mnuKhachHang,     // ⭐ CHÈN KHÁCH HÀNG VÀO ĐÚNG VỊ TRÍ
                this.mnuTaiKhoan,
                this.mnuChamCong
            });
            this.mnuQuanLy.Text = "👥 Quản lý";

            this.mnuNhanVien.Text = "👤 Nhân viên";

            // ⭐ MENU KHÁCH HÀNG
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(262, 38);
            this.mnuKhachHang.Text = "🐱 Khách hàng";

            this.mnuTaiKhoan.Text = "🔑 Tài khoản";
            this.mnuChamCong.Text = "🕒 Chấm công";

            // ================== MENU SẢN PHẨM & DỊCH VỤ ==================
            this.mnuSanPhamDichVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuThuCung,
                this.mnuSanPham,
                this.mnuDichVu,
                this.mnuNhaCungCap
            });
            this.mnuSanPhamDichVu.Text = "🏪 Sản phẩm & Dịch vụ";

            this.mnuThuCung.Text = "🐶 Thú cưng";
            this.mnuSanPham.Text = "📦 Sản phẩm";
            this.mnuDichVu.Text = "✨ Dịch vụ";
            this.mnuNhaCungCap.Text = "🚚 Nhà cung cấp";

            // ================== MENU GIAO DỊCH ==================
            this.mnuGiaoDich.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuBanHang,
                this.mnuLichHen,
                this.mnuPhieuNhap,
                this.mnuHoaDon
            });
            this.mnuGiaoDich.Text = "💰 Giao dịch";

            this.mnuBanHang.Text = "🛒 Bán hàng";
            this.mnuLichHen.Text = "📅 Lịch hẹn";
            this.mnuPhieuNhap.Text = "📥 Phiếu nhập";
            this.mnuHoaDon.Text = "🧾 Hóa đơn";

            // ================== MENU BÁO CÁO ==================
            this.mnuBaoCao.Text = "📊 Báo cáo";

            // ================== HEADER ==================
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(253, 221, 230);
            this.pnlHeader.Controls.Add(this.lblGioDN);
            this.pnlHeader.Controls.Add(this.lblQuyen);
            this.pnlHeader.Controls.Add(this.lblTenNV);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(1200, 80);

            this.lblTenNV.Text = "Nhân viên: ---";
            this.lblQuyen.Text = "Quyền: ---";
            this.lblGioDN.Text = "Giờ đăng nhập: ---";

            // ================== MAIN PANEL ==================
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.BackColor = System.Drawing.Color.White;

            // ================== FORM ==================
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Cửa Hàng Thú Cưng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
