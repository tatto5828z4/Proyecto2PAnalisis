-- DROP DATABASE hotelSanCarlos;
CREATE DATABASE hotelSanCarlos;
USE hotelSanCarlos;

-- ------------------------------------------------------------------------------------------------------------
-- 												COMPONENTE SEGURIDAD
-- ------------------------------------------------------------------------------------------------------------
CREATE TABLE Empleado(
	pkIdEmpleado varchar(15) PRIMARY KEY,
	nombre varchar(25) NOT NULL,
	apellido varchar(25) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE Usuario(
pkId VARCHAR(15) PRIMARY KEY,
fkIdEmpleado varchar(15) NOT NULL, 
nombre VARCHAR(30) NOT NULL,
contraseña VARCHAR(100) NOT NULL,
estado VARCHAR(1) NOT NULL,
intento INT NULL,

FOREIGN KEY (fkIdEmpleado) REFERENCES  Empleado(pkIdEmpleado)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE Modulo(
pkId VARCHAR(15) PRIMARY KEY,
nombre VARCHAR(30) NOT NULL,
descripcion VARCHAR(200) NOT NULL,
estado VARCHAR(1) NOT NULL
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE Aplicacion(
pkId VARCHAR(15) PRIMARY KEY,
fkIdModulo VARCHAR(15) NOT NULL,
nombre VARCHAR(45) NULL,
estado INT NOT NULL,
rutaChm varchar(80) not null,
rutaHtml varchar(80) not null,
FOREIGN KEY (fkIdModulo) REFERENCES Modulo(pkId)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

-- INSERT INTO aplicacion VALUES ("1","1","Prueba", "1", "1", "");
/*
INSERT INTO aplicacion VALUES ("2","Registro de Usuario",1,"");
INSERT INTO aplicacion VALUES ("3","Asignación de Perfiles a Usuario",1,"");
INSERT INTO aplicacion VALUES ("4","Permisos Usuario Aplicación",1,"");
*/
create table reporte (
	idReporte int NOT NULL primary key,
	nombre varchar(20) NOT NULL,
	ruta varchar(100) NOT NULL,
    idAplicacion VARCHAR(15) not null,
	estado char(1) NOT NULL,
    foreign key (idAplicacion) references aplicacion(pkId)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE BitacoraUsuario(
	pkId INT AUTO_INCREMENT PRIMARY KEY,
	`host` VARCHAR(45) NULL DEFAULT NULL,
	ip VARCHAR(20) NULL,
	conexionFecha DATE NULL,
	conexionHora TIME NULL,
	fkIdUsuario VARCHAR(15) NOT NULL,
	fkIdAplicacion VARCHAR(15) NOT NULL,
	accion VARCHAR(200) NOT NULL,

	FOREIGN KEY (fkIdUsuario) REFERENCES Usuario (pkId),
	FOREIGN KEY (fkIdAplicacion) REFERENCES Aplicacion(pkID)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE Perfil(
	pkId VARCHAR(15) PRIMARY KEY,
	nombre VARCHAR(45) NULL,
	estado VARCHAR(45) NULL
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE UsuarioPerfil(
	fkIdUsuario VARCHAR(15) NOT NULL,
	fkIdPerfil VARCHAR(15) NOT NULL,

	FOREIGN KEY (fkIdPerfil) REFERENCES Perfil (pkId),
	FOREIGN KEY (fkIdUsuario) REFERENCES Usuario (pkId)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE UsuarioAplicacion(
	fkIdUsuario VARCHAR(15) NOT NULL,
	fkIdAplicacion VARCHAR(15) NOT NULL,
	permisoEscritura int,
	permisoLectura int,
	permisoModificar int,
	permisoEliminar int,
	permisoImprimir int,

	FOREIGN KEY (fkIdAplicacion) REFERENCES Aplicacion (pkId),
	FOREIGN KEY (fkIdUsuario) REFERENCES Usuario (pkId)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

#insert into usuarioaplicacion VALUES (1,1,null,null,null,null,null);      

CREATE TABLE IF NOT EXISTS AplicacionPerfil (
	fkIdPerfil VARCHAR(15) NOT NULL,
	fkIdAplicacion VARCHAR(15) NOT NULL,
	permisoEscritura int,
	permisoLectura int,
	permisoModificar int,
	permisoEliminar int,
	permisoImprimir int,

	FOREIGN KEY (fkIdAplicacion) REFERENCES Aplicacion (pkId),
	FOREIGN KEY (fkIdPerfil) REFERENCES Perfil (pkId)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE UsuarioAplicacionAsignados(
	fkIdUsuario VARCHAR(15) NOT NULL,
	fkIdAplicacion VARCHAR(15) NOT NULL,

	FOREIGN KEY (fkIdAplicacion) REFERENCES Aplicacion (pkId),
	FOREIGN KEY (fkIdUsuario) REFERENCES Usuario (pkId)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

/*insert into aplicacionperfil VALUES (1,1,null,null,null,null,null);
insert into aplicacionperfil VALUES (2,1,1,1,1,1,1);
insert into aplicacionperfil VALUES (1,2,1,1,1,1,1);*/

-- INSERT SEGURIDAD
INSERT INTO empleado VALUES ("1","María","Hernandez");
INSERT INTO usuario(pkId,fkIdEmpleado, nombre, contraseña,estado,intento) VALUES ("1", "1", "admin","LKAekHU9EtweB49HAaTRfg==","1","0");
#usuario: admin
#contraseña: 12345
INSERT INTO modulo VALUES ("1", "Seguridad", "Modulo de seguridad", 1);
INSERT INTO perfil VALUES("1","Administrador","1");
INSERT INTO perfil VALUES("2","Vendedor","1");

-- VISTAS SEGURIDAD
CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`localhost` 
    SQL SECURITY DEFINER
VIEW `hotelSanCarlos`.`vwpermisosperfil` AS
    SELECT 
        `a`.`permisoEscritura` AS `permisoEscritura`,
        `a`.`permisoLectura` AS `permisoLectura`,
        `a`.`permisoModificar` AS `permisoModificar`,
        `a`.`permisoEliminar` AS `permisoEliminar`,
        `a`.`permisoImprimir` AS `permisoImprimir`,
        `b`.`pkId` AS `pkIdPerfil`,
        `b`.`nombre` AS `Perfil`,
        `c`.`pkId` AS `pkIdAplicacion`,
        `c`.`nombre` AS `Aplicacion`
    FROM
        ((`hotelSanCarlos`.`aplicacionperfil` `a`
        JOIN `hotelSanCarlos`.`perfil` `b` ON ((`b`.`pkId` = `a`.`fkIdPerfil`)))
        JOIN `hotelSanCarlos`.`aplicacion` `c` ON ((`c`.`pkId` = `a`.`fkIdAplicacion`)))
    ORDER BY `a`.`fkIdPerfil`;

-- select * from vwpermisosperfil;

CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`localhost` 
    SQL SECURITY DEFINER
VIEW `hotelSanCarlos`.`vwpermisosusuario` AS
    SELECT 
        `a`.`permisoEscritura` AS `permisoEscritura`,
        `a`.`permisoLectura` AS `permisoLectura`,
        `a`.`permisoModificar` AS `permisoModificar`,
        `a`.`permisoEliminar` AS `permisoEliminar`,
        `a`.`permisoImprimir` AS `permisoImprimir`,
        `b`.`pkId` AS `pkIdUsuario`,
        `b`.`nombre` AS `Usuario`,
        `c`.`pkId` AS `pkIdAplicacion`,
        `c`.`nombre` AS `Aplicacion`
    FROM
        ((`hotelSanCarlos`.`usuarioaplicacion` `a`
        JOIN `hotelSanCarlos`.`usuario` `b` ON ((`b`.`pkId` = `a`.`fkIdUsuario`)))
        JOIN `hotelSanCarlos`.`aplicacion` `c` ON ((`c`.`pkId` = `a`.`fkIdAplicacion`)))
    ORDER BY `a`.`fkIdUsuario`;
    
-- select * from vwpermisosusuario;
    
    
-- ------------------------------------------------------------------------------------------------------------
-- 											COMPONENTE NAVEGADOR (PRUEBAS)
-- ------------------------------------------------------------------------------------------------------------
create table marcaP(
	idMarca varchar(10) not null primary key,
    nombre varchar(35) not null,
    estatus char(1) not null
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE producto(
	idProducto varchar(20) not null primary key,
	idMarca varchar(10) not null,
	nombre varchar(45) not null,
	fecha date not null,
	descripcion varchar(100) not null,
	stock int not null,
	precio float not null,
	estado char(1) not null,
  
	foreign key (idMarca) references marcaP(idMarca)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;


-- INSERT NAVEGADOR

INSERT INTO `hotelsancarlos`.`marcaP` (`idMarca`, `nombre`, `estatus`) VALUES ('1', 'Nike', 'A');
INSERT INTO `hotelsancarlos`.`marcaP` (`idMarca`, `nombre`, `estatus`) VALUES ('2', 'Adidas', 'A');

INSERT INTO `hotelsancarlos`.`aplicacion` (`pkId`, `fkIdModulo`, `nombre`, `estado`, `rutaChm`, `rutaHtml`) VALUES ('1', '1', 'Prueba', '1', 'Ayudas/AyudasSistemaReparto.chm', 'ManualSistemaReparto.html');
INSERT INTO `hotelsancarlos`.`reporte` (`idReporte`, `nombre`, `ruta`, `idAplicacion`, `estado`) VALUES ('1', 'Reporte de Pruebas', 'Reportes/productos.rpt', '1', 'A');

INSERT INTO `hotelsancarlos`.`producto` (`idProducto`, `idMarca`, `nombre`, `fecha`, `descripcion`, `stock`, `precio`, `estado`) VALUES ('1', '1', 'Producto1', '2021/09/22', 'Descripcion', '10', '15', 'A');
INSERT INTO `hotelsancarlos`.`producto` (`idProducto`, `idMarca`, `nombre`, `fecha`, `descripcion`, `stock`, `precio`, `estado`) VALUES ('2', '2', 'Producto 2', '2021-10-07', 'Descripcion 2', '200', '5', 'A');


-- ------------------------------------------------------------------------------------------------------------
-- 												CONSULTAS INTELIGENTES
-- ------------------------------------------------------------------------------------------------------------
CREATE TABLE factura_header (
  id_factura_header int NOT NULL,
  id_proveedor int DEFAULT NULL,
  total float DEFAULT NULL
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE linea (
   id_linea int NOT NULL,
   nombre varchar(100) DEFAULT NULL,
   descripcion varchar(500) DEFAULT NULL,
   id_marca int DEFAULT NULL
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE marca (
   id_marca int NOT NULL,
   nombre varchar(100) DEFAULT NULL,
   descripcion varchar(500) DEFAULT NULL,
   id_proveedor int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE proveedores (
   id_proveedor int NOT NULL,
   nombre varchar(100) DEFAULT NULL,
   direccion varchar(500) DEFAULT NULL,
   telefono int DEFAULT NULL,
   email varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE registro_compra (
   id_registro int NOT NULL,
   id_factura_header int DEFAULT NULL,
   Monto float DEFAULT NULL,
   fecha date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE registro_consultas (
   id_registro int NOT NULL,
   nombre varchar(200) DEFAULT NULL,
   consulta varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


-- INSERT CONSULTAS INTELIGENTES
INSERT INTO `linea` (`id_linea`, `nombre`, `descripcion`, `id_marca`) VALUES (1, '1', '1', 1), (2, '1', '1', 1), (3, '1', '1', 1);
INSERT INTO `marca` (`id_marca`, `nombre`, `descripcion`, `id_proveedor`) VALUES (1, '1', '1', 1);
INSERT INTO `proveedores` (`id_proveedor`, `nombre`, `direccion`, `telefono`, `email`) VALUES (1, 'prueba', 'prueba', 12345678, 'prueba');

--
-- Volcado de datos para la tabla `registro_consultas`
--

INSERT INTO `registro_consultas` (`id_registro`, `nombre`, `consulta`) VALUES
(3, 'consulta1', 'SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\" OR id_linea=\"3\"  order by id_linea desc;'),
(4, 'consulta2', 'SELECT id_factura_header as fh FROM factura_header ;'),
(5, 'aniversario', 'SELECT nombre as nonono FROM proveedores ;'),
(8, 'todosprov', 'SELECT  * FROM proveedores ;'),
(10, 'nuevoprov', 'SELECT  * FROM proveedores '),
(11, 'Demostracion', 'SELECT  * FROM linea    ;'),
(12, 'Todos los campos', 'SELECT  * FROM proveedores '),
(13, 'simple', 'SELECT nombre FROM marca '),
(14, 'pruebasimple', 'SELECT nombre FROM linea     ;'),
(18, 'ejemplox', 'SELECT  * FROM linea  WHERE id_linea=\"1\"    ;'),
(19, 'pruebabiggs', 'SELECT  * FROM linea  WHERE id_linea=\"1\"    ;'),
(20, 'and', 'SELECT  * FROM linea  WHERE id_linea=\"1\"  AND nombre=\"1\"   ;'),
(21, 'orord', 'SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\"  order by id_linea desc ;'),
(22, 'error', 'SELECT  * FROM linea  WHERE nombre=\"1\"  AND id_linea=\"1\"  group by id_linea ;'),
(28, 'prueba', 'SELECT  * FROM registro_consultas  WHERE id_registro=\"1\"    ;'),
(29, 'Pruebadef', 'SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\"  order by id_linea desc ;'),
(30, 'pruebadef2', 'SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\" OR id_linea=\"3\"  order by id_linea desc ;'),
(31, 'pruebadef3', 'SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\"  order by id_linea asc ;'),
(36, 'esteban', 'SELECT id_linea as linea , nombre as esteban FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\"  order by id_linea asc;'),
(37, 'ejemplo36', 'SELECT  * FROM linea    ;'),
(38, 'pruebafinal', 'SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\"  group by id_linea;');

--
-- Índices para tablas volcadas

-- Indices de la tabla `factura_header`
--
ALTER TABLE `factura_header`
  ADD PRIMARY KEY (`id_factura_header`),
  ADD KEY `id_proveedor` (`id_proveedor`);

--
-- Indices de la tabla `linea`
--
ALTER TABLE `linea`
  ADD PRIMARY KEY (`id_linea`),
  ADD KEY `fklineamarca` (`id_marca`);

--
-- Indices de la tabla `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`id_marca`),
  ADD KEY `fkmarcaproveedor` (`id_proveedor`);

--
-- Indices de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  ADD PRIMARY KEY (`id_proveedor`);

--
-- Indices de la tabla `registro_compra`
--
ALTER TABLE `registro_compra`
  ADD PRIMARY KEY (`id_registro`),
  ADD KEY `id_factura_header` (`id_factura_header`);

--
-- Indices de la tabla `registro_consultas`
--
ALTER TABLE `registro_consultas`
  ADD PRIMARY KEY (`id_registro`);

--
-- AUTO_INCREMENT de las tablas volcadas
--
-- AUTO_INCREMENT de la tabla `factura_header`
--
ALTER TABLE `factura_header`
  MODIFY `id_factura_header` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `linea`
--
ALTER TABLE `linea`
  MODIFY `id_linea` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `marca`
--
ALTER TABLE `marca`
  MODIFY `id_marca` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  MODIFY `id_proveedor` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `registro_compra`
--
ALTER TABLE `registro_compra`
  MODIFY `id_registro` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `registro_consultas`
--
ALTER TABLE `registro_consultas`
  MODIFY `id_registro` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- Restricciones para tablas volcadas
--
-- Filtros para la tabla `factura_header`
--
ALTER TABLE `factura_header`
  ADD CONSTRAINT `factura_header_ibfk_1` FOREIGN KEY (`id_proveedor`) REFERENCES `proveedores` (`id_proveedor`);

--
-- Filtros para la tabla `linea`
--
ALTER TABLE `linea`
  ADD CONSTRAINT `linea_ibfk_1` FOREIGN KEY (`id_marca`) REFERENCES `marca` (`id_marca`);

--
-- Filtros para la tabla `marca`
--
ALTER TABLE `marca`
  ADD CONSTRAINT `marca_ibfk_1` FOREIGN KEY (`id_proveedor`) REFERENCES `proveedores` (`id_proveedor`);

--
-- Filtros para la tabla `registro_compra`
--
ALTER TABLE `registro_compra`
  ADD CONSTRAINT `registro_compra_ibfk_1` FOREIGN KEY (`id_factura_header`) REFERENCES `factura_header` (`id_factura_header`);