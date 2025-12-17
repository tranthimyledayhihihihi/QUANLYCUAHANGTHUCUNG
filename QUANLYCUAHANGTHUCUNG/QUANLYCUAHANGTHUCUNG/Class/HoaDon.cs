using System;
using System.Data;
using System.Xml;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung.Class
{
    class HoaDonBLL
    {
        FileXml Fxml = new FileXml();

        // ===============================================
<<<<<<< HEAD
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
        // 2) THÊM HÓA ĐƠN (CHỈ DÙNG XML)
        // ===============================================
        public int ThemHD(
     string MaNhanVien,
     string MaKhachHang,
     string NgayLap,
     decimal TongTien
 )
        {
            // 1️⃣ KIỂM TRA NHÂN VIÊN
            DataTable dtNV = Fxml.HienThi("NhanVien.xml");
            bool tonTaiNV = dtNV.AsEnumerable()
                .Any(r => r["MaNhanVien"].ToString() == MaNhanVien);

            if (!tonTaiNV)
            {
                MessageBox.Show(
                    $"❌ Nhân viên {MaNhanVien} không tồn tại.\nKhông thể tạo hóa đơn!",
                    "Lỗi nghiệp vụ"
                );
                return 0;
            }

            // 2️⃣ KIỂM TRA KHÁCH HÀNG
            DataTable dtKH = Fxml.HienThi("KhachHang.xml");
            bool tonTaiKH = dtKH.AsEnumerable()
                .Any(r => r["MaKhachHang"].ToString() == MaKhachHang);

            if (!tonTaiKH)
            {
                MessageBox.Show(
                    $"❌ Khách hàng {MaKhachHang} không tồn tại.\nKhông thể tạo hóa đơn!",
                    "Lỗi nghiệp vụ"
                );
                return 0;
            }

            // 3️⃣ SAU KHI HỢP LỆ → MỚI TẠO HÓA ĐƠN XML
            int soHDMoi = LaySoHoaDonTiepTheo();

            string noiDung =
                "<HoaDon>" +
                    "<SoHoaDon>" + soHDMoi + "</SoHoaDon>" +
                    "<MaNhanVien>" + MaNhanVien + "</MaNhanVien>" +
                    "<MaKhachHang>" + MaKhachHang + "</MaKhachHang>" +
                    "<NgayLap>" + NgayLap + "</NgayLap>" +
                    "<TongTien>" + TongTien + "</TongTien>" +
                "</HoaDon>";

            Fxml.Them("HoaDon.xml", noiDung);

            return soHDMoi;
        }
        // 3) THÊM CHI TIẾT HÓA ĐƠN (CHỈ DÙNG XML)
        // ===============================================
        public void ThemCTHD(
            int SoHoaDon,
            string MaMatHang,
            string LoaiMatHang,
            int SoLuong,
            decimal DonGiaBan
        )
        {
            // Ghi dữ liệu vào file XML
            string noiDung =
                "<ChiTietHoaDon>" +
                    "<SoHoaDon>" + SoHoaDon + "</SoHoaDon>" +
                    // Kiểm tra và xử lý NULL an toàn
                    "<MaMatHang>" + (MaMatHang ?? "") + "</MaMatHang>" +
                    "<LoaiMatHang>" + (LoaiMatHang ?? "") + "</LoaiMatHang>" +
                    "<SoLuong>" + SoLuong + "</SoLuong>" +
                    "<DonGiaBan>" + DonGiaBan + "</DonGiaBan>" +
                "</ChiTietHoaDon>";

            Fxml.Them("ChiTietHoaDon.xml", noiDung); // Thao tác duy nhất là XML
        }

        // ===============================================
        // 4) XÓA HÓA ĐƠN + CHI TIẾT (CHỈ DÙNG XML)
        // ===============================================
        public void XoaHD(int SoHoaDon)
        {
            // Thao tác xóa trên file XML ChiTietHoaDon
            DataTable dtCT = Fxml.HienThi("ChiTietHoaDon.xml");

            if (dtCT != null)
            {
                // Logic xóa lặp lại nhiều lần cho cùng một khóa phụ (SoHoaDon)
                // đảm bảo tất cả các chi tiết liên quan đều bị xóa.
                int rowsBefore = dtCT.AsEnumerable()
                                     .Count(r => r["SoHoaDon"].ToString() == SoHoaDon.ToString());

                for (int i = 0; i < rowsBefore; i++)
                {
                    Fxml.Xoa(
                        "ChiTietHoaDon.xml",
                        "ChiTietHoaDon",
                        "SoHoaDon",
                        SoHoaDon.ToString()
                    );
                }
            }

            // Thao tác xóa trên file XML HoaDon
            Fxml.Xoa("HoaDon.xml", "HoaDon", "SoHoaDon", SoHoaDon.ToString());
        }
    }
}
>>>>>>> origin/Trần-Thị-Mỹ
