using QuanLyCuaHangThuCung.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QuanLyCuaHangThuCung.Class
{
    internal class ChamCong
    {
        FileXml Fxml = new FileXml();

        // Hàm lấy danh sách chấm công từ XML
        public DataTable LayDanhSachChamCong()
        {
            return Fxml.HienThi("ChamCong.xml");
        }

        // ===================================================
        // 1) GHI CHẤM CÔNG (Đã loại bỏ GioChamCong để khớp SQL)
        // ===================================================
        public void XacNhanDiLam(string MaNhanVien, int Ngay, int Thang, int Nam)
        {
            XmlDocument doc = new XmlDocument();
            string path = Application.StartupPath + "\\Data\\ChamCong.xml";
            doc.Load(path);

            XmlNode root = doc.DocumentElement;

            XmlElement chamCong = doc.CreateElement("ChamCong");

            // Chỉ thêm các trường có trong bảng SQL
            XmlElement maNV = doc.CreateElement("MaNhanVien");
            maNV.InnerText = MaNhanVien;
            chamCong.AppendChild(maNV);

            XmlElement ngayNode = doc.CreateElement("Ngay");
            ngayNode.InnerText = Ngay.ToString();
            chamCong.AppendChild(ngayNode);

            XmlElement thangNode = doc.CreateElement("Thang");
            thangNode.InnerText = Thang.ToString();
            chamCong.AppendChild(thangNode);

            XmlElement namNode = doc.CreateElement("Nam");
            namNode.InnerText = Nam.ToString();
            chamCong.AppendChild(namNode);

            // Ghi chú: Đã loại bỏ GioChamCong vì bảng SQL không định nghĩa cột này

            root.AppendChild(chamCong);
            doc.Save(path);
        }

        // ===================================================
        // 2) KIỂM TRA ĐÃ CHẤM CÔNG NGÀY ĐÓ CHƯA
        // ===================================================
        public bool kiemtraNgayThang(string MaNhanVien, int Ngay, int Thang, int Nam)
        {
            DataTable dt = Fxml.HienThi("ChamCong.xml");

            // RowFilter vẫn giữ nguyên vì các cột này khớp với SQL
            dt.DefaultView.RowFilter =
                $"MaNhanVien='{MaNhanVien}' AND Ngay={Ngay} AND Thang={Thang} AND Nam={Nam}";

            return dt.DefaultView.Count > 0;
        }
    }
}