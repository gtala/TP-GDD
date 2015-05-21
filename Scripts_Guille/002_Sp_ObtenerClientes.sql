CREATE PROCEDURE BrainStormers.Sp_ObtenerClientes
AS
BEGIN
	SELECT C.[Cliente_Codigo]
		,C.[Cliente_Nombre]
		,C.[Cliente_Apellido]
		,C.[Cliente_Tipo_Doc_Cod]
		,C.[Cliente_Nro_Doc]
		,C.[Cliente_Tipo_Doc_Desc]
		,C.[Cliente_Pais_Codigo]
		,C.[Cliente_Dom_Calle]
		,C.[Cliente_Dom_Nro]
		,C.[Cliente_Dom_Piso]
		,C.[Cliente_Dom_Depto]
		,C.[Cliente_Fecha_Nac]
		,C.[Cliente_Mail]
		,P.Pais_Codigo
		,P.Pais_Desc
	FROM [BrainStormers].[Cliente] C
		INNER JOIN BrainStormers.Pais P 
		ON c.Cliente_Pais_Codigo = P.Pais_Codigo
END
GO


