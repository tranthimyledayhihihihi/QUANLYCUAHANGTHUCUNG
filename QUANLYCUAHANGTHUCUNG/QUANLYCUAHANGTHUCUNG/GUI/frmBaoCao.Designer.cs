namespace QuanLyCuaHangThuCung.GUI
{
    partial class frmBaoCao
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.tabControlBaoCao = new System.Windows.Forms.TabControl();

            // --- Tab Doanh Thu ---
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.panelTopDoanhThu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXemDoanhThu = new System.Windows.Forms.Button();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();

            // --- Tab Tồn Kho ---
            this.tabTonKho = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTonKho = new System.Windows.Forms.DataGridView();

            // --- Tab Thú Cưng ---
            this.tabThuCung = new System.Windows.Forms.TabPage();
            this.dgvThuCung = new System.Windows.Forms.DataGridView();
            this.chartThuCung = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();

            this.tabControlBaoCao.SuspendLayout();
            this.tabDoanhThu.SuspendLayout();
            this.panelTopDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.tabTonKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).BeginInit();
            this.tabThuCung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThuCung)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControlBaoCao
            // 
            this.tabControlBaoCao.Controls.Add(this.tabDoanhThu);
            this.tabControlBaoCao.Controls.Add(this.tabTonKho);
            this.tabControlBaoCao.Controls.Add(this.tabThuCung);
            this.tabControlBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControlBaoCao.Location = new System.Drawing.Point(0, 0);
            this.tabControlBaoCao.Name = "tabControlBaoCao";
            this.tabControlBaoCao.SelectedIndex = 0;
            this.tabControlBaoCao.Size = new System.Drawing.Size(1000, 600);
            this.tabControlBaoCao.TabIndex = 0;

            // 
            // --- SETUP TAB DOANH THU ---
            // 
            this.tabDoanhThu.Controls.Add(this.chartDoanhThu);
            this.tabDoanhThu.Controls.Add(this.dgvDoanhThu);
            this.tabDoanhThu.Controls.Add(this.panelTopDoanhThu);
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 29);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoanhThu.Text = "Doanh Thu";
            this.tabDoanhThu.UseVisualStyleBackColor = true;

            // Panel Filter
            this.panelTopDoanhThu.Controls.Add(this.lblTongDoanhThu);
            this.panelTopDoanhThu.Controls.Add(this.label3);
            this.panelTopDoanhThu.Controls.Add(this.btnXemDoanhThu);
            this.panelTopDoanhThu.Controls.Add(this.dtpDenNgay);
            this.panelTopDoanhThu.Controls.Add(this.label2);
            this.panelTopDoanhThu.Controls.Add(this.dtpTuNgay);
            this.panelTopDoanhThu.Controls.Add(this.label1);
            this.panelTopDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopDoanhThu.Height = 80;
            this.panelTopDoanhThu.BackColor = System.Drawing.Color.WhiteSmoke;

            this.label1.AutoSize = true; this.label1.Location = new System.Drawing.Point(20, 30); this.label1.Text = "Từ ngày:";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(100, 27); this.dtpTuNgay.Size = new System.Drawing.Size(120, 26);

            this.label2.AutoSize = true; this.label2.Location = new System.Drawing.Point(240, 30); this.label2.Text = "Đến ngày:";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(330, 27); this.dtpDenNgay.Size = new System.Drawing.Size(120, 26);

            this.btnXemDoanhThu.Text = "Xem Báo Cáo";
            this.btnXemDoanhThu.Location = new System.Drawing.Point(470, 25);
            this.btnXemDoanhThu.Size = new System.Drawing.Size(150, 30);
            this.btnXemDoanhThu.Click += new System.EventHandler(this.btnXemDoanhThu_Click);

            this.label3.AutoSize = true; this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(650, 28); this.label3.Text = "Tổng thu:";

            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(750, 26);
            this.lblTongDoanhThu.Text = "0 VNĐ";

            // Grid Doanh Thu (Trái)
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDoanhThu.Width = 400;
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Chart Doanh Thu (Phải)
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column; // Biểu đồ Cột
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Titles.Add("Biểu đồ doanh thu theo ngày");

            // 
            // --- SETUP TAB TỒN KHO ---
            // 
            this.tabTonKho.Controls.Add(this.dgvTonKho);
            this.tabTonKho.Controls.Add(this.label4);
            this.tabTonKho.Location = new System.Drawing.Point(4, 29);
            this.tabTonKho.Name = "tabTonKho";
            this.tabTonKho.Text = "Cảnh Báo Tồn Kho";
            this.tabTonKho.UseVisualStyleBackColor = true;

            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Height = 40;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Text = "DANH SÁCH SẢN PHẨM SẮP HẾT HÀNG (<10)";

            this.dgvTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTonKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // --- SETUP TAB THÚ CƯNG ---
            // 
            this.tabThuCung.Controls.Add(this.chartThuCung);
            this.tabThuCung.Controls.Add(this.dgvThuCung);
            this.tabThuCung.Controls.Add(this.label5);
            this.tabThuCung.Location = new System.Drawing.Point(4, 29);
            this.tabThuCung.Name = "tabThuCung";
            this.tabThuCung.Text = "Thống Kê Thú Cưng";
            this.tabThuCung.UseVisualStyleBackColor = true;

            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Height = 40;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Text = "TÌNH TRẠNG THÚ CƯNG TẠI CỬA HÀNG";

            this.dgvThuCung.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvThuCung.Width = 500;
            this.dgvThuCung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Chart Thú Cưng (Phải)
            chartArea2.Name = "ChartArea2";
            this.chartThuCung.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend2";
            this.chartThuCung.Legends.Add(legend2);
            this.chartThuCung.Dock = System.Windows.Forms.DockStyle.Fill;
            series2.ChartArea = "ChartArea2";
            series2.Legend = "Legend2";
            series2.Name = "TrangThai";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie; // Biểu đồ Tròn
            series2.IsValueShownAsLabel = true; // Hiện số %
            this.chartThuCung.Series.Add(series2);
            this.chartThuCung.Titles.Add("Tỷ lệ Bán / Tồn");

            // 
            // Form Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabControlBaoCao);
            this.Name = "frmBaoCao";
            this.Text = "Báo Cáo Thống Kê";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);

            this.tabControlBaoCao.ResumeLayout(false);
            this.tabDoanhThu.ResumeLayout(false);
            this.panelTopDoanhThu.ResumeLayout(false);
            this.panelTopDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.tabTonKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).EndInit();
            this.tabThuCung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThuCung)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // Khai báo biến
        private System.Windows.Forms.TabControl tabControlBaoCao;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.TabPage tabTonKho;
        private System.Windows.Forms.TabPage tabThuCung;

        // Tab Doanh Thu
        private System.Windows.Forms.Panel panelTopDoanhThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnXemDoanhThu;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;

        // Tab Tồn Kho
        private System.Windows.Forms.DataGridView dgvTonKho;
        private System.Windows.Forms.Label label4;

        // Tab Thú Cưng
        private System.Windows.Forms.DataGridView dgvThuCung;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThuCung;
        private System.Windows.Forms.Label label5;
    }
}