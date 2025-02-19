USE [master]
GO
/****** Object:  Database [AvalonDB]    Script Date: 20/02/2025 12:00:16 a. m. ******/
CREATE DATABASE [AvalonDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AvalonDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEVJA\MSSQL\DATA\AvalonDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AvalonDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLDEVJA\MSSQL\DATA\AvalonDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AvalonDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AvalonDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AvalonDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AvalonDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AvalonDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AvalonDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AvalonDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [AvalonDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AvalonDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AvalonDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AvalonDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AvalonDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AvalonDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AvalonDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AvalonDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AvalonDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AvalonDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AvalonDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AvalonDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AvalonDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AvalonDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AvalonDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AvalonDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AvalonDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AvalonDB] SET RECOVERY FULL 
GO
ALTER DATABASE [AvalonDB] SET  MULTI_USER 
GO
ALTER DATABASE [AvalonDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AvalonDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AvalonDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AvalonDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AvalonDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AvalonDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AvalonDB', N'ON'
GO
ALTER DATABASE [AvalonDB] SET QUERY_STORE = OFF
GO
USE [AvalonDB]
GO
/****** Object:  Table [dbo].[banco]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[banco](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[nombreCorto] [varchar](10) NULL,
	[codigo] [varchar](4) NULL,
 CONSTRAINT [PK_banco] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[centroCostos]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[centroCostos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[nombreCorto] [varchar](15) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_centroCostos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clase]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clase](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[nombreCorto] [varchar](15) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_clase] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[condicionPago]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[condicionPago](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[estado] [bit] NULL,
	[dias] [int] NULL,
 CONSTRAINT [PK_condicionPago] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[familia]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[familia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[nombreCorto] [varchar](15) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_familia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menu]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[padre] [int] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_menu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menuXperfil]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menuXperfil](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idMenu] [int] NULL,
	[idPerfil] [int] NULL,
 CONSTRAINT [PK_menuXperfil] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[modulo]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[modulo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[orden] [int] NULL,
	[idMenu] [int] NULL,
 CONSTRAINT [PK_modulo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[perfil]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perfil](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombrePerfil] [varchar](50) NULL,
	[usuCrea] [varchar](20) NULL,
	[fechaCrea] [datetime] NULL,
 CONSTRAINT [PK_perfil] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigoProducto] [varchar](10) NULL,
	[nombreProducto] [varchar](200) NULL,
	[descripcionProducto] [varchar](8000) NULL,
	[codigoCliente] [varchar](30) NULL,
	[idUnidadMedida] [int] NULL,
	[idClase] [int] NULL,
	[idSubClase] [int] NULL,
	[idSubSubClase] [int] NULL,
	[idCentroCostos] [int] NULL,
	[idSubCentroCostos] [int] NULL,
	[idSubSubCentroCostos] [int] NULL,
	[idFamilia] [int] NULL,
	[idSubFamilia] [int] NULL,
	[ubicacion] [varchar](20) NULL,
	[esParaVenta] [bit] NULL,
	[esParaCompra] [bit] NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[servicio]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servicio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigoServicio] [varchar](10) NULL,
	[nombreServicio] [varchar](200) NULL,
	[descripcionServicio] [varchar](300) NULL,
	[idCentroCostos] [int] NULL,
	[idSubCentroCostos] [int] NULL,
	[idSubSubCentroCostos] [int] NULL,
	[esParaCompra] [bit] NULL,
	[esParaVenta] [bit] NULL,
 CONSTRAINT [PK_servicio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[socioNegocio]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[socioNegocio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipoSocio] [char](1) NULL,
	[codigoSocio] [varchar](15) NULL,
	[grupoSocio] [char](1) NULL,
	[idTipoDocumento] [int] NULL,
	[nroDocumento] [varchar](15) NULL,
	[razonSocial] [varchar](250) NULL,
	[telefono1] [varchar](20) NULL,
	[telefono2] [varchar](20) NULL,
	[email] [varchar](100) NULL,
	[direccionFiscal] [varchar](500) NULL,
	[direccionAlternativa] [varchar](500) NULL,
	[idCondicionPago] [int] NULL,
	[cuentaDetraccion] [varchar](30) NULL,
	[cuentaCorriente1] [varchar](30) NULL,
	[cuentaMoneda1] [varchar](2) NULL,
	[cuentaCodigoBanco1] [int] NULL,
	[cuentaCorriente2] [varchar](30) NULL,
	[cuentaMoneda2] [varchar](2) NULL,
	[cuentaCodigoBanco2] [int] NULL,
	[estado] [bit] NULL,
	[contacto1] [varchar](50) NULL,
	[telefonoContacto1] [varchar](20) NULL,
	[emailContacto1] [varchar](100) NULL,
	[contacto2] [varchar](50) NULL,
	[telefonoContacto2] [varchar](20) NULL,
	[emailContacto2] [varchar](100) NULL,
	[contacto3] [varchar](50) NULL,
	[telefonoContacto3] [varchar](20) NULL,
	[emailContacto3] [varchar](100) NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subCentroCostos]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subCentroCostos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idCentroCostos] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[nombreCorto] [varchar](15) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_subCentroCostos] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[idCentroCostos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subClase]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subClase](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idClase] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[nombreCorto] [varchar](15) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_subClase] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[idClase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subFamilia]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subFamilia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idFamilia] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[nombreCorto] [varchar](15) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_subFamilia] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[idFamilia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subSubCentroCostos]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subSubCentroCostos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idCentroCostos] [int] NOT NULL,
	[idSubCentroCostos] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[nombreCorto] [varchar](15) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_subSubCentroCostos] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[idCentroCostos] ASC,
	[idSubCentroCostos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subSubClase]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subSubClase](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idClase] [int] NOT NULL,
	[idSubClase] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[nombreCorto] [varchar](15) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_subSubClase] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[idClase] ASC,
	[idSubClase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipoDocumentoIdentidad]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoDocumentoIdentidad](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
 CONSTRAINT [PK_tipoDocumentoIdentidad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[unidadMedida]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unidadMedida](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[siglas] [varchar](6) NULL,
	[codSunat] [varchar](4) NULL,
 CONSTRAINT [PK_unidadMedida] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](150) NULL,
	[nomUsu] [varchar](20) NULL,
	[password] [varchar](max) NULL,
	[cambioPassword] [bit] NULL,
	[estado] [bit] NULL,
	[usuCrea] [varchar](20) NULL,
	[fechaCrea] [datetime] NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarioXperfil]    Script Date: 20/02/2025 12:00:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarioXperfil](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NULL,
	[idPerfil] [int] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_usuarioXperfil] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[clase] ON 

INSERT [dbo].[clase] ([id], [nombre], [nombreCorto], [estado]) VALUES (1, N'Clase 1', NULL, 1)
INSERT [dbo].[clase] ([id], [nombre], [nombreCorto], [estado]) VALUES (2, N'Clase 2', NULL, 1)
SET IDENTITY_INSERT [dbo].[clase] OFF
GO
SET IDENTITY_INSERT [dbo].[condicionPago] ON 

INSERT [dbo].[condicionPago] ([id], [nombre], [estado], [dias]) VALUES (1, N'Contado', 1, 0)
INSERT [dbo].[condicionPago] ([id], [nombre], [estado], [dias]) VALUES (2, N'Factura 30 Dias', 1, 30)
INSERT [dbo].[condicionPago] ([id], [nombre], [estado], [dias]) VALUES (3, N'Factura 15 Dias', 1, 15)
SET IDENTITY_INSERT [dbo].[condicionPago] OFF
GO
SET IDENTITY_INSERT [dbo].[familia] ON 

INSERT [dbo].[familia] ([id], [nombre], [nombreCorto], [estado]) VALUES (1, N'familia1', NULL, 1)
INSERT [dbo].[familia] ([id], [nombre], [nombreCorto], [estado]) VALUES (2, N'familai2', NULL, 1)
INSERT [dbo].[familia] ([id], [nombre], [nombreCorto], [estado]) VALUES (3, N'familia3', NULL, 1)
SET IDENTITY_INSERT [dbo].[familia] OFF
GO
SET IDENTITY_INSERT [dbo].[menu] ON 

INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (1, N'Configuracion', NULL, 1)
INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (2, N'Mantenimiento Usuarios', 1, 1)
INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (3, N'Mantenimiento Perfiles', 1, 1)
INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (4, N'Asignacion Permisos por Perfil', 1, 1)
INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (5, N'Asignacion de Perfil', 1, 1)
INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (6, N'Monedas', 1, 1)
INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (7, N'Rutas Archivos', 1, 1)
INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (8, N'Tipo Documento Identidad', 1, 1)
INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (9, N'Periodos/Ejercicios', 1, 1)
INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (10, N'Maestros', NULL, 1)
INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (11, N'Socio de Negocio', 10, 1)
INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (12, N'Clientes', 10, 0)
INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (13, N'Productos', 10, 1)
INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (14, N'Servicios', 10, 1)
INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (15, N'Almacenes', 10, 1)
INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (16, N'Familias', 10, 1)
INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (17, N'Centro de Costos', 10, 1)
INSERT [dbo].[menu] ([id], [nombre], [padre], [estado]) VALUES (18, N'Inventario', NULL, 1)
SET IDENTITY_INSERT [dbo].[menu] OFF
GO
SET IDENTITY_INSERT [dbo].[menuXperfil] ON 

INSERT [dbo].[menuXperfil] ([id], [idMenu], [idPerfil]) VALUES (1, 1, 1)
INSERT [dbo].[menuXperfil] ([id], [idMenu], [idPerfil]) VALUES (2, 2, 1)
INSERT [dbo].[menuXperfil] ([id], [idMenu], [idPerfil]) VALUES (3, 3, 1)
INSERT [dbo].[menuXperfil] ([id], [idMenu], [idPerfil]) VALUES (4, 4, 1)
INSERT [dbo].[menuXperfil] ([id], [idMenu], [idPerfil]) VALUES (5, 5, 1)
INSERT [dbo].[menuXperfil] ([id], [idMenu], [idPerfil]) VALUES (6, 6, 1)
INSERT [dbo].[menuXperfil] ([id], [idMenu], [idPerfil]) VALUES (7, 7, 1)
INSERT [dbo].[menuXperfil] ([id], [idMenu], [idPerfil]) VALUES (8, 8, 1)
INSERT [dbo].[menuXperfil] ([id], [idMenu], [idPerfil]) VALUES (9, 9, 1)
INSERT [dbo].[menuXperfil] ([id], [idMenu], [idPerfil]) VALUES (10, 10, 1)
INSERT [dbo].[menuXperfil] ([id], [idMenu], [idPerfil]) VALUES (11, 11, 1)
INSERT [dbo].[menuXperfil] ([id], [idMenu], [idPerfil]) VALUES (12, 12, 1)
INSERT [dbo].[menuXperfil] ([id], [idMenu], [idPerfil]) VALUES (13, 13, 1)
INSERT [dbo].[menuXperfil] ([id], [idMenu], [idPerfil]) VALUES (14, 14, 1)
INSERT [dbo].[menuXperfil] ([id], [idMenu], [idPerfil]) VALUES (15, 15, 1)
INSERT [dbo].[menuXperfil] ([id], [idMenu], [idPerfil]) VALUES (16, 16, 1)
INSERT [dbo].[menuXperfil] ([id], [idMenu], [idPerfil]) VALUES (17, 17, 1)
SET IDENTITY_INSERT [dbo].[menuXperfil] OFF
GO
SET IDENTITY_INSERT [dbo].[modulo] ON 

INSERT [dbo].[modulo] ([id], [orden], [idMenu]) VALUES (1, 1, 1)
INSERT [dbo].[modulo] ([id], [orden], [idMenu]) VALUES (2, 2, 10)
INSERT [dbo].[modulo] ([id], [orden], [idMenu]) VALUES (3, 3, 18)
SET IDENTITY_INSERT [dbo].[modulo] OFF
GO
SET IDENTITY_INSERT [dbo].[perfil] ON 

INSERT [dbo].[perfil] ([id], [nombrePerfil], [usuCrea], [fechaCrea]) VALUES (1, N'Administrador', N'jacho', CAST(N'2025-01-29T00:00:00.000' AS DateTime))
INSERT [dbo].[perfil] ([id], [nombrePerfil], [usuCrea], [fechaCrea]) VALUES (2, N'Almacenero', N'jacho', CAST(N'2025-01-29T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[perfil] OFF
GO
SET IDENTITY_INSERT [dbo].[producto] ON 

INSERT [dbo].[producto] ([id], [codigoProducto], [nombreProducto], [descripcionProducto], [codigoCliente], [idUnidadMedida], [idClase], [idSubClase], [idSubSubClase], [idCentroCostos], [idSubCentroCostos], [idSubSubCentroCostos], [idFamilia], [idSubFamilia], [ubicacion], [esParaVenta], [esParaCompra]) VALUES (1, N'P0025', N'Producto Demo 1', N'Aca va la descripcion del producto', N'699', 1, 1, 1, 1, NULL, NULL, NULL, 1, 1, N'Zona 3', 0, 1)
INSERT [dbo].[producto] ([id], [codigoProducto], [nombreProducto], [descripcionProducto], [codigoCliente], [idUnidadMedida], [idClase], [idSubClase], [idSubSubClase], [idCentroCostos], [idSubCentroCostos], [idSubSubCentroCostos], [idFamilia], [idSubFamilia], [ubicacion], [esParaVenta], [esParaCompra]) VALUES (2, N'P0026', N'Producto demo 2', N'Ortra Descricipcion', N'85525', 2, 2, 4, 4, NULL, NULL, NULL, 1, 1, N'Zona1', 1, 1)
SET IDENTITY_INSERT [dbo].[producto] OFF
GO
SET IDENTITY_INSERT [dbo].[socioNegocio] ON 

INSERT [dbo].[socioNegocio] ([id], [tipoSocio], [codigoSocio], [grupoSocio], [idTipoDocumento], [nroDocumento], [razonSocial], [telefono1], [telefono2], [email], [direccionFiscal], [direccionAlternativa], [idCondicionPago], [cuentaDetraccion], [cuentaCorriente1], [cuentaMoneda1], [cuentaCodigoBanco1], [cuentaCorriente2], [cuentaMoneda2], [cuentaCodigoBanco2], [estado], [contacto1], [telefonoContacto1], [emailContacto1], [contacto2], [telefonoContacto2], [emailContacto2], [contacto3], [telefonoContacto3], [emailContacto3]) VALUES (3, N'P', N'P10441476308', N'N', 1, N'10441476308', N'Proveedor de demo modificado', N'111', N'222', N'333', N'444444444444444444444', N'una direccion alternativa', 1, NULL, N'', NULL, NULL, N'', NULL, NULL, 1, N'rrrr', N'ffff', N'ttttt', N'xxxx', N'', N'', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[socioNegocio] OFF
GO
SET IDENTITY_INSERT [dbo].[subClase] ON 

INSERT [dbo].[subClase] ([id], [idClase], [nombre], [nombreCorto], [estado]) VALUES (1, 1, N'C1_Sub1', NULL, 1)
INSERT [dbo].[subClase] ([id], [idClase], [nombre], [nombreCorto], [estado]) VALUES (2, 1, N'C1_Sub2', NULL, 1)
INSERT [dbo].[subClase] ([id], [idClase], [nombre], [nombreCorto], [estado]) VALUES (3, 1, N'C1_Sub3', NULL, 1)
INSERT [dbo].[subClase] ([id], [idClase], [nombre], [nombreCorto], [estado]) VALUES (4, 2, N'C2_Sub1', NULL, 1)
INSERT [dbo].[subClase] ([id], [idClase], [nombre], [nombreCorto], [estado]) VALUES (5, 2, N'C2_Sub2', NULL, 1)
SET IDENTITY_INSERT [dbo].[subClase] OFF
GO
SET IDENTITY_INSERT [dbo].[subFamilia] ON 

INSERT [dbo].[subFamilia] ([id], [idFamilia], [nombre], [nombreCorto], [estado]) VALUES (1, 1, N'subFamilia1', NULL, 1)
INSERT [dbo].[subFamilia] ([id], [idFamilia], [nombre], [nombreCorto], [estado]) VALUES (2, 1, N'subFamilia2', NULL, 1)
INSERT [dbo].[subFamilia] ([id], [idFamilia], [nombre], [nombreCorto], [estado]) VALUES (3, 2, N'subFamilia3', NULL, 1)
INSERT [dbo].[subFamilia] ([id], [idFamilia], [nombre], [nombreCorto], [estado]) VALUES (4, 3, N'subFamilia4', NULL, 1)
INSERT [dbo].[subFamilia] ([id], [idFamilia], [nombre], [nombreCorto], [estado]) VALUES (5, 3, N'subFamilia5', NULL, 1)
SET IDENTITY_INSERT [dbo].[subFamilia] OFF
GO
SET IDENTITY_INSERT [dbo].[subSubClase] ON 

INSERT [dbo].[subSubClase] ([id], [idClase], [idSubClase], [nombre], [nombreCorto], [estado]) VALUES (1, 1, 1, N'A', NULL, 1)
INSERT [dbo].[subSubClase] ([id], [idClase], [idSubClase], [nombre], [nombreCorto], [estado]) VALUES (2, 1, 1, N'B', NULL, 1)
INSERT [dbo].[subSubClase] ([id], [idClase], [idSubClase], [nombre], [nombreCorto], [estado]) VALUES (3, 1, 2, N'C', NULL, 1)
INSERT [dbo].[subSubClase] ([id], [idClase], [idSubClase], [nombre], [nombreCorto], [estado]) VALUES (4, 2, 4, N'D', NULL, 1)
INSERT [dbo].[subSubClase] ([id], [idClase], [idSubClase], [nombre], [nombreCorto], [estado]) VALUES (5, 2, 5, N'E', NULL, 1)
SET IDENTITY_INSERT [dbo].[subSubClase] OFF
GO
SET IDENTITY_INSERT [dbo].[tipoDocumentoIdentidad] ON 

INSERT [dbo].[tipoDocumentoIdentidad] ([id], [nombre]) VALUES (1, N'DNI')
INSERT [dbo].[tipoDocumentoIdentidad] ([id], [nombre]) VALUES (2, N'CE')
INSERT [dbo].[tipoDocumentoIdentidad] ([id], [nombre]) VALUES (3, N'RUC')
INSERT [dbo].[tipoDocumentoIdentidad] ([id], [nombre]) VALUES (4, N'OTR')
SET IDENTITY_INSERT [dbo].[tipoDocumentoIdentidad] OFF
GO
SET IDENTITY_INSERT [dbo].[unidadMedida] ON 

INSERT [dbo].[unidadMedida] ([id], [nombre], [siglas], [codSunat]) VALUES (1, N'Kilogramo', N'KG', NULL)
INSERT [dbo].[unidadMedida] ([id], [nombre], [siglas], [codSunat]) VALUES (2, N'Metro', N'M', NULL)
INSERT [dbo].[unidadMedida] ([id], [nombre], [siglas], [codSunat]) VALUES (3, N'Gramo', N'GR', NULL)
INSERT [dbo].[unidadMedida] ([id], [nombre], [siglas], [codSunat]) VALUES (4, N'Unidad', N'C62', NULL)
SET IDENTITY_INSERT [dbo].[unidadMedida] OFF
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([id], [nombre], [nomUsu], [password], [cambioPassword], [estado], [usuCrea], [fechaCrea]) VALUES (1, N'Javier Acho Mamani', N'jacho', N'BibG2tZouoRgCt/z0PBRKw==', 0, 0, NULL, CAST(N'2025-02-10T23:39:35.883' AS DateTime))
INSERT [dbo].[usuario] ([id], [nombre], [nomUsu], [password], [cambioPassword], [estado], [usuCrea], [fechaCrea]) VALUES (2, N'Administrador TI', N'manager', N'baNM5ntSjavr0IEPByx0MQ==', 0, 0, NULL, CAST(N'2025-01-28T23:39:15.137' AS DateTime))
INSERT [dbo].[usuario] ([id], [nombre], [nomUsu], [password], [cambioPassword], [estado], [usuCrea], [fechaCrea]) VALUES (3, N'Compras', N'compras1', N'XfevHUFu5L15aXACyzBtGw==', 0, 0, NULL, CAST(N'2025-01-28T23:40:33.983' AS DateTime))
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarioXperfil] ON 

INSERT [dbo].[usuarioXperfil] ([id], [idUsuario], [idPerfil], [estado]) VALUES (1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[usuarioXperfil] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_producto]    Script Date: 20/02/2025 12:00:17 a. m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_producto] ON [dbo].[producto]
(
	[codigoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_servicio]    Script Date: 20/02/2025 12:00:17 a. m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_servicio] ON [dbo].[servicio]
(
	[codigoServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_usuario]    Script Date: 20/02/2025 12:00:17 a. m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_usuario] ON [dbo].[usuario]
(
	[nomUsu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[menuXperfil]  WITH CHECK ADD  CONSTRAINT [FK_menuXperfil_menu] FOREIGN KEY([idMenu])
REFERENCES [dbo].[menu] ([id])
GO
ALTER TABLE [dbo].[menuXperfil] CHECK CONSTRAINT [FK_menuXperfil_menu]
GO
ALTER TABLE [dbo].[menuXperfil]  WITH CHECK ADD  CONSTRAINT [FK_menuXperfil_perfil] FOREIGN KEY([idPerfil])
REFERENCES [dbo].[perfil] ([id])
GO
ALTER TABLE [dbo].[menuXperfil] CHECK CONSTRAINT [FK_menuXperfil_perfil]
GO
ALTER TABLE [dbo].[modulo]  WITH CHECK ADD  CONSTRAINT [FK_modulo_menu] FOREIGN KEY([idMenu])
REFERENCES [dbo].[menu] ([id])
GO
ALTER TABLE [dbo].[modulo] CHECK CONSTRAINT [FK_modulo_menu]
GO
ALTER TABLE [dbo].[socioNegocio]  WITH CHECK ADD  CONSTRAINT [FK_proveedor_condicionPago] FOREIGN KEY([idCondicionPago])
REFERENCES [dbo].[condicionPago] ([id])
GO
ALTER TABLE [dbo].[socioNegocio] CHECK CONSTRAINT [FK_proveedor_condicionPago]
GO
ALTER TABLE [dbo].[socioNegocio]  WITH CHECK ADD  CONSTRAINT [FK_proveedor_tipoDocumentoIdentidad] FOREIGN KEY([idTipoDocumento])
REFERENCES [dbo].[tipoDocumentoIdentidad] ([id])
GO
ALTER TABLE [dbo].[socioNegocio] CHECK CONSTRAINT [FK_proveedor_tipoDocumentoIdentidad]
GO
ALTER TABLE [dbo].[subCentroCostos]  WITH CHECK ADD  CONSTRAINT [FK_subCentroCostos_centroCostos] FOREIGN KEY([idCentroCostos])
REFERENCES [dbo].[centroCostos] ([id])
GO
ALTER TABLE [dbo].[subCentroCostos] CHECK CONSTRAINT [FK_subCentroCostos_centroCostos]
GO
ALTER TABLE [dbo].[subClase]  WITH CHECK ADD  CONSTRAINT [FK_subClase_clase] FOREIGN KEY([idClase])
REFERENCES [dbo].[clase] ([id])
GO
ALTER TABLE [dbo].[subClase] CHECK CONSTRAINT [FK_subClase_clase]
GO
ALTER TABLE [dbo].[subFamilia]  WITH CHECK ADD  CONSTRAINT [FK_subFamilia_familia] FOREIGN KEY([idFamilia])
REFERENCES [dbo].[familia] ([id])
GO
ALTER TABLE [dbo].[subFamilia] CHECK CONSTRAINT [FK_subFamilia_familia]
GO
ALTER TABLE [dbo].[subSubCentroCostos]  WITH CHECK ADD  CONSTRAINT [FK_subSubCentroCostos_subCentroCostos] FOREIGN KEY([idSubCentroCostos], [idCentroCostos])
REFERENCES [dbo].[subCentroCostos] ([id], [idCentroCostos])
GO
ALTER TABLE [dbo].[subSubCentroCostos] CHECK CONSTRAINT [FK_subSubCentroCostos_subCentroCostos]
GO
ALTER TABLE [dbo].[subSubClase]  WITH CHECK ADD  CONSTRAINT [FK_subSubClase_subClase] FOREIGN KEY([idSubClase], [idClase])
REFERENCES [dbo].[subClase] ([id], [idClase])
GO
ALTER TABLE [dbo].[subSubClase] CHECK CONSTRAINT [FK_subSubClase_subClase]
GO
ALTER TABLE [dbo].[usuarioXperfil]  WITH CHECK ADD  CONSTRAINT [FK_usuarioXperfil_perfil] FOREIGN KEY([idPerfil])
REFERENCES [dbo].[perfil] ([id])
GO
ALTER TABLE [dbo].[usuarioXperfil] CHECK CONSTRAINT [FK_usuarioXperfil_perfil]
GO
ALTER TABLE [dbo].[usuarioXperfil]  WITH CHECK ADD  CONSTRAINT [FK_usuarioXperfil_usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[usuarioXperfil] CHECK CONSTRAINT [FK_usuarioXperfil_usuario]
GO
USE [master]
GO
ALTER DATABASE [AvalonDB] SET  READ_WRITE 
GO
