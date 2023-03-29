CREATE PROCEDURE USP_combobox_empleado
as
begin
	SELECT '0' as id, 'Seleccione un empleado'  as proveedor from empleado
	union
	SELECT id_empleado,nombre_empleado from empleado

end
go
CREATE PROCEDURE USP_combobox_proveedor
as
begin
	SELECT '0' as id, 'Seleccione una proveedor'  as proveedor from proveedor
	union
	SELECT id_proveedor,nombre_proveedor from proveedor
end
go
CREATE PROCEDURE USP_combobox_categoria
as
begin
	SELECT '0' as id, 'Seleccione un categoria'  as categoria from categoria
	union
	SELECT id_categoria,nombre_categoria from categoria
end

execute USP_combobox_empleado
execute USP_combobox_proveedor
execute USP_combobox_categoria