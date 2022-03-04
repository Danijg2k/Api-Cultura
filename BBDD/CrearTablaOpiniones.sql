use API_Cultura;
CREATE TABLE Opiniones(
Id INTEGER IDENTITY(1,1),
Nombre VARCHAR(100),
Apellidos VARCHAR(75),
Email VARCHAR(200),
Telefono INTEGER,
Calificacion INTEGER,
Comentario VARCHAR
CONSTRAINT pk_Opiniones PRIMARY KEY (Id),
);