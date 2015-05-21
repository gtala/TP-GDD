ALTER PROCEDURE [BrainStormers].[Sp_ObtenerPaises]
AS
BEGIN
	SELECT Pais_Codigo, Pais_Desc
	FROM BrainStormers.Pais
	Order by Pais_Desc ASC
END
