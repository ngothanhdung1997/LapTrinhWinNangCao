USE [QL_SHOP]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 11/26/2019 12:03:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [int] IDENTITY(1,1) NOT NULL,
	[TenCV] [nvarchar](30) NULL,
	[Hesoluong] [float] NULL,
	[Phucap] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_DDH]    Script Date: 11/26/2019 12:03:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_DDH](
	[MaDDH] [int] NOT NULL,
	[MaHang] [int] NOT NULL,
	[SLDat] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDDH] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_HD]    Script Date: 11/26/2019 12:03:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_HD](
	[MaHD] [int] NOT NULL,
	[MaHang] [int] NOT NULL,
	[SLBan] [int] NULL,
	[GiaBan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_PhieuGIao]    Script Date: 11/26/2019 12:03:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PhieuGIao](
	[MaPG] [int] NOT NULL,
	[MaHang] [int] NOT NULL,
	[SLGiao] [int] NULL,
	[DonGiaGiao] [int] NULL,
	[NgayGiao] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPG] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonDatHang]    Script Date: 11/26/2019 12:03:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonDatHang](
	[MaDDH] [int] IDENTITY(1,1) NOT NULL,
	[MaNCC] [int] NULL,
	[TongLoaiHang] [int] NULL,
	[TongSLDat] [int] NULL,
	[NgayDat] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 11/26/2019 12:03:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHang] [int] IDENTITY(1,1) NOT NULL,
	[MaThuongHieu] [int] NULL,
	[MaLoai] [int] NULL,
	[TenHang] [nvarchar](50) NULL,
	[Dongia] [int] NULL,
	[SoluongTon] [int] NULL,
	[DVT] [nvarchar](10) NULL,
	[MoTa] [nvarchar](100) NULL,
	[img] [char](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/26/2019 12:03:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NULL,
	[MaKH] [int] NULL,
	[TongTien] [int] NULL,
	[NgayLapHD] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/26/2019 12:03:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[Gioitinh] [nvarchar](5) NULL,
	[Diachi] [nvarchar](50) NULL,
	[sdt] [char](10) NULL,
	[email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCC]    Script Date: 11/26/2019 12:03:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCC](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/26/2019 12:03:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[MaCV] [int] NULL,
	[Gioitinh] [nvarchar](4) NULL,
	[Ngaysinh] [date] NULL,
	[Diachi] [nvarchar](100) NULL,
	[Sdt] [char](10) NULL,
	[Email] [char](50) NULL,
	[Ngayvaolam] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuGiao]    Script Date: 11/26/2019 12:03:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuGiao](
	[MaPG] [int] IDENTITY(1,1) NOT NULL,
	[TongLoaiHangGiao] [int] NULL,
	[TongSLGiao] [int] NULL,
	[TongGiatri] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 11/26/2019 12:03:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[Tenloai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThuongHieu]    Script Date: 11/26/2019 12:03:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuongHieu](
	[MaThuongHieu] [int] IDENTITY(1,1) NOT NULL,
	[TenTH] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThuongHieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [Hesoluong], [Phucap]) VALUES (1, N'Nhân viên', 2, 50000)
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
SET IDENTITY_INSERT [dbo].[HangHoa] ON 

