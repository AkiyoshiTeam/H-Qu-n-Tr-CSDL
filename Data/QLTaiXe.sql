/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
CREATE DATABASE [QLTaiXe]
GO
USE [QLTaiXe]
GO
/****** Object:  Table [dbo].[ChuyenXe]    Script Date: 01/09/2017 11:15:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuyenXe](
	[MaChuyen] [varchar](10) NOT NULL,
	[HangXe] [nvarchar](50) NULL,
	[GiaVe] [bigint] NULL,
	[MaTuyen] [varchar](10) NULL,
 CONSTRAINT [PK_ChuyenXe] PRIMARY KEY CLUSTERED 
(
	[MaChuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichTrinh]    Script Date: 01/09/2017 11:15:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichTrinh](
	[MaLich] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [varchar](10) NULL,
	[Thang] [int] NULL,
	[GioDi] [datetime] NULL,
	[GioDen] [datetime] NULL,
	[NoiDi] [nvarchar](100) NULL,
	[NoiDen] [nvarchar](100) NULL,
	[MaChuyen] [varchar](10) NULL,
	[SoLuongVeBanDuoc] [int] NULL,
 CONSTRAINT [PK_LichTrinh] PRIMARY KEY CLUSTERED 
(
	[MaLich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 01/09/2017 11:15:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[CMND] [varchar](12) NULL,
	[DienThoai] [varchar](11) NULL,
	[KhaNangLai] [int] NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [varchar](20) NULL,
	[MaPQ] [int] NULL,
	[MaTo] [int] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhom]    Script Date: 01/09/2017 11:15:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhom](
	[MaTo] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [date] NULL,
	[ToTruong] [varchar](10) NULL,
 CONSTRAINT [PK_To] PRIMARY KEY CLUSTERED 
(
	[MaTo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 01/09/2017 11:15:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaPQ] [int] IDENTITY(1,1) NOT NULL,
	[TenPQ] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaPQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinhTrang]    Script Date: 01/09/2017 11:15:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhTrang](
	[MaTinhTrang] [bit] NOT NULL,
	[TenTinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_TinhTrang] PRIMARY KEY CLUSTERED 
(
	[MaTinhTrang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TuyenDuong]    Script Date: 01/09/2017 11:15:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuyenDuong](
	[MaTuyen] [varchar](10) NOT NULL,
	[TenTuyen] [nvarchar](50) NULL,
	[KhoangCach] [bigint] NULL,
 CONSTRAINT [PK_TuyenDuong] PRIMARY KEY CLUSTERED 
(
	[MaTuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000001', N'Hoàng Long', 620000, N'TD00001')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000002', N'Mai Linh', 715000, N'TD00001')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000003', N'Phượng Hoàng', 890000, N'TD00001')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000004', N'Minh Trí Limousine', 150000, N'TD00002')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000005', N'Thanh Bình Xanh', 150000, N'TD00002')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000006', N'Thuận Hưng', 250000, N'TD00002')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000007', N'Liên Hưng', 185000, N'TD00003')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000008', N'Quang Hạnh', 185000, N'TD00003')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000009', N'Hà Linh', 170000, N'TD00003')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000010', N'Hoàng Long', 370000, N'TD00004')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000011', N'Phúc Thuận Thảo', 360000, N'TD00004')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000012', N'Xuân Tùng', 300000, N'TD00004')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000013', N'Danh Danh', 200000, N'TD00005')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000014', N'Mekong Express', 322000, N'TD00005')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000015', N'Phương Heng', 200000, N'TD00005')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000016', N'Việt Nhật', 120000, N'TD00006')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000017', N'The Sinh Tourist', 119000, N'TD00006')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000018', N'Hạnh Cafe', 110000, N'TD00006')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000019', N'Thiên Phú', 90000, N'TD00007')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000020', N'Minh Dũng', 150000, N'TD00007')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000021', N'HTX vận tải Bà Rịa', 80000, N'TD00007')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000022', N'Liên Hưng', 185000, N'TD00008')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000023', N'Hà Linh', 220000, N'TD00008')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000024', N'Quang Hạnh', 205000, N'TD00008')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000025', N'Thảo Lan', 140000, N'TD00009')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000026', N'Tiến Oanh', 200000, N'TD00009')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000027', N'Đức Minh', 200000, N'TD00009')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000028', N'Tuyết Hon', 135000, N'TD00010')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000029', N'Việt Đức', 160000, N'TD00010')
INSERT [dbo].[ChuyenXe] ([MaChuyen], [HangXe], [GiaVe], [MaTuyen]) VALUES (N'C000030', N'Ba Dũng', 120000, N'TD00010')
SET IDENTITY_INSERT [dbo].[LichTrinh] ON 

INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (1, N'NV00007', 7, CAST(N'2017-07-09T07:00:00.000' AS DateTime), CAST(N'2017-07-10T17:00:00.000' AS DateTime), N'Hồ Chí Minh', N'Hà Nội', N'C000001', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (2, N'NV00018', 7, CAST(N'2017-07-16T09:00:00.000' AS DateTime), CAST(N'2017-07-18T05:50:00.000' AS DateTime), N'Bến xe Miền Đông', N'Bến xe Nước Ngầm', N'C000002', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (3, N'NV00028', 7, CAST(N'2017-07-11T08:00:00.000' AS DateTime), CAST(N'2017-07-12T14:00:00.000' AS DateTime), N'Bến xe Miền Đông', N'Bến xe Nước Ngầm', N'C000003', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (4, N'NV00007', 7, CAST(N'2017-07-24T21:00:00.000' AS DateTime), CAST(N'2017-08-26T10:28:00.000' AS DateTime), N'VP.Hồ Chí Minh', N'Bến xe Nước Ngầm', N'C000001', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (5, N'NV00011', 7, CAST(N'2017-07-22T12:00:00.000' AS DateTime), CAST(N'2017-07-22T18:30:00.000' AS DateTime), N'VP.Sài Gòn', N'VP.Đà Lạt', N'C000004', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (6, N'NV00006', 7, CAST(N'2017-07-26T20:40:00.000' AS DateTime), CAST(N'2017-07-27T03:35:00.000' AS DateTime), N'VP.Sài Gòn', N'Bến xe liên tỉnh Đà Lạt', N'C000005', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (7, N'NV00016', 7, CAST(N'2017-07-20T19:00:00.000' AS DateTime), CAST(N'2017-07-21T03:20:00.000' AS DateTime), N'TP.Hồ Chí Minh', N'PV.Đà Lạt', N'C000006', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (8, N'NV00005', 7, CAST(N'2017-07-01T07:15:00.000' AS DateTime), CAST(N'2017-07-01T16:00:00.000' AS DateTime), N'Bến xe Miền Đông', N'VP.Nha Trang', N'C000007', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (9, N'NV00008', 7, CAST(N'2017-07-14T09:30:00.000' AS DateTime), CAST(N'2017-07-14T18:15:00.000' AS DateTime), N'Bến xe Miền Đông', N'VP.Nha Trang', N'C000007', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (10, N'NV00029', 7, CAST(N'2017-07-25T20:00:00.000' AS DateTime), CAST(N'2017-07-26T05:00:00.000' AS DateTime), N'Bến xe Miền Đông', N'Siêu thị Metro Nha Trang', N'C000008', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (11, N'NV00012', 7, CAST(N'2017-07-27T21:30:00.000' AS DateTime), CAST(N'2017-07-28T06:30:00.000' AS DateTime), N'Bến xe Miền Đông', N'Siêu thị Metro Nha Trang', N'C000008', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (12, N'NV00020', 7, CAST(N'2017-07-25T17:00:00.000' AS DateTime), CAST(N'2017-07-26T02:00:00.000' AS DateTime), N'Bến xe Miền Đông', N'Nha Trang', N'C000009', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (13, N'NV00019', 7, CAST(N'2017-07-13T07:00:00.000' AS DateTime), CAST(N'2017-07-14T03:18:00.000' AS DateTime), N'Hồ Chí Minh', N'Đà Nẵng', N'C000010', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (14, N'NV00018', 7, CAST(N'2017-07-19T11:00:00.000' AS DateTime), CAST(N'2017-07-20T07:18:00.000' AS DateTime), N'Hồ Chí Minh ', N'Đà Nẵng', N'C000010', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (15, N'NV00028', 7, CAST(N'2017-07-28T11:00:00.000' AS DateTime), CAST(N'2017-07-29T06:50:00.000' AS DateTime), N'Sài Gòn ', N'Đà Nẵng', N'C000011', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (16, N'NV00007', 7, CAST(N'2017-07-31T16:00:00.000' AS DateTime), CAST(N'2017-08-01T11:50:00.000' AS DateTime), N'Sài Gòn ', N'Đà Nẵng', N'C000011', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (17, N'NV00019', 7, CAST(N'2017-07-24T12:00:00.000' AS DateTime), CAST(N'2017-07-25T08:00:00.000' AS DateTime), N'VP.Tân Bình', N'VP.Đà Nẵng', N'C000012', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (18, N'NV00016', 7, CAST(N'2017-07-28T10:30:00.000' AS DateTime), CAST(N'2017-07-28T16:30:00.000' AS DateTime), N'VP.Hồ Chí Minh', N'VP.Phnôm Pênh', N'C000013', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (19, N'NV00013', 7, CAST(N'2017-07-19T13:00:00.000' AS DateTime), CAST(N'2017-07-19T18:00:00.000' AS DateTime), N'VP.Hồ Chí Minh', N'VP.Phnôm Pênh', N'C000014', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (20, N'NV00008', 7, CAST(N'2017-07-16T13:00:00.000' AS DateTime), CAST(N'2017-07-16T19:30:00.000' AS DateTime), N'VP.Sài Gòn', N'VP.Phnôm Pênh', N'C000015', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (21, N'NV00030', 7, CAST(N'2017-07-13T16:30:00.000' AS DateTime), CAST(N'2017-07-13T23:00:00.000' AS DateTime), N'VP.Sài Gòn', N'VP.Phnôm Pênh', N'C000015', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (22, N'NV00009', 7, CAST(N'2017-07-11T20:00:00.000' AS DateTime), CAST(N'2017-07-12T01:00:00.000' AS DateTime), N'VP.Phạm Ngũ Lão', N'VP.Mũi Né', N'C000016', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (23, N'NV00004', 7, CAST(N'2017-07-17T07:00:00.000' AS DateTime), CAST(N'2017-07-17T11:30:00.000' AS DateTime), N'VP.Đề Thám', N'Mũi Né', N'C000017', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (24, N'NV00031', 7, CAST(N'2017-07-20T14:00:00.000' AS DateTime), CAST(N'2017-07-20T18:30:00.000' AS DateTime), N'VP.Đề Thám', N'Mũi Né', N'C000017', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (25, N'NV00032', 7, CAST(N'2017-07-26T07:00:00.000' AS DateTime), CAST(N'2017-07-26T11:30:00.000' AS DateTime), N'VP.Phạm Ngũ Lão', N'VP.Mũi Né', N'C000018', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (26, N'NV00027', 7, CAST(N'2017-07-24T13:30:00.000' AS DateTime), CAST(N'2017-07-24T18:30:00.000' AS DateTime), N'VP.Phạm Ngũ Lão', N'VP.Mũi Né', N'C000018', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (27, N'NV00003', 7, CAST(N'2017-07-31T10:30:00.000' AS DateTime), CAST(N'2017-07-31T13:15:00.000' AS DateTime), N'Bến xe Miền Đông', N'Bến xe Vũng Tàu', N'C000019', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (28, N'NV00010', 7, CAST(N'2017-07-13T07:00:00.000' AS DateTime), CAST(N'2017-07-13T08:40:00.000' AS DateTime), N'VP.Hồ Chí Minh', N'TP.Vũng Tàu', N'C000020', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (29, N'NV00014', 7, CAST(N'2017-07-17T05:00:00.000' AS DateTime), CAST(N'2017-07-17T07:00:00.000' AS DateTime), N'Bến xe Miền Đông', N'Bến xe Vũng Tàu', N'C000021', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (30, N'NV00025', 7, CAST(N'2017-07-14T12:30:00.000' AS DateTime), CAST(N'2017-07-14T14:10:00.000' AS DateTime), N'VP.Hồ Chí Minh', N'TP.Vũng Tàu', N'C000020', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (31, N'NV00024', 7, CAST(N'2017-07-28T06:30:00.000' AS DateTime), CAST(N'2017-07-28T08:25:00.000' AS DateTime), N'Bến xe Miền Đông', N'Bến xe Vũng Tàu', N'C000019', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (32, N'NV00003', 7, CAST(N'2017-07-16T15:00:00.000' AS DateTime), CAST(N'2017-07-16T17:45:00.000' AS DateTime), N'Bến xe Miền Đông', N'Bến xe Vũng Tàu', N'C000019', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (33, N'NV00003', 7, CAST(N'2017-07-24T09:45:00.000' AS DateTime), CAST(N'2017-07-24T11:25:00.000' AS DateTime), N'VP.Hồ Chí Minh', N'TP.Vũng Tàu', N'C000020', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (34, N'NV00004', 7, CAST(N'2017-07-28T05:00:00.000' AS DateTime), CAST(N'2017-07-28T07:00:00.000' AS DateTime), N'Bến xe Miền Đông', N'Bến xe Vũng Tàu', N'C000021', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (35, N'NV00004', 7, CAST(N'2017-07-21T05:00:00.000' AS DateTime), CAST(N'2017-07-21T07:00:00.000' AS DateTime), N'Bến xe Miền Đông', N'Bến xe Vũng Tàu', N'C000021', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (36, N'NV00005', 7, CAST(N'2017-07-13T07:15:00.000' AS DateTime), CAST(N'2017-07-13T16:00:00.000' AS DateTime), N'Bến xe Miền Đông', N'VP.Nha Trang', N'C000022', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (37, N'NV00005', 7, CAST(N'2017-07-17T08:15:00.000' AS DateTime), CAST(N'2017-07-17T17:00:00.000' AS DateTime), N'Bến xe Miền Đông', N'VP.Nha Trang', N'C000022', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (38, N'NV00029', 7, CAST(N'2017-07-16T19:00:00.000' AS DateTime), CAST(N'2017-07-17T04:20:00.000' AS DateTime), N'Bến xe Miền Đông', N'Đầm Môn', N'C000023', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (39, N'NV00029', 7, CAST(N'2017-07-30T20:00:00.000' AS DateTime), CAST(N'2017-07-31T06:45:00.000' AS DateTime), N'Bến xe Miền Đông', N'Đầm Môn', N'C000023', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (40, N'NV00009', 7, CAST(N'2017-07-01T18:00:00.000' AS DateTime), CAST(N'2017-07-02T04:45:00.000' AS DateTime), N'Bến xe Miền Đông', N'Bến xe Vạn Giã', N'C000024', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (41, N'NV00012', 7, CAST(N'2017-07-20T19:00:00.000' AS DateTime), CAST(N'2017-07-21T04:30:00.000' AS DateTime), N'Bến xe Miền Đông', N'VP.Đại Lãnh', N'C000024', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (42, N'NV00009', 7, CAST(N'2017-07-22T18:00:00.000' AS DateTime), CAST(N'2017-07-23T02:30:00.000' AS DateTime), N'VP.Sài Gòn', N'VP.Buôn Hồ', N'C000025', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (43, N'NV00012', 7, CAST(N'2017-07-16T18:05:00.000' AS DateTime), CAST(N'2017-07-17T02:35:00.000' AS DateTime), N'VP.Sài Gòn', N'Buôn Ma Thuột', N'C000025', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (44, N'NV00026', 7, CAST(N'2017-07-23T18:15:00.000' AS DateTime), CAST(N'2017-07-24T05:45:00.000' AS DateTime), N'TP.Hồ Chí Minh', N'Cư Kuin', N'C000026', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (45, N'NV00031', 7, CAST(N'2017-07-24T19:00:00.000' AS DateTime), CAST(N'2017-07-25T03:30:00.000' AS DateTime), N'Bến xe An Sương', N'VP.Việt Đức', N'C000027', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (46, N'NV00032', 7, CAST(N'2017-07-04T19:00:00.000' AS DateTime), CAST(N'2017-07-05T03:00:00.000' AS DateTime), N'Bến xe An Sương', N'Bến xe Phía nam Buôn Ma Thuột', N'C000027', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (47, N'NV00021', 7, CAST(N'2017-07-06T07:30:00.000' AS DateTime), CAST(N'2017-07-06T14:00:00.000' AS DateTime), N'Bến xe Miền Tây', N'VP.Rạch Sỏi', N'C000028', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (48, N'NV00021', 7, CAST(N'2017-07-18T07:39:00.000' AS DateTime), CAST(N'2017-07-18T13:30:00.000' AS DateTime), N'VP.Sài Gòn', N'VP.Kiên Giang', N'C000028', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (49, N'NV00027', 7, CAST(N'2017-07-20T09:00:00.000' AS DateTime), CAST(N'2017-07-20T14:00:00.000' AS DateTime), N'TP.Hồ Chí Minh', N'D10, Nguyễn Tri Phương', N'C000029', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (50, N'NV00023', 7, CAST(N'2017-07-10T09:00:00.000' AS DateTime), CAST(N'2017-07-10T14:00:00.000' AS DateTime), N'TP.Hồ Chí Minh', N'D10, Nguyễn Tri Phương', N'C000029', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (51, N'NV00023', 7, CAST(N'2017-07-04T15:00:00.000' AS DateTime), CAST(N'2017-07-04T20:40:00.000' AS DateTime), N'Bến xe Miền Tây', N'Bến xe Rạch Giá', N'C000030', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (52, N'NV00016', 7, CAST(N'2017-07-13T15:00:00.000' AS DateTime), CAST(N'2017-07-13T20:40:00.000' AS DateTime), N'Bến xe Miền Tây', N'Bến xe Rạch Giá', N'C000030', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (53, N'NV00017', 7, CAST(N'2017-07-14T15:00:00.000' AS DateTime), CAST(N'2017-07-14T20:40:00.000' AS DateTime), N'Bến xe Miền Tây', N'Bến xe Rạch Giá', N'C000030', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (54, N'NV00013', 7, CAST(N'2017-07-25T21:00:00.000' AS DateTime), CAST(N'2017-07-26T02:00:00.000' AS DateTime), N'TP.Hồ Chí Minh', N'D10, Nguyễn Tri Phương', N'C000029', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (55, N'NV00007', 7, CAST(N'2017-07-01T07:00:13.000' AS DateTime), CAST(N'2017-07-02T17:00:13.000' AS DateTime), N'VP.Hồ Chí Minh', N'Bến xe Hà Nội', N'C000003', 10)
INSERT [dbo].[LichTrinh] ([MaLich], [MaNV], [Thang], [GioDi], [GioDen], [NoiDi], [NoiDen], [MaChuyen], [SoLuongVeBanDuoc]) VALUES (56, N'NV00021', 7, CAST(N'2017-07-22T07:30:37.000' AS DateTime), CAST(N'2017-07-22T11:30:37.000' AS DateTime), N'VP.Đề Thám', N'Mũi Né', N'C000017', 10)
SET IDENTITY_INSERT [dbo].[LichTrinh] OFF
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00001', N'Nguyễn Đức Đông', N'36/17, Nguyễn Du, P.7, Q.Gò Vấp', N'093824763646', N'01675986916', NULL, N'1642015', N'123456', 3, NULL, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00002', N'Đỗ Minh Thiện', N'4, Nguyễn Thái Học, P.9, Q.8', N'022327462374', N'0908764534', NULL, N'1642068', N'123456', 2, NULL, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00003', N'Lâm Thiên Hưng', N'3, An Dương Vương, P.5, Q.5', N'022347263743', N'0908432434', 120, N'1642027', N'123456', 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00004', N'Nguyễn Kim Hùng', N'4, Đường 3/2, P.10, Q.10', N'022362746346', N'01247657364', 300, N'1642022', N'123456', 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00005', N'Nguyễn Thị Ánh Nhi', N'6, Lý Chính Thắng, P.2, Q.3', N'022387475674', N'0908463564', 500, N'ntanhi', N'123456', 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00006', N'Nguyễn Đức Toàn', N'4/4, Võ Thị Sáu, P.1, Q.1', N'023476576455', N'0903436546', 400, N'ndtoan', N'123456', 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00007', N'Nguyễn Văn Anh', N'3, Nguyễn Thái Sơn, P.5, Q.Gò Vấp', N'022847465756', N'0906325364', 1600, N'nvanh', N'123456', 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00008', N'Lâm Ngọc Hưng', N'5, Hoàng Minh Giám, P9, Q.Phú Nhuận', N'089437463765', N'01224765734', 500, N'lnhung', N'123456', 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00009', N'Nguyễn Ngọc Bích', N'6, Tôn Đức Thắng, P.5, Q.1', N'033756347654', N'0907373465', 600, N'nnbich', N'123456', 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00010', N'Bùi Đức Tài', N'5, Bạch Đằng, P.8, Q.Phú Nhuận', N'034273463566', N'0907635246', 200, N'bdtai', N'123456', 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00011', N'Đinh Hoàng Tú Tài', N'4/5/6, Đường số 7, P.9, Q.Tân Phú', N'023284773465', N'0907263536', 350, N'dhttai', N'123456', 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00012', N'Ái Nhĩ Lan', N'3, Phạm Văn Đồng, P.7, Q.Thủ Đức', N'039827473245', N'0909382744', 600, N'anlan', N'123456', 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00013', N'Lý Nhã Kỳ', N'4, Lũy Bán Bích, P.4, Q.Tân Phú', N'038747464756', N'0909827344', 400, N'lnky', N'123456', 1, 2, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00014', N'Vũ Đức Anh', N'3, Độc Lập, P.3, Q.Tân Phú', N'124634564756', N'0903473654', 200, N'vdanh', N'123456', 1, 2, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00015', N'Phạm Cao Thái', N'4/5/6, Phan Văn Trị, P.10, Q.Bình Thạnh', N'346746376756', N'01234765755', 300, N'pcthai', N'123456', 1, 2, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00016', N'Đinh Hoàng ', N'3, CMT8, P.4, Q.Phú Nhuận', N'121321746374', N'01223467555', 400, N'dhoang', N'123456', 1, 2, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00017', N'Nguyễn Thị Mai Linh', N'4, Xa Lộ Hà Nội, P.Linh Trung, Q.Thủ Đức ', N'082327467465', N'0908734623', 600, N'ntmlinh', N'123456', 1, 2, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00018', N'Nguyễn Công Danh', N'3/4, Lương Trúc Đàm, P.5, Q.Tân Bình', N'093472473657', N'0909372645', 2000, N'ncdanh', N'123456', 1, 2, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00019', N'Phạm Thị Yến Linh', N'2, Quốc Lộ 1A, P. Linh Chiểu, Q.Thủ Đức', N'093246372645', N'0908213124', 1300, N'ptylinh', N'123456', 1, 2, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00020', N'Mai Châu Yến Linh', N'3/4, Kha Vạn Cân, P.6, Q.Thủ Đức', N'033553745586', N'0908736245', 700, N'mcylinh', N'123456', 1, 2, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00021', N'Nguyễn Nhật Khánh', N'3, Nguyễn Văn Nghi, P.7, Q.Gò Vấp', N'023487278545', N'0908276721', 900, N'nnkhanh', N'123456', 1, 2, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00022', N'Ịp Sùi Dậu', N'4/5, Đường 3/2, P.9, Q.10', N'039423895735', N'01223437566', 650, N'isdau', N'123456', 1, 2, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00023', N'Võ Văn Thành', N'6, Độc Lập, P.3, Q.10', N'034235746556', N'0934324556', 700, N'vvthanh', N'123456', 1, 3, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00024', N'Nguyễn Cao Chí Thanh', N'6/7/8, Đường Số 9, P.5, Q.7', N'022124143357', N'0908732673', 200, N'nccthanh', N'123456', 1, 3, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00025', N'Vũ Nguyễn Lan Anh', N'3/4, Trường Chinh, P.8, Q.Phú Nhuận ', N'098324723465', N'0908732654', 150, N'vnlanh', N'123456', 1, 3, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00026', N'Cao Sơn Thái', N'2, Cộng Hòa, P.6, Q.Phú Nhuận', N'034353467867', N'0903232345', 600, N'csthai', N'123456', 1, 3, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00027', N'Cao Sơn Anh', N'2/5, Quốc Lộ 13, P.8, H.Hóc Môn', N'076235472434', N'0904232455', 750, N'csanh', N'123456', 1, 3, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00028', N'Nguyễn Thị Sáng', N'5/6/4, Võ Thị Sáu, P.4, Q.1', N'022148732456', N'0903123245', 1800, N'ntsang', N'123456', 1, 3, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00029', N'Nguyễn Văn Thành Đạt', N'3, Quang Trung, P.6, Q.Gò Vấp', N'043546637264', N'01224534667', 550, N'nvtdat', N'123456', 1, 3, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00030', N'Nguyễn Sơn Thiện', N'5, Hà Huy Giáp, P.6, Q.12', N'022376473566', N'01223242356', 400, N'nsthien', N'123456', 1, 3, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00031', N'Đỗ Đình Anh Tài', N'8, Đường Số 10, P. Nhị Đình, H.Hóc Môn', N'091237183746', N'0907326542', 860, N'ddatai', N'123456', 1, 3, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00032', N'Đinh Thái Sơn', N'3/2, Nguyễn Oanh, P.5, Q.12', N'022389274743', N'0903232456', 750, N'dtson', N'123456', 1, 3, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00033', N'Lương Văn Thiện', N'6/4, Nguyễn Du, P.7, Q.GV', N'023849734734', N'01223764758', NULL, N'lvthien', N'123456', 4, NULL, 1)
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [DiaChi], [CMND], [DienThoai], [KhaNangLai], [Username], [Password], [MaPQ], [MaTo], [TinhTrang]) VALUES (N'NV00034', N'Phạm Thị Minh', N'2, Nguyễn Văn Cừ', N'039447587697', N'0908326364', NULL, N'ptminh', N'123456', 4, NULL, 1)
SET IDENTITY_INSERT [dbo].[Nhom] ON 

INSERT [dbo].[Nhom] ([MaTo], [NgayLap], [ToTruong]) VALUES (1, CAST(N'2017-07-06' AS Date), N'NV00003')
INSERT [dbo].[Nhom] ([MaTo], [NgayLap], [ToTruong]) VALUES (2, CAST(N'2017-07-06' AS Date), N'NV00013')
INSERT [dbo].[Nhom] ([MaTo], [NgayLap], [ToTruong]) VALUES (3, CAST(N'2017-07-06' AS Date), N'NV00023')
INSERT [dbo].[Nhom] ([MaTo], [NgayLap], [ToTruong]) VALUES (4, CAST(N'2017-07-06' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[Nhom] OFF
SET IDENTITY_INSERT [dbo].[PhanQuyen] ON 

INSERT [dbo].[PhanQuyen] ([MaPQ], [TenPQ]) VALUES (1, N'Tài xế')
INSERT [dbo].[PhanQuyen] ([MaPQ], [TenPQ]) VALUES (2, N'Quản lí')
INSERT [dbo].[PhanQuyen] ([MaPQ], [TenPQ]) VALUES (3, N'Quản trị')
INSERT [dbo].[PhanQuyen] ([MaPQ], [TenPQ]) VALUES (4, N'Khách hàng')
SET IDENTITY_INSERT [dbo].[PhanQuyen] OFF
INSERT [dbo].[TinhTrang] ([MaTinhTrang], [TenTinhTrang]) VALUES (0, N'Lock')
INSERT [dbo].[TinhTrang] ([MaTinhTrang], [TenTinhTrang]) VALUES (1, N'Unlock')
INSERT [dbo].[TuyenDuong] ([MaTuyen], [TenTuyen], [KhoangCach]) VALUES (N'TD00001', N'Thành phố Hồ Chí Minh - Hà Nội', 1573)
INSERT [dbo].[TuyenDuong] ([MaTuyen], [TenTuyen], [KhoangCach]) VALUES (N'TD00002', N'Thành phố Hồ Chí Minh - Đà Lạt', 304)
INSERT [dbo].[TuyenDuong] ([MaTuyen], [TenTuyen], [KhoangCach]) VALUES (N'TD00003', N'Thành phố Hồ Chí Minh - Nha Trang', 449)
INSERT [dbo].[TuyenDuong] ([MaTuyen], [TenTuyen], [KhoangCach]) VALUES (N'TD00004', N'Thành phố Hồ Chí Minh - Đà Nẵng', 926)
INSERT [dbo].[TuyenDuong] ([MaTuyen], [TenTuyen], [KhoangCach]) VALUES (N'TD00005', N'Thành phố Hồ Chí Minh - Phnôm Pênh', 253)
INSERT [dbo].[TuyenDuong] ([MaTuyen], [TenTuyen], [KhoangCach]) VALUES (N'TD00006', N'Thành phố Hồ Chí Minh - Mũi Né', 217)
INSERT [dbo].[TuyenDuong] ([MaTuyen], [TenTuyen], [KhoangCach]) VALUES (N'TD00007', N'Thành phố Hồ Chí Minh - Vũng Tàu', 104)
INSERT [dbo].[TuyenDuong] ([MaTuyen], [TenTuyen], [KhoangCach]) VALUES (N'TD00008', N'Thành phố Hồ Chí Minh - Khánh Hòa', 436)
INSERT [dbo].[TuyenDuong] ([MaTuyen], [TenTuyen], [KhoangCach]) VALUES (N'TD00009', N'Thành phố Hồ Chí Minh - Buôn Ma Thuột', 363)
INSERT [dbo].[TuyenDuong] ([MaTuyen], [TenTuyen], [KhoangCach]) VALUES (N'TD00010', N'Thành phố Hồ Chí Minh - Rạch Giá - Kiên Giang', 244)
ALTER TABLE [dbo].[ChuyenXe]  WITH CHECK ADD  CONSTRAINT [FK_ChuyenXe_TuyenDuong] FOREIGN KEY([MaTuyen])
REFERENCES [dbo].[TuyenDuong] ([MaTuyen])
GO
ALTER TABLE [dbo].[ChuyenXe] CHECK CONSTRAINT [FK_ChuyenXe_TuyenDuong]
GO
ALTER TABLE [dbo].[LichTrinh]  WITH CHECK ADD  CONSTRAINT [FK_LichTrinh_ChuyenXe] FOREIGN KEY([MaChuyen])
REFERENCES [dbo].[ChuyenXe] ([MaChuyen])
GO
ALTER TABLE [dbo].[LichTrinh] CHECK CONSTRAINT [FK_LichTrinh_ChuyenXe]
GO
ALTER TABLE [dbo].[LichTrinh]  WITH CHECK ADD  CONSTRAINT [FK_LichTrinh_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[LichTrinh] CHECK CONSTRAINT [FK_LichTrinh_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhanQuyen] FOREIGN KEY([MaPQ])
REFERENCES [dbo].[PhanQuyen] ([MaPQ])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhanQuyen]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TinhTrang] FOREIGN KEY([TinhTrang])
REFERENCES [dbo].[TinhTrang] ([MaTinhTrang])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TinhTrang]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_To] FOREIGN KEY([MaTo])
REFERENCES [dbo].[Nhom] ([MaTo])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_To]
GO
ALTER TABLE [dbo].[Nhom]  WITH CHECK ADD  CONSTRAINT [FK_To_NhanVien] FOREIGN KEY([ToTruong])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[Nhom] CHECK CONSTRAINT [FK_To_NhanVien]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã chuyến' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ChuyenXe', @level2type=N'COLUMN',@level2name=N'MaChuyen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Hãng xe' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ChuyenXe', @level2type=N'COLUMN',@level2name=N'HangXe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Giá vé' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ChuyenXe', @level2type=N'COLUMN',@level2name=N'GiaVe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã tuyến' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ChuyenXe', @level2type=N'COLUMN',@level2name=N'MaTuyen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã lịch' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LichTrinh', @level2type=N'COLUMN',@level2name=N'MaLich'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã nhân viên' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LichTrinh', @level2type=N'COLUMN',@level2name=N'MaNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tháng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LichTrinh', @level2type=N'COLUMN',@level2name=N'Thang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Giờ đi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LichTrinh', @level2type=N'COLUMN',@level2name=N'GioDi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Giờ đến' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LichTrinh', @level2type=N'COLUMN',@level2name=N'GioDen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nơi đi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LichTrinh', @level2type=N'COLUMN',@level2name=N'NoiDi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nơi đến' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LichTrinh', @level2type=N'COLUMN',@level2name=N'NoiDen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã chuyến' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LichTrinh', @level2type=N'COLUMN',@level2name=N'MaChuyen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Số lượng vé bán được' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LichTrinh', @level2type=N'COLUMN',@level2name=N'SoLuongVeBanDuoc'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã nhân viên' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MaNV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Họ tên' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'HoTen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Địa chỉ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'DiaChi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CMND' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'CMND'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Điện thoại' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'DienThoai'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Khả năng lái' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'KhaNangLai'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tên đăng nhập' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Username'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mật khẩu' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'Password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Phân quyền' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'MaPQ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tình trạng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhanVien', @level2type=N'COLUMN',@level2name=N'TinhTrang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã tổ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Nhom', @level2type=N'COLUMN',@level2name=N'MaTo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày lập' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Nhom', @level2type=N'COLUMN',@level2name=N'NgayLap'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tổ trưởng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Nhom', @level2type=N'COLUMN',@level2name=N'ToTruong'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã phân quyền' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PhanQuyen', @level2type=N'COLUMN',@level2name=N'MaPQ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tên phân quyền' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PhanQuyen', @level2type=N'COLUMN',@level2name=N'TenPQ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã tình trạng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TinhTrang', @level2type=N'COLUMN',@level2name=N'MaTinhTrang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tên tình trạng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TinhTrang', @level2type=N'COLUMN',@level2name=N'TenTinhTrang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã tuyến' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TuyenDuong', @level2type=N'COLUMN',@level2name=N'MaTuyen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tên tuyến' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TuyenDuong', @level2type=N'COLUMN',@level2name=N'TenTuyen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Khoảng cách' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TuyenDuong', @level2type=N'COLUMN',@level2name=N'KhoangCach'
GO
