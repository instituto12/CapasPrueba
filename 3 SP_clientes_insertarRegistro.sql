USE [Segpool]
GO
/****** Object:  StoredProcedure [dbo].[clientes_insertarRegistro]    Script Date: 30/09/2014 07:26:52 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Charly Blues
-- =============================================
CREATE PROCEDURE [dbo].[clientes_insertarRegistro]
	@idcliente int,
	@razonsocial varchar (100)
	
AS
BEGIN
   insert into dbo.Clientes values(@idcliente,@razonsocial)

END
