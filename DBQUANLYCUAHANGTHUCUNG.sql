USE [master]
GO

-- 1. Sửa lỗi tạo Database: Sử dụng đường dẫn mặc định
IF DB_ID(N'QuanLyCuaHangThuCung') IS NOT NULL
BEGIN
    ALTER DATABASE [QuanLyCuaHangThuCung] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [QuanLyCuaHangThuCung];
END
GO

CREATE DATABASE [QuanLyCuaHangThuCung];
GO

USE [QuanLyCuaHangThuCung]
GO

-- 1. Bảng Khách Hàng (Mới)
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] NVARCHAR(5) NOT NULL PRIMARY KEY,
	[TenKhachHang] NVARCHAR(50) NOT NULL,
	[SDT] NVARCHAR(15) NULL, -- Dùng NVARCHAR cho SDT để tránh lỗi INT
	[DiaChi] NVARCHAR(100) NULL,
	[DiemTichLuy] INT DEFAULT 0
)
GO

-- 2. Bảng Nhà Cung Cấp (Giữ lại/Sửa)
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] NVARCHAR(5) NOT NULL PRIMARY KEY,
	[TenNCC] NVARCHAR(50) NULL,
	[DiaChi] NVARCHAR(50) NULL,
	[SDT] NVARCHAR(15) NULL,
	[Email] NVARCHAR(50) NULL,
	[MoTa] NVARCHAR(50) NULL
)
GO

-- 3. Bảng Nhân Viên (Giữ lại/Sửa)
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] NVARCHAR(5) NOT NULL PRIMARY KEY,
	[TenNhanVien] NVARCHAR(50) NULL,
	[NgaySinh] DATE NULL, -- Thay NVARCHAR(25) bằng DATE
	[DiaChi] NVARCHAR(50) NULL,
	[SDT] NVARCHAR(15) NULL,
	[Email] NVARCHAR(50) NULL
)
GO

-- 4. Bảng Tài Khoản (Giữ lại/Sửa)
CREATE TABLE [dbo].[TaiKhoan](
	[MaNhanVien] NVARCHAR(5) NOT NULL PRIMARY KEY REFERENCES [dbo].[NhanVien]([MaNhanVien]),
	[MatKhau] NVARCHAR(10) NULL,
	[Quyen] INT NULL -- 1: Quản lý, 0: Nhân viên
)
GO

-- 5. Bảng Chấm Công (Giữ lại)
CREATE TABLE [dbo].[ChamCong](
	[Id] INT IDENTITY(1,1) NOT NULL, -- Tự động tăng
	[MaNhanVien] NVARCHAR(5) NOT NULL REFERENCES [dbo].[NhanVien]([MaNhanVien]),
	[Ngay] DATE NULL, -- Dùng DATE
 CONSTRAINT [PK_ChamCong] PRIMARY KEY CLUSTERED (
	[Id] ASC, [MaNhanVien] ASC
)
)
GO

-- 6. Bảng Thú Cưng (Mới/Thay thế Hàng)
CREATE TABLE [dbo].[ThuCung](
	[MaThuCung] NVARCHAR(5) NOT NULL PRIMARY KEY,
	[TenThuCung] NVARCHAR(50) NOT NULL,
	[LoaiThuCung] NVARCHAR(30) NULL, -- VD: Chó, Mèo
	[Giong] NVARCHAR(50) NULL, -- VD: Poodle, Husky
	[GioiTinh] NVARCHAR(3) NULL, -- VD: Đực, Cái
	[NgaySinh] DATE NULL,
	[GiaNhap] INT NULL,
	[GiaBan] INT NULL,
	[MaNCC] NVARCHAR(5) REFERENCES [dbo].[NhaCungCap]([MaNCC]),
	[TrangThai] NVARCHAR(20) NULL -- VD: Còn hàng, Đã bán, Đang ốm
)
GO

-- 7. Bảng Sản Phẩm (Mới/Thay thế Hàng)
CREATE TABLE [dbo].[SanPham](
	[MaSP] NVARCHAR(5) NOT NULL PRIMARY KEY,
	[TenSP] NVARCHAR(100) NOT NULL,
	[LoaiSP] NVARCHAR(30) NULL, -- VD: Thức ăn, Đồ chơi, Thuốc
	[DonViTinh] NVARCHAR(10) NULL,
	[DonGiaBan] INT NULL,
	[SoLuongTon] INT NULL,
	[MaNCC] NVARCHAR(5) REFERENCES [dbo].[NhaCungCap]([MaNCC])
)
GO

-- 8. Bảng Dịch Vụ (Mới)
CREATE TABLE [dbo].[DichVu](
	[MaDV] NVARCHAR(5) NOT NULL PRIMARY KEY,
	[TenDV] NVARCHAR(50) NOT NULL, -- VD: Cắt tỉa, Tắm sấy, Khám sức khỏe
	[GiaDV] INT NULL,
	[ThoiGianThucHien] INT NULL -- Thời gian tính bằng phút
)
GO

-- 9. Bảng Phiếu Nhập (Giữ lại/Sửa)
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieu] INT IDENTITY(1,1) NOT NULL,
	[MaMatHang] NVARCHAR(5) NOT NULL, -- Có thể là MaSP hoặc MaThuCung
    [LoaiMatHang] NVARCHAR(10) NOT NULL, -- 'SP' hoặc 'TC'
	[MaNhanVien] NVARCHAR(5) NOT NULL REFERENCES [dbo].[NhanVien]([MaNhanVien]),
	[SoLuongNhap] INT NULL,
	[NgayLapPhieu] DATE NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC, [MaMatHang] ASC, [LoaiMatHang] ASC
)
)
GO

-- 10. Bảng Hóa Đơn (Giữ lại/Sửa)
CREATE TABLE [dbo].[HoaDon](
	[SoHoaDon] INT IDENTITY(1000,1) NOT NULL PRIMARY KEY,
	[MaNhanVien] NVARCHAR(5) NOT NULL REFERENCES [dbo].[NhanVien]([MaNhanVien]),
	[MaKhachHang] NVARCHAR(5) NOT NULL REFERENCES [dbo].[KhachHang]([MaKhachHang]),
	[NgayLap] DATE NULL,
	[TongTien] INT NULL
)
GO

-- 11. Bảng Chi Tiết Hóa Đơn (Giữ lại/Sửa)
CREATE TABLE [dbo].[ChiTietHoaDon](
	[SoHoaDon] INT NOT NULL REFERENCES [dbo].[HoaDon]([SoHoaDon]),
	[MaMatHang] NVARCHAR(5) NOT NULL, -- Mã SP, TC, hoặc DV
    [LoaiMatHang] NVARCHAR(10) NOT NULL, -- 'SP', 'TC', 'DV'
	[SoLuong] INT NULL,
	[DonGiaBan] INT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED (
	[SoHoaDon] ASC, [MaMatHang] ASC, [LoaiMatHang] ASC
)
)
GO

-- 12. Bảng Lịch Hẹn (Mới)
CREATE TABLE [dbo].[LichHen](
	[MaLichHen] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[MaKhachHang] NVARCHAR(5) NOT NULL REFERENCES [dbo].[KhachHang]([MaKhachHang]),
	[MaDichVu] NVARCHAR(5) NOT NULL REFERENCES [dbo].[DichVu]([MaDV]),
	[NgayHen] DATE NOT NULL,
	[GioHen] TIME NULL,
	[TrangThai] NVARCHAR(20) NULL -- VD: Đã xác nhận, Đã hủy, Hoàn thành
)
GO