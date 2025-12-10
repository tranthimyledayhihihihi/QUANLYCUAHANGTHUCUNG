using QuanLyCuaHangThuCung.Class;
using System;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung.GUI
{
    public partial class frmHeThong : Form
    {
        public frmHeThong()
        {
            InitializeComponent();
        }

        // ============================
        //  SQL → XML
        // ============================
        private void btnSqlToXml_Click(object sender, EventArgs e)
        {
            HeThong ht = new HeThong();
            ht.TaoXML();

            MessageBox.Show("Đã xuất dữ liệu từ SQL → XML thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ============================
        //  XML → SQL
        // ============================
        private void btnXmlToSql_Click(object sender, EventArgs e)
        {
            HeThong ht = new HeThong();
            ht.CapNhapSQL();

            MessageBox.Show("Đã nhập dữ liệu từ XML → SQL thành công!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
