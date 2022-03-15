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

--Insertar datos Tabla Provee

INSERT INTO Provee VALUES(1, 1 , 0.75)
INSERT INTO Provee VALUES(1, 2 , 0.90)

INSERT INTO Provee VALUES(2, 3 , 0.75)
INSERT INTO Provee VALUES(2, 4 , 0.80)

INSERT INTO Provee VALUES(3, 5 , 0.50)
INSERT INTO Provee VALUES(3, 6 , 0.50)

INSERT INTO Provee VALUES(4, 7, 0.20)
INSERT INTO Provee VALUES(4, 8, 0.25)

--Insertar datos Tabla Temporadas

INSERT INTO Temporadas VALUES('Primavera','/assets/Temporadas/primavera.jpg','Marzo/Abril/Mayo/Junio')
INSERT INTO Temporadas VALUES('Verano','/assets/Temporadas/verano.jpg','Junio/Julio/Agosto/Septiembre')
INSERT INTO Temporadas VALUES('Otoño','/assets/Temporadas/otono.jpg','Septiembre/Octubre/Noviembre/Diciembre')
INSERT INTO Temporadas VALUES('Invierno','/assets/Temporadas/invierno.jpeg','Diciembre/Enero/Febrero/Marzo')

--Insertar datos Tabla Pertenece

INSERT INTO Pertenece VALUES(16, 1)
INSERT INTO Pertenece VALUES(2, 1)
INSERT INTO Pertenece VALUES(21, 1)
INSERT INTO Pertenece VALUES(27, 1)

INSERT INTO Pertenece VALUES(7, 2)
INSERT INTO Pertenece VALUES(3, 2)
INSERT INTO Pertenece VALUES(24, 2)
INSERT INTO Pertenece VALUES(25, 2)

INSERT INTO Pertenece VALUES(10, 3)
INSERT INTO Pertenece VALUES(18, 3)
INSERT INTO Pertenece VALUES(23, 3)
INSERT INTO Pertenece VALUES(26, 3)


INSERT INTO Pertenece VALUES(17, 4)
INSERT INTO Pertenece VALUES(19, 4)
INSERT INTO Pertenece VALUES(13, 4)
INSERT INTO Pertenece VALUES(28, 4)