INSERT [dbo].[HangHoa] ([MaHang], [MaThuongHieu], [MaLoai], [TenHang], [Dongia], [SoluongTon], [DVT], [MoTa], [img]) VALUES (1, 1, 1, N'Áo thun tay ngắn', 100000, 50, N'cái', N'Áo chất liệu co giản tốt', N'aothun1.png         ')
INSERT [dbo].[HangHoa] ([MaHang], [MaThuongHieu], [MaLoai], [TenHang], [Dongia], [SoluongTon], [DVT], [MoTa], [img]) VALUES (2, 1, 1, N'Áo thun tay ngắn', 100000, 50, N'cái', N'Áo chất liệu co giản tốt', N'aothun2.jpg         ')
INSERT [dbo].[HangHoa] ([MaHang], [MaThuongHieu], [MaLoai], [TenHang], [Dongia], [SoluongTon], [DVT], [MoTa], [img]) VALUES (3, 1, 1, N'Áo thun tay ngắn', 100000, 50, N'cái', N'Áo chất liệu co giản tốt', N'aothun3.jpg         ')
INSERT [dbo].[HangHoa] ([MaHang], [MaThuongHieu], [MaLoai], [TenHang], [Dongia], [SoluongTon], [DVT], [MoTa], [img]) VALUES (4, 1, 1, N'Áo thun tay ngắn', 100000, 50, N'cái', N'Áo chất liệu co giản tốt', N'aothun4.jpg         ')
INSERT [dbo].[HangHoa] ([MaHang], [MaThuongHieu], [MaLoai], [TenHang], [Dongia], [SoluongTon], [DVT], [MoTa], [img]) VALUES (5, 1, 1, N'Áo thun tay ngắn', 100000, 50, N'cái', N'Áo chất liệu co giản tốt', N'aothun5.jpg         ')
INSERT [dbo].[HangHoa] ([MaHang], [MaThuongHieu], [MaLoai], [TenHang], [Dongia], [SoluongTon], [DVT], [MoTa], [img]) VALUES (6, 1, 1, N'Áo thun tay ngắn', 100000, 50, N'cái', N'Áo chất liệu co giản tốt', N'aothun6.jpg         ')
SET IDENTITY_INSERT [dbo].[HangHoa] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Gioitinh], [Diachi], [sdt], [email]) VALUES (1, N'Ngô Thanh Dũng', N'Nam', N'HCM', N'0376000872', N'ntd13797@gmail.com')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Gioitinh], [Diachi], [sdt], [email]) VALUES (2, N'nnn', N'Nữ', N'HCm', N'0235987568', N'nnn@gmail.com')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Gioitinh], [Diachi], [sdt], [email]) VALUES (4, N'nnnn', N'Nữ', N'HCm', N'0235987568', N'nnn@gmail.com')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[NhaCC] ON 

INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC]) VALUES (1, N'Thanh Dũng')
INSERT [dbo].[NhaCC] ([MaNCC], [TenNCC]) VALUES (2, N'Hoài Bảo')
SET IDENTITY_INSERT [dbo].[NhaCC] OFF
SET IDENTITY_INSERT [dbo].[TheLoai] ON 

INSERT [dbo].[TheLoai] ([MaLoai], [Tenloai]) VALUES (1, N'Nam')
INSERT [dbo].[TheLoai] ([MaLoai], [Tenloai]) VALUES (2, N'Nữ')
INSERT [dbo].[TheLoai] ([MaLoai], [Tenloai]) VALUES (3, N'Hot')
SET IDENTITY_INSERT [dbo].[TheLoai] OFF
SET IDENTITY_INSERT [dbo].[ThuongHieu] ON 

INSERT [dbo].[ThuongHieu] ([MaThuongHieu], [TenTH]) VALUES (1, N'Việt Nam')
INSERT [dbo].[ThuongHieu] ([MaThuongHieu], [TenTH]) VALUES (2, N'Thái')
INSERT [dbo].[ThuongHieu] ([MaThuongHieu], [TenTH]) VALUES (3, N'Mỹ')
SET IDENTITY_INSERT [dbo].[ThuongHieu] OFF
ALTER TABLE [dbo].[CT_DDH]  WITH CHECK ADD FOREIGN KEY([MaDDH])
REFERENCES [dbo].[DonDatHang] ([MaDDH])
GO
ALTER TABLE [dbo].[CT_DDH]  WITH CHECK ADD FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangHoa] ([MaHang])
GO
ALTER TABLE [dbo].[CT_HD]  WITH CHECK ADD FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangHoa] ([MaHang])
GO
ALTER TABLE [dbo].[CT_HD]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[CT_PhieuGIao]  WITH CHECK ADD FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangHoa] ([MaHang])
GO
ALTER TABLE [dbo].[CT_PhieuGIao]  WITH CHECK ADD FOREIGN KEY([MaPG])
REFERENCES [dbo].[PhieuGiao] ([MaPG])
GO
ALTER TABLE [dbo].[DonDatHang]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCC] ([MaNCC])
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD FOREIGN KEY([MaLoai])
REFERENCES [dbo].[TheLoai] ([MaLoai])
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD FOREIGN KEY([MaThuongHieu])
REFERENCES [dbo].[ThuongHieu] ([MaThuongHieu])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
