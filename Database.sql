USE [PP2023]
GO
/****** Object:  Table [dbo].[Director]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Director](
	[idDirector] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[activo] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[idMovie] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[title] [nvarchar](255) NOT NULL,
	[idWriter] [int] NOT NULL,
	[idDirector] [int] NOT NULL,
	[idProducer] [int] NOT NULL,
	[available] [bit] NOT NULL,
	[precio] [decimal](18, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producer]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producer](
	[idProducer] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[activo] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[idUser] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[total] [decimal](18, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShoppingCart]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoppingCart](
	[idCart] [int] IDENTITY(1,1) NOT NULL,
	[idUser] [int] NOT NULL,
	[idMovie] [int] NOT NULL,
	[precio] [decimal](18, 0) NOT NULL,
	[available] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[idUser] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
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
/****** Object:  Table [dbo].[Writer]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Writer](
	[idWriter] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[activo] [bit] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Movies] ADD  DEFAULT ((0)) FOR [precio]
GO
/****** Object:  StoredProcedure [dbo].[Directors_Add]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Directors_Add](
	@name nvarchar(100)
)
as 
begin

INSERT INTO [dbo].[Director]
           ([name]
           ,[activo])
     VALUES
           (@name
           ,1)
end
GO
/****** Object:  StoredProcedure [dbo].[Directors_Disable]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Directors_Disable](
	@idDirector int
)
as
begin
	
UPDATE [dbo].[Director]
   SET [activo] = 0
 WHERE idDirector = @idDirector
end
GO
/****** Object:  StoredProcedure [dbo].[Directors_Edit]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Directors_Edit](
	@name nvarchar(100),
	@idDirector int
)
as
begin
	
UPDATE [dbo].[Director]
   SET [name] = @name
 WHERE idDirector = @idDirector
end
GO
/****** Object:  StoredProcedure [dbo].[Directors_getAll]    Script Date: 24/05/2023 11:52:04 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Directors_getByID]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Directors_getByID](
	@idDirector int
)

as 
begin

SELECT [idDirector]
      ,[name]
      ,[activo]
  FROM [dbo].[Director] where idDirector = @idDirector and activo = 1
end
GO
/****** Object:  StoredProcedure [dbo].[FindUser]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[FindUser](
	@nombre nvarchar(100)
)
as 
begin 
	select idUser,username,activo from Users where username = @nombre
end





GO
/****** Object:  StoredProcedure [dbo].[Movie_getByID]    Script Date: 24/05/2023 11:52:04 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Movies_Disable]    Script Date: 24/05/2023 11:52:04 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Movies_EditMovie]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Movies_EditMovie](
	@idMovie int,
	@title nvarchar(255),
	@idWriter int,
	@idDirector int,
	@idProducer int,
	@precio decimal(18,0)
)
as 

begin


UPDATE [dbo].[Movies]
   SET [title] = @title
      ,[idWriter] = @idWriter
      ,[idDirector] = @idDirector
      ,[idProducer] = @idProducer
	  ,[precio] = @precio
 WHERE idMovie = @idMovie
end
GO
/****** Object:  StoredProcedure [dbo].[Movies_getALL]    Script Date: 24/05/2023 11:52:04 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Movies_newMovie]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Movies_newMovie](
	@title nvarchar(255),
	@idwriter int,
	@idDirector int,
	@idProducer int,
	@precio decimal(18,0)
)

as 
begin

INSERT INTO [dbo].[Movies]
           ([title]
           ,[idWriter]
           ,[idDirector]
           ,[idProducer]
           ,[available]
		   ,[precio])
     VALUES
           (@title,
           @idwriter,
		   @idDirector,
		   @idProducer,
		   1,
		   @precio)
end
GO
/****** Object:  StoredProcedure [dbo].[ProcedureName]    Script Date: 24/05/2023 11:52:04 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Producers_Disable]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Producers_Disable](
	@idProducer int
)
as
begin


UPDATE [dbo].[Producer]
   SET [activo] = 0
 WHERE idProducer = @idProducer
end
GO
/****** Object:  StoredProcedure [dbo].[Producers_EditProducer]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Producers_EditProducer](
 @id int,
 @name nvarchar(100)
)
as
begin

UPDATE [dbo].[Producer]
   SET [name] = @name
 WHERE idProducer = @id
end
GO
/****** Object:  StoredProcedure [dbo].[Producers_getAll]    Script Date: 24/05/2023 11:52:04 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Producers_getByID]    Script Date: 24/05/2023 11:52:04 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Producers_newProducer]    Script Date: 24/05/2023 11:52:04 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Sales_Add]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sales_Add]
(
	@idUser int,
	@fecha date,
	@total decimal
)
as
begin

INSERT INTO [dbo].[Sales]
           ([idUser]
           ,[fecha]
           ,[total])
     VALUES
           (@idUser
           ,@fecha
           ,@total)
end
GO
/****** Object:  StoredProcedure [dbo].[Sales_GetAll]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sales_GetAll]

as
begin

SELECT [idVenta]
      ,[idUser]
      ,[fecha]
      ,[total]
  FROM [dbo].[Sales]

end
GO
/****** Object:  StoredProcedure [dbo].[ShoppingCart_Add]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ShoppingCart_Add]
(
	@idUser int,
	@idMovie int,
	@precio decimal(18,0)
)
as
begin

	INSERT INTO [dbo].[ShoppingCart]
			   ([idUser]
			   ,[idMovie]
			   ,[precio]
			   ,[available])
		 VALUES
			   (@idUser
			   ,@idMovie
			   ,@precio
			   ,1)
end
GO
/****** Object:  StoredProcedure [dbo].[ShoppingCart_Disable]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ShoppingCart_Disable]
(
	@idCart int
)
as
begin

	UPDATE [dbo].[ShoppingCart]
	   SET[available] = 0
	 WHERE idCart = @idCart
end
GO
/****** Object:  StoredProcedure [dbo].[ShoppingCart_GetAll]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ShoppingCart_GetAll]
as
begin

SELECT [idCart]
      ,[idUser]
      ,[idMovie]
      ,[precio]
      ,[available]
  FROM [dbo].[ShoppingCart] where available = 1;
end
GO
/****** Object:  StoredProcedure [dbo].[ShoppingCart_SaleComplete]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ShoppingCart_SaleComplete]
(
	@idUser int
)
as
begin

	UPDATE [dbo].[ShoppingCart]
	   SET[available] = 0
	 WHERE idUser= @idUser And available = 1
end
GO
/****** Object:  StoredProcedure [dbo].[User_GetAll]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[User_GetAll]
as
begin
SELECT [idUser]
      ,[username]
  FROM [dbo].[Users]
end
GO
/****** Object:  StoredProcedure [dbo].[Users_CheckAvailable]    Script Date: 24/05/2023 11:52:04 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Users_getIdByUser]    Script Date: 24/05/2023 11:52:04 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Users_Login]    Script Date: 24/05/2023 11:52:04 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Users_NewPassword]    Script Date: 24/05/2023 11:52:04 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Users_NewUser]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Users_NewUser](
	@username nvarchar(80),
	@password nvarchar(max),
	@su bit
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
		   @su)
end
GO
/****** Object:  StoredProcedure [dbo].[Writer_Add]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Writer_Add](
	@name nvarchar(100)
)
as
begin
	
INSERT INTO [dbo].[Writer]
           ([name]
           ,[activo])
     VALUES
           (@name
           ,1)
End
GO
/****** Object:  StoredProcedure [dbo].[Writer_Drop]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Writer_Drop](
	@idWriter int
)
as
begin

UPDATE [dbo].[Writer]
   SET [activo] = 0
 WHERE idWriter = @idWriter

End
GO
/****** Object:  StoredProcedure [dbo].[Writer_Edit]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Writer_Edit](
	@name nvarchar(100),
	@idWriter int
)
as
begin

UPDATE [dbo].[Writer]
   SET [name] = @name
 WHERE idWriter = @idWriter

End
GO
/****** Object:  StoredProcedure [dbo].[Writer_getALL]    Script Date: 24/05/2023 11:52:04 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Writer_getByID]    Script Date: 24/05/2023 11:52:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Writer_getByID](
	@idWriter int
)
as
begin
	select * from Writer
	WHERE idWriter = @idWriter
End
GO
