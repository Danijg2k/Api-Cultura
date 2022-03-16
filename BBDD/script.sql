--Hay que crear la base de datos por separado y luego ejecutar el sql

--CREATE DATABASE API_Cultura

use API_Cultura

--Crear Tabla Productos

CREATE TABLE Productos(
Id INTEGER IDENTITY(1,1),
Nombre VARCHAR(100),
Img VARCHAR(200),
CONSTRAINT Pk_Productos PRIMARY KEY (Id)
);

--Crear Tabla Proveedores

CREATE TABLE Proveedores(
Id INTEGER IDENTITY(1,1),
Nombre VARCHAR(100),
Poblacion VARCHAR(75),
Telefono VARCHAR(30),
CONSTRAINT Pk_Proveedores PRIMARY KEY (Id)
);

--Crear Tabla Provee

CREATE TABLE Provee(
Id INTEGER IDENTITY(1,1),
IdProducto INTEGER,
IdProveedor INTEGER,
Precio DECIMAL(5,2),
CONSTRAINT Pk_Provee PRIMARY KEY (Id,IdProducto,IdProveedor),
CONSTRAINT Fk_Productos_Provee FOREIGN KEY (IdProducto) REFERENCES Productos(Id),
CONSTRAINT Fk_Proveedores_Provee FOREIGN KEY (IdProveedor) REFERENCES Proveedores(Id)
);

--Crear Tabla Temporadas

CREATE TABLE Temporadas(
Id INTEGER IDENTITY(1,1),
Nombre VARCHAR(100),
Img VARCHAR(200),
Meses VARCHAR(50),
CONSTRAINT Pk_Temporadas PRIMARY KEY (Id)
);

--Crear Tabla Pertenece

CREATE TABLE Pertenece(
Id INTEGER IDENTITY(1,1),
IdProducto INTEGER,
IdTemporada INTEGER,
CONSTRAINT Pk_Pertenece PRIMARY KEY (Id,IdProducto,IdTemporada),
CONSTRAINT Fk_Productos_Pertenece FOREIGN KEY (IdProducto) REFERENCES Productos(Id),
CONSTRAINT Fk_Temporadas_Pertenece FOREIGN KEY (IdTemporada) REFERENCES Temporadas(Id)
);

--Crear Tabla Opiniones

CREATE TABLE Opiniones(
Id INTEGER IDENTITY(1,1),
Nombre VARCHAR(100),
Apellidos VARCHAR(150),
Email VARCHAR(150),
Telefono INTEGER,
Calificacion INTEGER,
Comentario VARCHAR(max)
CONSTRAINT Pk_Opiniones PRIMARY KEY (Id),
);

--Insertar datos Tabla Productos

INSERT INTO Productos VALUES('Huevos','/assets/Tienda/Huevos.png')
INSERT INTO Productos VALUES('Lechuga','/assets/Tienda/Lechuga.png')
INSERT INTO Productos VALUES('Tomate','/assets/Tienda/Tomate.png')
INSERT INTO Productos VALUES('Patata','/assets/Tienda/Patata.png')
INSERT INTO Productos VALUES('Manzana','/assets/Tienda/Manzana.png')
INSERT INTO Productos VALUES('Miel','/assets/Tienda/Miel.png')
INSERT INTO Productos VALUES('Zanahoria','/assets/Tienda/Zanahoria.png')
INSERT INTO Productos VALUES('Guisante','/assets/Tienda/Guisante.png')
INSERT INTO Productos VALUES('Ajo','/assets/Tienda/Ajo.png')
INSERT INTO Productos VALUES('Pimiento','/assets/Tienda/Pimiento.png')
INSERT INTO Productos VALUES('Calabacín','/assets/Tienda/Calabacin.png')
INSERT INTO Productos VALUES('Seta','/assets/Tienda/Seta.png')
INSERT INTO Productos VALUES('Naranja','/assets/Tienda/Naranja.png')
INSERT INTO Productos VALUES('Alcachofa','/assets/Tienda/Alcachofa.png')
INSERT INTO Productos VALUES('Pepino','/assets/Tienda/Pepino.png')
INSERT INTO Productos VALUES('Coliflor','/assets/Tienda/Coliflor.png')
INSERT INTO Productos VALUES('Brócoli','/assets/Tienda/Brocoli.png')
INSERT INTO Productos VALUES('Berenjena','/assets/Tienda/Berenjena.png')
INSERT INTO Productos VALUES('Acelga','/assets/Tienda/Acelga.png')
INSERT INTO Productos VALUES('Aceituna','/assets/Tienda/Aceituna.png')
INSERT INTO Productos VALUES('Pera','/assets/Tienda/Pera.png')
INSERT INTO Productos VALUES('Repollo','/assets/Tienda/Repollo.png')
INSERT INTO Productos VALUES('Granada','/assets/Tienda/Granada.png')
INSERT INTO Productos VALUES('Melocotón','/assets/Tienda/Melocoton.png')
INSERT INTO Productos VALUES('Sandía','/assets/Tienda/Sandia.png')
INSERT INTO Productos VALUES('Uva','/assets/Tienda/Uva.png')
INSERT INTO Productos VALUES('Ciruela','/assets/Tienda/Ciruela.png')
INSERT INTO Productos VALUES('Limón','/assets/Tienda/Limon.png')

