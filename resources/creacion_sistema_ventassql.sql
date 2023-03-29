go
DROP DATABASE IF EXISTS sales_system_db;
go
CREATE DATABASE sales_system_db
go
USE sales_system_db;
go
--Creacion tabla cliente
CREATE TABLE cliente(
id_cliente varchar(20) primary key,
nombre_cliente varchar(30) not null,
apellido_cliente varchar(30) not null,
telefono_cliente varchar(15) not null,
direccion_cliente varchar (50) not null,
email_cliente varchar(30) not null
);
go
--Creacion tabla empleado
CREATE TABLE empleado(
id_empleado varchar(20) primary key not null,
nombre_empleado varchar(30) not null,                                        
apellido_empleado varchar(30) not null,
telefono_empleado varchar(15) not null,
direccion_empleado varchar (50) not null,
email_empleado varchar(30) not null,
salario_empleado float not null,
);
go
--Creacion tabla ventas
CREATE TABLE venta(
id_venta int primary key identity (1,1),
fecha datetime default current_timestamp not null,
iva float not null,
subtotal float not null,
total float not null,
id_empleado_fk varchar(20) not null,
id_cliente_fk varchar(20) not null,
FOREIGN KEY (id_empleado_fk) REFERENCES empleado(id_empleado),
FOREIGN KEY (id_cliente_fk) REFERENCES cliente(id_cliente)
);
go
--Creacion tabla categoria
CREATE TABLE categoria(
id_categoria int primary key identity (1,1),
nombre_categoria varchar(20) not null,
descripcion_categoria varchar(50) not null
);
go
--Creacion de tabla producto
CREATE TABLE producto(
cod_producto varchar(30) primary key,
nombre_producto varchar(30) not null,
descripción_producto varchar(50) not null,
precio_producto float not null,
id_categoria_fk int,
FOREIGN KEY (id_categoria_fk) REFERENCES categoria(id_categoria)
);
go
--Creacion de tabla puente-llave compuesta entre venta y producto
CREATE TABLE venta_producto (
id_venta_vp int,
cod_producto_vp varchar(30),
cantidad_producto int,
valor_total_producto float
foreign key (id_venta_vp) references venta(id_venta),
foreign key (cod_producto_vp) references producto(cod_producto),
primary key (id_venta_vp,cod_producto_vp)
);
go
--Creacion tabla proveedor
CREATE TABLE proveedor(
id_proveedor varchar(20) primary key,
nombre_proveedor varchar(30) not null,
apellido_proveedor varchar(30) not null,
telefono_proveedor varchar(15) not null,
direccion_proveedor varchar (50) not null,
email_proveedor varchar(30) not null
);
go
--Creacion tabla compra
CREATE TABLE compra(
id_compra varchar(20) primary key,
fecha datetime default current_timestamp not null,
iva decimal not null,
subtotal float not null,
total float not null,
id_empleado_FK varchar(20),
id_proovedor_FK varchar(20)
FOREIGN KEY (id_empleado_FK) REFERENCES empleado(id_empleado),
FOREIGN KEY (id_proovedor_FK) REFERENCES proveedor(id_proveedor)
);
go
--Creacion tabla puente-llave compuesta entre compra y producto
CREATE TABLE compra_producto (
id_compra_cp varchar(20),
cod_producto_cp varchar(30),
cantidad_producto_cp int not null,
costo_producto_cp float not null,
valor_total_producto_cp float not null,
foreign key (id_compra_cp) references compra(id_compra),
foreign key (cod_producto_cp) references producto(cod_producto),
primary key (id_compra_cp,cod_producto_cp)
);

