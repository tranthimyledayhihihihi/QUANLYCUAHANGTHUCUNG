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

            Fxml.Them("NhanVien.xml", noiDung);
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

            Fxml.Sua("NhanVien.xml", "NhanVien", "MaNhanVien", MaNhanVien, noiDung);
        }

        // ===================================================
        // 4) XÓA NHÂN VIÊN
        // ===================================================
        public void xoaNV(string MaNhanVien)
        {
            Fxml.Xoa("NhanVien.xml", "NhanVien", "MaNhanVien", MaNhanVien);
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
