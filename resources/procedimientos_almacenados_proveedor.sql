-- ************ CREADO POR: CRISTIAN ALBERTO HERNANDEZ *********************
-- ***************** PROCEDURES PROVEEDOR **********************************
-- LISTAR PROVEEDOR POR ID
CREATE PROCEDURE USP_listar_proveedor_por_id
	@id_proveedor varchar(20)
as
begin
SELECT * FROM proveedor WHERE id_proveedor=@id_proveedor
end
go
-- LISTAR PROVEEDORES 
CREATE PROCEDURE USP_listar_proveedores
as
begin
SELECT * FROM proveedor
end
go
-- CREAR PROVEEDOR
CREATE PROCEDURE USP_insertar_proveedor
	@id_proveedor varchar(20),
	@nombre_proveedor varchar(30),
	@apellido_proveedor varchar(30),
	@telefono_proveedor varchar(15),
	@direccion_proveedor varchar (50),
	@email_proveedor varchar(30) 

as
begin
	INSERT INTO proveedor(id_proveedor,nombre_proveedor,apellido_proveedor,telefono_proveedor,direccion_proveedor,email_proveedor) 
	VALUES(@id_proveedor,@nombre_proveedor,@apellido_proveedor,@telefono_proveedor,@direccion_proveedor,@email_proveedor)
end
go

--ACTUALIZAR PROVEEDOR
CREATE PROCEDURE USP_actualizar_proveedor
	@id_proveedor varchar(20),
	@nombre_proveedor varchar(30),
	@apellido_proveedor varchar(30),
	@telefono_proveedor varchar(15),
	@direccion_proveedor varchar (50),
	@email_proveedor varchar(30) 
as
begin
	UPDATE proveedor SET
	nombre_proveedor=@nombre_proveedor,
	apellido_proveedor=@apellido_proveedor,
	telefono_proveedor=@telefono_proveedor,
	direccion_proveedor=@direccion_proveedor,
	email_proveedor= @email_proveedor
	WHERE id_proveedor=@id_proveedor
end
go
--BORRAR PROVEEDOR
CREATE PROCEDURE USP_borrar_proveedor
	@id_proveedor varchar(20)
as
begin
	DELETE FROM proveedor
	WHERE id_proveedor = @id_proveedor
end

-- ***************** FIN PROCEDURES PROVEEDORES ********************************
