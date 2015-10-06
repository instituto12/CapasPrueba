-- ================================================
-- PROCEDIMIENTOS ALMACENADOS
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Gabriel
-- Create date: 05/11/2015
-- Description:	Obtiene un registro de la tabla
-- Clientes
-- =============================================
CREATE PROCEDURE  clientes_obtenerRegistro
	@idcliente int	
AS

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * FROM Clientes WHERE idcliente = @idcliente
END
GO
