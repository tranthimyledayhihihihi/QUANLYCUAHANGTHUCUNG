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
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,       -- Khóa chính
    [MaNhanVien] NVARCHAR(5) NOT NULL 
        REFERENCES [dbo].[NhanVien]([MaNhanVien]),
    [Ngay] INT NOT NULL,                                -- Thêm cột Ngay
    [Thang] INT NOT NULL,                               -- Thêm cột Thang
    [Nam] INT NOT NULL                                  -- Thêm cột Nam
);
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
-- XÓA BẢNG CŨ (CÓ KHÓA PHỨC HỢP)
IF OBJECT_ID('dbo.PhieuNhap', 'U') IS NOT NULL
BEGIN
    DROP TABLE dbo.PhieuNhap;
END
GO

-- TẠO LẠI BẢNG PHIEUNHAP ĐÚNG CHUẨN WINFORM
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieu] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[MaMatHang] NVARCHAR(5) NOT NULL, 
	[LoaiMatHang] NVARCHAR(10) NOT NULL, -- 'SP' hoặc 'TC'
	[MaNhanVien] NVARCHAR(5) NOT NULL REFERENCES [dbo].[NhanVien]([MaNhanVien]),
	[SoLuongNhap] INT NOT NULL,
	[NgayLapPhieu] DATE NOT NULL
);
GO
-- XÓA BẢNG CŨ (KHÓA PHỨC HỢP)
IF OBJECT_ID('dbo.ChiTietHoaDon', 'U') IS NOT NULL
BEGIN
    DROP TABLE dbo.ChiTietHoaDon;
END
GO

-- TẠO LẠI BẢNG ĐÚNG CHUẨN WINFORM
CREATE TABLE [dbo].[ChiTietHoaDon](
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[SoHoaDon] INT NOT NULL REFERENCES [dbo].[HoaDon]([SoHoaDon]),
	[MaMatHang] NVARCHAR(5) NOT NULL, 
	[LoaiMatHang] NVARCHAR(10) NOT NULL, -- 'SP', 'TC', 'DV'
	[SoLuong] INT NOT NULL,
	[DonGiaBan] INT NOT NULL
);
GO
---------------------------------------------------------
-- 1. NhaCungCap
---------------------------------------------------------
INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChi, SDT, Email, MoTa) VALUES
('NCC01', N'Công ty Thú Cưng Hòa Bình', N'Đà Nẵng', '0905123456', 'hbpet@gmail.com', N'Nguồn cung cấp thú cưng chất lượng'),
('NCC02', N'Pet Shop Việt Nhật', N'Hà Nội', '0984556677', 'vietnhatpet@gmail.com', N'Sản phẩm nhập khẩu'),
('NCC03', N'Thế giới Pet', N'Hồ Chí Minh', '0918234567', 'petworld@gmail.com', N'Thuốc và phụ kiện thú cưng');

---------------------------------------------------------
-- 2. NhanVien
---------------------------------------------------------
INSERT INTO NhanVien (MaNhanVien, TenNhanVien, NgaySinh, DiaChi, SDT, Email) VALUES
('NV001', N'Trần Mỹ', '2003-02-15', N'Đà Nẵng', '0905000111', 'my@gmail.com'),
('NV002', N'Nguyễn Quang', '2003-08-20', N'Huế', '0905222333', 'quang@gmail.com'),
('NV003', N'Lê Huyền', '2004-04-18', N'Đà Nẵng', '0906778899', 'huyen@gmail.com');

---------------------------------------------------------
-- 3. TaiKhoan
---------------------------------------------------------
INSERT INTO TaiKhoan (MaNhanVien, MatKhau, Quyen) VALUES
('NV001', '123', 1),
('NV002', '123', 0),
('NV003', '123', 0);

---------------------------------------------------------
-- 4. KhachHang
---------------------------------------------------------
INSERT INTO KhachHang (MaKhachHang, TenKhachHang, SDT, DiaChi, DiemTichLuy) VALUES
('KH001', N'Hoàng Minh', '0905667788', N'Đà Nẵng', 10),
('KH002', N'Lê Thu', '0912333444', N'Quảng Nam', 5),
('KH003', N'Nguyễn Tâm', '0933556677', N'Huế', 2);

