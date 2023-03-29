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