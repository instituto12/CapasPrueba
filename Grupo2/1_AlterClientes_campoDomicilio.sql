/*
   martes, 29 de septiembre de 201521:11:08
   Usuario: 
   Servidor: LAPTOP\SQLEXPRESS
   Base de datos: Segpool
   Aplicación: 
*/

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Clientes ADD
	domicilio varchar(50) NULL
GO
ALTER TABLE dbo.Clientes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
