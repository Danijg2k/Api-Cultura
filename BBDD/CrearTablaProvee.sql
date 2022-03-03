use API_Cultura;
CREATE TABLE Provee(
Id INTEGER IDENTITY(1,1),
IdProducto INTEGER,
IdProveedor INTEGER,
Precio DECIMAL(10,2),
CONSTRAINT Pk_Provee PRIMARY KEY (Id,IdProducto,IdProveedor),
CONSTRAINT Fk_Productos_Provee FOREIGN KEY (IdProducto) REFERENCES Productos(Id),
CONSTRAINT Fk_Proveedores_Provee FOREIGN KEY (IdProveedor) REFERENCES Proveedores(Id)
);