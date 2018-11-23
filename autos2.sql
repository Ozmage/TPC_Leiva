CREATE DATABASE AUTOS2
GO 
USE AUTOS2
GO


CREATE TABLE anio (
  id int NOT NULL ,
  name varchar (200) NOT NULL,
  marca_id int NOT NULL,
  modelo_id int NOT NULL,
  version_id int NOT NULL,
  valor int NOT NULL,
  estado int NOT NULL
) 

go


INSERT INTO anio (id, name, marca_id, modelo_id, version_id, valor, estado) VALUES
(1, '2014', 2, 1, 1, 1, 1),
(2, '2014', 2, 1, 2, 1, 1),
(3, '2014', 2, 1, 3, 1, 1),
(4, '2014', 2, 1, 4, 1, 1),
(5, '2015', 2, 1, 1, 1, 1),
(6, '2014', 2, 1, 2, 1, 1),
(7, '2015', 2, 1, 3, 1, 1),
(8, '2015', 2, 1, 4, 1, 1),
(9, '2006', 4, 2, 5, 1, 1),
(10, '2007', 4, 2, 5, 1, 1),
(11, '2008', 4, 2, 5, 1, 1),
(12, '2009', 4, 2, 5, 1, 1),
(13, '2010', 4, 2, 5, 1, 1),
(14, '2006', 4, 2, 6, 1, 1),
(15, '2007', 4, 2, 6, 1, 1),
(16, '2008', 4, 2, 6, 1, 1),
(17, '2009', 4, 2, 6, 1, 1),
(18, '2010', 4, 2, 6, 1, 1),
(19, '2006', 4, 2, 7, 1, 1),
(20, '2007', 4, 2, 7, 1, 1);

go

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

CREATE TABLE combo (
  id int NOT NULL primary key,
  marca_id int NOT NULL,
  modelo_id int NOT NULL,
  version_id int NOT NULL
)

go

INSERT INTO combo (id, marca_id, modelo_id, version_id) VALUES
(1, 1, 1, 1),
(2, 1, 1, 1),
(3, 1, 1, 1);

CREATE TABLE marca (
  id int NOT NULL,
  name varchar (200)NOT NULL,
  estado int NOT NULL
)

INSERT INTO marca (id, name, estado) VALUES
(1, 'Agco Allis', 1),
(2, 'Agrale', 1),
(3, 'Agrinar', 1),
(4, 'Alfa Romeo', 1),
(5, 'Apache Solis', 1),
(6, 'Audi', 1),
(7, 'Baic', 1),
(8, 'BMW', 1),
(9, 'Case', 1),
(10, 'Challenger', 1)

go

CREATE TABLE modelo (
  id int NOT NULL primary key,
  name varchar(255) NOT NULL,
  marca_id int NOT NULL,
  vDP int NOT NULL,
  estado int NOT NULL
) 

INSERT INTO modelo (id, name, marca_id, vDP, estado) VALUES
(1, 'Marruá', 2, 0, 1),
(2, '147', 4, 1, 1),
(3, '156', 4, 1, 1),
(4, '159', 4, 1, 1),
(5, '166', 4, 1, 1),
(6, 'Brera', 4, 1, 1),
(7, 'Giulietta', 4, 1, 1),
(8, 'GT', 4, 1, 1),
(9, 'Mito', 4, 1, 1),
(10, 'Spider', 4, 1, 1),
(11, 'A1', 6, 0, 1),
(12, 'A3', 6, 0, 1),
(13, 'A4', 6, 0, 1),
(14, 'A5', 6, 0, 1),
(15, 'A6', 6, 0, 1),
(16, 'A7', 6, 0, 1),
(17, 'A8', 6, 0, 1),
(18, 'Allroad', 6, 0, 1),
(19, 'Q2', 6, 0, 1),
(20, 'Q3', 6, 0, 1);

go

CREATE TABLE version (
  id int NOT NULL ,
  name varchar (200)NOT NULL,
  modelo_id int NOT NULL,
  marca_id int NOT NULL,
  estado int NOT NULL
)

go

INSERT INTO version (id, name, modelo_id, marca_id, estado) VALUES
(1, 'AM100 2.8 4x4 Cabina Simple (150cv)', 1, 2, 1),
(2, 'AM100 2.8 4x4 Cabina Doble (150cv)', 1, 2, 1),
(3, 'AM150 2.8 4x4 Cabina Doble (150cv)', 1, 2, 1),
(4, 'AM200 2.8 4x4 Cabina Doble (150cv)', 1, 2, 1),
(5, '1.6 TS Progression (120cv) 3Ptas.', 2, 4, 1),
(6, '1.6 TS Progression (120cv) 5Ptas.', 2, 4, 1),
(7, '2.0 TS MT (150cv) 5Ptas.', 2, 4, 1),
(8, '2.0 TS Selespeed (150cv) 5Ptas.', 2, 4, 1),
(9, '1.9 JTD (150cv) 5Ptas.', 2, 4, 1),
(10, '1.9 JTD Cuero TC (150cv) 5Ptas.', 2, 4, 1),
(11, '2.0 TS (L03)', 3, 4, 1),
(12, '2.0 TS Selespeed (L03)', 3, 4, 1),
(13, '2.5 V6 (L03)', 3, 4, 1),
(14, '2.4 JTD (L03)', 3, 4, 1),
(15, '1.8 TBi 6MT Cuero TC (200cv)', 4, 4, 1);



