-- ************ CREADO POR: CRISTIAN ALBERTO HERNANDEZ *********************
-- ***************** PROCEDURES CLIENTE ********************************
-- LISTAR CLIENTES POR ID
CREATE PROCEDURE USP_listar_cliente_por_id
	@id_cliente varchar(20)
as
begin
SELECT * FROM cliente WHERE id_cliente=@id_cliente
end
go
-- LISTAR CLIENTES
CREATE PROCEDURE USP_listar_clientes
as
begin
SELECT * FROM cliente
end
go
-- CREAR CLIENTE
CREATE PROCEDURE USP_insertar_cliente
	@id_cliente varchar(20),
	@nombre_cliente varchar(30),
	@apellido_cliente varchar(30), 
	@telefono_cliente varchar(15), 
	@direccion_cliente varchar (50),
	@email_cliente varchar(30) 
as
begin
	INSERT INTO cliente(id_cliente,nombre_cliente,apellido_cliente,telefono_cliente,direccion_cliente,email_cliente) 
	VALUES(@id_cliente,@nombre_cliente,@apellido_cliente,@telefono_cliente,@direccion_cliente,@email_cliente)
end
go
--ACTUALIZAR CLIENTE
CREATE PROCEDURE USP_actualizar_cliente
	@id_cliente varchar(20),
	@nombre_cliente varchar(30),
	@apellido_cliente varchar(30), 
	@telefono_cliente varchar(15), 
	@direccion_cliente varchar (50),
	@email_cliente varchar(30) 
as
begin
	UPDATE cliente SET
	nombre_cliente=@nombre_cliente,
	apellido_cliente=@apellido_cliente,
	telefono_cliente=@telefono_cliente,
	direccion_cliente=@direccion_cliente,
	email_cliente= @email_cliente
	WHERE id_cliente=@id_cliente
end
go
--BORRAR CLIENTE
CREATE PROCEDURE USP_borrar_cliente
	@id_cliente varchar(20)
as
begin
	DELETE FROM cliente
	WHERE id_cliente = @id_cliente
end
go
-- ***************** FIN PROCEDURES CLIENTE ********************************
