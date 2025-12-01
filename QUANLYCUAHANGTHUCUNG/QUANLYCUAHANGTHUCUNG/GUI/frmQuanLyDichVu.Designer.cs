namespace QuanLyCuaHangThuCung.GUI
{
    partial class frmQuanLyDichVu
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
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.numThoiGian = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numGiaDV = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaDV)).BeginInit();
            this.SuspendLayout();

            // dgvDichVu
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDichVu.Location = new System.Drawing.Point(0, 0);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(550, 450);
            this.dgvDichVu.TabIndex = 0;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);

            // groupBox1
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.numThoiGian);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numGiaDV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenDV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaDV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(550, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";

            // Controls
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 50); this.label1.Text = "Mã DV:";
            this.txtMaDV.Location = new System.Drawing.Point(110, 47); this.txtMaDV.Size = new System.Drawing.Size(200, 26);

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 100); this.label2.Text = "Tên DV:";
            this.txtTenDV.Location = new System.Drawing.Point(110, 97); this.txtTenDV.Size = new System.Drawing.Size(200, 26);

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 150); this.label3.Text = "Giá tiền:";
            this.numGiaDV.Location = new System.Drawing.Point(110, 148); this.numGiaDV.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 }); this.numGiaDV.Size = new System.Drawing.Size(200, 26);

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 200); this.label4.Text = "Thời gian:";
            this.numThoiGian.Location = new System.Drawing.Point(110, 198); this.numThoiGian.Maximum = new decimal(new int[] { 1000, 0, 0, 0 }); this.numThoiGian.Size = new System.Drawing.Size(120, 26);

            // Buttons
            this.btnThem.Text = "Thêm"; this.btnThem.Location = new System.Drawing.Point(30, 270); this.btnThem.Size = new System.Drawing.Size(80, 40);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Text = "Sửa"; this.btnSua.Location = new System.Drawing.Point(120, 270); this.btnSua.Size = new System.Drawing.Size(80, 40);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Text = "Xóa"; this.btnXoa.Location = new System.Drawing.Point(210, 270); this.btnXoa.Size = new System.Drawing.Size(80, 40);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnLamMoi.Text = "Làm mới"; this.btnLamMoi.Location = new System.Drawing.Point(120, 320); this.btnLamMoi.Size = new System.Drawing.Size(80, 40);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDichVu);
            this.Name = "frmQuanLyDichVu";
            this.Text = "Quản Lý Dịch Vụ";
            this.Load += new System.EventHandler(this.frmQuanLyDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaDV)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown numThoiGian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numGiaDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label1;
    }
}