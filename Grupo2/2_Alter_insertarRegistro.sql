USE [Segpool]
GO
/****** Object:  StoredProcedure [dbo].[clientes_insertarRegistro]    Script Date: 29/09/2015 21:14:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Charly Blues
-- =============================================
ALTER PROCEDURE [dbo].[clientes_insertarRegistro]
	@idcliente int,
	@razonsocial varchar (100),
	@CUIL char(11),
	@domicilio varchar(50)
	

	as
	begin
   insert into dbo.Clientes values(@idcliente,@razonsocial,@CUIL,@domicilio)

END
