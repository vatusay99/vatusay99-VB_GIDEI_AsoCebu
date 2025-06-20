USE [gestorInventarioEquipos]
GO
ALTER TABLE [dbo].[t_registro_de_equipos] DROP CONSTRAINT [FK_t_usuarios_id]
GO
ALTER TABLE [dbo].[t_registro_de_equipos] DROP CONSTRAINT [FK_t_departamentos_id]
GO
/****** Object:  Index [c_unique_usuario]    Script Date: 16/06/2025 4:10:43 p. m. ******/
ALTER TABLE [dbo].[t_usuarios] DROP CONSTRAINT [c_unique_usuario]
GO
/****** Object:  Index [c_unique_id_usuario_encargado]    Script Date: 16/06/2025 4:10:43 p. m. ******/
ALTER TABLE [dbo].[t_registro_de_equipos] DROP CONSTRAINT [c_unique_id_usuario_encargado]
GO
/****** Object:  Table [dbo].[t_usuarios]    Script Date: 16/06/2025 4:10:43 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_usuarios]') AND type in (N'U'))
DROP TABLE [dbo].[t_usuarios]
GO
/****** Object:  Table [dbo].[t_registro_de_equipos]    Script Date: 16/06/2025 4:10:43 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_registro_de_equipos]') AND type in (N'U'))
DROP TABLE [dbo].[t_registro_de_equipos]
GO
/****** Object:  Table [dbo].[t_departamento_area]    Script Date: 16/06/2025 4:10:43 p. m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_departamento_area]') AND type in (N'U'))
DROP TABLE [dbo].[t_departamento_area]
GO
/****** Object:  User [sinedin]    Script Date: 16/06/2025 4:10:43 p. m. ******/
DROP USER [sinedin]
GO
/****** Object:  User [sinedin]    Script Date: 16/06/2025 4:10:43 p. m. ******/
CREATE USER [sinedin] FOR LOGIN [sinedin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [sinedin]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [sinedin]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [sinedin]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [sinedin]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [sinedin]
GO
ALTER ROLE [db_datareader] ADD MEMBER [sinedin]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [sinedin]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [sinedin]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [sinedin]
GO
/****** Object:  Table [dbo].[t_departamento_area]    Script Date: 16/06/2025 4:10:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_departamento_area](
	[id_departamento] [int] IDENTITY(1,1) NOT NULL,
	[nombre_area_departamento] [nvarchar](150) NOT NULL,
	[centro_de_costos] [nchar](50) NULL,
	[nombre_jefe_area] [nvarchar](150) NULL,
	[descripcion] [nvarchar](255) NULL,
 CONSTRAINT [PK_departamento_area] PRIMARY KEY CLUSTERED 
(
	[id_departamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[t_departamento_area] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[t_registro_de_equipos]    Script Date: 16/06/2025 4:10:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_registro_de_equipos](
	[nombre] [nvarchar](150) NOT NULL,
	[tipo] [nvarchar](max) NOT NULL,
	[serial] [nvarchar](50) NOT NULL,
	[id_departamento_area] [int] NULL,
	[fecha_ingreso] [date] NOT NULL,
	[activo] [nvarchar](50) NULL,
	[id_usuario_encargado] [int] NULL,
	[id_equipo] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_t_registro_de_equipos] PRIMARY KEY CLUSTERED 
(
	[id_equipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[t_registro_de_equipos] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[t_usuarios]    Script Date: 16/06/2025 4:10:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre_completo] [nvarchar](150) NOT NULL,
	[usuario] [nchar](10) NOT NULL,
	[password] [nchar](110) NOT NULL,
	[tipo_usurio] [nvarchar](50) NULL,
	[estado] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_t_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[t_usuarios] TO  SCHEMA OWNER 
GO
SET IDENTITY_INSERT [dbo].[t_departamento_area] ON 

INSERT [dbo].[t_departamento_area] ([id_departamento], [nombre_area_departamento], [centro_de_costos], [nombre_jefe_area], [descripcion]) VALUES (1, N'Recursos Humanos', N'HHRR01                                            ', N'David N Diaz', N'Area de RH ubicada en en la planta 1 off 101')
INSERT [dbo].[t_departamento_area] ([id_departamento], [nombre_area_departamento], [centro_de_costos], [nombre_jefe_area], [descripcion]) VALUES (2, N'Contabilidad', N'Cont002                                           ', N'Felipe Diaz Perez', N'Departamento de contabilidad planta 2 y 3 oficinas 201, 202, 203, 303 y 501')
INSERT [dbo].[t_departamento_area] ([id_departamento], [nombre_area_departamento], [centro_de_costos], [nombre_jefe_area], [descripcion]) VALUES (5, N'Comercial', N'Comer01                                           ', N'Victoria Ortiz', N'Planta 3 off 302-305 y casa Campaña')
INSERT [dbo].[t_departamento_area] ([id_departamento], [nombre_area_departamento], [centro_de_costos], [nombre_jefe_area], [descripcion]) VALUES (6, N'Almacen2 ', N'Alma02                                            ', N'Cesar Cascarrabias', N'Entrada de mercancia Sotano 2')
INSERT [dbo].[t_departamento_area] ([id_departamento], [nombre_area_departamento], [centro_de_costos], [nombre_jefe_area], [descripcion]) VALUES (8, N'Area de Mensajeria', N'MEN01                                             ', N'Martha Diaz', N'Area de edificio principal plata 4 Off 401')
INSERT [dbo].[t_departamento_area] ([id_departamento], [nombre_area_departamento], [centro_de_costos], [nombre_jefe_area], [descripcion]) VALUES (9, N'Area de Caja Menor', N'CJ01                                              ', N'Camilo Palacio', N'Piso 1 porteria')
INSERT [dbo].[t_departamento_area] ([id_departamento], [nombre_area_departamento], [centro_de_costos], [nombre_jefe_area], [descripcion]) VALUES (10, N'Area de Compras', N'Comp01                                            ', N'Milena monsalve', N'Sotano de entrada de mercancias Porteria 2')
INSERT [dbo].[t_departamento_area] ([id_departamento], [nombre_area_departamento], [centro_de_costos], [nombre_jefe_area], [descripcion]) VALUES (11, N'IT & Sistemas', N'SIS01                                             ', N'Mario Camacho', N'piso 5 al frente de gerencia =ficina 503')
SET IDENTITY_INSERT [dbo].[t_departamento_area] OFF
GO
SET IDENTITY_INSERT [dbo].[t_registro_de_equipos] ON 

INSERT [dbo].[t_registro_de_equipos] ([nombre], [tipo], [serial], [id_departamento_area], [fecha_ingreso], [activo], [id_usuario_encargado], [id_equipo]) VALUES (N'Mouse optico inalambrico', N'Periferico', N'Mo01', 1, CAST(N'1900-01-01' AS Date), N'Inactivo', 1004, 1)
INSERT [dbo].[t_registro_de_equipos] ([nombre], [tipo], [serial], [id_departamento_area], [fecha_ingreso], [activo], [id_usuario_encargado], [id_equipo]) VALUES (N'Tarjeta Grafica XRFORCE 2025', N'Dispocitivos Internos PC, Laptop', N'TGX01', 5, CAST(N'1900-01-01' AS Date), N'Inactivo', 1, 8)
INSERT [dbo].[t_registro_de_equipos] ([nombre], [tipo], [serial], [id_departamento_area], [fecha_ingreso], [activo], [id_usuario_encargado], [id_equipo]) VALUES (N'Equipo de prueba 01', N'prueba', N'pr01', 1, CAST(N'1900-01-01' AS Date), N'Activo', 1005, 9)
INSERT [dbo].[t_registro_de_equipos] ([nombre], [tipo], [serial], [id_departamento_area], [fecha_ingreso], [activo], [id_usuario_encargado], [id_equipo]) VALUES (N'Laptop Lenovo Optiplex', N'LAPTOP-(Marca Lenovo)', N'LP001', 2, CAST(N'1900-01-01' AS Date), N'Activo', 1008, 10)
INSERT [dbo].[t_registro_de_equipos] ([nombre], [tipo], [serial], [id_departamento_area], [fecha_ingreso], [activo], [id_usuario_encargado], [id_equipo]) VALUES (N'Impresora Lexmark', N'Impresora', N'Imp01', 5, CAST(N'1900-01-01' AS Date), N'Activo', 1009, 2002)
INSERT [dbo].[t_registro_de_equipos] ([nombre], [tipo], [serial], [id_departamento_area], [fecha_ingreso], [activo], [id_usuario_encargado], [id_equipo]) VALUES (N'Impresora Epson', N'Impresoras', N'IMP02', 2, CAST(N'2025-06-05' AS Date), N'Activo', 2008, 2003)
SET IDENTITY_INSERT [dbo].[t_registro_de_equipos] OFF
GO
SET IDENTITY_INSERT [dbo].[t_usuarios] ON 

INSERT [dbo].[t_usuarios] ([id_usuario], [nombre_completo], [usuario], [password], [tipo_usurio], [estado]) VALUES (1, N'David Diaz', N'sinedindnd', N'Felipe2020                                                                                                    ', N'Admin', N'activo')
INSERT [dbo].[t_usuarios] ([id_usuario], [nombre_completo], [usuario], [password], [tipo_usurio], [estado]) VALUES (1004, N'Diego A Diaz', N'DDiaz     ', N'dad2025                                                                                                       ', N'Invitado', N'Activo')
INSERT [dbo].[t_usuarios] ([id_usuario], [nombre_completo], [usuario], [password], [tipo_usurio], [estado]) VALUES (1005, N'Felipe Diaz', N'Juanes    ', N'Felipe2007                                                                                                    ', N'Invitado', N'Inactivo')
INSERT [dbo].[t_usuarios] ([id_usuario], [nombre_completo], [usuario], [password], [tipo_usurio], [estado]) VALUES (1008, N'Usuari01', N'Pruebas01 ', N'Pruebas01                                                                                                     ', N'Operario', N'Activo')
INSERT [dbo].[t_usuarios] ([id_usuario], [nombre_completo], [usuario], [password], [tipo_usurio], [estado]) VALUES (1009, N'Usuari02', N'Pruebas02 ', N'Pruebas02                                                                                                     ', N'Sistemas', N'Activo')
INSERT [dbo].[t_usuarios] ([id_usuario], [nombre_completo], [usuario], [password], [tipo_usurio], [estado]) VALUES (2008, N'Pruebas Comencial', N'prueba03  ', N'pruebas03                                                                                                     ', N'Analista Comercial', N'Inactivo')
INSERT [dbo].[t_usuarios] ([id_usuario], [nombre_completo], [usuario], [password], [tipo_usurio], [estado]) VALUES (2010, N'UsuarioAlmacen1', N'Malla     ', N'malla2025                                                                                                     ', N'Invitado', N'Activo')
INSERT [dbo].[t_usuarios] ([id_usuario], [nombre_completo], [usuario], [password], [tipo_usurio], [estado]) VALUES (2011, N'AlmacenPruebas02', N'Malla02   ', N'malla2024                                                                                                     ', N'Admin', N'Activo')
INSERT [dbo].[t_usuarios] ([id_usuario], [nombre_completo], [usuario], [password], [tipo_usurio], [estado]) VALUES (2014, N'Administrador', N'Master    ', N'master2025                                                                                                    ', N'Admin', N'Activo')
SET IDENTITY_INSERT [dbo].[t_usuarios] OFF
GO
/****** Object:  Index [c_unique_id_usuario_encargado]    Script Date: 16/06/2025 4:10:44 p. m. ******/
ALTER TABLE [dbo].[t_registro_de_equipos] ADD  CONSTRAINT [c_unique_id_usuario_encargado] UNIQUE NONCLUSTERED 
(
	[id_usuario_encargado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [c_unique_usuario]    Script Date: 16/06/2025 4:10:44 p. m. ******/
ALTER TABLE [dbo].[t_usuarios] ADD  CONSTRAINT [c_unique_usuario] UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[t_registro_de_equipos]  WITH CHECK ADD  CONSTRAINT [FK_t_departamentos_id] FOREIGN KEY([id_departamento_area])
REFERENCES [dbo].[t_departamento_area] ([id_departamento])
GO
ALTER TABLE [dbo].[t_registro_de_equipos] CHECK CONSTRAINT [FK_t_departamentos_id]
GO
ALTER TABLE [dbo].[t_registro_de_equipos]  WITH CHECK ADD  CONSTRAINT [FK_t_usuarios_id] FOREIGN KEY([id_usuario_encargado])
REFERENCES [dbo].[t_usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[t_registro_de_equipos] CHECK CONSTRAINT [FK_t_usuarios_id]
GO
