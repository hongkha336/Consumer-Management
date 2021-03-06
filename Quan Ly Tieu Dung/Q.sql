USE [master]
GO
/****** Object:  Database [Quan Ly Tieu Dung]    Script Date: 8/9/2018 2:39:26 PM ******/
CREATE DATABASE [Quan Ly Tieu Dung]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Quan Ly Tieu Dung', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.UX305\MSSQL\DATA\Quan Ly Tieu Dung.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Quan Ly Tieu Dung_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.UX305\MSSQL\DATA\Quan Ly Tieu Dung_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quan Ly Tieu Dung].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET ARITHABORT OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET  MULTI_USER 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Quan Ly Tieu Dung]
GO
/****** Object:  Table [dbo].[LanChiTieu]    Script Date: 8/9/2018 2:39:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LanChiTieu](
	[Ngay] [date] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Money] [int] NULL,
	[Reasion] [nvarchar](80) NULL,
	[UserID] [varchar](50) NULL,
 CONSTRAINT [PK_LanChiTieu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ngay]    Script Date: 8/9/2018 2:39:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ngay](
	[ID_Time] [date] NOT NULL,
 CONSTRAINT [PK_Ngay] PRIMARY KEY CLUSTERED 
(
	[ID_Time] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NoTot]    Script Date: 8/9/2018 2:39:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NoTot](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Money] [int] NULL,
	[ThanhToan] [bit] NOT NULL,
	[UserID] [varchar](50) NOT NULL,
	[Ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NoTot] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NoXau]    Script Date: 8/9/2018 2:39:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NoXau](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Money] [int] NULL,
	[ThanhToan] [bit] NOT NULL,
	[UserID] [varchar](50) NULL,
	[Ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NoXau] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TienTrongVi]    Script Date: 8/9/2018 2:39:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TienTrongVi](
	[Ngay] [date] NOT NULL,
	[SoTien] [int] NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [nvarchar](50) NULL,
 CONSTRAINT [PK_TienTrongVi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 8/9/2018 2:39:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[userID] [varchar](50) NOT NULL,
	[userPassWord] [varchar](50) NULL,
	[userName] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[LanChiTieu] ON 

INSERT [dbo].[LanChiTieu] ([Ngay], [ID], [Money], [Reasion], [UserID]) VALUES (CAST(0x903E0B00 AS Date), 5, 55000, N'Dầu gội', N'hongkha')
INSERT [dbo].[LanChiTieu] ([Ngay], [ID], [Money], [Reasion], [UserID]) VALUES (CAST(0x903E0B00 AS Date), 6, 15000, N'Mì hoành thánh', N'hongkha')
INSERT [dbo].[LanChiTieu] ([Ngay], [ID], [Money], [Reasion], [UserID]) VALUES (CAST(0x903E0B00 AS Date), 8, 11000, N'Nước ngọt', N'hongkha')
INSERT [dbo].[LanChiTieu] ([Ngay], [ID], [Money], [Reasion], [UserID]) VALUES (CAST(0x903E0B00 AS Date), 9, 20000, N'Cơm trưa', N'hongkha')
INSERT [dbo].[LanChiTieu] ([Ngay], [ID], [Money], [Reasion], [UserID]) VALUES (CAST(0x903E0B00 AS Date), 10, 10000, N'Nước Cam', N'hongkha')
INSERT [dbo].[LanChiTieu] ([Ngay], [ID], [Money], [Reasion], [UserID]) VALUES (CAST(0x913E0B00 AS Date), 11, 20000, N'Cơm trưa', N'hongkha')
INSERT [dbo].[LanChiTieu] ([Ngay], [ID], [Money], [Reasion], [UserID]) VALUES (CAST(0x913E0B00 AS Date), 15, 20000, N'Cơm chiều', N'hongkha')
INSERT [dbo].[LanChiTieu] ([Ngay], [ID], [Money], [Reasion], [UserID]) VALUES (CAST(0x913E0B00 AS Date), 22, 10000, N'Nước khóm', N'hongkha')
INSERT [dbo].[LanChiTieu] ([Ngay], [ID], [Money], [Reasion], [UserID]) VALUES (CAST(0x923E0B00 AS Date), 29, 74000, N'Gà nướng ò ó o', N'hongkha')
SET IDENTITY_INSERT [dbo].[LanChiTieu] OFF
INSERT [dbo].[Ngay] ([ID_Time]) VALUES (CAST(0x883E0B00 AS Date))
INSERT [dbo].[Ngay] ([ID_Time]) VALUES (CAST(0x8E3E0B00 AS Date))
INSERT [dbo].[Ngay] ([ID_Time]) VALUES (CAST(0x903E0B00 AS Date))
INSERT [dbo].[Ngay] ([ID_Time]) VALUES (CAST(0x913E0B00 AS Date))
INSERT [dbo].[Ngay] ([ID_Time]) VALUES (CAST(0x923E0B00 AS Date))
SET IDENTITY_INSERT [dbo].[NoTot] ON 

INSERT [dbo].[NoTot] ([ID], [Money], [ThanhToan], [UserID], [Ghichu]) VALUES (1, 44000, 1, N'hongkha', N'Phương (Shopping)')
INSERT [dbo].[NoTot] ([ID], [Money], [ThanhToan], [UserID], [Ghichu]) VALUES (2, 91000, 0, N'hongkha', N'Sì (Lấy đồ)')
INSERT [dbo].[NoTot] ([ID], [Money], [ThanhToan], [UserID], [Ghichu]) VALUES (3, 45000, 0, N'hongkha', N'Long (Nước)')
SET IDENTITY_INSERT [dbo].[NoTot] OFF
SET IDENTITY_INSERT [dbo].[TienTrongVi] ON 

INSERT [dbo].[TienTrongVi] ([Ngay], [SoTien], [ID], [UserID]) VALUES (CAST(0x913E0B00 AS Date), 1223000, 6, N'hongkha')
INSERT [dbo].[TienTrongVi] ([Ngay], [SoTien], [ID], [UserID]) VALUES (CAST(0x913E0B00 AS Date), 1203000, 8, N'hongkha')
INSERT [dbo].[TienTrongVi] ([Ngay], [SoTien], [ID], [UserID]) VALUES (CAST(0x913E0B00 AS Date), 1193000, 19, N'hongkha')
INSERT [dbo].[TienTrongVi] ([Ngay], [SoTien], [ID], [UserID]) VALUES (CAST(0x913E0B00 AS Date), 1237000, 20, N'hongkha')
INSERT [dbo].[TienTrongVi] ([Ngay], [SoTien], [ID], [UserID]) VALUES (CAST(0x923E0B00 AS Date), 1163000, 24, N'hongkha')
SET IDENTITY_INSERT [dbo].[TienTrongVi] OFF
INSERT [dbo].[User] ([userID], [userPassWord], [userName]) VALUES (N'hongkha', N'hongkha123', N'Đặng Nguyễn Hồng Kha')
INSERT [dbo].[User] ([userID], [userPassWord], [userName]) VALUES (N'phuongpham', N'phuong123', N'Phạm Hoàng Đông Phương')
ALTER TABLE [dbo].[LanChiTieu]  WITH CHECK ADD  CONSTRAINT [FK_LanChiTieu_Ngay] FOREIGN KEY([Ngay])
REFERENCES [dbo].[Ngay] ([ID_Time])
GO
ALTER TABLE [dbo].[LanChiTieu] CHECK CONSTRAINT [FK_LanChiTieu_Ngay]
GO
ALTER TABLE [dbo].[LanChiTieu]  WITH CHECK ADD  CONSTRAINT [FK_LanChiTieu_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([userID])
GO
ALTER TABLE [dbo].[LanChiTieu] CHECK CONSTRAINT [FK_LanChiTieu_User]
GO
ALTER TABLE [dbo].[NoTot]  WITH CHECK ADD  CONSTRAINT [FK_NoTot_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([userID])
GO
ALTER TABLE [dbo].[NoTot] CHECK CONSTRAINT [FK_NoTot_User]
GO
ALTER TABLE [dbo].[NoXau]  WITH CHECK ADD  CONSTRAINT [FK_NoXau_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([userID])
GO
ALTER TABLE [dbo].[NoXau] CHECK CONSTRAINT [FK_NoXau_User]
GO
ALTER TABLE [dbo].[TienTrongVi]  WITH CHECK ADD  CONSTRAINT [FK_TienTrongVi_Ngay] FOREIGN KEY([Ngay])
REFERENCES [dbo].[Ngay] ([ID_Time])
GO
ALTER TABLE [dbo].[TienTrongVi] CHECK CONSTRAINT [FK_TienTrongVi_Ngay]
GO
USE [master]
GO
ALTER DATABASE [Quan Ly Tieu Dung] SET  READ_WRITE 
GO
