﻿USE [master]
GO

/****** Object:  Database [Control]    Script Date: 8/8/2020 4:47:07 PM ******/
CREATE DATABASE [Control]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Control', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Control.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Control_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Control_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Control] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Control].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Control] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Control] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Control] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Control] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Control] SET ARITHABORT OFF 
GO
ALTER DATABASE [Control] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Control] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Control] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Control] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Control] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Control] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Control] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Control] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Control] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Control] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Control] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Control] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Control] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Control] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Control] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Control] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Control] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Control] SET RECOVERY FULL 
GO
ALTER DATABASE [Control] SET  MULTI_USER 
GO
ALTER DATABASE [Control] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Control] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Control] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Control] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Control] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Control', N'ON'
GO
ALTER DATABASE [Control] SET QUERY_STORE = OFF
GO
USE [Control]
GO
/****** Object:  Table [dbo].[aula]    Script Date: 8/8/2020 4:47:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aula](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[aula] [varchar](50) NULL,
 CONSTRAINT [PK_aula] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[edificio]    Script Date: 8/8/2020 4:47:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[edificio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Edificio] [int] NULL,
 CONSTRAINT [PK_edificio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loginvisitas]    Script Date: 8/8/2020 4:47:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loginvisitas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[contraseña] [varchar](50) NOT NULL,
	[tipo_usuario] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[fecha] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[register]    Script Date: 8/8/2020 4:47:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[register](
	[Nombre] [varchar](50) NULL,
	[Appelido] [varchar](50) NULL,
	[Carrera] [varchar](50) NULL,
	[Correo] [varchar](50) NULL,
	[Edificio] [varchar](50) NULL,
	[Hora] [varchar](50) NULL,
	[Motivo] [varchar](50) NULL,
	[Aula] [varchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[visitas]    Script Date: 8/8/2020 4:47:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[visitas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[carrera] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[edificio] [int] NULL,
	[hora] [varchar](50) NULL,
	[motivo] [varchar](50) NULL,
	[aula] [varchar](50) NULL,
	[tipo_visita] [varchar](50) NULL,
 CONSTRAINT [PK_visitas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[aula] ON 

INSERT [dbo].[aula] ([id], [aula]) VALUES (19, N'Aula 1A')
INSERT [dbo].[aula] ([id], [aula]) VALUES (20, N'Aula 1B')
INSERT [dbo].[aula] ([id], [aula]) VALUES (21, N'Aula 4C')
INSERT [dbo].[aula] ([id], [aula]) VALUES (22, N'Aula 4-C')
SET IDENTITY_INSERT [dbo].[aula] OFF
SET IDENTITY_INSERT [dbo].[edificio] ON 

INSERT [dbo].[edificio] ([id], [Edificio]) VALUES (14, 1)
INSERT [dbo].[edificio] ([id], [Edificio]) VALUES (15, 1)
INSERT [dbo].[edificio] ([id], [Edificio]) VALUES (16, 5)
INSERT [dbo].[edificio] ([id], [Edificio]) VALUES (17, 5)
SET IDENTITY_INSERT [dbo].[edificio] OFF
SET IDENTITY_INSERT [dbo].[loginvisitas] ON 

INSERT [dbo].[loginvisitas] ([id], [usuario], [contraseña], [tipo_usuario], [nombre], [apellido], [fecha]) VALUES (1, N'admin', N'admin', N'admin', NULL, NULL, NULL)
INSERT [dbo].[loginvisitas] ([id], [usuario], [contraseña], [tipo_usuario], [nombre], [apellido], [fecha]) VALUES (8, N'Jose', N'1234', N'usuario', N'jose', N'cruz', CAST(N'2020-08-08' AS Date))
INSERT [dbo].[loginvisitas] ([id], [usuario], [contraseña], [tipo_usuario], [nombre], [apellido], [fecha]) VALUES (6, N'ciprian', N'1234', N'usuario', N'ciprian', N'no se', CAST(N'2020-08-05' AS Date))
SET IDENTITY_INSERT [dbo].[loginvisitas] OFF
SET IDENTITY_INSERT [dbo].[visitas] ON 

INSERT [dbo].[visitas] ([id], [nombre], [apellido], [carrera], [email], [edificio], [hora], [motivo], [aula], [tipo_visita]) VALUES (7, N'ciprian', N'minaya', N'software', N'ciprian@gmail.com', 1, N'1:13:25 PM', N'estudiar', N'Aula 1A', N'Estudiante')
INSERT [dbo].[visitas] ([id], [nombre], [apellido], [carrera], [email], [edificio], [hora], [motivo], [aula], [tipo_visita]) VALUES (8, N'kevin', N'rosario', N'software', N'kevin@gmail.com', 5, N'1:13:25 PM', N'estudiar', N'Aula 4C', N'Estudiante')
INSERT [dbo].[visitas] ([id], [nombre], [apellido], [carrera], [email], [edificio], [hora], [motivo], [aula], [tipo_visita]) VALUES (9, N'david', N'ortiz', N'redes', N'david@hotmail.com', 5, N'7:25:25 PM', N'buscar info', N'Aula 1B', N'Estudiante')
SET IDENTITY_INSERT [dbo].[visitas] OFF
/****** Object:  StoredProcedure [dbo].[borrar]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create proc [dbo].[borrar]
 @id int
 as
 begin
delete from loginvisitas where id=@id
 end;
GO
/****** Object:  StoredProcedure [dbo].[buscarVisi]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscarVisi]
@edificio int
as
begin
select *from visitas where edificio = @edificio
end;
GO
/****** Object:  StoredProcedure [dbo].[BuscarVisita]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[BuscarVisita]
 @id int 
 as
 begin
 select *from loginvisitas where id=@id
 end;
GO
/****** Object:  StoredProcedure [dbo].[crear]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[crear] 
@usuario varchar(50),
@contraseña varchar(50),
@tipo_usuario varchar(50),
@nombre varchar(50),
@apellido varchar(50),
@fecha date
as
begin
insert into loginvisitas values (@usuario,@contraseña ,@tipo_usuario,@nombre,@apellido,@fecha)
end;
GO
/****** Object:  StoredProcedure [dbo].[editar]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[editar]
 @id int,
@usuario varchar(50),
@contraseña varchar(50),
@tipo_usuario varchar(50),
@nombre varchar(50),
@apellido varchar(50),
@fecha date


 as
 begin
update loginvisitas set usuario=@usuario, contraseña=@contraseña,tipo_usuario=@tipo_usuario,nombre=@nombre,apellido=@apellido,fecha=@fecha where id=@id
 end;
GO
/****** Object:  StoredProcedure [dbo].[guardaraula]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create    proc [dbo].[guardaraula] 
 @aula varchar(50)
 as
 begin
 insert into aula values (@aula)
 end;
GO
/****** Object:  StoredProcedure [dbo].[guardaredi]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create   proc [dbo].[guardaredi] 
 @edificio int
 as
 begin
 insert into edificio values (@edificio)
 end;
GO
/****** Object:  StoredProcedure [dbo].[lg_visitas]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[lg_visitas]
@usuario varchar(50),
@contraseña varchar(50)
as
begin
select * from loginvisitas where usuario=@usuario and contraseña = @contraseña 
end;

GO
/****** Object:  StoredProcedure [dbo].[llenar]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

 create proc [dbo].[llenar]
 as
 begin
 select *from loginvisitas
 end;
GO
/****** Object:  StoredProcedure [dbo].[llenargrid]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create  proc [dbo].[llenargrid]
as
select *from visitas
GO
/****** Object:  StoredProcedure [dbo].[llenarlos]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[llenarlos]
as
select *from visitas
GO
/****** Object:  StoredProcedure [dbo].[modif]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  proc [dbo].[modif]
@id int,
@edificio int
as
begin
update edificio set Edificio = @edificio where id = @id
end;
GO
/****** Object:  StoredProcedure [dbo].[modif2]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  proc [dbo].[modif2]
@id int,
@aula varchar(50)
as
begin
update aula set aula = @aula where id = @id
end;
GO
/****** Object:  StoredProcedure [dbo].[Registrar1]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create  proc [dbo].[Registrar1]

 as 
 select *from aula;
GO
/****** Object:  StoredProcedure [dbo].[Registrar2]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
 create  proc [dbo].[Registrar2]

 as 
 select *from edificio;
GO
/****** Object:  StoredProcedure [dbo].[registro]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create  proc  [dbo].[registro]
@nombre varchar(50),
@apellido varchar(50),
@carrera varchar(50),
@correo varchar(50),
@Edificio int,
@Hora varchar(50),
@motivo varchar(50),
@Aula varchar(50),
@tipo_visita varchar(50)
as
begin
insert into visitas values(@nombre,@apellido,@carrera,@correo,@Edificio,@Hora,@motivo,@Aula,@tipo_visita)
end;
GO
/****** Object:  StoredProcedure [dbo].[selection]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[selection]
as
select * from loginvisitas

GO
/****** Object:  StoredProcedure [dbo].[username]    Script Date: 8/8/2020 4:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[username]
@usuario varchar(50),
@contraseña varchar(50),
@tipo_usuario varchar(50),
@nombre varchar(50),
@apellido varchar(50),
@fecha date

as
begin
insert into loginvisitas values(@usuario,@contraseña,@tipo_usuario,@nombre,@apellido,@fecha)
end;
GO
USE [master]
GO
ALTER DATABASE [Control] SET  READ_WRITE 
GO
