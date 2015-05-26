USE [GD1C2015]
GO

BEGIN TRY
	BEGIN TRANSACTION

	/********************/
	/*CREACION DE ESQUEMA*/
	/********************/
	IF NOT EXISTS (
			SELECT 1
			FROM sys.schemas
			WHERE NAME = 'BrainStormers'
			)
	BEGIN
		EXEC ('CREATE SCHEMA [BrainStormers] AUTHORIZATION [gd]')
	END

	/********************/
	/*CREACION DE TABLAS*/
	/********************/
	IF OBJECT_ID(N'[BrainStormers].[Cliente]', N'U') IS NOT NULL
		DROP TABLE [BrainStormers].[Cliente]

	IF OBJECT_ID(N'[BrainStormers].[Pais]', N'U') IS NOT NULL
		DROP TABLE [BrainStormers].[Pais]

	IF OBJECT_ID(N'[BrainStormers].[TipoDocumento]', N'U') IS NOT NULL
		DROP TABLE [BrainStormers].[TipoDocumento]

	--CREO LA TABLA DE PAISES
	CREATE TABLE [BrainStormers].[Pais] (
		[Pais_Codigo] [numeric](18, 0) NOT NULL
		,[Pais_Desc] [varchar](250) NULL
		,CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED ([Pais_Codigo] ASC)
		) ON [PRIMARY]

	--CREO la TABLA TIPODOCUMENTO
	CREATE TABLE [BrainStormers].[TipoDocumento] (
		[Tipo_Doc_Cod] [numeric](18, 0) NOT NULL
		,[Tipo_Doc_Desc] [varchar](255) NULL
		,CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED ([Tipo_Doc_Cod] ASC) WITH (
			PAD_INDEX = OFF
			,STATISTICS_NORECOMPUTE = OFF
			,IGNORE_DUP_KEY = OFF
			,ALLOW_ROW_LOCKS = ON
			,ALLOW_PAGE_LOCKS = ON
			) ON [PRIMARY]
		) ON [PRIMARY]

	--CREO LA TABLA DE CLIENTES
	CREATE TABLE [BrainStormers].[Cliente] (
		[Cliente_Codigo] [numeric](18, 0) NOT NULL IDENTITY(1, 1)
		,[Cliente_Nombre] [varchar](255) NULL
		,[Cliente_Apellido] [varchar](255) NULL
		,[Cliente_Tipo_Doc_Cod] [numeric](18, 0) NULL
		,[Cliente_Nro_Doc] [numeric](18, 0) NULL
		,[Cliente_Pais_Codigo] [numeric](18, 0) NOT NULL
		,[Cliente_Dom_Calle] [varchar](255) NULL
		,[Cliente_Dom_Nro] [numeric](18, 0) NULL
		,[Cliente_Dom_Piso] [numeric](18, 0) NULL
		,[Cliente_Dom_Depto] [varchar](10) NULL
		,[Cliente_Fecha_Nac] [datetime] NULL
		,[Cliente_Mail] [varchar](255) NULL
		,[Cliente_Baja] [bit] NULL
		,CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED ([Cliente_Codigo] ASC)
		,CONSTRAINT U_Cliente_Mail UNIQUE ([Cliente_Mail])
		,CONSTRAINT [U_Documento] UNIQUE NONCLUSTERED (
			[Cliente_Tipo_Doc_Cod]
			,[Cliente_Nro_Doc]
			)
		) ON [PRIMARY]

	ALTER TABLE [BrainStormers].[Cliente]
		WITH CHECK ADD CONSTRAINT [FK_Cliente_Pais] FOREIGN KEY ([Cliente_Pais_Codigo]) REFERENCES [BrainStormers].[Pais]([Pais_Codigo])

	ALTER TABLE [BrainStormers].[Cliente] CHECK CONSTRAINT [FK_Cliente_Pais]

	ALTER TABLE [BrainStormers].[Cliente]
		WITH CHECK ADD CONSTRAINT [FK_Cliente_TipoDocumento] FOREIGN KEY ([Cliente_Tipo_Doc_Cod]) REFERENCES [BrainStormers].[TipoDocumento]([Tipo_Doc_Cod])

	ALTER TABLE [BrainStormers].[Cliente] CHECK CONSTRAINT [FK_Cliente_TipoDocumento]

	--CARGO LA TABLA PAIS
	INSERT INTO BrainStormers.Pais
	SELECT DISTINCT Cli_Pais_Codigo
		,Cli_Pais_Desc
	FROM gd_esquema.Maestra

	--CARGO LA TABLA DE TIPOS DE DOCUMENTO
	INSERT [BrainStormers].[TipoDocumento]
	SELECT DISTINCT Cli_Tipo_Doc_Cod
		,Cli_Tipo_Doc_Desc
	FROM gd_esquema.Maestra

	--CARGO LA TABLA CLIENTES
	INSERT INTO BrainStormers.Cliente
	SELECT DISTINCT Cli_Nombre
		,Cli_Apellido
		,Cli_Tipo_Doc_Cod
		,Cli_Nro_Doc
		,Cli_Pais_Codigo
		,Cli_Dom_Calle
		,Cli_Dom_Nro
		,Cli_Dom_Piso
		,Cli_Dom_Depto
		,Cli_Fecha_Nac
		,Cli_Mail
		,0 --Por defecto ningun cliente esta dado de baja.
	FROM gd_esquema.Maestra

	/*******************************/
	/*CREACION DE STORED PROCEDURES*/
	/*******************************/
	IF EXISTS (
			SELECT *
			FROM sys.objects
			WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_ObtenerPaises]')
				AND type IN (
					N'P'
					,N'PC'
					)
			)
		DROP PROCEDURE [BrainStormers].[Sp_ObtenerPaises]

	EXEC (
			'CREATE PROCEDURE [BrainStormers].[Sp_ObtenerPaises]
	AS
	BEGIN
		SELECT Pais_Codigo, Pais_Desc
		FROM BrainStormers.Pais
		Order by Pais_Desc ASC
	END'
			)

	IF EXISTS (
			SELECT *
			FROM sys.objects
			WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_EliminarCliente]')
				AND type IN (
					N'P'
					,N'PC'
					)
			)
		DROP PROCEDURE [BrainStormers].[Sp_EliminarCliente]

	EXEC (
			'CREATE PROCEDURE [BrainStormers].[Sp_EliminarCliente] (@Codigo NUMERIC(18, 0))
AS
BEGIN
	UPDATE BrainStormers.Cliente
	SET Cliente_baja = 1
	WHERE Cliente_Codigo = @Codigo
END'
			)

	IF EXISTS (
			SELECT *
			FROM sys.objects
			WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_ObtenerClientes]')
				AND type IN (
					N'P'
					,N'PC'
					)
			)
		DROP PROCEDURE [BrainStormers].[Sp_ObtenerClientes]

	EXEC (
			'CREATE PROCEDURE [BrainStormers].[Sp_ObtenerClientes]
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
			)

	IF EXISTS (
			SELECT *
			FROM sys.objects
			WHERE object_id = OBJECT_ID(N'[BrainStormers].[Sp_GuardarCliente]')
				AND type IN (
					N'P'
					,N'PC'
					)
			)
		DROP PROCEDURE [BrainStormers].[Sp_GuardarCliente]

	EXEC (
			'CREATE PROCEDURE [BrainStormers].[Sp_GuardarCliente] (@XmlCliente XML)
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
			)

	COMMIT TRANSACTION
END TRY

BEGIN CATCH
	SELECT ERROR_MESSAGE()

	ROLLBACK TRANSACTION
END CATCH
