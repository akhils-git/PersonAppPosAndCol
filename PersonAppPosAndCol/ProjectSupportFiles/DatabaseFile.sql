CREATE DATABASE [CDMS]
USE [CDMS]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 17-03-2021 09:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Left] [int] NOT NULL,
	[Top] [int] NOT NULL,
	[Color] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([ID], [Name], [Left], [Top], [Color], [Username], [Password]) VALUES (1, N'Sachin', 239, 153, N'-12582912', N'sachin', N'1234')
INSERT [dbo].[Person] ([ID], [Name], [Left], [Top], [Color], [Username], [Password]) VALUES (2, N'Akhil', 335, 266, N'-8372160', N'akhil', N'1234')
SET IDENTITY_INSERT [dbo].[Person] OFF
GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 17-03-2021 09:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Login]
	@Username	NVARCHAR(50)
	, @Password NVARCHAR(50)
AS
BEGIN
	SELECT 
		[ID]
      ,[Name]
      ,[Left]
      ,[Top]
      ,[Color]
      ,[Username]
      ,[Password]
	FROM [dbo].[Person]
	WHERE	Username	=	@Username
	AND		Password	=	@Password
END
GO
/****** Object:  StoredProcedure [dbo].[SetColor]    Script Date: 17-03-2021 09:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SetColor]
	@ID	INT
	,	@Color	NVARCHAR(10)
AS
BEGIN
	UPDATE [dbo].[Person] SET
	[Color]			=	@Color
	where ID		=	@ID

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateWindowPosition]    Script Date: 17-03-2021 09:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateWindowPosition]
	@ID	INT
	,	@Left	INT
	,	@Top	INT
AS
BEGIN
	UPDATE [dbo].[Person] SET
	[Left]			=	@Left
	,	[Top]		=	@Top
	where ID		=	@ID

END
GO
