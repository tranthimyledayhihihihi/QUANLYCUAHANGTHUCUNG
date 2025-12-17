namespace QuanLyCuaHangThuCung.GUI
{
    partial class frmMainNew
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.Label lblGioDN;

        // ===== MENU =====
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuChuyenDoi;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;

        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuChamCong;

        private System.Windows.Forms.ToolStripMenuItem mnuSanPhamDichVu;
        private System.Windows.Forms.ToolStripMenuItem mnuThuCung;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuDichVu;

        private System.Windows.Forms.ToolStripMenuItem mnuGiaoDich;
        private System.Windows.Forms.ToolStripMenuItem mnuBanHang;
        private System.Windows.Forms.ToolStripMenuItem mnuLichHen;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieuNhap;

        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;

        // ===== DASHBOARD CONTROLS =====
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSystemInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChuyenDoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChamCong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPhamDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuCung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGiaoDich = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLichHen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblGioDN = new System.Windows.Forms.Label();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblSystemInfo = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(247)))), ((int)(((byte)(220)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuQuanLy,
            this.mnuSanPhamDichVu,
            this.mnuGiaoDich,
            this.mnuBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(1372, 41);
            this.menuStrip1.TabIndex = 2;
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChuyenDoi,
            this.mnuThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(130, 29);
            this.mnuHeThong.Text = "🏠 Hệ thống";
            // 
            // mnuChuyenDoi
            // 
            this.mnuChuyenDoi.Name = "mnuChuyenDoi";
            this.mnuChuyenDoi.Size = new System.Drawing.Size(283, 30);
            this.mnuChuyenDoi.Text = "🔄 Chuyển đổi dữ liệu";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(283, 30);
            this.mnuThoat.Text = "🚪 Thoát";
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVien,
            this.mnuKhachHang,
            this.mnuTaiKhoan,
            this.mnuChamCong});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(117, 29);
            this.mnuQuanLy.Text = "👥 Quản lý";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(224, 30);
            this.mnuNhanVien.Text = "👤 Nhân viên";
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(224, 30);
            this.mnuKhachHang.Text = "🐱 Khách hàng";
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(224, 30);
            this.mnuTaiKhoan.Text = "🔑 Tài khoản";
            // 
            // mnuChamCong
            // 
            this.mnuChamCong.Name = "mnuChamCong";
            this.mnuChamCong.Size = new System.Drawing.Size(224, 30);
            this.mnuChamCong.Text = "🕒 Chấm công";
            this.mnuChamCong.Click += new System.EventHandler(this.mnuChamCong_Click);
            // 
            // mnuSanPhamDichVu
            // 
            this.mnuSanPhamDichVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThuCung,
            this.mnuSanPham,
            this.mnuDichVu});
            this.mnuSanPhamDichVu.Name = "mnuSanPhamDichVu";
            this.mnuSanPhamDichVu.Size = new System.Drawing.Size(209, 29);
            this.mnuSanPhamDichVu.Text = "🏪 Sản phẩm & Dịch vụ";
            // 
            // mnuThuCung
            // 
            this.mnuThuCung.Name = "mnuThuCung";
            this.mnuThuCung.Size = new System.Drawing.Size(208, 30);
            this.mnuThuCung.Text = "🐶 Thú cưng";
            // 
            // mnuSanPham
            // 
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.Size = new System.Drawing.Size(208, 30);
            this.mnuSanPham.Text = "📦 Sản phẩm";
            // 
            // mnuDichVu
            // 
            this.mnuDichVu.Name = "mnuDichVu";
            this.mnuDichVu.Size = new System.Drawing.Size(208, 30);
            this.mnuDichVu.Text = "✨ Dịch vụ";
            // 
            // mnuGiaoDich
            // 
            this.mnuGiaoDich.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBanHang,
            this.mnuLichHen,
            this.mnuPhieuNhap});
            this.mnuGiaoDich.Name = "mnuGiaoDich";
            this.mnuGiaoDich.Size = new System.Drawing.Size(132, 29);
            this.mnuGiaoDich.Text = "💰 Giao dịch";
            // 
            // mnuBanHang
            // 
            this.mnuBanHang.Name = "mnuBanHang";
            this.mnuBanHang.Size = new System.Drawing.Size(220, 30);
            this.mnuBanHang.Text = "🛒 Bán hàng";
            // 
            // mnuLichHen
            // 
            this.mnuLichHen.Name = "mnuLichHen";
            this.mnuLichHen.Size = new System.Drawing.Size(220, 30);
            this.mnuLichHen.Text = "📅 Lịch hẹn";
            // 
            // mnuPhieuNhap
            // 
            this.mnuPhieuNhap.Name = "mnuPhieuNhap";
            this.mnuPhieuNhap.Size = new System.Drawing.Size(220, 30);
            this.mnuPhieuNhap.Text = "📥 Phiếu nhập";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(119, 29);
            this.mnuBaoCao.Text = "📊 Báo cáo";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(221)))), ((int)(((byte)(230)))));
            this.pnlHeader.Controls.Add(this.lblGioDN);
            this.pnlHeader.Controls.Add(this.lblQuyen);
            this.pnlHeader.Controls.Add(this.lblTenNV);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 41);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1372, 96);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblGioDN
            // 
            this.lblGioDN.AutoSize = true;
            this.lblGioDN.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblGioDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblGioDN.Location = new System.Drawing.Point(23, 70);
            this.lblGioDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioDN.Name = "lblGioDN";
            this.lblGioDN.Size = new System.Drawing.Size(164, 21);
            this.lblGioDN.TabIndex = 2;
            this.lblGioDN.Text = "🕐 Giờ đăng nhập: ---";
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblQuyen.Location = new System.Drawing.Point(23, 45);
            this.lblQuyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(118, 23);
            this.lblQuyen.TabIndex = 1;
            this.lblQuyen.Text = "🔐 Quyền: ---";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTenNV.Location = new System.Drawing.Point(23, 16);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(163, 25);
            this.lblTenNV.TabIndex = 0;
            this.lblTenNV.Text = "👤 Nhân viên: ---";
            this.lblTenNV.Click += new System.EventHandler(this.lblTenNV_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.pnlMain.BackgroundImage = global::QUANLYCUAHANGTHUCUNG.Properties.Resources.Pastel_paws_and_hearts_pattern_background_for_pets___Premium_Vector;
            this.pnlMain.Controls.Add(this.pnlDashboard);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 137);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(23, 22, 23, 22);
            this.pnlMain.Size = new System.Drawing.Size(1372, 609);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.Transparent;
            this.pnlDashboard.Controls.Add(this.pnlCard4);
            this.pnlDashboard.Controls.Add(this.pnlCard3);
            this.pnlDashboard.Controls.Add(this.pnlCard2);
            this.pnlDashboard.Controls.Add(this.pnlCard1);
            this.pnlDashboard.Controls.Add(this.lblSystemInfo);
            this.pnlDashboard.Controls.Add(this.lblWelcome);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(23, 22);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Padding = new System.Windows.Forms.Padding(35, 32, 35, 32);
            this.pnlDashboard.Size = new System.Drawing.Size(1326, 565);
            this.pnlDashboard.TabIndex = 0;
            // 
            // pnlCard4
            // 
            this.pnlCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(251)))), ((int)(((byte)(152)))));
            this.pnlCard4.Location = new System.Drawing.Point(1017, 192);
            this.pnlCard4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Size = new System.Drawing.Size(285, 160);
            this.pnlCard4.TabIndex = 5;
            this.pnlCard4.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard4_Paint);
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(160)))), ((int)(((byte)(221)))));
            this.pnlCard3.Location = new System.Drawing.Point(697, 192);
            this.pnlCard3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(285, 160);
            this.pnlCard3.TabIndex = 4;
            this.pnlCard3.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard3_Paint);
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.pnlCard2.Location = new System.Drawing.Point(377, 192);
            this.pnlCard2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(285, 160);
            this.pnlCard2.TabIndex = 3;
            this.pnlCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard2_Paint);
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(193)))));
            this.pnlCard1.Location = new System.Drawing.Point(57, 192);
            this.pnlCard1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(285, 160);
            this.pnlCard1.TabIndex = 2;
            this.pnlCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard1_Paint);
            // 
            // lblSystemInfo
            // 
            this.lblSystemInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSystemInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSystemInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblSystemInfo.Location = new System.Drawing.Point(35, 118);
            this.lblSystemInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystemInfo.Name = "lblSystemInfo";
            this.lblSystemInfo.Size = new System.Drawing.Size(1256, 42);
            this.lblSystemInfo.TabIndex = 1;
            this.lblSystemInfo.Text = "Vui lòng chọn chức năng từ menu phía trên";
            this.lblSystemInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(112)))), ((int)(((byte)(140)))));
            this.lblWelcome.Location = new System.Drawing.Point(35, 32);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1256, 86);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "🐾 HỆ THỐNG QUẢN LÝ THÚ CƯNG";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmMainNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 746);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1139, 634);
            this.Name = "frmMainNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🐾 QUẢN LÝ CỬA HÀNG THÚ CƯNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainNew_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Event handlers cho các card
        private void pnlCard1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Vẽ icon và text
            using (var font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold))
            using (var brush = new System.Drawing.SolidBrush(System.Drawing.Color.White))
            {
                g.DrawString("👥", font, brush, new System.Drawing.PointF(15, 15));
                g.DrawString("NHÂN VIÊN", new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold), brush, new System.Drawing.PointF(15, 60));
                g.DrawString("Quản lý nhân sự", new System.Drawing.Font("Segoe UI", 9F), brush, new System.Drawing.PointF(15, 90));
            }
        }

        private void pnlCard2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (var font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold))
            using (var brush = new System.Drawing.SolidBrush(System.Drawing.Color.White))
            {
                g.DrawString("🐶", font, brush, new System.Drawing.PointF(15, 15));
                g.DrawString("THÚ CƯNG", new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold), brush, new System.Drawing.PointF(15, 60));
                g.DrawString("Quản lý kho thú cưng", new System.Drawing.Font("Segoe UI", 9F), brush, new System.Drawing.PointF(15, 90));
            }
        }

        private void pnlCard3_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (var font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold))
            using (var brush = new System.Drawing.SolidBrush(System.Drawing.Color.White))
            {
                g.DrawString("🛒", font, brush, new System.Drawing.PointF(15, 15));
                g.DrawString("BÁN HÀNG", new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold), brush, new System.Drawing.PointF(15, 60));
                g.DrawString("Tạo hóa đơn bán", new System.Drawing.Font("Segoe UI", 9F), brush, new System.Drawing.PointF(15, 90));
            }
        }

        private void pnlCard4_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (var font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold))
            using (var brush = new System.Drawing.SolidBrush(System.Drawing.Color.White))
            {
                g.DrawString("📊", font, brush, new System.Drawing.PointF(15, 15));
                g.DrawString("BÁO CÁO", new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold), brush, new System.Drawing.PointF(15, 60));
                g.DrawString("Thống kê doanh thu", new System.Drawing.Font("Segoe UI", 9F), brush, new System.Drawing.PointF(15, 90));
            }
        }

        private System.Windows.Forms.ImageList imageList1;
    }
}