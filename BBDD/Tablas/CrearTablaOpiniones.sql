use API_Cultura;
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