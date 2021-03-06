USE [Ventas]
GO
/****** Object:  Table [dbo].[tb_logueo]    Script Date: 14/09/2021 16:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_logueo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[LoginUsuario] [varchar](200) NOT NULL,
	[ContrasenaUsuario] [varchar](200) NOT NULL,
 CONSTRAINT [PK_tb_logueo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_sucursal]    Script Date: 14/09/2021 16:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_sucursal](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Sucursal] [varchar](200) NOT NULL,
	[Ubicacion] [varchar](200) NOT NULL,
	[TelefonoSucursal] [int] NOT NULL,
	[EstadoSucursal] [bit] NULL,
 CONSTRAINT [PK_tb_sucursal] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_usuario]    Script Date: 14/09/2021 16:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idSucursal] [int] NOT NULL,
	[idLogueo] [int] NOT NULL,
	[CodigoUsuario] [int] NOT NULL,
	[NombreUsuario] [varchar](200) NOT NULL,
	[TelefonoUsuario] [int] NOT NULL,
	[CelularUsuario] [int] NOT NULL,
	[CorreoUsuario] [varchar](200) NOT NULL,
	[EstadoUsuario] [bit] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
 CONSTRAINT [PK_tb_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_logueo] ON 

INSERT [dbo].[tb_logueo] ([id], [LoginUsuario], [ContrasenaUsuario]) VALUES (1, N'admin', N'admin')
INSERT [dbo].[tb_logueo] ([id], [LoginUsuario], [ContrasenaUsuario]) VALUES (2, N'usuario', N'usuario')
INSERT [dbo].[tb_logueo] ([id], [LoginUsuario], [ContrasenaUsuario]) VALUES (3, N'invitado', N'invitado')
SET IDENTITY_INSERT [dbo].[tb_logueo] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_sucursal] ON 

INSERT [dbo].[tb_sucursal] ([id], [Sucursal], [Ubicacion], [TelefonoSucursal], [EstadoSucursal]) VALUES (1, N'Santos Dumont', N'Av.Santos Dumont', 2312334, 1)
INSERT [dbo].[tb_sucursal] ([id], [Sucursal], [Ubicacion], [TelefonoSucursal], [EstadoSucursal]) VALUES (2, N'Brasil', N'Av.Brasil', 32434, 1)
INSERT [dbo].[tb_sucursal] ([id], [Sucursal], [Ubicacion], [TelefonoSucursal], [EstadoSucursal]) VALUES (3, N'ewrwerewr', N'rrtyrtyrty', 4353453, 1)
INSERT [dbo].[tb_sucursal] ([id], [Sucursal], [Ubicacion], [TelefonoSucursal], [EstadoSucursal]) VALUES (4, N'prueba', N'prueba', 342345, 0)
INSERT [dbo].[tb_sucursal] ([id], [Sucursal], [Ubicacion], [TelefonoSucursal], [EstadoSucursal]) VALUES (5, N'prueba', N'prueba', 55435, 1)
SET IDENTITY_INSERT [dbo].[tb_sucursal] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_usuario] ON 

INSERT [dbo].[tb_usuario] ([id], [idSucursal], [idLogueo], [CodigoUsuario], [NombreUsuario], [TelefonoUsuario], [CelularUsuario], [CorreoUsuario], [EstadoUsuario], [FechaCreacion]) VALUES (1, 1, 1, 1, N'admin', 3242342, 344534, N'admin@admin.com', 1, CAST(N'2020-03-01T00:00:00.000' AS DateTime))
INSERT [dbo].[tb_usuario] ([id], [idSucursal], [idLogueo], [CodigoUsuario], [NombreUsuario], [TelefonoUsuario], [CelularUsuario], [CorreoUsuario], [EstadoUsuario], [FechaCreacion]) VALUES (2, 2, 2, 2, N'admin', 3242342, 344534, N'admin@admin.com', 1, CAST(N'2020-03-01T00:00:00.000' AS DateTime))
INSERT [dbo].[tb_usuario] ([id], [idSucursal], [idLogueo], [CodigoUsuario], [NombreUsuario], [TelefonoUsuario], [CelularUsuario], [CorreoUsuario], [EstadoUsuario], [FechaCreacion]) VALUES (3, 3, 3, 2, N'admin', 3242342, 344534, N'admin@admin.com', 1, CAST(N'2020-03-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tb_usuario] OFF
GO
/****** Object:  StoredProcedure [dbo].[insertarusuario1]    Script Date: 14/09/2021 16:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertarusuario1]

--Parámetro Logueo
@LoginUsuario varchar(200),
@ContrasenaUsuario varchar(200),

--Parámetro Sucursal
--@Sucursal varchar(200),
--@Ubicacion varchar(200),
--@TelefonoSucursal int,
--@EstadoSucursal bit,

--Parámetro Usuario
@idLogueo int output,
@idSucursal int output,
@CodigoUsuario int,
@NombreUsuario varchar(200),
@TelefonoUsuario int,
@CelularUsuario int,
@CorreoUsuario varchar(200),
@EstadoUsuario bit,
@FechaCreacion datetime

as

insert into tb_logueo values (@LoginUsuario,@ContrasenaUsuario)
--insert into tb_sucursal values (@Sucursal,@Ubicacion,@TelefonoSucursal,@EstadoSucursal)

select @idLogueo = @@IDENTITY
select @idSucursal = @@IDENTITY

insert into tb_usuario values(@idLogueo,@idSucursal,@CodigoUsuario,@NombreUsuario,@TelefonoUsuario,@CelularUsuario,@CorreoUsuario,@EstadoUsuario,@FechaCreacion)
GO
/****** Object:  StoredProcedure [dbo].[insertarusuario2]    Script Date: 14/09/2021 16:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertarusuario2]

--Parámetro Logueo
@LoginUsuario varchar(200),
@ContrasenaUsuario varchar(200),

--Parámetro Sucursal
@Sucursal varchar(200),
@Ubicacion varchar(200),
@TelefonoSucursal int,
@EstadoSucursal bit,

--Parámetro Usuario
@idLogueo int output,
@idSucursal int output,
@CodigoUsuario int,
@NombreUsuario varchar(200),
@TelefonoUsuario int,
@CelularUsuario int,
@CorreoUsuario varchar(200),
@EstadoUsuario bit,
@FechaCreacion datetime

as

insert into tb_logueo values (@LoginUsuario,@ContrasenaUsuario)
insert into tb_sucursal values (@Sucursal,@Ubicacion,@TelefonoSucursal,@EstadoSucursal)

select @idLogueo = @@IDENTITY
select @idSucursal = @@IDENTITY

insert into tb_usuario values(@idLogueo,@idSucursal,@CodigoUsuario,@NombreUsuario,@TelefonoUsuario,@CelularUsuario,@CorreoUsuario,@EstadoUsuario,@FechaCreacion)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertarsucursal]    Script Date: 14/09/2021 16:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertarsucursal]
@Sucursal varchar(200),
@Ubicacion varchar(200),
@TelefonoSucursal int,
@EstadoSucursal bit
as
insert into tb_sucursal values (@Sucursal,@Ubicacion,@TelefonoSucursal,@EstadoSucursal)
GO
/****** Object:  StoredProcedure [dbo].[sp_listarsucursal]    Script Date: 14/09/2021 16:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_listarsucursal]
as
SELECT id, Sucursal, Ubicacion, TelefonoSucursal, EstadoSucursal
FROM     tb_sucursal
GO