CREATE TABLE persona (
  id int NOT NULL primary key,
  marca_id int NOT NULL,
  modelo_id int NOT NULL,
  version_id int NOT NULL,
  anio int NOT NULL,
  gasgnc varchar(200) NOT NULL,
  nombre varchar(200) NOT NULL,
  apellido varchar(200) NOT NULL,
  edad int NOT NULL,
  email varchar(200) NOT NULL,
  codArea int NOT NULL,
  telefono int NOT NULL,
  codPostal varchar(200) NOT NULL,
  localidad varchar(200) NOT NULL,
  provincia varchar(200) NOT NULL,
  codDesc varchar(200) NOT NULL
) 

go

INSERT INTO persona (id, marca_id, modelo_id, version_id, anio, gasgnc, nombre, apellido, edad, email, codArea, telefono, codPostal, localidad, provincia, codDesc) VALUES
(1, 1, 1, 2, 2000, 'Gas', 'Pepe', 'Pepon', 22, 'pepito@pepe.com', 11, 44448888, '1111', 'San Miguel', 'Buenos Aires', 'WB10'),
(2, 1, 2, 2, 2002, 'Gas', 'Carolo', 'Carolin', 22, 'carolo@pepe.com', 11, 75857587, '1111', 'San Miguel', 'Buenos Aires', 'WB10'),
(3, 1, 3, 2, 2003, 'Gas', 'Pepe', 'Pepon', 22, 'pepito@pepe.com', 11, 44584458, '1111', 'San Miguel', 'Buenos Aires', 'WB10'),
(4, 1, 1, 2, 2004, 'Gnc', 'Pepe', 'Pepon', 22, 'pepito@pepe.com', 11, 66584474, '1111', 'San Miguel', 'Buenos Aires', 'WB10');

CREATE TABLE Personas (
  idPersona int primary key  NOT NULL,
  marca varchar(100) NOT NULL,
  modelo varchar(100) NOT NULL,
  version varchar(100) NOT NULL,
  anio int NOT NULL,
  gasgnc varchar(100) NOT NULL,
  nombre varchar(100) NOT NULL,
  apellido varchar(100) NOT NULL,
  edad varchar(100) NOT NULL,
  email varchar(100) NOT NULL,
  codarea int NOT NULL,
  telefono int NOT NULL,
  codpostal varchar(100) NOT NULL,
  localidad varchar(100) NOT NULL,
  provincia varchar(100) NOT NULL,
  cdesc varchar(100) NOT NULL
) 


INSERT INTO version (id, name, modelo_id, marca_id, estado) VALUES
(1, 'AM100 2.8 4x4 Cabina Simple (150cv)', 1, 2, 1),
(2, 'AM100 2.8 4x4 Cabina Doble (150cv)', 1, 2, 1),
(3, 'AM150 2.8 4x4 Cabina Doble (150cv)', 1, 2, 1),
(4, 'AM200 2.8 4x4 Cabina Doble (150cv)', 1, 2, 1),
(5, '1.6 TS Progression (120cv) 3Ptas.', 2, 4, 1),
(6, '1.6 TS Progression (120cv) 5Ptas.', 2, 4, 1),
(7, '2.0 TS MT (150cv) 5Ptas.', 2, 4, 1),
(8, '2.0 TS Selespeed (150cv) 5Ptas.', 2, 4, 1),
(9, '1.9 JTD (150cv) 5Ptas.', 2, 4, 1),
(10, '1.9 JTD Cuero TC (150cv) 5Ptas.', 2, 4, 1),
(11, '2.0 TS (L03)', 3, 4, 1),
(12, '2.0 TS Selespeed (L03)', 3, 4, 1),
(13, '2.5 V6 (L03)', 3, 4, 1),
(14, '2.4 JTD (L03)', 3, 4, 1),
(15, '1.8 TBi 6MT Cuero TC (200cv)', 4, 4, 1),
(16, '2.2 JTS 6MT Progression (185cv)', 4, 4, 1),
(17, '2.2 JTS Selespeed Cuero (185cv)', 4, 4, 1);


