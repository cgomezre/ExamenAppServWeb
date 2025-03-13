USE Viviendas_ITM;
GO

CREATE TABLE Cliente (
    Id INT PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(20) NOT NULL,
    Email NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE TipoVivienda (
    Id INT PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE Agencia (
    Id INT PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE Vivienda (
    Id INT PRIMARY KEY,
    TipoViviendaId INT NOT NULL,
	AgenciaId INT NOT NULL,
    NumCuartos INT NOT NULL,
    NumBanos INT NOT NULL,
    Tamano DECIMAL(10,2) NOT NULL,
    NumPisos INT NOT NULL,
    Accesorios NVARCHAR(MAX) NOT NULL,
    FOREIGN KEY (TipoViviendaId) REFERENCES TipoVivienda(Id),
	FOREIGN KEY (AgenciaId) REFERENCES Agencia(Id)
);
GO

CREATE TABLE Venta (
    Id INT PRIMARY KEY,
    ClienteId INT NOT NULL,
    ViviendaId INT NOT NULL UNIQUE,
    FechaVenta DATETIME NOT NULL DEFAULT GETDATE(),
    Precio DECIMAL(18,5) NOT NULL,
    FOREIGN KEY (ClienteId) REFERENCES Cliente(Id),
    FOREIGN KEY (ViviendaId) REFERENCES Vivienda(Id)
);
GO
