USE [PruebaNexTI]
GO

ALTER TABLE [dbo].[Informacion] DROP CONSTRAINT [FK_Cedula]
GO

/****** Object:  Table [dbo].[Informacion]    Script Date: 5/10/2023 2:10:58 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Informacion]') AND type in (N'U'))
DROP TABLE [dbo].[Informacion]
GO

/****** Object:  Table [dbo].[Informacion]    Script Date: 5/10/2023 2:10:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Informacion](
	[Cedula] [nvarchar](10) NULL,
	[Telefono] [nvarchar](10) NULL,
	[Correo] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Informacion]  WITH CHECK ADD  CONSTRAINT [FK_Cedula] FOREIGN KEY([Cedula])
REFERENCES [dbo].[Persona] ([Cedula])
GO

ALTER TABLE [dbo].[Informacion] CHECK CONSTRAINT [FK_Cedula]
GO


