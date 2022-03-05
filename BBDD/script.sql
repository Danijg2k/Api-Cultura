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

INSERT INTO Productos VALUES('Huevos','/assets/')
INSERT INTO Productos VALUES('Lechuga','/assets/')
INSERT INTO Productos VALUES('Tomate','/assets/')
INSERT INTO Productos VALUES('Patata','/assets/')
INSERT INTO Productos VALUES('Manzana','/assets/')
INSERT INTO Productos VALUES('Miel','/assets/')
INSERT INTO Productos VALUES('Zanahoria','/assets/')
INSERT INTO Productos VALUES('Guisante','/assets/')
INSERT INTO Productos VALUES('Ajo','/assets/')
INSERT INTO Productos VALUES('Pimientio','/assets/')
INSERT INTO Productos VALUES('Calabacín','/assets/')
INSERT INTO Productos VALUES('Seta','/assets/')
INSERT INTO Productos VALUES('Naranja','/assets/')
INSERT INTO Productos VALUES('Alcachofa','/assets/')
INSERT INTO Productos VALUES('Pepino','/assets/')
INSERT INTO Productos VALUES('Coliflor','/assets/')
INSERT INTO Productos VALUES('Brócoli','/assets/')
INSERT INTO Productos VALUES('Berenjena','/assets/')
INSERT INTO Productos VALUES('Acelga','/assets/')
INSERT INTO Productos VALUES('Aceituna','/assets/')
INSERT INTO Productos VALUES('Pera','/assets/')
INSERT INTO Productos VALUES('Repollo','/assets/')
INSERT INTO Productos VALUES('Granada','/assets/')
INSERT INTO Productos VALUES('Melocotón','/assets/')
INSERT INTO Productos VALUES('Sandía','/assets/')
INSERT INTO Productos VALUES('Uva','/assets/')
INSERT INTO Productos VALUES('Ciruela','/assets/')
INSERT INTO Productos VALUES('Limón','/assets/')

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

INSERT INTO Temporadas VALUES('Primavera','/assets/','Marzo/Abril/Mayo/Junio')
INSERT INTO Temporadas VALUES('Verano','/assets/','Junio/Julio/Agosto/Septiembre')
INSERT INTO Temporadas VALUES('Otoño','/assets/','Septiembre/Obtubre/Noviembre/Diciembre')
INSERT INTO Temporadas VALUES('Invierno','/assets/','Diciembre/Enero/Febrero/Marzo')

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