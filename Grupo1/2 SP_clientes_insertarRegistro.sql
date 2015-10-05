USE [Segpool]
GO
/****** Object:  StoredProcedure [dbo].[clientes_insertarRegistro]    Script Date: 05/10/2015 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Gabriel
-- =============================================
CREATE PROCEDURE [dbo].[clientes_insertarRegistro]
	@idcliente int,
	@apellido varchar (50),
	@razonsocial varchar (100)

AS
BEGIN
   insert into dbo.Clientes values(@idcliente,@apellido, @razonsocial)

END
