// File: KhachHangBLL.cs
using System.Xml;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung.Class
{
    class KhachHangBLL
    {
        FileXml Fxml = new FileXml();

        // ===========================================
        // 1) KIỂM TRA MÃ KHÁCH HÀNG TỒN TẠI
        // ===========================================
        public bool kiemtraMaKhachHang(string MaKhachHang)
        {
            try
            {
                string giaTri = Fxml.LayGiaTri("KhachHang.xml", "MaKhachHang", MaKhachHang, "MaKhachHang");
                return !string.IsNullOrEmpty(giaTri);
            }
            catch
            {
                MessageBox.Show("Không tìm thấy file Data/KhachHang.xml.\nHãy đồng bộ dữ liệu.");
                return false;
            }
        }

        // ===========================================
        // 2) THÊM KHÁCH HÀNG
        // ===========================================
        public void themKH(string MaKhachHang, string TenKhachHang, string SDT, string DiaChi)
        {
            string noiDung =
                "<KhachHang>" +
                "<MaKhachHang>" + MaKhachHang + "</MaKhachHang>" +
                "<TenKhachHang>" + TenKhachHang + "</TenKhachHang>" +
                "<SDT>" + SDT + "</SDT>" +
                "<DiaChi>" + DiaChi + "</DiaChi>" +
                "<DiemTichLuy>0</DiemTichLuy>" +
                "</KhachHang>";

            Fxml.Them("KhachHang.xml", noiDung);
        }

        // ===========================================
        // 3) SỬA KHÁCH HÀNG
        // ===========================================
        public void suaKH(string MaKhachHang, string TenKhachHang, string SDT, string DiaChi, int DiemTichLuy)
        {
            string noiDung =
                "<MaKhachHang>" + MaKhachHang + "</MaKhachHang>" +
                "<TenKhachHang>" + TenKhachHang + "</TenKhachHang>" +
                "<SDT>" + SDT + "</SDT>" +
                "<DiaChi>" + DiaChi + "</DiaChi>" +
                "<DiemTichLuy>" + DiemTichLuy.ToString() + "</DiemTichLuy>";

            Fxml.Sua("KhachHang.xml", "KhachHang", "MaKhachHang", MaKhachHang, noiDung);
        }

        // ===========================================
        // 4) XÓA KHÁCH HÀNG
        // ===========================================
        public void xoaKH(string MaKhachHang)
        {
            Fxml.Xoa("KhachHang.xml", "KhachHang", "MaKhachHang", MaKhachHang);
        }

        // ===========================================
        // 5) LOAD KHÁCH HÀNG
        // ===========================================
        public DataTable LoadTable()
        {
            return Fxml.HienThi("KhachHang.xml");
        }
    }
}
