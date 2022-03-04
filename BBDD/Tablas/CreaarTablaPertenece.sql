use API_Cultura;
CREATE TABLE Pertenece(
Id INTEGER IDENTITY(1,1),
IdProducto INTEGER,
IdTemporada INTEGER,
CONSTRAINT Pk_Pertenece PRIMARY KEY (Id,IdProducto,IdTemporada),
CONSTRAINT Fk_Productos_Pertenece FOREIGN KEY (IdProducto) REFERENCES Productos(Id),
CONSTRAINT Fk_Temporadas_Pertenece FOREIGN KEY (IdTemporada) REFERENCES Temporadas(Id)
);