
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Charly Blues
-- =============================================
ALTER PROCEDURE clientes_insertarRegistro
	@idcliente int,
	@razonsocial varchar (100),
	@CUIL char(11)
	

	as
	begin
   insert into dbo.Clientes values(@idcliente,@razonsocial,@CUIL)

END
GO
