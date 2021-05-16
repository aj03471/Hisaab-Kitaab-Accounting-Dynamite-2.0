/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.1742)
    Source Database Engine Edition : Microsoft SQL Server Standard Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [USALS-2]    Script Date: 17-Feb-21 10:25:29 PM ******/
CREATE DATABASE [USALS-2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'USALS-2', FILENAME = N'D:\SQL_DATA\USALS-2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'USALS-2_log', FILENAME = N'D:\SQL_DATA\USALS-2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [USALS-2] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [USALS-2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [USALS-2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [USALS-2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [USALS-2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [USALS-2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [USALS-2] SET ARITHABORT OFF 
GO
ALTER DATABASE [USALS-2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [USALS-2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [USALS-2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [USALS-2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [USALS-2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [USALS-2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [USALS-2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [USALS-2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [USALS-2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [USALS-2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [USALS-2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [USALS-2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [USALS-2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [USALS-2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [USALS-2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [USALS-2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [USALS-2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [USALS-2] SET RECOVERY FULL 
GO
ALTER DATABASE [USALS-2] SET  MULTI_USER 
GO
ALTER DATABASE [USALS-2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [USALS-2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [USALS-2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [USALS-2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [USALS-2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [USALS-2] SET QUERY_STORE = OFF
GO
USE [USALS-2]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [USALS-2]
GO
/****** Object:  Table [dbo].[DBMenu]    Script Date: 17-Feb-21 10:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DBMenu](
	[MENU_ID] [bigint] NOT NULL,
	[MENU_DESCRIPTION] [nvarchar](255) NOT NULL,
	[MENU_CODE] [nchar](12) NULL,
 CONSTRAINT [PK_DBMenu] PRIMARY KEY CLUSTERED 
(
	[MENU_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DBProperties]    Script Date: 17-Feb-21 10:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DBProperties](
	[DB_ID] [bigint] NOT NULL,
	[DB_NAME] [nvarchar](255) NULL,
	[DB_START] [date] NULL,
	[DB_END] [date] NULL,
	[DB_COMPANYNAME] [nvarchar](max) NULL,
	[DB_COMPLOGO_PATH] [nvarchar](255) NULL,
	[DB_DBSTORAGE_PATH] [nvarchar](255) NULL,
	[DB_CNICRECORD_PATH] [nvarchar](255) NULL,
	[DB_BACKUPDATA_PATH] [nvarchar](255) NULL,
	[DB_PHOTORECORD_PATH] [nvarchar](255) NULL,
 CONSTRAINT [PK_DBProperties] PRIMARY KEY CLUSTERED 
(
	[DB_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DBUserRights]    Script Date: 17-Feb-21 10:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DBUserRights](
	[DB_ID] [bigint] NOT NULL,
	[USER_ID] [bigint] NOT NULL,
	[ACCESSTODB_ALLOWED] [nvarchar](255) NULL,
	[SUAUL_RIGHTS_ADD] [nvarchar](255) NULL,
	[SUAUL_RIGHTS_MODIFY] [nvarchar](255) NULL,
	[SUAUL_RIGHTS_REMOVE] [nvarchar](255) NULL,
	[SUAUL_RIGHTS_PRINT] [nvarchar](255) NULL,
	[ADS2_RIGHTS_ADD] [nvarchar](255) NULL,
	[ADS2_RIGHTS_MODIFY] [nvarchar](255) NULL,
	[ADS2_RIGHTS_REMOVE] [nvarchar](255) NULL,
	[ADS2_RIGHTS_PRINT] [nvarchar](255) NULL,
 CONSTRAINT [PK_DBUserRights] PRIMARY KEY CLUSTERED 
(
	[DB_ID] ASC,
	[USER_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DBUsers]    Script Date: 17-Feb-21 10:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DBUsers](
	[USER_ID] [bigint] NOT NULL,
	[USER_NAME] [nvarchar](255) NULL,
	[USER_PASSWORD] [nvarchar](255) NULL,
	[USER_PATH_PHOTO] [nvarchar](255) NULL,
	[USER_PATH_CNIC] [nvarchar](255) NULL,
	[USER_POSITION] [nvarchar](255) NULL,
	[USER_LOCATION] [nvarchar](255) NULL,
	[USER_ACCOPENDATE] [date] NULL,
	[USER_ACCOPENTIME] [time](7) NULL,
 CONSTRAINT [PK_DBUsers] PRIMARY KEY CLUSTERED 
(
	[USER_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersLogActivities]    Script Date: 17-Feb-21 10:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersLogActivities](
	[UserLogActivity_ID] [bigint] NOT NULL,
	[LOG_ID] [bigint] NULL,
	[MENU_ID] [bigint] NULL,
	[OLDACTHEAD_ID] [nchar](10) NULL,
	[NEWACTHEAD_ID] [nchar](10) NULL,
	[OLDTRANS_AMT] [nchar](10) NULL,
	[NEWTRANS_AMT] [nchar](10) NULL,
	[OLDALLOCATION_ID] [nchar](10) NULL,
	[NEWALLOCATION_ID] [nchar](10) NULL,
	[ALEDGER_ID] [nchar](10) NULL,
	[ILEDGER_ID] [nchar](10) NULL,
 CONSTRAINT [PK_UsersLogActivities] PRIMARY KEY CLUSTERED 
(
	[UserLogActivity_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersLogs]    Script Date: 17-Feb-21 10:25:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersLogs](
	[LOG_ID] [bigint] NOT NULL,
	[USER_ID] [bigint] NULL,
	[LOGIN_DATE] [date] NULL,
	[LOGIN_TIME] [time](7) NULL,
	[LOGOUT_DATE] [date] NULL,
	[LOGOUT_TIME] [time](7) NULL,
 CONSTRAINT [PK_UsersLogs] PRIMARY KEY CLUSTERED 
(
	[LOG_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DBUsers] ([USER_ID], [USER_NAME], [USER_PASSWORD], [USER_PATH_PHOTO], [USER_PATH_CNIC], [USER_POSITION], [USER_LOCATION], [USER_ACCOPENDATE], [USER_ACCOPENTIME]) VALUES (1, N'admin', N'admin', NULL, NULL, NULL, NULL, NULL, NULL)
ALTER TABLE [dbo].[DBUserRights]  WITH CHECK ADD  CONSTRAINT [FK_DBUserRights_DBProperties] FOREIGN KEY([DB_ID])
REFERENCES [dbo].[DBProperties] ([DB_ID])
GO
ALTER TABLE [dbo].[DBUserRights] CHECK CONSTRAINT [FK_DBUserRights_DBProperties]
GO
ALTER TABLE [dbo].[DBUserRights]  WITH CHECK ADD  CONSTRAINT [FK_DBUserRights_DBUsers] FOREIGN KEY([USER_ID])
REFERENCES [dbo].[DBUsers] ([USER_ID])
GO
ALTER TABLE [dbo].[DBUserRights] CHECK CONSTRAINT [FK_DBUserRights_DBUsers]
GO
ALTER TABLE [dbo].[UsersLogActivities]  WITH CHECK ADD  CONSTRAINT [FK_UsersLogActivities_DBMenu] FOREIGN KEY([MENU_ID])
REFERENCES [dbo].[DBMenu] ([MENU_ID])
GO
ALTER TABLE [dbo].[UsersLogActivities] CHECK CONSTRAINT [FK_UsersLogActivities_DBMenu]
GO
ALTER TABLE [dbo].[UsersLogActivities]  WITH CHECK ADD  CONSTRAINT [FK_UsersLogActivities_UsersLogs] FOREIGN KEY([LOG_ID])
REFERENCES [dbo].[UsersLogs] ([LOG_ID])
GO
ALTER TABLE [dbo].[UsersLogActivities] CHECK CONSTRAINT [FK_UsersLogActivities_UsersLogs]
GO
ALTER TABLE [dbo].[UsersLogs]  WITH CHECK ADD  CONSTRAINT [FK_UsersLogs_DBUsers] FOREIGN KEY([USER_ID])
REFERENCES [dbo].[DBUsers] ([USER_ID])
GO
ALTER TABLE [dbo].[UsersLogs] CHECK CONSTRAINT [FK_UsersLogs_DBUsers]
GO
USE [master]
GO
ALTER DATABASE [USALS-2] SET  READ_WRITE 
GO
