-- ================================================
-- 
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE clientes_obtenerRegistroPorCUIL 
	@CUIL char (11)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM dbo.Clientes WHERE cuil = @CUIL
END
