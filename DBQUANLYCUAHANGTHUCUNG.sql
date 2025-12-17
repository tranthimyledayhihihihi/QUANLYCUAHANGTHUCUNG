USE [master]
GO

-- Xóa database nếu tồn tại
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


---------------------------------------------------------
-- TẠO CÁC BẢNG CƠ BẢN (KHÔNG THAY ĐỔI)
---------------------------------------------------------

-- 1. Bảng Nhà Cung Cấp
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] NVARCHAR(5) NOT NULL PRIMARY KEY,
	[TenNCC] NVARCHAR(50) NULL,
	[DiaChi] NVARCHAR(50) NULL,
	[SDT] NVARCHAR(15) NULL,
	[Email] NVARCHAR(50) NULL,
	[MoTa] NVARCHAR(50) NULL
)
GO


-- 2. Bảng Khách Hàng
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] NVARCHAR(5) NOT NULL PRIMARY KEY,
	[TenKhachHang] NVARCHAR(50) NOT NULL,
	[SDT] NVARCHAR(15) NULL,
	[DiaChi] NVARCHAR(100) NULL,
	[DiemTichLuy] INT DEFAULT 0
)
GO

-- 3. Bảng Nhân Viên
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] NVARCHAR(5) NOT NULL PRIMARY KEY,
	[TenNhanVien] NVARCHAR(50) NULL,
	[NgaySinh] DATE NULL,
	[DiaChi] NVARCHAR(50) NULL,
	[SDT] NVARCHAR(15) NULL,
	[Email] NVARCHAR(50) NULL
)
GO


-- 4. Bảng Tài Khoản
CREATE TABLE [dbo].[TaiKhoan](
	[MaNhanVien] NVARCHAR(5) NOT NULL PRIMARY KEY,
	[MatKhau] NVARCHAR(10) NULL,
	[Quyen] INT NULL, -- 1: Quản lý, 0: Nhân viên
	CONSTRAINT FK_TaiKhoan_NhanVien
		FOREIGN KEY ([MaNhanVien]) REFERENCES [dbo].[NhanVien]([MaNhanVien])
)
GO

-- 5. Bảng Chấm Công
CREATE TABLE [dbo].[ChamCong](
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [MaNhanVien] NVARCHAR(5) NOT NULL,
    [Ngay] INT NOT NULL,
    [Thang] INT NOT NULL,
    [Nam] INT NOT NULL,
	CONSTRAINT FK_ChamCong_NhanVien
		FOREIGN KEY ([MaNhanVien]) REFERENCES [dbo].[NhanVien]([MaNhanVien])
)
GO

-- 6. Bảng Dịch Vụ
CREATE TABLE [dbo].[DichVu](
	[MaDV] NVARCHAR(5) NOT NULL PRIMARY KEY,
	[TenDV] NVARCHAR(50) NOT NULL,
	[GiaDV] INT NULL,
	[ThoiGianThucHien] INT NULL -- Thời gian tính bằng phút
)
GO


-- 7. Bảng Thú Cưng
CREATE TABLE [dbo].[ThuCung](
	[MaThuCung] NVARCHAR(5) NOT NULL PRIMARY KEY,
	[TenThuCung] NVARCHAR(50) NOT NULL,
	[LoaiThuCung] NVARCHAR(30) NULL, -- VD: Chó, Mèo
	[Giong] NVARCHAR(50) NULL,
	[GioiTinh] NVARCHAR(3) NULL,
	[NgaySinh] DATE NULL,
	[GiaNhap] INT NULL,
	[GiaBan] INT NULL,
	[MaNCC] NVARCHAR(5) NULL,
	[TrangThai] NVARCHAR(20) NULL, -- VD: Còn hàng, Đã bán
	CONSTRAINT FK_ThuCung_NhaCungCap
		FOREIGN KEY ([MaNCC]) REFERENCES [dbo].[NhaCungCap]([MaNCC])
)
GO

-- 8. Bảng Sản Phẩm
CREATE TABLE [dbo].[SanPham](
	[MaSP] NVARCHAR(5) NOT NULL PRIMARY KEY,
	[TenSP] NVARCHAR(100) NOT NULL,
	[LoaiSP] NVARCHAR(30) NULL,
	[DonViTinh] NVARCHAR(10) NULL,
	[DonGiaBan] INT NULL,
	[SoLuongTon] INT NULL,
	[MaNCC] NVARCHAR(5) NULL,
	CONSTRAINT FK_SanPham_NhaCungCap
		FOREIGN KEY ([MaNCC]) REFERENCES [dbo].[NhaCungCap]([MaNCC])
)
GO

