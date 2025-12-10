using System.Data;
using System.Xml;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung.Class
{
    class SanPham
    {
        FileXml Fxml = new FileXml();

        // ==========================================================
        // 1) KIỂM TRA MÃ SẢN PHẨM
        // ==========================================================
        public bool kiemtraMaSP(string MaSP)
        {
            try
            {
                string value = Fxml.LayGiaTri("SanPham.xml", "MaSP", MaSP, "MaSP");
                return !string.IsNullOrEmpty(value);
            }
            catch
            {
                MessageBox.Show("Không tìm thấy file Data/SanPham.xml. Hãy đồng bộ dữ liệu!");
                return false;
            }
        }

        // ==========================================================
        // 2) THÊM SẢN PHẨM
        // ==========================================================
        public void themSP(string MaSP, string TenSP, string LoaiSP,
                           string DonViTinh, int DonGiaBan, int SoLuongTon, string MaNCC)
        {
            string noiDung =
                "<SanPham>" +
                "<MaSP>" + MaSP + "</MaSP>" +
                "<TenSP>" + TenSP + "</TenSP>" +
                "<LoaiSP>" + LoaiSP + "</LoaiSP>" +
                "<DonViTinh>" + DonViTinh + "</DonViTinh>" +
                "<DonGiaBan>" + DonGiaBan + "</DonGiaBan>" +
                "<SoLuongTon>" + SoLuongTon + "</SoLuongTon>" +
                "<MaNCC>" + MaNCC + "</MaNCC>" +
                "</SanPham>";

            // Ghi đúng vào Data\SanPham.xml
            Fxml.Them("Data\\SanPham.xml", noiDung);
        }

        // ==========================================================
        // 3) SỬA SẢN PHẨM
        // ==========================================================
        public void suaSP(string MaSP, string TenSP, string LoaiSP,
                          string DonViTinh, int DonGiaBan, int SoLuongTon, string MaNCC)
        {
            string noiDung =
                "<MaSP>" + MaSP + "</MaSP>" +
                "<TenSP>" + TenSP + "</TenSP>" +
                "<LoaiSP>" + LoaiSP + "</LoaiSP>" +
                "<DonViTinh>" + DonViTinh + "</DonViTinh>" +
                "<DonGiaBan>" + DonGiaBan + "</DonGiaBan>" +
                "<SoLuongTon>" + SoLuongTon + "</SoLuongTon>" +
                "<MaNCC>" + MaNCC + "</MaNCC>";

            Fxml.Sua("Data\\SanPham.xml", "SanPham", "MaSP", MaSP, noiDung);
        }

        // ==========================================================
        // 4) XÓA SẢN PHẨM
        // ==========================================================
        public void xoaSP(string MaSP)
        {
            // XÓA dùng path ngắn → FileXml.Xoa tự tìm trong Data\
            Fxml.Xoa("SanPham.xml", "SanPham", "MaSP", MaSP);
        }

        // ==========================================================
        // 5) LOAD BẢNG SẢN PHẨM
        // ==========================================================
        public DataTable LoadTable()
        {
            return Fxml.HienThi("SanPham.xml");
        }
    }
}
