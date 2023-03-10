USE [PP2023]
GO
/****** Object:  Table [dbo].[Director]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  Table [dbo].[Movies]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  Table [dbo].[Producer]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  Table [dbo].[Users]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  Table [dbo].[Writer]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Directors_getAll]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Movie_getByID]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Movies_getALL]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Movies_newMovie]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[ProcedureName]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Producers_getAll]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Producers_getByID]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Producers_newProducer]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Users_CheckAvailable]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Users_getIdByUser]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Users_Login]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Users_NewPassword]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Users_NewUser]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Writer_getALL]    Script Date: 07/03/2023 12:42:23 p. m. ******/
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
