USE [PruebaNexTI]
GO

/****** Object:  Table [dbo].[Informacion_personas]    Script Date: 5/10/2023 2:08:22 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Informacion_personas]') AND type in (N'U'))
DROP TABLE [dbo].[Informacion_personas]
GO

/****** Object:  Table [dbo].[Informacion_personas]    Script Date: 5/10/2023 2:08:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Informacion_personas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[Cedula] [nvarchar](10) NULL,
	[Telefono] [nvarchar](10) NULL,
	[Correo] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
 CONSTRAINT [PK__Informac__3214EC27E4450F39] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