---------------------------------------------------------
-- 5. DichVu
---------------------------------------------------------
INSERT INTO DichVu (MaDV, TenDV, GiaDV, ThoiGianThucHien) VALUES
('DV01', N'Tắm thú cưng', 80000, 30),
('DV02', N'Cắt tỉa lông', 120000, 45),
('DV03', N'Khám tổng quát', 150000, 20);

---------------------------------------------------------
-- 6. SanPham
---------------------------------------------------------
INSERT INTO SanPham (MaSP, TenSP, LoaiSP, DonViTinh, DonGiaBan, SoLuongTon, MaNCC) VALUES
('SP01', N'Thức ăn hạt Royal Canin', N'Thức ăn', N'Bịch', 350000, 15, 'NCC02'),
('SP02', N'Sữa tắm SOS', N'Vệ sinh', N'Chai', 90000, 25, 'NCC03'),
('SP03', N'Dây dắt chó', N'Phụ kiện', N'Cái', 45000, 40, 'NCC01');

---------------------------------------------------------
-- 7. ThuCung
---------------------------------------------------------
INSERT INTO ThuCung (MaThuCung, TenThuCung, LoaiThuCung, Giong, GioiTinh, NgaySinh, GiaNhap, GiaBan, MaNCC, TrangThai) VALUES
('TC01', N'Bun', N'Chó', N'Poodle', N'Đực', '2024-01-15', 3000000, 4500000, 'NCC01', N'Đang bán'),
('TC02', N'Miu', N'Mèo', N'Mèo Anh Lông Ngắn', N'Cái', '2024-03-10', 2500000, 4000000, 'NCC01', N'Đang bán'),
('TC03', N'Bông', N'Chó', N'Corgi', N'Cái', '2024-02-20', 5000000, 7000000, 'NCC02', N'Đang bán');

---------------------------------------------------------
-- 8. LichHen
---------------------------------------------------------
INSERT INTO LichHen (MaKhachHang, MaDichVu, NgayHen, GioHen, TrangThai) VALUES
('KH001', 'DV01', '2025-01-10', '09:00', N'Chờ xử lý'),
('KH002', 'DV03', '2025-01-11', '14:00', N'Hoàn thành'),
('KH003', 'DV02', '2025-01-13', '10:30', N'Đang thực hiện');


---------------------------------------------------------
-- 9. PhieuNhap
---------------------------------------------------------
INSERT INTO PhieuNhap (MaMatHang, LoaiMatHang, MaNhanVien, SoLuongNhap, NgayLapPhieu) VALUES
('SP01', 'SP', 'NV002', 10, '2025-01-01'),
('SP02', 'SP', 'NV001', 20, '2025-01-02'),
('TC01', 'TC', 'NV003', 1,  '2025-01-05');


---------------------------------------------------------
-- 10. HoaDon
---------------------------------------------------------
INSERT INTO HoaDon (MaNhanVien, MaKhachHang, NgayLap, TongTien) VALUES
('NV002', 'KH001', '2025-01-15', 4500000),
('NV001', 'KH002', '2025-01-16', 90000),
('NV003', 'KH003', '2025-01-16', 350000);


---------------------------------------------------------
-- 11. ChiTietHoaDon
---------------------------------------------------------
INSERT INTO ChiTietHoaDon (SoHoaDon, MaMatHang, LoaiMatHang, SoLuong, DonGiaBan) VALUES
(1000, 'TC01', 'TC', 1, 4500000),   -- Hóa đơn mua 1 thú cưng
(1001, 'SP02', 'SP', 1, 90000),     -- Hóa đơn mua 1 sản phẩm
(1002, 'SP01', 'SP', 1, 350000);    -- Hóa đơn mua 1 sản phẩm


---------------------------------------------------------
-- 12. ChamCong
---------------------------------------------------------
INSERT INTO ChamCong (MaNhanVien, Ngay, Thang, Nam) VALUES
('NV001', 1, 12, 2025),
('NV002', 1, 12, 2025),
('NV003', 1, 12, 2025),
('NV001', 2, 12, 2025),
('NV002', 2, 12, 2025);





