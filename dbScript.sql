USE [master]
GO
/****** Object:  Database [dbStudent]    Script Date: 3/1/2019 8:54:22 PM ******/
CREATE DATABASE [dbStudent]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbStudent', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.DASHTECH\MSSQL\DATA\dbStudent.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbStudent_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.DASHTECH\MSSQL\DATA\dbStudent_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbStudent] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbStudent].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbStudent] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbStudent] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbStudent] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbStudent] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbStudent] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbStudent] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbStudent] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbStudent] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbStudent] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbStudent] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbStudent] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbStudent] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbStudent] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbStudent] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbStudent] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbStudent] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbStudent] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbStudent] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbStudent] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbStudent] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbStudent] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbStudent] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbStudent] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbStudent] SET  MULTI_USER 
GO
ALTER DATABASE [dbStudent] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbStudent] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbStudent] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbStudent] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbStudent] SET DELAYED_DURABILITY = DISABLED 
GO
USE [dbStudent]
GO
/****** Object:  Table [dbo].[adminMaster]    Script Date: 3/1/2019 8:54:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[adminMaster](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](20) NULL,
	[password] [varchar](15) NULL,
	[emailid] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[assignmentMaster]    Script Date: 3/1/2019 8:54:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[assignmentMaster](
	[aid] [int] IDENTITY(1,1) NOT NULL,
	[adate] [date] NULL,
	[aurl] [varchar](100) NULL,
	[subjectname] [varchar](100) NULL,
	[description] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[aid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[chatmaster]    Script Date: 3/1/2019 8:54:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[chatmaster](
	[cid] [int] IDENTITY(1,1) NOT NULL,
	[sendername] [varchar](100) NULL,
	[recivername] [varchar](100) NULL,
	[message] [varchar](200) NULL,
	[mdate] [date] NULL,
	[mtime] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[cid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[exammaster]    Script Date: 3/1/2019 8:54:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[exammaster](
	[eid] [int] IDENTITY(1,1) NOT NULL,
	[ename] [varchar](100) NULL,
	[edate] [date] NULL,
	[subjectname] [varchar](100) NULL,
	[egroup] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[eid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[facultymaster]    Script Date: 3/1/2019 8:54:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[facultymaster](
	[facid] [int] IDENTITY(1,1) NOT NULL,
	[facname] [varchar](20) NULL,
	[emailid] [varchar](100) NULL,
	[password] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[facid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[feedbackmaster]    Script Date: 3/1/2019 8:54:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[feedbackmaster](
	[fid] [int] IDENTITY(1,1) NOT NULL,
	[fdesc] [varchar](100) NULL,
	[fdate] [date] NULL,
	[fitme] [time](7) NULL,
	[femailid] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[fid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[studentMaster]    Script Date: 3/1/2019 8:54:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[studentMaster](
	[sid] [int] IDENTITY(1,1) NOT NULL,
	[sname] [varchar](20) NULL,
	[fname] [varchar](20) NULL,
	[lname] [varchar](20) NULL,
	[emailid] [varchar](100) NULL,
	[password] [varchar](20) NULL,
	[gender] [varchar](10) NULL,
	[image] [varchar](50) NULL,
	[college] [varchar](100) NULL,
	[country] [varchar](40) NULL,
	[state] [varchar](40) NULL,
	[city] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[sid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[adminMaster] ON 

INSERT [dbo].[adminMaster] ([id], [name], [password], [emailid]) VALUES (1, N'admin', N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[adminMaster] OFF
SET IDENTITY_INSERT [dbo].[exammaster] ON 

INSERT [dbo].[exammaster] ([eid], [ename], [edate], [subjectname], [egroup]) VALUES (1, N'Exame1', CAST(N'2019-01-01' AS Date), N'EC', N'Sem-1')
SET IDENTITY_INSERT [dbo].[exammaster] OFF
SET IDENTITY_INSERT [dbo].[facultymaster] ON 

INSERT [dbo].[facultymaster] ([facid], [facname], [emailid], [password]) VALUES (1, N'bhadresh', N'bhadresh@gmail.com', N'123')
SET IDENTITY_INSERT [dbo].[facultymaster] OFF
SET IDENTITY_INSERT [dbo].[studentMaster] ON 

INSERT [dbo].[studentMaster] ([sid], [sname], [fname], [lname], [emailid], [password], [gender], [image], [college], [country], [state], [city]) VALUES (1, N'prashant', N'Prashant', N'Varma', N'p@gmail.com', N'123', N'Male', N'image1.png', N'ETC', N'India', N'Gujrat', N'Ahmedabad')
SET IDENTITY_INSERT [dbo].[studentMaster] OFF
USE [master]
GO
ALTER DATABASE [dbStudent] SET  READ_WRITE 
GO
