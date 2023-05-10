USE [PruebaNexTI]
GO

/****** Object:  Table [dbo].[Events]    Script Date: 5/10/2023 2:08:14 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Events]') AND type in (N'U'))
DROP TABLE [dbo].[Events]
GO

/****** Object:  Table [dbo].[Events]    Script Date: 5/10/2023 2:08:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Events](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaEvento] [datetime] NULL,
	[Lugar] [nvarchar](200) NULL,
	[NEntrada] [int] NULL,
	[Descripcion] [nvarchar](1000) NULL,
	[Precio] [decimal](18, 0) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


