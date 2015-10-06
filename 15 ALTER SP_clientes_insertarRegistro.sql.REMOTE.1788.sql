El campo apellido lo agrego gabriel   
ALTER procedure dbo.clientes_insertarRegistro 
	@idCliente int, 
	@apellido varchar(50),
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
					apellido,
					razonsocial,
					cuil,
					calle,
					mail,
					web,
					localidad,
					telefono,
					telefonocelular)
					 
	VALUES(@idCliente, 
			@apellido,
			@razonsocial,
			@cuil,
			@calle,
			@email,
			@dirWeb,
			@localidad,
			@telefono,
			@telefonocelular)
