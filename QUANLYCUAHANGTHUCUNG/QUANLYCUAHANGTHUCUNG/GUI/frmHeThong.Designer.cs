namespace QuanLyCuaHangThuCung.GUI
{
    partial class frmHeThong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnSqlToXml;
        private System.Windows.Forms.Button btnXmlToSql;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnSqlToXml = new System.Windows.Forms.Button();
            this.btnXmlToSql = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSqlToXml
            // 
            this.btnSqlToXml.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSqlToXml.Location = new System.Drawing.Point(150, 120);
            this.btnSqlToXml.Name = "btnSqlToXml";
            this.btnSqlToXml.Size = new System.Drawing.Size(300, 60);
            this.btnSqlToXml.TabIndex = 1;
            this.btnSqlToXml.Text = "SQL → XML";
            this.btnSqlToXml.Click += new System.EventHandler(this.btnSqlToXml_Click);
            // 
            // btnXmlToSql
            // 
            this.btnXmlToSql.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnXmlToSql.Location = new System.Drawing.Point(150, 200);
            this.btnXmlToSql.Name = "btnXmlToSql";
            this.btnXmlToSql.Size = new System.Drawing.Size(300, 60);
            this.btnXmlToSql.TabIndex = 2;
            this.btnXmlToSql.Text = "XML → SQL";
            this.btnXmlToSql.Click += new System.EventHandler(this.btnXmlToSql_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CHUYỂN ĐỔI DỮ LIỆU";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHeThong
            // 
            this.BackgroundImage = global::QUANLYCUAHANGTHUCUNG.Properties.Resources.Pastel_paws_and_hearts_pattern_background_for_pets___Premium_Vector;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSqlToXml);
            this.Controls.Add(this.btnXmlToSql);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }
    }
}
