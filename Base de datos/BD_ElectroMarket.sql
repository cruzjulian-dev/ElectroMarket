--------------------- SE COMPRUEBA SI EXISTE LA BASE DE DATOS, EN CASO AFIRMATIVO SE LA ELIMINA --------------------
IF EXISTS (SELECT 1 FROM sys.databases WHERE name = 'DB_ElectroMarket')
BEGIN
    USE master;
    ALTER DATABASE DB_ElectroMarket SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE DB_ElectroMarket;
END
--------------------- FIN DE COMPROBACIÓN DE EXISTENCIA PREVIA DE LA BASE DE DATOS ------------------------------

GO

------------------------------------- COMIENZO DE CREACION DE BASE DE DATOS Y TABLAS  -------------------------------------
CREATE DATABASE DB_ElectroMarket

GO

USE DB_ElectroMarket

GO

CREATE TABLE ROLES(
IdRol int primary key identity NOT NULL,
Descripcion varchar(100) NOT NULL,
FechaRegistro datetime default getdate() NOT NULL
)


GO

CREATE TABLE USUARIOS(
IdUsuario int primary key identity NOT NULL,
Nombre varchar(100) NOT NULL,
Apellido varchar(100) NOT NULL,
Dni int NOT NULL,
UsuarioLogin varchar(100) NOT NULL,
Clave varchar(100) NOT NULL,
FechaNacimiento DATE NOT NULL,
Telefono varchar(40) NOT NULL,
Domicilio varchar(200) NOT NULL,
IdRol int references ROLES(IdRol) NOT NULL,
Estado bit NOT NULL,
FechaRegistro datetime default getdate() NOT NULL
)

GO

CREATE TABLE CLIENTES(
IdCliente int primary key identity NOT NULL,
Nombre varchar(100) NOT NULL,
Apellido varchar(100) NOT NULL,
Dni int NOT NULL,
FechaNacimiento DATE NOT NULL,
Telefono varchar(40) NOT NULL,
Domicilio varchar(200) NOT NULL,
Estado bit NOT NULL,
FechaRegistro datetime default getdate() NOT NULL
)

GO


CREATE TABLE CATEGORIAS(
IdCategoria int primary key identity NOT NULL,
Descripcion varchar(100),
Estado bit,
FechaRegistro datetime default getdate() NOT NULL
)


GO


CREATE TABLE PRODUCTOS(
IdProducto int primary key identity NOT NULL,
Codigo varchar(50),
Nombre varchar(50),
Descripcion varchar(100),
IdCategoria int references CATEGORIAS(IdCategoria),
Stock int NOT NULL default 0,
PrecioVenta decimal(10,2) default 0,
Estado bit,
FechaRegistro datetime default getdate() NOT NULL
)


GO

CREATE TABLE FORMA_PAGO(
IdFormaPago int primary key identity NOT NULL,
Descripcion varchar(200) NOT NULL,
FechaRegistro datetime default getdate() NOT NULL
);

GO


CREATE TABLE VENTAS(
IdVenta int primary key identity NOT NULL,
IdUsuario int references USUARIOS(IdUsuario),
IdFormaPago int references FORMA_PAGO(IdFormaPago),
DniCliente int NOT NULL,
NombreCliente varchar(100) NOT NULL,
ApellidoCliente varchar(100) NOT NULL,
MontoPago decimal(10,2) NOT NULL default 0,
MontoCambio decimal(10,2) NOT NULL default 0,
MontoTotal decimal(10,2) NOT NULL default 0,
FechaRegistro datetime default getdate() NOT NULL
)

GO

CREATE TABLE DETALLE_VENTA(
IdDetalleVenta int primary key identity NOT NULL,
IdVenta int references VENTAS(IdVenta),
IdProducto int references PRODUCTOS(IdProducto),
PrecioVenta decimal(10,2),
Cantidad int,
SubTotal decimal(10,2),
FechaRegistro datetime default getdate() NOT NULL
)

GO
------------------------------------- FIN DE CREACION DE BASE DE DATOS Y TABLAS -------------------------------------


