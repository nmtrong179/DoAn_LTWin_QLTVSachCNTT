USE [master]
GO
/****** Object:  Database [DoAn_QLTVSachCNTT]    Script Date: 7/25/2020 2:51:10 PM ******/
CREATE DATABASE [DoAn_QLTVSachCNTT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DoAn_QLTVSachCNTT', FILENAME = N'D:\PTTK HT\DoAn\DoAn_QLTVSachCNTT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DoAn_QLTVSachCNTT_log', FILENAME = N'D:\PTTK HT\DoAn\DoAn_QLTVSachCNTT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DoAn_QLTVSachCNTT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET ARITHABORT OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET  MULTI_USER 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET QUERY_STORE = OFF
GO
USE [DoAn_QLTVSachCNTT]
GO
/****** Object:  Table [dbo].[CTPHIEUMUON]    Script Date: 7/25/2020 2:51:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPHIEUMUON](
	[MaPM] [char](5) NOT NULL,
	[MaSach] [char](5) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_CTPHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 7/25/2020 2:51:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MaDG] [char](5) NOT NULL,
	[TenDG] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](10) NULL,
	[Hinh] [image] NULL,
 CONSTRAINT [PK_DOCGIA] PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 7/25/2020 2:51:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [char](5) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](11) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 7/25/2020 2:51:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [char](5) NOT NULL,
	[HoTenNV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](11) NULL,
	[ChucVu] [nvarchar](10) NULL,
	[ID] [char](5) NULL,
	[Hinh] [image] NULL,
 CONSTRAINT [PK_THUTHU] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 7/25/2020 2:51:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUON](
	[MaPM] [char](5) NOT NULL,
	[NgayMuon] [date] NULL,
	[NgayTra] [date] NULL,
	[MaDG] [char](5) NULL,
	[MaNV] [char](5) NULL,
 CONSTRAINT [PK_PHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 7/25/2020 2:51:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [char](5) NOT NULL,
	[TenSach] [nvarchar](128) NULL,
	[TheLoai] [nvarchar](50) NULL,
	[TacGia] [nvarchar](50) NULL,
	[NXB] [nvarchar](50) NULL,
	[MaNCC] [char](5) NULL,
	[SLTon] [int] NULL,
	[Hinh] [image] NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 7/25/2020 2:51:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[ID] [char](5) NOT NULL,
	[TenTK] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
	[LoaiTK] [int] NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM001', N'SA003', 1)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM001', N'SA006', 2)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM002', N'SA020', 1)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM003', N'SA003', 1)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM003', N'SA007', 1)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM003', N'SA017', 1)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM004', N'SA018', 1)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM005', N'SA016', 2)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM006', N'SA009', 1)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM006', N'SA012', 1)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM006', N'SA022', 1)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM007', N'SA004', 1)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM007', N'SA010', 1)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM008', N'SA005', 2)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM009', N'SA011', 1)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM009', N'SA012', 1)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM010', N'SA020', 3)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM011', N'SA005', 2)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM011', N'SA015', 1)
INSERT [dbo].[CTPHIEUMUON] ([MaPM], [MaSach], [SoLuong]) VALUES (N'PM012', N'SA020', 2)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG001', N'Nguyễn Văn Tâm', CAST(N'1999-07-12' AS Date), 1, N'Bình Dương', N'0912334216', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG002', N'Trần Thị Thu', CAST(N'1995-04-10' AS Date), 0, N'Đồng Nai', N'0358125233', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG003', N'Nguyễn Văn Nam', CAST(N'2001-08-25' AS Date), 1, N'Tây Ninh', N'0315898798', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG004', N'Phạm Văn Quân', CAST(N'1999-11-24' AS Date), 1, N'Bình Dương', N'0998987286', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG005', N'Hoàng Văn Chinh', CAST(N'1986-12-12' AS Date), 1, N'Đăk Nông', N'0962847866', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG006', N'Phạm Thị Viên', CAST(N'2000-11-18' AS Date), 0, N'TP HCM', N'0312354999', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG007', N'Phạm Thị Mai Lan', CAST(N'1990-10-10' AS Date), 0, N'Bình Dương', N'0358197128', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG008', N'Trần Quyết Thắng', CAST(N'1994-07-15' AS Date), 1, N'TP HCM', N'0376186237', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG009', N'Lương Ngọc Quyên', CAST(N'1990-11-27' AS Date), 0, N'Đà Nẵng', N'0963472543', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG010', N'Nguyễn Văn Thực', CAST(N'1994-10-30' AS Date), 1, N'Hải Phòng', N'0923428482', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG011', N'Phạm Thị Thanh Mai', CAST(N'1991-09-27' AS Date), 0, N'Bình Dương', N'0926472387', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG012', N'Phạm Văn Nam', CAST(N'1993-05-14' AS Date), 1, N'Đồng Nai', N'0327368723', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG013', N'Nguyễn Mạnh Hưng', CAST(N'1995-03-25' AS Date), 1, N'Quảng Ngãi', N'0237623764', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG014', N'Lê Thị Trúc Anh', CAST(N'1995-07-12' AS Date), 0, N'Bình Dương', N'0927642723', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG015', N'Phạm Thế Phong', CAST(N'1999-02-28' AS Date), 1, N'Tây Ninh', N'0327476238', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG016', N'Nguyễn Minh Triết', CAST(N'1979-12-12' AS Date), 1, N'Bình Phước', N'0927486274', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG017', N'Lê Thu Dung', CAST(N'2001-10-20' AS Date), 0, N'Bình Phước', N'0243824676', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG018', N'Trần Văn Chính', CAST(N'2000-06-22' AS Date), 1, N'TP HCM', N'0233747647', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG019', N'Lê Kiều Oanh', CAST(N'2002-10-10' AS Date), 0, N'Bình Dương', N'0326736437', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG020', N'Trần Thị Dung', CAST(N'1989-06-21' AS Date), 0, N'Bình Dương', N'0927364723', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG021', N'Nguyễn Văn Cường', CAST(N'1998-09-12' AS Date), 1, N'Bình Dương', N'0923424236', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG022', N'Võ Tấn Lộc', CAST(N'2000-09-25' AS Date), 1, N'Đà Nẵng', N'0232764273', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG023', N'Trần Thị Ngọc Ánh', CAST(N'1990-01-11' AS Date), 0, N'Hải Phòng', N'0326276827', NULL)
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [Hinh]) VALUES (N'DG024', N'Phạm Hoàng Long', CAST(N'1987-02-14' AS Date), 1, N'TP HCM', N'0923279228', NULL)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC01', N'ĐH QG HN', N'Bình Dương', N'0234232434 ')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC02', N'Giáo Dục', N'Hà Nội', N'0234243543 ')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC03', N'Thiên Long', N'TP HCM', N'0326742237 ')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC04', N'Thanh Long', N'Bình Dương', N'0927362333 ')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC05', N'Minh Huy', N'Bình Dương', N'0332523234 ')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC06', N'Huyền Vũ', N'Đà Nẵng', N'0912732323 ')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC07', N'Hồng Hà', N'Bình Dương', N'0989767778 ')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [ChucVu], [ID], [Hinh]) VALUES (N'NV001', N'Nguyễn Minh Trọng', NULL, 1, N'Bình Dương', N'0358126179 ', N'Quản Lý', N'ID001', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [ChucVu], [ID], [Hinh]) VALUES (N'NV002', N'Trần Phương Nhi', NULL, 0, N'Bình Dương', N'0243232444 ', N'Quản Lý', N'ID002', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [ChucVu], [ID], [Hinh]) VALUES (N'NV003', N'Trần Văn Toàn', NULL, 1, N'TP HCM', N'0923535634 ', N'Thủ Thư', N'ID003', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [ChucVu], [ID], [Hinh]) VALUES (N'NV004', N'Ngô Minh Thanh', NULL, 1, N'Bình Phước', N'0354642332 ', N'Thủ Thư', N'ID004', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [ChucVu], [ID], [Hinh]) VALUES (N'NV005', N'Nguyễn Thị Hoa', NULL, 0, N'TP HCM', N'0234543435 ', N'Thủ Thư', N'ID005', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [ChucVu], [ID], [Hinh]) VALUES (N'NV006', N'Phạm Thu Ngân', NULL, 0, N'Đà Nẵng', N'0964743223 ', N'Thủ Thư', N'ID006', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [ChucVu], [ID], [Hinh]) VALUES (N'NV007', N'Nguyễn Trí Dũng', NULL, 1, N'Bình Dương', N'0958453445 ', N'Thủ Thư', N'ID007', NULL)
INSERT [dbo].[PHIEUMUON] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaNV]) VALUES (N'PM001', CAST(N'2019-01-14' AS Date), CAST(N'2019-01-24' AS Date), N'DG001', N'NV003')
INSERT [dbo].[PHIEUMUON] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaNV]) VALUES (N'PM002', CAST(N'2019-07-22' AS Date), CAST(N'2019-08-06' AS Date), N'DG005', N'NV004')
INSERT [dbo].[PHIEUMUON] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaNV]) VALUES (N'PM003', CAST(N'2020-01-12' AS Date), CAST(N'2020-01-22' AS Date), N'DG006', N'NV005')
INSERT [dbo].[PHIEUMUON] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaNV]) VALUES (N'PM004', CAST(N'2019-08-16' AS Date), CAST(N'2019-08-26' AS Date), N'DG020', N'NV006')
INSERT [dbo].[PHIEUMUON] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaNV]) VALUES (N'PM005', CAST(N'2019-08-17' AS Date), CAST(N'2019-09-01' AS Date), N'DG024', N'NV007')
INSERT [dbo].[PHIEUMUON] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaNV]) VALUES (N'PM006', CAST(N'2020-02-08' AS Date), CAST(N'2020-02-18' AS Date), N'DG007', N'NV005')
INSERT [dbo].[PHIEUMUON] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaNV]) VALUES (N'PM007', CAST(N'2019-07-28' AS Date), CAST(N'2019-08-12' AS Date), N'DG015', N'NV004')
INSERT [dbo].[PHIEUMUON] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaNV]) VALUES (N'PM008', CAST(N'2019-06-22' AS Date), CAST(N'2019-07-01' AS Date), N'DG012', N'NV007')
INSERT [dbo].[PHIEUMUON] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaNV]) VALUES (N'PM009', CAST(N'2019-12-12' AS Date), CAST(N'2019-12-22' AS Date), N'DG002', N'NV003')
INSERT [dbo].[PHIEUMUON] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaNV]) VALUES (N'PM010', CAST(N'2019-03-24' AS Date), CAST(N'2019-04-08' AS Date), N'DG013', N'NV003')
INSERT [dbo].[PHIEUMUON] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaNV]) VALUES (N'PM011', CAST(N'2019-05-16' AS Date), CAST(N'2019-05-26' AS Date), N'DG001', N'NV004')
INSERT [dbo].[PHIEUMUON] ([MaPM], [NgayMuon], [NgayTra], [MaDG], [MaNV]) VALUES (N'PM012', CAST(N'2019-08-30' AS Date), CAST(N'2019-09-14' AS Date), N'DG017', N'NV005')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA001', N'Giáo Trình Lập Trình Java', N'Ngôn Ngữ Lập Trình', N'Đoàn Văn Ban', N'Giáo Dục Việt Nam', N'NCC01', 50, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA002', N'Giáo Trình Kỹ Thuật Lập Trình C', N'Ngôn Ngữ Lập Trình', N'Phạm Văn Ất', N'Hồng Đức', N'NCC02', 75, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA003', N'Lập Trình C# Từ Cơ Bản Đến Nâng Cao', N'Ngôn Ngữ Lập Trình', N'Phạm Công Ngô', N'Giáo Dục', N'NCC01', 35, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA004', N'Lập Trình Cơ Bản PHP Và MySQL', N'Ngôn Ngữ Lập Trình', N'Joel Murach', N'Khoa Học Và Kỹ Thuật', N'NCC03', 50, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA005', N'Hướng Dẫn Thiết Kế Website', N'Thiết Kế Web', N'Water PC', N'Văn Hoá - Thông Tin', N'NCC04', 100, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA006', N'CSS And HTML Web Design', N'Thiết Kế Web', N'Craig Grannell', NULL, N'NCC04', 45, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA007', N'HTML5 & CSS3 Thiết Kế Trang Web Thích Ứng Giàu Tính Năng', N'Thiết Kế Web', N'Jeremy Osborn', N'Bách Khoa Hà Nội', N'NCC05', 50, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA008', N'Thiết Kế Web Với Dreamweaver', N'Thiết Kế Web', N'Jeremy Osborn', N'Bách Khoa Hà Nội', N'NCC05', 50, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA009', N'Giáo Trình Tự Học AutoCad 2019', N'Đồ Hoạ', N'Nhiều Tác Giả', N'Đồng Nai', N'NCC06', 70, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA010', N'Tự Học Thiết Kế Đồ Hoạ Trên PhotoShop 2019', N'Đồ Hoạ', N'Nguyễn Đức Hiếu', N'Hồng Đức', N'NCC06', 70, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA011', N'Tự Học Microsoft Excel 2016', N'Tin Học - Văn Phòng', N'Nhiều Tác Giả', N'Hồng Đức', N'NCC07', 45, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA012', N'Tự Học Microsoft Word 2010', N'Tin Học - Văn Phòng', N'Nhiều Tác Giả', N'Văn Hoá - Thông Tin', N'NCC07', 50, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA013', N'Giáo Trình Nhập Môn Mạng Máy Tính', N'Quản Trị Mạng', N'Hồ Đắc Phương', N'Giáo Dục Việt Nam', N'NCC04', 50, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA014', N'Giáo Trình Tổng Hợp Mạng Máy Tính Tổng Hợp', N'Quản Trị Mạng', N'Nhiều Tác Giả', NULL, N'NCC03', 50, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA015', N'Giáo Trình Quản Trị Mạng', N'Quản Trị Mạng', N'Lê Hoài Nghĩa', N'ĐH QG TP HCM', N'NCC03', 30, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA016', N'Blockchain', N'Bảo Mật   ', N'Mark Gates', N'Lao Động', N'NCC02', 20, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA017', N'Bóng Ma Trên Mạng', N'Bảo Mật   ', N'Kevin Mitnick', N'Công Thương', N'NCC02', 20, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA018', N'Gián Điệp Mạng', N'Bảo Mật   ', N'Clifford Stoll', N'Công Thương', N'NCC02', 20, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA019', N'Ứng Dụng Trí Tuệ Nhân Tạo Để Dẫn Đầu', N'Khác      ', N'Bernard Marr', N'Thế Giới', N'NCC05', 40, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA020', N'Trí Tuệ Nhân Tạo Trong Marketing', N'Khác      ', N'Katie King', N'Công Thương', N'NCC06', 35, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA021', N'Code Dạo Ký Sự', N'Khác      ', N'Phạm Huy Hoàng', N'Dân Trí', N'NCC07', 100, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA022', N'Lập Trình Và Cuộc Sống', N'Khác      ', N'Jeff Atwood', N'Dân Trí', N'NCC01', 100, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA023', N'Lập Trình Python', N'Ngôn Ngữ Lập Trình', N'Nguyễn Văn Tuấn', N'Hồng Đức', N'NCC05', NULL, NULL)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [TheLoai], [TacGia], [NXB], [MaNCC], [SLTon], [Hinh]) VALUES (N'SA024', N'sấd', N'ấ', N'sfaas', N'sdfas', N'NCC03', NULL, NULL)
INSERT [dbo].[TAIKHOAN] ([ID], [TenTK], [MatKhau], [LoaiTK]) VALUES (N'ID001', N'quanly01', N'@Trong02456789', 1)
INSERT [dbo].[TAIKHOAN] ([ID], [TenTK], [MatKhau], [LoaiTK]) VALUES (N'ID002', N'quanly02', N'@Quanly456', 1)
INSERT [dbo].[TAIKHOAN] ([ID], [TenTK], [MatKhau], [LoaiTK]) VALUES (N'ID003', N'thuthu01', N'@Thuthu123', 0)
INSERT [dbo].[TAIKHOAN] ([ID], [TenTK], [MatKhau], [LoaiTK]) VALUES (N'ID004', N'thuthu02', N'@Thuthu456', 0)
INSERT [dbo].[TAIKHOAN] ([ID], [TenTK], [MatKhau], [LoaiTK]) VALUES (N'ID005', N'thuthu03', N'@Thuthu789', 0)
INSERT [dbo].[TAIKHOAN] ([ID], [TenTK], [MatKhau], [LoaiTK]) VALUES (N'ID006', N'thuthu04', N'@Thuthu135', 0)
INSERT [dbo].[TAIKHOAN] ([ID], [TenTK], [MatKhau], [LoaiTK]) VALUES (N'ID007', N'thuthu05', N'@Thuthu246', 0)
ALTER TABLE [dbo].[CTPHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CTPHIEUMUON_PHIEUMUON] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PHIEUMUON] ([MaPM])
GO
ALTER TABLE [dbo].[CTPHIEUMUON] CHECK CONSTRAINT [FK_CTPHIEUMUON_PHIEUMUON]
GO
ALTER TABLE [dbo].[CTPHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CTPHIEUMUON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CTPHIEUMUON] CHECK CONSTRAINT [FK_CTPHIEUMUON_SACH]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_THUTHU_TAIKHOAN] FOREIGN KEY([ID])
REFERENCES [dbo].[TAIKHOAN] ([ID])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_THUTHU_TAIKHOAN]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_DOCGIA] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DOCGIA] ([MaDG])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_DOCGIA]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_THUTHU] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_THUTHU]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NHACUNGCAP] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NHACUNGCAP]
GO
USE [master]
GO
ALTER DATABASE [DoAn_QLTVSachCNTT] SET  READ_WRITE 
GO
