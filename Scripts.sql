USE [master]
GO
/****** Object:  Database [TR]    Script Date: 14/03/2021 12:50:30 ******/
CREATE DATABASE [TR]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TR', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TR.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TR_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TR_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TR] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TR].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TR] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TR] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TR] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TR] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TR] SET ARITHABORT OFF 
GO
ALTER DATABASE [TR] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TR] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TR] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TR] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TR] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TR] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TR] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TR] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TR] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TR] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TR] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TR] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TR] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TR] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TR] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TR] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TR] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TR] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TR] SET  MULTI_USER 
GO
ALTER DATABASE [TR] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TR] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TR] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TR] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TR] SET DELAYED_DURABILITY = DISABLED 
GO
USE [TR]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[ProjectId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProjectName] [varchar](150) NULL,
	[ProjectDesc] [varchar](150) NULL,
	[ProjectStart] [date] NULL,
	[ProjectEnd] [date] NULL,
	[ProjectDeadline] [date] NULL,
	[TeaId] [int] NULL,
	[StatusID] [int] NULL,
 CONSTRAINT [pkProject] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectsDetails]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectsDetails](
	[DetailsId] [int] IDENTITY(1,1) NOT NULL,
	[Comments] [varchar](250) NOT NULL,
	[ProjectDate] [date] NULL,
	[StaId] [int] NULL,
 CONSTRAINT [pkProjectsDetails] PRIMARY KEY CLUSTERED 
(
	[DetailsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectStatus]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectStatus](
	[ProjectId] [bigint] NOT NULL,
	[StatusId] [int] NOT NULL,
 CONSTRAINT [pkProjectStatus] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC,
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusId] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [nvarchar](50) NULL,
	[StatusType] [char](1) NULL,
 CONSTRAINT [pkStatus] PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeamAssigns]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeamAssigns](
	[AssignId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
 CONSTRAINT [pkTeamAssigns] PRIMARY KEY CLUSTERED 
(
	[AssignId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teams]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teams](
	[TeamId] [int] IDENTITY(1,1) NOT NULL,
	[TeamName] [varchar](100) NOT NULL,
	[TeamDesc] [varchar](120) NULL,
	[TeamStatus] [bit] NULL,
 CONSTRAINT [pkTeams] PRIMARY KEY CLUSTERED 
(
	[TeamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [pkUsers] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[StatusOfProject]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[StatusOfProject] (@ProjectId BigInt) RETURNS Table AS
       RETURN 
SELECT ProjectId, StatusId StId
FROM ProjectStatus WHERE ProjectId=@ProjectId
GO
/****** Object:  UserDefinedFunction [dbo].[ProjectStatusName]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ProjectStatusName] (@ProjectId BigInt) Returns Table AS
       RETURN
SELECT ProjectId, StatusId StatusId,  StatusName StatusName
FROM Status LEFT OUTER JOIN dbo.StatusOfProject (@ProjectId) On StatusId = StId
GO
SET IDENTITY_INSERT [dbo].[Projects] ON 
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677876, N'hfghdd', N'gfgfhgg', CAST(N'2021-03-08' AS Date), CAST(N'2021-03-08' AS Date), CAST(N'2021-03-08' AS Date), 3, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677877, N'sdsdtst', N'xvxvxv', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677878, N'fdsfjshdfgsdhgfsdf', N'sfndjnfjnvmxnvmxnvxcv', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 6, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677879, N'zxvzxv', N'zvzvzv', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677880, N'cscsc', N'cscscscsc', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677881, N'dsf', N'sffs', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 4, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677882, N'rget', N'etetre', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677883, N'dasd', N'dadasd', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677884, N'asas', N'sadasd', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677885, N'cbvcbc', N'cbcb', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677886, N'sdad', N'dadad', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 7, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677887, N'zX', N'xzXz', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677888, N'asdad', N'adadadadad', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 7, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677889, N'asa', N'adadad', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 4, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677890, N'wrwr', N'rwrwr', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 6, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677891, N'towhid', N'tytytyty', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 4, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677892, N'adsf', N'sfsfsf', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 6, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677893, N'x', N'Xx', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 4, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677894, N'fsfsf', N'sdfsf', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677895, N'efsdf', N'sfsfsf', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677896, N'aDASD', N'ASDDAD', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 4, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677897, N'sscac', N'zczczczczc', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-06' AS Date), 4, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677898, N'xxzX', N'xXZXX', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 4, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677899, N'cxczc', N'zczc', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677900, N'zC', N'CC', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677920, N'xccz', N'xzczc', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677921, N'xzXz', N'zxzX', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 4, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677922, N'zczx', N'zxczc', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677923, N'X', N'xZx', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 6, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677924, N'cvxcv', N'vxcvxcvxcv', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677925, N'cxccx', N'czxczc', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 4, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677926, N'zxz', N'xzxzx', CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), CAST(N'2021-03-10' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677927, N'fsf', N'sdfsf', CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677928, N'szsc', N'czczczc', CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), 6, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677929, N'xzx', N'zxZX', CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), 6, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677930, N'Zzx', N'csczc', CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), 7, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677931, NULL, NULL, CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), 13, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677932, N'cxczx', N'zxcc', CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), 12, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677933, N'xczxc', N'czxczxczxc', CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), 12, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677934, N'zX', N'xx', CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), 4, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677935, N'zxczxc', N'czxcxczxczxc', CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), CAST(N'2021-03-11' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677936, N'sfsdf', N'sdfsdf', CAST(N'2021-03-13' AS Date), CAST(N'2021-03-13' AS Date), CAST(N'2021-03-13' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677937, N'xz', N'xzxzx', CAST(N'2021-03-13' AS Date), CAST(N'2021-03-13' AS Date), CAST(N'2021-03-13' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677938, N'sfas', N'asdasd', CAST(N'2021-03-14' AS Date), CAST(N'2021-03-14' AS Date), CAST(N'2021-03-14' AS Date), 4, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677939, N'xX', N'xasaSAsas', CAST(N'2021-03-14' AS Date), CAST(N'2021-03-14' AS Date), CAST(N'2021-03-14' AS Date), 5, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677940, N'ZXzx', N'zxZXzx', CAST(N'2021-03-14' AS Date), CAST(N'2021-03-14' AS Date), CAST(N'2021-03-14' AS Date), 12, 1)
GO
INSERT [dbo].[Projects] ([ProjectId], [ProjectName], [ProjectDesc], [ProjectStart], [ProjectEnd], [ProjectDeadline], [TeaId], [StatusID]) VALUES (677941, N'sdsfszf', N'fsfsfs', CAST(N'2021-03-14' AS Date), CAST(N'2021-03-14' AS Date), CAST(N'2021-03-14' AS Date), 12, 1)
GO
SET IDENTITY_INSERT [dbo].[Projects] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectsDetails] ON 
GO
INSERT [dbo].[ProjectsDetails] ([DetailsId], [Comments], [ProjectDate], [StaId]) VALUES (18, N'xczczczczczxc', CAST(N'2021-03-14' AS Date), 17)
GO
INSERT [dbo].[ProjectsDetails] ([DetailsId], [Comments], [ProjectDate], [StaId]) VALUES (19, N'ddsgdgsdg', CAST(N'2021-03-14' AS Date), 15)
GO
SET IDENTITY_INSERT [dbo].[ProjectsDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 
GO
INSERT [dbo].[Status] ([StatusId], [StatusName], [StatusType]) VALUES (14, N'as', N'1')
GO
INSERT [dbo].[Status] ([StatusId], [StatusName], [StatusType]) VALUES (15, N'node.js', N'1')
GO
INSERT [dbo].[Status] ([StatusId], [StatusName], [StatusType]) VALUES (16, N'ccs', N'1')
GO
INSERT [dbo].[Status] ([StatusId], [StatusName], [StatusType]) VALUES (17, N'sdSZ', N'1')
GO
INSERT [dbo].[Status] ([StatusId], [StatusName], [StatusType]) VALUES (18, N'xczxczxc', N'1')
GO
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[Teams] ON 
GO
INSERT [dbo].[Teams] ([TeamId], [TeamName], [TeamDesc], [TeamStatus]) VALUES (3, N'sdasd', N'sdasd', 1)
GO
INSERT [dbo].[Teams] ([TeamId], [TeamName], [TeamDesc], [TeamStatus]) VALUES (4, N'adad', N'asdad', 1)
GO
INSERT [dbo].[Teams] ([TeamId], [TeamName], [TeamDesc], [TeamStatus]) VALUES (5, N'czx', N'zczc', 1)
GO
INSERT [dbo].[Teams] ([TeamId], [TeamName], [TeamDesc], [TeamStatus]) VALUES (6, N'dfsf', N'sfsf', 1)
GO
INSERT [dbo].[Teams] ([TeamId], [TeamName], [TeamDesc], [TeamStatus]) VALUES (7, N'gggg', N'gdfg', 1)
GO
INSERT [dbo].[Teams] ([TeamId], [TeamName], [TeamDesc], [TeamStatus]) VALUES (10, N'z', N'XX', 1)
GO
INSERT [dbo].[Teams] ([TeamId], [TeamName], [TeamDesc], [TeamStatus]) VALUES (11, N'czxx', N'czxcx', 1)
GO
INSERT [dbo].[Teams] ([TeamId], [TeamName], [TeamDesc], [TeamStatus]) VALUES (12, N'asd', N'asd4', 1)
GO
INSERT [dbo].[Teams] ([TeamId], [TeamName], [TeamDesc], [TeamStatus]) VALUES (13, N'towhid', N'hh', 1)
GO
SET IDENTITY_INSERT [dbo].[Teams] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([UserId], [UserName], [Password]) VALUES (4, N'sdfs', N'ss')
GO
INSERT [dbo].[Users] ([UserId], [UserName], [Password]) VALUES (5, N'dsda', N'dsa')
GO
INSERT [dbo].[Users] ([UserId], [UserName], [Password]) VALUES (6, N'xczc', N'333')
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Projects] ADD  CONSTRAINT [DF__Projects__TeaId__30F848ED]  DEFAULT ((0)) FOR [TeaId]
GO
ALTER TABLE [dbo].[Projects]  WITH CHECK ADD  CONSTRAINT [fkProjectTea] FOREIGN KEY([TeaId])
REFERENCES [dbo].[Teams] ([TeamId])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[Projects] CHECK CONSTRAINT [fkProjectTea]
GO
ALTER TABLE [dbo].[ProjectsDetails]  WITH CHECK ADD  CONSTRAINT [fkProjectsDetailsSta] FOREIGN KEY([StaId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[ProjectsDetails] CHECK CONSTRAINT [fkProjectsDetailsSta]
GO
ALTER TABLE [dbo].[ProjectStatus]  WITH CHECK ADD  CONSTRAINT [fkProjectStatus_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Projects] ([ProjectId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProjectStatus] CHECK CONSTRAINT [fkProjectStatus_Project]
GO
ALTER TABLE [dbo].[ProjectStatus]  WITH CHECK ADD  CONSTRAINT [fkProjectStatus_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProjectStatus] CHECK CONSTRAINT [fkProjectStatus_Status]
GO
ALTER TABLE [dbo].[TeamAssigns]  WITH CHECK ADD  CONSTRAINT [fkTeamAssignsUs] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[TeamAssigns] CHECK CONSTRAINT [fkTeamAssignsUs]
GO
/****** Object:  StoredProcedure [dbo].[spAddProjects]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spAddProjects]
                 @ProjectName    varchar(150),
				 @ProjectDesc    varchar(150),
                 @ProjectStart Date,
				 @ProjectEnd Date,
				 @ProjectDeadline Date,
				
                 @TeaId     Int 
       AS
INSERT INTO dbo.Projects(ProjectName, ProjectDesc, ProjectStart,ProjectEnd,ProjectDeadline,TeaId,StatusID)
VALUES (@ProjectName, @ProjectDesc, @ProjectStart,@ProjectEnd,@ProjectDeadline,@TeaId,1)
GO
/****** Object:  StoredProcedure [dbo].[spAddProjectsDetails]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spAddProjectsDetails]
               
                 @Comments     varchar(250),
                
                 @ProjectDate date,
                 @StaId  int
AS
BEGIN
    INSERT INTO dbo.ProjectsDetails(Comments,ProjectDate,StaId)
    VALUES (@Comments, @ProjectDate,@StaId)
    
END
GO
/****** Object:  StoredProcedure [dbo].[spAddProjectStatus]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAddProjectStatus]
                 @ProjectId      BigInt, 
                 @StatusId  Int
                
       AS
INSERT INTO [dbo].[ProjectStatus]([ProjectId],[StatusId])
VALUES (@ProjectId, @StatusId)
GO
/****** Object:  StoredProcedure [dbo].[spAddStatus]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAddStatus]
                 @StatusName Nvarchar(50), 
                 @StatusType Char (1)
                
       AS
BEGIN    
   DECLARE @StatusId as smallint;
   INSERT  INTO Status([StatusName], [StatusType]) 
   VALUES  (@StatusName, @StatusType);
   SET     @StatusId = SCOPE_IDENTITY();  
END
GO
/****** Object:  StoredProcedure [dbo].[spAddTeamAssigns]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAddTeamAssigns]
              
               
                 @UserId     Int 
       AS
	   BEGIN
INSERT INTO dbo.TeamAssigns( UserId)
VALUES ( @UserId);
SELECT @UserId AS teamAssignsId;
END
GO
/****** Object:  StoredProcedure [dbo].[spAddTeams]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spAddTeams]
                 @TeamName VarChar(100), 
                 @TeamDesc VarChar(150), 
                 @TeamStatus bit
       AS
BEGIN    
   DECLARE @TeamId as Int;
   INSERT  INTO Teams([TeamName], [TeamDesc], [TeamStatus]) 
   VALUES  (@TeamName, @TeamDesc, @TeamStatus);
   SET     @TeamId = SCOPE_IDENTITY(); 
   SELECT @TeamId AS TeaId;
END
GO
/****** Object:  StoredProcedure [dbo].[spAddUsers]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAddUsers]
                 @UserName NVarChar(50), 
                 @Password NVarChar(50)
                 
       AS
BEGIN    
   DECLARE @UserId as Int;
   INSERT  INTO Users([UserName], [Password]) 
   VALUES  (@UserName, @Password);
   SET     @UserId = SCOPE_IDENTITY();  
   SELECT @UserId AS UsId;
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateProjects]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateProjects]
                 @ProjectId      Bigint, 
                 @ProjectName    varchar(150),
				 @ProjectDesc    varchar(150),
                 @ProjectStart Date,
				 @ProjectEnd Date,
				 @ProjectDeadline Date,
				
                 @TeaId     Int ,
				 @PK        BigInt
                 
       AS
UPDATE Projects 
SET [ProjectId]      = @ProjectId,
    [ProjectName]     = @ProjectName, 
    [ProjectDesc]   = @ProjectDesc,
    [ProjectStart]      = @ProjectStart,
	[ProjectEnd]   = @ProjectEnd,
	[ProjectDeadline]   = @ProjectDeadline,
	
    [TeaId]     = @TeaId
WHERE [ProjectId] = @PK
GO
/****** Object:  StoredProcedure [dbo].[spUpdateProjectsDetails]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateProjectsDetails]
                 @DetailsId      int,
                 @Comments     varchar(250),
                 
                 @ProjectDate date,
                 @StaId  int
AS
    UPDATE ProjectsDetails
    SET [Comments]     = @Comments,
      
        [ProjectDate] = @ProjectDate,
        [StaId]     = @StaId
    WHERE [DetailsId] = @DetailsId
GO
/****** Object:  StoredProcedure [dbo].[spUpdateProjectStatus]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateProjectStatus]
                 @ProjectId      BigInt, 
                 @StatusId  Int 
                 
       AS
UPDATE ProjectStatus
SET [StatusId] = @StatusId
WHERE [ProjectId] = @ProjectId and StatusId = @StatusId
GO
/****** Object:  StoredProcedure [dbo].[spUpdateStatus]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateStatus]
                 @StatusId    smallint, 
                 @StatusName Nvarchar(50), 
                  
                 @StatusType Char(1)
       AS
UPDATE Status 
SET [StatusName] = @StatusName, 
    [StatusType] = @StatusType
    
WHERE  [StatusId] = @StatusId
GO
/****** Object:  StoredProcedure [dbo].[spUpdateTeamAssigns]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateTeamAssigns]
                 @AssignId     int, 
               
                 @UserId     Int
                 
       AS
UPDATE TeamAssigns 
SET 
   
    [UserId]     = @UserId
WHERE [AssignId] = @AssignId
GO
/****** Object:  StoredProcedure [dbo].[spUpdateTeams]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateTeams]
                 @TeamId    Int, 
                 @TeamName VarChar(100), 
                 @TeamDesc VarChar(150), 
                 @TeamStatus bit
       AS
UPDATE Teams 
SET [TeamName] = @TeamName, 
    [TeamDesc] = @TeamDesc, 
    [TeamStatus] = @TeamStatus 
WHERE  [TeamId] = @TeamId
GO
/****** Object:  StoredProcedure [dbo].[spUpdateUsers]    Script Date: 14/03/2021 12:50:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateUsers]
                 @UserId    Int, 
                 @UserName NVarChar(50), 
                 @Password NVarChar(50) 
                 
       AS
UPDATE Users
SET [UserName] = @UserName, 
    [Password] = @Password 
    
WHERE  [UserId] = @UserId
GO
USE [master]
GO
ALTER DATABASE [TR] SET  READ_WRITE 
GO