--Insertar datos Tabla Proveedor

INSERT INTO Proveedores VALUES('José Luis O.','Calahorra', '34 611 11 11 11')
INSERT INTO Proveedores VALUES('Manolo R.','Calahorra', '34 611 11 11 11')

INSERT INTO Proveedores VALUES('Santiago I.','Arnedo', '34 611 11 11 11')
INSERT INTO Proveedores VALUES('Marcos T','Alfaro', '34 611 11 11  11')

INSERT INTO Proveedores VALUES('Alfredo D.','Préjano','34 611 11 11  11')
INSERT INTO Proveedores VALUES('Ignacio G.','Arnedillo','34 611 11 11  11')

INSERT INTO Proveedores VALUES('Luis P.','Autol','34 611 11 11  11')
INSERT INTO Proveedores VALUES('Paco L.','Calahorra', '34 611 11 11  11')


INSERT INTO Proveedores VALUES('Joana Comas','Arnedillo', '34 611 11 11  11')

INSERT INTO Proveedores VALUES('Victor Encinas','Arnedo', '34 611 11 11  11')

INSERT INTO Proveedores VALUES('Cristian Jaramillo','Calahorra', '34 611 11 11  11')

INSERT INTO Proveedores VALUES('Zoe Rivas','Alfaro', '34 611 11 11  11')

INSERT INTO Proveedores VALUES('Eloy Exposito','Arnedillo', '34 611 11 11  11')

INSERT INTO Proveedores VALUES('Karima Marin','Arnedo', '34 611 11 11  11')

INSERT INTO Proveedores VALUES('Amanda Cantero','Calahorra', '34 611 11 11  11')

INSERT INTO Proveedores VALUES('Nicoleta Alvarez','Autol', '34 611 11 11  11')

INSERT INTO Proveedores VALUES('Balbina Albert','Alfaro', '34 611 11 11  11')

INSERT INTO Proveedores VALUES('Norberto Perdomo','Arnedillo', '34 611 11 11  11')

INSERT INTO Proveedores VALUES('Imane Kaur','Autol', '34 611 11 11  11')

INSERT INTO Proveedores VALUES('Aurelia San-Martin','Arnedillo', '34 611 11 11  11')

INSERT INTO Proveedores VALUES('Estefania Garces','Arnedillo', '34 611 11 11  11')

INSERT INTO Proveedores VALUES('Nicole Olmo','Autol', '34 611 11 11  11')

INSERT INTO Proveedores VALUES('Pablo Palomino','Calahorra', '34 611 11 11  11')


--Insertar datos Tabla Provee

INSERT INTO Provee VALUES(1, 1 , 0.75)
INSERT INTO Provee VALUES(1, 2 , 0.90)

INSERT INTO Provee VALUES(2, 3 , 0.75)
INSERT INTO Provee VALUES(2, 4 , 0.80)

INSERT INTO Provee VALUES(3, 5 , 0.50)
INSERT INTO Provee VALUES(3, 6 , 0.50)

INSERT INTO Provee VALUES(4, 7, 0.20)
INSERT INTO Provee VALUES(4, 8, 0.25)


INSERT INTO Provee VALUES(5, 23, 0.25)

INSERT INTO Provee VALUES(6, 22, 3.25)

INSERT INTO Provee VALUES(7, 12, 0.45)

INSERT INTO Provee VALUES(8, 1, 0.25)

INSERT INTO Provee VALUES(9, 13, 0.85)

INSERT INTO Provee VALUES(10, 14, 2.00)

INSERT INTO Provee VALUES(11, 15, 0.30)

INSERT INTO Provee VALUES(12, 16, 1.70)

INSERT INTO Provee VALUES(13, 17, 0.30)

INSERT INTO Provee VALUES(14, 20, 0.50)

INSERT INTO Provee VALUES(15, 18, 0.40)

INSERT INTO Provee VALUES(16, 19, 0.40)

INSERT INTO Provee VALUES(17, 9, 0.30)

INSERT INTO Provee VALUES(18, 10, 0.65)

INSERT INTO Provee VALUES(19, 11, 0.40)

INSERT INTO Provee VALUES(20, 20, 0.70)

INSERT INTO Provee VALUES(21, 21, 0.55)

INSERT INTO Provee VALUES(22, 5, 0.20)

INSERT INTO Provee VALUES(23, 12, 0.35)

INSERT INTO Provee VALUES(24, 22, 1.20)

INSERT INTO Provee VALUES(25, 23, 0.15)

INSERT INTO Provee VALUES(26, 5, 0.60)

INSERT INTO Provee VALUES(27, 11, 0.50)

INSERT INTO Provee VALUES(28, 2, 0.20)



--Insertar datos Tabla Temporadas

INSERT INTO Temporadas VALUES('Primavera','/assets/Temporadas/Primavera.jpg','Marzo/Abril/Mayo/Junio')
INSERT INTO Temporadas VALUES('Verano','/assets/Temporadas/Verano.jpg','Junio/Julio/Agosto/Septiembre')
INSERT INTO Temporadas VALUES('Otoño','/assets/Temporadas/Otono.jpg','Septiembre/Octubre/Noviembre/Diciembre')
INSERT INTO Temporadas VALUES('Invierno','/assets/Temporadas/Invierno.jpg','Diciembre/Enero/Febrero/Marzo')

--Insertar datos Tabla Pertenece

-- Primavera
INSERT INTO Pertenece VALUES(16, 1)
INSERT INTO Pertenece VALUES(2, 1)
INSERT INTO Pertenece VALUES(21, 1)
INSERT INTO Pertenece VALUES(27, 1)
INSERT INTO Pertenece VALUES(7, 1)
INSERT INTO Pertenece VALUES(8, 1)
INSERT INTO Pertenece VALUES(14, 1)

-- Verano
INSERT INTO Pertenece VALUES(3, 2)
INSERT INTO Pertenece VALUES(24, 2)
INSERT INTO Pertenece VALUES(25, 2)
INSERT INTO Pertenece VALUES(4, 2)
INSERT INTO Pertenece VALUES(9, 2)
INSERT INTO Pertenece VALUES(10, 2)
INSERT INTO Pertenece VALUES(11, 2)
INSERT INTO Pertenece VALUES(15, 2)
INSERT INTO Pertenece VALUES(18, 2)

-- Otono
INSERT INTO Pertenece VALUES(18, 3)
INSERT INTO Pertenece VALUES(23, 3)
INSERT INTO Pertenece VALUES(26, 3)
INSERT INTO Pertenece VALUES(5, 3)
INSERT INTO Pertenece VALUES(13, 3)
INSERT INTO Pertenece VALUES(19, 3)
INSERT INTO Pertenece VALUES(21, 3)
INSERT INTO Pertenece VALUES(24, 3)
INSERT INTO Pertenece VALUES(28, 3)

--Invierno
INSERT INTO Pertenece VALUES(17, 4)
INSERT INTO Pertenece VALUES(19, 4)
INSERT INTO Pertenece VALUES(13, 4)
INSERT INTO Pertenece VALUES(16, 4)
INSERT INTO Pertenece VALUES(7, 4)