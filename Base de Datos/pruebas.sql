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