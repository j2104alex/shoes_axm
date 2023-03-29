--*************** CATEGORIA JUAN CORREA **********************-

--LISTAR TODOS LAS CATEGORIAS
CREATE PROCEDURE USP_listar_categoria

as
begin
	SELECT * FROM categoria
end
go
--LISTAR CATEGORIA
CREATE PROCEDURE USP_listar_categoria_id
	@id_categoria varchar(30) 
as
begin
	SELECT * FROM categoria WHERE id_categoria = @id_categoria
end
go
--INSERTAR CATEGORIA
CREATE PROCEDURE USP_insertar_categoria
	@nombre_categoria varchar(20),
	@descripcion_categoria varchar(50)
as
begin
	INSERT INTO categoria (nombre_categoria, descripcion_categoria)
	values(@nombre_categoria, @descripcion_categoria)
end
go

--ACTUALIZAR CATEGORIA
CREATE PROCEDURE USP_actualizar_categoria
	@id_categoria int,
	@nombre_categoria varchar(20),
	@descripcion_categoria varchar(50)
as
begin
	UPDATE categoria set 
	nombre_categoria=@nombre_categoria, 
	descripcion_categoria = @descripcion_categoria
	WHERE id_categoria = @id_categoria 
end
go

--ELIMINAR CATEGORIA
CREATE PROCEDURE USP_eliminar_categoria
	@id_categoria varchar(30) 
as
begin
	DELETE FROM categoria WHERE id_categoria = @id_categoria 
end
go

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

-- ************ CREADO POR: CRISTIAN ALBERTO HERNANDEZ *********************
-- ***************** PROCEDURES COMPRA-PRODUCTO ********************************

-- LISTAR COMPRA PRODUCTO POR ID
CREATE PROCEDURE USP_listar_compra_producto_por_id
	@id_compra_cp varchar(20)
as
begin
SELECT * FROM compra_producto WHERE id_compra_cp=@id_compra_cp
end
go
-- LISTAR COMPRA PRODUCTO
CREATE PROCEDURE USP_listar_compra_producto
as
begin
SELECT * FROM compra_producto
end
go
-- CREAR COMPRA PRODUCTO
CREATE PROCEDURE USP_insertar_compra_producto
	@id_compra_cp varchar(20),
	@cod_producto_cp varchar(30),
	@cantidad_producto_cp int,
	@costo_producto_cp float,
	@valor_total_producto_cp float
as
begin
	INSERT INTO compra_producto (id_compra_cp,cod_producto_cp,cantidad_producto_cp,costo_producto_cp,valor_total_producto_cp) 
	VALUES(@id_compra_cp,@cod_producto_cp,@cantidad_producto_cp,@costo_producto_cp,@valor_total_producto_cp)
end
go
--ACTUALIZAR COMPRA PRODUCTO
CREATE PROCEDURE USP_actualizar_compra_producto
	@id_compra_cp varchar(20),
	@cod_producto_cp varchar(30),
	@cantidad_producto_cp int,
	@costo_producto_cp float,
	@valor_total_producto_cp float
as
begin
	UPDATE compra_producto SET
	cod_producto_cp=@cod_producto_cp,
	cantidad_producto_cp=@cantidad_producto_cp,
	costo_producto_cp= @costo_producto_cp,
	valor_total_producto_cp=@valor_total_producto_cp
	WHERE id_compra_cp=@id_compra_cp
end
go
--BORRAR COMPRA PRODUCTO
CREATE PROCEDURE USP_borrar_compra_producto
	@id_compra_cp varchar(20)
as
begin
	DELETE FROM compra_producto
	WHERE id_compra_cp = @id_compra_cp
end

-- ***************** FIN PROCEDURES COMPRA-PRODUCTO ********************************
--Creado por: Jessica Berrio
--Prodedimientos almacenados: Compra

