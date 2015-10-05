
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Gabriel
-- =============================================
CREATE PROCEDURE clientes_eliminarRegistro

@idcliente int

AS
BEGIN
	
	delete from dbo.Clientes where @idcliente=@idcliente
END
GO
