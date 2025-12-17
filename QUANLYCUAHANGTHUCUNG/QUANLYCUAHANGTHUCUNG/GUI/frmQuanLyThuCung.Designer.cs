// frmQuanLyThuCung.Designer.cs
namespace QuanLyCuaHangThuCung.GUI
{
    partial class frmQuanLyThuCung
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThuCung = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numGiaBan = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenTC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNhap)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThuCung
            // 
            this.dgvThuCung.AllowUserToAddRows = false;
            this.dgvThuCung.AllowUserToDeleteRows = false;
            this.dgvThuCung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvThuCung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuCung.BackgroundColor = System.Drawing.Color.White;
            this.dgvThuCung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThuCung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThuCung.ColumnHeadersHeight = 40;
            this.dgvThuCung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvThuCung.EnableHeadersVisualStyles = false;
            this.dgvThuCung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.dgvThuCung.Location = new System.Drawing.Point(19, 20);
            this.dgvThuCung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvThuCung.Name = "dgvThuCung";
            this.dgvThuCung.ReadOnly = true;
            this.dgvThuCung.RowHeadersVisible = false;
            this.dgvThuCung.RowHeadersWidth = 62;
            this.dgvThuCung.RowTemplate.Height = 35;
            this.dgvThuCung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuCung.Size = new System.Drawing.Size(862, 893);
            this.dgvThuCung.TabIndex = 0;
            this.dgvThuCung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuCung_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cboNCC);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboTrangThai);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numGiaBan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numGiaNhap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGiong);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cboLoai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.groupBox1.Location = new System.Drawing.Point(899, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(644, 893);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "🐾 THÔNG TIN THÚ CƯNG";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(418, 825);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(116, 60);
            this.btnLamMoi.TabIndex = 23;
            this.btnLamMoi.Text = "🔄 Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(294, 825);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 60);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "🗑️ Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(161, 825);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 60);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "✏️ Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(37, 825);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 60);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboNCC
            // 
            this.cboNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(193, 589);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(327, 33);
            this.cboNCC.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label9.Location = new System.Drawing.Point(32, 593);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "🏢 NCC:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(193, 536);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(327, 33);
            this.cboTrangThai.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label8.Location = new System.Drawing.Point(32, 540);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "📊 Trạng thái:";
            // 
            // numGiaBan
            // 
            this.numGiaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.numGiaBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numGiaBan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numGiaBan.Location = new System.Drawing.Point(193, 483);
            this.numGiaBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numGiaBan.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numGiaBan.Name = "numGiaBan";
            this.numGiaBan.Size = new System.Drawing.Size(328, 33);
            this.numGiaBan.TabIndex = 15;
            this.numGiaBan.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label7.Location = new System.Drawing.Point(32, 487);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "💰 Giá bán:";
            // 
            // numGiaNhap
            // 
            this.numGiaNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.numGiaNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numGiaNhap.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numGiaNhap.Location = new System.Drawing.Point(193, 429);
            this.numGiaNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numGiaNhap.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numGiaNhap.Name = "numGiaNhap";
            this.numGiaNhap.Size = new System.Drawing.Size(328, 33);
            this.numGiaNhap.TabIndex = 13;
            this.numGiaNhap.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(32, 433);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "💵 Giá nhập:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(193, 376);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(327, 33);
            this.dtpNgaySinh.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(32, 380);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "🎂 Ngày sinh:";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(193, 323);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(327, 33);
            this.cboGioiTinh.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(32, 327);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "⚧ Giới tính:";
            // 
            // txtGiong
            // 
            this.txtGiong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.txtGiong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtGiong.Location = new System.Drawing.Point(193, 269);
            this.txtGiong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiong.Name = "txtGiong";
            this.txtGiong.Size = new System.Drawing.Size(327, 33);
            this.txtGiong.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label10.Location = new System.Drawing.Point(32, 273);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "🦴 Giống:";
            // 
            // cboLoai
            // 
            this.cboLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(193, 216);
            this.cboLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(327, 33);
            this.cboLoai.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(32, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "🏷️ Loại:";
            // 
            // txtTenTC
            // 
            this.txtTenTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.txtTenTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenTC.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenTC.Location = new System.Drawing.Point(193, 103);
            this.txtTenTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenTC.Multiline = true;
            this.txtTenTC.Name = "txtTenTC";
            this.txtTenTC.Size = new System.Drawing.Size(327, 93);
            this.txtTenTC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(32, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "📝 Tên TC:";
            // 
            // txtMaTC
            // 
            this.txtMaTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.txtMaTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaTC.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaTC.Location = new System.Drawing.Point(193, 49);
            this.txtMaTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaTC.Name = "txtMaTC";
            this.txtMaTC.Size = new System.Drawing.Size(327, 33);
            this.txtMaTC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "🔖 Mã TC:";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Controls.Add(this.dgvThuCung);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(19, 20, 19, 20);
            this.panelMain.Size = new System.Drawing.Size(1543, 933);
            this.panelMain.TabIndex = 0;
            // 
            // frmQuanLyThuCung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1543, 933);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1279, 781);
            this.Name = "frmQuanLyThuCung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🐾 QUẢN LÝ KHO THÚ CƯNG";
            this.Load += new System.EventHandler(this.frmQuanLyThuCung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuCung)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNhap)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvThuCung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numGiaBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numGiaNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTC;
        private System.Windows.Forms.Label label1;
    }
}