namespace QuanLyCuaHangThuCung
{
    partial class frmBaoCao
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();

            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.chartBaoCao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnTKNgay = new System.Windows.Forms.Button();
            this.grpMonth = new System.Windows.Forms.GroupBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.btnTKThang = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblTongHoaDon = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblSanPhamDaBan = new System.Windows.Forms.Label();
            this.lblThuCungDaBan = new System.Windows.Forms.Label();
            this.tabHoaDon = new System.Windows.Forms.TabPage();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnXuatPDF = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.chartBaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tabHoaDon.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.grpMonth.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();

            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDashboard);
            this.tabControl1.Controls.Add(this.tabHoaDon);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 700);
            this.tabControl1.TabIndex = 0;

            // 
            // tabDashboard
            // 
            this.tabDashboard.BackColor = System.Drawing.Color.FromArgb(240, 244, 248);
            this.tabDashboard.Controls.Add(this.chartBaoCao);
            this.tabDashboard.Controls.Add(this.grpSummary);
            this.tabDashboard.Controls.Add(this.grpMonth);
            this.tabDashboard.Controls.Add(this.grpDate);
            this.tabDashboard.Location = new System.Drawing.Point(4, 29);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(15);
            this.tabDashboard.Size = new System.Drawing.Size(1192, 667);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "📊 Dashboard";

            // 
            // grpDate
            // 
            this.grpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDate.BackColor = System.Drawing.Color.White;
            this.grpDate.Controls.Add(this.btnTKNgay);
            this.grpDate.Controls.Add(this.dtTo);
            this.grpDate.Controls.Add(this.dtFrom);
            this.grpDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDate.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.grpDate.Location = new System.Drawing.Point(15, 15);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(560, 85);
            this.grpDate.TabIndex = 0;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "📅 Thống kê theo ngày";

            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(20, 35);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(160, 25);
            this.dtFrom.TabIndex = 0;

            // 
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(195, 35);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(160, 25);
            this.dtTo.TabIndex = 1;

            // 
            // btnTKNgay
            // 
            this.btnTKNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTKNgay.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnTKNgay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTKNgay.FlatAppearance.BorderSize = 0;
            this.btnTKNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTKNgay.ForeColor = System.Drawing.Color.White;
            this.btnTKNgay.Location = new System.Drawing.Point(375, 30);
            this.btnTKNgay.Name = "btnTKNgay";
            this.btnTKNgay.Size = new System.Drawing.Size(165, 35);
            this.btnTKNgay.TabIndex = 2;
            this.btnTKNgay.Text = "🔍 Thống kê";
            this.btnTKNgay.UseVisualStyleBackColor = false;
            this.btnTKNgay.Click += new System.EventHandler(this.btnTKNgay_Click);

            // 
            // grpMonth
            // 
            this.grpMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMonth.BackColor = System.Drawing.Color.White;
            this.grpMonth.Controls.Add(this.btnTKThang);
            this.grpMonth.Controls.Add(this.cboNam);
            this.grpMonth.Controls.Add(this.cboThang);
            this.grpMonth.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpMonth.ForeColor = System.Drawing.Color.FromArgb(142, 68, 173);
            this.grpMonth.Location = new System.Drawing.Point(595, 15);
            this.grpMonth.Name = "grpMonth";
            this.grpMonth.Size = new System.Drawing.Size(582, 85);
            this.grpMonth.TabIndex = 1;
            this.grpMonth.TabStop = false;
            this.grpMonth.Text = "📆 Thống kê theo tháng";

            // 
            // cboThang
            // 
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(20, 35);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(140, 25);
            this.cboThang.TabIndex = 0;

            // 
            // cboNam
            // 
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(175, 35);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(140, 25);
            this.cboNam.TabIndex = 1;

            // 
            // btnTKThang
            // 
            this.btnTKThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTKThang.BackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            this.btnTKThang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTKThang.FlatAppearance.BorderSize = 0;
            this.btnTKThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKThang.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTKThang.ForeColor = System.Drawing.Color.White;
            this.btnTKThang.Location = new System.Drawing.Point(335, 30);
            this.btnTKThang.Name = "btnTKThang";
            this.btnTKThang.Size = new System.Drawing.Size(227, 35);
            this.btnTKThang.TabIndex = 2;
            this.btnTKThang.Text = "🔍 Thống kê";
            this.btnTKThang.UseVisualStyleBackColor = false;
            this.btnTKThang.Click += new System.EventHandler(this.btnTKThang_Click);

            // 
            // grpSummary
            // 
            this.grpSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSummary.BackColor = System.Drawing.Color.White;
            this.grpSummary.Controls.Add(this.lblThuCungDaBan);
            this.grpSummary.Controls.Add(this.lblSanPhamDaBan);
            this.grpSummary.Controls.Add(this.lblTongDoanhThu);
            this.grpSummary.Controls.Add(this.lblTongHoaDon);
            this.grpSummary.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpSummary.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.grpSummary.Location = new System.Drawing.Point(15, 110);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(1162, 110);
            this.grpSummary.TabIndex = 2;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "📌 Tổng quan";

            // 
            // lblTongHoaDon
            // 
            this.lblTongHoaDon.AutoSize = true;
            this.lblTongHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongHoaDon.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblTongHoaDon.Location = new System.Drawing.Point(20, 35);
            this.lblTongHoaDon.Name = "lblTongHoaDon";
            this.lblTongHoaDon.Size = new System.Drawing.Size(150, 19);
            this.lblTongHoaDon.TabIndex = 0;
            this.lblTongHoaDon.Text = "💼 Tổng hóa đơn: 0";

            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.lblTongDoanhThu.Location = new System.Drawing.Point(20, 65);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(170, 19);
            this.lblTongDoanhThu.TabIndex = 1;
            this.lblTongDoanhThu.Text = "💰 Tổng doanh thu: 0đ";

            // 
            // lblSanPhamDaBan
            // 
            this.lblSanPhamDaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSanPhamDaBan.AutoSize = true;
            this.lblSanPhamDaBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSanPhamDaBan.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.lblSanPhamDaBan.Location = new System.Drawing.Point(600, 35);
            this.lblSanPhamDaBan.Name = "lblSanPhamDaBan";
            this.lblSanPhamDaBan.Size = new System.Drawing.Size(180, 19);
            this.lblSanPhamDaBan.TabIndex = 2;
            this.lblSanPhamDaBan.Text = "📦 Sản phẩm đã bán: 0";

            // 
            // lblThuCungDaBan
            // 
            this.lblThuCungDaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThuCungDaBan.AutoSize = true;
            this.lblThuCungDaBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblThuCungDaBan.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.lblThuCungDaBan.Location = new System.Drawing.Point(600, 65);
            this.lblThuCungDaBan.Name = "lblThuCungDaBan";
            this.lblThuCungDaBan.Size = new System.Drawing.Size(180, 19);
            this.lblThuCungDaBan.TabIndex = 3;
            this.lblThuCungDaBan.Text = "🐾 Thú cưng đã bán: 0";

            // 
            // chartBaoCao
            // 
            this.chartBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartBaoCao.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartBaoCao.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBaoCao.Legends.Add(legend1);
            this.chartBaoCao.Location = new System.Drawing.Point(15, 230);
            this.chartBaoCao.Name = "chartBaoCao";
            this.chartBaoCao.Size = new System.Drawing.Size(1162, 422);
            this.chartBaoCao.TabIndex = 3;
            this.chartBaoCao.Text = "chart1";

            // 
            // tabHoaDon
            // 
            this.tabHoaDon.BackColor = System.Drawing.Color.FromArgb(240, 244, 248);
            this.tabHoaDon.Controls.Add(this.dgvHoaDon);
            this.tabHoaDon.Controls.Add(this.btnXuatPDF);
            this.tabHoaDon.Location = new System.Drawing.Point(4, 29);
            this.tabHoaDon.Name = "tabHoaDon";
            this.tabHoaDon.Padding = new System.Windows.Forms.Padding(15);
            this.tabHoaDon.Size = new System.Drawing.Size(1192, 667);
            this.tabHoaDon.TabIndex = 1;
            this.tabHoaDon.Text = "🧾 Báo cáo hóa đơn";

            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(15, 15);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowTemplate.Height = 25;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(1162, 587);
            this.dgvHoaDon.TabIndex = 0;

            // 
            // btnXuatPDF
            // 
            this.btnXuatPDF.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnXuatPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatPDF.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnXuatPDF.FlatAppearance.BorderSize = 0;
            this.btnXuatPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatPDF.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXuatPDF.ForeColor = System.Drawing.Color.White;
            this.btnXuatPDF.Location = new System.Drawing.Point(15, 602);
            this.btnXuatPDF.Name = "btnXuatPDF";
            this.btnXuatPDF.Size = new System.Drawing.Size(1162, 50);
            this.btnXuatPDF.TabIndex = 1;
            this.btnXuatPDF.Text = "📄 Xuất PDF";
            this.btnXuatPDF.UseVisualStyleBackColor = false;
            this.btnXuatPDF.Click += new System.EventHandler(this.btnXuatPDF_Click);

            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "📊 BÁO CÁO – THỐNG KÊ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            ((System.ComponentModel.ISupportInitialize)(this.chartBaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabHoaDon.ResumeLayout(false);
            this.grpDate.ResumeLayout(false);
            this.grpMonth.ResumeLayout(false);
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDashboard, tabHoaDon;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBaoCao;
        private System.Windows.Forms.GroupBox grpDate, grpMonth, grpSummary;
        private System.Windows.Forms.DateTimePicker dtFrom, dtTo;
        private System.Windows.Forms.ComboBox cboThang, cboNam;
        private System.Windows.Forms.Button btnTKNgay, btnTKThang, btnXuatPDF;
        private System.Windows.Forms.Label lblTongHoaDon, lblTongDoanhThu, lblSanPhamDaBan, lblThuCungDaBan;
        private System.Windows.Forms.DataGridView dgvHoaDon;
    }
}