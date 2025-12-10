using System;
using System.Data;
using System.Xml;
using System.Windows.Forms;


namespace QuanLyCuaHangThuCung.Class
{
    class NhanVien
    {
        FileXml Fxml = new FileXml();

        // ===================================================
        // 1) KIỂM TRA MÃ NHÂN VIÊN
        // ===================================================
        public bool kiemtra(string MaNhanVien)
        {
            string v = Fxml.LayGiaTri("NhanVien.xml", "MaNhanVien", MaNhanVien, "MaNhanVien");
            return !string.IsNullOrEmpty(v);
        }

        // ===================================================
        // 2) THÊM NHÂN VIÊN
        // ===================================================
        public void themNV(string MaNhanVien, string TenNhanVien, string NgaySinh,
                           string DiaChi, string SDT, string Email)
        {
            string noiDung =
                "<NhanVien>" +
                "<MaNhanVien>" + MaNhanVien + "</MaNhanVien>" +
                "<TenNhanVien>" + TenNhanVien + "</TenNhanVien>" +
                "<NgaySinh>" + NgaySinh + "</NgaySinh>" +
                "<DiaChi>" + DiaChi + "</DiaChi>" +
                "<SDT>" + SDT + "</SDT>" +
                "<Email>" + Email + "</Email>" +
                "</NhanVien>";

            Fxml.Them("Data\\NhanVien.xml", noiDung);
        }

        // ===================================================
        // 3) SỬA NHÂN VIÊN
        // ===================================================
        public void suaNV(string MaNhanVien, string TenNhanVien, string NgaySinh,
                          string DiaChi, string SDT, string Email)
        {
            string noiDung =
                "<MaNhanVien>" + MaNhanVien + "</MaNhanVien>" +
                "<TenNhanVien>" + TenNhanVien + "</TenNhanVien>" +
                "<NgaySinh>" + NgaySinh + "</NgaySinh>" +
                "<DiaChi>" + DiaChi + "</DiaChi>" +
                "<SDT>" + SDT + "</SDT>" +
                "<Email>" + Email + "</Email>";

            Fxml.Sua("Data\\NhanVien.xml", "NhanVien", "MaNhanVien", MaNhanVien, noiDung);
        }

        // ===================================================
        // 4) XÓA NHÂN VIÊN
        // ===================================================
        public void xoaNV(string MaNhanVien)
        {
            Fxml.Xoa("NhanVien.xml", "NhanVien", "MaNhanVien", MaNhanVien);
        }

        // ===================================================
        // 5) GHI CHẤM CÔNG
        // ===================================================
        public void XacNhanDiLam(string MaNhanVien, int Ngay, int Thang, int Nam)
        {
            // Tải file ChamCong.xml từ Data\
            XmlDocument doc = new XmlDocument();
            doc.Load(Application.StartupPath + "\\Data\\ChamCong.xml");

            XmlNode root = doc.DocumentElement;
            XmlDocumentFragment frag = doc.CreateDocumentFragment();

            frag.InnerXml =
                "<ChamCong>" +
                "<MaNhanVien>" + MaNhanVien + "</MaNhanVien>" +
                "<Ngay>" + Ngay + "</Ngay>" +
                "<Thang>" + Thang + "</Thang>" +
                "<Nam>" + Nam + "</Nam>" +
                "</ChamCong>";

            root.AppendChild(frag);

            doc.Save(Application.StartupPath + "\\Data\\ChamCong.xml");
        }

        // ===================================================
        // 6) KIỂM TRA ĐÃ CHẤM CÔNG NGÀY ĐÓ CHƯA
        // ===================================================
        public bool kiemtraNgayThang(string MaNhanVien, int Ngay, int Thang, int Nam)
        {
            DataTable dt = Fxml.HienThi("ChamCong.xml");

            dt.DefaultView.RowFilter =
                $"MaNhanVien='{MaNhanVien}' AND Ngay='{Ngay}' AND Thang='{Thang}' AND Nam='{Nam}'";

            return dt.DefaultView.Count > 0;
        }

        // ===================================================
        // 7) LOAD TOÀN BỘ NHÂN VIÊN
        // ===================================================
        public DataTable LoadTable()
        {
            return Fxml.HienThi("NhanVien.xml");
        }
    }
}
