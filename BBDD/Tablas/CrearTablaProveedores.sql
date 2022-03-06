use API_Cultura;
CREATE TABLE Proveedores(
Id INTEGER IDENTITY(1,1),
Nombre VARCHAR(100),
Poblacion VARCHAR(75),
Telefono VARCHAR(30),
CONSTRAINT Pk_Proveedores PRIMARY KEY (Id)
);