------------------------------------- COMIENZO DE PROCEDIMIENTOS ALMACENADOS -------------------------------------
-- USUARIO --
CREATE PROC SP_REGISTRARUSUARIO(
	
	@Nombre varchar(100),
	@Apellido varchar(100),
	@Dni int,
	@UsuarioLogin varchar(100),
	@Clave varchar(100),
	@FechaNacimiento DATE,
	@Telefono varchar(40),
	@Domicilio varchar(200),
	@IdRol int,
	@Estado bit,
	@IdUsuarioResultado int output,
	@Mensaje varchar(500) output
)
as
begin
	set @IdUsuarioResultado = 0
	set @Mensaje = ''

	-- Verifica si el DNI ya está siendo utilizado por otro usuario
	if not exists(SELECT * FROM USUARIOS WHERE Dni = @Dni)
	begin
		-- Verifica si el UsuarioLogin ya está siendo utilizado por otro usuario
		if not exists(SELECT * FROM USUARIOS WHERE UsuarioLogin = @UsuarioLogin)
		begin
			INSERT INTO USUARIOS(Nombre, Apellido, Dni, UsuarioLogin, Clave, FechaNacimiento, Telefono, Domicilio, IdRol, Estado) 
			VALUES (@Nombre, @Apellido, @Dni, @UsuarioLogin, @Clave, @FechaNacimiento, @Telefono, @Domicilio, @IdRol, @Estado)

			set @IdUsuarioResultado = SCOPE_IDENTITY()
		end
		else
			set @Mensaje = 'El nombre de Usuario ya está en uso por otro usuario'
		end
	else
    set @Mensaje = 'El DNI ya está en uso por otro usuario.'
end

GO

