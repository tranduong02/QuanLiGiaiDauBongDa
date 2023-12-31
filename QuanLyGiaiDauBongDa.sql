USE [master]
GO
/****** Object:  Database [QuanLyGiaiDauBongDa]    Script Date: 3/26/2022 9:43:25 AM ******/
CREATE DATABASE [QuanLyGiaiDauBongDa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyGiaiDauBongDa', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyGiaiDauBongDa.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyGiaiDauBongDa_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuanLyGiaiDauBongDa_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyGiaiDauBongDa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyGiaiDauBongDa', N'ON'
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET QUERY_STORE = OFF
GO
USE [QuanLyGiaiDauBongDa]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[username] [nvarchar](50) NOT NULL,
	[full_name] [nvarchar](100) NULL,
	[password] [nvarchar](100) NULL,
	[email] [nvarchar](50) NULL,
	[dob] [date] NULL,
	[club_id] [int] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Card]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Card](
	[player_id] [int] NOT NULL,
	[match_id] [int] NOT NULL,
	[card_time] [int] NULL,
	[card_type] [bit] NULL,
	[card_id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Card] PRIMARY KEY CLUSTERED 
(
	[card_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Club]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Club](
	[club_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[year_created] [nvarchar](4) NULL,
	[country_id] [int] NULL,
	[city] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[stadium_id] [int] NULL,
	[logo_url] [nvarchar](50) NULL,
 CONSTRAINT [PK_Club] PRIMARY KEY CLUSTERED 
(
	[club_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[country_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[short_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[country_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feedback]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedback](
	[username] [nvarchar](50) NOT NULL,
	[problem] [nvarchar](50) NOT NULL,
	[content] [nvarchar](500) NOT NULL,
	[rateId] [int] NOT NULL,
	[FeedbackId] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Feedback_1] PRIMARY KEY CLUSTERED 
(
	[FeedbackId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Goal]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Goal](
	[goal_id] [int] IDENTITY(1,1) NOT NULL,
	[match_id] [int] NOT NULL,
	[player_id] [int] NOT NULL,
	[goal_time] [int] NULL,
 CONSTRAINT [PK_Goal] PRIMARY KEY CLUSTERED 
(
	[goal_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Match]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Match](
	[match_id] [int] IDENTITY(1,1) NOT NULL,
	[play_date] [datetime] NULL,
	[host_id] [int] NOT NULL,
	[guest_id] [int] NOT NULL,
	[referee_id] [int] NOT NULL,
	[tourseason_id] [int] NULL,
	[play_stage] [nvarchar](50) NULL,
	[venue_id] [int] NULL,
 CONSTRAINT [PK_Match_1] PRIMARY KEY CLUSTERED 
(
	[match_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Match_Result]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Match_Result](
	[match_id] [int] NOT NULL,
	[club_id] [int] NOT NULL,
	[win_lose] [nvarchar](50) NULL,
	[goal_score] [int] NULL,
	[shots] [int] NULL,
	[ontarget] [int] NULL,
	[control] [int] NULL,
	[fouls] [int] NULL,
	[corners] [int] NULL,
	[offsides] [int] NULL,
	[play_stage] [nvarchar](50) NULL,
 CONSTRAINT [PK_Match_Result] PRIMARY KEY CLUSTERED 
(
	[match_id] ASC,
	[club_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Player]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Player](
	[player_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[dob] [nvarchar](50) NULL,
	[country_id] [int] NULL,
	[position_id] [nvarchar](50) NULL,
	[height] [nvarchar](50) NULL,
	[weight] [nvarchar](50) NULL,
	[image] [nvarchar](50) NULL,
	[club_id] [int] NULL,
 CONSTRAINT [PK_Player] PRIMARY KEY CLUSTERED 
(
	[player_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Playing_Position]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Playing_Position](
	[position_id] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Playing_Position] PRIMARY KEY CLUSTERED 
(
	[position_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ranking]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ranking](
	[club_id] [int] NOT NULL,
	[club_name] [nvarchar](50) NULL,
	[match_played] [int] NULL,
	[won] [int] NULL,
	[drawn] [int] NULL,
	[lost] [int] NULL,
	[goal_difference] [int] NULL,
 CONSTRAINT [PK_Ranking] PRIMARY KEY CLUSTERED 
(
	[club_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ranking2s]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ranking2s](
	[ClubID] [nchar](10) NULL,
	[ClubName] [nvarchar](50) NULL,
	[Played] [nchar](10) NULL,
	[Won] [nchar](10) NULL,
	[Drawn] [nchar](10) NULL,
	[Lost] [nchar](10) NULL,
	[GD] [nchar](10) NULL,
	[Point] [nvarchar](50) NULL,
	[Ranking2ID] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Ranking2ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rate]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rate](
	[rateId] [int] NOT NULL,
	[rateName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Rate] PRIMARY KEY CLUSTERED 
(
	[rateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Referee]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Referee](
	[referee_id] [int] IDENTITY(1,1) NOT NULL,
	[referee_name] [nvarchar](50) NULL,
	[country_id] [int] NULL,
	[dob] [date] NULL,
	[image] [nvarchar](50) NULL,
	[year_started] [int] NULL,
 CONSTRAINT [PK_Referee] PRIMARY KEY CLUSTERED 
(
	[referee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[role_id] [int] NOT NULL,
	[role_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role_Account]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role_Account](
	[role_id] [int] NOT NULL,
	[username] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role_Account] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC,
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stadium]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stadium](
	[stadium_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Stadiun] PRIMARY KEY CLUSTERED 
(
	[stadium_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Team]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Team](
	[player_id] [int] NOT NULL,
	[match_id] [int] NOT NULL,
	[starting] [bit] NULL,
 CONSTRAINT [PK_Team] PRIMARY KEY CLUSTERED 
(
	[player_id] ASC,
	[match_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venue]    Script Date: 3/26/2022 9:43:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venue](
	[venue_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[audience_capacity] [int] NULL,
 CONSTRAINT [PK_Venue] PRIMARY KEY CLUSTERED 
(
	[venue_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'afussie5', N'Ardelle Fussie', N'5xFmcs8G6CXx', N'afussie5@earthlink.net', CAST(N'1980-11-12' AS Date), 1)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'asaurd', N'Ainslie Saur', N'odFxThXvRh', N'asaurd@flickr.com', CAST(N'2008-05-24' AS Date), 2)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'atantoni', N'Adriane Tanton', N'H3bwiJu', N'atantoni@wired.com', CAST(N'2003-10-08' AS Date), 3)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'brevane', N'Bruis Revan', N'eJIIFbGOpT3a', N'brevane@dot.gov', CAST(N'1986-02-12' AS Date), 4)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'ddresself', N'Drucie Dressel', N'iSUfOm7uz08', N'ddresself@businesswire.com', CAST(N'2002-10-23' AS Date), 5)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'dpaolaccig', N'Dianne Paolacci', N'dq7Cs9O5tO', N'dpaolaccig@omniture.com', CAST(N'2008-07-25' AS Date), NULL)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'dtd91', N'David Dang', N'123', N'datdthe151528@fpt.edu.vn', CAST(N'2001-10-09' AS Date), NULL)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'gboulter7', N'Georgena Boulter', N'S0rouqm7f', N'gboulter7@imageshack.us', CAST(N'2003-10-06' AS Date), NULL)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'ggoldspinkj', N'Glen Goldspink', N'A2h2IQRh5t73', N'ggoldspinkj@elpais.com', CAST(N'2001-06-09' AS Date), NULL)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'ggrieveson9', N'Gallagher Grieveson', N'XCWMEFPmi', N'ggrieveson9@hp.com', CAST(N'1984-05-28' AS Date), NULL)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'isidgwick2', N'Iain Sidgwick', N'twfl35Yt47', N'isidgwick2@bigcartel.com', CAST(N'1993-01-27' AS Date), NULL)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'kannetts0', N'Konstanze Annetts', N'Po0AhlbdNl3', N'kannetts0@tiny.cc', CAST(N'1998-09-05' AS Date), NULL)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'lguilfoylec', N'Laural Guilfoyle', N'UwsdbC9gISf', N'lguilfoylec@spotify.com', CAST(N'1994-04-10' AS Date), NULL)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'lhenrieb', N'Loella Henrie', N'thkCTaMATJ', N'lhenrieb@vinaora.com', CAST(N'2002-03-07' AS Date), NULL)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'lrogers6', N'Leon Rogers', N'i9NK9dvc0vaG', N'lrogers6@flickr.com', CAST(N'2005-03-25' AS Date), NULL)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'nbointonh', N'Nickie Bointon', N'tecK8VQEm4c', N'nbointonh@washingtonpost.com', CAST(N'1984-01-30' AS Date), NULL)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'podooghaine1', N'Pamella O''Dooghaine', N'ZZNXzgn', N'podooghaine1@indiegogo.com', CAST(N'2001-10-08' AS Date), NULL)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'rpeizer3', N'Rayner Peizer', N'hdSAtyJPf', N'rpeizer3@home.pl', CAST(N'1986-01-11' AS Date), NULL)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'sbaitmana', N'Salomone Baitman', N'klPMihD5', N'sbaitmana@tiny.cc', CAST(N'1994-09-12' AS Date), NULL)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'tgerok8', N'Theodoric Gerok', N'2rmPKS', N'tgerok8@storify.com', CAST(N'1998-11-29' AS Date), NULL)
