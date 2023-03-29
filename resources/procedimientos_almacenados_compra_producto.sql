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