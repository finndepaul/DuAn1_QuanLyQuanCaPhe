CREATE DATABASE DA1_Coffee
GO
USE DA1_Coffee
GO
CREATE TABLE [dbo].[KhachHang](
	[IDKhachHang] VARCHAR(20) NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	[SDT] VARCHAR(10) NULL,
	[Email] nvarchar(50) NULL,
	[DiaChi] nvarchar(50) NULL,
	[Point] [int] NULL,
    [IDRank] VARCHAR(20) NULL,
)
GO
CREATE TABLE [dbo].[DichVuPhatSinh](
	[IDDichVuPhatSinh] VARCHAR(20) NOT NULL PRIMARY KEY,
	[ChiTiet] nvarchar(50) NULL,
	[SoTien] [FLOAT] NULL,
	[IDHoaDon] VARCHAR(20) NOT NULL,
)
GO
CREATE TABLE [dbo].[HoaDonChiTiet](
	[IDHoaDonChiTiet] VARCHAR(20) NOT NULL PRIMARY KEY,
	[SoLuong] [int] NULL,
	[GiaBan] FLOAT NULL,
	GhiChu NVARCHAR(255) NULL,
	[IDSanPham] VARCHAR(20) NOT NULL,
	[IDHoaDon] VARCHAR(20) NOT NULL,
)
GO
CREATE TABLE [dbo].[HoaDon](
	[IDHoaDon] VARCHAR(20) NOT NULL PRIMARY KEY,
	TongTien Float null,
	[NgayXuatDon] DATE NOT NULL,
	[TrangThai] [int] NOT NULL,
	[IDNhanVien] VARCHAR(20) NOT NULL,
	[IDKhachHang] VARCHAR(20) NULL,
	[IDVoucher] VARCHAR(20) NULL,
)
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[IDLoaiSanPham] VARCHAR(20) NOT NULL PRIMARY KEY,
	[TenLoaiSanPham] nvarchar(50) NOT NULL,
	TrangThai INT NULL,
	[IDNhanVien] VARCHAR(20) NOT NULL,
)
GO
CREATE TABLE [dbo].[MemberShipRank](
	[IDRank] VARCHAR(20) NOT NULL PRIMARY KEY,
	[PointsNeed] [int] NULL,
	[Discount] FLOAT NULL,
	[RankName] NVARCHAR(50) NULL,
)
GO
CREATE TABLE [dbo].[NguyenLieu](
	[IDNguyenLieu] VARCHAR(20) NOT NULL PRIMARY KEY,
	[TenNguyenLieu] NVARCHAR(50) NOT NULL,
	[Gia] FLOAT NULL,
	[SoLuong] [int] NULL,
)
GO
CREATE TABLE [dbo].[NhanVien](
	[IDNhanVien] VARCHAR(20) PRIMARY KEY NOT NULL,
	[LoginName] VARCHAR(20) NOT NULL,
	[Password] VARCHAR(20) NOT NULL,
	[Role] BIT NOT NULL,
	[Active] BIT NULL,
)
GO
CREATE TABLE [dbo].[PhaChe](
	[IDPhaChe] VARCHAR(20) NOT NULL PRIMARY KEY,
	[IDSanPham] VARCHAR(20)NOT NULL,
	[IDNguyenLieu] VARCHAR(20) NOT NULL,
)
GO
CREATE TABLE [dbo].[GiamGia](
	[IDGiamGia] VARCHAR(20) NOT NULL PRIMARY KEY,
	TenChuongTrinh nvarchar(50) null,
	[PhanTram] [FLOAT] NULL,
	[NgayBatDau] DATE NULL,
	[NgayKetThuc] DATE NULL,
	TrangThai int Null,
)
CREATE TABLE [dbo].[GiamGiaChiTiet](
	[IDGiamGiaChiTiet] VARCHAR(20) NOT NULL PRIMARY KEY,
	[IDSanPham] VARCHAR(20) NOT NULL,
	[IDGiamGia] VARCHAR(20) NOT NULL,
)
GO
CREATE TABLE [dbo].[SanPham](
	[IDSanPham] VARCHAR(20) NOT NULL PRIMARY KEY,
	[TenSanPham] nvarchar(50) NOT NULL,
	[Gia] [FLOAT] NULL,
	[GiaSale] [FLOAT] NULL,
	[TrangThai] [int] NULL,
	[Thue] [FLOAT] NULL,
	HinhAnh nvarchar(100) NULL,
	[IDLoaiSanPham] VARCHAR(20) NOT NULL,
	[IDNhanVien] VARCHAR(20) NOT NULL
)
GO
CREATE TABLE [dbo].[Voucher](
	[IDVoucher] VARCHAR(20) NOT NULL PRIMARY KEY ,
	[GiamTien] [FLOAT] NULL,
	[DateStart] DATE NULL,
	[DateEnd] DATE NULL,
	[SoLuong] [int] NULL,
	[Code] VARCHAR(20) NULL,
	[DieuKienApDung] NVARCHAR(50) NULL,
	TrangThai int,
)
GO


ALTER TABLE SanPham
	ADD CONSTRAINT fk_LSP_SP FOREIGN KEY(IDLoaiSanPham) REFERENCES LoaiSanPham(IDLoaiSanPham)
ALTER TABLE SanPham
	ADD CONSTRAINT fk_NV_SP FOREIGN KEY(IDNhanVien) REFERENCES NhanVien(IDNhanVien)

