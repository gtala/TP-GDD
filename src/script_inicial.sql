--USE [master]
--GO
--/****** Object:  Database [GD1C2015]    Script Date: 06/06/2015 19:26:33 ******/
--CREATE DATABASE [GD1C2015]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'GD1C2015', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER2008\MSSQL\DATA\GD1C2015.mdf' , SIZE = 325632KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
-- LOG ON 
--( NAME = N'GD1C2015_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER2008\MSSQL\DATA\GD1C2015_log.ldf' , SIZE = 568896KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
--GO
--ALTER DATABASE [GD1C2015] SET COMPATIBILITY_LEVEL = 110
--GO
--IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
--begin
--EXEC [GD1C2015].[dbo].[sp_fulltext_database] @action = 'enable'
--end
--GO
--ALTER DATABASE [GD1C2015] SET ANSI_NULL_DEFAULT OFF 
--GO
--ALTER DATABASE [GD1C2015] SET ANSI_NULLS OFF 
--GO
--ALTER DATABASE [GD1C2015] SET ANSI_PADDING OFF 
--GO
--ALTER DATABASE [GD1C2015] SET ANSI_WARNINGS OFF 
--GO
--ALTER DATABASE [GD1C2015] SET ARITHABORT OFF 
--GO
--ALTER DATABASE [GD1C2015] SET AUTO_CLOSE OFF 
--GO
--ALTER DATABASE [GD1C2015] SET AUTO_CREATE_STATISTICS ON 
--GO
--ALTER DATABASE [GD1C2015] SET AUTO_SHRINK OFF 
--GO
--ALTER DATABASE [GD1C2015] SET AUTO_UPDATE_STATISTICS ON 
--GO
--ALTER DATABASE [GD1C2015] SET CURSOR_CLOSE_ON_COMMIT OFF 
--GO
--ALTER DATABASE [GD1C2015] SET CURSOR_DEFAULT  GLOBAL 
--GO
--ALTER DATABASE [GD1C2015] SET CONCAT_NULL_YIELDS_NULL OFF 
--GO
--ALTER DATABASE [GD1C2015] SET NUMERIC_ROUNDABORT OFF 
--GO
--ALTER DATABASE [GD1C2015] SET QUOTED_IDENTIFIER OFF 
--GO
--ALTER DATABASE [GD1C2015] SET RECURSIVE_TRIGGERS OFF 
--GO
--ALTER DATABASE [GD1C2015] SET  DISABLE_BROKER 
--GO
--ALTER DATABASE [GD1C2015] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
--GO
--ALTER DATABASE [GD1C2015] SET DATE_CORRELATION_OPTIMIZATION OFF 
--GO
--ALTER DATABASE [GD1C2015] SET TRUSTWORTHY OFF 
--GO
--ALTER DATABASE [GD1C2015] SET ALLOW_SNAPSHOT_ISOLATION OFF 
--GO
--ALTER DATABASE [GD1C2015] SET PARAMETERIZATION SIMPLE 
--GO
--ALTER DATABASE [GD1C2015] SET READ_COMMITTED_SNAPSHOT OFF 
--GO
--ALTER DATABASE [GD1C2015] SET HONOR_BROKER_PRIORITY OFF 
--GO
--ALTER DATABASE [GD1C2015] SET RECOVERY FULL 
--GO
--ALTER DATABASE [GD1C2015] SET  MULTI_USER 
--GO
--ALTER DATABASE [GD1C2015] SET PAGE_VERIFY CHECKSUM  
--GO
--ALTER DATABASE [GD1C2015] SET DB_CHAINING OFF 
--GO
--ALTER DATABASE [GD1C2015] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
--GO
--ALTER DATABASE [GD1C2015] SET TARGET_RECOVERY_TIME = 0 SECONDS 
--GO
--EXEC sys.sp_db_vardecimal_storage_format N'GD1C2015', N'ON'
--GO
--USE [GD1C2015]
--GO
--/****** Object:  User [gd]    Script Date: 06/06/2015 19:26:34 ******/
--CREATE USER [gd] FOR LOGIN [gd] WITH DEFAULT_SCHEMA=[dbo]
--GO
/****** Object:  Schema [Brainstormers]    Script Date: 06/06/2015 19:26:34 ******/
--CREATE SCHEMA [Brainstormers]
--GO
--/****** Object:  Schema [gd_esquema]    Script Date: 06/06/2015 19:26:34 ******/
--CREATE SCHEMA [gd_esquema]
--GO
--/****** Object:  StoredProcedure [Brainstormers].[Sp_EliminarCliente]    Script Date: 06/06/2015 19:26:34 ******/
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO

USE [GD1C2015]
GO

CREATE PROCEDURE [Brainstormers].[Sp_EliminarCliente] (@Codigo NUMERIC(18, 0))
AS
BEGIN
	UPDATE Brainstormers.Cliente
	SET Cliente_baja = 1
	WHERE Cliente_Codigo = @Codigo
END
GO
/****** Object:  StoredProcedure [Brainstormers].[Sp_EliminarRol]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Brainstormers].[Sp_EliminarRol] (@Codigo NUMERIC(18, 0))
AS
BEGIN
	UPDATE Brainstormers.Rol
	SET Rol_Estado = 1
	WHERE Rol_Codigo = @Codigo
END
GO
/****** Object:  StoredProcedure [Brainstormers].[Sp_EliminarUsuario]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Brainstormers].[Sp_EliminarUsuario] (@Username VARCHAR(255))
AS
BEGIN
	UPDATE Brainstormers.Usuario
	SET Usuario_Inhabilitado  = 1
	WHERE Usuario_Username = @Username
END
GO
/****** Object:  StoredProcedure [Brainstormers].[Sp_GuardarCliente]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Brainstormers].[Sp_GuardarCliente] (@XmlCliente XML)
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
		FROM OPENXML(@Identificador, '/Cliente', 2) WITH (
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
			UPDATE Brainstormers.Cliente
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
			INSERT INTO [Brainstormers].[Cliente] (
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
END
GO
/****** Object:  StoredProcedure [Brainstormers].[Sp_GuardarRol]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Brainstormers].[Sp_GuardarRol] (@XmlRol XML)
AS
BEGIN

--DECLARE @XmlRol xml
--set @XmlRol = '
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
--' 
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
		FROM OPENXML(@Identificador, '/Rol', 2) WITH (
				Codigo [numeric] (18,0)
				,Nombre [varchar] (255)
				,Estado [bit]
				)

		IF (@Rol_Codigo IS NOT NULL AND @Rol_Codigo > 0)
		BEGIN
			UPDATE Brainstormers.Rol
			SET Rol_Codigo = @Rol_Codigo,
				Rol_Estado = @Rol_Estado,
				Rol_Nombre = @Rol_Nombre
			WHERE Rol_Codigo = @Rol_Codigo

			DELETE Brainstormers.FuncionalidadesRol
			WHERE FuncRol_Rol_Codigo = @Rol_Codigo
		END
		ELSE
		BEGIN
			SELECT @Rol_Codigo =  isnull(max(rol_codigo),0) + 1 from Brainstormers.Rol			

			INSERT INTO [Brainstormers].[Rol] (Rol_Codigo,Rol_Nombre, Rol_Estado)
			VALUES (@Rol_Codigo, @Rol_Nombre, @Rol_Estado)
		END

		INSERT Brainstormers.FuncionalidadesRol
		SELECT @Rol_Codigo,Codigo 
		FROM OPENXML(@Identificador, '/Rol/Funcionalidades/Funcionalidad', 2) WITH (Codigo [numeric] (18,0))

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
GO
/****** Object:  StoredProcedure [Brainstormers].[Sp_GuardarUsuario]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Brainstormers].[Sp_GuardarUsuario] (@XmlUsuario XML)
AS
BEGIN

--DECLARE @XmlUsuario xml
--set @XmlUsuario = '
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
--' 
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
		FROM OPENXML(@Identificador, '/Usuario', 2) WITH (
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
			UPDATE Brainstormers.Usuario
			SET 
			 Usuario_Password = @Usuario_Password   
			,Usuario_Fecha_Creacion = @Usuario_FechaCreacion 
			,Usuario_Fecha_Ultima_Modificacion = @Usuario_FechaUltimaModificacion 
			,Usuario_Pregunta_Secreta =  @Usuario_PreguntaSecreta
			,Usuario_Respuesta_Secreta = @Usuario_RespuestaSecreta 
			,Usuario_Intentos_Fallidos = @Usuario_CantidadIntentosFallidos
			,Usuario_Inhabilitado =  @Usuario_Inhabilitado
			WHERE Usuario_Username = @Usuario_Username

			DELETE Brainstormers.RolesUsuario
			WHERE RolUsu_Usuario_Username = @Usuario_Username
		END
		ELSE
		BEGIN
			INSERT INTO [Brainstormers].[Usuario] (
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
		
		INSERT Brainstormers.RolesUsuario
		SELECT Codigo, @Usuario_Username  
		FROM OPENXML(@Identificador, '/Usuario/Roles/Rol', 2) WITH (Codigo [numeric] (18,0))

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
GO
/****** Object:  StoredProcedure [Brainstormers].[Sp_ObtenerClientes]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Brainstormers].[Sp_ObtenerClientes]
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
FROM OPENXML (@Identificador, '/Filtros',2)
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
	FROM [Brainstormers].[Cliente] C
		INNER JOIN Brainstormers.Pais P 
		ON c.Cliente_Pais_Codigo = P.Pais_Codigo
		INNER JOIN Brainstormers.TipoDocumento TD
		ON C.Cliente_Tipo_Doc_Cod = TD.Tipo_Doc_Cod
	WHERE (@Cliente_Nombre IS NULL OR C.Cliente_Nombre LIKE '%' + @Cliente_Nombre + '%')
		AND (@Cliente_Apellido IS NULL OR C.Cliente_Apellido LIKE '%' + @Cliente_Apellido + '%')
		AND (@Cliente_Mail IS NULL OR C.Cliente_Mail LIKE '%' + @Cliente_Mail + '%')
		AND (@Cliente_Nro_Doc IS NULL OR C.Cliente_Nro_Doc = @Cliente_Nro_Doc)
		AND (@Cliente_Tipo_Doc_Codigo IS NULL OR C.Cliente_Tipo_Doc_Cod = @Cliente_Tipo_Doc_Codigo)
		AND (@Cliente_Pais_Codigo IS NULL OR C.Cliente_Pais_Codigo = @Cliente_Pais_Codigo)
		AND (@Cliente_Baja IS NULL OR C.Cliente_Baja = @Cliente_Baja)

EXEC sp_xml_removedocument @Identificador
END
GO
/****** Object:  StoredProcedure [Brainstormers].[Sp_ObtenerFuncionalidades]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [Brainstormers].[Sp_ObtenerFuncionalidades]
as
begin
	select * from Brainstormers.Funcionalidad
end 
GO
/****** Object:  StoredProcedure [Brainstormers].[Sp_ObtenerPaises]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Brainstormers].[Sp_ObtenerPaises]
	AS
	BEGIN
		SELECT Pais_Codigo, Pais_Desc
		FROM Brainstormers.Pais
		Order by Pais_Desc ASC
	END
GO
/****** Object:  StoredProcedure [Brainstormers].[Sp_ObtenerRoles]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Brainstormers].[Sp_ObtenerRoles] (@filtrosXml XML)
AS
BEGIN
	DECLARE @Identificador INT

	EXEC sp_xml_preparedocument @Identificador OUTPUT
		,@filtrosXml

	DECLARE @Rol_Nombre [varchar] (255)

	SELECT @Rol_Nombre = Nombre
	FROM OPENXML(@Identificador, '/Filtros', 2) WITH (Nombre [varchar](255))

	SELECT R.Rol_Codigo
		,R.Rol_Nombre
		,R.Rol_Estado
		,FR.FuncRol_Rol_Codigo
		,F.Func_Codigo
		,F.Func_Desc
	FROM [Brainstormers].[Rol] R
	LEFT JOIN [Brainstormers].[FuncionalidadesRol] FR ON FR.[FuncRol_Rol_Codigo] = R.[Rol_Codigo]
	LEFT JOIN [Brainstormers].[Funcionalidad] F ON FR.[FuncRol_Func_Codigo] = F.Func_Codigo
	WHERE @Rol_Nombre is NULL OR R.Rol_Nombre LIKE '%' + @Rol_Nombre+ '%'


	--SELECT C.[Rol_Codigo]
	--FROM [Brainstormers].[Rol] C
	--	INNER JOIN Brainstormers.Pais P 
	--	ON c.Rol_Pais_Codigo = P.Pais_Codigo
	--	INNER JOIN Brainstormers.TipoDocumento TD
	--	ON C.Rol_Tipo_Doc_Cod = TD.Tipo_Doc_Cod
	--WHERE (@Rol_Nombre IS NULL OR C.Rol_Nombre LIKE ''%'' + @Rol_Nombre + ''%'')
	EXEC sp_xml_removedocument @Identificador
END

GO
/****** Object:  StoredProcedure [Brainstormers].[Sp_ObtenerUsuarioPorUsername]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Brainstormers].[Sp_ObtenerUsuarioPorUsername] (@UsernameXML XML)
AS
BEGIN
	--DECLARE  @UsernameXML XML
	--SET @UsernameXML = '<Username>Admin</Username>'

	DECLARE @Username VARCHAR(255)
	DECLARE @Identificador INT

EXEC sp_xml_preparedocument	@Identificador OUTPUT,
							@UsernameXML

SELECT
	@Username = Username
FROM OPENXML(@Identificador, '/', 2) WITH (Username [varchar](255))


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
FROM [Brainstormers].[Usuario] U
LEFT JOIN [Brainstormers].[RolesUsuario] RU
	ON RU.RolUsu_Usuario_Username = U.Usuario_Username
LEFT JOIN [Brainstormers].[Rol] R
	ON R.Rol_Codigo = RU.RolUsu_Rol_Codigo
LEFT JOIN [Brainstormers].[FuncionalidadesRol] FR
	ON FR.[FuncRol_Rol_Codigo] = R.[Rol_Codigo]
LEFT JOIN [Brainstormers].[Funcionalidad] F
	ON FR.[FuncRol_Func_Codigo] = F.Func_Codigo
WHERE Usuario_Username = @Username

EXEC sp_xml_removedocument @Identificador
END
GO
/****** Object:  StoredProcedure [Brainstormers].[Sp_ObtenerUsuarios]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Brainstormers].[Sp_ObtenerUsuarios] (@filtrosXml XML)
AS
BEGIN
	--declare @filtrosXml xml
	--set @filtrosXml = '<filtros/>'
	DECLARE @Identificador INT

	EXEC sp_xml_preparedocument @Identificador OUTPUT
		,@filtrosXml

	DECLARE @Usuario_Username [varchar] (255)

	SELECT @Usuario_Username = Username
	FROM OPENXML(@Identificador, '/Filtros', 2) WITH (Username [varchar](255))

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
	FROM [Brainstormers].[Usuario] U
	LEFT JOIN [Brainstormers].[RolesUsuario] RU ON RU.RolUsu_Usuario_Username = U.Usuario_Username
	LEFT JOIN [Brainstormers].[Rol] R ON R.Rol_Codigo = RU.RolUsu_Rol_Codigo
	LEFT JOIN [Brainstormers].[FuncionalidadesRol] FR ON FR.[FuncRol_Rol_Codigo] = R.[Rol_Codigo]
	LEFT JOIN [Brainstormers].[Funcionalidad] F ON FR.[FuncRol_Func_Codigo] = F.Func_Codigo
	WHERE @Usuario_Username IS NULL
		OR U.Usuario_Username LIKE '%' + @Usuario_Username + '%'

	EXEC sp_xml_removedocument @Identificador
END

GO
/****** Object:  Table [Brainstormers].[Cliente]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Brainstormers].[Cliente](
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

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Brainstormers].[Cuenta]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Brainstormers].[Cuenta](
	[Cuenta_Numero] [numeric](18, 0) NOT NULL,
	[Cuenta_Fecha_Creacion] [datetime] NULL,
	[Cuenta_Estado] [varchar](255) NULL,
	[Cuenta_Pais_Codigo] [numeric](18, 0) NULL,
	[Cuenta_Fecha_Cierre] [datetime] NULL,
	[Cuenta_Fecha_Estado] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Cuenta] PRIMARY KEY CLUSTERED 
(
	[Cuenta_Numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Brainstormers].[Funcionalidad]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Brainstormers].[Funcionalidad](
	[Func_Codigo] [numeric](18, 0) NOT NULL,
	[Func_Desc] [varchar](250) NULL,
 CONSTRAINT [PK_Funcionalidad] PRIMARY KEY CLUSTERED 
(
	[Func_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Brainstormers].[FuncionalidadesRol]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Brainstormers].[FuncionalidadesRol](
	[FuncRol_Rol_Codigo] [numeric](18, 0) NOT NULL,
	[FuncRol_Func_Codigo] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_FuncRol] PRIMARY KEY CLUSTERED 
(
	[FuncRol_Rol_Codigo] ASC,
	[FuncRol_Func_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Brainstormers].[Pais]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Brainstormers].[Pais](
	[Pais_Codigo] [numeric](18, 0) NOT NULL,
	[Pais_Desc] [varchar](250) NULL,
 CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
(
	[Pais_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Brainstormers].[Rol]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Brainstormers].[Rol](
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

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Brainstormers].[RolesUsuario]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Brainstormers].[RolesUsuario](
	[RolUsu_Rol_Codigo] [numeric](18, 0) NOT NULL,
	[RolUsu_Usuario_Username] [varchar](255) NOT NULL,
 CONSTRAINT [PK_RolUsu] PRIMARY KEY CLUSTERED 
(
	[RolUsu_Rol_Codigo] ASC,
	[RolUsu_Usuario_Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Brainstormers].[TipoDocumento]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Brainstormers].[TipoDocumento](
	[Tipo_Doc_Cod] [numeric](18, 0) NOT NULL,
	[Tipo_Doc_Desc] [varchar](255) NULL,
 CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[Tipo_Doc_Cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [Brainstormers].[Usuario]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Brainstormers].[Usuario](
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

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [gd_esquema].[Maestra]    Script Date: 06/06/2015 19:26:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
--CREATE TABLE [gd_esquema].[Maestra](
--	[Cli_Pais_Codigo] [numeric](18, 0) NULL,
--	[Cli_Pais_Desc] [varchar](250) NULL,
--	[Cli_Nombre] [varchar](255) NULL,
--	[Cli_Apellido] [varchar](255) NULL,
--	[Cli_Tipo_Doc_Cod] [numeric](18, 0) NULL,
--	[Cli_Nro_Doc] [numeric](18, 0) NULL,
--	[Cli_Tipo_Doc_Desc] [varchar](255) NULL,
--	[Cli_Dom_Calle] [varchar](255) NULL,
--	[Cli_Dom_Nro] [numeric](18, 0) NULL,
--	[Cli_Dom_Piso] [numeric](18, 0) NULL,
--	[Cli_Dom_Depto] [varchar](10) NULL,
--	[Cli_Fecha_Nac] [datetime] NULL,
--	[Cli_Mail] [varchar](255) NULL,
--	[Cuenta_Numero] [numeric](18, 0) NULL,
--	[Cuenta_Fecha_Creacion] [datetime] NULL,
--	[Cuenta_Estado] [varchar](255) NULL,
--	[Cuenta_Pais_Codigo] [numeric](18, 0) NULL,
--	[Cuenta_Pais_Desc] [varchar](250) NULL,
--	[Cuenta_Fecha_Cierre] [datetime] NULL,
--	[Deposito_Codigo] [numeric](18, 0) NULL,
--	[Deposito_Fecha] [datetime] NULL,
--	[Deposito_Importe] [numeric](18, 2) NULL,
--	[Tarjeta_Numero] [varchar](16) NULL,
--	[Tarjeta_Fecha_Emision] [datetime] NULL,
--	[Tarjeta_Fecha_Vencimiento] [datetime] NULL,
--	[Tarjeta_Codigo_Seg] [varchar](3) NULL,
--	[Tarjeta_Emisor_Descripcion] [varchar](255) NULL,
--	[Cuenta_Dest_Numero] [numeric](18, 0) NULL,
--	[Cuenta_Dest_Fecha_Creacion] [datetime] NULL,
--	[Cuenta_Dest_Estado] [varchar](255) NULL,
--	[Cuenta_Dest_Pais_Codigo] [numeric](18, 0) NULL,
--	[Cuenta_Dest_Pais_Desc] [varchar](250) NULL,
--	[Cuenta_Dest_Fecha_Cierre] [datetime] NULL,
--	[Transf_Fecha] [datetime] NULL,
--	[Trans_Importe] [numeric](18, 2) NULL,
--	[Trans_Costo_Trans] [numeric](18, 2) NULL,
--	[Retiro_Fecha] [datetime] NULL,
--	[Retiro_Codigo] [numeric](18, 0) NULL,
--	[Retiro_Importe] [numeric](18, 2) NULL,
--	[Cheque_Numero] [numeric](18, 0) NULL,
--	[Cheque_Fecha] [datetime] NULL,
--	[Cheque_Importe] [numeric](18, 2) NULL,
--	[Banco_Cogido] [numeric](18, 0) NULL,
--	[Banco_Nombre] [varchar](255) NULL,
--	[Banco_Direccion] [varchar](255) NULL,
--	[Item_Factura_Descr] [varchar](255) NULL,
--	[Item_Factura_Importe] [numeric](18, 2) NULL,
--	[Factura_Numero] [numeric](18, 0) NULL,
--	[Factura_Fecha] [datetime] NULL
--) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [Brainstormers].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Pais] FOREIGN KEY([Cliente_Pais_Codigo])
REFERENCES [Brainstormers].[Pais] ([Pais_Codigo])
GO
ALTER TABLE [Brainstormers].[Cliente] CHECK CONSTRAINT [FK_Cliente_Pais]
GO
ALTER TABLE [Brainstormers].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_TipoDocumento] FOREIGN KEY([Cliente_Tipo_Doc_Cod])
REFERENCES [Brainstormers].[TipoDocumento] ([Tipo_Doc_Cod])
GO
ALTER TABLE [Brainstormers].[Cliente] CHECK CONSTRAINT [FK_Cliente_TipoDocumento]
GO
ALTER TABLE [Brainstormers].[Cuenta]  WITH CHECK ADD  CONSTRAINT [FK_Cuenta_Cuenta] FOREIGN KEY([Cuenta_Numero])
REFERENCES [Brainstormers].[Cuenta] ([Cuenta_Numero])
GO
ALTER TABLE [Brainstormers].[Cuenta] CHECK CONSTRAINT [FK_Cuenta_Cuenta]
GO
ALTER TABLE [Brainstormers].[Cuenta]  WITH CHECK ADD  CONSTRAINT [FK_Cuenta_Pais] FOREIGN KEY([Cuenta_Pais_Codigo])
REFERENCES [Brainstormers].[Pais] ([Pais_Codigo])
GO
ALTER TABLE [Brainstormers].[Cuenta] CHECK CONSTRAINT [FK_Cuenta_Pais]
GO
ALTER TABLE [Brainstormers].[FuncionalidadesRol]  WITH CHECK ADD  CONSTRAINT [FK_Func_FuncionalidadesRol] FOREIGN KEY([FuncRol_Func_Codigo])
REFERENCES [Brainstormers].[Funcionalidad] ([Func_Codigo])
GO
ALTER TABLE [Brainstormers].[FuncionalidadesRol] CHECK CONSTRAINT [FK_Func_FuncionalidadesRol]
GO
ALTER TABLE [Brainstormers].[FuncionalidadesRol]  WITH CHECK ADD  CONSTRAINT [FK_Rol_FuncionalidadesRol] FOREIGN KEY([FuncRol_Rol_Codigo])
REFERENCES [Brainstormers].[Rol] ([Rol_Codigo])
GO
ALTER TABLE [Brainstormers].[FuncionalidadesRol] CHECK CONSTRAINT [FK_Rol_FuncionalidadesRol]
GO
ALTER TABLE [Brainstormers].[RolesUsuario]  WITH CHECK ADD  CONSTRAINT [FK_Rol_RolesUsuario] FOREIGN KEY([RolUsu_Rol_Codigo])
REFERENCES [Brainstormers].[Rol] ([Rol_Codigo])
GO
ALTER TABLE [Brainstormers].[RolesUsuario] CHECK CONSTRAINT [FK_Rol_RolesUsuario]
GO
ALTER TABLE [Brainstormers].[RolesUsuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_RolesUsuario] FOREIGN KEY([RolUsu_Usuario_Username])
REFERENCES [Brainstormers].[Usuario] ([Usuario_Username])
GO
ALTER TABLE [Brainstormers].[RolesUsuario] CHECK CONSTRAINT [FK_Usuario_RolesUsuario]
GO
USE [master]
GO
ALTER DATABASE [GD1C2015] SET  READ_WRITE 
GO
