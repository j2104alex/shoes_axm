-- ************ CREADO POR: CRISTIAN ALBERTO HERNANDEZ *********************
-- ***************** PROCEDURES EMPLEADO **********************************

-- LISTAR EMPLEADO POR ID
CREATE PROCEDURE USP_listar_empleado_por_id
	@id_empleado varchar(20)
as
begin
SELECT * FROM empleado WHERE id_empleado = @id_empleado
end
go
-- LISTAR EMPLEADOS 
CREATE PROCEDURE USP_listar_empleados
as
begin
SELECT * FROM empleado
end
go
-- CREAR EMPLEADO
CREATE PROCEDURE USP_insertar_empleado
	@id_empleado varchar(20),
	@nombre_empleado varchar(30),
	@apellido_empleado varchar(30),
	@telefono_empleado varchar(15),
	@direccion_empleado varchar (50),
	@email_empleado varchar(30),
	@salario_empleado float

as
begin
	INSERT INTO empleado(id_empleado,nombre_empleado,apellido_empleado,telefono_empleado,direccion_empleado,email_empleado,salario_empleado) 
	VALUES(@id_empleado,@nombre_empleado,@apellido_empleado,@telefono_empleado,@direccion_empleado,@email_empleado,@salario_empleado)
end
go

-- ACTUALIZAR EMPLEADO
CREATE PROCEDURE USP_actualizar_empleado
	@id_empleado varchar(20),
	@nombre_empleado varchar(30),
	@apellido_empleado varchar(30),
	@telefono_empleado varchar(15),
	@direccion_empleado varchar (50),
	@email_empleado varchar(30),
	@salario_empleado float
as
begin
	UPDATE empleado SET
	nombre_empleado=@nombre_empleado,
	apellido_empleado=@apellido_empleado,
	telefono_empleado=@telefono_empleado,
	direccion_empleado=@direccion_empleado,
	email_empleado= @email_empleado,
	salario_empleado= @salario_empleado
	WHERE id_empleado=@id_empleado
end
go
--BORRAR EMPLEADO
CREATE PROCEDURE USP_borrar_empleado
	@id_empleado varchar(20)
as
begin
	DELETE FROM empleado
	WHERE id_empleado = @id_empleado
end
go
-- ***************** FIN PROCEDURES EMPLEADO ********************************