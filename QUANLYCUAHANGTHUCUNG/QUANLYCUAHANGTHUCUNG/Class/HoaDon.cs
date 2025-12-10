using System;
using System.Data;
using System.Xml;
using System.Linq;

namespace QuanLyCuaHangThuCung.Class
{
    class HoaDonBLL
    {
        FileXml Fxml = new FileXml();

        // ===============================================
        // 1) LẤY SỐ HÓA ĐƠN TIẾP THEO
        // ===============================================
        public int LaySoHoaDonTiepTheo()
        {
            DataTable dt = Fxml.HienThi("HoaDon.xml");

            if (dt == null || dt.Rows.Count == 0)
                return 1001;        // bắt đầu từ 1001

            return dt.AsEnumerable()
                .Max(row => int.Parse(row["SoHoaDon"].ToString())) + 1;
        }

        // ===============================================
        // 2) THÊM HÓA ĐƠN
        // ===============================================
        public int ThemHD(string MaNhanVien, string MaKhachHang, string NgayLap, int TongTien)
        {
            int soHDMoi = LaySoHoaDonTiepTheo();

            string noiDung =
                "<HoaDon>" +
                "<SoHoaDon>" + soHDMoi + "</SoHoaDon>" +
                "<MaNhanVien>" + MaNhanVien + "</MaNhanVien>" +
                "<MaKhachHang>" + MaKhachHang + "</MaKhachHang>" +
                "<NgayLap>" + NgayLap + "</NgayLap>" +
                "<TongTien>" + TongTien + "</TongTien>" +
                "</HoaDon>";

            Fxml.Them("Data\\HoaDon.xml", noiDung);

            return soHDMoi;
        }

        // ===============================================
        // 3) THÊM CHI TIẾT HÓA ĐƠN (SP - TC - DV)
        // ===============================================
        public void ThemCTHD(int SoHoaDon, string MaMatHang, string LoaiMatHang, int SoLuong, int DonGiaBan)
        {
            string noiDung =
                "<ChiTietHoaDon>" +
                "<SoHoaDon>" + SoHoaDon + "</SoHoaDon>" +
                "<MaMatHang>" + MaMatHang + "</MaMatHang>" +
                "<LoaiMatHang>" + LoaiMatHang + "</LoaiMatHang>" +
                "<SoLuong>" + SoLuong + "</SoLuong>" +
                "<DonGiaBan>" + DonGiaBan + "</DonGiaBan>" +
                "</ChiTietHoaDon>";

            Fxml.Them("Data\\ChiTietHoaDon.xml", noiDung);

            // =============================
            // HOOK: CẬP NHẬT KHO (tùy bạn)
            // =============================
            if (LoaiMatHang == "SP")
            {
                // TODO: giảm số lượng tồn của sản phẩm
            }
            else if (LoaiMatHang == "TC")
            {
                // TODO: đánh dấu thú cưng = ĐÃ BÁN
            }
        }

        // ===============================================
        // 4) XÓA HÓA ĐƠN + CHI TIẾT
        // ===============================================
        public void XoaHD(int SoHoaDon)
        {
            // XÓA CÁC DÒNG CHI TIẾT
            DataTable dtCT = Fxml.HienThi("ChiTietHoaDon.xml");
            if (dtCT != null)
            {
                var rows = dtCT.AsEnumerable()
                    .Where(r => r["SoHoaDon"].ToString() == SoHoaDon.ToString())
                    .ToList();

                foreach (var row in rows)
                {
                    string maMH = row["MaMatHang"].ToString();
                    Fxml.Xoa("ChiTietHoaDon.xml", "ChiTietHoaDon", "MaMatHang", maMH);
                }
            }

            // XÓA HÓA ĐƠN
            Fxml.Xoa("HoaDon.xml", "HoaDon", "SoHoaDon", SoHoaDon.ToString());
        }
    }
}
