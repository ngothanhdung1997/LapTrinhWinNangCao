USE [Fashion]
GO
/****** Object:  Table [dbo].[QL_ManHinh]    Script Date: 11/26/2019 12:02:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_ManHinh](
	[MaManHinh] [nchar](10) NULL,
	[TenManHinh] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QL_NguoiDung]    Script Date: 11/26/2019 12:02:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_NguoiDung](
	[TenDangNhap] [nchar](10) NOT NULL,
	[MatKhau] [nchar](10) NULL,
	[TinhTrang] [int] NULL,
 CONSTRAINT [PK_QL_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QL_NguoiDungNhomNguoiDung]    Script Date: 11/26/2019 12:02:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_NguoiDungNhomNguoiDung](
	[TenDangNhap] [nchar](10) NULL,
	[MaNhom] [nchar](10) NULL,
	[GhiChu] [nvarchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QL_NhomNguoiDung]    Script Date: 11/26/2019 12:02:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_NhomNguoiDung](
	[MaNhom] [nchar](10) NOT NULL,
	[TenNhom] [nvarchar](10) NULL,
	[GhiChu] [nvarchar](10) NULL,
 CONSTRAINT [PK_QL_NhomNguoiDung] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QL_PhanQuyen]    Script Date: 11/26/2019 12:02:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_PhanQuyen](
	[MaNhom] [nchar](10) NULL,
	[MaManHinh] [nchar](10) NULL,
	[CoQuyen] [int] NULL
) ON [PRIMARY]

GO
INSERT [dbo].[QL_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'KH        ', N'Quản lý khách hàng')
INSERT [dbo].[QL_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'NH        ', N'Quản lý nhập hàng')
INSERT [dbo].[QL_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'Admin     ', N'admin')
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [TinhTrang]) VALUES (N'hhb       ', N'123       ', 1)
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [TinhTrang]) VALUES (N'nnn       ', N'123       ', 0)
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [TinhTrang]) VALUES (N'ntd       ', N'123       ', 1)
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhom], [GhiChu]) VALUES (N'ntd       ', N'Nhom01    ', NULL)
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhom], [GhiChu]) VALUES (N'hhb       ', N'Nhom02    ', NULL)
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'Nhom01    ', N'Quản lý', NULL)
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'Nhom02    ', N'Nhân viên', NULL)
INSERT [dbo].[QL_PhanQuyen] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'Nhom01    ', N'Admin     ', NULL)
INSERT [dbo].[QL_PhanQuyen] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'Nhom01    ', N'KH        ', NULL)
INSERT [dbo].[QL_PhanQuyen] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'Nhom01    ', N'NH        ', NULL)
INSERT [dbo].[QL_PhanQuyen] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'Nhom02    ', N'KH        ', NULL)
