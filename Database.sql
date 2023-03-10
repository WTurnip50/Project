USE [PP2023]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 03/03/2023 07:37:21 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Users_CheckAvailable]    Script Date: 03/03/2023 07:37:22 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Users_getIdByUser]    Script Date: 03/03/2023 07:37:22 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Users_Login]    Script Date: 03/03/2023 07:37:22 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Users_NewPassword]    Script Date: 03/03/2023 07:37:22 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[Users_NewUser]    Script Date: 03/03/2023 07:37:22 p. m. ******/
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
