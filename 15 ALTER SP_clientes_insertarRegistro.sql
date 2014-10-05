ALTER procedure clientes_insertarRegistro 
	@idCliente int, 
	@razonsocial varchar(100),
	@cuil char(11),
	@calle varchar(100),
	@email varchar(100),
	@dirWeb varchar(100),
	@telefono varchar (100),
	@telefonocelular varchar(12)
AS 
INSERT INTO Clientes (idcliente,
					razonsocial,
					cuil,
					calle,
					mail,
					web,
					telefono,
					telefonocelular) 
	VALUES(@idCliente, 
			@razonsocial,
			@cuil,
			@calle,
			@email,
			@dirWeb,
			@telefono,
			@telefonocelular)
