using System;
using System.Data;

namespace QuanLyCuaHangThuCung.Class
{
    class ThuCung
    {
        FileXml Fxml = new FileXml();
        string file = "ThuCung.xml";   // File đọc trong thư mục Data\ThuCung.xml

        // ==========================================================
        // 1. KIỂM TRA MÃ THÚ CƯNG
        // ==========================================================
        public bool KiemTra(string ma)
        {
            string value = Fxml.LayGiaTri(file, "MaThuCung", ma, "MaThuCung");
            return !string.IsNullOrEmpty(value);
        }

        // ==========================================================
        // 2. THÊM THÚ CƯNG
        // ==========================================================
        public void Them(
            string ma,
            string ten,
            string loai,
            string giong,
            string gioitinh,
            string ngaysinh,
            string gianhap,
            string giaban,
            string mancc,
            string trangthai)
        {
            string node =
                "<ThuCung>" +
                    "<MaThuCung>" + ma + "</MaThuCung>" +
                    "<TenThuCung>" + ten + "</TenThuCung>" +
                    "<LoaiThuCung>" + loai + "</LoaiThuCung>" +
                    "<Giong>" + giong + "</Giong>" +
                    "<GioiTinh>" + gioitinh + "</GioiTinh>" +
                    "<NgaySinh>" + ngaysinh + "</NgaySinh>" +
                    "<GiaNhap>" + gianhap + "</GiaNhap>" +
                    "<GiaBan>" + giaban + "</GiaBan>" +
                    "<MaNCC>" + mancc + "</MaNCC>" +
                    "<TrangThai>" + trangthai + "</TrangThai>" +
                "</ThuCung>";

            // GHI CHÍNH XÁC VÀO Data\ThuCung.xml (KHÔNG thêm “Data\\”)
            Fxml.Them(file, node);
        }

        // ==========================================================
        // 3. SỬA THÚ CƯNG
        // ==========================================================
        public void Sua(
            string ma,
            string ten,
            string loai,
            string giong,
            string gioitinh,
            string ngaysinh,
            string gianhap,
            string giaban,
            string mancc,
            string trangthai)
        {
            string node =
                "<MaThuCung>" + ma + "</MaThuCung>" +
                "<TenThuCung>" + ten + "</TenThuCung>" +
                "<LoaiThuCung>" + loai + "</LoaiThuCung>" +
                "<Giong>" + giong + "</Giong>" +
                "<GioiTinh>" + gioitinh + "</GioiTinh>" +
                "<NgaySinh>" + ngaysinh + "</NgaySinh>" +
                "<GiaNhap>" + gianhap + "</GiaNhap>" +
                "<GiaBan>" + giaban + "</GiaBan>" +
                "<MaNCC>" + mancc + "</MaNCC>" +
                "<TrangThai>" + trangthai + "</TrangThai>";

            Fxml.Sua(file, "ThuCung", "MaThuCung", ma, node);
        }

        // ==========================================================
        // 4. XÓA
        // ==========================================================
        public void Xoa(string ma)
        {
            Fxml.Xoa(file, "ThuCung", "MaThuCung", ma);
        }

        // ==========================================================
        // 5. LOAD DATA
        // ==========================================================
        public DataTable Load()
        {
            return Fxml.HienThi(file);
        }
    }
}
