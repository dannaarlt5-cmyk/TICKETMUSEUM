-----------------------------------------------------
-- CREAR BASE DE DATOS SI NO EXISTE
-----------------------------------------------------
IF DB_ID('BDMUSEO') IS NULL
    CREATE DATABASE BDMUSEO;
GO

USE BDMUSEO;
GO

-----------------------------------------------------
-- TABLA VISITANTES
-----------------------------------------------------
CREATE TABLE dbo.TB_VISITANTES(
    Id_visita INT IDENTITY(1,1) PRIMARY KEY,
    Nom_visita NVARCHAR(100) NOT NULL,
    Cant_bol INT NOT NULL,
    hora_ent DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-----------------------------------------------------
-- TABLA VENTAS
-----------------------------------------------------
CREATE TABLE dbo.TB_VENTAS(
    Id_venta INT IDENTITY(1,1) PRIMARY KEY,
    Monto_total DECIMAL(10,2) NOT NULL,
    Metodo_pago NVARCHAR(50) NOT NULL,
    Fecha_venta DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-----------------------------------------------------
-- DATOS INICIALES (OPCIONAL)
-----------------------------------------------------
-- INSERT INTO TB_VISITANTES
-- (Nom_visita, Cant_bol)
-- VALUES ('Visitante General', 1);

GO