namespace QuanLyCuaHangThuCung.GUI
{
    partial class frmPhieuNhap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMatHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radThuCung = new System.Windows.Forms.RadioButton();
            this.radSanPham = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.SuspendLayout();

            // 
            // groupBox1 (Khu vực nhập liệu)
            // 
            this.groupBox1.Controls.Add(this.btnNhapHang);
            this.groupBox1.Controls.Add(this.numSoLuong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboMatHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radThuCung);
            this.groupBox1.Controls.Add(this.radSanPham);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập hàng";

            // Radio Button
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại hàng:";

            this.radSanPham.AutoSize = true;
            this.radSanPham.Location = new System.Drawing.Point(140, 38);
            this.radSanPham.Name = "radSanPham";
            this.radSanPham.Size = new System.Drawing.Size(105, 24);
            this.radSanPham.TabIndex = 1;
            this.radSanPham.TabStop = true;
            this.radSanPham.Text = "Sản phẩm";
            this.radSanPham.UseVisualStyleBackColor = true;
            this.radSanPham.CheckedChanged += new System.EventHandler(this.radSanPham_CheckedChanged);

            this.radThuCung.AutoSize = true;
            this.radThuCung.Location = new System.Drawing.Point(260, 38);
            this.radThuCung.Name = "radThuCung";
            this.radThuCung.Size = new System.Drawing.Size(100, 24);
            this.radThuCung.TabIndex = 2;
            this.radThuCung.TabStop = true;
            this.radThuCung.Text = "Thú cưng";
            this.radThuCung.UseVisualStyleBackColor = true;

            // ComboBox Hàng
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mặt hàng:";

            this.cboMatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatHang.FormattingEnabled = true;
            this.cboMatHang.Location = new System.Drawing.Point(140, 87);
            this.cboMatHang.Name = "cboMatHang";
            this.cboMatHang.Size = new System.Drawing.Size(250, 28);
            this.cboMatHang.TabIndex = 4;

            // Số lượng
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng:";

            this.numSoLuong.Location = new System.Drawing.Point(510, 88);
            this.numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(100, 26);
            this.numSoLuong.TabIndex = 6;
            this.numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // Button
            this.btnNhapHang.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnNhapHang.Location = new System.Drawing.Point(650, 80);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(120, 40);
            this.btnNhapHang.TabIndex = 7;
            this.btnNhapHang.Text = "NHẬP KHO";
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);

            // 
            // groupBox2 (Lịch sử)
            // 
            this.groupBox2.Controls.Add(this.dgvPhieuNhap);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(0, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 450);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lịch sử nhập hàng (Mới nhất)";

            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(3, 22);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(794, 425);
            this.dgvPhieuNhap.TabIndex = 0;

            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhieuNhap";
            this.Text = "Quản Lý Nhập Hàng";
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMatHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radThuCung;
        private System.Windows.Forms.RadioButton radSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
    }
}