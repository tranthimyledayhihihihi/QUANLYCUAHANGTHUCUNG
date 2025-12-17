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
        // 1) GHI CHẤM CÔNG
        // ===================================================
        public void XacNhanDiLam(string MaNhanVien, int Ngay, int Thang, int Nam)
        {
            XmlDocument doc = new XmlDocument();
            string path = Application.StartupPath + "\\Data\\ChamCong.xml";
            doc.Load(path);

            XmlNode root = doc.DocumentElement;

            XmlElement chamCong = doc.CreateElement("ChamCong");

            chamCong.AppendChild(doc.CreateElement("MaNhanVien")).InnerText = MaNhanVien;
            chamCong.AppendChild(doc.CreateElement("Ngay")).InnerText = Ngay.ToString();
            chamCong.AppendChild(doc.CreateElement("Thang")).InnerText = Thang.ToString();
            chamCong.AppendChild(doc.CreateElement("Nam")).InnerText = Nam.ToString();
            chamCong.AppendChild(doc.CreateElement("GioChamCong")).InnerText = DateTime.Now.ToString("HH:mm");

            root.AppendChild(chamCong);
            doc.Save(path);
        }


        // ===================================================
        // 2) KIỂM TRA ĐÃ CHẤM CÔNG NGÀY ĐÓ CHƯA
        // ===================================================
        public bool kiemtraNgayThang(string MaNhanVien, int Ngay, int Thang, int Nam)
        {
            DataTable dt = Fxml.HienThi("ChamCong.xml");

            dt.DefaultView.RowFilter =
                $"MaNhanVien='{MaNhanVien}' AND Ngay='{Ngay}' AND Thang='{Thang}' AND Nam='{Nam}'";

            return dt.DefaultView.Count > 0;
        }
    }
}
