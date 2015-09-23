Esto lo puso diego
ALTER procedure dbo.clientes_insertarRegistro 
	@idCliente int, 
	@razonsocial varchar(100),
	@cuil char(11),
	@calle varchar(100),
	@email varchar(100),
	@dirWeb varchar(100),
	@localidad varchar (30),
	@telefono varchar (100),
	@telefonocelular varchar(12)
	
AS 
INSERT INTO Clientes (idcliente,
					razonsocial,
					cuil,
					calle,
					mail,
					web,
					localidad,
					telefono,
					telefonocelular)
					 
	VALUES(@idCliente, 
			@razonsocial,
			@cuil,
			@calle,
			@email,
			@dirWeb,
			@localidad,
			@telefono,
			@telefonocelular)
