/*Para prueba iniciales respectivas*/
create database pruebas;
use pruebas;

select * from productos;

CREATE TABLE `productos` (
  `codigo` varchar(20) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `precio_publico` decimal(10,2) NOT NULL,
  `existencias` int NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci