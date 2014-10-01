ALTER procedure clientes_insertarRegistro (@idCliente int, @razonsocial varchar, @cuil char, @calle varchar, @mail varchar, @web varchar) as 
insert into Clientes (idcliente,
					razonsocial,
					cuil,
					calle,
					mail,
					web) 
	values(@idCliente, 
			@razonsocial,
			@cuil,
			@calle,
			@mail,
			@web)
