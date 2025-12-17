using System.Xml;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace QuanLyCuaHangThuCung.Class
{
    class DichVuBLL
    {
        FileXml Fxml = new FileXml();

        // 1. Kiểm tra Mã Dịch Vụ có tồn tại không
        public bool kiemtraMaDV(string MaDV)
        {
            string filePath = Application.StartupPath + "\\Data\\DichVu.xml";

            if (!File.Exists(filePath))
            {
                return false;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            // Sử dụng SelectSingleNode để tìm mã dịch vụ tương ứng với MaDV trong SQL
            XmlNode node = doc.SelectSingleNode($"NewDataSet/DichVu[MaDV='{MaDV}']");

            return node != null;
        }

        // 2. Thêm Dịch Vụ mới
        public void themDV(string MaDV, string TenDV, int GiaDV, int ThoiGianThucHien)
        {
            // Các trường dữ liệu khớp hoàn toàn với bảng DichVu trong SQL
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

            // Cập nhật dựa trên khóa chính MaDV
            Fxml.Sua("DichVu.xml", "DichVu", "MaDV", MaDV, noiDung);
        }

        // 4. Xóa dịch vụ
        public void xoaDV(string MaDV)
        {
            Fxml.Xoa("DichVu.xml", "DichVu", "MaDV", MaDV);
        }

        // 5. Hiển thị danh sách dịch vụ
        public DataTable LoadTable()
        {
            return Fxml.HienThi("DichVu.xml");
        }
    }
}