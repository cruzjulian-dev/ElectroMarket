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
Codigo varchar(50) UNIQUE,
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
TipoDocumento varchar(50) NOT NULL,
NumeroDocumento varchar(50) NOT NULL,
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
-- PROCEDIMIENTOS USUARIO --
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
-- FIN PROCEDIMIENTOS DE USUARIO -- 


GO

-- PROCEDIMIENTOS CLIENTE --
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
-- FIN PROCEDIMIENTOS CLIENTE --


GO


-- PROCEDIMIENTOS CATEGORIAS --
CREATE PROC SP_RegistrarCategoria (
@Descripcion varchar(100),
@Estado bit,
@Resultado int output,
@Mensaje varchar (500) output
)as
begin 
	SET @Resultado = 0
	set @Mensaje = ''
	IF NOT EXISTS (SELECT * FROM CATEGORIAS WHERE Descripcion = @Descripcion)
	begin 
		insert into CATEGORIAS(Descripcion, Estado)
		VALUES (@Descripcion, @Estado)
		SET @Resultado = SCOPE_IDENTITY()
	end
	ELSE
		begin
			set @Mensaje =  'No se puede repetir la descripcion para mas de una categoria.'
		end
end

go

CREATE PROC SP_EditarCategoria(
@IdCategoria int,
@Descripcion varchar(500),
@Estado bit,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
	SET @Respuesta = 0
	IF NOT EXISTS (SELECT * FROM CATEGORIAS WHERE Descripcion = @Descripcion AND IdCategoria != @IdCategoria)
	begin
		update CATEGORIAS SET
		Descripcion = @Descripcion,
		Estado = @Estado
		where IdCategoria = @IdCategoria
		set @Respuesta = 1
	end
	ELSE
	begin
		set @Mensaje =  'No se puede repetir la descripcion para mas de una categoria.'
	end
end
-- FIN PROCEDIMIENTOS CATEGORIA --

go

-- PROCEDIMIENTOS PRODUCTOS --
CREATE PROC SP_RegistrarProducto(
	@Codigo varchar(50),
	@Nombre varchar(50),
	@Descripcion varchar(100),
	@IdCategoria int,
	@Stock int,
	@PrecioVenta decimal(10,2),
	@Estado bit,
	@IdProductoResultado int output,
	@Mensaje varchar(500) output
)
as
begin
	set @IdProductoResultado = 0
	set @Mensaje = ''

	-- Verifica si el Codigo de producto no está siendo utilizado por otro producto
	if not exists(SELECT * FROM PRODUCTOS WHERE Codigo = @Codigo)
	begin
		INSERT INTO PRODUCTOS(Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioVenta, Estado) 
		VALUES (@Codigo, @Nombre, @Descripcion, @IdCategoria, @Stock, @PrecioVenta, @Estado)

		set @IdProductoResultado = SCOPE_IDENTITY()
	end
	else
	begin
		set @Mensaje = 'El Codigo ya está siendo usado por otro producto.'
	end
end

GO

CREATE PROC SP_EditarProducto(
	@IdProducto int,
	@Codigo varchar(50),
	@Nombre varchar(50),
	@Descripcion varchar(100),
	@IdCategoria int,
	@Stock int,
	@PrecioVenta decimal(10,2),
	@Estado bit,
	@Respuesta bit output,
	@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 1
	set @Mensaje = ''


	-- Verifica si el Codigo no está siendo utilizado por otro producto
    if not exists(SELECT * FROM PRODUCTOS WHERE Codigo = @Codigo AND IdProducto != @IdProducto)
    BEGIN
		-- Realiza la actualización del Producto
            UPDATE PRODUCTOS SET
                Codigo = @Codigo,
                Nombre = @Nombre,
                Descripcion = @Descripcion,
                IdCategoria = @IdCategoria,
                Stock = @Stock,
				PrecioVenta = @PrecioVenta,
                Estado = @Estado
            WHERE IdProducto = @IdProducto

    END
    ELSE
    BEGIN
        SET @Respuesta = 0
        SET @Mensaje = 'No se puede repetir el Codigo que está siendo utilizado por otro producto.'
    END
END


-- PROCEDIMIENTOS VENTA -- 

GO

CREATE TYPE [dbo].[eDetalle_Venta] AS TABLE(
	[IdProducto] int NULL,
	[PrecioVenta] decimal(10,2)NULL,
	[Cantidad] int NULL,
	[SubTotal] decimal(10,2) NULL
)

GO

CREATE PROCEDURE SP_RegistrarVenta(
	@IdUsuario int,
	@DniCliente int,
	@IdFormaPago int,
	@NombreCliente varchar(100),
	@ApellidoCliente varchar(100),
	@TipoDocumento varchar(50),
	@NumeroDocumento varchar(50),
	@MontoTotal decimal(10,2),
	@DetalleVenta [eDetalle_Venta] READONLY,
	@Resultado bit output,
	@Mensaje varchar(500) output
)
as
	begin
		
		begin try
		
			DECLARE @IdVenta int = 0
			SET @RESULTADO = 1
			SET @Mensaje = ''
			
			begin transaction registro
			
				INSERT INTO VENTAS(IdUsuario, DniCliente, IdFormaPago, NombreCliente, ApellidoCliente, TipoDocumento, NumeroDocumento, MontoTotal)
				VALUES (@IdUsuario, @DniCliente, @IdFormaPago, @NombreCliente, @ApellidoCliente, @TipoDocumento, @NumeroDocumento, @MontoTotal)
			
				SET @IdVenta = SCOPE_IDENTITY()
				
				INSERT INTO DETALLE_VENTA(IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal)
				SELECT @IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal FROM @DetalleVenta
			
			commit transaction
		
		end try
		begin catch
			
			SET @Resultado = 0
			SET @Mensaje = ERROR_MESSAGE()
			ROLLBACK TRANSACTION registro
		
		end catch

	end

-- FIN PROCEDIMIENTOS PRODUCTOS--
------------------------------------- FIN DE PROCEDIMIENTOS ALMACENADOS -------------------------------------

go

------------------------------------- COMIENZO DE CREACION DE DATOS DE PRUEBA -------------------------------------

-- ROLES
INSERT INTO ROLES (Descripcion) 
VALUES ('Vendedor')

INSERT INTO ROLES (Descripcion) 
VALUES ('Administrador')

INSERT INTO ROLES (Descripcion) 
VALUES ('Super Administrador')
-- FIN ROLES

GO

-- FORMAS DE PAGO
INSERT INTO FORMA_PAGO(Descripcion)
VALUES ('Efectivo')

INSERT INTO FORMA_PAGO(Descripcion)
VALUES ('Tarjeta')

INSERT INTO FORMA_PAGO(Descripcion)
VALUES ('Mercado Pago')
-- FIN FORMAS DE PAGO

GO

-- USUARIOS --
INSERT INTO USUARIOS (Nombre, Apellido, Dni, UsuarioLogin, Clave, FechaNacimiento, Telefono, Domicilio, IdRol, Estado) 
VALUES ('Julian', 'Cruz', '40982522', 'cruz', '$2a$11$PA3vjlB6WGz7Hvhsp3tmAuTENbwGurweMK7V6shthC1qFIpWr7MxC', '1998-02-17', 3795012213, 'San Martin 2412', 3, 1)

INSERT INTO USUARIOS (Nombre, Apellido, Dni, UsuarioLogin, Clave, FechaNacimiento, Telefono, Domicilio, IdRol, Estado) 
VALUES ('Fabricio', 'Blanco', '20952532', 'blanco', '$2a$11$Vdgjzj16SUbKI7OMfcz4k.gdj.OkYZ5ZLNeVbnoMCf5jZvMOztolS', '1992-04-24', 3453324645, 'Bolivar 1432', 2, 1)

INSERT INTO USUARIOS (Nombre, Apellido, Dni, UsuarioLogin, Clave, FechaNacimiento, Telefono, Domicilio, IdRol, Estado) 
VALUES ('Yamila', 'Davalos', '33912552', 'davalos', '$2a$11$f4dtagZTEwwK.xcEnmZ7Su14nB6bVkwu3Nz7Ys6lq4I1rmGm4UgIi', '1978-03-07', 3794042215, 'Sarmiento 412', 1, 1)

INSERT INTO USUARIOS (Nombre,Apellido, Dni, UsuarioLogin, Clave, FechaNacimiento, Telefono, Domicilio, IdRol, Estado) 
VALUES ('Vendedor', 'ApeVendedor', '12345678', 'vendedor', '$2a$11$HJml9V4Oyxw0/ucfgA2DCO9an1XpJPSHk2rEaxwRXKTQ/RDIBM10S', '1999-09-27', 364042215, 'Calle 412', 1, 1)

INSERT INTO USUARIOS (Nombre, Apellido, Dni, UsuarioLogin, Clave, FechaNacimiento, Telefono, Domicilio, IdRol, Estado) 
VALUES ('Fernando', 'Gutierrez', '32912552', 'fernando', '$2a$11$3DUH8Nnpf97ICNN8a3voCO7iFzwWYDdL8tBdy0dYpDGcDxuEz.7N6', '1976-04-08', 3794052615, 'Brasil 772', 1, 0)

INSERT INTO USUARIOS (Nombre, Apellido, Dni, UsuarioLogin, Clave, FechaNacimiento, Telefono, Domicilio, IdRol, Estado) 
VALUES ('Admin', 'ApeAdmin', '32345678', 'admin', '$2a$11$5TXtcRVArqeZvZaLG1yy6u02j/ocEzH4lZVIOMyDPtoFrdCcjGUKa', '2001-12-12', 335042215, 'Calle 512', 2, 1)

INSERT INTO USUARIOS (Nombre, Apellido, Dni, UsuarioLogin, Clave, FechaNacimiento, Telefono, Domicilio, IdRol, Estado) 
VALUES ('Super', 'ApeSuper', '22345678', 'super', '$2a$11$3rLF1dD4QaYqhzJTBqYhy.61tRibB76jsCtvIUxq3EqYInVD9ZW8u', '1994-01-13', 364012215, 'Calle 712', 3, 1)
-- FIN USUARIOS --

GO

-- CLIENTES--
INSERT INTO CLIENTES (Nombre, Apellido, Dni, FechaNacimiento, Telefono, Domicilio, Estado) 
VALUES ('Juan', 'Perez', '25082522', '1980-06-19', 3795012213, 'San Juan 1442', 1)

INSERT INTO CLIENTES (Nombre, Apellido, Dni, FechaNacimiento, Telefono, Domicilio, Estado) 
VALUES ('Ramon', 'Flores', '16958532', '1971-08-11', 3453324645, 'Cabral 1738', 1)

INSERT INTO CLIENTES (Nombre, Apellido, Dni, FechaNacimiento, Telefono, Domicilio, Estado) 
VALUES ('Luis', 'Barrios', '46958532', '2004-09-24', 3572324645, 'Catamarca 1118', 1)

INSERT INTO CLIENTES (Nombre, Apellido, Dni, FechaNacimiento, Telefono, Domicilio, Estado) 
VALUES ('Ivan', 'Lescano', '26958532', '1978-04-27', 3557364615, 'Guemes 2112', 1)

INSERT INTO CLIENTES (Nombre, Apellido, Dni, FechaNacimiento, Telefono, Domicilio, Estado) 
VALUES ('Monica', 'Ayala', '36958532', '1989-01-17', 3597724245, 'Bolivar 3121', 1)
-- FIN CLIENTES -- 

GO

-- CATEGORIAS
insert into CATEGORIAS(Descripcion,Estado)
values ('Televisores',1)

insert into CATEGORIAS(Descripcion,Estado)
values ('Heladeras',1)

insert into CATEGORIAS(Descripcion,Estado)
values ('Lavarropas',1)

insert into CATEGORIAS(Descripcion,Estado)
values ('Hornos',1)
-- FIN CATEGORIAS


GO

-- PRODUCTOS
insert into PRODUCTOS(Codigo,Nombre,Descripcion,IdCategoria,Stock,PrecioVenta,Estado)
values ('ATMA1500','Horno Electrico Grill Atma','1500w - 40L - 250° - Plateado', 4, 48, 79999.99, 1)

insert into PRODUCTOS(Codigo,Nombre,Descripcion,IdCategoria,Stock,PrecioVenta,Estado)
values ('SM65LINV','Lavarropas Samsung Automatico','Carga Frontal - 6.5 Kg - Inverter - 1000 RPM', 3, 22, 559999.99, 1)

insert into PRODUCTOS(Codigo,Nombre,Descripcion,IdCategoria,Stock,PrecioVenta,Estado)
values ('HGFA282L', 'Heladera Gafa', '282L - Freezer - 220V', 2, 17, 279999.99, 1)

insert into PRODUCTOS(Codigo,Nombre,Descripcion,IdCategoria,Stock,PrecioVenta,Estado)
values ('HPHI282L', 'Heladera Philips', '323L - Freezer - 2 Puertas', 2, 4, 580500, 0)

insert into PRODUCTOS(Codigo,Nombre,Descripcion,IdCategoria,Stock,PrecioVenta,Estado)
values ('NBLX55LD','Smart Tv Noblex','LED - HD - 32" - Android Tv', 1, 65, 125000, 1)

insert into PRODUCTOS(Codigo,Nombre,Descripcion,IdCategoria,Stock,PrecioVenta,Estado)
values ('NBLX5EED','Smart Tv Samsung','LED - 4k - 52" - Android Tv', 1, 65, 145000, 1)

insert into PRODUCTOS(Codigo,Nombre,Descripcion,IdCategoria,Stock,PrecioVenta,Estado)
values ('HTCH40LD','Smart TV Hitachi','LED - FULL HD - 40" - Android Tv', 1, 37, 174999.99, 1)
-- FIN PRODUCTOS

GO

-- VENTA 1 + DETALLE DE VENTA      
INSERT INTO VENTAS (IdUsuario, IdFormaPago, DniCliente, NombreCliente, ApellidoCliente, TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro)
VALUES (3, 1, 25082522, 'Juan', 'Perez', 'Factura', '00001', 999999.96, '11-11-2023')

INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal, FechaRegistro)
VALUES (1, 2, 559999.99, 1, 559999.99, '11-11-2023')

INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal, FechaRegistro)
VALUES (1, 3, 279999.99, 1, 279999.99, '11-11-2023')

INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal, FechaRegistro)
VALUES (1, 1, 79999.99, 2, 159999.98, '11-11-2023')
-- FIN VENTAS 1 + DETALLE DE VENTA   


-- VENTA 2 + DETALLE DE VENTA      
INSERT INTO VENTAS (IdUsuario, IdFormaPago, DniCliente, NombreCliente, ApellidoCliente, TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro)
VALUES (3, 3, 16958532, 'Ramon', 'Flores', 'Factura', '00002', 1536000, '2023-11-11')

INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal, FechaRegistro)
VALUES (2, 4, 580500.00, 2, 1161000.00, '2023-11-11')

INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal, FechaRegistro)
VALUES (2, 5, 125000, 3, 375000, '2023-11-11')

-- FIN VENTAS 2 + DETALLE DE VENTA   


-- VENTA 3 + DETALLE DE VENTA      
INSERT INTO VENTAS (IdUsuario, IdFormaPago, DniCliente, NombreCliente, ApellidoCliente, TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro)
VALUES (3, 3, 46958532, 'Luis', 'Barrios', 'Factura', '00003', 290000.00, '2023-11-12')

INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal, FechaRegistro)
VALUES (3, 6, 145000.00, 2, 290000.00, '2023-11-12')
-- FIN VENTAS 3 + DETALLE DE VENTA   


