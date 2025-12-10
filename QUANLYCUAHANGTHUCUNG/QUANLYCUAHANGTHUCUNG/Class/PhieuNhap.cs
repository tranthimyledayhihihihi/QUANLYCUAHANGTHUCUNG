using System.Data;
using System.Linq;

namespace QuanLyCuaHangThuCung.Class
{
    class PhieuNhap
    {
        FileXml Fxml = new FileXml();

        // =========================================================
        // 1) LẤY MÃ PHIẾU NHẬP TIẾP THEO
        // =========================================================
        public int LayMaPhieuTiepTheo()
        {
            DataTable dt = Fxml.HienThi("PhieuNhap.xml");

            if (dt == null || dt.Rows.Count == 0)
                return 1;

            return dt.AsEnumerable()
                     .Max(row => int.Parse(row["MaPhieu"].ToString())) + 1;
        }

        // =========================================================
        // 2) KIỂM TRA MÃ PHIẾU
        // =========================================================
        public bool kiemtraMaPhieu(string MaPhieu)
        {
            string giaTri = Fxml.LayGiaTri("PhieuNhap.xml", "MaPhieu", MaPhieu, "MaPhieu");
            return !string.IsNullOrEmpty(giaTri);
        }

        // =========================================================
        // 3) THÊM PHIẾU NHẬP
        // =========================================================
        public void themPN(string MaMatHang, string LoaiMatHang,
                           string MaNhanVien, int SoLuongNhap, string NgayLap)
        {
            int maPhieuMoi = LayMaPhieuTiepTheo();

            string noiDung =
                "<PhieuNhap>" +
                "<MaPhieu>" + maPhieuMoi + "</MaPhieu>" +
                "<MaMatHang>" + MaMatHang + "</MaMatHang>" +
                "<LoaiMatHang>" + LoaiMatHang + "</LoaiMatHang>" +
                "<MaNhanVien>" + MaNhanVien + "</MaNhanVien>" +
                "<SoLuongNhap>" + SoLuongNhap + "</SoLuongNhap>" +
                "<NgayLapPhieu>" + NgayLap + "</NgayLapPhieu>" +
                "</PhieuNhap>";

            // Ghi đúng đường dẫn Data\
            Fxml.Them("Data\\PhieuNhap.xml", noiDung);

            // TODO: update kho / thêm thú cưng nếu LoaiMatHang = TC
        }

        // =========================================================
        // 4) XÓA PHIẾU NHẬP
        // =========================================================
        public void xoaPN(string MaPhieu)
        {
            // Xóa đúng file PhieuNhap.xml (FileXml tự thêm folder Data)
            Fxml.Xoa("PhieuNhap.xml", "PhieuNhap", "MaPhieu", MaPhieu);
        }
    }
}