-- 9. Bảng Phiếu Nhập
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieu] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[MaMatHang] NVARCHAR(5) NOT NULL,
	[LoaiMatHang] NVARCHAR(10) NOT NULL, -- 'SP' hoặc 'TC'
	[MaNhanVien] NVARCHAR(5) NOT NULL,
	[SoLuongNhap] INT NOT NULL,
	[NgayLapPhieu] DATE NOT NULL,
	CONSTRAINT FK_PhieuNhap_NhanVien
		FOREIGN KEY ([MaNhanVien]) REFERENCES [dbo].[NhanVien]([MaNhanVien])
)
GO

-- 10. Bảng Hóa Đơn
CREATE TABLE [dbo].[HoaDon](
	[SoHoaDon] INT IDENTITY(1000,1) NOT NULL PRIMARY KEY,
	[MaNhanVien] NVARCHAR(5) NOT NULL,
	[MaKhachHang] NVARCHAR(5) NOT NULL,
	[NgayLap] DATE NULL,
	[TongTien] INT NULL,
	CONSTRAINT FK_HoaDon_NhanVien
		FOREIGN KEY ([MaNhanVien]) REFERENCES [dbo].[NhanVien]([MaNhanVien]),
	CONSTRAINT FK_HoaDon_KhachHang
		FOREIGN KEY ([MaKhachHang]) REFERENCES [dbo].[KhachHang]([MaKhachHang])
)
GO

-- 11. Bảng Chi Tiết Hóa Đơn
CREATE TABLE [dbo].[ChiTietHoaDon](
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[SoHoaDon] INT NOT NULL,
	[MaMatHang] NVARCHAR(5) NOT NULL,
	[LoaiMatHang] NVARCHAR(10) NOT NULL, -- 'SP', 'TC', 'DV'
	[SoLuong] INT NOT NULL,
	[DonGiaBan] INT NOT NULL,
	CONSTRAINT FK_ChiTietHoaDon_HoaDon
		FOREIGN KEY ([SoHoaDon]) REFERENCES [dbo].[HoaDon]([SoHoaDon])
)
GO

-- 12. Bảng Lịch Hẹn
CREATE TABLE [dbo].[LichHen](
	[MaLichHen] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[MaKhachHang] NVARCHAR(5) NOT NULL,
	[MaDichVu] NVARCHAR(5) NOT NULL,
	[NgayHen] DATE NOT NULL,
	[GioHen] TIME NULL,
	[TrangThai] NVARCHAR(20) NULL, -- VD: Chờ xử lý, Hoàn thành, Đã hủy
	CONSTRAINT FK_LichHen_KhachHang
		FOREIGN KEY ([MaKhachHang]) REFERENCES [dbo].[KhachHang]([MaKhachHang]),
	CONSTRAINT FK_LichHen_DichVu
		FOREIGN KEY ([MaDichVu]) REFERENCES [dbo].[DichVu]([MaDV])
)
GO

---------------------------------------------------------
-- TRIGGER (KHÔNG THAY ĐỔI).
---------------------------------------------------------
-- Tự động cập nhật trạng thái thú cưng khi bán
CREATE TRIGGER trg_UpdateThuCungStatus ON ChiTietHoaDon AFTER INSERT AS
BEGIN
    UPDATE ThuCung SET TrangThai = N'Đã bán' FROM ThuCung TC INNER JOIN inserted i ON TC.MaThuCung = i.MaMatHang WHERE i.LoaiMatHang = 'TC'
END
GO

-- Tự động giảm số lượng tồn kho khi bán sản phẩm
CREATE TRIGGER trg_UpdateSanPhamStock ON ChiTietHoaDon AFTER INSERT AS
BEGIN
    UPDATE SanPham SET SoLuongTon = SoLuongTon - i.SoLuong FROM SanPham SP INNER JOIN inserted i ON SP.MaSP = i.MaMatHang WHERE i.LoaiMatHang = 'SP'
END
GO

-- Tự động cộng số lượng tồn kho khi nhập hàng
CREATE TRIGGER trg_UpdateStockOnImport ON PhieuNhap AFTER INSERT AS
BEGIN
    UPDATE SanPham SET SoLuongTon = SoLuongTon + i.SoLuongNhap FROM SanPham SP INNER JOIN inserted i ON SP.MaSP = i.MaMatHang WHERE i.LoaiMatHang = 'SP'
    UPDATE ThuCung SET TrangThai = N'Còn hàng' FROM ThuCung TC INNER JOIN inserted i ON TC.MaThuCung = i.MaMatHang WHERE i.LoaiMatHang = 'TC'
END
GO

---------------------------------------------------------
-- ⚡ CHÈN DỮ LIỆU MẪU (INSERT SAMPLE DATA) ⚡
---------------------------------------------------------
