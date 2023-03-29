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