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
CREATE TABLE dbo.Tmp_Clientes
	(
	idcliente int NOT NULL,
	razonsocial varchar(100) NULL,
	CUIL char(11) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Clientes SET (LOCK_ESCALATION = TABLE)
GO
IF EXISTS(SELECT * FROM dbo.Clientes)
	 EXEC('INSERT INTO dbo.Tmp_Clientes (idcliente, razonsocial, CUIL)
		SELECT idcliente, razonsocial, CUIL FROM dbo.Clientes WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.Clientes
GO
EXECUTE sp_rename N'dbo.Tmp_Clientes', N'Clientes', 'OBJECT' 
GO
ALTER TABLE dbo.Clientes ADD CONSTRAINT
	PK_Clientes PRIMARY KEY CLUSTERED 
	(
	idcliente
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
CREATE UNIQUE NONCLUSTERED INDEX IX_ClientesCUIL ON dbo.Clientes
	(
	CUIL
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
COMMIT