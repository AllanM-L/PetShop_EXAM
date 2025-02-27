USE [master]
GO
/****** Object:  Database [PetShopDB]    Script Date: 31/01/2025 15:33:03 ******/
CREATE DATABASE [PetShopDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PetShopDB', FILENAME = N'C:\SQLDatos\MSSQL16.SQLEXPRESS\MSSQL\DATA\PetShopDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PetShopDB_log', FILENAME = N'C:\SQLDatos\MSSQL16.SQLEXPRESS\MSSQL\DATA\PetShopDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PetShopDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PetShopDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PetShopDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PetShopDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PetShopDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PetShopDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PetShopDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [PetShopDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PetShopDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PetShopDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PetShopDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PetShopDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PetShopDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PetShopDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PetShopDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PetShopDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PetShopDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PetShopDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PetShopDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PetShopDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PetShopDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PetShopDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PetShopDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PetShopDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PetShopDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PetShopDB] SET  MULTI_USER 
GO
ALTER DATABASE [PetShopDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PetShopDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PetShopDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PetShopDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PetShopDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PetShopDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PetShopDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [PetShopDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PetShopDB]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 31/01/2025 15:33:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mascotas]    Script Date: 31/01/2025 15:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mascotas](
	[Id_Mascota] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
	[IdCliente] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Mascota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 31/01/2025 15:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Categoria] [nvarchar](50) NOT NULL,
	[Precio] [decimal](10, 2) NOT NULL,
	[Stock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 31/01/2025 15:33:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Total] [decimal](10, 2) NOT NULL,
	[Fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono]) VALUES (1, N'Allison', N'Manzanillas', N'0 98 389 8535')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono]) VALUES (2, N'Cristian', N'Montoya', N'0 98 500 7426')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Mascotas] ON 

INSERT [dbo].[Mascotas] ([Id_Mascota], [Nombre], [Tipo], [IdCliente]) VALUES (2, N'Romeo', N'Gato', 1)
INSERT [dbo].[Mascotas] ([Id_Mascota], [Nombre], [Tipo], [IdCliente]) VALUES (3, N'Conny', N'Perro', 2)
SET IDENTITY_INSERT [dbo].[Mascotas] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([Id_Producto], [Nombre], [Categoria], [Precio], [Stock]) VALUES (1, N'Cortador de uñas', N'Cosmeticos', CAST(5.00 AS Decimal(10, 2)), 30)
INSERT [dbo].[Productos] ([Id_Producto], [Nombre], [Categoria], [Precio], [Stock]) VALUES (2, N'Hueso de plastico', N'Juguetes', CAST(12.00 AS Decimal(10, 2)), 25)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Ventas] ON 

INSERT [dbo].[Ventas] ([Id], [IdCliente], [IdProducto], [Cantidad], [Total], [Fecha]) VALUES (1, 1, 1, 2, CAST(10.00 AS Decimal(10, 2)), CAST(N'2025-01-31T12:08:20.270' AS DateTime))
INSERT [dbo].[Ventas] ([Id], [IdCliente], [IdProducto], [Cantidad], [Total], [Fecha]) VALUES (2, 2, 2, 1, CAST(12.00 AS Decimal(10, 2)), CAST(N'2025-01-31T12:37:51.437' AS DateTime))
SET IDENTITY_INSERT [dbo].[Ventas] OFF
GO
ALTER TABLE [dbo].[Ventas] ADD  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[Mascotas]  WITH CHECK ADD FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([Id_cliente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([Id_cliente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([Id_Producto])
ON DELETE CASCADE
GO
USE [master]
GO
ALTER DATABASE [PetShopDB] SET  READ_WRITE 
GO
