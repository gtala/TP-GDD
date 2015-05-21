use GD1C2015
go
/*
create schema [gdd_maxi] authorization [gd]
go

create table [gdd_maxi].Usuarios
(
username nvarchar(20) not null,
pass	varchar(256) null,
fechacrea Datetime null,
fechaultmod datetime null,
preguntasecreta varchar(256) null,
respuestasecreta varchar (256) null,
estado int null
)
go

create table [gdd_maxi].UsuarioXRol
(
username nvarchar(20) null,
idRol int null
)
go

create table [gdd_maxi].Roles
(
idRol int not null,
nombre nvarchar(20) null,
estado int null
)
go

create table [gdd_maxi].RolXFuncionalidad
(
idRol int null,
idFuncionalidad int null
)
go

create table [gdd_maxi].Funcionalidades
(
idFuncionalidad int not null,
nombre nvarchar(30) null
)
go

create table gdd_maxi.Clientes
(
Cli_nro_doc numeric(18,0) not null,
Cli_Nombre varchar(255) NULL,
Cli_Apellido varchar(255) NULL,
Cli_Dom_Calle varchar(255) null,
Cli_Dom_Nro numeric(18,0) null,
Cli_Dom_Piso numeric(18,0) null,
Cli_Dom_Depto varchar(10) null,
Cli_Fecha_Nac datetime null,
Cli_Mail varchar(255) null,
Cli_Pais_Codigo numeric(18,0) null,
Cli_Tipo_Doc_Cod numeric(18,0) null,
cli_tipo_doc_desc varchar(255) null,
username nvarchar(20) null,
habilitado int null
)
go
print 'tabla clientes creadas'

create table gdd_maxi.Cuentas
(
cta_cod numeric(18,0) not null,
cli_cod numeric(18,0) null,
Pais_cuenta numeric(18,0) null,
Moneda numeric(18,0) null,
estado varchar(255) null,
cod_tipo numeric(18,0) null,
cuenta_Pais_codigo numeric(18,0) null,
cuenta_fecha_cierre datetime null,
banco_codigo numeric(18,0) null,
cuenta_fecha_creacion datetime null
)
go
print 'tabla cuentas creadas'

--create table gdd_maxi.CuentasDest
--(
--cta_cod numeric(18,0) not null,
--cli_cod numeric(18,0) null,
--Pais_cuenta numeric(18,0) null,
--Moneda numeric(18,0) null,
--estado varchar(255) null,
--cod_tipo numeric(18,0) null,
--cuenta_Pais_codigo numeric(18,0) null,
--cuenta_fecha_cierre datetime null,
--banco_codigo numeric(18,0) null,
--cuenta_fecha_creacion datetime null
--)
--go
--print 'tabla cuentas destinos creadas'

create table gdd_maxi.Paises
(
cod_pais numeric(18,0) not NULL,
descripcion varchar(255) NULL
)
go
print 'tabla Paises creadas'

create table [gdd_maxi].[Tarjetas]
(
tarjeta_numero varchar(16) not null,
tarjeta_fecha_emision datetime null,
tarjeta_fecha_vencimiento datetime null,
tarjeta_codigo_seg varchar(3) null,
tarjeta_emisor varchar(255) null,
cod_cli numeric(18,0) null,
cod_banco numeric(18,0) null
)
go
print 'tabla tarjetas creadas'


create table gdd_maxi.Facturas
(
cod_factura numeric(18,0) not null,
cod_cli numeric(18,0) null,
fecha_emision datetime null,
cod_item numeric(18,0) null,
importe numeric(18,2) null
)
go

print 'tabla facturas creadas'

create table gdd_maxi.Items
(
cod_item numeric(18,0) null,
cod_factura numeric(18,0) null,
tipo char(2) null,
importe numeric(18,2) null
)
go

print 'tabla items creadas'


--create table gdd_maxi.Documentos
--(
--cod_doc numeric(18,0) null,
--descripcion varchar(30) null
--)
--go
--print 'tabla documentos creadas'

create table gdd_maxi.Tipo_Cuenta
(
cod_tipo numeric(18,0) not null,
duracion int null,
--verificar si hay 3 costos o 1 costo
costo numeric(18,2) null
)
go

print 'tabla tipo_cuenta creadas'

create table gdd_maxi.Bancos
(
cod_banco numeric(18,0) not null,
nombre varchar(255) null,
direccion varchar(255) null
)
go

print 'tabla bancos creadas'

create table gdd_maxi.Tipo_moneda
(
cod_moneda numeric(18,0) not null,
descripcion varchar(255) null
)
go

print 'tabla tipo_moneda creadas'

create table gdd_maxi.Transferencias
(
cod_transf numeric(18,0) not null,
importe numeric(18,2) null,
cta_dest numeric(18,0) null,
cta_origen numeric(18,0) null,
costo numeric(18,2) null,
fecha datetime null,
cod_cli numeric(18,0) null
)
go

print 'tabla transferencias creadas'

create table gdd_maxi.Depositos
(
cod_depo numeric(18,0) not null,
fecha datetime null,
importe numeric(18,2) null,
cta_cod numeric(18,0) null,
cli_cod numeric(18,0) null,
cod_banco numeric(18,0) null
)
go

print 'tabla depositos creadas'

create table gdd_maxi.Retiros
(
cod_cli numeric (18,0) null,
cta_cod numeric(18,0) null,
cod_retiro numeric(18,0) not null,
fecha datetime null,
importe numeric(18,2) null,
cod_banco numeric(18,0) null
)
go

print 'tabla retiros creadas'

create table gdd_maxi.Cheques
(
nro_cheque numeric(18,0) not null,
cod_retiro numeric(18,0) null,
fecha datetime null,
importe numeric(18,2) null,
cod_cli numeric(18,0) null,
cod_banco numeric(18,0) null,
num_egreso numeric(18,0) null
)
go
print 'tabla cheques creadas'

create table gdd_maxi.auditoria
(
login numeric(18,0) identity(1,1) not null,
fecha datetime null,
correcto char (3) null,
username nvarchar(20) null
)
go

print 'tabla auditoria creada'
-- GENERACION DE CONSTRAINTS

alter table [gdd_maxi].Funcionalidades add constraint pk_idFuncionalidad primary key(idFuncionalidad)

ALTER TABLE [gdd_maxi].RolXFuncionalidad  WITH CHECK ADD CONSTRAINT [FK_RolXFuncionalidades_Funcionalidades] FOREIGN KEY([idFuncionalidad])
REFERENCES [gdd_maxi].[Funcionalidades] ([idFuncionalidad])

alter table [gdd_maxi].Roles add constraint pk_idRol primary key(idRol)


ALTER TABLE [gdd_maxi].RolXFuncionalidad  WITH CHECK ADD CONSTRAINT [FK_RolXFuncionalidades_Roles] FOREIGN KEY([idRol])
REFERENCES [gdd_maxi].[Roles] ([idRol])

alter table [gdd_maxi].Usuarios add constraint pk_username primary key(username)


alter table [gdd_maxi].usuarioxrol WITH CHECK ADD CONSTRAINT [FK_RolXusuarios_usuarios] FOREIGN KEY([username])
REFERENCES [gdd_maxi].[usuarios] ([username])

alter table [gdd_maxi].usuarioxrol WITH CHECK ADD CONSTRAINT [FK_RolXusuarios_roles] FOREIGN KEY([idrol])
REFERENCES [gdd_maxi].[roles] ([idrol])

alter table gdd_maxi.Clientes add constraint pk_cli_cod primary key(Cli_nro_doc)

alter table gdd_maxi.Cuentas add constraint pk_cta_cod primary key(cta_cod)

--alter table gdd_maxi.CuentasDest add constraint pk_ctadest_cod primary key(cta_cod)

alter table gdd_maxi.Depositos add constraint pk_cod_depo primary key(cod_depo)

alter table gdd_maxi.Cheques add constraint pk_nro_cheque primary key(nro_cheque)

alter table gdd_maxi.Bancos add constraint pk_cod_banco primary key(cod_banco)

--alter table gdd_maxi.Documentos add constraint pk_cod_doc primary key(cod_doc)

alter table gdd_maxi.Facturas add constraint pk_cod_factura primary key(cod_factura)

--alter table gdd_maxi.Items add constraint pk_cod_item primary key(cod_item)

alter table gdd_maxi.Paises add constraint pk_cod_pais primary key(cod_pais)

alter table gdd_maxi.Retiros add constraint pk_cod_retiro primary key(cod_retiro)

alter table gdd_maxi.Tarjetas add constraint pk_tarjeta_numero primary key(tarjeta_numero)

alter table gdd_maxi.Tipo_Cuenta add constraint pk_cod_tipo primary key(cod_tipo)

alter table gdd_maxi.Tipo_Moneda add constraint pk_cod_moneda primary key(cod_moneda)

alter table gdd_maxi.Transferencias add constraint pk_cod_transferencia primary key(cod_transf)

alter table [gdd_maxi].auditoria add constraint pk_log primary key(login)

alter table [gdd_maxi].Cuentas  WITH CHECK ADD CONSTRAINT [FK_Cuentas_Clientes] FOREIGN KEY([Cli_cod])
REFERENCES [gdd_maxi].[Clientes] ([Cli_nro_doc])

alter table [gdd_maxi].Cuentas  WITH CHECK ADD CONSTRAINT [FK_Cuentas_Tipo_Cuenta] FOREIGN KEY([cod_tipo])
REFERENCES [gdd_maxi].[Tipo_Cuenta] ([cod_tipo])

alter table [gdd_maxi].Cuentas  WITH CHECK ADD CONSTRAINT [FK_Cuentas_Tipo_moneda] FOREIGN KEY([moneda])
REFERENCES [gdd_maxi].[Tipo_moneda] ([cod_Moneda])

alter table [gdd_maxi].Clientes  WITH CHECK ADD CONSTRAINT [FK_Clientes_Paises] FOREIGN KEY([Cli_Pais_Codigo])
REFERENCES [gdd_maxi].[Paises] ([cod_pais])

--alter table [gdd_maxi].Clientes  WITH CHECK ADD CONSTRAINT [FK_Clientes_Documentos] FOREIGN KEY([Cli_Tipo_Doc_Cod])
--REFERENCES [gdd_maxi].[Documentos] ([cod_doc])

alter table [gdd_maxi].Tarjetas  WITH CHECK ADD CONSTRAINT [FK_Tarjetas_Clientes] FOREIGN KEY([Cod_cli])
REFERENCES [gdd_maxi].[Clientes] ([Cli_nro_doc])

alter table [gdd_maxi].Tarjetas  WITH CHECK ADD CONSTRAINT [FK_Tarjetas_Bancos] FOREIGN KEY([Cod_banco])
REFERENCES [gdd_maxi].[Bancos] ([cod_banco])

alter table [gdd_maxi].Facturas  WITH CHECK ADD CONSTRAINT [FK_Facturas_Clientes] FOREIGN KEY([cod_cli])
REFERENCES [gdd_maxi].[Clientes] ([Cli_nro_doc])

alter table [gdd_maxi].Items  WITH CHECK ADD CONSTRAINT [FK_Items_Facturas] FOREIGN KEY([cod_factura])
REFERENCES [gdd_maxi].[Facturas] ([cod_factura])

alter table [gdd_maxi].Depositos  WITH CHECK ADD CONSTRAINT [FK_Depositos_Clientes] FOREIGN KEY([Cli_cod])
REFERENCES [gdd_maxi].[Clientes] ([Cli_nro_doc])

alter table [gdd_maxi].Retiros  WITH CHECK ADD CONSTRAINT [FK_Retiros_Clientes] FOREIGN KEY([cod_cli])
REFERENCES [gdd_maxi].[Clientes] ([Cli_nro_doc])

alter table [gdd_maxi].Transferencias  WITH CHECK ADD CONSTRAINT [FK_Transferencias_Clientes] FOREIGN KEY([cod_cli])
REFERENCES [gdd_maxi].[Clientes] ([Cli_nro_doc])

--alter table [gdd_maxi].Transferencias  WITH CHECK ADD CONSTRAINT [FK_Transferencias_CuentasDest] FOREIGN KEY([cta_dest])
--REFERENCES [gdd_maxi].[CuentasDest] ([cta_cod])

alter table [gdd_maxi].Cheques  WITH CHECK ADD CONSTRAINT [FK_Cheques_Retiros] FOREIGN KEY([cod_retiro])
REFERENCES [gdd_maxi].[Retiros] ([cod_retiro])

alter table [gdd_maxi].Cheques  WITH CHECK ADD CONSTRAINT [FK_Cheques_Clientes] FOREIGN KEY([cod_cli])
REFERENCES [gdd_maxi].[Clientes] ([Cli_nro_doc])

alter table [gdd_maxi].Cheques  WITH CHECK ADD CONSTRAINT [FK_Cheques_Bancos] FOREIGN KEY([cod_banco])
REFERENCES [gdd_maxi].[Bancos] ([cod_banco])

alter table [gdd_maxi].Cuentas  WITH CHECK ADD CONSTRAINT [FK_cuentas_paises] FOREIGN KEY([cuenta_pais_codigo])
REFERENCES [gdd_maxi].[Paises] ([cod_pais])

--alter table [gdd_maxi].Cuentasdest  WITH CHECK ADD CONSTRAINT [FK_cuentasdest_paises] FOREIGN KEY([cuenta_pais_codigo])
--REFERENCES [gdd_maxi].[Paises] ([cod_pais])

alter table [gdd_maxi].Clientes  WITH CHECK ADD CONSTRAINT [FK_clientes_usuarios] FOREIGN KEY([username])
REFERENCES [gdd_maxi].[usuarios] ([username])

alter table [gdd_maxi].auditoria  WITH CHECK ADD CONSTRAINT [FK_auditoria_usuarios] FOREIGN KEY([username])
REFERENCES [gdd_maxi].[usuarios] ([username])




SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [gdd_maxi].[sp_obtenerusuario]
	@username nvarchar(20)
	
AS
BEGIN
	select username,pass,fechacrea,fechaultmod,preguntasecreta,respuestasecreta,estado  
	from [gdd_maxi].usuarios
	where username = @username
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [gdd_maxi].[sp_obtenerrolessegunusuario]
	@username nvarchar(20)
	
AS
BEGIN
	select UXR.idRol,Rs.nombre,Rs.estado 
	from ((gdd_maxi.Usuarios U join gdd_maxi.UsuarioXRol UXR on U.username = UXR.username) join gdd_maxi.Roles Rs on UXR.idRol = Rs.idRol)
	where (U.username=@username) 
	
	
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [gdd_maxi].[sp_insertarol]
	@id int,
	@nombre nvarchar(20),
	@estado int
AS
BEGIN
	
	insert gdd_maxi.Roles (idrol,nombre,estado) values (@id,@nombre,@estado)
	 
	
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [gdd_maxi].[sp_insertarolxfuncionalidad]
	@idrol int,
	@idfuncionalidad int
	
AS
BEGIN
	
	insert gdd_maxi.Rolxfuncionalidad (idrol,idfuncionalidad) values (@idrol,@idfuncionalidad)
	 
	
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [gdd_maxi].[sp_traerfuncionalidades]
		
AS
BEGIN
	
	select idfuncionalidad,nombre
	from Funcionalidades
	 	
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create TRIGGER [gdd_maxi].[t_genera_username] 
   ON [gdd_maxi].[Clientes]  
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert gdd_maxi.usuarios (username,fechacrea,fechaultmod) select case when cli_nombre in (select cli_nombre from gdd_maxi.Clientes) then cli_nombre+substring(cli_apellido,1,1) else cli_nombre end,getdate(),getdate() from gdd_maxi.Clientes order by Cli_Nombre
	

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE gdd_maxi.sp_obtenerFuncionalidadesderol 
	@idrol int
	
AS
BEGIN
	SET NOCOUNT ON;

    select f.idfuncionalidad,f.nombre 
    from gdd_maxi.RolXFuncionalidad rxf join gdd_maxi.Funcionalidades f on rxf.idFuncionalidad=f.idFuncionalidad
	where rxf.idRol=@idrol
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE gdd_maxi.sp_traerroles 
	
AS
BEGIN
	SET NOCOUNT ON;

    select idRol,nombre,estado 
    from gdd_maxi.Roles
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [gdd_maxi].[sp_cargar_tablas]
	
AS
BEGIN
	
	insert gdd_maxi.USUARIOS (username,pass,fechacrea,fechaultmod,preguntasecreta,respuestasecreta) 
	values	('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',2015-04-26, 2015-04-26, 'preguntasecreta', '1f761f7127462b23542d2c1c7e1a308a4d1a0aa22410a28a536a53b366dd8371')
	insert gdd_maxi.roles values (1,'admin',1)
	insert gdd_maxi.roles values (2,'cliente',1)
	insert gdd_maxi.usuarioxrol values	('admin',1)
	insert gdd_maxi.usuarioxrol values	('admin',2)
	insert gdd_maxi.Funcionalidades values	(1,'ABM de roles')
	insert gdd_maxi.Funcionalidades values	(2,'ABM de usuarios')
	insert gdd_maxi.Funcionalidades values	(3,'ABM de clientes')
	insert gdd_maxi.Funcionalidades values	(4,'ABM de cuenta')
	insert gdd_maxi.Funcionalidades values	(5,'Depositos')
	insert gdd_maxi.Funcionalidades values	(6,'Retiro')
	insert gdd_maxi.Funcionalidades values	(7,'Transferencias')
	insert gdd_maxi.Funcionalidades values	(8,'Facturacion')
	insert gdd_maxi.Funcionalidades values	(9,'Consulta de saldo')
	insert gdd_maxi.Funcionalidades values	(10,'Listado estadistico')
	insert gdd_maxi.RolXFuncionalidad values (1,1)
	insert gdd_maxi.RolXFuncionalidad values (1,2)
	insert gdd_maxi.Paises select distinct cli_pais_codigo,cli_pais_desc from gd_esquema.Maestra union select distinct Cuenta_Pais_Codigo,Cuenta_Pais_Desc from gd_esquema.Maestra order by Cli_Pais_Codigo
	insert gdd_maxi.Cuentas (cta_cod,estado,cuenta_Pais_codigo,cuenta_fecha_cierre,cuenta_fecha_creacion) select cuenta_numero,cuenta_estado,cuenta_pais_codigo,cuenta_fecha_cierre,cuenta_fecha_creacion from gd_esquema.Maestra group by cuenta_numero,cuenta_estado,cuenta_pais_codigo,cuenta_fecha_cierre,cuenta_fecha_creacion order by Cuenta_Numero
	--insert gdd_maxi.Documentos select Cli_Tipo_Doc_Cod,Cli_Tipo_Doc_Desc from gd_esquema.Maestra group by Cli_Tipo_Doc_Cod,Cli_Tipo_Doc_Desc order by Cli_Tipo_Doc_Cod	
	insert gdd_maxi.Clientes (cli_nro_doc,cli_nombre,cli_apellido,cli_dom_calle,cli_dom_nro,cli_dom_piso,cli_dom_depto,cli_fecha_nac,cli_mail,cli_pais_codigo,cli_tipo_doc_cod,cli_tipo_doc_desc) select distinct cli_nro_doc,cli_nombre,cli_apellido,cli_dom_calle,cli_dom_nro,cli_dom_piso,cli_dom_depto,cli_fecha_nac,cli_mail,cli_pais_codigo,cli_tipo_doc_cod,cli_tipo_doc_desc from gd_esquema.Maestra group by cli_nro_doc,cli_nombre,cli_apellido,cli_dom_calle,cli_dom_nro,cli_dom_piso,cli_dom_depto,cli_fecha_nac,cli_mail,cli_pais_codigo,cli_tipo_doc_cod,cli_tipo_doc_desc order by Cli_Nro_Doc
	insert gdd_maxi.Bancos select banco_cogido,banco_nombre,banco_direccion from gd_esquema.Maestra where Banco_Cogido is not null group by banco_cogido,banco_nombre,banco_direccion order by Banco_Cogido
	insert gdd_maxi.Cheques (nro_cheque,fecha,importe) select cheque_numero,cheque_fecha,cheque_importe from gd_esquema.Maestra where Cheque_Numero is not null group by Cheque_Numero,Cheque_Fecha,Cheque_Importe order by Cheque_Numero
	--insert gdd_maxi.CuentasDest (cta_cod,cuenta_fecha_creacion,estado,cuenta_Pais_codigo,cuenta_fecha_cierre) select cuenta_dest_numero,Cuenta_Dest_Fecha_Creacion,Cuenta_Dest_Estado,Cuenta_Dest_Pais_Codigo,Cuenta_Dest_Fecha_Cierre from gd_esquema.Maestra where cuenta_dest_numero is not null group by cuenta_dest_numero,Cuenta_Dest_Fecha_Creacion,Cuenta_Dest_Estado,Cuenta_Dest_Pais_Codigo,Cuenta_Dest_Fecha_Cierre order by Cuenta_Dest_Numero
	insert gdd_maxi.Depositos (cod_depo,fecha,importe) select Deposito_Codigo,Deposito_Fecha,Deposito_Importe from gd_esquema.Maestra where Deposito_Codigo is not null group by Deposito_Codigo,Deposito_Fecha,Deposito_Importe order by Deposito_Codigo
	insert gdd_maxi.Facturas (cod_factura,fecha_emision) select distinct factura_numero,factura_fecha from gd_esquema.Maestra where factura_numero is not null group by Factura_Numero,Factura_Fecha order by Factura_Numero	
END
go

create PROCEDURE [gdd_maxi].[sp_borrar_tablas]
		
AS
BEGIN
	--delete gdd_maxi.CuentasDest
	delete gdd_maxi.Clientes
	delete gdd_maxi.Paises 
	--delete gdd_maxi.Documentos 
	delete gdd_maxi.Cuentas
	delete gdd_maxi.Bancos
	delete gdd_maxi.Cheques
	delete gdd_maxi.Depositos
	delete gdd_maxi.Facturas
	delete gdd_maxi.Items
	delete gdd_maxi.Retiros
	delete gdd_maxi.UsuarioXRol
	delete gdd_maxi.RolXFuncionalidad
	delete gdd_maxi.Roles
	delete gdd_maxi.Tarjetas
	delete gdd_maxi.Tipo_Cuenta
	delete gdd_maxi.Tipo_moneda
	delete gdd_maxi.Transferencias
	delete gdd_maxi.Usuarios
	delete gdd_maxi.Funcionalidades  
END
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE gdd_maxi.sp_traerrolessegunnombre 
	@nombre nvarchar(20)
AS
BEGIN
	SET NOCOUNT ON;

    select idRol,nombre,estado
    from gdd_maxi.Roles
	where nombre = @nombre
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE gdd_maxi.sp_traerrolessegunnombrelike 
	@nombre nvarchar(20)
AS
BEGIN
	SET NOCOUNT ON;

    select idRol,nombre,estado
    from gdd_maxi.Roles
    where nombre like '%@nombre%'
	
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE gdd_maxi.sp_cargarpass 

AS
BEGIN
	SET NOCOUNT ON;
	update gdd_maxi.Usuarios set pass = '2143517f2499c6d41771546ceb9e4e32ade2ea3f45190449f5a83139cb681913' 
	where username = 'AgataD'
	update gdd_maxi.Usuarios set pass = '342ec2f5ad988eebc4741a89120422e15c5f2b5953d2495d84824774bc067397' 
	where username = 'AienR'
	update gdd_maxi.Usuarios set pass = '6a78a1c92e0c634c75665be4b4901f6dc144a270e34fcd57f229227ff3c04d99' 
	where username = 'AlejandroF'
	update gdd_maxi.Usuarios set pass = 'b05c7bc0528f9f444750fcd9841e4b22c24cba43cdb8385c31f5c83844aed1e9' 
	where username = 'AlejoC'
	update gdd_maxi.Usuarios set pass = 'a2e53976ab60b1ad2c841a51d41025be5d043de45ebbc3630673b48b9cc0ca57' 
	where username = 'AlenkaG'
	update gdd_maxi.Usuarios set pass = 'b71e872da86eb6f4fb380f5940a4efda95a6d1b09d957b12a5f24e8f847e19bd' 
	where username = 'AmarenaM'
	update gdd_maxi.Usuarios set pass = '552131bea2f7b33ee1991dc39d02afac14b5fd37ea78f3c2b7777389ece3e862' 
	where username = 'AmbrosioV'
	update gdd_maxi.Usuarios set pass = '1a7523c3f47d9b981e4f7bde79c769ef7207f0dc132609ec9efe701e31b0cb0e' 
	where username = 'AnastasiaG'
	update gdd_maxi.Usuarios set pass = '7018a257fac99eeddaa5a36f3d92189468b8aecca95b09dade979cba5f53eb7d' 
	where username = 'AndinaO'
	update gdd_maxi.Usuarios set pass = '8673e8ac648841a4e652197be3c44da82d45d87c8e2e19b8f1cabc403dcb471d' 
	where username = 'AntoninoM'
	update gdd_maxi.Usuarios set pass = 'bdf7aef8feb8df081bd2bcb720e4ae47e152d1da55b71a26d74b9760e2173bab' 
	where username = 'AonikenkR'
	update gdd_maxi.Usuarios set pass = 'db67c92ee3816f648047743017311b8e3bfd415b73488f6d42519bdc9fb1cc25' 
	where username = 'ArchibaldoH'
	update gdd_maxi.Usuarios set pass = 'baaae29c81c2a08f1d654f4376bad429df07a1d55eaac402478dbc3fe1241f33' 
	where username = 'ArgimiroC'
	update gdd_maxi.Usuarios set pass = '8a3017c316102dd70c4260a92a8ee00d651f51460d81d63771517f9a97f29d34' 
	where username = 'AyeshaR'
	update gdd_maxi.Usuarios set pass = '5085604d2bd45445457ade6784e8f6302a0ae5df0ba4d19e1e73746d65f466c7' 
	where username = 'AyumiC'
	update gdd_maxi.Usuarios set pass = '854d836f411afa5cce3fb2b675fb24ea6821cbbc02c49b6950b16f6e0f4ef68b' 
	where username = 'BartoloF'
	update gdd_maxi.Usuarios set pass = '1743be7640b96fd7d41db2589a400ffff96cab2a987a7ad256be67d39725aab0' 
	where username = 'BelindaC'
    
	
END
GO   

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE gdd_maxi.sp_traerusuarios 
	
AS
BEGIN
	SET NOCOUNT ON;

    select username,pass,fechacrea,fechaultmod,preguntasecreta,respuestasecreta,estado
    from gdd_maxi.Usuarios
    
	
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create PROCEDURE [gdd_maxi].[sp_traerrolesactivos]
	
	
AS
BEGIN
	select idRol,nombre
	from gdd_maxi.Roles
	where estado<>0 
	
	
END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE gdd_maxi.sp_insertarolxusuario 
	@usuario nvarchar(20),
	@idrol int
AS
BEGIN
	SET NOCOUNT ON;

    insert gdd_maxi.UsuarioXRol values (@usuario,@idrol)
	
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE gdd_maxi.sp_insertalogin 
	@fecha datetime,
	@correcto char(3),
	@username nvarchar(20)
AS
BEGIN
	SET NOCOUNT ON;

    insert gdd_maxi.auditoria (fecha,correcto,username) values (@fecha,@correcto,@username)
	
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE gdd_maxi.sp_insertausuario 
	@usuario nvarchar(20),
	@pass varchar(256),
	@fechacrea datetime,
	@fechaultmod datetime,
	@preguntasecreta varchar(256),
	@respuestasecreta varchar(256),
	@estado int
AS
BEGIN
	SET NOCOUNT ON;

    insert gdd_maxi.usuarios values (@usuario,@pass,@fechacrea,@fechaultmod,@preguntasecreta,@respuestasecreta,@estado)
    
	
END
GO

create view gdd_maxi.V_nombrederoles as
  select idrol,nombre
   from gdd_maxi.Roles
   where estado <>0

create view gdd_maxi.V_usuarios as
  select username
   from gdd_maxi.usuarios
   
*/


--generar usuarios a cada cliente migrado

--gdd_maxi.sp_borrar_tablas
--gdd_maxi.sp_cargar_tablas






