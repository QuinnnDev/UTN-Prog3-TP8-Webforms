CREATE DATABASE BDSucursales
GO

USE BDSucursales
GO

CREATE TABLE Provincia (
    Id_Provincia INT PRIMARY KEY IDENTITY(1,1),
    DescripcionProvincia VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Sucursal (
    Id_Sucursal INT PRIMARY KEY IDENTITY(1,1),
    NombreSucursal VARCHAR(100) NOT NULL UNIQUE,
    DescripcionSucursal VARCHAR(255) NULL,
    IdHorarioSucursal INT NULL,
    Id_ProvinciaSucursal INT FOREIGN KEY REFERENCES Provincia(Id_Provincia) NOT NULL,
    DireccionSucursal VARCHAR(255) NULL,
    UrlImagen_Sucursal VARCHAR(255) NULL
);

USE BDSucursales
GO

CREATE PROCEDURE spAgregarSucursal
    @NombreSucursal VARCHAR(100),
    @DescripcionSucursal VARCHAR(100),
    @Id_HorarioSucursal INT,
    @Id_ProvinciaSucursal INT,
    @DireccionSucursal VARCHAR(100),
    @URL_Imagen_Sucursal VARCHAR(100)
AS
BEGIN
    INSERT INTO Sucursal (
        NombreSucursal,
        DescripcionSucursal,
        IdHorarioSucursal,
        Id_ProvinciaSucursal,
        DireccionSucursal,
        URLImagen_Sucursal
    )
    VALUES (
        @NombreSucursal,
        @DescripcionSucursal,
        @Id_HorarioSucursal,
        @Id_ProvinciaSucursal,
        @DireccionSucursal,
        @URL_Imagen_Sucursal
    )
END
GO

CREATE PROCEDURE spEliminarSucursal 
@IdSucursal int
AS
BEGIN
	DELETE FROM Sucursal WHERE Id_Sucursal = @IdSucursal
END
GO

INSERT INTO Provincia (DescripcionProvincia) VALUES
('Ciudad Autonoma de Buenos Aires'),
('Misiones'),
('Jujuy');
GO

INSERT INTO Sucursal (
    NombreSucursal,
    DescripcionSucursal,
    IdHorarioSucursal,
    Id_ProvinciaSucursal,
    DireccionSucursal,
    UrlImagen_Sucursal
)
VALUES
(
    'Sucursal Centro',
    'La sucursal más grande y antigua.',
    1,
    1,
    'Av. Corrientes 500',
    'imagen_centro.png'
),
(
    'Sucursal Posadas',
    'Especializada en logística.',
    1,
    2,
    'Ruta Nacional 12 Km 5',
    'imagen_posadas.png'
),
(
    'Sucursal Jujuy',
    'Foco en atención al cliente.',
    2,
    3,
    'Calle Lavalle 150',
    'imagen_jujuy.png'
);
GO