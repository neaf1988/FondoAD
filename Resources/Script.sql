CREATE DATABASE [fondo];
GO
USE [fondo]
GO

/****** Object:  Table [dbo].[Persona]    Script Date: 12/17/2019 11:22:00 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Persona](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](100) NOT NULL,
	[Apellidos] [varchar](100) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NULL,
	[CorreoElectronico] [varchar](100) NOT NULL,
	[Activo] [bit] NOT NULL,
	[Banco] [varchar](50) NOT NULL,
	[NumeroCuenta] [varchar](50) NOT NULL,
	[Cedula] [varchar](50) NOT NULL,
	[MontoAhorro] [float] NOT NULL,
	[Afiliado] [bit] NOT NULL,
	[FechaNacimiento] [date] NULL,
	[Quincena] [tinyint] NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prestamo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonaId] [int] NOT NULL,
	[Valor] [float] NOT NULL,
	[Interes] [float] NOT NULL,
	[Fecha] [date] NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[Finalizado] [bit] NOT NULL,
 CONSTRAINT [PK_Prestamo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Prestamo] ADD  CONSTRAINT [DF_Prestamo_Finalizado]  DEFAULT ((0)) FOR [Finalizado]
GO

ALTER TABLE [dbo].[Prestamo]  WITH CHECK ADD  CONSTRAINT [FK_Prestamo_Persona] FOREIGN KEY([PersonaId])
REFERENCES [dbo].[Persona] ([Id])
GO

ALTER TABLE [dbo].[Prestamo] CHECK CONSTRAINT [FK_Prestamo_Persona]
GO
/****** Object:  Table [dbo].[Consignacion]    Script Date: 12/17/2019 11:21:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Consignacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonaId] [int] NOT NULL,
	[TipoConsignacion] [tinyint] NOT NULL,
	[Valor] [float] NULL,
	[Interes] [float] NULL,
	[Fecha] [date] NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[PrestamoId] [int] NULL,
 CONSTRAINT [PK_Consignacion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Consignacion]  WITH CHECK ADD  CONSTRAINT [FK_Consignacion_Persona] FOREIGN KEY([PersonaId])
REFERENCES [dbo].[Persona] ([Id])
GO

ALTER TABLE [dbo].[Consignacion] CHECK CONSTRAINT [FK_Consignacion_Persona]
GO

ALTER TABLE [dbo].[Consignacion]  WITH CHECK ADD  CONSTRAINT [FK_Consignacion_Prestamo] FOREIGN KEY([PrestamoId])
REFERENCES [dbo].[Prestamo] ([Id])
GO

ALTER TABLE [dbo].[Consignacion] CHECK CONSTRAINT [FK_Consignacion_Prestamo]
GO

/****** Object:  Table [dbo].[Parametros]    Script Date: 12/17/2019 11:21:51 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Parametros](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Valor1] [varchar](150) NOT NULL,
	[Valor2] [varchar](100) NULL,
 CONSTRAINT [PK_Parametros] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO