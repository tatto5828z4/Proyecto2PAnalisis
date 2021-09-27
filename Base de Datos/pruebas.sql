create database pruebas;
use pruebas;

create table marca(
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
  
	foreign key (idMarca) references marca(idMarca)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table ayuda(
	idAyuda int primary key not null,
    rutaChm varchar(80) not null,
    rutaHtml varchar(80) not null
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


-- ----------------------------------------------------------------------------------------------------------------------------
-- REPORTES
-- ----------------------------------------------------------------------------------------------------------------------------
-- drop table reporte;
create table reporte (
	idReporte int NOT NULL primary key,
	nombreReporte varchar(20) NOT NULL,
	rutaReporte varchar(100) NOT NULL,
	-- IdDepartamento varchar(20) NOT NULL,
	estado char(1) NOT NULL
	-- foreign key (IdDepartamento) references departamentos (IdDepartamento)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;


-- ----------------------------------------------------------------------------------------------------------------------------
-- SEGURIDAD
-- ----------------------------------------------------------------------------------------------------------------------------
create table aplicacion (
   pkId INT NOT NULL primary key,
   nombre VARCHAR(45) NULL,
   estado char(1) NOT NULL
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

-- Tabla aplicacionAyuda
create table aplicacionAyuda(
	pkId int not null,
    idAyuda int not null,
    primary key(pkId, idAyuda),
    
    foreign key (pkId) references aplicacion(pkId),
    foreign key (idAyuda) references ayuda(idAyuda)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

-- Tabla aplicacionReporte
create table aplicacionReporte(
	pkId int not null,
    idReporte int not null,
    primary key(pkId, idReporte),
    
    foreign key (pkId) references aplicacion(pkId),
    foreign key (idReporte) references reporte(idReporte)
)ENGINE = InnoDB DEFAULT CHARACTER SET = latin1;

-- ---------------------------------------------------------------
-- Consultas
-- ---------------------------------------------------------------
select * from marca;
select * from aplicacion;
select * from aplicacionReporte;
select * from ayuda;
select * from reporte;

-- ---------------------------------------------------------------
-- Insert
-- ---------------------------------------------------------------

INSERT INTO `pruebas`.`marca` (`idMarca`, `nombre`, `estatus`) VALUES ('1', 'Nike', 'A');
INSERT INTO `pruebas`.`marca` (`idMarca`, `nombre`, `estatus`) VALUES ('2', 'Adidas', 'A');

INSERT INTO `pruebas`.`producto` (`idProducto`, `idMarca`, `nombre`, `fecha`, `descripcion`, `stock`, `precio`, `estado`) VALUES ('1', '1', 'Producto1', '2021/09/22', 'Descripcion', '10', '15', 'A');
INSERT INTO `pruebas`.`ayuda` (`idAyuda`, `rutaChm`, `rutaHtml`) VALUES ('1', 'Ayudas/AyudaSistemaReparto.chm', 'ManualSistemaReparto.html');

INSERT INTO `pruebas`.`aplicacion` (`pkId`, `nombre`, `estado`) VALUES ('1', 'Aplicacion 1', 'A');
INSERT INTO `pruebas`.`reporte` (`idReporte`, `nombreReporte`, `rutaReporte`, `estado`) VALUES ('1', 'Reporte de Pruebas', 'Reportes/productos.rpt', 'A');
