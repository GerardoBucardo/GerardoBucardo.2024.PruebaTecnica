CREATE DATABASE PracticaTecnicaDB
USE PracticaTecnicaDB
USE PracticaDB

CREATE TABLE Productos(
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	nombre VARCHAR(100),
	precio DECIMAL(10,2),
	IdCategoria INT
    CONSTRAINT FK_Categoria FOREIGN KEY (IdCategoria) REFERENCES Categorias(Id)
)

CREATE TABLE Categorias(
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	nombre VARCHAR(100)
)

INSERT INTO Productos(nombre, precio, IdCategoria) VALUES ('u',1.50,1);
INSERT INTO Categorias(nombre) VALUES ('n');

DROP DATABASE PracticaTecnicaDB

SELECT * FROM Productos
