USE [master]
GO
/****** Object:  Database [CuaHang_XeMay]    Script Date: 1/1/2021 10:06:49 AM ******/
CREATE DATABASE [CuaHang_XeMay]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CuaHang_XeMay', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CuaHang_XeMay.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CuaHang_XeMay_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CuaHang_XeMay_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CuaHang_XeMay] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CuaHang_XeMay].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CuaHang_XeMay] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET ARITHABORT OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CuaHang_XeMay] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CuaHang_XeMay] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CuaHang_XeMay] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CuaHang_XeMay] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CuaHang_XeMay] SET  MULTI_USER 
GO
ALTER DATABASE [CuaHang_XeMay] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CuaHang_XeMay] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CuaHang_XeMay] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CuaHang_XeMay] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CuaHang_XeMay] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CuaHang_XeMay] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CuaHang_XeMay] SET QUERY_STORE = OFF
GO
USE [CuaHang_XeMay]
GO
/****** Object:  Table [dbo].[ChucNang]    Script Date: 1/1/2021 10:06:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucNang](
	[ma_CN] [int] IDENTITY(5000,1) NOT NULL,
	[ten_CN] [ntext] NULL,
	[ma_UI] [ntext] NULL,
 CONSTRAINT [PK_ChucNang] PRIMARY KEY CLUSTERED 
(
	[ma_CN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_PhieuNhap]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PhieuNhap](
	[ma_PN] [int] NOT NULL,
	[ma_SP] [int] NOT NULL,
	[gianhap_SP] [int] NULL,
	[soluong_SP] [int] NULL,
	[tongtien_SP] [int] NULL,
 CONSTRAINT [PK_CT_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[ma_PN] ASC,
	[ma_SP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_Quyen]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_Quyen](
	[ma_NV] [int] NOT NULL,
	[ma_CN] [int] NOT NULL,
 CONSTRAINT [PK_CT_Quyen] PRIMARY KEY CLUSTERED 
(
	[ma_NV] ASC,
	[ma_CN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHD_BanHang]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD_BanHang](
	[ma_HD] [int] NOT NULL,
	[ma_SP] [int] NOT NULL,
	[gia_SP] [int] NULL,
	[soluong_SP] [int] NULL,
	[tongtien_SP] [int] NULL,
 CONSTRAINT [PK_CTHD_BanHang] PRIMARY KEY CLUSTERED 
(
	[ma_HD] ASC,
	[ma_SP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHD_DichVu]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD_DichVu](
	[ma_HDDV] [int] NOT NULL,
	[ma_DV] [int] NOT NULL,
	[gia_DV] [int] NULL,
	[soluong_DV] [int] NULL,
	[tongtien_DV] [int] NULL,
 CONSTRAINT [PK_CTHD_DichVu] PRIMARY KEY CLUSTERED 
(
	[ma_HDDV] ASC,
	[ma_DV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[ma_DM] [int] IDENTITY(4000,1) NOT NULL,
	[ten_DM] [ntext] NULL,
 CONSTRAINT [PK_DanhMuc] PRIMARY KEY CLUSTERED 
(
	[ma_DM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[ma_DV] [int] IDENTITY(8000,1) NOT NULL,
	[ten_DV] [ntext] NULL,
	[mota_DV] [ntext] NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[ma_DV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gia_DV]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gia_DV](
	[ma_GiaDV] [int] IDENTITY(9000,1) NOT NULL,
	[ma_DV] [int] NULL,
	[gia_DV] [int] NULL,
	[ngay_DBDV] [date] NULL,
	[ngay_KTDV] [date] NULL,
 CONSTRAINT [PK_Gia_DV] PRIMARY KEY CLUSTERED 
(
	[ma_GiaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gia_SP]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gia_SP](
	[ma_GiaSP] [int] IDENTITY(10000,1) NOT NULL,
	[ma_SP] [int] NULL,
	[gia_SP] [int] NULL,
	[ngay_BDSP] [date] NULL,
	[ngay_KTSP] [date] NULL,
 CONSTRAINT [PK_Gia_SP] PRIMARY KEY CLUSTERED 
(
	[ma_GiaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hang_SX]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hang_SX](
	[ma_Hang] [int] IDENTITY(3000,1) NOT NULL,
	[ten_Hang] [ntext] NULL,
 CONSTRAINT [PK_Hang_SX] PRIMARY KEY CLUSTERED 
(
	[ma_Hang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HD_BanHang]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HD_BanHang](
	[ma_hd] [int] NOT NULL,
	[ma_kh] [int] NULL,
	[ma_nv] [int] NULL,
	[ngaylap_hd] [date] NULL,
	[thanhtien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_hd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HD_DichVu]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HD_DichVu](
	[ma_HDDV] [int] IDENTITY(13000,1) NOT NULL,
	[ma_KH] [int] NULL,
	[ma_NV] [int] NULL,
	[isDelete] [bit] NULL,
 CONSTRAINT [PK_HD_DichVu] PRIMARY KEY CLUSTERED 
(
	[ma_HDDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ma_KH] [int] IDENTITY(7000,1) NOT NULL,
	[ten_HK] [ntext] NULL,
	[mail_KH] [ntext] NULL,
	[sdt_KH] [ntext] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[ma_KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loai_SP]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai_SP](
	[ma_Loai] [int] IDENTITY(2000,1) NOT NULL,
	[ten_Loai] [ntext] NULL,
 CONSTRAINT [PK_Loai_SP] PRIMARY KEY CLUSTERED 
(
	[ma_Loai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nha_CungCap]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nha_CungCap](
	[ma_NCC] [int] IDENTITY(1000,1) NOT NULL,
	[ten_NCC] [ntext] NULL,
 CONSTRAINT [PK_Nha_CungCap] PRIMARY KEY CLUSTERED 
(
	[ma_NCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ma_NV] [int] IDENTITY(6000,1) NOT NULL,
	[ten_NV] [ntext] NULL,
	[mail_NV] [varchar](100) NULL,
	[sdt_NV] [ntext] NULL,
	[mk_DangNhap] [ntext] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[ma_NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[ma_PN] [int] IDENTITY(11000,1) NOT NULL,
	[ma_NCC] [int] NULL,
	[ma_NV] [int] NULL,
	[ngaylap_PN] [date] NULL,
	[isDelete] [bit] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[ma_PN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[ma_SP] [int] IDENTITY(14000,1) NOT NULL,
	[ma_DM] [int] NULL,
	[ma_Loai] [int] NULL,
	[ma_Hang] [int] NULL,
	[mau_SP] [ntext] NULL,
	[soluong_SP] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[ma_SP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[CTHD_BanHang] ([ma_HD], [ma_SP], [gia_SP], [soluong_SP], [tongtien_SP]) VALUES (12001, 14000, 10000, 2, 20000)
INSERT [dbo].[CTHD_BanHang] ([ma_HD], [ma_SP], [gia_SP], [soluong_SP], [tongtien_SP]) VALUES (12001, 14004, 19000, 2, 38000)
INSERT [dbo].[CTHD_BanHang] ([ma_HD], [ma_SP], [gia_SP], [soluong_SP], [tongtien_SP]) VALUES (12002, 14003, 17000, 2, 34000)
INSERT [dbo].[CTHD_BanHang] ([ma_HD], [ma_SP], [gia_SP], [soluong_SP], [tongtien_SP]) VALUES (12003, 14013, 12000, 2, 24000)
INSERT [dbo].[CTHD_BanHang] ([ma_HD], [ma_SP], [gia_SP], [soluong_SP], [tongtien_SP]) VALUES (12004, 14011, 12000, 1, 12000)
INSERT [dbo].[CTHD_BanHang] ([ma_HD], [ma_SP], [gia_SP], [soluong_SP], [tongtien_SP]) VALUES (12005, 14011, 12000, 1, 12000)
INSERT [dbo].[CTHD_BanHang] ([ma_HD], [ma_SP], [gia_SP], [soluong_SP], [tongtien_SP]) VALUES (12006, 14013, 12000, 1, 12000)
INSERT [dbo].[CTHD_BanHang] ([ma_HD], [ma_SP], [gia_SP], [soluong_SP], [tongtien_SP]) VALUES (12007, 14012, 16000, 2, 32000)
INSERT [dbo].[CTHD_BanHang] ([ma_HD], [ma_SP], [gia_SP], [soluong_SP], [tongtien_SP]) VALUES (12008, 14010, 76000, 2, 152000)
INSERT [dbo].[CTHD_BanHang] ([ma_HD], [ma_SP], [gia_SP], [soluong_SP], [tongtien_SP]) VALUES (12009, 14003, 17000, 1, 17000)
GO
INSERT [dbo].[CTHD_DichVu] ([ma_HDDV], [ma_DV], [gia_DV], [soluong_DV], [tongtien_DV]) VALUES (13001, 8001, 10000, 1, 10000)
INSERT [dbo].[CTHD_DichVu] ([ma_HDDV], [ma_DV], [gia_DV], [soluong_DV], [tongtien_DV]) VALUES (13002, 8003, 30000, 2, 60000)
INSERT [dbo].[CTHD_DichVu] ([ma_HDDV], [ma_DV], [gia_DV], [soluong_DV], [tongtien_DV]) VALUES (13005, 8008, 15000, 1, 15000)
GO
SET IDENTITY_INSERT [dbo].[DanhMuc] ON 

INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4000, N'Wave Alpha')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4001, N'PCX')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4002, N'SH ')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4003, N'Winner')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4004, N'Vario')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4005, N'Vision')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4006, N'AirBlack')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4007, N'Wave RSX')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4008, N'Black')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4009, N'Rebel 500')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4010, N'SH mode')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4011, N'CBR1000RR')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4012, N'CB500X')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4013, N'TFX')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4014, N'MT-15')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4015, N'YZF-R15')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4016, N'MT-03')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4017, N'YZF-R3')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4018, N'Sirius')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4019, N'Grande')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4020, N'Latte')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4021, N'Jupiter')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4022, N'Janus')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4023, N'Exciter')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4024, N'Freego')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4025, N'Acruzo')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4026, N'Raider')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4027, N'Address')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4028, N'GZ150-A')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4029, N'GD110HU')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4030, N'INTRUDER150')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4031, N'Attila')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4032, N'Passing')
INSERT [dbo].[DanhMuc] ([ma_DM], [ten_DM]) VALUES (4033, N'Klara ')
SET IDENTITY_INSERT [dbo].[DanhMuc] OFF
GO
SET IDENTITY_INSERT [dbo].[DichVu] ON 

INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8000, N'Bảo dưỡng cổ phốt', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8001, N'Bảo dưỡng độ cơ khỏi động', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8002, N'Bảo dưỡng dây công tơ mét', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8003, N'Bảo dưỡng dây phanh', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8004, N'Bảo dưỡng bát phanh trước', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8005, N'Bảo dưỡng công tắc đèn', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8006, N'Bảo dưỡng toàn bộ xe côn tay', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8007, N'Thay cổ bô', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8008, N'Vệ sinh kim phun', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8009, N'Vệ sinh buồn đốt', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8010, N'Vệ sinh họng ga', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8011, N'Vệ sinh lọc gió', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8012, N'Súc nạp Acquy', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8013, N'Bảo dưỡng phanh sau', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8014, N'Bảo dưỡng phanh trước', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8015, N'Thay hộp xích', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8016, N'Kiểm tra hệ thống điện', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8017, N'Nắn khung càng xe tai nạn', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8018, N'Bảo dưỡng giảm sóc trước', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8019, N'Bảo dưỡng giảm sóc sau', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8020, N'Bảo dưỡng bộ chế hòa khí', NULL)
INSERT [dbo].[DichVu] ([ma_DV], [ten_DV], [mota_DV]) VALUES (8021, N'Thay vỏ nhựa', NULL)
SET IDENTITY_INSERT [dbo].[DichVu] OFF
GO
SET IDENTITY_INSERT [dbo].[Gia_DV] ON 

INSERT [dbo].[Gia_DV] ([ma_GiaDV], [ma_DV], [gia_DV], [ngay_DBDV], [ngay_KTDV]) VALUES (9000, 8001, 1000, NULL, NULL)
INSERT [dbo].[Gia_DV] ([ma_GiaDV], [ma_DV], [gia_DV], [ngay_DBDV], [ngay_KTDV]) VALUES (9001, 8002, 10000, NULL, NULL)
INSERT [dbo].[Gia_DV] ([ma_GiaDV], [ma_DV], [gia_DV], [ngay_DBDV], [ngay_KTDV]) VALUES (9002, 8003, 15000, NULL, NULL)
INSERT [dbo].[Gia_DV] ([ma_GiaDV], [ma_DV], [gia_DV], [ngay_DBDV], [ngay_KTDV]) VALUES (9003, 8004, 20000, NULL, NULL)
INSERT [dbo].[Gia_DV] ([ma_GiaDV], [ma_DV], [gia_DV], [ngay_DBDV], [ngay_KTDV]) VALUES (9004, 8005, 21000, NULL, NULL)
INSERT [dbo].[Gia_DV] ([ma_GiaDV], [ma_DV], [gia_DV], [ngay_DBDV], [ngay_KTDV]) VALUES (9005, 8006, 22000, NULL, NULL)
INSERT [dbo].[Gia_DV] ([ma_GiaDV], [ma_DV], [gia_DV], [ngay_DBDV], [ngay_KTDV]) VALUES (9006, 8007, 16000, NULL, NULL)
INSERT [dbo].[Gia_DV] ([ma_GiaDV], [ma_DV], [gia_DV], [ngay_DBDV], [ngay_KTDV]) VALUES (9007, 8008, 19000, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Gia_DV] OFF
GO
SET IDENTITY_INSERT [dbo].[Gia_SP] ON 

INSERT [dbo].[Gia_SP] ([ma_GiaSP], [ma_SP], [gia_SP], [ngay_BDSP], [ngay_KTSP]) VALUES (10000, 14000, 10000, CAST(N'2019-09-10' AS Date), NULL)
INSERT [dbo].[Gia_SP] ([ma_GiaSP], [ma_SP], [gia_SP], [ngay_BDSP], [ngay_KTSP]) VALUES (10001, 14001, 20000, CAST(N'2019-09-10' AS Date), NULL)
INSERT [dbo].[Gia_SP] ([ma_GiaSP], [ma_SP], [gia_SP], [ngay_BDSP], [ngay_KTSP]) VALUES (10002, 14002, 15000, CAST(N'2019-09-10' AS Date), NULL)
INSERT [dbo].[Gia_SP] ([ma_GiaSP], [ma_SP], [gia_SP], [ngay_BDSP], [ngay_KTSP]) VALUES (10003, 14003, 17000, CAST(N'2019-09-10' AS Date), NULL)
INSERT [dbo].[Gia_SP] ([ma_GiaSP], [ma_SP], [gia_SP], [ngay_BDSP], [ngay_KTSP]) VALUES (10004, 14004, 19000, CAST(N'2019-09-10' AS Date), NULL)
INSERT [dbo].[Gia_SP] ([ma_GiaSP], [ma_SP], [gia_SP], [ngay_BDSP], [ngay_KTSP]) VALUES (10005, 14005, 30000, CAST(N'2019-09-10' AS Date), NULL)
INSERT [dbo].[Gia_SP] ([ma_GiaSP], [ma_SP], [gia_SP], [ngay_BDSP], [ngay_KTSP]) VALUES (10006, 14006, 50000, CAST(N'2019-09-10' AS Date), NULL)
INSERT [dbo].[Gia_SP] ([ma_GiaSP], [ma_SP], [gia_SP], [ngay_BDSP], [ngay_KTSP]) VALUES (10007, 14007, 45000, CAST(N'2019-09-10' AS Date), NULL)
INSERT [dbo].[Gia_SP] ([ma_GiaSP], [ma_SP], [gia_SP], [ngay_BDSP], [ngay_KTSP]) VALUES (10008, 14008, 44000, CAST(N'2019-09-10' AS Date), NULL)
INSERT [dbo].[Gia_SP] ([ma_GiaSP], [ma_SP], [gia_SP], [ngay_BDSP], [ngay_KTSP]) VALUES (10009, 14009, 40000, CAST(N'2019-09-10' AS Date), NULL)
INSERT [dbo].[Gia_SP] ([ma_GiaSP], [ma_SP], [gia_SP], [ngay_BDSP], [ngay_KTSP]) VALUES (10010, 14010, 76000, CAST(N'2019-09-10' AS Date), NULL)
INSERT [dbo].[Gia_SP] ([ma_GiaSP], [ma_SP], [gia_SP], [ngay_BDSP], [ngay_KTSP]) VALUES (10011, 14011, 12000, CAST(N'2019-09-10' AS Date), NULL)
INSERT [dbo].[Gia_SP] ([ma_GiaSP], [ma_SP], [gia_SP], [ngay_BDSP], [ngay_KTSP]) VALUES (10012, 14012, 16000, CAST(N'2019-09-10' AS Date), NULL)
INSERT [dbo].[Gia_SP] ([ma_GiaSP], [ma_SP], [gia_SP], [ngay_BDSP], [ngay_KTSP]) VALUES (10013, 14013, 12000, CAST(N'2019-09-10' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[Gia_SP] OFF
GO
SET IDENTITY_INSERT [dbo].[Hang_SX] ON 

INSERT [dbo].[Hang_SX] ([ma_Hang], [ten_Hang]) VALUES (3000, N'Honda')
INSERT [dbo].[Hang_SX] ([ma_Hang], [ten_Hang]) VALUES (3001, N'Yamaha')
INSERT [dbo].[Hang_SX] ([ma_Hang], [ten_Hang]) VALUES (3002, N'Suzuki')
INSERT [dbo].[Hang_SX] ([ma_Hang], [ten_Hang]) VALUES (3003, N'Sym')
INSERT [dbo].[Hang_SX] ([ma_Hang], [ten_Hang]) VALUES (3004, N'VinFast')
SET IDENTITY_INSERT [dbo].[Hang_SX] OFF
GO
INSERT [dbo].[HD_BanHang] ([ma_hd], [ma_kh], [ma_nv], [ngaylap_hd], [thanhtien]) VALUES (12001, 7000, 6000, CAST(N'2020-12-31' AS Date), 58000)
INSERT [dbo].[HD_BanHang] ([ma_hd], [ma_kh], [ma_nv], [ngaylap_hd], [thanhtien]) VALUES (12002, 7003, 6000, CAST(N'2020-12-31' AS Date), 34000)
INSERT [dbo].[HD_BanHang] ([ma_hd], [ma_kh], [ma_nv], [ngaylap_hd], [thanhtien]) VALUES (12003, 7002, 6000, CAST(N'2020-12-31' AS Date), 24000)
INSERT [dbo].[HD_BanHang] ([ma_hd], [ma_kh], [ma_nv], [ngaylap_hd], [thanhtien]) VALUES (12004, 7006, 6000, CAST(N'2020-12-31' AS Date), 12000)
INSERT [dbo].[HD_BanHang] ([ma_hd], [ma_kh], [ma_nv], [ngaylap_hd], [thanhtien]) VALUES (12005, 7007, 6000, CAST(N'2020-12-31' AS Date), 12000)
INSERT [dbo].[HD_BanHang] ([ma_hd], [ma_kh], [ma_nv], [ngaylap_hd], [thanhtien]) VALUES (12006, 7008, 6000, CAST(N'2020-12-31' AS Date), 12000)
INSERT [dbo].[HD_BanHang] ([ma_hd], [ma_kh], [ma_nv], [ngaylap_hd], [thanhtien]) VALUES (12007, 7000, 6000, CAST(N'2020-12-31' AS Date), 32000)
INSERT [dbo].[HD_BanHang] ([ma_hd], [ma_kh], [ma_nv], [ngaylap_hd], [thanhtien]) VALUES (12008, 7006, 6000, CAST(N'2020-12-31' AS Date), 152000)
INSERT [dbo].[HD_BanHang] ([ma_hd], [ma_kh], [ma_nv], [ngaylap_hd], [thanhtien]) VALUES (12009, 7000, 6000, CAST(N'2021-01-01' AS Date), 17000)
GO
SET IDENTITY_INSERT [dbo].[HD_DichVu] ON 

INSERT [dbo].[HD_DichVu] ([ma_HDDV], [ma_KH], [ma_NV], [isDelete]) VALUES (13000, 7000, 6000, 0)
INSERT [dbo].[HD_DichVu] ([ma_HDDV], [ma_KH], [ma_NV], [isDelete]) VALUES (13001, 7001, 6001, 0)
INSERT [dbo].[HD_DichVu] ([ma_HDDV], [ma_KH], [ma_NV], [isDelete]) VALUES (13002, 7006, 6001, 0)
INSERT [dbo].[HD_DichVu] ([ma_HDDV], [ma_KH], [ma_NV], [isDelete]) VALUES (13003, 7002, 6006, 0)
INSERT [dbo].[HD_DichVu] ([ma_HDDV], [ma_KH], [ma_NV], [isDelete]) VALUES (13004, 7003, 6005, 0)
INSERT [dbo].[HD_DichVu] ([ma_HDDV], [ma_KH], [ma_NV], [isDelete]) VALUES (13005, 7001, 6002, 0)
SET IDENTITY_INSERT [dbo].[HD_DichVu] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([ma_KH], [ten_HK], [mail_KH], [sdt_KH]) VALUES (7000, N'Khách hàng 1', N'ngoctin10a11@gmail.com', N'111111')
INSERT [dbo].[KhachHang] ([ma_KH], [ten_HK], [mail_KH], [sdt_KH]) VALUES (7001, N'Khách hàng 2', N'khachhang2', N'222222')
INSERT [dbo].[KhachHang] ([ma_KH], [ten_HK], [mail_KH], [sdt_KH]) VALUES (7002, N'Khách hàng 3', N'khachhang3', N'333333')
INSERT [dbo].[KhachHang] ([ma_KH], [ten_HK], [mail_KH], [sdt_KH]) VALUES (7003, N'Khách hàng 4', N'khachhang4', N'444444')
INSERT [dbo].[KhachHang] ([ma_KH], [ten_HK], [mail_KH], [sdt_KH]) VALUES (7004, N'Khách hàng 5', N'khachhang5', N'555555')
INSERT [dbo].[KhachHang] ([ma_KH], [ten_HK], [mail_KH], [sdt_KH]) VALUES (7005, N'Khách hàng 6', N'khachhang6', N'666666')
INSERT [dbo].[KhachHang] ([ma_KH], [ten_HK], [mail_KH], [sdt_KH]) VALUES (7006, N'Khách hàng 7', N'khachhang7', N'777777')
INSERT [dbo].[KhachHang] ([ma_KH], [ten_HK], [mail_KH], [sdt_KH]) VALUES (7007, N'Khách hàng 8', N'khachhang8', N'888888')
INSERT [dbo].[KhachHang] ([ma_KH], [ten_HK], [mail_KH], [sdt_KH]) VALUES (7008, N'Khách hàng 9', N'khachhang9', N'999999')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[Loai_SP] ON 

INSERT [dbo].[Loai_SP] ([ma_Loai], [ten_Loai]) VALUES (2000, N'Xe Ga')
INSERT [dbo].[Loai_SP] ([ma_Loai], [ten_Loai]) VALUES (2001, N'Xe Tay Côn')
INSERT [dbo].[Loai_SP] ([ma_Loai], [ten_Loai]) VALUES (2002, N'Xe Số')
INSERT [dbo].[Loai_SP] ([ma_Loai], [ten_Loai]) VALUES (2003, N'Xe Điện')
INSERT [dbo].[Loai_SP] ([ma_Loai], [ten_Loai]) VALUES (2004, N'Xe Phân Khối Lớn')
SET IDENTITY_INSERT [dbo].[Loai_SP] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([ma_NV], [ten_NV], [mail_NV], [sdt_NV], [mk_DangNhap]) VALUES (6000, N'Nguyễn Hoàng Dương', N'hoangduong150199@gmail.com', N'0123456789', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([ma_NV], [ten_NV], [mail_NV], [sdt_NV], [mk_DangNhap]) VALUES (6001, N'Lê Đức Tín', NULL, NULL, N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([ma_NV], [ten_NV], [mail_NV], [sdt_NV], [mk_DangNhap]) VALUES (6002, N'Nguyễn Công Thắng', N'congthang@gmail.com', N'1235235', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([ma_NV], [ten_NV], [mail_NV], [sdt_NV], [mk_DangNhap]) VALUES (6003, N'Dương Công Hậu', N'conghau@gmail.com', NULL, N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([ma_NV], [ten_NV], [mail_NV], [sdt_NV], [mk_DangNhap]) VALUES (6004, N'Trần Ngọc Tín', N'ngoctin10a11@gmail.com', N'3536264', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([ma_NV], [ten_NV], [mail_NV], [sdt_NV], [mk_DangNhap]) VALUES (6005, N'Không Biết Tên', N'khongten@gmail.com', NULL, N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([ma_NV], [ten_NV], [mail_NV], [sdt_NV], [mk_DangNhap]) VALUES (6006, N'David', N'david@gmail.com', N'0123456789', N'e10adc3949ba59abbe56e057f20f883e')
INSERT [dbo].[NhanVien] ([ma_NV], [ten_NV], [mail_NV], [sdt_NV], [mk_DangNhap]) VALUES (6007, N'Hoàng Yến', N'hoangyen@gmail.com', NULL, N'e10adc3949ba59abbe56e057f20f883e')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([ma_SP], [ma_DM], [ma_Loai], [ma_Hang], [mau_SP], [soluong_SP]) VALUES (14000, 4002, 2000, 3002, N'Đen', 7)
INSERT [dbo].[SanPham] ([ma_SP], [ma_DM], [ma_Loai], [ma_Hang], [mau_SP], [soluong_SP]) VALUES (14001, 4003, 2002, 3001, N'Trắng', 8)
INSERT [dbo].[SanPham] ([ma_SP], [ma_DM], [ma_Loai], [ma_Hang], [mau_SP], [soluong_SP]) VALUES (14002, 4005, 2003, 3000, N'Blue', 33)
INSERT [dbo].[SanPham] ([ma_SP], [ma_DM], [ma_Loai], [ma_Hang], [mau_SP], [soluong_SP]) VALUES (14003, 4006, 2004, 3004, N'Dark', 10)
INSERT [dbo].[SanPham] ([ma_SP], [ma_DM], [ma_Loai], [ma_Hang], [mau_SP], [soluong_SP]) VALUES (14004, 4011, 2001, 3003, N'Light', 4)
INSERT [dbo].[SanPham] ([ma_SP], [ma_DM], [ma_Loai], [ma_Hang], [mau_SP], [soluong_SP]) VALUES (14005, 4012, 2003, 3002, N'Đen', 10)
INSERT [dbo].[SanPham] ([ma_SP], [ma_DM], [ma_Loai], [ma_Hang], [mau_SP], [soluong_SP]) VALUES (14006, 4011, 2003, 3003, N'Be', 16)
INSERT [dbo].[SanPham] ([ma_SP], [ma_DM], [ma_Loai], [ma_Hang], [mau_SP], [soluong_SP]) VALUES (14007, 4010, 2002, 3002, N'Green', 9)
INSERT [dbo].[SanPham] ([ma_SP], [ma_DM], [ma_Loai], [ma_Hang], [mau_SP], [soluong_SP]) VALUES (14008, 4009, 2004, 3003, N'Pink', 2)
INSERT [dbo].[SanPham] ([ma_SP], [ma_DM], [ma_Loai], [ma_Hang], [mau_SP], [soluong_SP]) VALUES (14009, 4008, 2002, 3001, N'Violet', 19)
INSERT [dbo].[SanPham] ([ma_SP], [ma_DM], [ma_Loai], [ma_Hang], [mau_SP], [soluong_SP]) VALUES (14010, 4007, 2003, 3004, N'Violet', 18)
INSERT [dbo].[SanPham] ([ma_SP], [ma_DM], [ma_Loai], [ma_Hang], [mau_SP], [soluong_SP]) VALUES (14011, 4015, 2001, 3000, N'Red', 16)
INSERT [dbo].[SanPham] ([ma_SP], [ma_DM], [ma_Loai], [ma_Hang], [mau_SP], [soluong_SP]) VALUES (14012, 4018, 2000, 3002, N'Dark', 24)
INSERT [dbo].[SanPham] ([ma_SP], [ma_DM], [ma_Loai], [ma_Hang], [mau_SP], [soluong_SP]) VALUES (14013, 4021, 2004, 3000, N'Trắng', 19)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
ALTER TABLE [dbo].[CT_PhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_ctpn_pn] FOREIGN KEY([ma_PN])
REFERENCES [dbo].[PhieuNhap] ([ma_PN])
GO
ALTER TABLE [dbo].[CT_PhieuNhap] CHECK CONSTRAINT [fk_ctpn_pn]
GO
ALTER TABLE [dbo].[CT_PhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_ctpn_sp] FOREIGN KEY([ma_SP])
REFERENCES [dbo].[SanPham] ([ma_SP])
GO
ALTER TABLE [dbo].[CT_PhieuNhap] CHECK CONSTRAINT [fk_ctpn_sp]
GO
ALTER TABLE [dbo].[CT_Quyen]  WITH CHECK ADD  CONSTRAINT [fk_ctq_cn] FOREIGN KEY([ma_CN])
REFERENCES [dbo].[ChucNang] ([ma_CN])
GO
ALTER TABLE [dbo].[CT_Quyen] CHECK CONSTRAINT [fk_ctq_cn]
GO
ALTER TABLE [dbo].[CT_Quyen]  WITH CHECK ADD  CONSTRAINT [fk_ctq_nv] FOREIGN KEY([ma_NV])
REFERENCES [dbo].[NhanVien] ([ma_NV])
GO
ALTER TABLE [dbo].[CT_Quyen] CHECK CONSTRAINT [fk_ctq_nv]
GO
ALTER TABLE [dbo].[CTHD_BanHang]  WITH CHECK ADD  CONSTRAINT [fk_cthd_sp] FOREIGN KEY([ma_SP])
REFERENCES [dbo].[SanPham] ([ma_SP])
GO
ALTER TABLE [dbo].[CTHD_BanHang] CHECK CONSTRAINT [fk_cthd_sp]
GO
ALTER TABLE [dbo].[CTHD_BanHang]  WITH CHECK ADD  CONSTRAINT [fk_cthdbh_hdbh] FOREIGN KEY([ma_HD])
REFERENCES [dbo].[HD_BanHang] ([ma_hd])
GO
ALTER TABLE [dbo].[CTHD_BanHang] CHECK CONSTRAINT [fk_cthdbh_hdbh]
GO
ALTER TABLE [dbo].[CTHD_DichVu]  WITH CHECK ADD  CONSTRAINT [fk_cthddv_dv] FOREIGN KEY([ma_DV])
REFERENCES [dbo].[DichVu] ([ma_DV])
GO
ALTER TABLE [dbo].[CTHD_DichVu] CHECK CONSTRAINT [fk_cthddv_dv]
GO
ALTER TABLE [dbo].[CTHD_DichVu]  WITH CHECK ADD  CONSTRAINT [fk_cthddv_hddv] FOREIGN KEY([ma_HDDV])
REFERENCES [dbo].[HD_DichVu] ([ma_HDDV])
GO
ALTER TABLE [dbo].[CTHD_DichVu] CHECK CONSTRAINT [fk_cthddv_hddv]
GO
ALTER TABLE [dbo].[Gia_DV]  WITH CHECK ADD  CONSTRAINT [fk_gdv_dv] FOREIGN KEY([ma_DV])
REFERENCES [dbo].[DichVu] ([ma_DV])
GO
ALTER TABLE [dbo].[Gia_DV] CHECK CONSTRAINT [fk_gdv_dv]
GO
ALTER TABLE [dbo].[Gia_SP]  WITH CHECK ADD  CONSTRAINT [fk_gsp_sp] FOREIGN KEY([ma_SP])
REFERENCES [dbo].[SanPham] ([ma_SP])
GO
ALTER TABLE [dbo].[Gia_SP] CHECK CONSTRAINT [fk_gsp_sp]
GO
ALTER TABLE [dbo].[HD_BanHang]  WITH CHECK ADD  CONSTRAINT [fk_hdbh_kh] FOREIGN KEY([ma_kh])
REFERENCES [dbo].[KhachHang] ([ma_KH])
GO
ALTER TABLE [dbo].[HD_BanHang] CHECK CONSTRAINT [fk_hdbh_kh]
GO
ALTER TABLE [dbo].[HD_BanHang]  WITH CHECK ADD  CONSTRAINT [fk_hdbh_nv] FOREIGN KEY([ma_nv])
REFERENCES [dbo].[NhanVien] ([ma_NV])
GO
ALTER TABLE [dbo].[HD_BanHang] CHECK CONSTRAINT [fk_hdbh_nv]
GO
ALTER TABLE [dbo].[HD_DichVu]  WITH CHECK ADD  CONSTRAINT [fk_hddv_kh] FOREIGN KEY([ma_KH])
REFERENCES [dbo].[KhachHang] ([ma_KH])
GO
ALTER TABLE [dbo].[HD_DichVu] CHECK CONSTRAINT [fk_hddv_kh]
GO
ALTER TABLE [dbo].[HD_DichVu]  WITH CHECK ADD  CONSTRAINT [fk_hddv_nv] FOREIGN KEY([ma_NV])
REFERENCES [dbo].[NhanVien] ([ma_NV])
GO
ALTER TABLE [dbo].[HD_DichVu] CHECK CONSTRAINT [fk_hddv_nv]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_pn_ncc] FOREIGN KEY([ma_NCC])
REFERENCES [dbo].[Nha_CungCap] ([ma_NCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [fk_pn_ncc]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_pn_nv] FOREIGN KEY([ma_NV])
REFERENCES [dbo].[NhanVien] ([ma_NV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [fk_pn_nv]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [fk_sp_dm] FOREIGN KEY([ma_DM])
REFERENCES [dbo].[DanhMuc] ([ma_DM])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [fk_sp_dm]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [fk_sp_hang] FOREIGN KEY([ma_Hang])
REFERENCES [dbo].[Hang_SX] ([ma_Hang])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [fk_sp_hang]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [fk_sp_loai] FOREIGN KEY([ma_Loai])
REFERENCES [dbo].[Loai_SP] ([ma_Loai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [fk_sp_loai]
GO
/****** Object:  StoredProcedure [dbo].[ChiTiet_HD]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChiTiet_HD]
as
begin
	select hd.ma_HD, nv.ten_NV, kh.ten_HK, dm.ten_DM, sp.mau_SP,ct.gia_SP ,ct.soluong_SP, ct.tongtien_SP 
	from HD_BanHang hd, CTHD_BanHang ct, NhanVien nv, KhachHang kh, SanPham sp, DanhMuc dm
	where hd.ma_HD = ct.ma_HD and hd.ma_NV = nv.ma_NV and hd.ma_KH = kh.ma_KH and ct.ma_SP = sp.ma_SP and sp.ma_DM = dm.ma_DM
end
GO
/****** Object:  StoredProcedure [dbo].[CThd]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CThd]
as
begin
	select hd.ma_HD, nv.ten_NV, kh.ten_HK, dm.ten_DM, sp.mau_SP,ct.gia_SP ,ct.soluong_SP, ct.tongtien_SP 
	from HD_BanHang hd, CTHD_BanHang ct, NhanVien nv, KhachHang kh, SanPham sp, DanhMuc dm
	where hd.ma_HD = ct.ma_HD and hd.ma_NV = nv.ma_NV and hd.ma_KH = kh.ma_KH and ct.ma_SP = sp.ma_SP and sp.ma_DM = dm.ma_DM
end
GO
/****** Object:  StoredProcedure [dbo].[delete_cthd]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[delete_cthd]
  (@ma int, @MASP int)
as begin
delete from CTHD_BanHang where ma_HD=@ma and ma_SP=@MASP
end
GO
/****** Object:  StoredProcedure [dbo].[delete_hd]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

  create proc [dbo].[delete_hd]
  (@ma int)
as begin
delete from HD_BanHang where ma_HD=@ma 
end
GO
/****** Object:  StoredProcedure [dbo].[Get_TKNhanVien]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Get_TKNhanVien]
 @value int

as
begin
	select * from NhanVien where ma_nv = @value
end
GO
/****** Object:  StoredProcedure [dbo].[giasp]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[giasp]
as
begin
	select * from SanPham sp , Gia_SP, DanhMuc dm where sp.ma_DM = dm.ma_DM and sp.ma_SP = gia_SP.ma_SP
end
GO
/****** Object:  StoredProcedure [dbo].[hd]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[hd]
as
select hd.ma_HD, nv.ten_NV, kh.ten_HK,hd.ngaylap_HD, hd.thanhtien from HD_BanHang hd, NhanVien nv, KhachHang kh where hd.ma_NV = nv.ma_NV and hd.ma_KH = kh.ma_KH
GO
/****** Object:  StoredProcedure [dbo].[hd_dv]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[hd_dv]
as
select hd.ma_HDDV, dv.ten_DV, kh.ten_HK, nv.ten_NV, ct.tongtien_DV 
from HD_DichVu hd, DichVu dv, CTHD_DichVu ct, NhanVien nv, KhachHang kh
where hd.ma_HDDV = ct.ma_HDDV and hd.ma_KH = kh.ma_KH and hd.ma_NV = nv.ma_NV and ct.ma_DV = dv.ma_DV
GO
/****** Object:  StoredProcedure [dbo].[Inhd]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Inhd]
  (@mahd int)
  as
  select *
  from HD_BanHang hd, CTHD_BanHang ct, DanhMuc dm, SanPham sp, NhanVien nv, KhachHang kh
  where hd.ma_NV = nv.ma_NV and hd.ma_KH = kh.ma_KH and ct.ma_SP = sp.ma_SP and sp.ma_DM = dm.ma_DM and ct.ma_HD = hd.ma_HD and hd.ma_HD = @mahd
GO
/****** Object:  StoredProcedure [dbo].[INSERT_CTHD]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create PROC [dbo].[INSERT_CTHD](
@MAHD           int,
@MASP           int,
@giasp			int,
@SL             INT,
@THANHTIEN      int
)
AS
INSERT INTO CTHD_BanHang VALUES (@MAHD, @MASP,@giasp, @SL, @THANHTIEN)
UPDATE SANPHAM SET soluong_SP = soluong_SP - @SL WHERE ma_SP=@MASP
GO
/****** Object:  StoredProcedure [dbo].[Insert_HoaDon]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[Insert_HoaDon]
  (@mahd int, 
  @makh int,
  @manv int, 
  @ngaylap date,
  @thanhtien int)
  as
  begin
  INSERT INTO HD_BanHang VALUES ( @mahd, @makh, @manv, @ngaylap, @thanhtien)
  end
GO
/****** Object:  StoredProcedure [dbo].[nhavien]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[nhavien]
as begin select * from NhanVien end
GO
/****** Object:  StoredProcedure [dbo].[Procedure]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Procedure]
	@masp int
AS
	SELECT * from SanPham where ma_DM = @masp
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[quenmk]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[quenmk]
(@ma int, @PASS NVARCHAR(50))
AS
BEGIN
	UPDATE NHANVIEN SET mk_DangNhap = @PASS WHERE ma_NV=@ma
END
GO
/****** Object:  StoredProcedure [dbo].[search_hdBan]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[search_hdBan]
(@search nvarchar(100))
as
select hd.ma_HD, nv.ten_NV, kh.ten_HK,hd.ngaylap_HD, hd.thanhtien 
from HD_BanHang hd, NhanVien nv, KhachHang kh 
where hd.ma_NV = nv.ma_NV and hd.ma_KH = kh.ma_KH and 
CONCAT( hd.ma_HD, nv.ten_NV, kh.ten_HK,hd.ngaylap_HD, hd.thanhtien) like '%'+@search+'%'
GO
/****** Object:  StoredProcedure [dbo].[searh_hddv]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[searh_hddv]
(@TKKH nvarchar(100))
as
select hd.ma_HDDV, dv.ten_DV, kh.ten_HK, nv.ten_NV, ct.tongtien_DV 
from HD_DichVu hd, DichVu dv, CTHD_DichVu ct, NhanVien nv, KhachHang kh
where hd.ma_HDDV = ct.ma_HDDV and hd.ma_KH = kh.ma_KH and hd.ma_NV = nv.ma_NV and ct.ma_DV = dv.ma_DV and
CONCAT(hd.ma_HDDV, dv.ten_DV, kh.ten_HK, nv.ten_NV, ct.tongtien_DV ) like '%'+@TKKH+'%'
GO
/****** Object:  StoredProcedure [dbo].[selectAll_CTHD]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[selectAll_CTHD] 
  (@maHD int , @masp int)
as
select * from CTHD_BanHang where ma_HD = @maHD and ma_SP = @masp
GO
/****** Object:  StoredProcedure [dbo].[selectCTHD]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectCTHD] (@ma int )
as
select CTHD_BanHang.MA_SP, dm.ten_DM, CTHD_BanHang.soluong_SP, Gia_SP.gia_SP, CTHD_BanHang.tongtien_SP   
from Gia_SP, CTHD_BanHang , SANPHAM SP, DanhMuc dm 
where ma_HD = @ma and CTHD_BanHang.ma_SP = SP.ma_SP and 
sp.ma_DM = dm.ma_DM and CTHD_BanHang.gia_SP = Gia_SP.gia_SP and Gia_SP.ma_SP = sp.ma_SP
GO
/****** Object:  StoredProcedure [dbo].[selectHoaDon]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[selectHoaDon] 
  (@ma nvarchar (50))
as
select * from HD_BanHang where ma_HD = @ma
GO
/****** Object:  StoredProcedure [dbo].[selectsp]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[selectsp]
(@masp int)
as select * from DanhMuc where ma_DM = @masp
GO
/****** Object:  StoredProcedure [dbo].[selectSP11]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectSP11]
(@masp int)
as
select * from SanPham where ma_SP = @masp
GO
/****** Object:  StoredProcedure [dbo].[soluongsp]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[soluongsp]
(
	@masp int
)
as
select * from SanPham sp, DanhMuc dm where sp.ma_DM = dm.ma_DM and sp.ma_DM = @masp
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_ThanhTien]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATE_ThanhTien](
@MAHD int,
@THANHTIEN int
)
as	
UPDATE HD_BanHang SET thanhtien = @THANHTIEN WHERE ma_HD= @MAHD
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_TONGTIEN]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[UPDATE_TONGTIEN]
(@MAHD int, @TONGTIEN int)
AS
UPDATE HD_BanHang SET THANHTIEN=@TONGTIEN WHERE ma_HD=@MAHD 
GO
/****** Object:  StoredProcedure [dbo].[updateSL_CTHD]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[updateSL_CTHD] 
(@ma int, @masp int ,@gia int, @soluong int, @THANHTIEN int)
as
update CTHD_BanHang set soluong_SP = @soluong, tongtien_SP = @THANHTIEN,gia_SP =@gia where ma_HD = @ma and ma_SP = @masp
GO
/****** Object:  StoredProcedure [dbo].[updateSLT]    Script Date: 1/1/2021 10:06:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[updateSLT] 
  (@masp int , @soluong int)
as 
update SanPham set soluong_SP = @soluong where ma_SP =@masp
GO
USE [master]
GO
ALTER DATABASE [CuaHang_XeMay] SET  READ_WRITE 
GO