CREATE PROC SP_EDITARUSUARIO(
	@IdUsuario int,
	@Nombre varchar(100),
	@Apellido varchar(100),
	@Dni int,
	@UsuarioLogin varchar(100),
	@Clave varchar(100),
	@FechaNacimiento DATE,
	@Telefono varchar(40),
	@Domicilio varchar(200),
	@IdRol int,
	@Estado bit,
	@Respuesta bit output,
	@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''


	-- Verifica si el nuevo DNI ya está siendo utilizado por otro usuario
    IF NOT EXISTS (SELECT * FROM USUARIOS WHERE Dni = @Dni AND IdUsuario != @IdUsuario)
    BEGIN
        -- Verifica si el nuevo UsuarioLogin ya está siendo utilizado por otro usuario
        IF NOT EXISTS (SELECT * FROM USUARIOS WHERE UsuarioLogin = @UsuarioLogin AND IdUsuario != @IdUsuario)
        BEGIN
            -- Realiza la actualización del usuario
            UPDATE USUARIOS SET
                Nombre = @Nombre,
                Apellido = @Apellido,
                Dni = @Dni,
                UsuarioLogin = @UsuarioLogin,
                Clave = @Clave,
                FechaNacimiento = @FechaNacimiento,
                Telefono = @Telefono,
                Domicilio = @Domicilio,
                IdRol = @IdRol,
                Estado = @Estado
            WHERE IdUsuario = @IdUsuario

            SET @Respuesta = 1
        END
        ELSE
        BEGIN
            SET @Mensaje = 'El nuevo nombre de Usuario ya está en uso por otro usuario.'
        END
    END
    ELSE
    BEGIN
        SET @Mensaje = 'El nuevo DNI ya está en uso por otro usuario.'
    END
END
-- FIN USUARIO -- 

GO

-- CLIENTE --
CREATE PROC SP_REGISTRARCLIENTE(
	@Nombre varchar(100),
	@Apellido varchar(100),
	@Dni int,
	@FechaNacimiento DATE,
	@Telefono varchar(40),
	@Domicilio varchar(200),
	@Estado bit,
	@IdClienteResultado int output,
	@Mensaje varchar(500) output
)
as
begin
	set @IdClienteResultado = 0
	set @Mensaje = ''

	-- Verifica si el DNI no está siendo utilizado por otro usuario
	if not exists(SELECT * FROM CLIENTES WHERE Dni = @Dni)
	begin
		INSERT INTO CLIENTES(Nombre, Apellido, Dni, FechaNacimiento, Telefono, Domicilio, Estado) 
		VALUES (@Nombre, @Apellido, @Dni, @FechaNacimiento, @Telefono, @Domicilio, @Estado)

		set @IdClienteResultado = SCOPE_IDENTITY()
	end
	else
	begin
		IF (SELECT Estado FROM CLIENTES WHERE Dni = @Dni) = 0
		begin
			set @Mensaje = 'El cliente está dado de baja, contacte al Administrador.'
		end
		else
		begin
			set @Mensaje = 'El DNI ya está en uso por otro cliente.'
		end
	end
end

GO

CREATE PROC SP_EDITARCLIENTE(
	@IdCliente int,
	@Nombre varchar(100),
	@Apellido varchar(100),
	@Dni int,
	@FechaNacimiento DATE,
	@Telefono varchar(40),
	@Domicilio varchar(200),
	@Estado bit,
	@Respuesta bit output,
	@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''


	-- Verifica si el DNI no está siendo utilizado por otro usuario
    if not exists(SELECT * FROM CLIENTES WHERE Dni = @Dni AND IdCliente != @IdCliente)
    BEGIN
		-- Realiza la actualización del cliente
            UPDATE CLIENTES SET
                Nombre = @Nombre,
                Apellido = @Apellido,
                Dni = @Dni,
                FechaNacimiento = @FechaNacimiento,
                Telefono = @Telefono,
                Domicilio = @Domicilio,
                Estado = @Estado
            WHERE IdCliente = @IdCliente

            SET @Respuesta = 1
    END
    ELSE
    BEGIN
        SET @Mensaje = 'El nuevo DNI ya está en uso por otro usuario.'
    END
END
-- FIN CLIENTE --

GO
------------------------------------- FIN DE PROCEDIMIENTOS ALMACENADOS -------------------------------------



------------------------------------- COMIENZO DE CREACION DE DATOS DE PRUEBA -------------------------------------

INSERT INTO ROLES (Descripcion) 
VALUES ('Vendedor')

GO

INSERT INTO ROLES (Descripcion) 
VALUES ('Administrador')

GO

INSERT INTO ROLES (Descripcion) 
VALUES ('Super Administrador')

GO

INSERT INTO FORMA_PAGO(Descripcion)
VALUES ('Efectivo')

GO

INSERT INTO FORMA_PAGO(Descripcion)
VALUES ('Tarjeta')

GO

INSERT INTO FORMA_PAGO(Descripcion)
VALUES ('Mercado Pago')


GO

-- USUARIOS --
INSERT INTO USUARIOS (Nombre, Apellido, Dni, UsuarioLogin, Clave, FechaNacimiento, Telefono, Domicilio, IdRol, Estado) 
VALUES ('Julian', 'Cruz', '40982522', 'cruz', '123', '1998-02-17', 3795012213, 'San Martin 2412', 3, 1)

GO

INSERT INTO USUARIOS (Nombre, Apellido, Dni, UsuarioLogin, Clave, FechaNacimiento, Telefono, Domicilio, IdRol, Estado) 
VALUES ('Fabricio', 'Blanco', '20952532', 'blanco', '123', '1992-04-24', 3453324645, 'Bolivar 1432', 2, 1)

GO

INSERT INTO USUARIOS (Nombre, Apellido, Dni, UsuarioLogin, Clave, FechaNacimiento, Telefono, Domicilio, IdRol, Estado) 
VALUES ('Yamila', 'Davalos', '43912552', 'davalos', '123', '1978-03-07', 3794042215, 'Sarmiento 412', 1, 0)

GO

INSERT INTO USUARIOS (Nombre,Apellido, Dni, UsuarioLogin, Clave, FechaNacimiento, Telefono, Domicilio, IdRol, Estado) 
VALUES ('Vendedor', 'ApeVendedor', '12345678', 'vendedor', '123', '1999-09-27', 364042215, 'Calle 412', 1, 1)

GO

INSERT INTO USUARIOS (Nombre, Apellido, Dni, UsuarioLogin, Clave, FechaNacimiento, Telefono, Domicilio, IdRol, Estado) 
VALUES ('Admin', 'ApeAdmin', '32345678', 'admin', '123', '2001-12-12', 335042215, 'Calle 512', 2, 1)

GO

INSERT INTO USUARIOS (Nombre, Apellido, Dni, UsuarioLogin, Clave, FechaNacimiento, Telefono, Domicilio, IdRol, Estado) 
VALUES ('Super', 'ApeSuper', '22345678', 'super', '123', '1994-01-13', 364012215, 'Calle 712', 3, 1)
-- FIN USUARIOS --

GO

-- CLIENTES--
INSERT INTO CLIENTES (Nombre, Apellido, Dni, FechaNacimiento, Telefono, Domicilio, Estado) 
VALUES ('Juan', 'Perez', '25082522', '11-06-1980', 3795012213, 'San Juan 1442', 1)

GO

INSERT INTO CLIENTES (Nombre, Apellido, Dni, FechaNacimiento, Telefono, Domicilio, Estado) 
VALUES ('Ramon', 'Flores', '16958532', '27-01-1971', 3453324645, 'Cabral 1738', 1)

GO

INSERT INTO CLIENTES (Nombre, Apellido, Dni, FechaNacimiento, Telefono, Domicilio, Estado) 
VALUES ('Luis', 'Barrios', '46958532', '24-09-2004', 3577324645, 'Catamarca 1118', 1)
-- FIN CLIENTES -- 

GO

------------------------------------- FIN DE CREACION DE DATOS DE PRUEBA -------------------------------------