-- VENTA 4 + DETALLE DE VENTA      
INSERT INTO VENTAS (IdUsuario, IdFormaPago, DniCliente, NombreCliente, ApellidoCliente, TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro)
VALUES (4, 3, 26958532, 'Ivan', 'Lescano', 'Factura', '00004', 1164999.95, '2023-11-12')

INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal, FechaRegistro)
VALUES (4, 7, 174999.99, 5, 874999.95, '2023-11-12')

INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal, FechaRegistro)
VALUES (4, 6, 145000.00, 2, 290000.00, '2023-11-12')

-- FIN VENTAS 4 + DETALLE DE VENTA   


-- VENTA 5 + DETALLE DE VENTA      
INSERT INTO VENTAS (IdUsuario, IdFormaPago, DniCliente, NombreCliente, ApellidoCliente, TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro)
VALUES (4, 1, 36958532, 'Monica', 'Ayala', 'Factura', '00005', 559999.99, '2023-11-10')

INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal, FechaRegistro)
VALUES (5, 2, 559999.99, 1, 559999.99, '2023-11-10')

-- FIN VENTAS 5 + DETALLE DE VENTA   


-- VENTA 6 + DETALLE DE VENTA      
INSERT INTO VENTAS (IdUsuario, IdFormaPago, DniCliente, NombreCliente, ApellidoCliente, TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro)
VALUES (5, 3, 36958532, 'Monica', 'Ayala', 'Factura', '00006', 1265500.00, '2023-11-12')

INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal, FechaRegistro)
VALUES (6, 4, 580500.00, 1, 580500.00, '2023-11-12')

INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal, FechaRegistro)
VALUES (6, 5, 125000.00, 2, 250000, '2023-11-12')

INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal, FechaRegistro)
VALUES (6, 6, 145000.00, 3, 435000.00, '2023-11-12')
-- FIN VENTAS 6 + DETALLE DE VENTA   


-- VENTA 7 + DETALLE DE VENTA      
INSERT INTO VENTAS (IdUsuario, IdFormaPago, DniCliente, NombreCliente, ApellidoCliente, TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro)
VALUES (5, 1, 36958532, 'Monica', 'Ayala', 'Factura', '00007', 519999.96, '2023-11-10')

INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal, FechaRegistro)
VALUES (7, 1, 79999.99, 3, 239999.97, '2023-11-10')

INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal, FechaRegistro)
VALUES (7, 3, 279999.99, 1, 279999.99, '2023-11-10')
-- FIN VENTAS 7 + DETALLE DE VENTA   


-- VENTA 8 + DETALLE DE VENTA      
INSERT INTO VENTAS (IdUsuario, IdFormaPago, DniCliente, NombreCliente, ApellidoCliente, TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro)
VALUES (3, 2, 16958532, 'Ramon', 'Flores', 'Factura', '00008', 524999.97, '2023-11-12')

INSERT INTO DETALLE_VENTA (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal, FechaRegistro)
VALUES (8, 7, 174999.99, 3, 524999.97, '2023-11-12')
-- FIN VENTAS 8 + DETALLE DE VENTA   

------------------------------------- FIN DE CREACION DE DATOS DE PRUEBA -------------------------------------
