USE [master]
GO
/****** Object:  Database [ReadingLightNovel]    Script Date: 26/11/2023 7:57:28 SA ******/
CREATE DATABASE [ReadingLightNovel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ReadingLightNovel', FILENAME = N'D:\App download\AppContain\SQL\MSSQL16.USERNAME\MSSQL\DATA\ReadingLightNovel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ReadingLightNovel_log', FILENAME = N'D:\App download\AppContain\SQL\MSSQL16.USERNAME\MSSQL\DATA\ReadingLightNovel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ReadingLightNovel] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ReadingLightNovel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ReadingLightNovel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET ARITHABORT OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ReadingLightNovel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ReadingLightNovel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ReadingLightNovel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ReadingLightNovel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET RECOVERY FULL 
GO
ALTER DATABASE [ReadingLightNovel] SET  MULTI_USER 
GO
ALTER DATABASE [ReadingLightNovel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ReadingLightNovel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ReadingLightNovel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ReadingLightNovel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ReadingLightNovel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ReadingLightNovel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ReadingLightNovel', N'ON'
GO
ALTER DATABASE [ReadingLightNovel] SET QUERY_STORE = ON
GO
ALTER DATABASE [ReadingLightNovel] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ReadingLightNovel]
GO
/****** Object:  Table [dbo].[BinhChon]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BinhChon](
	[MaBinhChon] [nvarchar](255) NOT NULL,
	[TenDangNhap] [nvarchar](255) NOT NULL,
	[MaTacPham] [nvarchar](255) NOT NULL,
	[Diem] [float] NOT NULL,
	[NoiDung] [ntext] NULL,
 CONSTRAINT [PK_BinhChon] PRIMARY KEY CLUSTERED 
(
	[MaBinhChon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BinhLuan]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BinhLuan](
	[MaBinhLuan] [nvarchar](255) NOT NULL,
	[MaChapter] [nvarchar](255) NOT NULL,
	[NoiDung] [ntext] NULL,
	[Anh] [nvarchar](255) NULL,
	[ThoiGian] [datetime] NOT NULL,
	[TenDangNhap] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_BinhLuan] PRIMARY KEY CLUSTERED 
(
	[MaBinhLuan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BinhLuanTacPham]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BinhLuanTacPham](
	[MaBinhLuan] [nvarchar](255) NOT NULL,
	[TenDangNhap] [nvarchar](255) NOT NULL,
	[MaTacPham] [nvarchar](255) NOT NULL,
	[NoiDung] [ntext] NULL,
	[Anh] [nvarchar](255) NULL,
	[ThoiGian] [datetime] NOT NULL,
 CONSTRAINT [PK_BinhLuanTacPham] PRIMARY KEY CLUSTERED 
(
	[MaBinhLuan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chapter]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chapter](
	[MaChapter] [nvarchar](255) NOT NULL,
	[TenChapter] [nvarchar](255) NOT NULL,
	[ThoiGianDang] [datetime] NOT NULL,
	[Nguon] [nvarchar](255) NOT NULL,
	[MaVolume] [nvarchar](255) NULL,
	[Stt] [int] NULL,
 CONSTRAINT [PK_Chapter] PRIMARY KEY CLUSTERED 
(
	[MaChapter] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaSi]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaSi](
	[MaHoaSi] [nvarchar](255) NOT NULL,
	[MaTacPham] [nvarchar](255) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietNhomDich]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietNhomDich](
	[TenDangNhap] [nvarchar](255) NOT NULL,
	[MaNhom] [nvarchar](255) NULL,
	[isAdmin] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietTheLoai]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietTheLoai](
	[MaTacPham] [nvarchar](255) NOT NULL,
	[MaTheLoai] [nvarchar](255) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HeThong]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeThong](
	[TenDangNhap] [nvarchar](255) NULL,
	[GhiNho] [bit] NULL,
	[DarkMode] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaSi]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaSi](
	[MaHoaSi] [nvarchar](255) NOT NULL,
	[TenHoaSi] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_HoaSi] PRIMARY KEY CLUSTERED 
(
	[MaHoaSi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichSu]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSu](
	[MaLichSu] [nvarchar](255) NOT NULL,
	[TenDangNhap] [nvarchar](255) NOT NULL,
	[MaChapter] [nvarchar](255) NOT NULL,
	[ThoiGian] [datetime] NOT NULL,
 CONSTRAINT [PK_LichSu] PRIMARY KEY CLUSTERED 
(
	[MaLichSu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomDich]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomDich](
	[MaNhom] [nvarchar](255) NOT NULL,
	[TenNhom] [nvarchar](255) NOT NULL,
	[GioiThieu] [ntext] NULL,
 CONSTRAINT [PK_NhomDich] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTacGia] [nvarchar](255) NOT NULL,
	[TenTacGia] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacPham]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacPham](
	[MaTacPham] [nvarchar](255) NOT NULL,
	[TenTacPham] [nvarchar](255) NOT NULL,
	[TenKhac] [nvarchar](255) NOT NULL,
	[TomTat] [ntext] NOT NULL,
	[Anh] [nvarchar](255) NULL,
	[MaTacGia] [nvarchar](255) NOT NULL,
	[TenDangNhap] [nvarchar](255) NOT NULL,
	[ThoiGianTao] [datetime] NULL,
	[TinhTrang] [nvarchar](255) NULL,
	[LoaiTruyen] [nvarchar](255) NULL,
	[MaNhom] [nvarchar](255) NULL,
	[MaHoaSi] [nvarchar](255) NULL,
	[Email] [nvarchar](255) NULL,
	[LuotXem] [int] NULL,
 CONSTRAINT [PK_TacPham] PRIMARY KEY CLUSTERED 
(
	[MaTacPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTheLoai] [nvarchar](255) NOT NULL,
	[TenTheLoai] [nvarchar](255) NULL,
	[GhiChu] [nvarchar](255) NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongBao]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongBao](
	[MaThongBao] [nvarchar](255) NOT NULL,
	[TenDangNhap] [nvarchar](255) NOT NULL,
	[NoiDung] [ntext] NOT NULL,
	[ThoiGianThongBaoi] [datetime] NOT NULL,
 CONSTRAINT [PK_ThongBao] PRIMARY KEY CLUSTERED 
(
	[MaThongBao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[TenDangNhap] [nvarchar](255) NOT NULL,
	[MatKhau] [nvarchar](255) NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[AnhDaiDien] [nvarchar](255) NULL,
	[AnhNen] [nvarchar](255) NULL,
	[NgayTao] [datetime] NULL,
	[ThoiGianLanCuoi] [datetime] NULL,
	[Email] [nvarchar](255) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Volume]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Volume](
	[MaVolume] [nvarchar](255) NOT NULL,
	[TenVolume] [nvarchar](255) NOT NULL,
	[Anh] [nvarchar](255) NULL,
	[MaTacPham] [nvarchar](255) NOT NULL,
	[Stt] [int] NULL,
 CONSTRAINT [PK_Volume] PRIMARY KEY CLUSTERED 
(
	[MaVolume] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YeuThich]    Script Date: 26/11/2023 7:57:28 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YeuThich](
	[MaYeuThich] [nvarchar](255) NOT NULL,
	[TenDangNhap] [nvarchar](255) NOT NULL,
	[MaTacPham] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_YeuThich] PRIMARY KEY CLUSTERED 
(
	[MaYeuThich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BinhChon] ([MaBinhChon], [TenDangNhap], [MaTacPham], [Diem], [NoiDung]) VALUES (N'BC001', N'CuongNguyen', N'TP001', 5, N'Art d?p cu?n')
INSERT [dbo].[BinhChon] ([MaBinhChon], [TenDangNhap], [MaTacPham], [Diem], [NoiDung]) VALUES (N'BC002', N'Zennomi', N'TP001', 4, N'T?m')
GO
INSERT [dbo].[BinhLuan] ([MaBinhLuan], [MaChapter], [NoiDung], [Anh], [ThoiGian], [TenDangNhap]) VALUES (N'BL001', N'TP001V1CH1', N'hóng', N'DateABullet.jpg', CAST(N'2022-03-04T00:00:00.000' AS DateTime), N'CuongNguyen')
INSERT [dbo].[BinhLuan] ([MaBinhLuan], [MaChapter], [NoiDung], [Anh], [ThoiGian], [TenDangNhap]) VALUES (N'BL002', N'TP001V1CH1', N'tks', N'DateABullet.jpg', CAST(N'2022-03-05T00:00:00.000' AS DateTime), N'CuongNguyen')
INSERT [dbo].[BinhLuan] ([MaBinhLuan], [MaChapter], [NoiDung], [Anh], [ThoiGian], [TenDangNhap]) VALUES (N'BL003', N'TP001V1CH1', N'Thông báo s?i', N'DateABullet.jpg', CAST(N'2022-03-05T00:00:00.000' AS DateTime), N'HiuTao')
GO
INSERT [dbo].[BinhLuanTacPham] ([MaBinhLuan], [TenDangNhap], [MaTacPham], [NoiDung], [Anh], [ThoiGian]) VALUES (N'BLTP001', N'HiuTao', N'TP001', N'Ad drop rồi à', NULL, CAST(N'2023-11-16T00:00:00.000' AS DateTime))
INSERT [dbo].[BinhLuanTacPham] ([MaBinhLuan], [TenDangNhap], [MaTacPham], [NoiDung], [Anh], [ThoiGian]) VALUES (N'BLTT002', N'Zennomi', N'TP001', N'Thông báo drop', NULL, CAST(N'2023-10-12T00:00:00.000' AS DateTime))
INSERT [dbo].[BinhLuanTacPham] ([MaBinhLuan], [TenDangNhap], [MaTacPham], [NoiDung], [Anh], [ThoiGian]) VALUES (N'BLTT003', N'HiuTao', N'TP002', N'tks', NULL, CAST(N'2023-09-09T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP001V1CH1', N'Chương 1', CAST(N'2022-03-03T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP001V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP001V1CH2', N'Chương 2', CAST(N'2022-03-04T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP001V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP001V1CH3', N'Chương 3', CAST(N'2022-03-05T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP001V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP002V1CH1', N'Chương 1', CAST(N'2022-04-10T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP002V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP002V1CH2', N'Chương 2', CAST(N'2022-04-12T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP002V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP002V1CH3', N'Chương 3', CAST(N'2022-04-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP002V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP003V1CH1', N'Chương 1', CAST(N'2023-09-15T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP003V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP003V1CH2', N'Chương 2', CAST(N'2023-10-12T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP003V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP003V1CH3', N'Chương 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP003V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP004V1CH1', N'Chương 1', CAST(N'2023-09-15T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP004V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP004V1CH2', N'Chương 2', CAST(N'2023-10-12T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP004V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP004V1CH3', N'Chương 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP004V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP005V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP005V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP005V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP005V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP005V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP005V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP005V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP005V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP005V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP005V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP005V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP005V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP005V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP005V3', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP005V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP005V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP005V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP005V3', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP006V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP006V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP006V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP006V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP006V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP006V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP006V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP006V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP006V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP006V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP006V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP006V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP006V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP006V3', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP006V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP006V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP006V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP006V3', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP007V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP007V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP007V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP007V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP007V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP007V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP007V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP007V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP007V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP007V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP007V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP007V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP007V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP007V3', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP007V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP007V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP007V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP007V3', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP008V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP008V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP008V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP008V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP008V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP008V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP008V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP008V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP008V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP008V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP008V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP008V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP008V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP008V3', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP008V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP008V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP008V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP008V3', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP009V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP009V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP009V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP009V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP009V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP009V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP009V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP009V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP009V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP009V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP009V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP009V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP009V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP009V3', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP009V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP009V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP009V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP009V3', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP010V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP010V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP010V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP010V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP010V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP010V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP010V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP010V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP010V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP010V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP010V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP010V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP010V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP010V3', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP010V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP010V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP010V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP010V3', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP011V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP011V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP011V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP011V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP011V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP011V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP011V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP011V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP011V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP011V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP011V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP011V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP011V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP011V3', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP011V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP011V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP011V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP011V3', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP012V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP012V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP012V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP012V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP012V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP012V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP012V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP012V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP012V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP012V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP012V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP012V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP012V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP012V3', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP012V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP012V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP012V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP012V3', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP013V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP013V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP013V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP013V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP013V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP013V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP013V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP013V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP013V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP013V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP013V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP013V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP013V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP013V3', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP013V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP013V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP013V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP013V3', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP014V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP014V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP014V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP014V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP014V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP014V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP014V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP014V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP014V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP014V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP014V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP014V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP014V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP014V3', 1)
GO
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP014V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP014V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP014V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP014V3', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP015V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP015V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP015V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP015V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP015V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP015V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP015V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP015V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP015V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP015V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP015V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP015V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP015V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP015V3', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP015V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP015V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP015V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP015V3', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP016V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP016V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP016V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP016V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP016V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP016V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP016V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP016V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP016V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP016V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP016V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP016V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP016V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP016V3', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP016V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP016V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP016V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP016V3', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP017V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP017V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP017V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP017V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP017V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP017V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP017V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP017V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP017V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP017V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP017V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP017V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP017V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP017V3', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP017V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP017V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP017V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP017V3', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP018V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP018V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP018V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP018V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP018V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP018V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP018V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP018V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP018V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP018V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP018V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP018V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP018V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP018V3', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP018V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP018V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP018V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP018V3', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP019V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP019V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP019V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP019V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP019V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP019V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP019V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP019V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP019V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP019V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP019V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP019V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP019V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP019V3', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP019V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP019V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP019V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP019V3', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP020V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP020V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP020V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP020V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP020V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP020V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP020V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP020V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP020V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP020V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP020V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP020V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP020V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP020V3', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP020V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP020V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP020V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP020V3', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP021V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP021V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP021V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP021V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP021V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP021V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP021V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP021V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP021V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP021V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP021V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP021V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP021V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP021V3', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP021V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP021V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP021V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP021V3', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP022V1CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP022V1', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP022V1CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP022V1', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP022V1CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP022V1', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP022V2CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP022V2', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP022V2CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP022V2', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP022V2CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP022V2', 3)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP022V3CH1', N'Chuong 1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap1.txt', N'TP022V3', 1)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP022V3CH2', N'Chuong 2', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap2.txt', N'TP022V3', 2)
INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'TP022V3CH3', N'Chuong 3', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'Chap3.txt', N'TP022V3', 3)
GO
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS001', N'TP001')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS001', N'TP002')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS002', N'TP003')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS004', N'TP004')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS008', N'TP005')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS006', N'TP006')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS007', N'TP007')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS008', N'TP008')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS009', N'TP009')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS010', N'TP010')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS008', N'TP011')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS008', N'TP012')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS008', N'TP013')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS008', N'TP014')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS008', N'TP015')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS008', N'TP016')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS008', N'TP017')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS008', N'TP018')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS009', N'TP018')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS009', N'TP019')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS009', N'TP020')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS009', N'TP021')
INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'HS009', N'TP022')
GO
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP001', N'TL01')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP001', N'TL21')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP001', N'TL22')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP002', N'TL01')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP002', N'TL05')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP002', N'TL07')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP003', N'TL13')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP003', N'TL03')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP003', N'TL22')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP003', N'TL01')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP003', N'TL08')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP004', N'TL01')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP004', N'TL08')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP004', N'TL22')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP005', N'TL10')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP006', N'TL11')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP007', N'TL12')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP022', N'TL02')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP008', N'TL12')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP009', N'TL01')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP010', N'TL01')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP011', N'TL01')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP012', N'TL01')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP013', N'TL01')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP014', N'TL01')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP015', N'TL01')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP016', N'TL01')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP017', N'TL01')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP018', N'TL01')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP019', N'TL01')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP020', N'TL02')
INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (N'TP021', N'TL02')
GO
INSERT [dbo].[HoaSi] ([MaHoaSi], [TenHoaSi]) VALUES (N'HS001', N'NOCO')
INSERT [dbo].[HoaSi] ([MaHoaSi], [TenHoaSi]) VALUES (N'HS002', N'Seele')
INSERT [dbo].[HoaSi] ([MaHoaSi], [TenHoaSi]) VALUES (N'HS003', N'KaoKa')
INSERT [dbo].[HoaSi] ([MaHoaSi], [TenHoaSi]) VALUES (N'HS004', N'Yamao')
INSERT [dbo].[HoaSi] ([MaHoaSi], [TenHoaSi]) VALUES (N'HS005', N'MaoMao')
INSERT [dbo].[HoaSi] ([MaHoaSi], [TenHoaSi]) VALUES (N'HS006', N'Yamato Ichidase')
INSERT [dbo].[HoaSi] ([MaHoaSi], [TenHoaSi]) VALUES (N'HS007', N'Ichinose')
INSERT [dbo].[HoaSi] ([MaHoaSi], [TenHoaSi]) VALUES (N'HS008', N'Mắm kaslana')
INSERT [dbo].[HoaSi] ([MaHoaSi], [TenHoaSi]) VALUES (N'HS009', N'Sql lover')
INSERT [dbo].[HoaSi] ([MaHoaSi], [TenHoaSi]) VALUES (N'HS010', N'Oracle Hater')
GO
INSERT [dbo].[LichSu] ([MaLichSu], [TenDangNhap], [MaChapter], [ThoiGian]) VALUES (N'LS001', N'CuongNguyen', N'TP001V1CH1', CAST(N'2022-03-03T00:00:00.000' AS DateTime))
INSERT [dbo].[LichSu] ([MaLichSu], [TenDangNhap], [MaChapter], [ThoiGian]) VALUES (N'LS002', N'Zennomi', N'TP001V1CH2', CAST(N'2022-03-05T00:00:00.000' AS DateTime))
INSERT [dbo].[LichSu] ([MaLichSu], [TenDangNhap], [MaChapter], [ThoiGian]) VALUES (N'LS003', N'HiuTao', N'TP001V1CH1', CAST(N'2022-03-03T00:00:00.000' AS DateTime))
INSERT [dbo].[LichSu] ([MaLichSu], [TenDangNhap], [MaChapter], [ThoiGian]) VALUES (N'LS004', N'HiuTao', N'TP002V1CH3', CAST(N'2022-04-13T00:00:00.000' AS DateTime))
INSERT [dbo].[LichSu] ([MaLichSu], [TenDangNhap], [MaChapter], [ThoiGian]) VALUES (N'LS005', N'HiuTao', N'TP002V1CH2', CAST(N'2022-04-13T00:00:00.000' AS DateTime))
INSERT [dbo].[LichSu] ([MaLichSu], [TenDangNhap], [MaChapter], [ThoiGian]) VALUES (N'LS006', N'HiuTao', N'TP004V1CH1', CAST(N'2022-10-13T00:00:00.000' AS DateTime))
INSERT [dbo].[LichSu] ([MaLichSu], [TenDangNhap], [MaChapter], [ThoiGian]) VALUES (N'LS007', N'HiuTao', N'TP003V1CH1', CAST(N'2023-10-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[NhomDich] ([MaNhom], [TenNhom], [GioiThieu]) VALUES (N'ND001', N'Drop có thâm niên', N'Nhóm dịch tùy hứng')
INSERT [dbo].[NhomDich] ([MaNhom], [TenNhom], [GioiThieu]) VALUES (N'ND002', N'RomComer', N'Chỉ dịch romcom mà thôi')
GO
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG01', N'SatoShi')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG02', N'KaKao')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG03', N'Inue Yoshida')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG04', N'Sangonomiya Kokomi')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG05', N'Luna Wow')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG06', N'Cecelia Shariac')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG07', N'Otto')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG08', N'Loucha')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG09', N'Shigure Kira')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG10', N'Anna Shariac')
GO
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP001', N'Date A Live Fragments: Date A Bullet', N'Cuộc hẹn sống còn', N'Series spin-off của Date A Live, với nội dung chủ yếu xoay quanh Tokisaki Kurumi. Tại đây, cô gặp gỡ Empty, một Chuẩn Tinh Linh mới xuất hiện tại Lân Giới. Cô cùng Empty hợp tác với nhau, tham gia vào cuộc chiến sinh tồn với các Tinh Linh, nhằm giành lấy một điều ước duy nhất cho Tinh Linh thắng cuộc.', N'DateABullet.jpg', N'TG09', N'HiuTao', CAST(N'2022-02-02T00:00:00.000' AS DateTime), N'Đang tiến hành', N'Truyện dịch', NULL, N'HS01', NULL, 5623)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP002', N'Moshimo Ashita, Kono Sekai ga Owaru to Shitara', N'もしも明日、この世界が終わるとしたら', N'Đây có phải là hồi kết của thế giới không? Không còn hy vọng. Tuy nhiên, ngay cả khi biết điều đó, con người ta vẫn rơi vào lưới tình... Chỉ còn khoảng một năm để sống trong thế giới mà anh hùng đã từng cứu. Dù vậy, chỉ có thể cứu thế giới này bằng cái chết...

"Osaki Sora-san, làm ơn, tôi cầu xin anh. Anh có thể cứu thế giới này được không?"

"Anh chính là sự tái sinh của vị anh hùng đã từng cứu thế giới này."

Trước khi ngày tận thế đến, anh do dự. Khi mà anh nghĩ về những ngày anh đã trải qua với cô gái ấy sau khi được triệu hồi đến thế giới này. Cô ấy có lúc ngốc nghếch và thỉnh thoảng nổi cáu một cách vô lý, nhưng những nụ cười thoáng qua của cô khiến anh hạnh phúc.

"Thế giới này và cô gái duy nhất mà tôi trân trọng. Nếu chỉ có thể cứu một..."', N'Shitara.jpg', N'TG10', N'HiuTao', CAST(N'2021-04-09T00:00:00.000' AS DateTime), N'Tạm ngưng', N'Truyện dịch', NULL, N'HS01', NULL, 213)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP003', N'Silent Witch', N'Phù Thủy Tĩnh Lặng', N'Pháp sư thiên tài Monica Everett là một cô gái cực kỳ nhút nhát và ngại giao tiếp trước đám đông.

Sau bao nhiêu nỗ lực, Monica cuối cùng cũng đã học được và thông thạo thuật vô niệm, khả năng sử dụng phép thuật mà không cần niệm chú. Ở tuổi 15, cô đã được chọn làm một trong Bảy Hiền Nhân, bảy pháp sư mạnh mẽ nhất vương quốc, với danh hiệu Phù Thủy Tĩnh Lặng. Và rồi, Monica bắt đầu một cuộc sống ẩn dật yên bình trong rừng.

Tuy vậy, hai năm sau, vào một ngày nọ, Monica nhận được một yêu cầu.
Đó chính là bí mật bảo vệ Nhị Hoàng Tử đang theo học trong Học Viện.

Để hoàn thành yêu cầu đó, Monica buộc phải thâm nhập vào một học viện xa hoa chỉ dành cho con em quý tộc theo học.
"Không muốn đâu....Sợ lắm.....Ưư...cái dạ dày của tôi..."
Tiếng khóc thút thít của cô gái rồi cũng bị những cơn gió cuốn bay đi thật xa.', N'SlientWitch.jpg', N'TG07', N'HiuTao', CAST(N'2023-09-12T00:00:00.000' AS DateTime), N'Đang tiến hành', N'Truyện sáng tác', NULL, N'HS02', NULL, 423)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP004', N'Có hơi chút khó khăn để trở thành nữ phản diện trong Otome game lấy bối cảnh hiện đại này', N'It’s a Little Hard to be a Villainess of an Otome Game in Modern Society', N'Cô gái hóa thân thành nữ phản diện trong một otome game lấy bối cảnh hiện đại. Tuy nhiên, bối cảnh hiện đại này đã khiến cuộc sống bình thường của nữ phản diện gặp quá nhiều trắc trở. Kể cả khi cô còn đang bận đấu tranh nội tâm, lịch sử nhật bản hiện đại, lịch sử kinh tế hiện đại và cũng như là vấn đề kinh tế toàn cầu đang không ngừng tấn công lấy cô gái nhân vật chính.

Nữ phản diện, hãy cố lên nào! Nữ phản diện, hãy đừng bỏ cuộc ! !

Sự thất bại trong đệ nhị thế chiến, sự sụp đổ của bong bong kinh tế, cũng như cả sự ảnh hưởng của khủng hoảng tài chính, nữ phản diện Keikain Runa đã phải ném mình vào cuộc đấu tranh với lịch sử ngụy tạo và chiến tranh tiền tệ, tất cả nhằm chỉ để bảo vệ cho nhân vật chính cùng các nhân vật chinh phục nam khác có được một cuộc sống bình yên.

Trên hết, đây là một câu chuyện hoàn toàn hư cấu, tất cả mọi sự trùng hợp chỉ là tình cờ và hoàn toàn không liên quan đến con người hoặc các sự vật, sự việc xảy ra ngoài đời thực.', N'otomehiendai.jpg', N'TG06', N'HiuTao', CAST(N'2020-09-27T00:00:00.000' AS DateTime), N'Đã hoàn thành', N'Truyện convert', NULL, N'HS02', NULL, 1234)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP005', N'Uống cà phê sau giờ học, trong quán cà phê ở thế giới khác', N'Houkago wa, Isekai Kissa de Coffee wo', N'Yuu Kurosawa - một chàng trai trẻ bị dịch chuyển sang dị giới. Tại thị trấn của thế giới thần thoại nơi có cả bán nhân, elf, người lùn này, cậu không đi thám hiểm mê cung cũng chẳng đi săn tìm quỷ vương, mà điều hành quán cà phê duy nhất của thế giới. Một ngày nọ, cậu gặp gỡ cô nữ sinh của học viện phép thuật đang tìm kiếm một nơi để học bài...

--------------------------------------------------------------------------------------------------------------------------

Nếu đang tìm kiếm một bộ isekai có thể khiến bạn nín thở đọc không dứt mắt, well, bạn có thể nhấn nút back được rồi. Nhưng nếu đã thấm mệt sau những chuyến phiêu lưu thì xin mời ngồi xuống đây, cùng làm một tách cà phê ở dị giới trong yên bình nào :D', N'anhbia.jpg
', N'TG06', N'CuongNguyen', CAST(N'2020-09-24T00:00:00.000' AS DateTime), N'Đang tiến hành', N'Truyện dịch', NULL, N'HS01', NULL, 2873)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP006', N'May Your Soul Rest In Magdala', N'Mong linh hồn người yên nghỉ ở Magdala', N'Đây là thế giới mà trật tự được duy trì bởi ba thế lực lớn: [Giáo Hội] là thế lực có quyền hạn lớn nhất, [Hội Kỵ Sĩ Clausius], chiếm hữu sự ảnh hưởng ngang tầm với [Giáo Hội], về quản lý tài chính và lực lượng quân sự, và [Hội Thương Gia], là hiệp hội của các thương nhân và thợ thủ công.

Trong thế giới mà nhân vật chính của chúng ta, giả kim thuật sư Kusla, người bị bắt bởi tội trộm cắp hài cốt của thánh nhân đem đi đốt một cách trái phép, bị giam giữ trong một cái ngục tù tối tăm và rồi...', N'anhbia.jpg
', N'TG07', N'CuongNguyen', CAST(N'2020-09-04T00:00:00.000' AS DateTime), N'Đang tiến hành', N'Truyện dịch', NULL, N'HS02', NULL, 2334)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP007', N'Itsuka Koko ni Ita Anata no Tameni / Zutto Soko ni Iru Anata no Tame ni', N'Someday, For You Who lived here / Forever, For You Who Stay There', N'Đây là một câu chuyện về ''sự kết thúc.'' Nói về câu chuyện bi thảm của hai người quan tâm đến nhau.

 

Người lính trẻ Lenka đã nhìn thấy một điều kỳ diệu vào ngày hôm đó.

 

Đó là tuyết rơi vào mùa xuân. Tuyết rơi trên tiền tuyến đẫm máu, đóng băng tất cả kẻ thù.

 

Cô gái thực hiện phép kỳ diệu này được gọi là ''Thánh nữ trong quan tài băng giá''.

 

Lenka và cô gái ấy tình cờ gặp nhau. Tình hình chiến tranh đang thay đổi và những ngày bình yên đến trong phút chốc, họ ngày càng gần gũi hơn.

 

Tuy nhiên, họ đã quên.

 

Rằng chàng trai ''chỉ là một người lính.''

 

Rằng cô gái là một ''vũ khí tuyệt đối''.

 

 

 

Đây là câu chuyện về cuộc gặp gỡ và chia ly của một chàng trai ngốc nghếch và một cô gái không mấy hạnh phúc.', N'anhbia.jpg
', N'TG03', N'CuongNguyen', CAST(N'2020-09-04T00:00:00.000' AS DateTime), N'Đang tiến hành', N'Truyện dịch', NULL, N'HS02', NULL, 1123)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP008', N'Kore ga mahoutsukai no kirifuda', N'This is Wizard’s Last Card', N'Không phải vì sức mạnh. Tôi trở thành ma pháp sư để được "sống vui vẻ mà thôi".

Chàng kiếm sĩ Rix đăng ký vào học viện ma pháp để có thể sống mà không phải chiến đấu, song lại bị đánh giá là không có năng khiếu trở thành pháp sư. Dẫu vậy, Rix vẫn phải dựa vào khả năng chiến đấu trời sinh để cố gắng vượt qua cuộc sống học đường, cũng như phải thử sức mình với "ma thuật" hòng có thể nắm bắt được lối sống mới này.', N'anhbia.jpg
', N'TG04', N'CuongNguyen', CAST(N'2023-09-12T00:00:00.000' AS DateTime), N'Tạm ngưng', N'Truyện convert', NULL, N'HS04', NULL, 1234)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP009', N'Mushoku Tensei - Isekai Ittara Honki Dasu', N'Thất nghiệp chuyển sinh', N'Một otaku vô công rồi nghề 34 tuổi bị đuổi ra khỏi nhà bởi chính gia đình của mình. Nhận ra cuộc đời của bản thân đã lâm vào ngõ cụt cũng như là sự rác rưởi, vô dụng của bản thân; anh ta ước rằng phải chi bản thân khi xưa vượt qua được giai đoạn đen tối của cuộc đời thì bây giờ có lẽ mọi chuyện đã khác. Đúng vào khoảnh khắc hối tiếc đó, anh thấy 1 chiếc xe tải chạy với vận tốc lớn đang lao đến 3 học sinh trung học gần đó. Gom tất cả sức lực còn lại, anh ta cứu được 3 học sinh kia tuy nhiên lại phải bỏ mạng của chính bản thân mình dưới bánh chiếc xe tải đó. Khi mở mắt ra, anh nhận ra rằng mình đã được đầu thai ở thế giới của gươm giáo và phép thuật song hành tồn tại dưới cái tên Rudeus Greyrat. Dưới hình hài mới ở một thế giới mới, Rudeus tự khẳng định với bản thân " Lần này mình sẽ thực sự sống đến tận cùng cuộc sống này mà không hề tiếc nuối". Và như thế, cuộc hành trình của anh bắt đầu.', N'anhbia.jpg
', N'TG04', N'CongTien', CAST(N'2020-09-24T00:00:00.000' AS DateTime), N'Tạm ngưng', N'Truyện convert', NULL, N'HS02', NULL, 565)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP010', N'Tensei shitara doragon no tamago datta ~ saikyō igai mezasane ~e ~', N'Reincarnated as a Dragon’s Egg ~ Lets Aim to Be the Strongest ~', N'Tôi tỉnh đậy ở một khu rừng vô danh trong hình dạng một quả trứng.

Nơi này giống như một thế giới giả tưởng, những sinh vật kỳ lạ và hung hãn khắp xung quanh. Giống như trong game, dường như tôi có thể kiểm tra chỉ số của tôi và kẻ thù.

Tôi muốn săn những con quái vật, thu thập danh hiệu để lên cấp và tiến hóa trở thành một con rồng mạnh mẽ hơn.

Rồi tôi nghe thấy một giọng nói bí ẩn ở trong đầu mình: “Hãy hướng đến mục tiêu trở thành kẻ mạnh nhất!”', N'anhbia.jpg
', N'TG04', N'CongTien', CAST(N'2022-02-02T00:00:00.000' AS DateTime), N'Tạm ngưng', N'Truyện convert', NULL, N'HS03', NULL, 12356)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP011', N'Date A Live Fragments: Date A Bullet', N'Cuộc hẹn sống còn', N'Series spin-off của Date A Live, với nội dung chủ yếu xoay quanh Tokisaki Kurumi. Tại đây, cô gặp gỡ Empty, một Chuẩn Tinh Linh mới xuất hiện tại Lân Giới. Cô cùng Empty hợp tác với nhau, tham gia vào cuộc chiến sinh tồn với các Tinh Linh, nhằm giành lấy một điều ước duy nhất cho Tinh Linh thắng cuộc.', NULL, N'TG09', N'HiuTao', CAST(N'2022-02-02T00:00:00.000' AS DateTime), N'Đang tiến hành', N'Truyện dịch', NULL, N'HS01', NULL, 5623)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP012', N'Date A Live Fragments: Date A Bullet', N'Cuộc hẹn sống còn', N'Series spin-off của Date A Live, với nội dung chủ yếu xoay quanh Tokisaki Kurumi. Tại đây, cô gặp gỡ Empty, một Chuẩn Tinh Linh mới xuất hiện tại Lân Giới. Cô cùng Empty hợp tác với nhau, tham gia vào cuộc chiến sinh tồn với các Tinh Linh, nhằm giành lấy một điều ước duy nhất cho Tinh Linh thắng cuộc.', NULL, N'TG09', N'HiuTao', CAST(N'2022-02-02T00:00:00.000' AS DateTime), N'Đang tiến hành', N'Truyện dịch', NULL, N'HS01', NULL, 5623)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP013', N'Date A Live Fragments: Date A Bullet', N'Cuộc hẹn sống còn', N'Series spin-off của Date A Live, với nội dung chủ yếu xoay quanh Tokisaki Kurumi. Tại đây, cô gặp gỡ Empty, một Chuẩn Tinh Linh mới xuất hiện tại Lân Giới. Cô cùng Empty hợp tác với nhau, tham gia vào cuộc chiến sinh tồn với các Tinh Linh, nhằm giành lấy một điều ước duy nhất cho Tinh Linh thắng cuộc.', NULL, N'TG09', N'HiuTao', CAST(N'2022-02-02T00:00:00.000' AS DateTime), N'Đang tiến hành', N'Truyện dịch', NULL, N'HS01', NULL, 5623)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP014', N'Date A Live Fragments: Date A Bullet', N'Cuộc hẹn sống còn', N'Series spin-off của Date A Live, với nội dung chủ yếu xoay quanh Tokisaki Kurumi. Tại đây, cô gặp gỡ Empty, một Chuẩn Tinh Linh mới xuất hiện tại Lân Giới. Cô cùng Empty hợp tác với nhau, tham gia vào cuộc chiến sinh tồn với các Tinh Linh, nhằm giành lấy một điều ước duy nhất cho Tinh Linh thắng cuộc.', NULL, N'TG09', N'HiuTao', CAST(N'2022-02-02T00:00:00.000' AS DateTime), N'Đang tiến hành', N'Truyện dịch', NULL, N'HS01', NULL, 5623)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP015', N'Date A Live Fragments: Date A Bullet', N'Cuộc hẹn sống còn', N'Series spin-off của Date A Live, với nội dung chủ yếu xoay quanh Tokisaki Kurumi. Tại đây, cô gặp gỡ Empty, một Chuẩn Tinh Linh mới xuất hiện tại Lân Giới. Cô cùng Empty hợp tác với nhau, tham gia vào cuộc chiến sinh tồn với các Tinh Linh, nhằm giành lấy một điều ước duy nhất cho Tinh Linh thắng cuộc.', NULL, N'TG09', N'HiuTao', CAST(N'2022-02-02T00:00:00.000' AS DateTime), N'Đang tiến hành', N'Truyện dịch', NULL, N'HS01', NULL, 5623)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP016', N'Date A Live Fragments: Date A Bullet', N'Cuộc hẹn sống còn', N'Series spin-off của Date A Live, với nội dung chủ yếu xoay quanh Tokisaki Kurumi. Tại đây, cô gặp gỡ Empty, một Chuẩn Tinh Linh mới xuất hiện tại Lân Giới. Cô cùng Empty hợp tác với nhau, tham gia vào cuộc chiến sinh tồn với các Tinh Linh, nhằm giành lấy một điều ước duy nhất cho Tinh Linh thắng cuộc.', NULL, N'TG09', N'HiuTao', CAST(N'2022-02-02T00:00:00.000' AS DateTime), N'Đang tiến hành', N'Truyện dịch', NULL, N'HS01', NULL, 5623)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP017', N'Date A Live Fragments: Date A Bullet', N'Cuộc hẹn sống còn', N'Series spin-off của Date A Live, với nội dung chủ yếu xoay quanh Tokisaki Kurumi. Tại đây, cô gặp gỡ Empty, một Chuẩn Tinh Linh mới xuất hiện tại Lân Giới. Cô cùng Empty hợp tác với nhau, tham gia vào cuộc chiến sinh tồn với các Tinh Linh, nhằm giành lấy một điều ước duy nhất cho Tinh Linh thắng cuộc.', NULL, N'TG09', N'HiuTao', CAST(N'2022-02-02T00:00:00.000' AS DateTime), N'Đang tiến hành', N'Truyện dịch', NULL, N'HS01', NULL, 5623)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP018', N'Date A Live Fragments: Date A Bullet', N'Cuộc hẹn sống còn', N'Series spin-off của Date A Live, với nội dung chủ yếu xoay quanh Tokisaki Kurumi. Tại đây, cô gặp gỡ Empty, một Chuẩn Tinh Linh mới xuất hiện tại Lân Giới. Cô cùng Empty hợp tác với nhau, tham gia vào cuộc chiến sinh tồn với các Tinh Linh, nhằm giành lấy một điều ước duy nhất cho Tinh Linh thắng cuộc.', NULL, N'TG09', N'HiuTao', CAST(N'2022-02-02T00:00:00.000' AS DateTime), N'Đang tiến hành', N'Truyện dịch', NULL, N'HS01', NULL, 5623)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP019', N'Date A Live Fragments: Date A Bullet', N'Cuộc hẹn sống còn', N'Series spin-off của Date A Live, với nội dung chủ yếu xoay quanh Tokisaki Kurumi. Tại đây, cô gặp gỡ Empty, một Chuẩn Tinh Linh mới xuất hiện tại Lân Giới. Cô cùng Empty hợp tác với nhau, tham gia vào cuộc chiến sinh tồn với các Tinh Linh, nhằm giành lấy một điều ước duy nhất cho Tinh Linh thắng cuộc.', NULL, N'TG09', N'HiuTao', CAST(N'2022-02-02T00:00:00.000' AS DateTime), N'Đang tiến hành', N'Truyện dịch', NULL, N'HS01', NULL, 5623)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP020', N'Date A Live Fragments: Date A Bullet', N'Cuộc hẹn sống còn', N'Series spin-off của Date A Live, với nội dung chủ yếu xoay quanh Tokisaki Kurumi. Tại đây, cô gặp gỡ Empty, một Chuẩn Tinh Linh mới xuất hiện tại Lân Giới. Cô cùng Empty hợp tác với nhau, tham gia vào cuộc chiến sinh tồn với các Tinh Linh, nhằm giành lấy một điều ước duy nhất cho Tinh Linh thắng cuộc.', NULL, N'TG09', N'HiuTao', CAST(N'2022-02-02T00:00:00.000' AS DateTime), N'Đang tiến hành', N'Truyện dịch', NULL, N'HS01', NULL, 5623)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP021', N'Date A Live Fragments: Date A Bullet', N'Cuộc hẹn sống còn', N'Series spin-off của Date A Live, với nội dung chủ yếu xoay quanh Tokisaki Kurumi. Tại đây, cô gặp gỡ Empty, một Chuẩn Tinh Linh mới xuất hiện tại Lân Giới. Cô cùng Empty hợp tác với nhau, tham gia vào cuộc chiến sinh tồn với các Tinh Linh, nhằm giành lấy một điều ước duy nhất cho Tinh Linh thắng cuộc.', NULL, N'TG09', N'HiuTao', CAST(N'2022-02-02T00:00:00.000' AS DateTime), N'Đang tiến hành', N'Truyện dịch', NULL, N'HS01', NULL, 5623)
INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem]) VALUES (N'TP022', N'Date A Live Fragments: Date A Bullet', N'Cuộc hẹn sống còn', N'Series spin-off của Date A Live, với nội dung chủ yếu xoay quanh Tokisaki Kurumi. Tại đây, cô gặp gỡ Empty, một Chuẩn Tinh Linh mới xuất hiện tại Lân Giới. Cô cùng Empty hợp tác với nhau, tham gia vào cuộc chiến sinh tồn với các Tinh Linh, nhằm giành lấy một điều ước duy nhất cho Tinh Linh thắng cuộc.', NULL, N'TG09', N'HiuTao', CAST(N'2022-02-02T00:00:00.000' AS DateTime), N'Đang tiến hành', N'Truyện dịch', NULL, N'HS01', NULL, 5623)
GO
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL01', N'Action', N'Thể loại hành động thường có nội dung đánh nhau')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL02', N'Adapted to anime', N'Truyện đã được chuyển thể sang anime')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL03', N'Apdated to manga', N'Truyện đã được chuyển thể manga')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL04', N'Apdated to anime', N'Truyện đã được chuyển thể anime')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL05', N'Apdated to movie', N'Truyện đã được chuyển thể phim điện ảnh')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL06', N'Apdated to game', N'Truyện đã được chuyển thể game')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL07', N'Historical', N'Lịch sử')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL08', N'Horror', N'Kinh dị')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL09', N'Mystery', N'Huyền bí')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL10', N'Romance', N'Lãng mạn')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL11', N'Science fiction', N'Khoa học viễn tưởng')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL12', N'School life', N'Truyện thanh xuân')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL13', N'Slice of life', N'Truyện đời thường')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL14', N'Sports', N'Thể thao')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL15', N'Thriller', N'Tình tiết hồi hộp')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL16', N'Webtoon', N'Truyện tranh mạng')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL17', N'Yuri', N'Truyện đồng tính nữ')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL18', N'Yaoi', N'Truyện đồng tính nam')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL19', N'Zombie', N'Xác sống')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL20', N'Isekai', N'Truyện có yếu tố chuyển sinh')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL21', N'Adventure', N'Truyện có yếu tố phiêu lưu')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai], [GhiChu]) VALUES (N'TL22', N'Adult', N'Truyện người lớn')
GO
INSERT [dbo].[User] ([TenDangNhap], [MatKhau], [TrangThai], [AnhDaiDien], [AnhNen], [NgayTao], [ThoiGianLanCuoi], [Email]) VALUES (N'Bro-nya', N'123', 0, NULL, NULL, CAST(N'2023-11-09T00:00:00.000' AS DateTime), CAST(N'2023-11-23T13:11:54.890' AS DateTime), N'aCafasdf@gmail.com')
INSERT [dbo].[User] ([TenDangNhap], [MatKhau], [TrangThai], [AnhDaiDien], [AnhNen], [NgayTao], [ThoiGianLanCuoi], [Email]) VALUES (N'CongTien', N'123', 0, NULL, NULL, CAST(N'2023-11-09T00:00:00.000' AS DateTime), CAST(N'2023-11-23T13:11:54.890' AS DateTime), N'HiuTao@gmail.com')
INSERT [dbo].[User] ([TenDangNhap], [MatKhau], [TrangThai], [AnhDaiDien], [AnhNen], [NgayTao], [ThoiGianLanCuoi], [Email]) VALUES (N'CuongNguyen', N'123', 0, NULL, NULL, CAST(N'2023-11-09T00:00:00.000' AS DateTime), CAST(N'2023-11-23T13:11:54.890' AS DateTime), N'HiuTao@gmail.com')
INSERT [dbo].[User] ([TenDangNhap], [MatKhau], [TrangThai], [AnhDaiDien], [AnhNen], [NgayTao], [ThoiGianLanCuoi], [Email]) VALUES (N'Eren', N'123', 0, NULL, NULL, CAST(N'2023-11-09T00:00:00.000' AS DateTime), CAST(N'2023-11-23T13:11:54.890' AS DateTime), N'HiuTao@gmail.com')
INSERT [dbo].[User] ([TenDangNhap], [MatKhau], [TrangThai], [AnhDaiDien], [AnhNen], [NgayTao], [ThoiGianLanCuoi], [Email]) VALUES (N'HiuTao', N'123', 0, NULL, NULL, CAST(N'2023-11-09T00:00:00.000' AS DateTime), CAST(N'2023-11-23T13:11:54.890' AS DateTime), N'HiuTao@gmail.com')
INSERT [dbo].[User] ([TenDangNhap], [MatKhau], [TrangThai], [AnhDaiDien], [AnhNen], [NgayTao], [ThoiGianLanCuoi], [Email]) VALUES (N'Inu', N'123', 0, NULL, NULL, CAST(N'2023-11-09T00:00:00.000' AS DateTime), CAST(N'2023-11-23T13:11:54.890' AS DateTime), N'HiuTao@gmail.com')
INSERT [dbo].[User] ([TenDangNhap], [MatKhau], [TrangThai], [AnhDaiDien], [AnhNen], [NgayTao], [ThoiGianLanCuoi], [Email]) VALUES (N'Kagome', N'123', 0, NULL, NULL, CAST(N'2023-11-09T00:00:00.000' AS DateTime), CAST(N'2023-11-23T13:11:54.890' AS DateTime), N'HiuTao@gmail.com')
INSERT [dbo].[User] ([TenDangNhap], [MatKhau], [TrangThai], [AnhDaiDien], [AnhNen], [NgayTao], [ThoiGianLanCuoi], [Email]) VALUES (N'Zennomi', N'123', 0, NULL, NULL, CAST(N'2023-11-09T00:00:00.000' AS DateTime), CAST(N'2023-11-23T13:11:54.890' AS DateTime), N'HiuTao@gmail.com')
GO
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP001V1', N'Vol1', N'DateABullet.jpg', N'TP001', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP001V2', N'Vol2', N'DateABullet.jpg', N'TP001', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP002V1', N'Vol1', N'DALVol1.jpg', N'TP002', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP002V2', N'Vol2', N'DALVol1.jpg', N'TP002', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP003V1', N'Vol1', N'DALVol1.jpg', N'TP003', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP003V2', N'Vol2', N'DALVol1.jpg', N'TP003', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP003V3', N'Vol3', N'DALVol1.jpg', N'TP003', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP004V1', N'Vol1', N'DALVol1.jpg', N'TP004', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP004V2', N'Vol2', N'DALVol1.jpg', N'TP004', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP004V3', N'Vol3', N'DALVol1.jpg', N'TP004', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP005V1', N'Vol1', N'vol.jpg', N'TP005', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP005V2', N'Vol2', N'vol.jpg', N'TP005', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP005V3', N'Vol3', N'vol.jpg', N'TP005', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP006V1', N'Vol1', N'vol.jpg', N'TP006', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP006V2', N'Vol2', N'vol.jpg', N'TP006', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP006V3', N'Vol3', N'vol.jpg', N'TP006', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP007V1', N'Vol1', N'vol.jpg', N'TP007', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP007V2', N'Vol2', N'vol.jpg', N'TP007', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP007V3', N'Vol3', N'vol.jpg', N'TP007', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP008V1', N'Vol1', N'vol.jpg', N'TP008', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP008V2', N'Vol2', N'vol.jpg', N'TP008', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP008V3', N'Vol3', N'vol.jpg', N'TP008', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP009V1', N'Vol1', N'vol.jpg', N'TP009', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP009V2', N'Vol2', N'vol.jpg', N'TP009', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP009V3', N'Vol3', N'vol.jpg', N'TP009', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP010V1', N'Vol1', N'vol.jpg', N'TP010', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP010V2', N'Vol2', N'vol.jpg', N'TP010', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP010V3', N'Vol3', N'vol.jpg', N'TP010', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP011V1', N'Vol1', N'vol.jpg', N'TP011', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP011V2', N'Vol2', N'vol.jpg', N'TP011', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP011V3', N'Vol3', N'vol.jpg', N'TP011', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP012V1', N'Vol1', N'vol.jpg', N'TP012', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP012V2', N'Vol2', N'vol.jpg', N'TP012', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP012V3', N'Vol3', N'vol.jpg', N'TP012', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP013V1', N'Vol1', N'vol.jpg', N'TP013', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP013V2', N'Vol2', N'vol.jpg', N'TP013', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP013V3', N'Vol3', N'vol.jpg', N'TP013', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP014V1', N'Vol1', N'vol.jpg', N'TP014', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP014V2', N'Vol2', N'vol.jpg', N'TP014', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP014V3', N'Vol3', N'vol.jpg', N'TP014', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP015V1', N'Vol1', N'vol.jpg', N'TP015', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP015V2', N'Vol2', N'vol.jpg', N'TP015', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP015V3', N'Vol3', N'vol.jpg', N'TP015', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP016V1', N'Vol1', N'vol.jpg', N'TP016', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP016V2', N'Vol2', N'vol.jpg', N'TP016', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP016V3', N'Vol3', N'vol.jpg', N'TP016', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP017V1', N'Vol1', N'vol.jpg', N'TP017', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP017V2', N'Vol2', N'vol.jpg', N'TP017', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP017V3', N'Vol3', N'vol.jpg', N'TP017', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP018V1', N'Vol1', N'vol.jpg', N'TP018', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP018V2', N'Vol2', N'vol.jpg', N'TP018', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP018V3', N'Vol3', N'vol.jpg', N'TP018', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP019V1', N'Vol1', N'vol.jpg', N'TP019', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP019V2', N'Vol2', N'vol.jpg', N'TP019', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP019V3', N'Vol3', N'vol.jpg', N'TP019', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP020V1', N'Vol1', N'vol.jpg', N'TP020', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP020V2', N'Vol2', N'vol.jpg', N'TP020', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP020V3', N'Vol3', N'vol.jpg', N'TP020', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP021V1', N'Vol1', N'vol.jpg', N'TP021', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP021V2', N'Vol2', N'vol.jpg', N'TP021', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP021V3', N'Vol3', N'vol.jpg', N'TP021', 3)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP022V1', N'Vol1', N'vol.jpg', N'TP022', 1)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP022V2', N'Vol2', N'vol.jpg', N'TP022', 2)
INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'TP022V3', N'Vol3', N'vol.jpg', N'TP022', 3)
GO
INSERT [dbo].[YeuThich] ([MaYeuThich], [TenDangNhap], [MaTacPham]) VALUES (N'YT001', N'CuongNguyen', N'TP001')
INSERT [dbo].[YeuThich] ([MaYeuThich], [TenDangNhap], [MaTacPham]) VALUES (N'YT002', N'HiuTao', N'TP001')
INSERT [dbo].[YeuThich] ([MaYeuThich], [TenDangNhap], [MaTacPham]) VALUES (N'YT003', N'HiuTao', N'TP002')
INSERT [dbo].[YeuThich] ([MaYeuThich], [TenDangNhap], [MaTacPham]) VALUES (N'YT004', N'HiuTao', N'TP004')
GO
ALTER TABLE [dbo].[BinhChon]  WITH CHECK ADD  CONSTRAINT [FK_BinhChon_TacPham] FOREIGN KEY([MaTacPham])
REFERENCES [dbo].[TacPham] ([MaTacPham])
GO
ALTER TABLE [dbo].[BinhChon] CHECK CONSTRAINT [FK_BinhChon_TacPham]
GO
ALTER TABLE [dbo].[BinhChon]  WITH CHECK ADD  CONSTRAINT [FK_BinhChon_User] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[User] ([TenDangNhap])
GO
ALTER TABLE [dbo].[BinhChon] CHECK CONSTRAINT [FK_BinhChon_User]
GO
ALTER TABLE [dbo].[BinhLuan]  WITH CHECK ADD  CONSTRAINT [FK_BinhLuan_Chapter] FOREIGN KEY([MaChapter])
REFERENCES [dbo].[Chapter] ([MaChapter])
GO
ALTER TABLE [dbo].[BinhLuan] CHECK CONSTRAINT [FK_BinhLuan_Chapter]
GO
ALTER TABLE [dbo].[BinhLuan]  WITH CHECK ADD  CONSTRAINT [FK_BinhLuan_User] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[User] ([TenDangNhap])
GO
ALTER TABLE [dbo].[BinhLuan] CHECK CONSTRAINT [FK_BinhLuan_User]
GO
ALTER TABLE [dbo].[BinhLuanTacPham]  WITH CHECK ADD  CONSTRAINT [FK_BinhLuanTacPham_TacPham] FOREIGN KEY([MaTacPham])
REFERENCES [dbo].[TacPham] ([MaTacPham])
GO
ALTER TABLE [dbo].[BinhLuanTacPham] CHECK CONSTRAINT [FK_BinhLuanTacPham_TacPham]
GO
ALTER TABLE [dbo].[BinhLuanTacPham]  WITH CHECK ADD  CONSTRAINT [FK_BinhLuanTacPham_User] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[User] ([TenDangNhap])
GO
ALTER TABLE [dbo].[BinhLuanTacPham] CHECK CONSTRAINT [FK_BinhLuanTacPham_User]
GO
ALTER TABLE [dbo].[Chapter]  WITH CHECK ADD  CONSTRAINT [FK_Chapter_Volume] FOREIGN KEY([MaVolume])
REFERENCES [dbo].[Volume] ([MaVolume])
GO
ALTER TABLE [dbo].[Chapter] CHECK CONSTRAINT [FK_Chapter_Volume]
GO
ALTER TABLE [dbo].[ChiTietHoaSi]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaSi_HoaSi] FOREIGN KEY([MaHoaSi])
REFERENCES [dbo].[HoaSi] ([MaHoaSi])
GO
ALTER TABLE [dbo].[ChiTietHoaSi] CHECK CONSTRAINT [FK_ChiTietHoaSi_HoaSi]
GO
ALTER TABLE [dbo].[ChiTietHoaSi]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaSi_TacPham] FOREIGN KEY([MaTacPham])
REFERENCES [dbo].[TacPham] ([MaTacPham])
GO
ALTER TABLE [dbo].[ChiTietHoaSi] CHECK CONSTRAINT [FK_ChiTietHoaSi_TacPham]
GO
ALTER TABLE [dbo].[ChiTietNhomDich]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhomDich_NhomDich] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NhomDich] ([MaNhom])
GO
ALTER TABLE [dbo].[ChiTietNhomDich] CHECK CONSTRAINT [FK_ChiTietNhomDich_NhomDich]
GO
ALTER TABLE [dbo].[ChiTietNhomDich]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhomDich_User] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[User] ([TenDangNhap])
GO
ALTER TABLE [dbo].[ChiTietNhomDich] CHECK CONSTRAINT [FK_ChiTietNhomDich_User]
GO
ALTER TABLE [dbo].[ChiTietTheLoai]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietTheLoai_TacPham] FOREIGN KEY([MaTacPham])
REFERENCES [dbo].[TacPham] ([MaTacPham])
GO
ALTER TABLE [dbo].[ChiTietTheLoai] CHECK CONSTRAINT [FK_ChiTietTheLoai_TacPham]
GO
ALTER TABLE [dbo].[ChiTietTheLoai]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietTheLoai_TheLoai] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoai] ([MaTheLoai])
GO
ALTER TABLE [dbo].[ChiTietTheLoai] CHECK CONSTRAINT [FK_ChiTietTheLoai_TheLoai]
GO
ALTER TABLE [dbo].[HeThong]  WITH CHECK ADD  CONSTRAINT [FK_HeThong_User] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[User] ([TenDangNhap])
GO
ALTER TABLE [dbo].[HeThong] CHECK CONSTRAINT [FK_HeThong_User]
GO
ALTER TABLE [dbo].[LichSu]  WITH CHECK ADD  CONSTRAINT [FK_LichSu_Chapter] FOREIGN KEY([MaChapter])
REFERENCES [dbo].[Chapter] ([MaChapter])
GO
ALTER TABLE [dbo].[LichSu] CHECK CONSTRAINT [FK_LichSu_Chapter]
GO
ALTER TABLE [dbo].[LichSu]  WITH CHECK ADD  CONSTRAINT [FK_LichSu_User] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[User] ([TenDangNhap])
GO
ALTER TABLE [dbo].[LichSu] CHECK CONSTRAINT [FK_LichSu_User]
GO
ALTER TABLE [dbo].[TacPham]  WITH CHECK ADD  CONSTRAINT [FK_TacPham_NhomDich] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NhomDich] ([MaNhom])
GO
ALTER TABLE [dbo].[TacPham] CHECK CONSTRAINT [FK_TacPham_NhomDich]
GO
ALTER TABLE [dbo].[TacPham]  WITH CHECK ADD  CONSTRAINT [FK_TacPham_TacGia] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TacGia] ([MaTacGia])
GO
ALTER TABLE [dbo].[TacPham] CHECK CONSTRAINT [FK_TacPham_TacGia]
GO
ALTER TABLE [dbo].[ThongBao]  WITH CHECK ADD  CONSTRAINT [FK_ThongBao_User] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[User] ([TenDangNhap])
GO
ALTER TABLE [dbo].[ThongBao] CHECK CONSTRAINT [FK_ThongBao_User]
GO
ALTER TABLE [dbo].[Volume]  WITH CHECK ADD  CONSTRAINT [FK_Volume_TacPham] FOREIGN KEY([MaTacPham])
REFERENCES [dbo].[TacPham] ([MaTacPham])
GO
ALTER TABLE [dbo].[Volume] CHECK CONSTRAINT [FK_Volume_TacPham]
GO
ALTER TABLE [dbo].[YeuThich]  WITH CHECK ADD  CONSTRAINT [FK_YeuThich_TacPham] FOREIGN KEY([MaTacPham])
REFERENCES [dbo].[TacPham] ([MaTacPham])
GO
ALTER TABLE [dbo].[YeuThich] CHECK CONSTRAINT [FK_YeuThich_TacPham]
GO
ALTER TABLE [dbo].[YeuThich]  WITH CHECK ADD  CONSTRAINT [FK_YeuThich_User] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[User] ([TenDangNhap])
GO
ALTER TABLE [dbo].[YeuThich] CHECK CONSTRAINT [FK_YeuThich_User]
GO
USE [master]
GO
ALTER DATABASE [ReadingLightNovel] SET  READ_WRITE 
GO
