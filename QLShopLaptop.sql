USE [QLShoplaptop]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 11/29/2023 1:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[MaKH] [nvarchar](50) NULL,
	[MaSP] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[NgayBan] [date] NULL,
	[DonGia] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 11/29/2023 1:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHOHANG]    Script Date: 11/29/2023 1:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOHANG](
	[MaKho] [nvarchar](50) NOT NULL,
	[MaSP] [nvarchar](50) NULL,
	[TenSP] [nvarchar](50) NULL,
	[SoLuongTon] [int] NULL,
	[NgayNhap] [date] NULL,
 CONSTRAINT [PK_KHOHANG] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 11/29/2023 1:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [int] NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/29/2023 1:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SDT] [int] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 11/29/2023 1:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHANQUYEN](
	[MaQuyen] [int] NOT NULL,
	[TenQuyen] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_QUYEN] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 11/29/2023 1:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSP] [nvarchar](50) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[GiaBan] [int] NULL,
	[MaNCC] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SANPHAM] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 11/29/2023 1:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MaTaiKhoan] [nvarchar](50) NOT NULL,
	[TenTaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](100) NULL,
	[MaQuyen] [int] NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaSP], [SoLuong], [NgayBan], [DonGia], [ThanhTien]) VALUES (N'HD1', N'NV1', N'KH1', N'SP1', 2, CAST(N'2023-11-07' AS Date), 15000000, 30000000)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaSP], [SoLuong], [NgayBan], [DonGia], [ThanhTien]) VALUES (N'HD2', N'NV2', N'KH2', N'SP2', 3, CAST(N'2023-11-07' AS Date), 12000000, 36000000)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaSP], [SoLuong], [NgayBan], [DonGia], [ThanhTien]) VALUES (N'HD3', N'NV3', N'KH3', N'SP3', 1, CAST(N'2023-11-07' AS Date), 13000000, 13000000)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaSP], [SoLuong], [NgayBan], [DonGia], [ThanhTien]) VALUES (N'HD4', N'NV4', N'KH4', N'SP4', 5, CAST(N'2023-11-07' AS Date), 14000000, 70000000)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [MaSP], [SoLuong], [NgayBan], [DonGia], [ThanhTien]) VALUES (N'HD5', N'NV5', N'KH5', N'SP5', 4, CAST(N'2023-11-07' AS Date), 10000000, 40000000)
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH1', N'Nguyễn Văn A', CAST(N'1990-01-15' AS Date), N'Nam', N'123 Đường ABC', 123456789)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH2', N'Trần Thị B', CAST(N'1995-05-20' AS Date), N'Nữ', N'456 Đường XYZ', 987654321)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH3', N'Hoàng Minh C', CAST(N'2000-08-10' AS Date), N'Nam', N'789 Đường KLM', 555555555)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH4', N'Lê Thị D', CAST(N'1985-03-05' AS Date), N'Nữ', N'321 Đường PQR', 111111111)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH5', N'Phạm Văn E', CAST(N'1992-12-25' AS Date), N'Nam', N'654 Đường DEF', 999999999)
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'KH6', N'Phạm Văn E', CAST(N'1992-12-25' AS Date), N'Nam', N'654 Đường DEF', 999999999)
GO
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK02', N'SP1', N'Laptop Dell XPS', 800, CAST(N'2023-03-15' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK03', N'SP2', N'Laptop HP Spectre', 900, CAST(N'2023-04-20' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK04', N'SP3', N'Laptop Asus ZenBook', 950, CAST(N'2023-05-12' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK05', N'SP4', N'Laptop Lenovo ThinkPad', 850, CAST(N'2023-06-18' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK06', N'SP5', N'Laptop Acer Swift', 750, CAST(N'2023-07-25' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK07', N'SP6', N'Laptop Acer Swift', 1200, CAST(N'2023-08-30' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK08', N'SP7', N'Laptop Huawei MateBook', 1100, CAST(N'2023-09-05' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK09', N'SP8', N'Laptop Samsung Galaxy Book', 1000, CAST(N'2023-10-10' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK10', N'SP9', N'Laptop Apple MacBook Air', 1300, CAST(N'2023-11-15' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK11', N'SP10', N'Laptop Google Pixelbook', 1250, CAST(N'2023-12-20' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK12', N'SP11', N'Laptop HP Pavilion', 1150, CAST(N'2023-09-05' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK13', N'SP12', N'Laptop Microsoft Surface', 1200, CAST(N'2023-10-10' AS Date))
INSERT [dbo].[KHOHANG] ([MaKho], [MaSP], [TenSP], [SoLuongTon], [NgayNhap]) VALUES (N'MK14', N'SP13', N'Laptop Razer Blade', 1050, CAST(N'2023-11-15' AS Date))
GO
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC1', N'Công Ty A', N'12 Đường UVW', 222222222)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC10', N'Công Ty X', N'12 Đường UVW', 673254345)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC11', N'Công Ty FF', N'56 Đường PQR', 444444444)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC12', N'Công Ty W', N'12 Đường UVW', 444444444)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC13', N'Công Ty QQ', N'56 Đường PQR', 121342552)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC14', N'Công Ty VV', N'56 Đường PQR', 134545633)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC2', N'Công Ty B', N'34 Đường XYZ', 333333333)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC3', N'Công Ty C', N'56 Đường PQR', 444444444)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC4', N'Công Ty D', N'78 Đường EFG', 555555555)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC5', N'Công Ty E', N'90 Đường HIJ', 334235554)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC6', N'Công Ty Hgg', N'34 Đường XYZ', 333333333)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC7', N'Công Ty F', N'56 Đường PQR', 242042400)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC8', N'Công Ty G', N'90 Đường HIJ', 666666666)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC9', N'Công Ty H', N'34 Đường XYZ', 333333333)
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV1', N'Nguyễn Thị F', CAST(N'1990-02-10' AS Date), N'Nữ', N'987 Đường LMN', 777777777)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV2', N'Trần Văn G', CAST(N'1987-06-15' AS Date), N'Nam', N'654 Đường XYZ', 888888888)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV3', N'Hồ Minh H', CAST(N'1992-09-20' AS Date), N'Nam', N'123 Đường ABC', 999999999)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV4', N'Lê Thị I', CAST(N'1980-11-25' AS Date), N'Nữ', N'456 Đường DEF', 111111111)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV5', N'Phạm Văn J', CAST(N'1995-12-30' AS Date), N'Nam', N'789 Đường GHI', 222222222)
GO
INSERT [dbo].[PHANQUYEN] ([MaQuyen], [TenQuyen]) VALUES (1, N'Admin')
INSERT [dbo].[PHANQUYEN] ([MaQuyen], [TenQuyen]) VALUES (2, N'User')
GO
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [MaNCC]) VALUES (N'SP1', N'Laptop Dell XPS', 10, 15000000, N'NCC1')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [MaNCC]) VALUES (N'SP10', N'Laptop Google Pixelbook', 22, 12800000, N'NCC9')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [MaNCC]) VALUES (N'SP11', N'Laptop HP Pavilion', 14, 11500000, N'NCC10')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [MaNCC]) VALUES (N'SP12', N'Laptop Microsoft Surface', 20, 12500000, N'NCC11')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [MaNCC]) VALUES (N'SP13', N'Laptop Razer Blade', 10, 15500000, N'NCC12')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [MaNCC]) VALUES (N'SP14', N'Laptop Gigabyte Aero', 18, 14500000, N'NCC13')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [MaNCC]) VALUES (N'SP2', N'Laptop HP Spectre', 8, 12000000, N'NCC2')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [MaNCC]) VALUES (N'SP3', N'Laptop Asus ZenBook', 12, 13000000, N'NCC3')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [MaNCC]) VALUES (N'SP4', N'Laptop Lenovo ThinkPad', 15, 14000000, N'NCC4')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [MaNCC]) VALUES (N'SP5', N'Laptop Acer Swift', 20, 10000000, N'NCC5')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [MaNCC]) VALUES (N'SP6', N'Laptop Acer Swift', 20, 10000000, N'NCC6')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [MaNCC]) VALUES (N'SP7', N'Laptop Huawei MateBook', 18, 11000000, N'NCC14')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [MaNCC]) VALUES (N'SP8', N'Laptop Samsung Galaxy Book', 25, 10500000, N'NCC7')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [SoLuong], [GiaBan], [MaNCC]) VALUES (N'SP9', N'Laptop Apple MacBook Air', 30, 13500000, N'NCC8')
GO
INSERT [dbo].[TAIKHOAN] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau], [MaQuyen]) VALUES (N'1', N'admin', N'123', 1)
INSERT [dbo].[TAIKHOAN] ([MaTaiKhoan], [TenTaiKhoan], [MatKhau], [MaQuyen]) VALUES (N'2', N'user', N'111', 2)
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[KHOHANG]  WITH CHECK ADD  CONSTRAINT [FK_KHOHANG_SANPHAM] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[KHOHANG] CHECK CONSTRAINT [FK_KHOHANG_SANPHAM]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[PHANQUYEN] ([MaQuyen])
GO
/****** Object:  StoredProcedure [dbo].[proc_DoiMatKhau]    Script Date: 11/29/2023 1:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DoiMatKhau]
    @tenTaiKhoan NVARCHAR(50),
    @matKhauMoi NVARCHAR(50)
AS
BEGIN
    UPDATE TaiKhoan
    SET MatKhau = @matKhauMoi
    WHERE TenTaiKhoan = @tenTaiKhoan
END
GO
/****** Object:  StoredProcedure [dbo].[proc_login]    Script Date: 11/29/2023 1:38:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_login]
@user nvarchar(50),
@pass nvarchar(50)
as
BEGIN
	SELECT * FROM TAIKHOAN WHERE TenTaiKhoan = @user AND MatKhau = @pass
END

GO
