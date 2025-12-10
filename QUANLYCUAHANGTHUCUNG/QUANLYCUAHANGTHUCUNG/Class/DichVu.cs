using System.Xml;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung.Class
{
    class DichVuBLL
    {
        FileXml Fxml = new FileXml();

        // 1. Kiểm tra Mã Dịch Vụ có tồn tại không
        public bool kiemtraMaDV(string MaDV)
        {
            string filePath = Application.StartupPath + "\\Data\\DichVu.xml";

            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show("Không tìm thấy file DichVu.xml!");
                return false;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode node = doc.SelectSingleNode(
                $"NewDataSet/DichVu[MaDV='{MaDV}']"
            );

            return node != null;
        }

        // 2. Thêm Dịch Vụ mới
        public void themDV(string MaDV, string TenDV, int GiaDV, int ThoiGianThucHien)
        {
            string noiDung = "<DichVu>" +
                    "<MaDV>" + MaDV + "</MaDV>" +
                    "<TenDV>" + TenDV + "</TenDV>" +
                    "<GiaDV>" + GiaDV + "</GiaDV>" +
                    "<ThoiGianThucHien>" + ThoiGianThucHien + "</ThoiGianThucHien>" +
                    "</DichVu>";

            Fxml.Them("DichVu.xml", noiDung);
        }

        // 3. Sửa Dịch Vụ
        public void suaDV(string MaDV, string TenDV, int GiaDV, int ThoiGianThucHien)
        {
            string noiDung =
                    "<MaDV>" + MaDV + "</MaDV>" +
                    "<TenDV>" + TenDV + "</TenDV>" +
                    "<GiaDV>" + GiaDV + "</GiaDV>" +
                    "<ThoiGianThucHien>" + ThoiGianThucHien + "</ThoiGianThucHien>";

            Fxml.Sua("DichVu.xml", "DichVu", "MaDV", MaDV, noiDung);
        }

        // 4. Xóa dịch vụ
        public void xoaDV(string MaDV)
        {
            Fxml.Xoa("DichVu.xml", "DichVu", "MaDV", MaDV);
        }

        // 5. Load vào bảng
        public DataTable LoadTable()
        {
            return Fxml.HienThi("DichVu.xml");
        }
    }
}
