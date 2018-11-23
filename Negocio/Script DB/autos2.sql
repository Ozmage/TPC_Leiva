CREATE DATABASE AUTOS2
GO 
USE AUTOS2
GO



CREATE TABLE codigos (
  id int NOT NULL PRIMARY KEY,
  name varchar (200) NOT NULL,
  porcentaje int NOT NULL,
  estado int NOT NULL
)

go

INSERT INTO codigos (id, name, porcentaje, estado) VALUES
(1, 'WB10', 10, 1),
(2, 'WB20', 20, 1),
(3, 'WB30', 30, 1),
(4, 'WB40', 40, 1),
(5, 'WB50', 50, 1),
(6, 'WB60', 60, 1),
(7, 'WB70', 70, 1),
(8, 'WB80', 80, 1),
(9, 'WB90', 90, 1);

go


CREATE TABLE marca (
  id int primary key identity(1,1),
  name varchar (200)NOT NULL,
  estado int NOT NULL
)

INSERT INTO marca (name, estado) VALUES
('Agco Allis', 1),
('Agrale', 1),
('Agrinar', 1),
('Alfa Romeo', 1),
('Apache Solis', 1),
('Audi', 1),
('Baic', 1),
('BMW', 1),
('Case', 1),
('Challenger', 1)

go

CREATE TABLE modelo (
  id int identity(1,1) primary key,
  name varchar(255) NOT NULL ,
  marca_id int NOT NULL foreign key references marca (id),
  vDP int NOT NULL,
  estado int NOT NULL
) 

INSERT INTO modelo (name, marca_id, vDP, estado) VALUES
('Marruá', 2, 0, 1),
('147', 4, 1, 1),
('156', 4, 1, 1),
('159', 4, 1, 1),
('166', 4, 1, 1),
('Brera', 4, 1, 1),
('Giulietta', 4, 1, 1),
('GT', 4, 1, 1),
('Mito', 4, 1, 1),
('Spider', 4, 1, 1),
('A1', 6, 0, 1),
('A3', 6, 0, 1),
('A4', 6, 0, 1),
('A5', 6, 0, 1),
('A6', 6, 0, 1),
('A7', 6, 0, 1),
('A8', 6, 0, 1),
('Allroad', 6, 0, 1),
('Q2', 6, 0, 1),
('Q3', 6, 0, 1);

go

CREATE TABLE version (
  id int primary key identity(1,1),
  name varchar (200)NOT NULL,
  modelo_id int NOT NULL foreign key references modelo (id),
  marca_id int NOT NULL foreign key references marca (id),
  estado int NOT NULL
)

go


CREATE TABLE Clientes (
  idCliente int identity(1,1) primary key,
  dni int not null,
  nombre varchar(100) NOT NULL,
  apellido varchar(100) NOT NULL,
  direccion varchar(100) NOT NULL,
  pisoPlanta varchar(100) NOT NULL,
  email varchar(100) NOT NULL,
  telefono int NOT NULL,
  codPostal varchar(100) NOT NULL,
  localidad varchar(100) NOT NULL,
  provincia varchar(100) NOT NULL,
  fechaNacimiento date not null,
  estado int not null
  ) 

  go

  insert into clientes (dni, nombre, apellido, direccion,pisoplanta,email,telefono,codpostal,localidad,provincia,fechanacimiento,estado)
values (33333333,'pepe','pepon','calle falsa 123','pb','pepe@pepe.com','55555555','aaa222','Grand Bourg','Buenos Aires','2000-01-01','1')

go

INSERT INTO version (name, modelo_id, marca_id, estado) VALUES
('AM100 2.8 4x4 Cabina Simple (150cv)', 1, 2, 1),
('AM100 2.8 4x4 Cabina Doble (150cv)', 1, 2, 1),
('AM150 2.8 4x4 Cabina Doble (150cv)', 1, 2, 1),
('AM200 2.8 4x4 Cabina Doble (150cv)', 1, 2, 1),
('1.6 TS Progression (120cv) 3Ptas.', 2, 4, 1),
('1.6 TS Progression (120cv) 5Ptas.', 2, 4, 1),
('2.0 TS MT (150cv) 5Ptas.', 2, 4, 1),
('2.0 TS Selespeed (150cv) 5Ptas.', 2, 4, 1),
('1.9 JTD (150cv) 5Ptas.', 2, 4, 1),
('1.9 JTD Cuero TC (150cv) 5Ptas.', 2, 4, 1),
('2.0 TS (L03)', 3, 4, 1),
('2.0 TS Selespeed (L03)', 3, 4, 1),
('2.5 V6 (L03)', 3, 4, 1),
('2.4 JTD (L03)', 3, 4, 1),
('1.8 TBi 6MT Cuero TC (200cv)', 4, 4, 1),
('2.2 JTS 6MT Progression (185cv)', 4, 4, 1),
('2.2 JTS Selespeed Cuero (185cv)', 4, 4, 1);



create table Presupuestos (
idPresupuesto int identity(1,1) not null primary key ,
idCliente int not null foreign key references Clientes (idCliente),
fechaPresupuesto date ,
fechaVencimiento date ,
marca_id int ,
modelo_id int ,
version_id int ,
patente varchar(10) ,
ceroKm varchar (60) ,
anio int ,
gncGas varchar (60),
formaDePago varchar (60) ,
detalle varchar (300) ,
codDescuento varchar (50),
estado int not null);

go

create table Cliente_x_presupuesto (
idCliente int not null foreign key references Clientes(idCliente),
idPresupuesto int not null foreign key references Presupuestos(idPresupuesto)
)

INSERT INTO presupuestos (idCliente, fechaPresupuesto, fechaVencimiento, marca_id, modelo_id, version_id, patente, ceroKm, anio, gncGas, formaDePago, detalle, codDescuento, estado) VALUES
(1,'01-01-01', '01-01-02',1, 1, 1,'ABC123','0KM',2000,'GNC','Credito','Autazo','no',1)

go

create table usuarios (
username varchar (60) not null,
password varchar (60) not null,
email varchar (60) not null,
nivel int not null
)

go

insert into usuarios (username,password,email,nivel) values 
('admin','123','algo@algo.com',1),
('user','123','algo@algo.com',2)

create table presupuestos_x_cliente (
id int identity(1,1) not null,
idcliente  int not null,
idpresupuesto int not null,
estado int not null
)

go

insert into presupuestos_x_cliente (idcliente,idpresupuesto,estado) values 
(3,5,1)
