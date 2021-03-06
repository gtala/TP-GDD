
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Transferencia_Cuenta_Destino]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Transferencia]'))
ALTER TABLE [BrainStormers].[Transferencia] DROP CONSTRAINT [FK_Transferencia_Cuenta_Destino]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Transferencia_Cuenta]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Transferencia]'))
ALTER TABLE [BrainStormers].[Transferencia] DROP CONSTRAINT [FK_Transferencia_Cuenta]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Usuario_RolesUsuario]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[RolesUsuario]'))
ALTER TABLE [BrainStormers].[RolesUsuario] DROP CONSTRAINT [FK_Usuario_RolesUsuario]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Rol_RolesUsuario]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[RolesUsuario]'))
ALTER TABLE [BrainStormers].[RolesUsuario] DROP CONSTRAINT [FK_Rol_RolesUsuario]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Rol_FuncionalidadesRol]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[FuncionalidadesRol]'))
ALTER TABLE [BrainStormers].[FuncionalidadesRol] DROP CONSTRAINT [FK_Rol_FuncionalidadesRol]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Func_FuncionalidadesRol]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[FuncionalidadesRol]'))
ALTER TABLE [BrainStormers].[FuncionalidadesRol] DROP CONSTRAINT [FK_Func_FuncionalidadesRol]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Deposito_Moneda]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Deposito]'))
ALTER TABLE [BrainStormers].[Deposito] DROP CONSTRAINT [FK_Deposito_Moneda]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Deposito_Deposito]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Deposito]'))
ALTER TABLE [BrainStormers].[Deposito] DROP CONSTRAINT [FK_Deposito_Deposito]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Deposito_Cuenta]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Deposito]'))
ALTER TABLE [BrainStormers].[Deposito] DROP CONSTRAINT [FK_Deposito_Cuenta]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Tipo_Cuenta]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta] DROP CONSTRAINT [FK_Cuenta_Tipo_Cuenta]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Pais]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta] DROP CONSTRAINT [FK_Cuenta_Pais]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Moneda]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta] DROP CONSTRAINT [FK_Cuenta_Moneda]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Estado_Cuenta]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta] DROP CONSTRAINT [FK_Cuenta_Estado_Cuenta]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Cuenta]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta] DROP CONSTRAINT [FK_Cuenta_Cuenta]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Cliente]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta] DROP CONSTRAINT [FK_Cuenta_Cliente]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cliente_Usuario]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cliente]'))
ALTER TABLE [BrainStormers].[Cliente] DROP CONSTRAINT [FK_Cliente_Usuario]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cliente_TipoDocumento]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cliente]'))
ALTER TABLE [BrainStormers].[Cliente] DROP CONSTRAINT [FK_Cliente_TipoDocumento]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cliente_Pais]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cliente]'))
ALTER TABLE [BrainStormers].[Cliente] DROP CONSTRAINT [FK_Cliente_Pais]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Auditoria_Login_Usuario]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Auditoria_Login]'))
ALTER TABLE [BrainStormers].[Auditoria_Login] DROP CONSTRAINT [FK_Auditoria_Login_Usuario]
GO
/****** Object:  Table [BrainStormers].[Usuario]    Script Date: 11/06/2015 19:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Usuario]') AND type in (N'U'))
DROP TABLE [BrainStormers].[Usuario]
GO
/****** Object:  Table [BrainStormers].[Transferencia]    Script Date: 11/06/2015 19:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Transferencia]') AND type in (N'U'))
DROP TABLE [BrainStormers].[Transferencia]
GO
/****** Object:  Table [BrainStormers].[TipoDocumento]    Script Date: 11/06/2015 19:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[TipoDocumento]') AND type in (N'U'))
DROP TABLE [BrainStormers].[TipoDocumento]
GO
/****** Object:  Table [BrainStormers].[Tipo_Cuenta]    Script Date: 11/06/2015 19:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Tipo_Cuenta]') AND type in (N'U'))
DROP TABLE [BrainStormers].[Tipo_Cuenta]
GO
/****** Object:  Table [BrainStormers].[RolesUsuario]    Script Date: 11/06/2015 19:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[RolesUsuario]') AND type in (N'U'))
DROP TABLE [BrainStormers].[RolesUsuario]
GO
/****** Object:  Table [BrainStormers].[Rol]    Script Date: 11/06/2015 19:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Rol]') AND type in (N'U'))
DROP TABLE [BrainStormers].[Rol]
GO
/****** Object:  Table [BrainStormers].[Pais]    Script Date: 11/06/2015 19:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Pais]') AND type in (N'U'))
DROP TABLE [BrainStormers].[Pais]
GO
/****** Object:  Table [BrainStormers].[Moneda]    Script Date: 11/06/2015 19:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Moneda]') AND type in (N'U'))
DROP TABLE [BrainStormers].[Moneda]
GO
/****** Object:  Table [BrainStormers].[FuncionalidadesRol]    Script Date: 11/06/2015 19:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[FuncionalidadesRol]') AND type in (N'U'))
DROP TABLE [BrainStormers].[FuncionalidadesRol]
GO
/****** Object:  Table [BrainStormers].[Funcionalidad]    Script Date: 11/06/2015 19:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Funcionalidad]') AND type in (N'U'))
DROP TABLE [BrainStormers].[Funcionalidad]
GO
/****** Object:  Table [BrainStormers].[Estado_Cuenta]    Script Date: 11/06/2015 19:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Estado_Cuenta]') AND type in (N'U'))
DROP TABLE [BrainStormers].[Estado_Cuenta]
GO
/****** Object:  Table [BrainStormers].[Deposito]    Script Date: 11/06/2015 19:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Deposito]') AND type in (N'U'))
DROP TABLE [BrainStormers].[Deposito]
GO
/****** Object:  Table [BrainStormers].[Cuenta]    Script Date: 11/06/2015 19:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]') AND type in (N'U'))
DROP TABLE [BrainStormers].[Cuenta]
GO
/****** Object:  Table [BrainStormers].[Cliente]    Script Date: 11/06/2015 19:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Cliente]') AND type in (N'U'))
DROP TABLE [BrainStormers].[Cliente]
GO
/****** Object:  Table [BrainStormers].[Auditoria_Login]    Script Date: 11/06/2015 19:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Auditoria_Login]') AND type in (N'U'))
DROP TABLE [BrainStormers].[Auditoria_Login]
GO
/****** Object:  Table [BrainStormers].[Auditoria_Login]    Script Date: 11/06/2015 19:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Auditoria_Login]') AND type in (N'U'))
BEGIN
CREATE TABLE [BrainStormers].[Auditoria_Login](
	[Auditoria_Login_Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Auditoria_Login_Usuario_Username] [varchar](255) NULL,
	[Auditoria_Login_Fecha] [datetime] NULL,
	[Auditoria_Login_Acceso_Correcto] [bit] NULL,
	[Auditoria_Login_Numero_Intento] [numeric](18, 0) NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [BrainStormers].[Cliente]    Script Date: 11/06/2015 19:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Cliente]') AND type in (N'U'))
BEGIN
CREATE TABLE [BrainStormers].[Cliente](
	[Cliente_Codigo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Cliente_Nombre] [varchar](255) NULL,
	[Cliente_Apellido] [varchar](255) NULL,
	[Cliente_Tipo_Doc_Cod] [numeric](18, 0) NULL,
	[Cliente_Nro_Doc] [numeric](18, 0) NULL,
	[Cliente_Pais_Codigo] [numeric](18, 0) NOT NULL,
	[Cliente_Dom_Calle] [varchar](255) NULL,
	[Cliente_Dom_Nro] [numeric](18, 0) NULL,
	[Cliente_Dom_Piso] [numeric](18, 0) NULL,
	[Cliente_Dom_Depto] [varchar](10) NULL,
	[Cliente_Fecha_Nac] [datetime] NULL,
	[Cliente_Mail] [varchar](255) NULL,
	[Cliente_Baja] [bit] NULL,
	[Cliente_Usuario] [varchar](255) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Cliente_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [U_Cliente_Mail] UNIQUE NONCLUSTERED 
(
	[Cliente_Mail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [U_Documento] UNIQUE NONCLUSTERED 
(
	[Cliente_Tipo_Doc_Cod] ASC,
	[Cliente_Nro_Doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [BrainStormers].[Cuenta]    Script Date: 11/06/2015 19:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]') AND type in (N'U'))
BEGIN
CREATE TABLE [BrainStormers].[Cuenta](
	[Cuenta_Numero] [numeric](18, 0) NOT NULL,
	[Cuenta_Fecha_Creacion] [datetime] NULL,
	[Cuenta_Estado] [numeric](18, 0) NULL,
	[Cuenta_Pais_Codigo] [numeric](18, 0) NULL,
	[Cuenta_Fecha_Cierre] [datetime] NULL,
	[Cuenta_Moneda] [numeric](18, 0) NULL,
	[Cuenta_Tipo] [numeric](18, 0) NULL,
	[Cuenta_Cliente] [numeric](18, 0) NULL,
	[Cuenta_Saldo] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Cuenta] PRIMARY KEY CLUSTERED 
(
	[Cuenta_Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [BrainStormers].[Deposito]    Script Date: 11/06/2015 19:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Deposito]') AND type in (N'U'))
BEGIN
CREATE TABLE [BrainStormers].[Deposito](
	[Deposito_Codigo] [numeric](18, 0) NOT NULL,
	[Deposito_Fecha] [datetime] NULL,
	[Deposito_Importe] [numeric](18, 2) NULL,
	[Deposito_Cuenta] [numeric](18, 0) NULL,
	[Deposito_Moneda] [numeric](18, 0) NULL,
	[Deposito_Tarjeta] [numeric](18, 2) NULL,
 CONSTRAINT [PK_Deposito] PRIMARY KEY CLUSTERED 
(
	[Deposito_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [BrainStormers].[Estado_Cuenta]    Script Date: 11/06/2015 19:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Estado_Cuenta]') AND type in (N'U'))
BEGIN
CREATE TABLE [BrainStormers].[Estado_Cuenta](
	[Estado_Cuenta_Id] [numeric](18, 0) NOT NULL,
	[Estado_Cuenta_Desc] [varchar](255) NULL,
 CONSTRAINT [PK_Estado_Cuenta] PRIMARY KEY CLUSTERED 
(
	[Estado_Cuenta_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [BrainStormers].[Funcionalidad]    Script Date: 11/06/2015 19:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Funcionalidad]') AND type in (N'U'))
BEGIN
CREATE TABLE [BrainStormers].[Funcionalidad](
	[Func_Codigo] [numeric](18, 0) NOT NULL,
	[Func_Desc] [varchar](250) NULL,
 CONSTRAINT [PK_Funcionalidad] PRIMARY KEY CLUSTERED 
(
	[Func_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [BrainStormers].[FuncionalidadesRol]    Script Date: 11/06/2015 19:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[FuncionalidadesRol]') AND type in (N'U'))
BEGIN
CREATE TABLE [BrainStormers].[FuncionalidadesRol](
	[FuncRol_Rol_Codigo] [numeric](18, 0) NOT NULL,
	[FuncRol_Func_Codigo] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_FuncRol] PRIMARY KEY CLUSTERED 
(
	[FuncRol_Rol_Codigo] ASC,
	[FuncRol_Func_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [BrainStormers].[Moneda]    Script Date: 11/06/2015 19:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Moneda]') AND type in (N'U'))
BEGIN
CREATE TABLE [BrainStormers].[Moneda](
	[Moneda_Tipo] [numeric](18, 0) NOT NULL,
	[Moneda_Desc] [varchar](255) NULL,
 CONSTRAINT [PK_Moneda] PRIMARY KEY CLUSTERED 
(
	[Moneda_Tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [BrainStormers].[Pais]    Script Date: 11/06/2015 19:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Pais]') AND type in (N'U'))
BEGIN
CREATE TABLE [BrainStormers].[Pais](
	[Pais_Codigo] [numeric](18, 0) NOT NULL IDENTITY(1,1),
	[Pais_Desc] [varchar](250) NULL,
 CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
(
	[Pais_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [BrainStormers].[Rol]    Script Date: 11/06/2015 19:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Rol]') AND type in (N'U'))
BEGIN
CREATE TABLE [BrainStormers].[Rol](
	[Rol_Codigo] [numeric](18, 0) NOT NULL,
	[Rol_Nombre] [varchar](250) NULL,
	[Rol_Estado] [bit] NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[Rol_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [U_Rol_Nombre] UNIQUE NONCLUSTERED 
(
	[Rol_Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [BrainStormers].[RolesUsuario]    Script Date: 11/06/2015 19:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[RolesUsuario]') AND type in (N'U'))
BEGIN
CREATE TABLE [BrainStormers].[RolesUsuario](
	[RolUsu_Rol_Codigo] [numeric](18, 0) NOT NULL,
	[RolUsu_Usuario_Username] [varchar](255) NOT NULL,
 CONSTRAINT [PK_RolUsu] PRIMARY KEY CLUSTERED 
(
	[RolUsu_Rol_Codigo] ASC,
	[RolUsu_Usuario_Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [BrainStormers].[Tipo_Cuenta]    Script Date: 11/06/2015 19:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Tipo_Cuenta]') AND type in (N'U'))
BEGIN
CREATE TABLE [BrainStormers].[Tipo_Cuenta](
	[Tipo_Cuenta_Tipo] [numeric](18, 0) NOT NULL,
	[Tipo_Cuenta_Desc] [varchar](255) NULL,
	[Tipo_Cuenta_Dias_Duracion] [numeric](18, 0) NULL,
	[Tipo_Cuenta_Costo] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Tipo_Cuenta] PRIMARY KEY CLUSTERED 
(
	[Tipo_Cuenta_Tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [BrainStormers].[TipoDocumento]    Script Date: 11/06/2015 19:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[TipoDocumento]') AND type in (N'U'))
BEGIN
CREATE TABLE [BrainStormers].[TipoDocumento](
	[Tipo_Doc_Cod] [numeric](18, 0) NOT NULL,
	[Tipo_Doc_Desc] [varchar](255) NULL,
 CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[Tipo_Doc_Cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [BrainStormers].[Transferencia]    Script Date: 11/06/2015 19:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Transferencia]') AND type in (N'U'))
BEGIN
CREATE TABLE [BrainStormers].[Transferencia](
	[Transf_Nro_Operacion] [numeric](18, 0) NOT NULL,
	[Transf_Fecha] [datetime] NULL,
	[Transf_Importe] [numeric](18, 2) NULL,
	[Transf_Costo] [numeric](18, 2) NULL,
	[Transf_Cuenta_Origen] [numeric](18, 0) NULL,
	[Transf_Cuenta_Destino] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Transferencia] PRIMARY KEY CLUSTERED 
(
	[Transf_Nro_Operacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [BrainStormers].[Usuario]    Script Date: 11/06/2015 19:13:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Usuario]') AND type in (N'U'))
BEGIN
CREATE TABLE [BrainStormers].[Usuario](
	[Usuario_Username] [varchar](255) NOT NULL,
	[Usuario_Password] [varchar](255) NULL,
	[Usuario_Fecha_Creacion] [datetime] NULL,
	[Usuario_Fecha_Ultima_Modificacion] [datetime] NULL,
	[Usuario_Pregunta_Secreta] [varchar](255) NULL,
	[Usuario_Respuesta_Secreta] [varchar](255) NULL,
	[Usuario_Intentos_Fallidos] [numeric](18, 0) NULL,
	[Usuario_Inhabilitado] [bit] NULL,
 CONSTRAINT [PK_Usuario_Username] PRIMARY KEY CLUSTERED 
(
	[Usuario_Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Auditoria_Login_Usuario]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Auditoria_Login]'))
ALTER TABLE [BrainStormers].[Auditoria_Login]  WITH CHECK ADD  CONSTRAINT [FK_Auditoria_Login_Usuario] FOREIGN KEY([Auditoria_Login_Usuario_Username])
REFERENCES [BrainStormers].[Usuario] ([Usuario_Username])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Auditoria_Login_Usuario]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Auditoria_Login]'))
ALTER TABLE [BrainStormers].[Auditoria_Login] CHECK CONSTRAINT [FK_Auditoria_Login_Usuario]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cliente_Pais]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cliente]'))
ALTER TABLE [BrainStormers].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Pais] FOREIGN KEY([Cliente_Pais_Codigo])
REFERENCES [BrainStormers].[Pais] ([Pais_Codigo])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cliente_Pais]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cliente]'))
ALTER TABLE [BrainStormers].[Cliente] CHECK CONSTRAINT [FK_Cliente_Pais]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cliente_TipoDocumento]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cliente]'))
ALTER TABLE [BrainStormers].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_TipoDocumento] FOREIGN KEY([Cliente_Tipo_Doc_Cod])
REFERENCES [BrainStormers].[TipoDocumento] ([Tipo_Doc_Cod])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cliente_TipoDocumento]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cliente]'))
ALTER TABLE [BrainStormers].[Cliente] CHECK CONSTRAINT [FK_Cliente_TipoDocumento]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cliente_Usuario]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cliente]'))
ALTER TABLE [BrainStormers].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Usuario] FOREIGN KEY([Cliente_Usuario])
REFERENCES [BrainStormers].[Usuario] ([Usuario_Username])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cliente_Usuario]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cliente]'))
ALTER TABLE [BrainStormers].[Cliente] CHECK CONSTRAINT [FK_Cliente_Usuario]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Cliente]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta]  WITH CHECK ADD  CONSTRAINT [FK_Cuenta_Cliente] FOREIGN KEY([Cuenta_Cliente])
REFERENCES [BrainStormers].[Cliente] ([Cliente_Codigo])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Cliente]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta] CHECK CONSTRAINT [FK_Cuenta_Cliente]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Cuenta]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta]  WITH CHECK ADD  CONSTRAINT [FK_Cuenta_Cuenta] FOREIGN KEY([Cuenta_Numero])
REFERENCES [BrainStormers].[Cuenta] ([Cuenta_Numero])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Cuenta]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta] CHECK CONSTRAINT [FK_Cuenta_Cuenta]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Estado_Cuenta]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta]  WITH CHECK ADD  CONSTRAINT [FK_Cuenta_Estado_Cuenta] FOREIGN KEY([Cuenta_Estado])
REFERENCES [BrainStormers].[Estado_Cuenta] ([Estado_Cuenta_Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Estado_Cuenta]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta] CHECK CONSTRAINT [FK_Cuenta_Estado_Cuenta]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Moneda]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta]  WITH CHECK ADD  CONSTRAINT [FK_Cuenta_Moneda] FOREIGN KEY([Cuenta_Moneda])
REFERENCES [BrainStormers].[Moneda] ([Moneda_Tipo])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Moneda]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta] CHECK CONSTRAINT [FK_Cuenta_Moneda]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Pais]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta]  WITH CHECK ADD  CONSTRAINT [FK_Cuenta_Pais] FOREIGN KEY([Cuenta_Pais_Codigo])
REFERENCES [BrainStormers].[Pais] ([Pais_Codigo])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Pais]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta] CHECK CONSTRAINT [FK_Cuenta_Pais]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Tipo_Cuenta]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta]  WITH CHECK ADD  CONSTRAINT [FK_Cuenta_Tipo_Cuenta] FOREIGN KEY([Cuenta_Tipo])
REFERENCES [BrainStormers].[Tipo_Cuenta] ([Tipo_Cuenta_Tipo])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Cuenta_Tipo_Cuenta]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Cuenta]'))
ALTER TABLE [BrainStormers].[Cuenta] CHECK CONSTRAINT [FK_Cuenta_Tipo_Cuenta]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Deposito_Cuenta]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Deposito]'))
ALTER TABLE [BrainStormers].[Deposito]  WITH CHECK ADD  CONSTRAINT [FK_Deposito_Cuenta] FOREIGN KEY([Deposito_Codigo])
REFERENCES [BrainStormers].[Cuenta] ([Cuenta_Numero])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Deposito_Cuenta]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Deposito]'))
ALTER TABLE [BrainStormers].[Deposito] CHECK CONSTRAINT [FK_Deposito_Cuenta]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Deposito_Deposito]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Deposito]'))
ALTER TABLE [BrainStormers].[Deposito]  WITH CHECK ADD  CONSTRAINT [FK_Deposito_Deposito] FOREIGN KEY([Deposito_Codigo])
REFERENCES [BrainStormers].[Deposito] ([Deposito_Codigo])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Deposito_Deposito]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Deposito]'))
ALTER TABLE [BrainStormers].[Deposito] CHECK CONSTRAINT [FK_Deposito_Deposito]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Deposito_Moneda]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Deposito]'))
ALTER TABLE [BrainStormers].[Deposito]  WITH CHECK ADD  CONSTRAINT [FK_Deposito_Moneda] FOREIGN KEY([Deposito_Moneda])
REFERENCES [BrainStormers].[Moneda] ([Moneda_Tipo])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Deposito_Moneda]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Deposito]'))
ALTER TABLE [BrainStormers].[Deposito] CHECK CONSTRAINT [FK_Deposito_Moneda]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Func_FuncionalidadesRol]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[FuncionalidadesRol]'))
ALTER TABLE [BrainStormers].[FuncionalidadesRol]  WITH CHECK ADD  CONSTRAINT [FK_Func_FuncionalidadesRol] FOREIGN KEY([FuncRol_Func_Codigo])
REFERENCES [BrainStormers].[Funcionalidad] ([Func_Codigo])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Func_FuncionalidadesRol]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[FuncionalidadesRol]'))
ALTER TABLE [BrainStormers].[FuncionalidadesRol] CHECK CONSTRAINT [FK_Func_FuncionalidadesRol]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Rol_FuncionalidadesRol]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[FuncionalidadesRol]'))
ALTER TABLE [BrainStormers].[FuncionalidadesRol]  WITH CHECK ADD  CONSTRAINT [FK_Rol_FuncionalidadesRol] FOREIGN KEY([FuncRol_Rol_Codigo])
REFERENCES [BrainStormers].[Rol] ([Rol_Codigo])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Rol_FuncionalidadesRol]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[FuncionalidadesRol]'))
ALTER TABLE [BrainStormers].[FuncionalidadesRol] CHECK CONSTRAINT [FK_Rol_FuncionalidadesRol]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Rol_RolesUsuario]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[RolesUsuario]'))
ALTER TABLE [BrainStormers].[RolesUsuario]  WITH CHECK ADD  CONSTRAINT [FK_Rol_RolesUsuario] FOREIGN KEY([RolUsu_Rol_Codigo])
REFERENCES [BrainStormers].[Rol] ([Rol_Codigo])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Rol_RolesUsuario]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[RolesUsuario]'))
ALTER TABLE [BrainStormers].[RolesUsuario] CHECK CONSTRAINT [FK_Rol_RolesUsuario]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Usuario_RolesUsuario]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[RolesUsuario]'))
ALTER TABLE [BrainStormers].[RolesUsuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_RolesUsuario] FOREIGN KEY([RolUsu_Usuario_Username])
REFERENCES [BrainStormers].[Usuario] ([Usuario_Username])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Usuario_RolesUsuario]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[RolesUsuario]'))
ALTER TABLE [BrainStormers].[RolesUsuario] CHECK CONSTRAINT [FK_Usuario_RolesUsuario]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Transferencia_Cuenta]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Transferencia]'))
ALTER TABLE [BrainStormers].[Transferencia]  WITH CHECK ADD  CONSTRAINT [FK_Transferencia_Cuenta] FOREIGN KEY([Transf_Cuenta_Origen])
REFERENCES [BrainStormers].[Cuenta] ([Cuenta_Numero])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Transferencia_Cuenta]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Transferencia]'))
ALTER TABLE [BrainStormers].[Transferencia] CHECK CONSTRAINT [FK_Transferencia_Cuenta]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Transferencia_Cuenta_Destino]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Transferencia]'))
ALTER TABLE [BrainStormers].[Transferencia]  WITH CHECK ADD  CONSTRAINT [FK_Transferencia_Cuenta_Destino] FOREIGN KEY([Transf_Cuenta_Destino])
REFERENCES [BrainStormers].[Cuenta] ([Cuenta_Numero])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[BrainStormers].[FK_Transferencia_Cuenta_Destino]') AND parent_object_id = OBJECT_ID(N'[BrainStormers].[Transferencia]'))
ALTER TABLE [BrainStormers].[Transferencia] CHECK CONSTRAINT [FK_Transferencia_Cuenta_Destino]
GO


/****** Object:  StoredProcedure [BrainStormers].[Sp_EliminarCliente]    Script Date: 11/06/2015 18:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_EliminarCliente]') AND type in (N'P', N'PC'))
BEGIN
	DROP PROCEDURE [BrainStormers].[Sp_EliminarCliente]
END
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [BrainStormers].[Sp_EliminarCliente] (@Codigo NUMERIC(18, 0))
AS
BEGIN
	UPDATE BrainStormers.Cliente
	SET Cliente_baja = 1
	WHERE Cliente_Codigo = @Codigo
END' 
GO
/****** Object:  StoredProcedure [BrainStormers].[Sp_EliminarRol]    Script Date: 11/06/2015 18:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_EliminarRol]') AND type in (N'P', N'PC'))
BEGIN
	DROP PROCEDURE [BrainStormers].[Sp_EliminarRol]
END
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [BrainStormers].[Sp_EliminarRol] (@Codigo NUMERIC(18, 0))
AS
BEGIN
	UPDATE BrainStormers.Rol
	SET Rol_Estado = 1
	WHERE Rol_Codigo = @Codigo
END' 
GO
/****** Object:  StoredProcedure [BrainStormers].[Sp_EliminarUsuario]    Script Date: 11/06/2015 18:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_EliminarUsuario]') AND type in (N'P', N'PC'))
BEGIN
DROP PROCEDURE [BrainStormers].[Sp_EliminarUsuario]
END
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [BrainStormers].[Sp_EliminarUsuario] (@Username VARCHAR(255))
AS
BEGIN
	UPDATE BrainStormers.Usuario
	SET Usuario_Inhabilitado  = 1
	WHERE Usuario_Username = @Username
END' 
GO
/****** Object:  StoredProcedure [BrainStormers].[Sp_GuardarAuditoria]    Script Date: 11/06/2015 18:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_GuardarAuditoria]') AND type in (N'P', N'PC'))
BEGIN
DROP PROCEDURE [BrainStormers].[Sp_GuardarAuditoria]
END
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [BrainStormers].[Sp_GuardarAuditoria] (@XmlAuditoria XML)
AS
BEGIN

--DECLARE @XmlAuditoria xml
--set @XmlAuditoria = ''
--<Auditoria>
--  <Username>Administrador</Username>
--  <AccesoCorrecto>false</AccesoCorrecto>
--  <NumeroIntento>1</NumeroIntento>
--</Auditoria>
--'' 
	DECLARE @Identificador INT

	EXEC sp_xml_preparedocument @Identificador OUTPUT
		,@XmlAuditoria


		--CAMPOS DE Auditoria
		DECLARE 
			 @Auditoria_Username [varchar] (255)
			,@Auditoria_AccesoCorrecto [bit]
			,@Auditoria_NumeroIntento [numeric](18,0)
			,@Fecha datetime

		SELECT 
			@Auditoria_Username = Username
			,@Auditoria_AccesoCorrecto = AccesoCorrecto 
			,@Auditoria_NumeroIntento = NumeroIntento 
		FROM OPENXML(@Identificador, ''/Auditoria'', 2) WITH (
				Username [varchar] (255)
				,AccesoCorrecto [bit]
				,NumeroIntento [numeric] (18,0)
				)
		
		SET @Fecha = (select getdate())
		INSERT INTO [BrainStormers].[Auditoria_Login] (Auditoria_Login_Usuario_Username,Auditoria_Login_Fecha, Auditoria_Login_Acceso_Correcto,Auditoria_Login_Numero_Intento)
		VALUES (@Auditoria_Username, @Fecha, @Auditoria_AccesoCorrecto,@Auditoria_NumeroIntento)


	EXEC sp_xml_removedocument @Identificador
END
' 
GO
/****** Object:  StoredProcedure [BrainStormers].[Sp_GuardarCliente]    Script Date: 11/06/2015 18:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_GuardarCliente]') AND type in (N'P', N'PC'))
BEGIN
DROP PROCEDURE [BrainStormers].[Sp_GuardarCliente] 
END

EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [BrainStormers].[Sp_GuardarCliente] (@XmlCliente XML)
AS
BEGIN
	DECLARE @Identificador INT

	EXEC sp_xml_preparedocument @Identificador OUTPUT
		,@XmlCliente

	BEGIN TRY
		--CAMPOS DE CLIENTE
		DECLARE @Cliente_Codigo [numeric] (
			18
			,0
			)
			,@Cliente_Nombre [varchar] (255)
			,@Cliente_Apellido [varchar] (255)
			,@Cliente_Tipo_Doc_Cod [numeric] (
			18
			,0
			)
			,@Cliente_Nro_Doc [numeric] (
			18
			,0
			)
			,@Cliente_Pais_Codigo [numeric] (
			18
			,0
			)
			,@Cliente_Dom_Calle [varchar] (255)
			,@Cliente_Dom_Nro [numeric] (
			18
			,0
			)
			,@Cliente_Dom_Piso [numeric] (
			18
			,0
			)
			,@Cliente_Dom_Depto [varchar] (10)
			,@Cliente_Fecha_Nac [datetime]
			,@Cliente_Mail [varchar] (255)
			,@Cliente_Baja [bit]

		SELECT @Cliente_Codigo = Codigo
			,@Cliente_Nombre = Nombre
			,@Cliente_Apellido = Apellido
			,@Cliente_Tipo_Doc_Cod = Tipo_Doc_Codigo
			,@Cliente_Nro_Doc = Nro_Documento
			,@Cliente_Pais_Codigo = Pais_Codigo
			,@Cliente_Dom_Calle = Domicilio_Calle
			,@Cliente_Dom_Nro = Domicilio_Nro
			,@Cliente_Dom_Piso = Domicilio_Piso
			,@Cliente_Dom_Depto = Domicilio_Depto
			,@Cliente_Fecha_Nac = CONVERT(DATETIME, Fecha_Nacimiento, 104)
			,@Cliente_Mail = Mail
			,@Cliente_Baja = Baja
		FROM OPENXML(@Identificador, ''/Cliente'', 2) WITH (
				Codigo [numeric](18, 0)
				,Nombre [varchar](255)
				,Apellido [varchar](255)
				,Tipo_Doc_Codigo [numeric](18, 0)
				,Nro_Documento [numeric](18, 0)
				,Tipo_Doc_Desc [varchar](255)
				,Pais_Codigo [numeric](18, 0)
				,Domicilio_Calle [varchar](255)
				,Domicilio_Nro [numeric](18, 0)
				,Domicilio_Piso [numeric](18, 0)
				,Domicilio_Depto [varchar](10)
				,Fecha_Nacimiento [varchar](20)
				,Mail [varchar](255)
				,Baja [bit]
				)

		IF @Cliente_Codigo > 0
		BEGIN
			UPDATE BrainStormers.Cliente
			SET Cliente_Nombre = @Cliente_Nombre
				,Cliente_Apellido = @Cliente_Apellido
				,Cliente_Tipo_Doc_Cod = @Cliente_Tipo_Doc_Cod
				,Cliente_Nro_Doc = @Cliente_Nro_Doc
				,Cliente_Pais_Codigo = @Cliente_Pais_Codigo
				,Cliente_Dom_Calle = @Cliente_Dom_Calle
				,Cliente_Dom_Nro = @Cliente_Dom_Nro
				,Cliente_Dom_Piso = @Cliente_Dom_Piso
				,Cliente_Dom_Depto = @Cliente_Dom_Depto
				,Cliente_Fecha_Nac = @Cliente_Fecha_Nac
				,Cliente_Mail = @Cliente_Mail
				,Cliente_Baja = @Cliente_Baja
			WHERE Cliente_Codigo = @Cliente_Codigo
		END
		ELSE
		BEGIN
			INSERT INTO [BrainStormers].[Cliente] (
				[Cliente_Nombre]
				,[Cliente_Apellido]
				,[Cliente_Tipo_Doc_Cod]
				,[Cliente_Nro_Doc]
				,[Cliente_Pais_Codigo]
				,[Cliente_Dom_Calle]
				,[Cliente_Dom_Nro]
				,[Cliente_Dom_Piso]
				,[Cliente_Dom_Depto]
				,[Cliente_Fecha_Nac]
				,[Cliente_Mail]
				,[Cliente_Baja]
				)
			VALUES (
				@Cliente_Nombre
				,@Cliente_Apellido
				,@Cliente_Tipo_Doc_Cod
				,@Cliente_Nro_Doc
				,@Cliente_Pais_Codigo
				,@Cliente_Dom_Calle
				,@Cliente_Dom_Nro
				,@Cliente_Dom_Piso
				,@Cliente_Dom_Depto
				,@Cliente_Fecha_Nac
				,@Cliente_Mail
				,0
				)
		END
	END TRY

	BEGIN CATCH
		DECLARE @ErrorMessage NVARCHAR(4000);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT @ErrorMessage = ERROR_MESSAGE()
			,@ErrorSeverity = ERROR_SEVERITY()
			,@ErrorState = ERROR_STATE();

		RAISERROR (
				@ErrorMessage
				,@ErrorSeverity
				,@ErrorState
				)
	END CATCH

	EXEC sp_xml_removedocument @Identificador
END' 
GO
/****** Object:  StoredProcedure [BrainStormers].[Sp_GuardarCuenta]    Script Date: 11/06/2015 18:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_GuardarCuenta]') AND type in (N'P', N'PC'))
BEGIN
DROP PROCEDURE [BrainStormers].[Sp_GuardarCuenta]
END
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [BrainStormers].[Sp_GuardarCuenta] (@XmlCuenta XML)
AS
BEGIN
	--DECLARE @XmlCuenta XML
	
--	SET @XmlCuenta = ''<Cuenta>
--<EsAlta>1</EsAlta>
--  <Numero>200</Numero>
--  <MonedaCodigo>1</MonedaCodigo>
--  <Pais>1</Pais>
--  <CodCliente>1</CodCliente>
--  <TipoCuenta>2</TipoCuenta>
--  <Estado>2</Estado>
--  <FechaCierre>01/09/2015 0:00:00</FechaCierre>
--  <FechaCreacion>01/10/2015 0:00:00</FechaCreacion>
--</Cuenta>''

	DECLARE @Identificador INT
	
	EXEC sp_xml_preparedocument @Identificador OUTPUT
		,@XmlCuenta

	BEGIN TRY
		--CAMPOS DE Cuenta
		DECLARE @Cuenta_Numero [numeric] (
			18
			,0
			)
			,@Cuenta_Fecha_Creacion [datetime]
			,@Cuenta_Fecha_Cierre [datetime]
			,@Cuenta_Estado [numeric] (
			18
			,0
			)
			,@Cuenta_Pais [numeric] (
			18
			,0
			)
			,@Cuenta_Moneda [numeric] (
			18
			,0
			)
			,@Cuenta_Tipo [numeric] (
			18
			,0
			)
			,@EsAlta BIT
			,@CodCliente [varchar] (255)

		SELECT @Cuenta_Numero = Numero
			,@EsAlta = EsAlta
			,@CodCliente = CodCliente
			,@Cuenta_Fecha_Creacion = CONVERT(DATETIME, FechaCreacion, 104)
			,@Cuenta_Fecha_Cierre = CONVERT(DATETIME, FechaCierre, 104)
			,@Cuenta_Estado = Estado
			,@Cuenta_Pais = Pais
			,@Cuenta_Moneda = MonedaCodigo
			,@Cuenta_Tipo = TipoCuenta
		FROM OPENXML(@Identificador, ''/Cuenta'', 2) WITH (
				Numero [numeric](18, 0)
				,EsAlta [Bit]
				,FechaCreacion [datetime]
				,FechaCierre [datetime]
				,Estado [numeric](18, 0)
				,Pais [numeric](18, 0)
				,MonedaCodigo [numeric](18, 0)
				,TipoCuenta [numeric](18, 0)
				,CodCliente [varchar](255)
				)

		IF @EsAlta <> 1
		BEGIN
			UPDATE [BrainStormers].[Cuenta]
			SET [Cuenta_Fecha_Creacion] = @Cuenta_Fecha_Creacion
				,[Cuenta_Estado] = @Cuenta_Estado
				,[Cuenta_Pais_Codigo] = @Cuenta_Pais
				,[Cuenta_Fecha_Cierre] = @Cuenta_Fecha_Cierre
				,[Cuenta_Moneda] = @Cuenta_Moneda
				,[Cuenta_Tipo] = @Cuenta_Tipo
			WHERE Cuenta_Numero = @Cuenta_Numero
		END
		ELSE
		BEGIN
			INSERT INTO [BrainStormers].[Cuenta] (
				[Cuenta_Numero]
				,[Cuenta_Fecha_Creacion]
				,[Cuenta_Estado]
				,[Cuenta_Pais_Codigo]
				,[Cuenta_Fecha_Cierre]
				,[Cuenta_Moneda]
				,[Cuenta_Tipo]
				,[Cuenta_Cliente]
				,[Cuenta_Saldo]
				)
			VALUES (
				@Cuenta_Numero
				,@Cuenta_Fecha_Creacion
				,1
				,@Cuenta_Pais
				,@Cuenta_Fecha_Cierre
				,@Cuenta_Moneda
				,@Cuenta_Tipo
				,@CodCliente
				,0
				)
		END
	END TRY

	BEGIN CATCH
		DECLARE @ErrorMessage NVARCHAR(4000);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT @ErrorMessage = ERROR_MESSAGE()
			,@ErrorSeverity = ERROR_SEVERITY()
			,@ErrorState = ERROR_STATE();

		RAISERROR (
				@ErrorMessage
				,@ErrorSeverity
				,@ErrorState
				)
	END CATCH

	EXEC sp_xml_removedocument @Identificador
END
' 
GO
/****** Object:  StoredProcedure [BrainStormers].[Sp_GuardarRol]    Script Date: 11/06/2015 18:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_GuardarRol]') AND type in (N'P', N'PC'))
BEGIN
DROP PROCEDURE [BrainStormers].[Sp_GuardarRol]
END
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [BrainStormers].[Sp_GuardarRol] (@XmlRol XML)
AS
BEGIN

--DECLARE @XmlRol xml
--set @XmlRol = ''
--<Rol>
--  <Codigo>0</Codigo>
--  <Nombre>Administrador</Nombre>
--  <Estado>false</Estado>
--  <Funcionalidades>
--    <Funcionalidad>
--      <Codigo>1</Codigo>
--    </Funcionalidad>
--  </Funcionalidades>
--</Rol>
--'' 
	DECLARE @Identificador INT

	EXEC sp_xml_preparedocument @Identificador OUTPUT
		,@XmlRol

	BEGIN TRY
	BEGIN TRANSACTION
		--CAMPOS DE Rol
		DECLARE 
			 @Rol_Codigo [numeric] (18,0)
			,@Rol_Nombre [varchar] (255)
			,@Rol_Estado [bit]

		SELECT 
			@Rol_Codigo = Codigo
			,@Rol_Nombre = Nombre 
			,@Rol_Estado = Estado 
		FROM OPENXML(@Identificador, ''/Rol'', 2) WITH (
				Codigo [numeric] (18,0)
				,Nombre [varchar] (255)
				,Estado [bit]
				)

		IF (@Rol_Codigo IS NOT NULL AND @Rol_Codigo > 0)
		BEGIN
			UPDATE BrainStormers.Rol
			SET Rol_Codigo = @Rol_Codigo,
				Rol_Estado = @Rol_Estado,
				Rol_Nombre = @Rol_Nombre
			WHERE Rol_Codigo = @Rol_Codigo

			DELETE BrainStormers.FuncionalidadesRol
			WHERE FuncRol_Rol_Codigo = @Rol_Codigo
		END
		ELSE
		BEGIN
			SELECT @Rol_Codigo =  isnull(max(rol_codigo),0) + 1 from BrainStormers.Rol			

			INSERT INTO [BrainStormers].[Rol] (Rol_Codigo,Rol_Nombre, Rol_Estado)
			VALUES (@Rol_Codigo, @Rol_Nombre, @Rol_Estado)
		END

		INSERT BrainStormers.FuncionalidadesRol
		SELECT @Rol_Codigo,Codigo 
		FROM OPENXML(@Identificador, ''/Rol/Funcionalidades/Funcionalidad'', 2) WITH (Codigo [numeric] (18,0))

	COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @ErrorMessage NVARCHAR(4000);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT @ErrorMessage = ERROR_MESSAGE()
			,@ErrorSeverity = ERROR_SEVERITY()
			,@ErrorState = ERROR_STATE();

		RAISERROR (
				@ErrorMessage
				,@ErrorSeverity
				,@ErrorState
				)
	END CATCH

	EXEC sp_xml_removedocument @Identificador
END' 
GO
/****** Object:  StoredProcedure [BrainStormers].[Sp_GuardarTransferencia]    Script Date: 11/06/2015 18:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_GuardarTransferencia]') AND type in (N'P', N'PC'))
BEGIN
DROP PROCEDURE [BrainStormers].[Sp_GuardarTransferencia]
END

EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [BrainStormers].[Sp_GuardarTransferencia] (@XmlTransferencia XML)
AS
BEGIN
	
	DECLARE @Identificador INT
	EXEC sp_xml_preparedocument @Identificador OUTPUT
			,@XmlTransferencia

	BEGIN TRY
		BEGIN TRANSACTION

		--DECLARE @XmlTransferencia xml
	--set @XmlTransferencia = ''
	--<Transferencia>
	--  <NroOperacion>0</NroOperacion>
	--  <Importe>1</Importe>
	--  <Costo>100</Costo>
	--  <CuentaDestino>1</CuentaDestino>
	--  <CuentaOrigen>2</CuentaOrigen>
	--  <Fecha>01/01/2015</Fecha>
	--</Transferencia>
	--'' 


		--CAMPOS DE Transferencia
		DECLARE @Transferencia_NroOperacion [varchar] (255)
			,@Transferencia_Importe [numeric] (
			18
			,2
			)
			,@Transferencia_Costo [numeric] (
			18
			,2
			)
			,@Transferencia_CuentaOrigen [numeric] (
			18
			,0
			)
			,@Transferencia_CuentaDestino [numeric] (
			18
			,0
			)
			,@Transferencia_Fecha DATETIME

		SELECT @Transferencia_NroOperacion = NroOperacion
			,@Transferencia_Importe = Importe
			,@Transferencia_Costo = Costo
			,@Transferencia_CuentaOrigen = CuentaOrigen
			,@Transferencia_CuentaDestino = CuentaDestino
			,@Transferencia_Fecha = CONVERT(DATETIME, Fecha, 105)
		FROM OPENXML(@Identificador, ''/Transferencia'', 2) WITH (
				NroOperacion [numeric](18, 2)
				,Importe [numeric](18, 2)
				,Costo [numeric](18, 2)
				,CuentaDestino [numeric](18, 0)
				,CuentaOrigen [numeric](18, 0)
				,Fecha [varchar](255)
				)

		SET @Transferencia_NroOperacion = ISNULL((
					SELECT max(Transf_Nro_Operacion)
					FROM [BrainStormers].[Transferencia]
					), 0) + 1

		INSERT INTO [BrainStormers].[Transferencia] (
			Transf_Nro_Operacion
			,Transf_Fecha
			,Transf_Importe
			,Transf_Costo
			,Transf_Cuenta_Origen
			,Transf_Cuenta_Destino
			)
		VALUES (
			@Transferencia_NroOperacion
			,@Transferencia_Fecha
			,@Transferencia_Importe
			,@Transferencia_Costo
			,@Transferencia_CuentaOrigen
			,@Transferencia_CuentaDestino
			)

		UPDATE BrainStormers.Cuenta
		SET Cuenta_Saldo = Cuenta_Saldo + @Transferencia_Importe
		WHERE Cuenta_Numero = @Transferencia_CuentaDestino

		UPDATE BrainStormers.Cuenta
		SET Cuenta_Saldo = Cuenta_Saldo - @Transferencia_Importe - @Transferencia_Costo
		WHERE Cuenta_Numero = @Transferencia_CuentaOrigen

		COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION

		DECLARE @ErrorMessage NVARCHAR(4000);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT @ErrorMessage = ERROR_MESSAGE()
			,@ErrorSeverity = ERROR_SEVERITY()
			,@ErrorState = ERROR_STATE();

		RAISERROR (
				@ErrorMessage
				,@ErrorSeverity
				,@ErrorState
				)
	END CATCH

	EXEC sp_xml_removedocument @Identificador
END
' 
GO
/****** Object:  StoredProcedure [BrainStormers].[Sp_GuardarUsuario]    Script Date: 11/06/2015 18:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_GuardarUsuario]') AND type in (N'P', N'PC'))
BEGIN
DROP PROCEDURE [BrainStormers].[Sp_GuardarUsuario]
END
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [BrainStormers].[Sp_GuardarUsuario] (@XmlUsuario XML)
AS
BEGIN

--DECLARE @XmlUsuario xml
--set @XmlUsuario = ''
--<Usuario>
--  <Username>Admin</Username>
--  <Password>lala</Password>
--  <FechaCreacion>03/06/2015 22:59:22</FechaCreacion>
--  <FechaUltimaModificacion>06/06/2015 1:36:25</FechaUltimaModificacion>
--  <PreguntaSecreta>kasdjksdkj</PreguntaSecreta>
--  <RespuestaSecreta>kjasdkjsdak</RespuestaSecreta>
--  <CantidadIntentosFallidos>0</CantidadIntentosFallidos>
--  <Inhabilitado>false</Inhabilitado>
--  <EsAlta>false</EsAlta>
--  <Roles>
--    <Rol>
--      <Codigo>1</Codigo>
--    </Rol>
--    <Rol>
--      <Codigo>2</Codigo>
--    </Rol>
--  </Roles>
--</Usuario>
--'' 
	DECLARE @Identificador INT

	EXEC sp_xml_preparedocument @Identificador OUTPUT
		,@XmlUsuario

	BEGIN TRY
	BEGIN TRANSACTION
		--CAMPOS DE USUARIO
		DECLARE 
			 @Usuario_Username [varchar] (255)
			,@Usuario_Password [varchar] (255)
			,@Usuario_FechaCreacion [datetime]
			,@Usuario_FechaUltimaModificacion [datetime]
			,@Usuario_PreguntaSecreta [varchar] (255)
			,@Usuario_RespuestaSecreta [varchar] (255)
			,@Usuario_CantidadIntentosFallidos[numeric](18,0)
			,@Usuario_Inhabilitado [bit]
			,@EsAlta [bit]

		SELECT 
			 @Usuario_Username  = Username 
			,@Usuario_Password  = Password 
			,@Usuario_FechaCreacion = CONVERT(DATETIME, FechaCreacion, 104) 
			,@Usuario_FechaUltimaModificacion = CONVERT(DATETIME, FechaUltimaModificacion, 104)   
			,@Usuario_PreguntaSecreta = PreguntaSecreta 
			,@Usuario_RespuestaSecreta = RespuestaSecreta 
			,@Usuario_CantidadIntentosFallidos = CantidadIntentosFallidos
			,@Usuario_Inhabilitado = Inhabilitado 
			,@EsAlta = EsAlta
		FROM OPENXML(@Identificador, ''/Usuario'', 2) WITH (
				Username [varchar] (255)
			,Password [varchar] (255)
			,FechaCreacion [varchar](30)
			,FechaUltimaModificacion [varchar](30)
			,PreguntaSecreta [varchar] (255)
			,RespuestaSecreta [varchar] (255)
			,CantidadIntentosFallidos [numeric](18,0)
			,Inhabilitado [bit]
			,EsAlta [bit]
				)

		IF @EsAlta = 0
		BEGIN
			UPDATE BrainStormers.Usuario
			SET 
			 Usuario_Password = @Usuario_Password   
			,Usuario_Fecha_Creacion = @Usuario_FechaCreacion 
			,Usuario_Fecha_Ultima_Modificacion = @Usuario_FechaUltimaModificacion 
			,Usuario_Pregunta_Secreta =  @Usuario_PreguntaSecreta
			,Usuario_Respuesta_Secreta = @Usuario_RespuestaSecreta 
			,Usuario_Intentos_Fallidos = @Usuario_CantidadIntentosFallidos
			,Usuario_Inhabilitado =  @Usuario_Inhabilitado
			WHERE Usuario_Username = @Usuario_Username

			DELETE BrainStormers.RolesUsuario
			WHERE RolUsu_Usuario_Username = @Usuario_Username
		END
		ELSE
		BEGIN
			INSERT INTO [BrainStormers].[Usuario] (
				Usuario_Username
			,Usuario_Password 
			,Usuario_Fecha_Creacion 
			,Usuario_Fecha_Ultima_Modificacion
			,Usuario_Pregunta_Secreta
			,Usuario_Respuesta_Secreta
			,Usuario_Intentos_Fallidos
			,Usuario_Inhabilitado 
				)
			VALUES (
				@Usuario_Username
			,@Usuario_Password 
			,@Usuario_FechaCreacion 
			,@Usuario_FechaUltimaModificacion 
			,@Usuario_PreguntaSecreta
			,@Usuario_RespuestaSecreta 
			,0
			,@Usuario_Inhabilitado 
				)
		END
		
		INSERT BrainStormers.RolesUsuario
		SELECT Codigo, @Usuario_Username  
		FROM OPENXML(@Identificador, ''/Usuario/Roles/Rol'', 2) WITH (Codigo [numeric] (18,0))

	COMMIT TRANSACTION
	END TRY

	BEGIN CATCH
		ROLLBACK TRANSACTION
		DECLARE @ErrorMessage NVARCHAR(4000);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT @ErrorMessage = ERROR_MESSAGE()
			,@ErrorSeverity = ERROR_SEVERITY()
			,@ErrorState = ERROR_STATE();

		RAISERROR (
				@ErrorMessage
				,@ErrorSeverity
				,@ErrorState
				)
	END CATCH

	EXEC sp_xml_removedocument @Identificador
END' 
GO
/****** Object:  StoredProcedure [BrainStormers].[Sp_ObtenerClientePorUsuario]    Script Date: 11/06/2015 18:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_ObtenerClientePorUsuario]') AND type in (N'P', N'PC'))
BEGIN
DROP PROCEDURE [BrainStormers].[Sp_ObtenerClientePorUsuario]
END

EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [BrainStormers].[Sp_ObtenerClientePorUsuario]
(
@UsernameXML XML
)
AS
BEGIN

	--DECLARE  @UsernameXML XML
	--SET @UsernameXML = ''<Username>Admin</Username>''

	DECLARE @Username VARCHAR(255)
	DECLARE @Identificador INT

EXEC sp_xml_preparedocument	@Identificador OUTPUT,
							@UsernameXML

SELECT
	@Username = Username
FROM OPENXML(@Identificador, ''/'', 2) WITH (Username [varchar](255))

	SELECT C.[Cliente_Codigo]
		,C.[Cliente_Nombre]
		,C.[Cliente_Apellido]
		,C.[Cliente_Tipo_Doc_Cod]
		,C.[Cliente_Nro_Doc]
		,C.[Cliente_Pais_Codigo]
		,C.[Cliente_Dom_Calle]
		,C.[Cliente_Dom_Nro]
		,C.[Cliente_Dom_Piso]
		,C.[Cliente_Dom_Depto]
		,C.[Cliente_Fecha_Nac]
		,C.[Cliente_Mail]
		,C.Cliente_Usuario
		,P.Pais_Codigo
		,P.Pais_Desc
		,TD.Tipo_Doc_Desc
		,C.Cliente_Baja
	FROM [BrainStormers].[Cliente] C
		INNER JOIN BrainStormers.Pais P 
		ON c.Cliente_Pais_Codigo = P.Pais_Codigo
		INNER JOIN BrainStormers.TipoDocumento TD
		ON C.Cliente_Tipo_Doc_Cod = TD.Tipo_Doc_Cod
	WHERE C.Cliente_Usuario = @Username

EXEC sp_xml_removedocument @Identificador
END' 
GO
/****** Object:  StoredProcedure [BrainStormers].[Sp_ObtenerClientes]    Script Date: 11/06/2015 18:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_ObtenerClientes]') AND type in (N'P', N'PC'))
BEGIN
DROP PROCEDURE [BrainStormers].[Sp_ObtenerClientes]
END

EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [BrainStormers].[Sp_ObtenerClientes]
(
@filtrosXml XML
)
AS
BEGIN

DECLARE @Identificador int

EXEC sp_xml_preparedocument @Identificador OUTPUT, @filtrosXml

DECLARE
	@Cliente_Nombre [varchar](255) ,
	@Cliente_Apellido [varchar](255) ,
	@Cliente_Mail [varchar](255) ,
	@Cliente_Nro_Doc [numeric](18, 0) ,
	@Cliente_Pais_Codigo [numeric](18, 0),
	@Cliente_Tipo_Doc_Codigo [numeric](18, 0),
	@Cliente_Baja [bit] 

SELECT  
	@Cliente_Nombre = Nombre ,
	@Cliente_Apellido = Apellido ,
	@Cliente_Mail  = Mail,
	@Cliente_Nro_Doc = Nro_Documento ,
	@Cliente_Pais_Codigo = Pais_Codigo,
	@Cliente_Tipo_Doc_Codigo = Tipo_Doc,
	@Cliente_Baja = Baja
FROM OPENXML (@Identificador, ''/Filtros'',2)
WITH (
	Nombre [varchar](255) ,
	Apellido [varchar](255) ,
	Mail [varchar](255) ,
	Nro_Documento [numeric](18, 0) ,
	Pais_Codigo [numeric](18, 0),
	Tipo_Doc [numeric](18, 0),
	Baja [bit]
	)

	SELECT C.[Cliente_Codigo]
		,C.[Cliente_Nombre]
		,C.[Cliente_Apellido]
		,C.[Cliente_Tipo_Doc_Cod]
		,C.[Cliente_Nro_Doc]
		,C.[Cliente_Pais_Codigo]
		,C.[Cliente_Dom_Calle]
		,C.[Cliente_Dom_Nro]
		,C.[Cliente_Dom_Piso]
		,C.[Cliente_Dom_Depto]
		,C.[Cliente_Fecha_Nac]
		,C.[Cliente_Mail]
		,P.Pais_Codigo
		,P.Pais_Desc
		,TD.Tipo_Doc_Desc
		,C.Cliente_Baja
	FROM [BrainStormers].[Cliente] C
		INNER JOIN BrainStormers.Pais P 
		ON c.Cliente_Pais_Codigo = P.Pais_Codigo
		INNER JOIN BrainStormers.TipoDocumento TD
		ON C.Cliente_Tipo_Doc_Cod = TD.Tipo_Doc_Cod
	WHERE (@Cliente_Nombre IS NULL OR C.Cliente_Nombre LIKE ''%'' + @Cliente_Nombre + ''%'')
		AND (@Cliente_Apellido IS NULL OR C.Cliente_Apellido LIKE ''%'' + @Cliente_Apellido + ''%'')
		AND (@Cliente_Mail IS NULL OR C.Cliente_Mail LIKE ''%'' + @Cliente_Mail + ''%'')
		AND (@Cliente_Nro_Doc IS NULL OR C.Cliente_Nro_Doc = @Cliente_Nro_Doc)
		AND (@Cliente_Tipo_Doc_Codigo IS NULL OR C.Cliente_Tipo_Doc_Cod = @Cliente_Tipo_Doc_Codigo)
		AND (@Cliente_Pais_Codigo IS NULL OR C.Cliente_Pais_Codigo = @Cliente_Pais_Codigo)
		AND (@Cliente_Baja IS NULL OR C.Cliente_Baja = @Cliente_Baja)

EXEC sp_xml_removedocument @Identificador
END' 
GO
/****** Object:  StoredProcedure [BrainStormers].[Sp_ObtenerCuentasPorCliente]    Script Date: 11/06/2015 18:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_ObtenerCuentasPorCliente]') AND type in (N'P', N'PC'))
BEGIN
DROP PROCEDURE [BrainStormers].[Sp_ObtenerCuentasPorCliente]
END

EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [BrainStormers].[Sp_ObtenerCuentasPorCliente] (@ClienteXML XML)
AS
BEGIN
	--DECLARE  @ClienteCodigoXML XML
	--SET @ClienteCodigoXML = ''<ClienteCodigo>Admin</ClienteCodigo>''
	DECLARE @ClienteCodigo numeric(18,0)
	DECLARE @Identificador INT

	EXEC sp_xml_preparedocument @Identificador OUTPUT
		,@ClienteXML

	SELECT @ClienteCodigo = ClienteCodigo
	FROM OPENXML(@Identificador, ''/'', 2) WITH (ClienteCodigo [numeric](18,0))

	SELECT *
	FROM [BrainStormers].[Cuenta] CU
	INNER JOIN BrainStormers.Estado_Cuenta EC ON EC.Estado_Cuenta_Id = CU.Cuenta_Estado
	INNER JOIN BrainStormers.Tipo_Cuenta TC ON TC.Tipo_Cuenta_Tipo = CU.Cuenta_Tipo
	INNER JOIN BrainStormers.Moneda M ON M.Moneda_Tipo = CU.Cuenta_Moneda
	LEFT JOIN BrainStormers.Pais P ON P.Pais_Codigo = CU.Cuenta_Pais_Codigo

	WHERE CU.Cuenta_Cliente = @ClienteCodigo

	EXEC sp_xml_removedocument @Identificador
END
' 
GO
/****** Object:  StoredProcedure [BrainStormers].[Sp_ObtenerFuncionalidades]    Script Date: 11/06/2015 18:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_ObtenerFuncionalidades]') AND type in (N'P', N'PC'))
BEGIN
DROP PROCEDURE [BrainStormers].[Sp_ObtenerFuncionalidades]
END
EXEC dbo.sp_executesql @statement = N'create procedure [BrainStormers].[Sp_ObtenerFuncionalidades]
as
begin
	select * from BrainStormers.Funcionalidad
end ' 
GO
/****** Object:  StoredProcedure [BrainStormers].[Sp_ObtenerPaises]    Script Date: 11/06/2015 18:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_ObtenerPaises]') AND type in (N'P', N'PC'))
BEGIN
DROP PROCEDURE [BrainStormers].[Sp_ObtenerPaises]
END

EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [BrainStormers].[Sp_ObtenerPaises]
	AS
	BEGIN
		SELECT Pais_Codigo, Pais_Desc
		FROM BrainStormers.Pais
		Order by Pais_Desc ASC
	END' 
GO
/****** Object:  StoredProcedure [BrainStormers].[Sp_ObtenerRoles]    Script Date: 11/06/2015 18:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_ObtenerRoles]') AND type in (N'P', N'PC'))
BEGIN
DROP PROCEDURE [BrainStormers].[Sp_ObtenerRoles]
END

EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [BrainStormers].[Sp_ObtenerRoles] (@filtrosXml XML)
AS
BEGIN
	DECLARE @Identificador INT

	EXEC sp_xml_preparedocument @Identificador OUTPUT
		,@filtrosXml

	DECLARE @Rol_Nombre [varchar] (255)

	SELECT @Rol_Nombre = Nombre
	FROM OPENXML(@Identificador, ''/Filtros'', 2) WITH (Nombre [varchar](255))

	SELECT R.Rol_Codigo
		,R.Rol_Nombre
		,R.Rol_Estado
		,FR.FuncRol_Rol_Codigo
		,F.Func_Codigo
		,F.Func_Desc
	FROM [BrainStormers].[Rol] R
	LEFT JOIN [BrainStormers].[FuncionalidadesRol] FR ON FR.[FuncRol_Rol_Codigo] = R.[Rol_Codigo]
	LEFT JOIN [BrainStormers].[Funcionalidad] F ON FR.[FuncRol_Func_Codigo] = F.Func_Codigo
	WHERE @Rol_Nombre is NULL OR R.Rol_Nombre LIKE ''%'' + @Rol_Nombre+ ''%''


	--SELECT C.[Rol_Codigo]
	--FROM [BrainStormers].[Rol] C
	--	INNER JOIN BrainStormers.Pais P 
	--	ON c.Rol_Pais_Codigo = P.Pais_Codigo
	--	INNER JOIN BrainStormers.TipoDocumento TD
	--	ON C.Rol_Tipo_Doc_Cod = TD.Tipo_Doc_Cod
	--WHERE (@Rol_Nombre IS NULL OR C.Rol_Nombre LIKE ''''%'''' + @Rol_Nombre + ''''%'''')
	EXEC sp_xml_removedocument @Identificador
END
' 
GO
/****** Object:  StoredProcedure [BrainStormers].[Sp_ObtenerUsuarioPorUsername]    Script Date: 11/06/2015 18:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_ObtenerUsuarioPorUsername]') AND type in (N'P', N'PC'))
BEGIN
DROP PROCEDURE [BrainStormers].[Sp_ObtenerUsuarioPorUsername]
END

EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [BrainStormers].[Sp_ObtenerUsuarioPorUsername] (@UsernameXML XML)
AS
BEGIN
	--DECLARE  @UsernameXML XML
	--SET @UsernameXML = ''<Username>Admin</Username>''

	DECLARE @Username VARCHAR(255)
	DECLARE @Identificador INT

EXEC sp_xml_preparedocument	@Identificador OUTPUT,
							@UsernameXML

SELECT
	@Username = Username
FROM OPENXML(@Identificador, ''/'', 2) WITH (Username [varchar](255))


SELECT
	U.[Usuario_Username],
	U.[Usuario_Password],
	U.[Usuario_Fecha_Creacion],
	U.[Usuario_Fecha_Ultima_Modificacion],
	U.[Usuario_Pregunta_Secreta],
	U.[Usuario_Respuesta_Secreta],
	U.Usuario_Intentos_Fallidos,
	U.[Usuario_Inhabilitado],
	R.Rol_Codigo,
	R.Rol_Nombre,
	R.Rol_Estado,
	F.Func_Codigo,
	F.Func_Desc
FROM [BrainStormers].[Usuario] U
LEFT JOIN [BrainStormers].[RolesUsuario] RU
	ON RU.RolUsu_Usuario_Username = U.Usuario_Username
LEFT JOIN [BrainStormers].[Rol] R
	ON R.Rol_Codigo = RU.RolUsu_Rol_Codigo
LEFT JOIN [BrainStormers].[FuncionalidadesRol] FR
	ON FR.[FuncRol_Rol_Codigo] = R.[Rol_Codigo]
LEFT JOIN [BrainStormers].[Funcionalidad] F
	ON FR.[FuncRol_Func_Codigo] = F.Func_Codigo
WHERE Usuario_Username = @Username

EXEC sp_xml_removedocument @Identificador
END' 
GO
/****** Object:  StoredProcedure [BrainStormers].[Sp_ObtenerUsuarios]    Script Date: 11/06/2015 18:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_ObtenerUsuarios]') AND type in (N'P', N'PC'))
BEGIN
DROP PROCEDURE [BrainStormers].[Sp_ObtenerUsuarios]
END

EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [BrainStormers].[Sp_ObtenerUsuarios] (@filtrosXml XML)
AS
BEGIN
	--declare @filtrosXml xml
	--set @filtrosXml = ''<filtros/>''
	DECLARE @Identificador INT

	EXEC sp_xml_preparedocument @Identificador OUTPUT
		,@filtrosXml

	DECLARE @Usuario_Username [varchar] (255)

	SELECT @Usuario_Username = Username
	FROM OPENXML(@Identificador, ''/Filtros'', 2) WITH (Username [varchar](255))

	SELECT U.[Usuario_Username]
		,U.[Usuario_Password]
		,U.[Usuario_Fecha_Creacion]
		,U.[Usuario_Fecha_Ultima_Modificacion]
		,U.[Usuario_Pregunta_Secreta]
		,U.[Usuario_Respuesta_Secreta]
		,U.Usuario_Intentos_Fallidos
		,U.[Usuario_Inhabilitado]
		,R.Rol_Codigo
		,R.Rol_Nombre
		,R.Rol_Estado
		,F.Func_Codigo
		,F.Func_Desc
	FROM [BrainStormers].[Usuario] U
	LEFT JOIN [BrainStormers].[RolesUsuario] RU ON RU.RolUsu_Usuario_Username = U.Usuario_Username
	LEFT JOIN [BrainStormers].[Rol] R ON R.Rol_Codigo = RU.RolUsu_Rol_Codigo
	LEFT JOIN [BrainStormers].[FuncionalidadesRol] FR ON FR.[FuncRol_Rol_Codigo] = R.[Rol_Codigo]
	LEFT JOIN [BrainStormers].[Funcionalidad] F ON FR.[FuncRol_Func_Codigo] = F.Func_Codigo
	WHERE @Usuario_Username IS NULL
		OR U.Usuario_Username LIKE ''%'' + @Usuario_Username + ''%''

	EXEC sp_xml_removedocument @Identificador
END
' 
GO

USE [GD1C2015]
GO
INSERT [BrainStormers].[Estado_Cuenta] ([Estado_Cuenta_Id], [Estado_Cuenta_Desc]) VALUES (CAST(1 AS Numeric(18, 0)), N'Pendiente de activación')
GO
INSERT [BrainStormers].[Estado_Cuenta] ([Estado_Cuenta_Id], [Estado_Cuenta_Desc]) VALUES (CAST(2 AS Numeric(18, 0)), N'Cerrada')
GO
INSERT [BrainStormers].[Estado_Cuenta] ([Estado_Cuenta_Id], [Estado_Cuenta_Desc]) VALUES (CAST(3 AS Numeric(18, 0)), N'Inhabilitada')
GO
INSERT [BrainStormers].[Estado_Cuenta] ([Estado_Cuenta_Id], [Estado_Cuenta_Desc]) VALUES (CAST(4 AS Numeric(18, 0)), N'Habilitada')
GO
INSERT [BrainStormers].[Funcionalidad] ([Func_Codigo], [Func_Desc]) VALUES (CAST(1 AS Numeric(18, 0)), N'ABM de Rol')
GO
INSERT [BrainStormers].[Funcionalidad] ([Func_Codigo], [Func_Desc]) VALUES (CAST(2 AS Numeric(18, 0)), N'ABM de Usuario')
GO
INSERT [BrainStormers].[Funcionalidad] ([Func_Codigo], [Func_Desc]) VALUES (CAST(3 AS Numeric(18, 0)), N'ABM de Cliente')
GO
INSERT [BrainStormers].[Funcionalidad] ([Func_Codigo], [Func_Desc]) VALUES (CAST(4 AS Numeric(18, 0)), N'ABM de Cuenta')
GO
INSERT [BrainStormers].[Funcionalidad] ([Func_Codigo], [Func_Desc]) VALUES (CAST(5 AS Numeric(18, 0)), N'Depósitos')
GO
INSERT [BrainStormers].[Funcionalidad] ([Func_Codigo], [Func_Desc]) VALUES (CAST(6 AS Numeric(18, 0)), N'Retiro de Efectivo')
GO
INSERT [BrainStormers].[Funcionalidad] ([Func_Codigo], [Func_Desc]) VALUES (CAST(7 AS Numeric(18, 0)), N'Transferencias entre cuentas')
GO
INSERT [BrainStormers].[Funcionalidad] ([Func_Codigo], [Func_Desc]) VALUES (CAST(8 AS Numeric(18, 0)), N'Facturación de Costos')
GO
INSERT [BrainStormers].[Funcionalidad] ([Func_Codigo], [Func_Desc]) VALUES (CAST(9 AS Numeric(18, 0)), N'Consulta de saldos')
GO
INSERT [BrainStormers].[Funcionalidad] ([Func_Codigo], [Func_Desc]) VALUES (CAST(10 AS Numeric(18, 0)), N'Listado Estadístico')
GO
INSERT [BrainStormers].[Moneda] ([Moneda_Tipo], [Moneda_Desc]) VALUES (CAST(1 AS Numeric(18, 0)), N'Dolares')
GO
INSERT [BrainStormers].[Rol] ([Rol_Codigo], [Rol_Nombre], [Rol_Estado]) VALUES (CAST(1 AS Numeric(18, 0)), N'Administrador', 0)
GO
INSERT [BrainStormers].[Rol] ([Rol_Codigo], [Rol_Nombre], [Rol_Estado]) VALUES (CAST(2 AS Numeric(18, 0)), N'Cliente', 0)
GO
GO
INSERT [BrainStormers].[Tipo_Cuenta] ([Tipo_Cuenta_Tipo], [Tipo_Cuenta_Desc], [Tipo_Cuenta_Dias_Duracion], [Tipo_Cuenta_Costo]) VALUES (CAST(1 AS Numeric(18, 0)), N'Gratuita', NULL, CAST(0 AS Numeric(18, 0)))
GO
INSERT [BrainStormers].[Tipo_Cuenta] ([Tipo_Cuenta_Tipo], [Tipo_Cuenta_Desc], [Tipo_Cuenta_Dias_Duracion], [Tipo_Cuenta_Costo]) VALUES (CAST(2 AS Numeric(18, 0)), N'Bronce', CAST(30 AS Numeric(18, 0)), CAST(500 AS Numeric(18, 0)))
GO
INSERT [BrainStormers].[Tipo_Cuenta] ([Tipo_Cuenta_Tipo], [Tipo_Cuenta_Desc], [Tipo_Cuenta_Dias_Duracion], [Tipo_Cuenta_Costo]) VALUES (CAST(3 AS Numeric(18, 0)), N'Plata', CAST(60 AS Numeric(18, 0)), CAST(1000 AS Numeric(18, 0)))
GO
INSERT [BrainStormers].[Tipo_Cuenta] ([Tipo_Cuenta_Tipo], [Tipo_Cuenta_Desc], [Tipo_Cuenta_Dias_Duracion], [Tipo_Cuenta_Costo]) VALUES (CAST(4 AS Numeric(18, 0)), N'Oro', CAST(90 AS Numeric(18, 0)), CAST(1200 AS Numeric(18, 0)))
GO
INSERT [BrainStormers].[TipoDocumento] ([Tipo_Doc_Cod], [Tipo_Doc_Desc]) VALUES (CAST(10002 AS Numeric(18, 0)), N'Pasaporte')
GO

insert BrainStormers.FuncionalidadesRol
select 1, Func_Codigo
from BrainStormers.Funcionalidad

insert BrainStormers.FuncionalidadesRol
select 2, Func_Codigo
FROM BrainStormers.Funcionalidad
WHERE Func_Codigo > 3


INSERT BrainStormers.Pais
SELECT DISTINCT Cli_Pais_Desc from gd_esquema.Maestra where Cli_Pais_Desc is not NULL 
UNION
SELECT DISTINCT Cli_Pais_Desc from gd_esquema.Maestra where Cli_Pais_Desc is not null
UNION
SELECT DISTINCT Cuenta_Dest_Pais_Desc from gd_esquema.Maestra where Cuenta_Dest_Pais_Desc is  not null

DECLARE @fecha datetime
set @fecha = GETDATE()

INSERT   BrainStormers.Usuario
SELECT DISTINCT  SUBSTRING(Cli_Nombre,1,1) + Cli_Apellido + CONVERT(varchar(4), YEAR(Cli_Fecha_Nac)) , '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4' , @fecha, NULL, '', '',0,0
FROM gd_esquema.Maestra 
UNION
SELECT 'Admin', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4' , @fecha, NULL, '', '',0,0

INSERT  BrainStormers.Cliente
SELECT DISTINCT Cli_Nombre,Cli_Apellido, Cli_Tipo_Doc_Cod, Cli_Nro_Doc, P.Pais_Codigo, Cli_Dom_Calle, Cli_Dom_Nro, 
				Cli_Dom_Piso, Cli_Dom_Depto, Cli_Fecha_Nac, Cli_Mail, 0, SUBSTRING(Cli_Nombre,1,1) + Cli_Apellido + CONVERT(varchar(4), YEAR(Cli_Fecha_Nac)) 
FROM gd_esquema.Maestra M
INNER JOIN BrainStormers.Pais P
on P.Pais_Desc = M.Cli_Pais_Desc

insert BrainStormers.RolesUsuario
SELECT 2, Usuario_Username  FROM BrainStormers.Usuario where Usuario_Username <> 'Admin'
UNION
SELECT 1, 'Admin'

INSERT  BrainStormers.Cuenta
SELECT DISTINCT M.Cuenta_Numero, M.Cuenta_Fecha_Creacion, 4, P.Pais_Codigo, M.Cuenta_Fecha_Cierre, 1, 1,C.Cliente_Codigo, 0
FROM gd_esquema.Maestra M
JOIN BrainStormers.Pais P ON P.Pais_Desc = M.Cuenta_Pais_Desc
JOIN BrainStormers.Cliente C ON C.Cliente_Usuario = SUBSTRING(Cli_Nombre,1,1) + Cli_Apellido + CONVERT(varchar(4), YEAR(Cli_Fecha_Nac))

--COMMIT TRANSACTION

