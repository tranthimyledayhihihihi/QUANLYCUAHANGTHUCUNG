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

        // 1. IMPORT CÁC BẢNG ĐỘC LẬP (Bảng Cha)
        private void ImportBảngCha(DataTable dtNhaCC, DataTable dtNV, DataTable dtKH, DataTable dtDV)
        {
            using (SqlConnection conn = new SqlConnection(Fxml.Conn))
            {
                conn.Open();
                // Nhà Cung Cấp
                foreach (DataRow r in dtNhaCC.Rows)
                {
                    SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT 1 FROM NhaCungCap WHERE MaNCC=@Ma) INSERT INTO NhaCungCap VALUES (@Ma,@Ten,@DC,@SDT,@Email,@MoTa)", conn);
                    cmd.Parameters.AddWithValue("@Ma", r["MaNCC"]);
                    cmd.Parameters.AddWithValue("@Ten", r["TenNCC"]);
                    cmd.Parameters.AddWithValue("@DC", r["DiaChi"]);
                    cmd.Parameters.AddWithValue("@SDT", r["SDT"]);
                    cmd.Parameters.AddWithValue("@Email", r.Table.Columns.Contains("Email") ? r["Email"] : "");
                    cmd.Parameters.AddWithValue("@MoTa", r.Table.Columns.Contains("MoTa") ? r["MoTa"] : "");
                    cmd.ExecuteNonQuery();
                }
                // Nhân Viên
                foreach (DataRow r in dtNV.Rows)
                {
                    SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE MaNhanVien=@Ma) INSERT INTO NhanVien VALUES (@Ma,@Ten,@NS,@DC,@SDT,@Email)", conn);
                    cmd.Parameters.AddWithValue("@Ma", r["MaNhanVien"]);
                    cmd.Parameters.AddWithValue("@Ten", r["TenNhanVien"]);
                    cmd.Parameters.AddWithValue("@NS", r["NgaySinh"]);
                    cmd.Parameters.AddWithValue("@DC", r["DiaChi"]);
                    cmd.Parameters.AddWithValue("@SDT", r["SDT"]);
                    cmd.Parameters.AddWithValue("@Email", r["Email"]);
                    cmd.ExecuteNonQuery();
                }
                // Khách Hàng
                foreach (DataRow r in dtKH.Rows)
                {
                    SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT 1 FROM KhachHang WHERE MaKhachHang=@Ma) INSERT INTO KhachHang VALUES (@Ma,@Ten,@SDT,@DC,@Diem)", conn);
                    cmd.Parameters.AddWithValue("@Ma", r["MaKhachHang"]);
                    cmd.Parameters.AddWithValue("@Ten", r["TenKhachHang"]);
                    cmd.Parameters.AddWithValue("@SDT", r["SDT"]);
                    cmd.Parameters.AddWithValue("@DC", r["DiaChi"]);
                    cmd.Parameters.AddWithValue("@Diem", r["DiemTichLuy"]);
                    cmd.ExecuteNonQuery();
                }
                // Dịch Vụ
                foreach (DataRow r in dtDV.Rows)
                {
                    SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT 1 FROM DichVu WHERE MaDV=@Ma) INSERT INTO DichVu VALUES (@Ma,@Ten,@Gia,@TG)", conn);
                    cmd.Parameters.AddWithValue("@Ma", r["MaDV"]);
                    cmd.Parameters.AddWithValue("@Ten", r["TenDV"]);
                    cmd.Parameters.AddWithValue("@Gia", r["GiaDV"]);
                    cmd.Parameters.AddWithValue("@TG", r["ThoiGianThucHien"]);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 2. IMPORT TÀI KHOẢN VÀ CHẤM CÔNG
        private void ImportNghiepVuNhanVien(DataTable dtTK, DataTable dtCC)
        {
            using (SqlConnection conn = new SqlConnection(Fxml.Conn))
            {
                conn.Open();
                foreach (DataRow r in dtTK.Rows)
                {
                    SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT 1 FROM TaiKhoan WHERE MaNhanVien=@Ma) INSERT INTO TaiKhoan VALUES (@Ma,@MK,@Quyen)", conn);
                    cmd.Parameters.AddWithValue("@Ma", r["MaNhanVien"]);
                    cmd.Parameters.AddWithValue("@MK", r["MatKhau"]);
                    cmd.Parameters.AddWithValue("@Quyen", r["Quyen"]);
                    cmd.ExecuteNonQuery();
                }
                foreach (DataRow r in dtCC.Rows)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO ChamCong (MaNhanVien, Ngay, Thang, Nam) VALUES (@Ma,@N,@T,@Nam)", conn);
                    cmd.Parameters.AddWithValue("@Ma", r["MaNhanVien"]);
                    cmd.Parameters.AddWithValue("@N", r["Ngay"]);
                    cmd.Parameters.AddWithValue("@T", r["Thang"]);
                    cmd.Parameters.AddWithValue("@Nam", r["Nam"]);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 3. IMPORT SẢN PHẨM VÀ THÚ CƯNG
        private void ImportHangHoa(DataTable dtSP, DataTable dtTC)
        {
            using (SqlConnection conn = new SqlConnection(Fxml.Conn))
            {
                conn.Open();
                foreach (DataRow r in dtSP.Rows)
                {
                    SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT 1 FROM SanPham WHERE MaSP=@Ma) INSERT INTO SanPham VALUES (@Ma,@Ten,@Loai,@DVT,@Gia,@SL,@NCC)", conn);
                    cmd.Parameters.AddWithValue("@Ma", r["MaSP"]);
                    cmd.Parameters.AddWithValue("@Ten", r["TenSP"]);
                    cmd.Parameters.AddWithValue("@Loai", r["LoaiSP"]);
                    cmd.Parameters.AddWithValue("@DVT", r["DonViTinh"]);
                    cmd.Parameters.AddWithValue("@Gia", r["DonGiaBan"]);
                    cmd.Parameters.AddWithValue("@SL", r["SoLuongTon"]);
                    cmd.Parameters.AddWithValue("@NCC", r["MaNCC"]);
                    cmd.ExecuteNonQuery();
                }
                foreach (DataRow r in dtTC.Rows)
                {
                    SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT 1 FROM ThuCung WHERE MaThuCung=@Ma) INSERT INTO ThuCung VALUES (@Ma,@Ten,@Loai,@Giong,@GT,@NS,@GiaN,@GiaB,@NCC,@TT)", conn);
                    cmd.Parameters.AddWithValue("@Ma", r["MaThuCung"]);
                    cmd.Parameters.AddWithValue("@Ten", r["TenThuCung"]);
                    cmd.Parameters.AddWithValue("@Loai", r["LoaiThuCung"]);
                    cmd.Parameters.AddWithValue("@Giong", r["Giong"]);
                    cmd.Parameters.AddWithValue("@GT", r["GioiTinh"]);
                    cmd.Parameters.AddWithValue("@NS", r["NgaySinh"]);
                    cmd.Parameters.AddWithValue("@GiaN", r["GiaNhap"]);
                    cmd.Parameters.AddWithValue("@GiaB", r["GiaBan"]);
                    cmd.Parameters.AddWithValue("@NCC", r["MaNCC"]);
                    cmd.Parameters.AddWithValue("@TT", r["TrangThai"]);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 4. IMPORT LỊCH HẸN VÀ PHIẾU NHẬP
        private void ImportGiaoDichKhac(DataTable dtLH, DataTable dtPN)
        {
            using (SqlConnection conn = new SqlConnection(Fxml.Conn))
            {
                conn.Open();
                foreach (DataRow r in dtLH.Rows)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO LichHen (MaKhachHang, MaDichVu, NgayHen, GioHen, TrangThai) VALUES (@MaKH,@MaDV,@Ngay,@Gio,@TT)", conn);
                    cmd.Parameters.AddWithValue("@MaKH", r["MaKhachHang"]);
                    cmd.Parameters.AddWithValue("@MaDV", r["MaDichVu"]);
                    cmd.Parameters.AddWithValue("@Ngay", r["NgayHen"]);
                    cmd.Parameters.AddWithValue("@Gio", r["GioHen"]);
                    cmd.Parameters.AddWithValue("@TT", r["TrangThai"]);
                    cmd.ExecuteNonQuery();
                }
                // Phiếu nhập: Trigger SQL sẽ tự cập nhật kho khi Insert vào đây
                foreach (DataRow r in dtPN.Rows)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO PhieuNhap (MaMatHang, LoaiMatHang, MaNhanVien, SoLuongNhap, NgayLapPhieu) VALUES (@MaMH,@Loai,@MaNV,@SL,@Ngay)", conn);
                    cmd.Parameters.AddWithValue("@MaMH", r["MaMatHang"]);
                    cmd.Parameters.AddWithValue("@Loai", r["LoaiMatHang"]);
                    cmd.Parameters.AddWithValue("@MaNV", r["MaNhanVien"]);
                    cmd.Parameters.AddWithValue("@SL", r["SoLuongNhap"]);
                    cmd.Parameters.AddWithValue("@Ngay", r["NgayLapPhieu"]);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 5. IMPORT HÓA ĐƠN & CHI TIẾT (Xử lý SCOPE_IDENTITY)
        private Dictionary<int, int> ImportHoaDon(DataTable dt)
        {
            Dictionary<int, int> mapHoaDon = new Dictionary<int, int>();
            using (SqlConnection conn = new SqlConnection(Fxml.Conn))
            {
                conn.Open();
                foreach (DataRow r in dt.Rows)
                {
                    int soHoaDonXML = Convert.ToInt32(r["SoHoaDon"]);
                    SqlCommand cmd = new SqlCommand("INSERT INTO HoaDon (MaNhanVien, MaKhachHang, NgayLap, TongTien) VALUES (@MaNV, @MaKH, @Ngay, @Tong); SELECT CAST(SCOPE_IDENTITY() AS INT);", conn);
                    cmd.Parameters.AddWithValue("@MaNV", r["MaNhanVien"]);
                    cmd.Parameters.AddWithValue("@MaKH", r["MaKhachHang"]);
                    cmd.Parameters.AddWithValue("@Ngay", r["NgayLap"]);
                    cmd.Parameters.AddWithValue("@Tong", r["TongTien"]);
                    int soHoaDonSQL = (int)cmd.ExecuteScalar();
                    mapHoaDon.Add(soHoaDonXML, soHoaDonSQL);
                }
            }
            return mapHoaDon;
        }

        private void ImportChiTietHoaDon(DataTable dt, Dictionary<int, int> mapHD)
        {
            using (SqlConnection conn = new SqlConnection(Fxml.Conn))
            {
                conn.Open();
                foreach (DataRow r in dt.Rows)
                {
                    int soXML = Convert.ToInt32(r["SoHoaDon"]);
                    if (!mapHD.ContainsKey(soXML)) continue;
                    // Trigger SQL sẽ tự giảm kho khi Insert vào đây
                    SqlCommand cmd = new SqlCommand("INSERT INTO ChiTietHoaDon (SoHoaDon, MaMatHang, LoaiMatHang, SoLuong, DonGiaBan) VALUES (@SoHD, @MaMH, @Loai, @SL, @Gia)", conn);
                    cmd.Parameters.AddWithValue("@SoHD", mapHD[soXML]);
                    cmd.Parameters.AddWithValue("@MaMH", r["MaMatHang"]);
                    cmd.Parameters.AddWithValue("@Loai", r["LoaiMatHang"]);
                    cmd.Parameters.AddWithValue("@SL", r["SoLuong"]);
                    cmd.Parameters.AddWithValue("@Gia", r["DonGiaBan"]);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // =================================================
        // HÀM TỔNG GỌI TỪ GIAO DIỆN
        // =================================================
        public void CapNhapSQL()
        {
            try
            {
                // Thứ tự cực kỳ quan trọng để không lỗi Foreign Key
                ImportBảngCha(Fxml.HienThi("NhaCungCap.xml"), Fxml.HienThi("NhanVien.xml"), Fxml.HienThi("KhachHang.xml"), Fxml.HienThi("DichVu.xml"));
                ImportNghiepVuNhanVien(Fxml.HienThi("TaiKhoan.xml"), Fxml.HienThi("ChamCong.xml"));
                ImportHangHoa(Fxml.HienThi("SanPham.xml"), Fxml.HienThi("ThuCung.xml"));
                ImportGiaoDichKhac(Fxml.HienThi("LichHen.xml"), Fxml.HienThi("PhieuNhap.xml"));

                Dictionary<int, int> mapHD = ImportHoaDon(Fxml.HienThi("HoaDon.xml"));
                ImportChiTietHoaDon(Fxml.HienThi("ChiTietHoaDon.xml"), mapHD);

                MessageBox.Show("✅ Đã chuyển đổi thành công tất cả 12 bảng sang SQL Server!", "Hoàn tất");
            }
            catch (Exception ex) { MessageBox.Show("❌ Lỗi: " + ex.Message); }
        }

        public void TaoXML()
        {
            string[] bang = { "NhaCungCap", "KhachHang", "NhanVien", "TaiKhoan", "ChamCong", "DichVu", "ThuCung", "SanPham", "PhieuNhap", "HoaDon", "ChiTietHoaDon", "LichHen" };
            foreach (string b in bang) Fxml.TaoXML(b);
            MessageBox.Show("📂 Đã đồng bộ dữ liệu từ SQL ngược lại 12 file XML!", "Thông báo");
        }
    }
}