ALTER TABLE LoaiSanPham
	ADD CONSTRAINT fk_NV_LSP FOREIGN KEY(IDNhanVien) REFERENCES NhanVien(IDNhanVien)

ALTER TABLE HoaDonChiTiet
	ADD CONSTRAINT fk_HD_HDCT FOREIGN KEY(IDHoaDon) REFERENCES HoaDon(IDHoaDon)
ALTER TABLE HoaDonChiTiet
	ADD CONSTRAINT fk_SP_HDCT FOREIGN KEY(IDSanPham) REFERENCES SanPham(IDSanPham)

ALTER TABLE PhaChe
	ADD CONSTRAINT fk_SP_PC FOREIGN KEY(IDSanPham) REFERENCES SanPham(IDSanPham)
ALTER TABLE PhaChe
	ADD CONSTRAINT fk_NL_PC FOREIGN KEY(IDNguyenLieu) REFERENCES NguyenLieu(IDNguyenLieu)

ALTER TABLE HoaDon
	ADD CONSTRAINT fk_KH_HD FOREIGN KEY(IDKhachHang) REFERENCES KhachHang(IDKhachHang)
ALTER TABLE HoaDon
	ADD CONSTRAINT fk_V_HD FOREIGN KEY(IDVoucher) REFERENCES Voucher(IDVoucher)
ALTER TABLE HoaDon
	ADD CONSTRAINT fk_NV_HD FOREIGN KEY(IDNhanVien) REFERENCES NhanVien(IDNhanVien)

ALTER TABLE DichVuPhatSinh
	ADD CONSTRAINT fk_HD_DVPS FOREIGN KEY(IDHoaDon) REFERENCES HoaDon(IDHoaDon)

ALTER TABLE KhachHang
	ADD CONSTRAINT fk_MR_KH FOREIGN KEY(IDRank) REFERENCES MemberShipRank(IDRank)

ALTER TABLE GiamGiaChiTiet
	ADD CONSTRAINT fk_SP_GGCT FOREIGN KEY(IDSanPham) REFERENCES SanPham(IDSanPham)
ALTER TABLE GiamGiaChiTiet
	ADD CONSTRAINT fk_GG_GGCT FOREIGN KEY(IDGiamGia) REFERENCES GiamGia(IDGiamGia)


INSERT INTO NhanVien 
VALUES
('NV001','admin1','123',1,1),
('NV002','nhanvien1','abc',0,1)
GO

INSERT INTO LoaiSanPham
VALUES
('KP001',N'Cà Phê',1,'NV001'),
('KP002',N'Nước Ép',1,'NV001'),
('KP003',N'Sữa Chua',1,'NV001'),
('KP004',N'Sinh Tố',1,'NV001')
GO

INSERT INTO SanPham
VALUES
('SP001', N'Cà Phê Sữa', 30000, 0, 1, 0, N'F:\FPT Polytechnic\Du an 1 (UDPM-.NET)\QuanLyQuanCaPhe\PRL\Resources\ImageProduct\SP001.jpg', 'KP001','NV001'),
('SP002', N'Nước Ép Cam', 20000, 0, 1, 0, N'F:\FPT Polytechnic\Du an 1 (UDPM-.NET)\QuanLyQuanCaPhe\PRL\Resources\ImageProduct\SP002.jpg', 'KP002','NV001'),
('SP003', N'Nước Ép Dâu ', 20000, 0, 1, 0, N'F:\FPT Polytechnic\Du an 1 (UDPM-.NET)\QuanLyQuanCaPhe\PRL\Resources\ImageProduct\SP003.jpg','KP002','NV001'),
('SP004', N'Sữa Chua Mít', 25000, 0, 1, 0, N'F:\FPT Polytechnic\Du an 1 (UDPM-.NET)\QuanLyQuanCaPhe\PRL\Resources\ImageProduct\SP004.jpg', 'KP003','NV001'),
('SP005', N'Sinh tố Bơ', 25000, 0, 1, 0, N'F:\FPT Polytechnic\Du an 1 (UDPM-.NET)\QuanLyQuanCaPhe\PRL\Resources\ImageProduct\SP005.jpg', 'KP004','NV001'),
('SP006', N'Cà Phê Trứng', 50000, 0, 0, 0, N'F:\FPT Polytechnic\Du an 1 (UDPM-.NET)\QuanLyQuanCaPhe\PRL\Resources\ImageProduct\SP006.jpg', 'KP001','NV001')
GO

INSERT INTO GiamGia
VALUES
('SA001', N'Ngày Nhà Giáo', 30, CONVERT(datetime, '22-02-2023', 103), CONVERT(datetime, '22-02-2023', 103), 0),
('SA002', N'Ngày Phụ Nữ', 29, CONVERT(datetime, '22-03-2023', 103), CONVERT(datetime, '22-03-2023', 103), 1),
('SA003', N'Quốc tế Lao Động', 30, CONVERT(datetime, '01-05-2023', 103), CONVERT(datetime, '03-05-2023', 103), 2),
('SA004', N'Quốc tế thiếu nhi', 30, CONVERT(datetime, '01-06-2023', 103), CONVERT(datetime, '04-06-2023', 103), 0)
GO

INSERT INTO GiamGiaChiTiet
VALUES
('GGCT001', 'SP001', 'SA001'),
('GGCT002', 'SP002', 'SA001'),
('GGCT003', 'SP005', 'SA004')









