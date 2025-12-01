namespace QuanLyCuaHangThuCung.GUI
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();

            // MENU CẤP 1
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGiaoDich = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCao = new System.Windows.Forms.ToolStripMenuItem();

            // MENU CON - HỆ THỐNG
            this.menuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaoLuu = new System.Windows.Forms.ToolStripMenuItem(); // Sao lưu/Phục hồi
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();

            // MENU CON - QUẢN LÝ
            this.menuNhanVien = new System.Windows.Forms.ToolStripMenuItem(); // Tên biến: menuQuanLyNhanVien trong code logic
            this.menuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThuCung = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDichVu = new System.Windows.Forms.ToolStripMenuItem();

            // MENU CON - GIAO DỊCH
            this.menuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLichHen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhapHang = new System.Windows.Forms.ToolStripMenuItem();

            // MENU CON - BÁO CÁO
            this.menuDoanhThu = new System.Windows.Forms.ToolStripMenuItem();

            // Status Strip
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);

            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuQuanLy,
            this.menuGiaoDich,
            this.menuBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";

            // --- 1. HỆ THỐNG ---
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDoiMatKhau,
            this.menuSaoLuu,
            this.menuDangXuat,
            this.menuThoat});
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Text = "Hệ Thống";

            this.menuDoiMatKhau.Name = "menuDoiMatKhau";
            this.menuDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.menuDoiMatKhau.Click += new System.EventHandler(this.menuDoiMatKhau_Click);

            this.menuSaoLuu.Name = "menuSaoLuu";
            this.menuSaoLuu.Text = "Sao Lưu / Phục Hồi";
            this.menuSaoLuu.Click += new System.EventHandler(this.menuSaoLuu_Click);

            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Text = "Đăng Xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);

            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);

            // --- 2. QUẢN LÝ ---
            this.menuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhanVien,
            this.menuKhachHang,
            this.menuThuCung,
            this.menuSanPham,
            this.menuDichVu});
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Text = "Quản Lý Danh Mục";

            this.menuNhanVien.Name = "menuQuanLyNhanVien"; // ID Khớp code logic
            this.menuNhanVien.Text = "Nhân Viên";
            this.menuNhanVien.Click += new System.EventHandler(this.menuNhanVien_Click);

            this.menuKhachHang.Name = "menuKhachHang";
            this.menuKhachHang.Text = "Khách Hàng";
            this.menuKhachHang.Click += new System.EventHandler(this.menuKhachHang_Click);

            this.menuThuCung.Name = "menuThuCung";
            this.menuThuCung.Text = "Thú Cưng";
            this.menuThuCung.Click += new System.EventHandler(this.menuThuCung_Click);

            this.menuSanPham.Name = "menuSanPham";
            this.menuSanPham.Text = "Sản Phẩm";
            this.menuSanPham.Click += new System.EventHandler(this.menuSanPham_Click);

            this.menuDichVu.Name = "menuDichVu";
            this.menuDichVu.Text = "Dịch Vụ";
            this.menuDichVu.Click += new System.EventHandler(this.menuDichVu_Click);

            // --- 3. GIAO DỊCH ---
            this.menuGiaoDich.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBanHang,
            this.menuLichHen,
            this.menuNhapHang});
            this.menuGiaoDich.Name = "menuGiaoDich";
            this.menuGiaoDich.Text = "Giao Dịch";

            this.menuBanHang.Name = "menuBanHang";
            this.menuBanHang.Text = "Bán Hàng & Dịch Vụ";
            this.menuBanHang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B))); // Phím tắt Ctrl+B
            this.menuBanHang.Click += new System.EventHandler(this.menuBanHang_Click);

            this.menuLichHen.Name = "menuLichHen";
            this.menuLichHen.Text = "Lịch Hẹn";
            this.menuLichHen.Click += new System.EventHandler(this.menuLichHen_Click);

            this.menuNhapHang.Name = "menuNhapHang";
            this.menuNhapHang.Text = "Nhập Hàng";
            this.menuNhapHang.Click += new System.EventHandler(this.menuNhapHang_Click);

            // --- 4. BÁO CÁO ---
            this.menuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDoanhThu});
            this.menuBaoCao.Name = "menuBaoCao";
            this.menuBaoCao.Text = "Báo Cáo";

            this.menuDoanhThu.Name = "menuDoanhThu";
            this.menuDoanhThu.Text = "Doanh Thu & Tồn Kho";
            this.menuDoanhThu.Click += new System.EventHandler(this.menuDoanhThu_Click);

            // Status Strip
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNguoiDung,
            this.lblThoiGian});
            this.statusStrip1.Location = new System.Drawing.Point(0, 674);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1200, 26);
            this.statusStrip1.TabIndex = 2;

            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(100, 20);
            this.lblNguoiDung.Text = "User: ...";

            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(100, 20);
            this.lblThoiGian.Text = "Time: ...";
            this.lblThoiGian.Spring = true;
            this.lblThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // Timer
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true; // QUAN TRỌNG: Để chứa các form con
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "HỆ THỐNG QUẢN LÝ CỬA HÀNG THÚ CƯNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuSaoLuu;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;

        private System.Windows.Forms.ToolStripMenuItem menuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem menuThuCung;
        private System.Windows.Forms.ToolStripMenuItem menuSanPham;
        private System.Windows.Forms.ToolStripMenuItem menuDichVu;

        private System.Windows.Forms.ToolStripMenuItem menuGiaoDich;
        private System.Windows.Forms.ToolStripMenuItem menuBanHang;
        private System.Windows.Forms.ToolStripMenuItem menuLichHen;
        private System.Windows.Forms.ToolStripMenuItem menuNhapHang;

        private System.Windows.Forms.ToolStripMenuItem menuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem menuDoanhThu;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNguoiDung;
        private System.Windows.Forms.ToolStripStatusLabel lblThoiGian;
        private System.Windows.Forms.Timer timer1;
    }
}