use GD1C2015
go

create schema [BRAINSTORMERS] authorization [gd]
go

create table [BRAINSTORMERS].Usuarios
(
username nvarchar(20) not null,
pass	varchar(256) null,
rolasignado int null,
fechacrea Datetime null,
fechaultmod datetime null,
preguntasecreta varchar(256) null,
respuestasecreta varchar (256) null
)
go

create table [BRAINSTORMERS].UsuarioXRol
(
username nvarchar(20) not null,
idRol int not null
)
go

create table [BRAINSTORMERS].Roles
(
idRol int not null,
nombre nvarchar(20) null,
estado int null
)
go

create table [BRAINSTORMERS].RolXFuncionalidad
(
idRol int not null,
idFuncionalidad int not null
)
go

create table [BRAINSTORMERS].Funcionalidades
(
idFuncionalidad int not null,
nombre nvarchar(30) null
)
go

create table BRAINSTORMERS.Clientes
(
Cli_nro_doc numeric(18,0) IDENTITY(1,1) not null,
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

create table BRAINSTORMERS.Cuentas
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

--create table BRAINSTORMERS.CuentasDest
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

create table BRAINSTORMERS.Paises
(
cod_pais numeric(18,0) not NULL,
descripcion varchar(255) NULL
)
go
print 'tabla Paises creadas'

create table [BRAINSTORMERS].[Tarjetas]
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


create table BRAINSTORMERS.Facturas
(
cod_factura numeric(18,0) not null,
cod_cli numeric(18,0) null,
fecha_emision datetime null,
cod_item numeric(18,0) null,
importe numeric(18,2) null
)
go

print 'tabla facturas creadas'

create table BRAINSTORMERS.Items
(
cod_item numeric(18,0) null,
cod_factura numeric(18,0) null,
tipo char(2) null,
importe numeric(18,2) null
)
go

print 'tabla items creadas'


--create table BRAINSTORMERS.Documentos
--(
--cod_doc numeric(18,0) null,
--descripcion varchar(30) null
--)
--go
--print 'tabla documentos creadas'

create table BRAINSTORMERS.Tipo_Cuenta
(
cod_tipo numeric(18,0) not null,
duracion int null,
--verificar si hay 3 costos o 1 costo
costo numeric(18,2) null
)
go

print 'tabla tipo_cuenta creadas'

create table BRAINSTORMERS.Bancos
(
cod_banco numeric(18,0) not null,
nombre varchar(255) null,
direccion varchar(255) null
)
go

print 'tabla bancos creadas'

create table BRAINSTORMERS.Tipo_moneda
(
cod_moneda numeric(18,0) not null,
descripcion varchar(255) null
)
go

print 'tabla tipo_moneda creadas'

create table BRAINSTORMERS.Transferencias
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

create table BRAINSTORMERS.Depositos
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

create table BRAINSTORMERS.Retiros
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

create table BRAINSTORMERS.Cheques
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

create table BRAINSTORMERS.auditoria
(
login numeric(18,0) identity(1,1) not null,
fecha datetime null,
correcto char (3) null,
username nvarchar(20) null
)
go

print 'tabla auditoria creada'
-- GENERACION DE CONSTRAINTS

alter table [BRAINSTORMERS].Funcionalidades add constraint pk_idFuncionalidad primary key(idFuncionalidad)

ALTER TABLE [BRAINSTORMERS].RolXFuncionalidad  WITH CHECK ADD CONSTRAINT [FK_RolXFuncionalidades_Funcionalidades] FOREIGN KEY([idFuncionalidad])
REFERENCES [BRAINSTORMERS].[Funcionalidades] ([idFuncionalidad])

alter table [BRAINSTORMERS].Roles add constraint pk_idRol primary key(idRol)


ALTER TABLE [BRAINSTORMERS].RolXFuncionalidad  WITH CHECK ADD CONSTRAINT [FK_RolXFuncionalidades_Roles] FOREIGN KEY([idRol])
REFERENCES [BRAINSTORMERS].[Roles] ([idRol])

alter table [BRAINSTORMERS].Usuarios add constraint pk_username primary key(username)


alter table [BRAINSTORMERS].usuarioxrol WITH CHECK ADD CONSTRAINT [FK_RolXusuarios_usuarios] FOREIGN KEY([username])
REFERENCES [BRAINSTORMERS].[usuarios] ([username])

alter table [BRAINSTORMERS].usuarioxrol WITH CHECK ADD CONSTRAINT [FK_RolXusuarios_roles] FOREIGN KEY([idrol])
REFERENCES [BRAINSTORMERS].[roles] ([idrol])

alter table BRAINSTORMERS.Clientes add constraint pk_cli_cod primary key(Cli_nro_doc)

alter table BRAINSTORMERS.Cuentas add constraint pk_cta_cod primary key(cta_cod)

--alter table BRAINSTORMERS.CuentasDest add constraint pk_ctadest_cod primary key(cta_cod)

alter table BRAINSTORMERS.Depositos add constraint pk_cod_depo primary key(cod_depo)

alter table BRAINSTORMERS.Cheques add constraint pk_nro_cheque primary key(nro_cheque)

alter table BRAINSTORMERS.Bancos add constraint pk_cod_banco primary key(cod_banco)

--alter table BRAINSTORMERS.Documentos add constraint pk_cod_doc primary key(cod_doc)

alter table BRAINSTORMERS.Facturas add constraint pk_cod_factura primary key(cod_factura)

--alter table BRAINSTORMERS.Items add constraint pk_cod_item primary key(cod_item)

alter table BRAINSTORMERS.Paises add constraint pk_cod_pais primary key(cod_pais)

alter table BRAINSTORMERS.Retiros add constraint pk_cod_retiro primary key(cod_retiro)

alter table BRAINSTORMERS.Tarjetas add constraint pk_tarjeta_numero primary key(tarjeta_numero)

alter table BRAINSTORMERS.Tipo_Cuenta add constraint pk_cod_tipo primary key(cod_tipo)

alter table BRAINSTORMERS.Tipo_Moneda add constraint pk_cod_moneda primary key(cod_moneda)

alter table BRAINSTORMERS.Transferencias add constraint pk_cod_transferencia primary key(cod_transf)

alter table [BRAINSTORMERS].Cuentas  WITH CHECK ADD CONSTRAINT [FK_Cuentas_Clientes] FOREIGN KEY([Cli_cod])
REFERENCES [BRAINSTORMERS].[Clientes] ([Cli_nro_doc])

alter table [BRAINSTORMERS].Cuentas  WITH CHECK ADD CONSTRAINT [FK_Cuentas_Tipo_Cuenta] FOREIGN KEY([cod_tipo])
REFERENCES [BRAINSTORMERS].[Tipo_Cuenta] ([cod_tipo])

alter table [BRAINSTORMERS].Cuentas  WITH CHECK ADD CONSTRAINT [FK_Cuentas_Tipo_moneda] FOREIGN KEY([moneda])
REFERENCES [BRAINSTORMERS].[Tipo_moneda] ([cod_Moneda])

alter table [BRAINSTORMERS].Clientes  WITH CHECK ADD CONSTRAINT [FK_Clientes_Paises] FOREIGN KEY([Cli_Pais_Codigo])
REFERENCES [BRAINSTORMERS].[Paises] ([cod_pais])

--alter table [BRAINSTORMERS].Clientes  WITH CHECK ADD CONSTRAINT [FK_Clientes_Documentos] FOREIGN KEY([Cli_Tipo_Doc_Cod])
--REFERENCES [BRAINSTORMERS].[Documentos] ([cod_doc])

alter table [BRAINSTORMERS].Tarjetas  WITH CHECK ADD CONSTRAINT [FK_Tarjetas_Clientes] FOREIGN KEY([Cod_cli])
REFERENCES [BRAINSTORMERS].[Clientes] ([Cli_nro_doc])

alter table [BRAINSTORMERS].Tarjetas  WITH CHECK ADD CONSTRAINT [FK_Tarjetas_Bancos] FOREIGN KEY([Cod_banco])
REFERENCES [BRAINSTORMERS].[Bancos] ([cod_banco])

alter table [BRAINSTORMERS].Facturas  WITH CHECK ADD CONSTRAINT [FK_Facturas_Clientes] FOREIGN KEY([cod_cli])
REFERENCES [BRAINSTORMERS].[Clientes] ([Cli_nro_doc])

alter table [BRAINSTORMERS].Items  WITH CHECK ADD CONSTRAINT [FK_Items_Facturas] FOREIGN KEY([cod_factura])
REFERENCES [BRAINSTORMERS].[Facturas] ([cod_factura])

alter table [BRAINSTORMERS].Depositos  WITH CHECK ADD CONSTRAINT [FK_Depositos_Clientes] FOREIGN KEY([Cli_cod])
REFERENCES [BRAINSTORMERS].[Clientes] ([Cli_nro_doc])

alter table [BRAINSTORMERS].Retiros  WITH CHECK ADD CONSTRAINT [FK_Retiros_Clientes] FOREIGN KEY([cod_cli])
REFERENCES [BRAINSTORMERS].[Clientes] ([Cli_nro_doc])

alter table [BRAINSTORMERS].Transferencias  WITH CHECK ADD CONSTRAINT [FK_Transferencias_Clientes] FOREIGN KEY([cod_cli])
REFERENCES [BRAINSTORMERS].[Clientes] ([Cli_nro_doc])

--alter table [BRAINSTORMERS].Transferencias  WITH CHECK ADD CONSTRAINT [FK_Transferencias_CuentasDest] FOREIGN KEY([cta_dest])
--REFERENCES [BRAINSTORMERS].[CuentasDest] ([cta_cod])

alter table [BRAINSTORMERS].Cheques  WITH CHECK ADD CONSTRAINT [FK_Cheques_Retiros] FOREIGN KEY([cod_retiro])
REFERENCES [BRAINSTORMERS].[Retiros] ([cod_retiro])

alter table [BRAINSTORMERS].Cheques  WITH CHECK ADD CONSTRAINT [FK_Cheques_Clientes] FOREIGN KEY([cod_cli])
REFERENCES [BRAINSTORMERS].[Clientes] ([Cli_nro_doc])

alter table [BRAINSTORMERS].Cheques  WITH CHECK ADD CONSTRAINT [FK_Cheques_Bancos] FOREIGN KEY([cod_banco])
REFERENCES [BRAINSTORMERS].[Bancos] ([cod_banco])

alter table [BRAINSTORMERS].Cuentas  WITH CHECK ADD CONSTRAINT [FK_cuentas_paises] FOREIGN KEY([cuenta_pais_codigo])
REFERENCES [BRAINSTORMERS].[Paises] ([cod_pais])

--alter table [BRAINSTORMERS].Cuentasdest  WITH CHECK ADD CONSTRAINT [FK_cuentasdest_paises] FOREIGN KEY([cuenta_pais_codigo])
--REFERENCES [BRAINSTORMERS].[Paises] ([cod_pais])

alter table [BRAINSTORMERS].Clientes  WITH CHECK ADD CONSTRAINT [FK_clientes_usuarios] FOREIGN KEY([username])
REFERENCES [BRAINSTORMERS].[usuarios] ([username])

alter table [BRAINSTORMERS].auditoria  WITH CHECK ADD CONSTRAINT [FK_auditoria_usuarios] FOREIGN KEY([username])
REFERENCES [BRAINSTORMERS].[usuarios] ([username])

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [BRAINSTORMERS].[sp_obtenerusuario]
	@username nvarchar(20)
	
AS
BEGIN
	select username,pass,fechacrea,fechaultmod,preguntasecreta,respuestasecreta  
	from [BRAINSTORMERS].usuarios
	where username = @username
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [BRAINSTORMERS].[sp_obtenerroles]
	@username nvarchar(20)
	
AS
BEGIN
	select UXR.idRol,Rs.nombre,Rs.estado 
	from ((BRAINSTORMERS.Usuarios U join BRAINSTORMERS.UsuarioXRol UXR on U.username = UXR.username) join BRAINSTORMERS.Roles Rs on UXR.idRol = Rs.idRol)
	where (U.username=@username) 
	
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [BRAINSTORMERS].[sp_cargar_tablas]
	
AS
BEGIN
	insert BRAINSTORMERS.USUARIOS (username,pass,fechacrea,fechaultmod,preguntasecreta,respuestasecreta) 
	values	('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',2015-04-26, 2015-04-26, 'preguntasecreta', '1f761f7127462b23542d2c1c7e1a308a4d1a0aa22410a28a536a53b366dd8371')
	insert BRAINSTORMERS.roles values (1,'admin',1)
	insert BRAINSTORMERS.roles values (2,'cliente',1)
	insert BRAINSTORMERS.usuarioxrol values	('admin',1)
	insert BRAINSTORMERS.usuarioxrol values	('admin',2)
	insert BRAINSTORMERS.Funcionalidades values	(1,'ABM de roles')
	insert BRAINSTORMERS.Funcionalidades values	(2,'ABM de usuarios')
	insert BRAINSTORMERS.RolXFuncionalidad values (1,1)
	insert BRAINSTORMERS.RolXFuncionalidad values (1,2)
	insert BRAINSTORMERS.Paises select distinct cli_pais_codigo,cli_pais_desc from gd_esquema.Maestra union select distinct Cuenta_Pais_Codigo,Cuenta_Pais_Desc from gd_esquema.Maestra order by Cli_Pais_Codigo
	insert BRAINSTORMERS.Cuentas (cta_cod,estado,cuenta_Pais_codigo,cuenta_fecha_cierre,cuenta_fecha_creacion) select cuenta_numero,cuenta_estado,cuenta_pais_codigo,cuenta_fecha_cierre,cuenta_fecha_creacion from gd_esquema.Maestra group by cuenta_numero,cuenta_estado,cuenta_pais_codigo,cuenta_fecha_cierre,cuenta_fecha_creacion order by Cuenta_Numero
	--insert BRAINSTORMERS.Documentos select Cli_Tipo_Doc_Cod,Cli_Tipo_Doc_Desc from gd_esquema.Maestra group by Cli_Tipo_Doc_Cod,Cli_Tipo_Doc_Desc order by Cli_Tipo_Doc_Cod	
	set identity_insert BRAINSTORMERS.clientes on
	insert BRAINSTORMERS.Clientes (cli_nro_doc,cli_nombre,cli_apellido,cli_dom_calle,cli_dom_nro,cli_dom_piso,cli_dom_depto,cli_fecha_nac,cli_mail,cli_pais_codigo,cli_tipo_doc_cod,cli_tipo_doc_desc) select distinct cli_nro_doc,cli_nombre,cli_apellido,cli_dom_calle,cli_dom_nro,cli_dom_piso,cli_dom_depto,cli_fecha_nac,cli_mail,cli_pais_codigo,cli_tipo_doc_cod,cli_tipo_doc_desc from gd_esquema.Maestra group by cli_nro_doc,cli_nombre,cli_apellido,cli_dom_calle,cli_dom_nro,cli_dom_piso,cli_dom_depto,cli_fecha_nac,cli_mail,cli_pais_codigo,cli_tipo_doc_cod,cli_tipo_doc_desc order by Cli_Nro_Doc
	insert BRAINSTORMERS.Bancos select banco_cogido,banco_nombre,banco_direccion from gd_esquema.Maestra where Banco_Cogido is not null group by banco_cogido,banco_nombre,banco_direccion order by Banco_Cogido
	insert BRAINSTORMERS.Cheques (nro_cheque,fecha,importe) select cheque_numero,cheque_fecha,cheque_importe from gd_esquema.Maestra where Cheque_Numero is not null group by Cheque_Numero,Cheque_Fecha,Cheque_Importe order by Cheque_Numero
	--insert BRAINSTORMERS.CuentasDest (cta_cod,cuenta_fecha_creacion,estado,cuenta_Pais_codigo,cuenta_fecha_cierre) select cuenta_dest_numero,Cuenta_Dest_Fecha_Creacion,Cuenta_Dest_Estado,Cuenta_Dest_Pais_Codigo,Cuenta_Dest_Fecha_Cierre from gd_esquema.Maestra where cuenta_dest_numero is not null group by cuenta_dest_numero,Cuenta_Dest_Fecha_Creacion,Cuenta_Dest_Estado,Cuenta_Dest_Pais_Codigo,Cuenta_Dest_Fecha_Cierre order by Cuenta_Dest_Numero
	insert BRAINSTORMERS.Depositos (cod_depo,fecha,importe) select Deposito_Codigo,Deposito_Fecha,Deposito_Importe from gd_esquema.Maestra where Deposito_Codigo is not null group by Deposito_Codigo,Deposito_Fecha,Deposito_Importe order by Deposito_Codigo
	insert BRAINSTORMERS.Facturas (cod_factura,fecha_emision) select distinct factura_numero,factura_fecha from gd_esquema.Maestra where factura_numero is not null group by Factura_Numero,Factura_Fecha order by Factura_Numero	
END
go

create PROCEDURE [BRAINSTORMERS].[sp_borrar_tablas]
		
AS
BEGIN
	--delete BRAINSTORMERS.CuentasDest
	delete BRAINSTORMERS.Clientes
	delete BRAINSTORMERS.Paises 
	--delete BRAINSTORMERS.Documentos 
	delete BRAINSTORMERS.Cuentas
	delete BRAINSTORMERS.Bancos
	delete BRAINSTORMERS.Cheques
	delete BRAINSTORMERS.Depositos
	delete BRAINSTORMERS.Facturas
	delete BRAINSTORMERS.Items
	delete BRAINSTORMERS.Retiros
	delete BRAINSTORMERS.UsuarioXRol
	delete BRAINSTORMERS.RolXFuncionalidad
	delete BRAINSTORMERS.Roles
	delete BRAINSTORMERS.Tarjetas
	delete BRAINSTORMERS.Tipo_Cuenta
	delete BRAINSTORMERS.Tipo_moneda
	delete BRAINSTORMERS.Transferencias
	delete BRAINSTORMERS.Usuarios
	delete BRAINSTORMERS.Funcionalidades  
	
END
go





--generar usuarios a cada cliente migrado

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create TRIGGER [BRAINSTORMERS].[t_genera_username] 
   ON [BRAINSTORMERS].[Clientes]  
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert BRAINSTORMERS.usuarios (username,fechacrea,fechaultmod) select case when cli_nombre in (select cli_nombre from BRAINSTORMERS.Clientes) then cli_nombre+substring(cli_apellido,1,1) else cli_nombre end,getdate(),getdate() from BRAINSTORMERS.Clientes order by Cli_Nombre
	

END

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE BRAINSTORMERS.sp_obtenerFuncionalidades 
	@idrol int
	
AS
BEGIN
	SET NOCOUNT ON;

    select f.idfuncionalidad,f.nombre 
    from BRAINSTORMERS.RolXFuncionalidad rxf join BRAINSTORMERS.Funcionalidades f on rxf.idFuncionalidad=f.idFuncionalidad
	where rxf.idRol=@idrol
END
GO


--BRAINSTORMERS.sp_borrar_tablas
BRAINSTORMERS.sp_cargar_tablas

--BRAINSTORMERS.sp_obtenerfuncionalidades
