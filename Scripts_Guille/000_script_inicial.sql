--CREO EL ESQUEMA
USE [GD1C2015]
GO

/****** Object:  Schema [gd_esquema]    Script Date: 04/15/2012 01:58:54 ******/
CREATE SCHEMA [BrainStormers] AUTHORIZATION [gd]
GO

--CREO LA TABLA DE PAISES
CREATE TABLE [BrainStormers].[Pais] (
	[Pais_Codigo] [numeric](18, 0) NOT NULL
	,[Pais_Desc] [varchar](250) NULL
	,CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED ([Pais_Codigo] ASC)
	) ON [PRIMARY]
GO

--CREO LA TABLA DE CLIENTES
CREATE TABLE [BrainStormers].[Cliente] (
	[Cliente_Codigo] [numeric](18, 0) NOT NULL IDENTITY(1, 1)
	,[Cliente_Nombre] [varchar](255) NULL
	,[Cliente_Apellido] [varchar](255) NULL
	,[Cliente_Tipo_Doc_Cod] [numeric](18, 0) NULL
	,[Cliente_Nro_Doc] [numeric](18, 0) NULL
	,[Cliente_Tipo_Doc_Desc] [varchar](255) NULL
	,[Cliente_Pais_Codigo] [numeric](18, 0) NOT NULL
	,[Cliente_Dom_Calle] [varchar](255) NULL
	,[Cliente_Dom_Nro] [numeric](18, 0) NULL
	,[Cliente_Dom_Piso] [numeric](18, 0) NULL
	,[Cliente_Dom_Depto] [varchar](10) NULL
	,[Cliente_Fecha_Nac] [datetime] NULL
	,[Cliente_Mail] [varchar](255) NULL
	,CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED ([Cliente_Codigo] ASC)
	) ON [PRIMARY]
GO

ALTER TABLE [BrainStormers].[Cliente]
	WITH CHECK ADD CONSTRAINT [FK_Cliente_Pais] FOREIGN KEY ([Cliente_Pais_Codigo]) REFERENCES [BrainStormers].[Pais]([Pais_Codigo])
GO

ALTER TABLE [BrainStormers].[Cliente] CHECK CONSTRAINT [FK_Cliente_Pais]
GO

--CARGO LA TABLA PAIS
INSERT INTO BrainStormers.Pais
SELECT DISTINCT Cli_Pais_Codigo
	,Cli_Pais_Desc
FROM gd_esquema.Maestra

--CARGO LA TABLA CLIENTES
INSERT INTO BrainStormers.Cliente
SELECT DISTINCT Cli_Nombre
	,Cli_Apellido
	,Cli_Tipo_Doc_Cod
	,Cli_Nro_Doc
	,Cli_Tipo_Doc_Desc
	,Cli_Pais_Codigo
	,Cli_Dom_Calle
	,Cli_Dom_Nro
	,Cli_Dom_Piso
	,Cli_Dom_Depto
	,Cli_Fecha_Nac
	,Cli_Mail
FROM gd_esquema.Maestra
