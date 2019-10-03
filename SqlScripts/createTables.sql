USE [SYSFOOD]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Usuario](
	[UsuarioId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Codigo] [nchar](10) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PedidoItem](
	[PedidoItemId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[PedidoId] [numeric](18, 0) NULL,
	[ComidaId] [numeric](18, 0) NULL,
	[Precio] [decimal](18, 0) NULL,
 CONSTRAINT [PK_PedidoItem] PRIMARY KEY CLUSTERED 
(
	[PedidoItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Pedido](
	[PedidoId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[UsuarioId] [numeric](18, 0) NULL,
	[ClienteId] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[PedidoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Comprobante](
	[ComprobanteId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[UsuarioId] [numeric](18, 0) NULL,
	[ClienteId] [numeric](18, 0) NULL,
	[PedidoId] [numeric](18, 0) NULL,
	[Nombre] [nvarchar](50) NULL,
	[NitCI] [nvarchar](50) NULL,
	[Total] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Comprobante] PRIMARY KEY CLUSTERED 
(
	[ComprobanteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Cliente](
	[IdCliente] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [numeric](18, 0) NULL,
	[NitCI] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Comida](
	[ComidaId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Codigo] [nchar](10) NULL,
	[Precio] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Comida] PRIMARY KEY CLUSTERED 
(
	[ComidaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


