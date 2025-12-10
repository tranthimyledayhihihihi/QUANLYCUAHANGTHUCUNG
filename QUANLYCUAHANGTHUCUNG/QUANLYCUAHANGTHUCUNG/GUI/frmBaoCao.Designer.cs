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
            this.btnTKNgay = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();

            this.grpFilterMonth = new System.Windows.Forms.GroupBox();
            this.btnTKThang = new System.Windows.Forms.Button();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();

            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblThuCungDaBan = new System.Windows.Forms.Label();
            this.lblSanPhamDaBan = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblTongHoaDon = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();

            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();

            this.tabThuCung = new System.Windows.Forms.TabPage();
            this.dgvThuCung = new System.Windows.Forms.DataGridView();

            this.tabHoaDon = new System.Windows.Forms.TabPage();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnInHD = new System.Windows.Forms.Button();

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
            // ------------------------------------------------------
            // TAB CONTROL
            // ------------------------------------------------------
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Controls.Add(this.tabDashboard);
            this.tabControl1.Controls.Add(this.tabSanPham);
            this.tabControl1.Controls.Add(this.tabThuCung);
            this.tabControl1.Controls.Add(this.tabHoaDon);

            // ====== TÊN TAB ======
            this.tabDashboard.Text = "📊 Dashboard";
            this.tabSanPham.Text = "📦 Sản phẩm";
            this.tabThuCung.Text = "🐾 Thú cưng";
            this.tabHoaDon.Text = "🧾 Hóa đơn";

            // ------------------------------------------------------
            // TAB DASHBOARD
            // ------------------------------------------------------
            this.tabDashboard.BackColor = System.Drawing.Color.White;
            this.tabDashboard.Controls.Add(this.chartDoanhThu);
            this.tabDashboard.Controls.Add(this.grpFilterDate);
            this.tabDashboard.Controls.Add(this.grpFilterMonth);
            this.tabDashboard.Controls.Add(this.grpSummary);

            // BIỂU ĐỒ
            this.chartDoanhThu.Location = new System.Drawing.Point(10, 260);
            this.chartDoanhThu.Size = new System.Drawing.Size(980, 360);
            this.chartDoanhThu.BackColor = System.Drawing.Color.WhiteSmoke;

            // GROUP: Filter theo ngày
            this.grpFilterDate.Text = "Thống kê theo ngày";
            this.grpFilterDate.Location = new System.Drawing.Point(10, 10);
            this.grpFilterDate.Size = new System.Drawing.Size(450, 100);

            this.lblFrom.Text = "Từ ngày:";
            this.lblFrom.Location = new System.Drawing.Point(10, 30);

            this.dtFrom.Location = new System.Drawing.Point(90, 25);

            this.lblTo.Text = "Đến ngày:";
            this.lblTo.Location = new System.Drawing.Point(10, 65);

            this.dtTo.Location = new System.Drawing.Point(90, 60);

            this.btnTKNgay.Text = "Thống kê";
            this.btnTKNgay.Location = new System.Drawing.Point(320, 40);
            this.btnTKNgay.Click += new System.EventHandler(this.btnTKNgay_Click);

            this.grpFilterDate.Controls.Add(this.lblFrom);
            this.grpFilterDate.Controls.Add(this.dtFrom);
            this.grpFilterDate.Controls.Add(this.lblTo);
            this.grpFilterDate.Controls.Add(this.dtTo);
            this.grpFilterDate.Controls.Add(this.btnTKNgay);

            // GROUP: Filter tháng
            this.grpFilterMonth.Text = "Thống kê theo tháng";
            this.grpFilterMonth.Location = new System.Drawing.Point(480, 10);
            this.grpFilterMonth.Size = new System.Drawing.Size(450, 100);

            this.label3.Text = "Tháng:";
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.cboThang.Location = new System.Drawing.Point(100, 20);

            this.label4.Text = "Năm:";
            this.label4.Location = new System.Drawing.Point(20, 55);
            this.cboNam.Location = new System.Drawing.Point(100, 50);

            this.btnTKThang.Text = "Thống kê";
            this.btnTKThang.Location = new System.Drawing.Point(320, 35);
            this.btnTKThang.Click += new System.EventHandler(this.btnTKThang_Click);

            this.grpFilterMonth.Controls.Add(this.label3);
            this.grpFilterMonth.Controls.Add(this.cboThang);
            this.grpFilterMonth.Controls.Add(this.label4);
            this.grpFilterMonth.Controls.Add(this.cboNam);
            this.grpFilterMonth.Controls.Add(this.btnTKThang);

            // GROUP: Tổng quan
            this.grpSummary.Text = "Tổng quan";
            this.grpSummary.Location = new System.Drawing.Point(10, 120);
            this.grpSummary.Size = new System.Drawing.Size(980, 130);

            this.label5.Text = "Tổng hóa đơn:";
            this.label5.Location = new System.Drawing.Point(20, 30);
            this.lblTongHoaDon.Location = new System.Drawing.Point(160, 30);

            this.label6.Text = "Tổng doanh thu:";
            this.label6.Location = new System.Drawing.Point(20, 70);
            this.lblTongDoanhThu.Location = new System.Drawing.Point(160, 70);

            this.label7.Text = "Sản phẩm đã bán:";
            this.label7.Location = new System.Drawing.Point(450, 30);
            this.lblSanPhamDaBan.Location = new System.Drawing.Point(620, 30);

            this.label8.Text = "Thú cưng đã bán:";
            this.label8.Location = new System.Drawing.Point(450, 70);
            this.lblThuCungDaBan.Location = new System.Drawing.Point(620, 70);

            this.grpSummary.Controls.Add(this.label5);
            this.grpSummary.Controls.Add(this.lblTongHoaDon);
            this.grpSummary.Controls.Add(this.label6);
            this.grpSummary.Controls.Add(this.lblTongDoanhThu);
            this.grpSummary.Controls.Add(this.label7);
            this.grpSummary.Controls.Add(this.lblSanPhamDaBan);
            this.grpSummary.Controls.Add(this.label8);
            this.grpSummary.Controls.Add(this.lblThuCungDaBan);

            // ------------------------------------------------------
            // TAB SẢN PHẨM
            // ------------------------------------------------------
            this.tabSanPham.BackColor = System.Drawing.Color.White;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSanPham.Controls.Add(this.dgvSanPham);

            // ------------------------------------------------------
            // TAB THÚ CƯNG
            // ------------------------------------------------------
            this.tabThuCung.BackColor = System.Drawing.Color.White;
            this.dgvThuCung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabThuCung.Controls.Add(this.dgvThuCung);

            // ------------------------------------------------------
            // TAB HÓA ĐƠN
            // ------------------------------------------------------
            this.tabHoaDon.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvHoaDon.Height = 450;

            this.btnInHD.Text = "In hóa đơn";
            this.btnInHD.Location = new System.Drawing.Point(50, 470);
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);

            this.tabHoaDon.Controls.Add(this.btnInHD);
            this.tabHoaDon.Controls.Add(this.dgvHoaDon);

            // ------------------------------------------------------
            // FORM
            // ------------------------------------------------------
            this.ClientSize = new System.Drawing.Size(1020, 650);
            this.Controls.Add(this.tabControl1);
            this.Text = "Báo Cáo Thống Kê";

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
