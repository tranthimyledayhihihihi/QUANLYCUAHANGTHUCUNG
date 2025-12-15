namespace QuanLyCuaHangThuCung
{
    partial class frmBaoCao
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpFilterDate = new System.Windows.Forms.GroupBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnTKNgay = new System.Windows.Forms.Button();
            this.grpFilterMonth = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.btnTKThang = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongHoaDon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSanPhamDaBan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblThuCungDaBan = new System.Windows.Forms.Label();
            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.tabThuCung = new System.Windows.Forms.TabPage();
            this.dgvThuCung = new System.Windows.Forms.DataGridView();
            this.tabHoaDon = new System.Windows.Forms.TabPage();
            this.btnInHD = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.grpFilterDate.SuspendLayout();
            this.grpFilterMonth.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.tabSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.tabThuCung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).BeginInit();
            this.tabHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDashboard);
            this.tabControl1.Controls.Add(this.tabSanPham);
            this.tabControl1.Controls.Add(this.tabThuCung);
            this.tabControl1.Controls.Add(this.tabHoaDon);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 668);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            this.tabDashboard.BackColor = System.Drawing.Color.Azure;
            this.tabDashboard.Controls.Add(this.chartDoanhThu);
            this.tabDashboard.Controls.Add(this.grpFilterDate);
            this.tabDashboard.Controls.Add(this.grpFilterMonth);
            this.tabDashboard.Controls.Add(this.grpSummary);
            this.tabDashboard.Location = new System.Drawing.Point(4, 32);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Size = new System.Drawing.Size(1012, 632);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "📊 Dashboard";
            // 
            // chartDoanhThu
            // 
            this.chartDoanhThu.BackColor = System.Drawing.Color.MistyRose;
            this.chartDoanhThu.Location = new System.Drawing.Point(10, 260);
            this.chartDoanhThu.Name = "chartDoanhThu";
            this.chartDoanhThu.Size = new System.Drawing.Size(980, 360);
            this.chartDoanhThu.TabIndex = 0;
            // 
            // grpFilterDate
            // 
            this.grpFilterDate.BackColor = System.Drawing.Color.Lavender;
            this.grpFilterDate.Controls.Add(this.lblFrom);
            this.grpFilterDate.Controls.Add(this.dtFrom);
            this.grpFilterDate.Controls.Add(this.lblTo);
            this.grpFilterDate.Controls.Add(this.dtTo);
            this.grpFilterDate.Controls.Add(this.btnTKNgay);
            this.grpFilterDate.Location = new System.Drawing.Point(10, 10);
            this.grpFilterDate.Name = "grpFilterDate";
            this.grpFilterDate.Size = new System.Drawing.Size(451, 100);
            this.grpFilterDate.TabIndex = 1;
            this.grpFilterDate.TabStop = false;
            this.grpFilterDate.Text = "Thống kê theo ngày";
            // 
            // lblFrom
            // 
            this.lblFrom.Location = new System.Drawing.Point(10, 30);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(76, 23);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Từ ngày:";
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(107, 25);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 30);
            this.dtFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.Location = new System.Drawing.Point(10, 65);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(90, 23);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "Đến ngày:";
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(107, 58);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 30);
            this.dtTo.TabIndex = 3;
            // 
            // btnTKNgay
            // 
            this.btnTKNgay.Location = new System.Drawing.Point(313, 35);
            this.btnTKNgay.Name = "btnTKNgay";
            this.btnTKNgay.Size = new System.Drawing.Size(75, 23);
            this.btnTKNgay.TabIndex = 4;
            this.btnTKNgay.Text = "Thống kê";
            this.btnTKNgay.Click += new System.EventHandler(this.btnTKNgay_Click);
            // 
            // grpFilterMonth
            // 
            this.grpFilterMonth.BackColor = System.Drawing.Color.Lavender;
            this.grpFilterMonth.Controls.Add(this.label3);
            this.grpFilterMonth.Controls.Add(this.cboThang);
            this.grpFilterMonth.Controls.Add(this.label4);
            this.grpFilterMonth.Controls.Add(this.cboNam);
            this.grpFilterMonth.Controls.Add(this.btnTKThang);
            this.grpFilterMonth.Location = new System.Drawing.Point(480, 10);
            this.grpFilterMonth.Name = "grpFilterMonth";
            this.grpFilterMonth.Size = new System.Drawing.Size(450, 100);
            this.grpFilterMonth.TabIndex = 2;
            this.grpFilterMonth.TabStop = false;
            this.grpFilterMonth.Text = "Thống kê theo tháng";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tháng:";
            // 
            // cboThang
            // 
            this.cboThang.Location = new System.Drawing.Point(100, 21);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(121, 31);
            this.cboThang.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Năm:";
            // 
            // cboNam
            // 
            this.cboNam.Location = new System.Drawing.Point(100, 50);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(121, 31);
            this.cboNam.TabIndex = 3;
            // 
            // btnTKThang
            // 
            this.btnTKThang.Location = new System.Drawing.Point(320, 35);
            this.btnTKThang.Name = "btnTKThang";
            this.btnTKThang.Size = new System.Drawing.Size(75, 23);
            this.btnTKThang.TabIndex = 4;
            this.btnTKThang.Text = "Thống kê";
            this.btnTKThang.Click += new System.EventHandler(this.btnTKThang_Click);
            // 
            // grpSummary
            // 
            this.grpSummary.BackColor = System.Drawing.Color.Ivory;
            this.grpSummary.Controls.Add(this.label5);
            this.grpSummary.Controls.Add(this.lblTongHoaDon);
            this.grpSummary.Controls.Add(this.label6);
            this.grpSummary.Controls.Add(this.lblTongDoanhThu);
            this.grpSummary.Controls.Add(this.label7);
            this.grpSummary.Controls.Add(this.lblSanPhamDaBan);
            this.grpSummary.Controls.Add(this.label8);
            this.grpSummary.Controls.Add(this.lblThuCungDaBan);
            this.grpSummary.Location = new System.Drawing.Point(10, 120);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(980, 130);
            this.grpSummary.TabIndex = 3;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Tổng quan";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng hóa đơn:";
            // 
            // lblTongHoaDon
            // 
            this.lblTongHoaDon.Location = new System.Drawing.Point(160, 30);
            this.lblTongHoaDon.Name = "lblTongHoaDon";
            this.lblTongHoaDon.Size = new System.Drawing.Size(100, 23);
            this.lblTongHoaDon.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tổng doanh thu:";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.Location = new System.Drawing.Point(160, 70);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(100, 23);
            this.lblTongDoanhThu.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(450, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sản phẩm đã bán:";
            // 
            // lblSanPhamDaBan
            // 
            this.lblSanPhamDaBan.Location = new System.Drawing.Point(620, 30);
            this.lblSanPhamDaBan.Name = "lblSanPhamDaBan";
            this.lblSanPhamDaBan.Size = new System.Drawing.Size(100, 23);
            this.lblSanPhamDaBan.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(450, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Thú cưng đã bán:";
            // 
            // lblThuCungDaBan
            // 
            this.lblThuCungDaBan.Location = new System.Drawing.Point(620, 70);
            this.lblThuCungDaBan.Name = "lblThuCungDaBan";
            this.lblThuCungDaBan.Size = new System.Drawing.Size(100, 23);
            this.lblThuCungDaBan.TabIndex = 7;
            // 
            // tabSanPham
            // 
            this.tabSanPham.BackColor = System.Drawing.Color.White;
            this.tabSanPham.Controls.Add(this.dgvSanPham);
            this.tabSanPham.Location = new System.Drawing.Point(4, 32);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Size = new System.Drawing.Size(192, 64);
            this.tabSanPham.TabIndex = 1;
            this.tabSanPham.Text = "📦 Sản phẩm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeight = 29;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.Size = new System.Drawing.Size(240, 150);
            this.dgvSanPham.TabIndex = 0;
            // 
            // tabThuCung
            // 
            this.tabThuCung.BackColor = System.Drawing.Color.White;
            this.tabThuCung.Controls.Add(this.dgvThuCung);
            this.tabThuCung.Location = new System.Drawing.Point(4, 32);
            this.tabThuCung.Name = "tabThuCung";
            this.tabThuCung.Size = new System.Drawing.Size(192, 64);
            this.tabThuCung.TabIndex = 2;
            this.tabThuCung.Text = "🐾 Thú cưng";
            // 
            // dgvThuCung
            // 
            this.dgvThuCung.ColumnHeadersHeight = 29;
            this.dgvThuCung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThuCung.Location = new System.Drawing.Point(0, 0);
            this.dgvThuCung.Name = "dgvThuCung";
            this.dgvThuCung.RowHeadersWidth = 51;
            this.dgvThuCung.Size = new System.Drawing.Size(240, 150);
            this.dgvThuCung.TabIndex = 0;
            // 
            // tabHoaDon
            // 
            this.tabHoaDon.BackColor = System.Drawing.Color.White;
            this.tabHoaDon.Controls.Add(this.btnInHD);
            this.tabHoaDon.Controls.Add(this.dgvHoaDon);
            this.tabHoaDon.Location = new System.Drawing.Point(4, 32);
            this.tabHoaDon.Name = "tabHoaDon";
            this.tabHoaDon.Size = new System.Drawing.Size(192, 64);
            this.tabHoaDon.TabIndex = 3;
            this.tabHoaDon.Text = "🧾 Hóa đơn";
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(50, 470);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(75, 23);
            this.btnInHD.TabIndex = 0;
            this.btnInHD.Text = "In hóa đơn";
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeight = 29;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.Size = new System.Drawing.Size(240, 450);
            this.dgvHoaDon.TabIndex = 1;
            // 
            // frmBaoCao
            // 
            this.ClientSize = new System.Drawing.Size(1020, 668);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmBaoCao";
            this.Text = "Báo Cáo Thống Kê";
            this.tabControl1.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.grpFilterDate.ResumeLayout(false);
            this.grpFilterMonth.ResumeLayout(false);
            this.grpSummary.ResumeLayout(false);
            this.tabSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.tabThuCung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).EndInit();
            this.tabHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabSanPham;
        private System.Windows.Forms.TabPage tabThuCung;
        private System.Windows.Forms.TabPage tabHoaDon;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.GroupBox grpFilterDate;
        private System.Windows.Forms.GroupBox grpFilterMonth;
        private System.Windows.Forms.GroupBox grpSummary;

        private System.Windows.Forms.Label lblFrom, lblTo;
        private System.Windows.Forms.Label lblTongHoaDon, lblTongDoanhThu;
        private System.Windows.Forms.Label lblSanPhamDaBan, lblThuCungDaBan;

        private System.Windows.Forms.Label label3, label4, label5, label6, label7, label8;

        private System.Windows.Forms.ComboBox cboThang, cboNam;
        private System.Windows.Forms.DateTimePicker dtFrom, dtTo;

        private System.Windows.Forms.Button btnTKNgay, btnTKThang;
        private System.Windows.Forms.Button btnInHD;

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridView dgvThuCung;
        private System.Windows.Forms.DataGridView dgvHoaDon;
    }
}