--Crear procedimiento insertar compra
CREATE PROCEDURE USP_Insertar_Compra
@id_compra varchar(20) ,
@fecha datetime,
@iva decimal,
@subtotal float,
@total float,
@id_empleado_FK varchar(20),
@id_proovedor_FK varchar(20)
as
begin
INSERT INTO compra(id_compra,fecha,iva,subtotal,total,id_empleado_FK,id_proovedor_FK)
VALUES (@id_compra,@fecha,@iva,@subtotal,@total,@id_empleado_FK,@id_proovedor_FK)
end

go 

----Crear procedimiento actualizar compra
CREATE PROCEDURE USP_Actualizar_Compra
@id_compra varchar(20),
@fecha datetime,
@iva decimal,
@subtotal float,
@total float,
@id_empleado_FK varchar(20),
@id_proovedor_FK varchar(20)
as
begin
UPDATE compra SET 
fecha=@fecha,
iva=@iva,
subtotal=@subtotal,
total=@total,
id_empleado_FK=@id_empleado_FK,
@id_proovedor_FK=@id_proovedor_FK
WHERE id_compra=@id_compra
end

go 
--Crear procedimiento eliminar venta
CREATE PROCEDURE USP_Eliminar_Compra
@id_compra int
as
begin
DELETE FROM compra
WHERE id_compra=@id_compra
end
go
--Crear procedimiento listar venta
CREATE PROCEDURE USP_Listar_Compra
as
begin
SELECT * FROM compra
end
go
--Crear procedimiento listar por id venta
CREATE PROCEDURE USP_Listar_Compra_Id
@id_compra int
as
begin
SELECT * FROM compra
WHERE id_compra=@id_compra
end
go
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
--********************** PRODUCTO JUAN CORREA ******************************

--LISTAR TODOS LOS PRODUCTOS
CREATE PROCEDURE USP_listar_producto

as
begin
	SELECT * FROM producto
end
go
--LISTAR PRODUCTO
CREATE PROCEDURE USP_listar_producto_id
	@cod_producto varchar(30) 
as
begin
	SELECT * FROM producto WHERE cod_producto = @cod_producto
end
go
--INSERTAR PRODUCTO
CREATE PROCEDURE USP_insertar_producto
	@cod_producto varchar(30) ,
	@nombre_producto varchar(30) ,
	@descripción_producto varchar(50) ,
	@precio_producto float,
	@id_categoria_fk int
as
begin
	INSERT INTO producto (cod_producto, nombre_producto, descripción_producto, precio_producto, id_categoria_fk)
	values(@cod_producto, @nombre_producto, @descripción_producto, @precio_producto, @id_categoria_fk)
end
go

--ACTUALIZAR PRODUCTO
CREATE PROCEDURE USP_actualizar_producto
	@nombre_producto varchar(30) ,
	@descripción_producto varchar(50) ,
	@precio_producto float,
	@id_categoria_fk int,
	@cod_producto varchar(30) 
as
begin
	UPDATE producto set 
	nombre_producto=@nombre_producto, 
	descripción_producto = @descripción_producto, 
	precio_producto = @precio_producto, 
	id_categoria_fk = @id_categoria_fk
	WHERE cod_producto = @cod_producto 
end
go

--ELIMINAR PRODUCTO
CREATE PROCEDURE USP_eliminar_producto
	@cod_producto varchar(30) 
as
begin
	DELETE FROM producto WHERE cod_producto = @cod_producto 
end
go
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
-- ************ CREADO POR: CRISTIAN ALBERTO HERNANDEZ *********************
-- ***************** PROCEDURES VENTA-PRODUCTO ********************************
-- LISTAR VENTA PRODUCTO POR ID
CREATE PROCEDURE USP_listar_venta_producto_por_id
	@id_venta_vp varchar(20)
as
begin
SELECT * FROM venta_producto WHERE id_venta_vp=@id_venta_vp
end
go
-- LISTAR VENTA PRODUCTO
CREATE PROCEDURE USP_listar_venta_producto
as
begin
SELECT * FROM venta_producto
end
go
-- CREAR VENTA PRODUCTO
CREATE PROCEDURE USP_insertar_venta_producto
	@id_venta_vp int,
	@cod_producto_vp varchar(30),
	@cantidad_producto int,
	@valor_total_producto float
