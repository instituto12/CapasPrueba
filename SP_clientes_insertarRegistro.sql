
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Charly Blues
-- =============================================
CREATE PROCEDURE clientes_insertarRegistro
	@idcliente int,
	@razonsocial varchar (100),
	@calle varchar (100)

	as
	begin
   insert into dbo.Clientes values(@idcliente,@razonsocial,@calle)

END
GO
