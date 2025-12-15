using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyCuaHangThuCung.Class
{
    class HeThong
    {
        FileXml Fxml = new FileXml();

        // =================================================
        // IMPORT NHÂN VIÊN (BẢNG CHA)
        // =================================================
        private void ImportNhanVien(DataTable dt)
        {
            using (SqlConnection conn = new SqlConnection(Fxml.Conn))
            {
                conn.Open();
                foreach (DataRow r in dt.Rows)
                {
                    SqlCommand cmd = new SqlCommand(@"
                        IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaNhanVien=@Ma)
                        INSERT INTO NhanVien(MaNhanVien, TenNhanVien, SDT, DiaChi, Email)
                        VALUES (@Ma, @Ten, @SDT, @DiaChi, @Email)
                    ", conn);

                    cmd.Parameters.AddWithValue("@Ma", r["MaNhanVien"]);
                    cmd.Parameters.AddWithValue("@Ten", r.Table.Columns.Contains("TenNhanVien") ? r["TenNhanVien"] : "");
                    cmd.Parameters.AddWithValue("@SDT", r.Table.Columns.Contains("SDT") ? r["SDT"] : "");
                    cmd.Parameters.AddWithValue("@DiaChi", r.Table.Columns.Contains("DiaChi") ? r["DiaChi"] : "");
                    cmd.Parameters.AddWithValue("@Email", r.Table.Columns.Contains("Email") ? r["Email"] : "");

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // =================================================
        // IMPORT KHÁCH HÀNG (BẢNG CHA)
        // =================================================
        private void ImportKhachHang(DataTable dt)
        {
            using (SqlConnection conn = new SqlConnection(Fxml.Conn))
            {
                conn.Open();
                foreach (DataRow r in dt.Rows)
                {
                    SqlCommand cmd = new SqlCommand(@"
                        IF NOT EXISTS (SELECT 1 FROM KhachHang WHERE MaKhachHang=@Ma)
                        INSERT INTO KhachHang(MaKhachHang, TenKhachHang, SDT, DiaChi)
                        VALUES (@Ma, @Ten, @SDT, @DiaChi)
                    ", conn);

                    cmd.Parameters.AddWithValue("@Ma", r["MaKhachHang"]);
                    cmd.Parameters.AddWithValue("@Ten", r["TenKhachHang"]);
                    cmd.Parameters.AddWithValue("@SDT", r.Table.Columns.Contains("SDT") ? r["SDT"] : "");
                    cmd.Parameters.AddWithValue("@DiaChi", r.Table.Columns.Contains("DiaChi") ? r["DiaChi"] : "");

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // =================================================
        // IMPORT HÓA ĐƠN (IDENTITY → MAP XML → SQL)
        // =================================================
        private Dictionary<int, int> ImportHoaDon(DataTable dt)
        {
            Dictionary<int, int> mapHoaDon = new Dictionary<int, int>();

            using (SqlConnection conn = new SqlConnection(Fxml.Conn))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        int soHoaDonXML = Convert.ToInt32(r["SoHoaDon"]);

                        SqlCommand cmd = new SqlCommand(@"
                            INSERT INTO HoaDon
                            (MaNhanVien, MaKhachHang, NgayLap, TongTien)
                            VALUES (@MaNV, @MaKH, @NgayLap, @TongTien);
                            SELECT CAST(SCOPE_IDENTITY() AS INT);
                        ", conn, tran);

                        cmd.Parameters.AddWithValue("@MaNV", r["MaNhanVien"]);
                        cmd.Parameters.AddWithValue("@MaKH", r["MaKhachHang"]);
                        cmd.Parameters.AddWithValue("@NgayLap",
                            r["NgayLap"] == DBNull.Value ? DBNull.Value : r["NgayLap"]);
                        cmd.Parameters.AddWithValue("@TongTien",
                            r["TongTien"] == DBNull.Value ? 0 : r["TongTien"]);

                        int soHoaDonSQL = (int)cmd.ExecuteScalar();

                        // MAP XML → SQL
                        mapHoaDon.Add(soHoaDonXML, soHoaDonSQL);
                    }

                    tran.Commit();
                    return mapHoaDon;
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }

        // =================================================
        // IMPORT CHI TIẾT HÓA ĐƠN (DÙNG MAP)
        // =================================================
        private void ImportChiTietHoaDon(
            DataTable dt,
            Dictionary<int, int> mapHoaDon)
        {
            using (SqlConnection conn = new SqlConnection(Fxml.Conn))
            {
                conn.Open();

                foreach (DataRow r in dt.Rows)
                {
                    int soHoaDonXML = Convert.ToInt32(r["SoHoaDon"]);

                    // ❗ Nếu không map được → bỏ
                    if (!mapHoaDon.ContainsKey(soHoaDonXML))
                        continue;

                    int soHoaDonSQL = mapHoaDon[soHoaDonXML];

                    SqlCommand cmd = new SqlCommand(@"
                        INSERT INTO ChiTietHoaDon
                        (SoHoaDon, MaMatHang, LoaiMatHang, SoLuong, DonGiaBan)
                        VALUES (@SoHD, @MaMH, @Loai, @SL, @Gia)
                    ", conn);

                    cmd.Parameters.AddWithValue("@SoHD", soHoaDonSQL);
                    cmd.Parameters.AddWithValue("@MaMH", r["MaMatHang"]);
                    cmd.Parameters.AddWithValue("@Loai", r["LoaiMatHang"]);
                    cmd.Parameters.AddWithValue("@SL", r["SoLuong"]);
                    cmd.Parameters.AddWithValue("@Gia", r["DonGiaBan"]);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // =================================================
        // IMPORT TOÀN BỘ XML → SQL (HÀM DUY NHẤT GỌI)
        // =================================================
        public void CapNhapSQL()
        {
            try
            {
                // CHA
                ImportNhanVien(Fxml.HienThi("NhanVien.xml"));
                ImportKhachHang(Fxml.HienThi("KhachHang.xml"));

                // CHA có IDENTITY
                Dictionary<int, int> mapHoaDon =
                    ImportHoaDon(Fxml.HienThi("HoaDon.xml"));

                // CON
                ImportChiTietHoaDon(
                    Fxml.HienThi("ChiTietHoaDon.xml"),
                    mapHoaDon
                );

                MessageBox.Show(
                    "✅ Import XML → SQL thành công!",
                    "Hoàn tất",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "❌ Lỗi import: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =================================================
        // TẠO XML TỪ DATABASE (GIỮ NGUYÊN)
        // =================================================
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

            MessageBox.Show(
                "Đã tạo / cập nhật XML từ SQL!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
