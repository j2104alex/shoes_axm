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
