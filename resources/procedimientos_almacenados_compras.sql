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