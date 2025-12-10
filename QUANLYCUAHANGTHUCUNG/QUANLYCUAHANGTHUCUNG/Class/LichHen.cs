// File: LichHenBLL.cs
using System.Xml;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung.Class
{
    class LichHenBLL
    {
        FileXml Fxml = new FileXml();

        // =======================================
        // 1) LẤY MÃ LỊCH HẸN TIẾP THEO
        // =======================================
        public int LayMaLichHenTiepTheo()
        {
            DataTable dt = Fxml.HienThi("LichHen.xml");

            if (dt == null || dt.Rows.Count == 0)
                return 1;

            return dt.AsEnumerable()
                     .Max(row => int.Parse(row["MaLichHen"].ToString())) + 1;
        }

        // =======================================
        // 2) KIỂM TRA MÃ LỊCH HẸN
        // =======================================
        public bool kiemtraMaLichHen(string MaLichHen)
        {
            string giaTri = Fxml.LayGiaTri("LichHen.xml", "MaLichHen", MaLichHen, "MaLichHen");
            return !string.IsNullOrEmpty(giaTri);
        }

        // =======================================
        // 3) THÊM LỊCH HẸN
        // =======================================
        public void themLH(string MaKhachHang, string MaDichVu, string NgayHen, string GioHen, string TrangThai)
        {
            int maLHMoi = LayMaLichHenTiepTheo();

            string noiDung =
                "<LichHen>" +
                "<MaLichHen>" + maLHMoi + "</MaLichHen>" +
                "<MaKhachHang>" + MaKhachHang + "</MaKhachHang>" +
                "<MaDichVu>" + MaDichVu + "</MaDichVu>" +
                "<NgayHen>" + NgayHen + "</NgayHen>" +
                "<GioHen>" + GioHen + "</GioHen>" +
                "<TrangThai>" + TrangThai + "</TrangThai>" +
                "</LichHen>";

            Fxml.Them("Data\\LichHen.xml", noiDung);
        }

        // =======================================
        // 4) SỬA LỊCH HẸN
        // =======================================
        public void suaLH(string MaLichHen, string MaKhachHang, string MaDichVu, string NgayHen, string GioHen, string TrangThai)
        {
            string noiDung =
                "<MaLichHen>" + MaLichHen + "</MaLichHen>" +
                "<MaKhachHang>" + MaKhachHang + "</MaKhachHang>" +
                "<MaDichVu>" + MaDichVu + "</MaDichVu>" +
                "<NgayHen>" + NgayHen + "</NgayHen>" +
                "<GioHen>" + GioHen + "</GioHen>" +
                "<TrangThai>" + TrangThai + "</TrangThai>";

            Fxml.Sua("Data\\LichHen.xml", "LichHen", "MaLichHen", MaLichHen, noiDung);
        }

        // =======================================
        // 5) XÓA LỊCH HẸN
        // =======================================
        public void xoaLH(string MaLichHen)
        {
            Fxml.Xoa("LichHen.xml", "LichHen", "MaLichHen", MaLichHen);
        }
    }
}