INSERT [dbo].[Account] ([username], [full_name], [password], [email], [dob], [club_id]) VALUES (N'tjanczyk4', N'Trudie Janczyk', N'Mnwyc6TgBM8', N'tjanczyk4@csmonitor.com', CAST(N'2003-08-01' AS Date), NULL)
GO
SET IDENTITY_INSERT [dbo].[Card] ON 

INSERT [dbo].[Card] ([player_id], [match_id], [card_time], [card_type], [card_id]) VALUES (41, 7, 30, 0, 6)
SET IDENTITY_INSERT [dbo].[Card] OFF
GO
SET IDENTITY_INSERT [dbo].[Club] ON 

INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (1, N'MANCHESTER UNITED', N'1878', 6, N'Manchester', N'Sir Matt Busby Way', 1, N'mu.png')
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (2, N'NEWCASTLE', N'1892', 6, N'Newcastle upon Tyne
', N'St. James'' Street', 2, N'newcastle.png')
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (3, N'WATFORD', N'1881', 6, N'Watford', N'Vicarage Road', 3, N'watford.png')
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (4, N'WOLVES', N'1877', 6, N'Wolverhampton, West Midlands', N'Waterloo Road', 4, N'wolves.png')
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (5, N'LIVERPOOL', N'1892', 6, N'Liverpool', N'Anfield Road', 5, N'liverpool.png')
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (20, N'MANCHESTER UNITED
', N'1878', 6, N'Manchester', N'Sir Matt Busby Way', 1, N'mu.png')
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (21, N'NEWCASTLE', N'1892', 6, N'Newcastle upon Tyne
', N'St. James'' Street', 2, N'newcastle.png')
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (22, N'WATFORD', N'1881', 6, N'Watford', N'Vicarage Road', 3, N'watford.png')
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (23, N'WOLVES', N'1877', 6, N'Wolverhampton, West Midlands', N'Waterloo Road', 4, N'wolves.png')
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (24, N'LIVERPOOL', N'1892', 6, N'
Liverpool', N'
Anfield Road', 5, N'liverpool.png')
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (25, N'SOUTHAMPTON', N'1885', 6, N'Southampton', N'St. Mary''s', 1, N'2.jpg')
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (26, N'Arsenal', N'1886', 6, N'Arsenal', N'Emirates', 2, NULL)
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (27, N'Burnley', N'1886', 6, N'Burnley', N'Turf Moor', 3, NULL)
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (28, N'Everton', N'1878', 6, N'Everton', N'Goodison Park', 4, NULL)
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (29, N'Leicester', N'1881', 6, N'Leicester', N'King Power', 5, NULL)
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (30, N'Tottenham', N'1882', 6, N'Tottenham', N'Tottenham Hotspur', 1, NULL)
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (31, N'West Ham', N'1881', 6, N'West Ham', N'London ', 2, NULL)
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (32, N'Chelsea', N'1892', 6, N'Chelsea', N'Stamford Bridge', 3, NULL)
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (33, N'	Manchester City', N'1880', 6, N'	Manchester City', N'Etihad', 4, NULL)
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (34, N'Brighton', N'1892', 6, N'Brighton', N'The American Express Community', 5, NULL)
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (35, N'Crystal Palace', N'1892', 6, N'Crystal Palace', N'	Selhurst Park', 1, NULL)
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (36, N'Brentford', N'1892', 6, N'Brentford', N'	Brentford Community', 2, NULL)
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (37, N'Leeds', N'1892', 6, N'Leeds', N'	Elland Road', 3, NULL)
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (38, N'Aston Villa', N'1892', 6, N'Aston Villa', N'Villa Park', 4, NULL)
INSERT [dbo].[Club] ([club_id], [name], [year_created], [country_id], [city], [address], [stadium_id], [logo_url]) VALUES (39, N'NORWICH', N'1892', 6, N'Norwich', N'Carrow Road', 5, N'2.jpg')
SET IDENTITY_INSERT [dbo].[Club] OFF
GO
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (1, N'Albania', N'ALB')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (2, N'Austria', N'AUT')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (3, N'Belgium', N'BEL')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (4, N'Croatia', N'CRO')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (5, N'Czech Republic
', N'CZE	')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (6, N'England', N'ENG')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (7, N'France', N'FRA')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (8, N'Germany', N'GER')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (9, N'Hungary', N'HUN')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (10, N'Iceland', N'ISL')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (11, N'Italy', N'ITA')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (12, N'Northern Ireland
', N'NIR')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (13, N'Poland', N'POL')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (14, N'Portugal', N'POR')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (15, N'Republic of Ireland
', N'IRL')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (16, N'Romania', N'ROU')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (17, N'Russia', N'RUS')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (18, N'Slovakia', N'SVK')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (19, N'Spain', N'ESP')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (20, N'Sweden', N'SWE')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (21, N'Switzerland', N'SUI')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (22, N'Turkey', N'TUR')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (23, N'Ukraine', N'UKR')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (24, N'Wales', N'WAL')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (25, N'Slovenia', N'SLO')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (26, N'Netherlands', N'NED')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (27, N'Serbia', N'SRB')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (28, N'Scotland', N'SCO')
INSERT [dbo].[Country] ([country_id], [name], [short_name]) VALUES (29, N'Norway', N'NOR')
SET IDENTITY_INSERT [dbo].[Country] OFF
GO
SET IDENTITY_INSERT [dbo].[Goal] ON 

INSERT [dbo].[Goal] ([goal_id], [match_id], [player_id], [goal_time]) VALUES (4, 4, 42, 60)
INSERT [dbo].[Goal] ([goal_id], [match_id], [player_id], [goal_time]) VALUES (5, 5, 41, 60)
INSERT [dbo].[Goal] ([goal_id], [match_id], [player_id], [goal_time]) VALUES (6, 7, 41, 50)
SET IDENTITY_INSERT [dbo].[Goal] OFF
GO
SET IDENTITY_INSERT [dbo].[Match] ON 

INSERT [dbo].[Match] ([match_id], [play_date], [host_id], [guest_id], [referee_id], [tourseason_id], [play_stage], [venue_id]) VALUES (2, CAST(N'2022-03-11T02:30:00.000' AS DateTime), 1, 3, 4, 1, N'G', 1)
INSERT [dbo].[Match] ([match_id], [play_date], [host_id], [guest_id], [referee_id], [tourseason_id], [play_stage], [venue_id]) VALUES (3, CAST(N'2022-03-11T02:45:00.000' AS DateTime), 2, 1, 5, 1, N'G', 4)
INSERT [dbo].[Match] ([match_id], [play_date], [host_id], [guest_id], [referee_id], [tourseason_id], [play_stage], [venue_id]) VALUES (4, CAST(N'2022-03-11T02:30:00.000' AS DateTime), 3, 4, 5, 1, N'G', 7)
INSERT [dbo].[Match] ([match_id], [play_date], [host_id], [guest_id], [referee_id], [tourseason_id], [play_stage], [venue_id]) VALUES (5, CAST(N'2022-03-11T02:30:00.000' AS DateTime), 3, 1, 7, 1, N'G', 5)
INSERT [dbo].[Match] ([match_id], [play_date], [host_id], [guest_id], [referee_id], [tourseason_id], [play_stage], [venue_id]) VALUES (6, CAST(N'2022-03-12T19:30:00.000' AS DateTime), 1, 5, 6, 1, N'G', 8)
INSERT [dbo].[Match] ([match_id], [play_date], [host_id], [guest_id], [referee_id], [tourseason_id], [play_stage], [venue_id]) VALUES (7, CAST(N'2022-03-10T23:32:31.000' AS DateTime), 3, 1, 19, NULL, N'G', 3)
INSERT [dbo].[Match] ([match_id], [play_date], [host_id], [guest_id], [referee_id], [tourseason_id], [play_stage], [venue_id]) VALUES (8, CAST(N'2022-03-10T23:34:05.000' AS DateTime), 2, 1, 3, NULL, N'G', 4)
INSERT [dbo].[Match] ([match_id], [play_date], [host_id], [guest_id], [referee_id], [tourseason_id], [play_stage], [venue_id]) VALUES (9, CAST(N'2022-03-25T23:35:15.000' AS DateTime), 2, 20, 14, NULL, N'G', 2)
INSERT [dbo].[Match] ([match_id], [play_date], [host_id], [guest_id], [referee_id], [tourseason_id], [play_stage], [venue_id]) VALUES (10, CAST(N'2022-03-24T23:37:30.000' AS DateTime), 5, 3, 19, NULL, N'R', 3)
INSERT [dbo].[Match] ([match_id], [play_date], [host_id], [guest_id], [referee_id], [tourseason_id], [play_stage], [venue_id]) VALUES (11, CAST(N'2022-03-26T00:00:53.000' AS DateTime), 2, 4, 20, NULL, N'S', 4)
INSERT [dbo].[Match] ([match_id], [play_date], [host_id], [guest_id], [referee_id], [tourseason_id], [play_stage], [venue_id]) VALUES (12, CAST(N'2022-03-26T08:44:14.000' AS DateTime), 5, 3, 3, NULL, N'G', 1)
SET IDENTITY_INSERT [dbo].[Match] OFF
GO
INSERT [dbo].[Match_Result] ([match_id], [club_id], [win_lose], [goal_score], [shots], [ontarget], [control], [fouls], [corners], [offsides], [play_stage]) VALUES (2, 1, N'D', 0, 6, 4, 4, 4, 3, 3, NULL)
INSERT [dbo].[Match_Result] ([match_id], [club_id], [win_lose], [goal_score], [shots], [ontarget], [control], [fouls], [corners], [offsides], [play_stage]) VALUES (2, 3, N'D', 0, 3, 3, 4, 3, 3, 3, NULL)
INSERT [dbo].[Match_Result] ([match_id], [club_id], [win_lose], [goal_score], [shots], [ontarget], [control], [fouls], [corners], [offsides], [play_stage]) VALUES (3, 1, N'D', 0, 4, 2, 70, 3, 3, 3, NULL)
INSERT [dbo].[Match_Result] ([match_id], [club_id], [win_lose], [goal_score], [shots], [ontarget], [control], [fouls], [corners], [offsides], [play_stage]) VALUES (3, 2, N'D', 0, 4, 2, 30, 3, 4, 4, NULL)
INSERT [dbo].[Match_Result] ([match_id], [club_id], [win_lose], [goal_score], [shots], [ontarget], [control], [fouls], [corners], [offsides], [play_stage]) VALUES (4, 3, N'W', 1, 3, 3, 50, 2, 3, 2, NULL)
INSERT [dbo].[Match_Result] ([match_id], [club_id], [win_lose], [goal_score], [shots], [ontarget], [control], [fouls], [corners], [offsides], [play_stage]) VALUES (4, 4, N'L', 0, 4, 1, 50, 2, 5, 4, NULL)
INSERT [dbo].[Match_Result] ([match_id], [club_id], [win_lose], [goal_score], [shots], [ontarget], [control], [fouls], [corners], [offsides], [play_stage]) VALUES (5, 1, N'D', 0, 5, 3, 60, 3, 3, 3, NULL)
INSERT [dbo].[Match_Result] ([match_id], [club_id], [win_lose], [goal_score], [shots], [ontarget], [control], [fouls], [corners], [offsides], [play_stage]) VALUES (5, 3, N'D', 0, 4, 4, 40, 3, 4, 3, NULL)
INSERT [dbo].[Match_Result] ([match_id], [club_id], [win_lose], [goal_score], [shots], [ontarget], [control], [fouls], [corners], [offsides], [play_stage]) VALUES (6, 1, N'D', 0, 5, 5, 80, 3, 4, 3, NULL)
INSERT [dbo].[Match_Result] ([match_id], [club_id], [win_lose], [goal_score], [shots], [ontarget], [control], [fouls], [corners], [offsides], [play_stage]) VALUES (6, 5, N'D', 0, 4, 2, 20, 2, 4, 3, NULL)
GO
SET IDENTITY_INSERT [dbo].[Player] ON 

INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (6, N'CRISTIANO RONALDO', N'2000', 1, N'ST', N'165', N'70', N'a2.jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (9, N'EMMANUEL BONAVENT', N'2000', 1, N'CB', N'160', N'75', N'a4.jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (10, N'Mason Greenwood', N'1-1-1', 1, N'GK', N'165', N'70', N'a5.jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (11, N'PHILIPPE COUTINHO', N'1-1-1', 1, N'GK', N'165', N'70', N'a16.jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (12, N'DIOGO JOTA', N'1967', 1, N'LB', N'169', N'69', N'a7.jpg', 32)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (13, N'Jamie Vardy', N'1-1-1', 1, N'GK', N'165', N'70', N'a8.jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (14, N'Son Heung-min', N'1-1-1', 1, N'GK', N'165', N'70', N'a9.jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (15, N'Harry Kane', N'1-1-1', 1, N'GK', N'165', N'60', N'a10.jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (17, N'DAVID DE GEA', N'1994', 2, N'CB', N'185', N'80', N'a6.jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (18, N'ERIC BAILLY', N'1994', 3, N'CB', N'183', N'76', N'a2.jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (19, N'PHIL JONES', N'1992', 4, N'GK', N'185', N'85', N'2.jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (20, N'Harry Maguire', N'1993', 4, N'CB', N'190', N'85', N'a14.jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (21, N'Paul Pogba', N'1993', 5, N'CM', N'185', N'75', N'a15.jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (22, N'Cristiano Ronaldo', N'1985', 6, N'CF', N'185', N'78', N'a16.jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (23, N'Juan Mata', N'1988', 1, N'CF', N'180', N'75', N'a17.jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (24, N'Anthony Martial', N'1995', 5, N'CF', N'180', N'75', N'a18.jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (25, N'Marcus Rashford', N'1997', 4, N'CF', N'183', N'73', N'a19.jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (26, N'Mason Greenwood', N'2001', 4, N'CF', N'185', N'75', N'a20.jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (27, N'Alisson Becker', N'92', 7, N'GK', N'190', N'75', N'a21.jpg', 2)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (28, N'Fabinho', N'1993', 7, N'DM', N'180', N'70', N'', 2)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (29, N'Virgil van Dijk', N'1991', 8, N'CB', N'190', N'80', N'', 2)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (30, N'Ibrahima Konaté', N'1999', 5, N'CM', N'180', N'75', N'', 2)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (31, N' Thiago Alcântara ', N'1991', 1, N'CM', N'180', N'75', N'', 2)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (32, N'James Milner', N'1986', 4, N'DM', N'180', N'80', N'', 2)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (33, N'NABY KEÏTA', N'1995', 9, N'LS', N'180', N'70', N'download (1).jpg', 1)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (34, N'Roberto Firmino', N'1991', 7, N'CF', N'180', N'75', N'', 2)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (35, N'Sadio Mané', N'1992', 10, N'CF', N'170', N'70', N'', 2)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (36, N'Mohamed Salah', N'1992', 11, N'CF', N'175', N'73', N'', 2)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (37, N'Trent Alexander-Arnold', N'1998', 4, N'RF', N'180', N'75', N'', 2)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (38, N'Kepa Arrizabalaga Revuelta', N'1999', 4, N'GK', N'190', N'75', N'', 3)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (39, N'Marcos Alonso Mendoza', N'1992', 4, N'CB', N'190', N'76', N'', 3)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (40, N'Hakim Ziyech', N'1994', 5, N'CM', N'184', N'76', N'', 3)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (41, N'Robert Kenedy Nunes do Nascimento', N'1993', 5, N'CB', N'187', N'74', N'', 3)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (42, N'	Édouard Mendy', N'1993', 10, N'GK', N'190', N'76', N'', 3)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (43, N'Ben Chilwell', N'1993', 4, N'LF', N'178', N'75', N'', 3)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (44, N'Antonio Rüdiger', N'1994', 4, N'RF', N'190', N'80', N'', 3)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (45, N'Kai Lukas Havertz', N'1997', 12, N'CF', N'185', N'73', N'', 3)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (46, N'Emerson Palmieri dos Santos', N'1998', 13, N'CF', N'190', N'80', N'', 3)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (47, N'	Reece James', N'1994', 4, N'CM', N'187', N'77', N'', 3)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (48, N'	Mateo Kovačić', N'1994', 14, N'CM', N'180', N'77', N'', 3)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (49, N'Ederson Santana de Moraes', N'1994', 7, N'GK', N'190', N'77', N'', 4)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (50, N'Rúben dos Santos Gato Alves Dias', N'1994', 4, N'CB', N'188', N'77', N'', 4)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (51, N'Kevin De Bruyne', N'1992', 5, N'CM', N'183', N'78', N'', 4)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (52, N'Philip Foden', N'1996', 4, N'LF', N'174', N'70', N'', 4)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (53, N'Ferran Torres García', N'1995', 5, N'DM', N'176', N'67', N'', 4)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (54, N'Liam Delap', N'1992', 7, N'CF', N'175', N'70', N'', 4)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (55, N'	Bernardo Mota Veiga de Carvalho e Silva', N'1990', 5, N'CF', N'176', N'80', N'', 4)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (58, N'	Aymeric Laporte', N'1994', 5, N'CM', N'178', N'74', N'', 4)
INSERT [dbo].[Player] ([player_id], [name], [dob], [country_id], [position_id], [height], [weight], [image], [club_id]) VALUES (59, N'João Pedro Cavaco Cancelo', N'1993', 3, N'CF', N'180', N'75', N'', 4)
SET IDENTITY_INSERT [dbo].[Player] OFF
GO
INSERT [dbo].[Playing_Position] ([position_id], [name]) VALUES (N'CB', N'Trung vệ')
INSERT [dbo].[Playing_Position] ([position_id], [name]) VALUES (N'CF', N'Tiền đạo trung tâm')
INSERT [dbo].[Playing_Position] ([position_id], [name]) VALUES (N'CM', N'Tiền vệ trung tâm')
INSERT [dbo].[Playing_Position] ([position_id], [name]) VALUES (N'DM', N'Tiền vệ phòng ngự')
INSERT [dbo].[Playing_Position] ([position_id], [name]) VALUES (N'GK', N'Thủ môn')
INSERT [dbo].[Playing_Position] ([position_id], [name]) VALUES (N'LB', N'Hậu vệ trái')
INSERT [dbo].[Playing_Position] ([position_id], [name]) VALUES (N'LF', N'Tiền đạo cánh trái')
INSERT [dbo].[Playing_Position] ([position_id], [name]) VALUES (N'LM', N'Tiền vệ trái')
INSERT [dbo].[Playing_Position] ([position_id], [name]) VALUES (N'LS', N'Hậu vệ trái')
INSERT [dbo].[Playing_Position] ([position_id], [name]) VALUES (N'LWB', N'Hậu vệ chạy cánh trái')
INSERT [dbo].[Playing_Position] ([position_id], [name]) VALUES (N'RB', N'Hậu vệ phải')
INSERT [dbo].[Playing_Position] ([position_id], [name]) VALUES (N'RF', N'Tiền đạo cánh phải')
INSERT [dbo].[Playing_Position] ([position_id], [name]) VALUES (N'RM', N'Tiền vệ phải')
INSERT [dbo].[Playing_Position] ([position_id], [name]) VALUES (N'RS', N'Hậu vệ phải')
INSERT [dbo].[Playing_Position] ([position_id], [name]) VALUES (N'RWB', N'Hậu vệ chạy cánh phải')
INSERT [dbo].[Playing_Position] ([position_id], [name]) VALUES (N'ST', N'Tiền đạo cắm')
INSERT [dbo].[Playing_Position] ([position_id], [name]) VALUES (N'SW', N'Trung vệ thòng')
GO
INSERT [dbo].[Rate] ([rateId], [rateName]) VALUES (1, N'ratkhonghailong')
INSERT [dbo].[Rate] ([rateId], [rateName]) VALUES (2, N'khonghailong')
INSERT [dbo].[Rate] ([rateId], [rateName]) VALUES (3, N'binhthuong')
INSERT [dbo].[Rate] ([rateId], [rateName]) VALUES (4, N'hailong')
INSERT [dbo].[Rate] ([rateId], [rateName]) VALUES (5, N'rathailong')
GO
SET IDENTITY_INSERT [dbo].[Referee] ON 

INSERT [dbo].[Referee] ([referee_id], [referee_name], [country_id], [dob], [image], [year_started]) VALUES (3, N'Damir Skomina', 2, CAST(N'2001-01-01' AS Date), N'a1.jpg', 1998)
INSERT [dbo].[Referee] ([referee_id], [referee_name], [country_id], [dob], [image], [year_started]) VALUES (4, N'Martin Atkinson', 2, CAST(N'2001-01-01' AS Date), N'a9.jpg', 12)
INSERT [dbo].[Referee] ([referee_id], [referee_name], [country_id], [dob], [image], [year_started]) VALUES (5, N'Felix Brych', 10, CAST(N'2001-01-01' AS Date), N'2.jpg', 7)
INSERT [dbo].[Referee] ([referee_id], [referee_name], [country_id], [dob], [image], [year_started]) VALUES (6, N'Cuneyt Cakir', 9, CAST(N'2001-01-01' AS Date), N'408175.jpg', 2014)
INSERT [dbo].[Referee] ([referee_id], [referee_name], [country_id], [dob], [image], [year_started]) VALUES (7, N'Mark Clattenburg', 8, CAST(N'2001-01-01' AS Date), N'a2.jpg', 2015)
INSERT [dbo].[Referee] ([referee_id], [referee_name], [country_id], [dob], [image], [year_started]) VALUES (8, N'Jonas Eriksson', 2, CAST(N'2001-01-01' AS Date), N'a3.jpg', 8)
INSERT [dbo].[Referee] ([referee_id], [referee_name], [country_id], [dob], [image], [year_started]) VALUES (9, N'Viktor Kassai', 14, CAST(N'2001-01-01' AS Date), N'a1.jpg', 2014)
INSERT [dbo].[Referee] ([referee_id], [referee_name], [country_id], [dob], [image], [year_started]) VALUES (10, N'Bjorn Kuipers', 4, CAST(N'2001-01-01' AS Date), N'a1.jpg', 2012)
INSERT [dbo].[Referee] ([referee_id], [referee_name], [country_id], [dob], [image], [year_started]) VALUES (11, N'Szymon Marciniak', 2, CAST(N'2001-01-01' AS Date), N'a1.jpg', 2020)
INSERT [dbo].[Referee] ([referee_id], [referee_name], [country_id], [dob], [image], [year_started]) VALUES (12, N'Milorad Mazic', 5, CAST(N'2001-01-01' AS Date), N'a11.jpg', 2)
INSERT [dbo].[Referee] ([referee_id], [referee_name], [country_id], [dob], [image], [year_started]) VALUES (13, N'Nicola Rizzoli', 1, CAST(N'2001-01-01' AS Date), N'a1.jpg', 2012)
INSERT [dbo].[Referee] ([referee_id], [referee_name], [country_id], [dob], [image], [year_started]) VALUES (14, N'Carlos Velasco Carballo', 6, CAST(N'2001-01-01' AS Date), N'a1.jpg', 2020)
INSERT [dbo].[Referee] ([referee_id], [referee_name], [country_id], [dob], [image], [year_started]) VALUES (15, N'William Collum', 15, CAST(N'2001-01-01' AS Date), N'a1.jpg', 2020)
INSERT [dbo].[Referee] ([referee_id], [referee_name], [country_id], [dob], [image], [year_started]) VALUES (16, N'Tien Dat', 7, CAST(N'2022-03-17' AS Date), N'a10.jpg', 2010)
INSERT [dbo].[Referee] ([referee_id], [referee_name], [country_id], [dob], [image], [year_started]) VALUES (18, N'David Dang', 3, CAST(N'2022-03-10' AS Date), N'a1.jpg', 1234)
INSERT [dbo].[Referee] ([referee_id], [referee_name], [country_id], [dob], [image], [year_started]) VALUES (19, N'David dANG', 4, CAST(N'2022-03-10' AS Date), N'a1.jpg', 12345)
INSERT [dbo].[Referee] ([referee_id], [referee_name], [country_id], [dob], [image], [year_started]) VALUES (20, N'BabyNoDoor', 7, CAST(N'2022-03-10' AS Date), NULL, 1990)
SET IDENTITY_INSERT [dbo].[Referee] OFF
GO
INSERT [dbo].[Role] ([role_id], [role_name]) VALUES (1, N'Admin')
INSERT [dbo].[Role] ([role_id], [role_name]) VALUES (2, N'User')
GO
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (1, N'dtd91')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'afussie5')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'asaurd')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'atantoni')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'brevane')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'ddresself')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'dpaolaccig')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'gboulter7')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'ggoldspinkj')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'ggrieveson9')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'isidgwick2')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'kannetts0')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'lguilfoylec')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'lhenrieb')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'lrogers6')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'nbointonh')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'podooghaine1')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'rpeizer3')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'sbaitmana')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'tgerok8')
INSERT [dbo].[Role_Account] ([role_id], [username]) VALUES (2, N'tjanczyk4')
GO
SET IDENTITY_INSERT [dbo].[Stadium] ON 

