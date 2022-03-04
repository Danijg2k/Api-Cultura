use API_Cultura;
CREATE TABLE Pertenece(
Id INTEGER IDENTITY(1,1),
IdProducto int,
IdTemporada int,
CONSTRAINT pk_Pertenece PRIMARY KEY (Id,IdProducto,IdTemporada),
CONSTRAINT fk_Productos_Pertenece FOREIGN KEY (IdProducto) REFERENCES Productos(Id),
CONSTRAINT fk_Temporadas_Pertenece FOREIGN KEY (IdTemporada) REFERENCES Temporadas(Id)
);