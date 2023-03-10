USE [master]
GO
/****** Object:  Database [PP2023]    Script Date: 09/03/2023 11:46:56 a. m. ******/
CREATE DATABASE [PP2023]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PP2023', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PP2023.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PP2023_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PP2023_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PP2023] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PP2023].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PP2023] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PP2023] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PP2023] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PP2023] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PP2023] SET ARITHABORT OFF 
GO
ALTER DATABASE [PP2023] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PP2023] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PP2023] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PP2023] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PP2023] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PP2023] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PP2023] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PP2023] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PP2023] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PP2023] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PP2023] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PP2023] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PP2023] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PP2023] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PP2023] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PP2023] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PP2023] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PP2023] SET RECOVERY FULL 
GO
ALTER DATABASE [PP2023] SET  MULTI_USER 
GO
ALTER DATABASE [PP2023] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PP2023] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PP2023] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PP2023] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PP2023] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PP2023] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PP2023', N'ON'
GO
ALTER DATABASE [PP2023] SET QUERY_STORE = ON
GO
ALTER DATABASE [PP2023] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PP2023]
GO
/****** Object:  Table [dbo].[Director]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Director](
	[idDirector] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[activo] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[idMovie] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](255) NOT NULL,
	[idWriter] [int] NOT NULL,
	[idDirector] [int] NOT NULL,
	[idProducer] [int] NOT NULL,
	[available] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producer]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producer](
	[idProducer] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[activo] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[idUser] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](80) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
	[activo] [bit] NOT NULL,
	[SU] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Writer]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Writer](
	[idWriter] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[activo] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Directors_getAll]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Directors_getAll]

as
begin

select * from Director where activo = 1
end
GO
/****** Object:  StoredProcedure [dbo].[Movie_getByID]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Movie_getByID](
	@idMovie int
)
as
begin
	select * from Movies where idMovie = @idMovie
end
GO
/****** Object:  StoredProcedure [dbo].[Movies_Disable]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Movies_Disable] (
	@idMovie int
)
as

begin

UPDATE [dbo].[Movies]
   SET [available] = 0
 WHERE idMovie = @idMovie
end
GO
/****** Object:  StoredProcedure [dbo].[Movies_EditMovie]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Movies_EditMovie](
	@idMovie int,
	@title nvarchar(255),
	@idWriter int,
	@idDirector int,
	@idProducer int
)
as 

begin


UPDATE [dbo].[Movies]
   SET [title] = @title
      ,[idWriter] = @idWriter
      ,[idDirector] = @idDirector
      ,[idProducer] = @idProducer
 WHERE idMovie = @idMovie
end
GO
/****** Object:  StoredProcedure [dbo].[Movies_getALL]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Movies_getALL]

as 
begin
select * from Movies where available = 1
end
GO
/****** Object:  StoredProcedure [dbo].[Movies_newMovie]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Movies_newMovie](
	@title nvarchar(255),
	@idwriter int,
	@idDirector int,
	@idProducer int
)

as 
begin

INSERT INTO [dbo].[Movies]
           ([title]
           ,[idWriter]
           ,[idDirector]
           ,[idProducer]
           ,[available])
     VALUES
           (@title,
           @idwriter,
		   @idDirector,
		   @idProducer,
		   1)
end
GO
/****** Object:  StoredProcedure [dbo].[ProcedureName]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[ProcedureName] 
	
AS
BEGIN
	select m.idMovie, m.title, d.name AS Director, p.name AS Productor, w.name AS Writer
	from Movies m
	INNER JOIN director d ON m.idDirector = d.idDirector
INNER JOIN producer p ON m.idProducer = p.idProducer
INNER JOIN writer w ON w.idWriter = w.idWriter

END
GO
/****** Object:  StoredProcedure [dbo].[Producers_getAll]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Producers_getAll]

as
begin
select * from Producer where activo = 1
end
GO
/****** Object:  StoredProcedure [dbo].[Producers_getByID]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Producers_getByID](
	@idProducer int)
as begin
select * from Producer where idProducer = @idProducer
end
GO
/****** Object:  StoredProcedure [dbo].[Producers_newProducer]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Producers_newProducer](
	@name nvarchar(100)
	)
as begin
INSERT INTO Producer ([name], [activo]) values (@name, 1)
end
GO
/****** Object:  StoredProcedure [dbo].[Users_CheckAvailable]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Users_CheckAvailable]
(
	@username nvarchar(100)
)
as

begin
	select * from Users where username = @username
end
GO
/****** Object:  StoredProcedure [dbo].[Users_getIdByUser]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Users_getIdByUser]
(
	@username nvarchar(80)
)

as

begin
	select idUser from Users where username = @username
end
GO
/****** Object:  StoredProcedure [dbo].[Users_Login]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Users_Login]
(
	@username nvarchar(80),
	@pasword nvarchar(max)
)
as
begin

SELECT [idUser]
      ,[username]
      ,[password]
      ,[activo]
	  ,[SU]
  FROM [dbo].[Users] where username = @username and password = @pasword

end
GO
/****** Object:  StoredProcedure [dbo].[Users_NewPassword]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Users_NewPassword]
(
	@idUser int,
	@username nvarchar(80),
	@password nvarchar(max)
)

as

begin

UPDATE [dbo].[Users]
   SET [password] = @password
 WHERE username = @username and idUser = @idUser  
end 
GO
/****** Object:  StoredProcedure [dbo].[Users_NewUser]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Users_NewUser](
	@username nvarchar(80),
	@password nvarchar(max)
)
as
begin 

INSERT INTO [dbo].[Users]
           ([username]
           ,[password]
           ,[activo]
		   ,[SU])
     VALUES
           (@username,
		   @password,
		   1,
		   0)
end
GO
/****** Object:  StoredProcedure [dbo].[Writer_getALL]    Script Date: 09/03/2023 11:46:57 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Writer_getALL]

as

begin
select * from Writer where activo = 1
end
GO
USE [master]
GO
ALTER DATABASE [PP2023] SET  READ_WRITE 
GO