INSERT [dbo].[Stadium] ([stadium_id], [name]) VALUES (1, N'Old Trafford')
INSERT [dbo].[Stadium] ([stadium_id], [name]) VALUES (2, N'St. James'' Park')
INSERT [dbo].[Stadium] ([stadium_id], [name]) VALUES (3, N'Vicarage Road')
INSERT [dbo].[Stadium] ([stadium_id], [name]) VALUES (4, N'Molineux Stadium')
INSERT [dbo].[Stadium] ([stadium_id], [name]) VALUES (5, N'Anfield')
SET IDENTITY_INSERT [dbo].[Stadium] OFF
GO
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (6, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (6, 3, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (9, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (9, 3, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (9, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (10, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (10, 3, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (10, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (11, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (11, 3, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (13, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (13, 3, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (13, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (14, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (14, 3, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (14, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (15, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (15, 3, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (15, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (17, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (17, 3, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (17, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (18, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (18, 3, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (18, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (19, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (19, 3, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (19, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (20, 2, 0)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (20, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (21, 2, 0)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (22, 2, 0)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (23, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (24, 3, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (25, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (26, 5, 0)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (33, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (38, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (38, 4, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (38, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (38, 7, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (39, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (39, 4, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (39, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (39, 7, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (40, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (40, 4, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (40, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (40, 7, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (41, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (41, 4, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (41, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (41, 7, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (42, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (42, 4, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (42, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (42, 7, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (43, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (43, 4, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (43, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (43, 7, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (44, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (44, 4, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (44, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (44, 7, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (45, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (45, 4, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (45, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (45, 7, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (46, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (46, 4, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (46, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (46, 7, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (47, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (47, 4, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (47, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (47, 7, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (48, 2, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (48, 4, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (48, 5, 1)
INSERT [dbo].[Team] ([player_id], [match_id], [starting]) VALUES (48, 7, 1)
GO
SET IDENTITY_INSERT [dbo].[Venue] ON 

INSERT [dbo].[Venue] ([venue_id], [name], [audience_capacity]) VALUES (1, N'Stade de Bordeaux	', 42115)
INSERT [dbo].[Venue] ([venue_id], [name], [audience_capacity]) VALUES (2, N'Stade Bollaert-Delelis', 38223)
INSERT [dbo].[Venue] ([venue_id], [name], [audience_capacity]) VALUES (3, N'Stade Pierre Mauroy', 49822)
INSERT [dbo].[Venue] ([venue_id], [name], [audience_capacity]) VALUES (4, N'Stade de Lyon', 58585)
INSERT [dbo].[Venue] ([venue_id], [name], [audience_capacity]) VALUES (5, N'	Stade VElodrome', 64354)
INSERT [dbo].[Venue] ([venue_id], [name], [audience_capacity]) VALUES (6, N'Stade de Nice', 35624)
INSERT [dbo].[Venue] ([venue_id], [name], [audience_capacity]) VALUES (7, N'Parc des Princes', 47294)
INSERT [dbo].[Venue] ([venue_id], [name], [audience_capacity]) VALUES (8, N'	Stade de France', 80100)
INSERT [dbo].[Venue] ([venue_id], [name], [audience_capacity]) VALUES (9, N'Stade Geoffroy Guichard', 42000)
INSERT [dbo].[Venue] ([venue_id], [name], [audience_capacity]) VALUES (10, N'Stadium de Toulouse', 33150)
SET IDENTITY_INSERT [dbo].[Venue] OFF
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Club] FOREIGN KEY([club_id])
REFERENCES [dbo].[Club] ([club_id])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Club]
GO
ALTER TABLE [dbo].[Card]  WITH CHECK ADD  CONSTRAINT [FK_Card_Match] FOREIGN KEY([match_id])
REFERENCES [dbo].[Match] ([match_id])
GO
ALTER TABLE [dbo].[Card] CHECK CONSTRAINT [FK_Card_Match]
GO
ALTER TABLE [dbo].[Card]  WITH CHECK ADD  CONSTRAINT [FK_Card_Player] FOREIGN KEY([player_id])
REFERENCES [dbo].[Player] ([player_id])
GO
ALTER TABLE [dbo].[Card] CHECK CONSTRAINT [FK_Card_Player]
GO
ALTER TABLE [dbo].[Club]  WITH CHECK ADD  CONSTRAINT [FK_Club_Country] FOREIGN KEY([country_id])
REFERENCES [dbo].[Country] ([country_id])
GO
ALTER TABLE [dbo].[Club] CHECK CONSTRAINT [FK_Club_Country]
GO
ALTER TABLE [dbo].[Club]  WITH CHECK ADD  CONSTRAINT [FK_Club_Stadiun] FOREIGN KEY([stadium_id])
REFERENCES [dbo].[Stadium] ([stadium_id])
GO
ALTER TABLE [dbo].[Club] CHECK CONSTRAINT [FK_Club_Stadiun]
GO
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_Rate] FOREIGN KEY([rateId])
REFERENCES [dbo].[Rate] ([rateId])
GO
ALTER TABLE [dbo].[Feedback] CHECK CONSTRAINT [FK_Feedback_Rate]
GO
ALTER TABLE [dbo].[Goal]  WITH CHECK ADD  CONSTRAINT [FK_Goal_Match] FOREIGN KEY([match_id])
REFERENCES [dbo].[Match] ([match_id])
GO
ALTER TABLE [dbo].[Goal] CHECK CONSTRAINT [FK_Goal_Match]
GO
ALTER TABLE [dbo].[Goal]  WITH CHECK ADD  CONSTRAINT [FK_Goal_Player] FOREIGN KEY([player_id])
REFERENCES [dbo].[Player] ([player_id])
GO
ALTER TABLE [dbo].[Goal] CHECK CONSTRAINT [FK_Goal_Player]
GO
ALTER TABLE [dbo].[Match]  WITH CHECK ADD  CONSTRAINT [FK_Match_Club] FOREIGN KEY([host_id])
REFERENCES [dbo].[Club] ([club_id])
GO
ALTER TABLE [dbo].[Match] CHECK CONSTRAINT [FK_Match_Club]
GO
ALTER TABLE [dbo].[Match]  WITH CHECK ADD  CONSTRAINT [FK_Match_Club1] FOREIGN KEY([guest_id])
REFERENCES [dbo].[Club] ([club_id])
GO
ALTER TABLE [dbo].[Match] CHECK CONSTRAINT [FK_Match_Club1]
GO
ALTER TABLE [dbo].[Match]  WITH CHECK ADD  CONSTRAINT [FK_Match_Referee] FOREIGN KEY([referee_id])
REFERENCES [dbo].[Referee] ([referee_id])
GO
ALTER TABLE [dbo].[Match] CHECK CONSTRAINT [FK_Match_Referee]
GO
ALTER TABLE [dbo].[Match]  WITH CHECK ADD  CONSTRAINT [FK_Match_Venue] FOREIGN KEY([venue_id])
REFERENCES [dbo].[Venue] ([venue_id])
GO
ALTER TABLE [dbo].[Match] CHECK CONSTRAINT [FK_Match_Venue]
GO
ALTER TABLE [dbo].[Match_Result]  WITH CHECK ADD  CONSTRAINT [FK_Match_Result_Club] FOREIGN KEY([club_id])
REFERENCES [dbo].[Club] ([club_id])
GO
ALTER TABLE [dbo].[Match_Result] CHECK CONSTRAINT [FK_Match_Result_Club]
GO
ALTER TABLE [dbo].[Match_Result]  WITH CHECK ADD  CONSTRAINT [FK_Match_Result_Match] FOREIGN KEY([match_id])
REFERENCES [dbo].[Match] ([match_id])
GO
ALTER TABLE [dbo].[Match_Result] CHECK CONSTRAINT [FK_Match_Result_Match]
GO
ALTER TABLE [dbo].[Player]  WITH CHECK ADD  CONSTRAINT [FK_Player_Playing_Position] FOREIGN KEY([position_id])
REFERENCES [dbo].[Playing_Position] ([position_id])
GO
ALTER TABLE [dbo].[Player] CHECK CONSTRAINT [FK_Player_Playing_Position]
GO
ALTER TABLE [dbo].[Ranking]  WITH CHECK ADD  CONSTRAINT [FK_Ranking_Club1] FOREIGN KEY([club_id])
REFERENCES [dbo].[Club] ([club_id])
GO
ALTER TABLE [dbo].[Ranking] CHECK CONSTRAINT [FK_Ranking_Club1]
GO
ALTER TABLE [dbo].[Referee]  WITH CHECK ADD  CONSTRAINT [FK_Referee_Country] FOREIGN KEY([country_id])
REFERENCES [dbo].[Country] ([country_id])
GO
ALTER TABLE [dbo].[Referee] CHECK CONSTRAINT [FK_Referee_Country]
GO
ALTER TABLE [dbo].[Role_Account]  WITH CHECK ADD  CONSTRAINT [FK_Role_Account_Account] FOREIGN KEY([username])
REFERENCES [dbo].[Account] ([username])
GO
ALTER TABLE [dbo].[Role_Account] CHECK CONSTRAINT [FK_Role_Account_Account]
GO
ALTER TABLE [dbo].[Role_Account]  WITH CHECK ADD  CONSTRAINT [FK_Role_Account_Role] FOREIGN KEY([role_id])
REFERENCES [dbo].[Role] ([role_id])
GO
ALTER TABLE [dbo].[Role_Account] CHECK CONSTRAINT [FK_Role_Account_Role]
GO
ALTER TABLE [dbo].[Team]  WITH CHECK ADD  CONSTRAINT [FK_Team_Match] FOREIGN KEY([match_id])
REFERENCES [dbo].[Match] ([match_id])
GO
ALTER TABLE [dbo].[Team] CHECK CONSTRAINT [FK_Team_Match]
GO
ALTER TABLE [dbo].[Team]  WITH CHECK ADD  CONSTRAINT [FK_Team_Player] FOREIGN KEY([player_id])
REFERENCES [dbo].[Player] ([player_id])
GO
ALTER TABLE [dbo].[Team] CHECK CONSTRAINT [FK_Team_Player]
GO
USE [master]
GO
ALTER DATABASE [QuanLyGiaiDauBongDa] SET  READ_WRITE 
GO
