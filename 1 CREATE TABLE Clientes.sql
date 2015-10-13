USE [Segpool]
GO

/****** Object:  Table [dbo].[Clientes]    Script Date: 09/02/2012 19:44:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Clientes](
	[idcliente] [int] NULL,
	[apellido] [varchar](50) NULL,
	[razonsocial] [varchar](100) NULL,
	[paginaweb] [varchar](100) NULL,

) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO



