using System;
using System.Data;

namespace QuanLyCuaHangThuCung.Class
{
    class HeThong
    {
        // ===============================
        // 1) THÔNG TIN NGƯỜI ĐĂNG NHẬP
        // ===============================
        public static string MaNhanVien = "";
        public static string TenNhanVien = "";
        public static int Quyen = 0;

        FileXml Fxml = new FileXml();

        // ===============================
        // 2) TẠO FILE XML TỪ DATABASE
        // ===============================
        public void TaoXML()
        {
            string[] bang =
            {
                "NhanVien","TaiKhoan","NhaCungCap","KhachHang",
                "ThuCung","SanPham","DichVu",
                "HoaDon","ChiTietHoaDon","PhieuNhap",
                "LichHen","ChamCong"
            };

            foreach (string b in bang)
                Fxml.TaoXML(b);
        }

        // ======================================================
        // 3) CHÉP XML → SQL (insert đúng cột, không sai schema)
        // ======================================================
        private void ImportBang(string tenBang)
        {
            string file = tenBang + ".xml";
            DataTable dt = Fxml.HienThi(file);

            if (dt == null || dt.Rows.Count == 0)
                return;

            foreach (DataRow row in dt.Rows)
            {
                string sql = $"INSERT INTO {tenBang}(";

                // Danh sách cột
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sql += dt.Columns[i].ColumnName;
                    if (i < dt.Columns.Count - 1) sql += ",";
                }

                sql += ") VALUES(";

                // Giá trị cột
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    string val = row[i].ToString().Replace("'", "''");

                    sql += "N'" + val + "'";
                    if (i < dt.Columns.Count - 1) sql += ",";
                }

                sql += ")";

                Fxml.InsertOrUpDateSQL(sql);
            }
        }

        // =============================================
        // 4) RESET DATABASE → NHẬP XML VÀO LẠI
        // =============================================
        public void CapNhapSQL()
        {
            // Xóa bảng theo đúng thứ tự FK
            string[] xoa =
            {
                "ChiTietHoaDon","HoaDon","PhieuNhap","LichHen",
                "ThuCung","SanPham","DichVu",
                "KhachHang","ChamCong",
                "TaiKhoan","NhanVien","NhaCungCap"
            };

            foreach (string b in xoa)
                Fxml.InsertOrUpDateSQL($"DELETE FROM {b}");

            // Import theo đúng thứ tự
            string[] nhap =
            {
                "NhaCungCap","NhanVien","TaiKhoan","KhachHang",
                "DichVu","ThuCung","SanPham",
                "HoaDon","ChiTietHoaDon","PhieuNhap",
                "LichHen","ChamCong"
            };

            foreach (string b in nhap)
                ImportBang(b);
        }
    }
}
