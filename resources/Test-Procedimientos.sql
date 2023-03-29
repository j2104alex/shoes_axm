-- ***************** TEST EMPLEADO ********************************
-- TEST LISTAR EMPLEADO (ok)
execute USP_listar_empleados
-- TEST LISTAR EMPLEADO POR ID (ok)
execute USP_listar_empleado_por_id '1094909543'
-- TEST INSERTAR EMPLEADO (ok)
execute USP_insertar_empleado '1094909543','Pedro','alberto','6067477487','barrio las palmas m2 casa 12','cahernandez34@hotmail.com','200'
-- TEST ACTUALIZAR EMPLEADO (ok)
execute USP_actualizar_empleado '10101','camilo','alberto','6067477487','barrio las acacias m2 casa 12','cahernandez34@hotmail.com','400'
-- TEST BORRAR EMPLEADO (ok)
execute USP_borrar_empleado '1094909543'
go
-- ***************************************************************
go
-- ***************** TEST CLIENTE ********************************
-- TEST INSERTAR CLIENTE (ok)
execute USP_insertar_cliente '1094909543','cristian','alberto','6067477487','barrio las palmas m2 casa 12','cahernandez34@hotmail.com'
execute USP_insertar_cliente '1094909549','maria','sanchez','6067477400','barrio las casas del palmar m2 casa 12','mariasanchez@hotmail.com'
-- TEST ACTUALIZAR CLIENTE (ok)
execute USP_actualizar_cliente '1094909549','Sara','sanchez','6067477400','barrio las casas del palmar m2 casa 12','sarasanchez@hotmail.com'
-- TEST LISTAR CLIENTES (ok)
execute USP_listar_clientes
-- TEST LISTAR CLIENTE POR ID (ok)
execute USP_listar_cliente_por_id '1094909549'
-- TEST BORRAR CLIENTE (ok)
execute USP_borrar_cliente '1094909549'
go
-- ***************************************************************
go
-- ******************* TEST COMPRA ***********************
--TEST INSERTAR COMPRA (OK)
execute USP_Insertar_Compra '1','01-01-2002',0.4,4000,80000,'1094909543','1094909543'
--TEST ACTUALIZAR COMPRA (OK)
-- si se pone con decimal redondea a 1 o 0 preguntar. o consultar
execute USP_Actualizar_Compra '1','01-01-2002',0.9,4000,90000,'1094909543','1094909543' 
--TEST ELIMINAR COMPRA (OK)
execute USP_Eliminar_Compra '1'
--TEST LISTAR COMPRAS (OK)
execute USP_Listar_Compra
--TEST LISTAR COMPRA POR ID (OK)
execute USP_Listar_Compra_Id '1'
-- ***************************************************************
go
-- ******************* TEST PROVEEDORES ***********************
-- TEST LISTAR PROVEEDORES (ok)
execute USP_listar_empleados
-- TEST LISTAR PROVEEDOR POR ID (ok)
execute USP_listar_empleado_por_id '1094909543'
-- TEST INSERTAR PROVEEDOR (ok)
execute USP_insertar_empleado '1094909543','cristian','alberto','6067477487','barrio las palmas m2 casa 12','cahernandez34@hotmail.com','200'
-- TEST ACTUALIZAR PROVEEDOR (ok)
execute USP_actualizar_empleado '1094909543','camilo','alberto','6067477487','barrio las acacias m2 casa 12','cahernandez34@hotmail.com','400'
-- TEST BORRAR PROVEEDOR (ok)
execute USP_borrar_empleado '1094909543'
go
SELECT * FROM empleado
go
-- ***************************************************************

-- ******************* TEST VENTA ***********************
--TEST INSERTAR VENTA (OK)
execute USP_Insertar_Venta '01-01-2002',0.4,4000,80000,'1094909543','1094909543'
--TEST ACTUALIZAR VENTA (OK)
execute USP_Actualizar_Venta '1','01-01-2002',0.9,4000,80000,'1094909543','1094909543'
--TEST ELIMINAR VENTA (OK)
execute USP_Eliminar_Venta '1'
--TEST LISTAR VENTA (OK)
execute USP_Listar_Venta
--TEST LISTAR VENTA POR ID (OK)
execute USP_Listar_Venta_Id '3'
-- ***************************************************************
go
/*************** TEST PRODUCTO ***********/
-- TEST INSERTAR PRODUCTO (OK)
execute USP_insertar_producto '1','nike one','zapatillas nike',2999,3
execute USP_insertar_producto '2','nike aventure','zapatillas nike sport',2999,1004
execute USP_insertar_producto '3','reebock aventure','zapatillas nike sport',2999,1005
-- TEST ACTUALIZAR PRODUCTO (OK)
execute USP_actualizar_producto 'nike one','zapatillas nike',4999,3,'1'
-- TEST ELIMINAR PRODUCTO (OK)
execute USP_eliminar_producto '2'
-- TEST LISTAR CATEGORIA (OK)
execute USP_listar_producto
-- TEST LISTAR CATEGORIA ID (OK)
execute USP_listar_producto_id '2'
-- ***************************************************************

/*************** TEST CATEGORIA ***********/
-- TEST INSERTAR PRODUCTO (OK)
execute USP_insertar_categoria 'zapatilla ','zapatilla deportiva resistente al agua'
execute USP_insertar_categoria 'zapatilla crop ','zapatilla toda ocasion'
execute USP_insertar_categoria 'zapatilla nike ','zapatilla nike'
execute USP_insertar_categoria 'zapatilla addidas ','zapatilla adiddas'
-- TEST ACTUALIZAR CAREGORIA (OK)
execute USP_actualizar_categoria '3','zapatilla2','zapatilla deportiva resistente al agua nueva'
-- TEST ELIMINAR CAREGORIA (OK)
execute USP_eliminar_categoria '1002'
execute USP_eliminar_categoria '2'
execute USP_eliminar_categoria '3'
-- TEST LISTAR CATEGORIA (OK)
execute USP_listar_categoria
-- TEST LISTAR CATEGORIA ID (OK)
execute USP_listar_categoria_id '3'
-- ***************************************************************
go
-- ***************** TEST VENTA-PRODUCTO ********************************
-- TEST INSERTAR VENTA PRODUCTO (ok)
execute USP_insertar_venta_producto 3,'2',3400,12000
-- TEST ACTUALIZAR VENTA PRODUCTO (ok)
execute USP_actualizar_venta_producto 3,'2',400,12000
-- TEST LISTAR VENTA PRODUCTO (ok)
execute USP_listar_venta_producto
-- TEST LISTAR VENTA PRODUCTO POR ID (ok)
execute USP_listar_venta_producto_por_id '3'
-- TEST BORRAR VENTA PRODUCTO (ok)
execute USP_borrar_venta_producto '3'
go
-- ***************************************************************
go
-- ******************* TEST COMPRA PRODUCTO ***********************
-- TEST INSERTAR COMPRA PRODUCTO (ok)
execute USP_insertar_compra_producto '1','2',3,2000,6000
-- TEST ACTUALIZAR COMPRA PRODUCTO (ok)
execute USP_actualizar_compra_producto '1','2',3,2000,9000
-- TEST LISTAR COMPRA PRODUCTO (ok)
execute USP_listar_compra_producto
-- TEST LISTAR COMPRA PRODUCTO POR ID (ok)
execute USP_listar_compra_producto_por_id '1'
-- TEST BORRAR COMPRA PRODUCTO (ok)
execute USP_borrar_compra_producto '1'
-- ***************************************************************