as
begin
	INSERT INTO venta_producto (id_venta_vp,cod_producto_vp,cantidad_producto,valor_total_producto) 
	VALUES(@id_venta_vp,@cod_producto_vp,@cantidad_producto,@valor_total_producto)
end
go
--ACTUALIZAR VENTA PRODUCTO
CREATE PROCEDURE USP_actualizar_venta_producto
	@id_venta_vp int,
	@cod_producto_vp varchar(30),
	@cantidad_producto int,
	@valor_total_producto float
as
begin
	UPDATE venta_producto SET
	id_venta_vp=@id_venta_vp,
	cod_producto_vp=@cod_producto_vp,
	cantidad_producto= @cantidad_producto,
	valor_total_producto=@valor_total_producto
	WHERE id_venta_vp=@id_venta_vp
end
go
--BORRAR VENTA PRODUCTO
CREATE PROCEDURE USP_borrar_venta_producto
	@id_venta_vp varchar(20)
as
begin
	DELETE FROM venta_producto
	WHERE id_venta_vp = @id_venta_vp
end
go

-- ***************** FIN PROCEDURES COMPRA-PRODUCTO ********************************

--Creado por: Jessica Berrio
--Prodedimientos almacenados: Venta

--Crear procedimiento insertar venta
CREATE PROCEDURE USP_Insertar_Venta 
@fecha datetime,
@iva float,
@subtotal float,
@total float,
@id_empleado_fk varchar(20),
@id_cliente_fk varchar(20)
as
begin
INSERT INTO venta(fecha,iva,subtotal,total,id_empleado_fk, id_cliente_fk)
VALUES (@fecha,@iva,@subtotal,@total,@id_empleado_fk,@id_cliente_fk)
end

go 

----Crear procedimiento actualizar venta
CREATE PROCEDURE USP_Actualizar_Venta 
@id_venta int,
@fecha datetime,
@iva float,
@subtotal float,
@total float,
@id_empleado_fk varchar(20),
@id_cliente_fk varchar(20)
as
begin
UPDATE venta SET 
fecha=@fecha,
iva=@iva,
subtotal=@subtotal,
total=@total,
id_empleado_fk=@id_empleado_fk,
id_cliente_fk=@id_cliente_fk
WHERE id_venta=@id_venta
end

go 
--Crear procedimiento eliminar venta
CREATE PROCEDURE USP_Eliminar_Venta 
@id_venta int
as
begin
DELETE FROM venta
WHERE id_venta=@id_venta
end
go
--Crear procedimiento listar venta
CREATE PROCEDURE USP_Listar_Venta 
as
begin
SELECT * FROM venta
end
go
--Crear procedimiento listar por id venta
CREATE PROCEDURE USP_Listar_Venta_Id
@id_venta int
as
begin
SELECT * FROM venta
WHERE id_venta=@id_venta
end
go

-- ************ CREADO POR: CRISTIAN ALBERTO HERNANDEZ *********************
-- PROCEDIMIENTOS ALMACENADOS COMBOBOX
CREATE PROCEDURE USP_combobox_empleado
as
begin
	SELECT '0' as id_empleado, 'Seleccione un empleado'  as nombre_empleado from empleado
	union
	SELECT id_empleado,nombre_empleado from empleado

end
go
CREATE PROCEDURE USP_combobox_proveedor
as
begin
	SELECT '0' as id_proveedor, 'Seleccione una proveedor'  as nombre_proveedor from proveedor
	union
	SELECT id_proveedor,nombre_proveedor from proveedor
end
go
CREATE PROCEDURE USP_combobox_categoria
as
begin
	SELECT '0' as id_categoria, 'Seleccione un categoria'  as nombre_categoria from categoria
	union
	SELECT id_categoria,nombre_categoria from categoria
end

execute USP_combobox_empleado
execute USP_combobox_proveedor
execute USP_combobox_categoria
