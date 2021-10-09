CREATE DATABASE  IF NOT EXISTS `hotelsancarlos` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `hotelsancarlos`;
-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: hotelsancarlos
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `aplicacion`
--

DROP TABLE IF EXISTS `aplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aplicacion` (
  `pkId` varchar(15) NOT NULL,
  `fkIdModulo` varchar(15) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `estado` int NOT NULL,
  `rutaChm` varchar(80) NOT NULL,
  `rutaHtml` varchar(80) NOT NULL,
  PRIMARY KEY (`pkId`),
  KEY `fkIdModulo` (`fkIdModulo`),
  CONSTRAINT `aplicacion_ibfk_1` FOREIGN KEY (`fkIdModulo`) REFERENCES `modulo` (`pkId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aplicacion`
--

LOCK TABLES `aplicacion` WRITE;
/*!40000 ALTER TABLE `aplicacion` DISABLE KEYS */;
INSERT INTO `aplicacion` VALUES ('1','1','Prueba',1,'Ayudas/AyudasSistemaReparto.chm','ManualSistemaReparto.html');
/*!40000 ALTER TABLE `aplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aplicacionperfil`
--

DROP TABLE IF EXISTS `aplicacionperfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aplicacionperfil` (
  `fkIdPerfil` varchar(15) NOT NULL,
  `fkIdAplicacion` varchar(15) NOT NULL,
  `permisoEscritura` int DEFAULT NULL,
  `permisoLectura` int DEFAULT NULL,
  `permisoModificar` int DEFAULT NULL,
  `permisoEliminar` int DEFAULT NULL,
  `permisoImprimir` int DEFAULT NULL,
  KEY `fkIdAplicacion` (`fkIdAplicacion`),
  KEY `fkIdPerfil` (`fkIdPerfil`),
  CONSTRAINT `aplicacionperfil_ibfk_1` FOREIGN KEY (`fkIdAplicacion`) REFERENCES `aplicacion` (`pkId`),
  CONSTRAINT `aplicacionperfil_ibfk_2` FOREIGN KEY (`fkIdPerfil`) REFERENCES `perfil` (`pkId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aplicacionperfil`
--

LOCK TABLES `aplicacionperfil` WRITE;
/*!40000 ALTER TABLE `aplicacionperfil` DISABLE KEYS */;
/*!40000 ALTER TABLE `aplicacionperfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bitacorausuario`
--

DROP TABLE IF EXISTS `bitacorausuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bitacorausuario` (
  `pkId` int NOT NULL AUTO_INCREMENT,
  `host` varchar(45) DEFAULT NULL,
  `ip` varchar(20) DEFAULT NULL,
  `conexionFecha` date DEFAULT NULL,
  `conexionHora` time DEFAULT NULL,
  `fkIdUsuario` varchar(15) NOT NULL,
  `fkIdAplicacion` varchar(15) NOT NULL,
  `accion` varchar(200) NOT NULL,
  PRIMARY KEY (`pkId`),
  KEY `fkIdUsuario` (`fkIdUsuario`),
  KEY `fkIdAplicacion` (`fkIdAplicacion`),
  CONSTRAINT `bitacorausuario_ibfk_1` FOREIGN KEY (`fkIdUsuario`) REFERENCES `usuario` (`pkId`),
  CONSTRAINT `bitacorausuario_ibfk_2` FOREIGN KEY (`fkIdAplicacion`) REFERENCES `aplicacion` (`pkId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bitacorausuario`
--

LOCK TABLES `bitacorausuario` WRITE;
/*!40000 ALTER TABLE `bitacorausuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `bitacorausuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleado` (
  `pkIdEmpleado` varchar(15) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `apellido` varchar(25) NOT NULL,
  PRIMARY KEY (`pkIdEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES ('1','María','Hernandez');
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura_header`
--

DROP TABLE IF EXISTS `factura_header`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `factura_header` (
  `id_factura_header` int NOT NULL AUTO_INCREMENT,
  `id_proveedor` int DEFAULT NULL,
  `total` float DEFAULT NULL,
  PRIMARY KEY (`id_factura_header`),
  KEY `id_proveedor` (`id_proveedor`),
  CONSTRAINT `factura_header_ibfk_1` FOREIGN KEY (`id_proveedor`) REFERENCES `proveedores` (`id_proveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura_header`
--

LOCK TABLES `factura_header` WRITE;
/*!40000 ALTER TABLE `factura_header` DISABLE KEYS */;
/*!40000 ALTER TABLE `factura_header` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `linea`
--

DROP TABLE IF EXISTS `linea`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `linea` (
  `id_linea` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` varchar(500) DEFAULT NULL,
  `id_marca` int DEFAULT NULL,
  PRIMARY KEY (`id_linea`),
  KEY `fklineamarca` (`id_marca`),
  CONSTRAINT `linea_ibfk_1` FOREIGN KEY (`id_marca`) REFERENCES `marca` (`id_marca`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `linea`
--

LOCK TABLES `linea` WRITE;
/*!40000 ALTER TABLE `linea` DISABLE KEYS */;
INSERT INTO `linea` VALUES (1,'1','1',1),(2,'1','1',1),(3,'1','1',1);
/*!40000 ALTER TABLE `linea` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marca`
--

DROP TABLE IF EXISTS `marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `marca` (
  `id_marca` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` varchar(500) DEFAULT NULL,
  `id_proveedor` int DEFAULT NULL,
  PRIMARY KEY (`id_marca`),
  KEY `fkmarcaproveedor` (`id_proveedor`),
  CONSTRAINT `marca_ibfk_1` FOREIGN KEY (`id_proveedor`) REFERENCES `proveedores` (`id_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca`
--

LOCK TABLES `marca` WRITE;
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
INSERT INTO `marca` VALUES (1,'1','1',1);
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marcap`
--

DROP TABLE IF EXISTS `marcap`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `marcap` (
  `idMarca` varchar(10) NOT NULL,
  `nombre` varchar(35) NOT NULL,
  `estatus` char(1) NOT NULL,
  PRIMARY KEY (`idMarca`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marcap`
--

LOCK TABLES `marcap` WRITE;
/*!40000 ALTER TABLE `marcap` DISABLE KEYS */;
INSERT INTO `marcap` VALUES ('1','Nike','A'),('2','Adidas','A');
/*!40000 ALTER TABLE `marcap` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modulo`
--

DROP TABLE IF EXISTS `modulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `modulo` (
  `pkId` varchar(15) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `descripcion` varchar(200) NOT NULL,
  `estado` varchar(1) NOT NULL,
  PRIMARY KEY (`pkId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modulo`
--

LOCK TABLES `modulo` WRITE;
/*!40000 ALTER TABLE `modulo` DISABLE KEYS */;
INSERT INTO `modulo` VALUES ('1','Seguridad','Modulo de seguridad','1');
/*!40000 ALTER TABLE `modulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `perfil`
--

DROP TABLE IF EXISTS `perfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `perfil` (
  `pkId` varchar(15) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`pkId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `perfil`
--

LOCK TABLES `perfil` WRITE;
/*!40000 ALTER TABLE `perfil` DISABLE KEYS */;
INSERT INTO `perfil` VALUES ('1','Administrador','1'),('2','Vendedor','1');
/*!40000 ALTER TABLE `perfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `idProducto` varchar(20) NOT NULL,
  `idMarca` varchar(10) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `fecha` date NOT NULL,
  `descripcion` varchar(100) NOT NULL,
  `stock` int NOT NULL,
  `precio` float NOT NULL,
  `estado` char(1) NOT NULL,
  PRIMARY KEY (`idProducto`),
  KEY `idMarca` (`idMarca`),
  CONSTRAINT `producto_ibfk_1` FOREIGN KEY (`idMarca`) REFERENCES `marcap` (`idMarca`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES ('1','1','Producto1','2021-09-22','Descripcion',10,15,'A'),('2','2','Producto 2','2021-10-07','Descripcion 2',200,5,'I');
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedores`
--

DROP TABLE IF EXISTS `proveedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedores` (
  `id_proveedor` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `direccion` varchar(500) DEFAULT NULL,
  `telefono` int DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id_proveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedores`
--

LOCK TABLES `proveedores` WRITE;
/*!40000 ALTER TABLE `proveedores` DISABLE KEYS */;
INSERT INTO `proveedores` VALUES (1,'prueba','prueba',12345678,'prueba');
/*!40000 ALTER TABLE `proveedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `registro_compra`
--

DROP TABLE IF EXISTS `registro_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `registro_compra` (
  `id_registro` int NOT NULL AUTO_INCREMENT,
  `id_factura_header` int DEFAULT NULL,
  `Monto` float DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`id_registro`),
  KEY `id_factura_header` (`id_factura_header`),
  CONSTRAINT `registro_compra_ibfk_1` FOREIGN KEY (`id_factura_header`) REFERENCES `factura_header` (`id_factura_header`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registro_compra`
--

LOCK TABLES `registro_compra` WRITE;
/*!40000 ALTER TABLE `registro_compra` DISABLE KEYS */;
/*!40000 ALTER TABLE `registro_compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `registro_consultas`
--

DROP TABLE IF EXISTS `registro_consultas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `registro_consultas` (
  `id_registro` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(200) DEFAULT NULL,
  `consulta` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`id_registro`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registro_consultas`
--

LOCK TABLES `registro_consultas` WRITE;
/*!40000 ALTER TABLE `registro_consultas` DISABLE KEYS */;
INSERT INTO `registro_consultas` VALUES (3,'consulta1','SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\" OR id_linea=\"3\"  order by id_linea desc;'),(4,'consulta2','SELECT id_factura_header as fh FROM factura_header ;'),(5,'aniversario','SELECT nombre as nonono FROM proveedores ;'),(8,'todosprov','SELECT  * FROM proveedores ;'),(10,'nuevoprov','SELECT  * FROM proveedores '),(11,'Demostracion','SELECT  * FROM linea    ;'),(12,'Todos los campos','SELECT  * FROM proveedores '),(13,'simple','SELECT nombre FROM marca '),(14,'pruebasimple','SELECT nombre FROM linea     ;'),(18,'ejemplox','SELECT  * FROM linea  WHERE id_linea=\"1\"    ;'),(19,'pruebabiggs','SELECT  * FROM linea  WHERE id_linea=\"1\"    ;'),(20,'and','SELECT  * FROM linea  WHERE id_linea=\"1\"  AND nombre=\"1\"   ;'),(21,'orord','SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\"  order by id_linea desc ;'),(22,'error','SELECT  * FROM linea  WHERE nombre=\"1\"  AND id_linea=\"1\"  group by id_linea ;'),(28,'prueba','SELECT  * FROM registro_consultas  WHERE id_registro=\"1\"    ;'),(29,'Pruebadef','SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\"  order by id_linea desc ;'),(30,'pruebadef2','SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\" OR id_linea=\"3\"  order by id_linea desc ;'),(31,'pruebadef3','SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\"  order by id_linea asc ;'),(36,'esteban','SELECT id_linea as linea , nombre as esteban FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\"  order by id_linea asc;'),(37,'ejemplo36','SELECT  * FROM linea    ;'),(38,'pruebafinal','SELECT  * FROM linea  WHERE id_linea=\"1\"  OR id_linea=\"2\"  group by id_linea;');
/*!40000 ALTER TABLE `registro_consultas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reporte`
--

DROP TABLE IF EXISTS `reporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reporte` (
  `idReporte` int NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `ruta` varchar(100) NOT NULL,
  `idAplicacion` varchar(15) NOT NULL,
  `estado` char(1) NOT NULL,
  PRIMARY KEY (`idReporte`),
  KEY `idAplicacion` (`idAplicacion`),
  CONSTRAINT `reporte_ibfk_1` FOREIGN KEY (`idAplicacion`) REFERENCES `aplicacion` (`pkId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporte`
--

LOCK TABLES `reporte` WRITE;
/*!40000 ALTER TABLE `reporte` DISABLE KEYS */;
INSERT INTO `reporte` VALUES (1,'Reporte de Pruebas','Reportes/productos.rpt','1','A');
/*!40000 ALTER TABLE `reporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `pkId` varchar(15) NOT NULL,
  `fkIdEmpleado` varchar(15) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `contraseña` varchar(100) NOT NULL,
  `estado` varchar(1) NOT NULL,
  `intento` int DEFAULT NULL,
  PRIMARY KEY (`pkId`),
  KEY `fkIdEmpleado` (`fkIdEmpleado`),
  CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`fkIdEmpleado`) REFERENCES `empleado` (`pkIdEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('1','1','admin','LKAekHU9EtweB49HAaTRfg==','1',0);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarioaplicacion`
--

DROP TABLE IF EXISTS `usuarioaplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarioaplicacion` (
  `fkIdUsuario` varchar(15) NOT NULL,
  `fkIdAplicacion` varchar(15) NOT NULL,
  `permisoEscritura` int DEFAULT NULL,
  `permisoLectura` int DEFAULT NULL,
  `permisoModificar` int DEFAULT NULL,
  `permisoEliminar` int DEFAULT NULL,
  `permisoImprimir` int DEFAULT NULL,
  KEY `fkIdAplicacion` (`fkIdAplicacion`),
  KEY `fkIdUsuario` (`fkIdUsuario`),
  CONSTRAINT `usuarioaplicacion_ibfk_1` FOREIGN KEY (`fkIdAplicacion`) REFERENCES `aplicacion` (`pkId`),
  CONSTRAINT `usuarioaplicacion_ibfk_2` FOREIGN KEY (`fkIdUsuario`) REFERENCES `usuario` (`pkId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarioaplicacion`
--

LOCK TABLES `usuarioaplicacion` WRITE;
/*!40000 ALTER TABLE `usuarioaplicacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuarioaplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarioaplicacionasignados`
--

DROP TABLE IF EXISTS `usuarioaplicacionasignados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarioaplicacionasignados` (
  `fkIdUsuario` varchar(15) NOT NULL,
  `fkIdAplicacion` varchar(15) NOT NULL,
  KEY `fkIdAplicacion` (`fkIdAplicacion`),
  KEY `fkIdUsuario` (`fkIdUsuario`),
  CONSTRAINT `usuarioaplicacionasignados_ibfk_1` FOREIGN KEY (`fkIdAplicacion`) REFERENCES `aplicacion` (`pkId`),
  CONSTRAINT `usuarioaplicacionasignados_ibfk_2` FOREIGN KEY (`fkIdUsuario`) REFERENCES `usuario` (`pkId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarioaplicacionasignados`
--

LOCK TABLES `usuarioaplicacionasignados` WRITE;
/*!40000 ALTER TABLE `usuarioaplicacionasignados` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuarioaplicacionasignados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarioperfil`
--

DROP TABLE IF EXISTS `usuarioperfil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarioperfil` (
  `fkIdUsuario` varchar(15) NOT NULL,
  `fkIdPerfil` varchar(15) NOT NULL,
  KEY `fkIdPerfil` (`fkIdPerfil`),
  KEY `fkIdUsuario` (`fkIdUsuario`),
  CONSTRAINT `usuarioperfil_ibfk_1` FOREIGN KEY (`fkIdPerfil`) REFERENCES `perfil` (`pkId`),
  CONSTRAINT `usuarioperfil_ibfk_2` FOREIGN KEY (`fkIdUsuario`) REFERENCES `usuario` (`pkId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarioperfil`
--

LOCK TABLES `usuarioperfil` WRITE;
/*!40000 ALTER TABLE `usuarioperfil` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuarioperfil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `vwpermisosperfil`
--

DROP TABLE IF EXISTS `vwpermisosperfil`;
/*!50001 DROP VIEW IF EXISTS `vwpermisosperfil`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vwpermisosperfil` AS SELECT 
 1 AS `permisoEscritura`,
 1 AS `permisoLectura`,
 1 AS `permisoModificar`,
 1 AS `permisoEliminar`,
 1 AS `permisoImprimir`,
 1 AS `pkIdPerfil`,
 1 AS `Perfil`,
 1 AS `pkIdAplicacion`,
 1 AS `Aplicacion`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vwpermisosusuario`
--

DROP TABLE IF EXISTS `vwpermisosusuario`;
/*!50001 DROP VIEW IF EXISTS `vwpermisosusuario`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vwpermisosusuario` AS SELECT 
 1 AS `permisoEscritura`,
 1 AS `permisoLectura`,
 1 AS `permisoModificar`,
 1 AS `permisoEliminar`,
 1 AS `permisoImprimir`,
 1 AS `pkIdUsuario`,
 1 AS `Usuario`,
 1 AS `pkIdAplicacion`,
 1 AS `Aplicacion`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'hotelsancarlos'
--

--
-- Dumping routines for database 'hotelsancarlos'
--

--
-- Final view structure for view `vwpermisosperfil`
--

/*!50001 DROP VIEW IF EXISTS `vwpermisosperfil`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vwpermisosperfil` AS select `a`.`permisoEscritura` AS `permisoEscritura`,`a`.`permisoLectura` AS `permisoLectura`,`a`.`permisoModificar` AS `permisoModificar`,`a`.`permisoEliminar` AS `permisoEliminar`,`a`.`permisoImprimir` AS `permisoImprimir`,`b`.`pkId` AS `pkIdPerfil`,`b`.`nombre` AS `Perfil`,`c`.`pkId` AS `pkIdAplicacion`,`c`.`nombre` AS `Aplicacion` from ((`aplicacionperfil` `a` join `perfil` `b` on((`b`.`pkId` = `a`.`fkIdPerfil`))) join `aplicacion` `c` on((`c`.`pkId` = `a`.`fkIdAplicacion`))) order by `a`.`fkIdPerfil` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vwpermisosusuario`
--

/*!50001 DROP VIEW IF EXISTS `vwpermisosusuario`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vwpermisosusuario` AS select `a`.`permisoEscritura` AS `permisoEscritura`,`a`.`permisoLectura` AS `permisoLectura`,`a`.`permisoModificar` AS `permisoModificar`,`a`.`permisoEliminar` AS `permisoEliminar`,`a`.`permisoImprimir` AS `permisoImprimir`,`b`.`pkId` AS `pkIdUsuario`,`b`.`nombre` AS `Usuario`,`c`.`pkId` AS `pkIdAplicacion`,`c`.`nombre` AS `Aplicacion` from ((`usuarioaplicacion` `a` join `usuario` `b` on((`b`.`pkId` = `a`.`fkIdUsuario`))) join `aplicacion` `c` on((`c`.`pkId` = `a`.`fkIdAplicacion`))) order by `a`.`fkIdUsuario` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-09  0:15:18
