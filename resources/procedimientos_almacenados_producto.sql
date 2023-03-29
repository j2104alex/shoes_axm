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
