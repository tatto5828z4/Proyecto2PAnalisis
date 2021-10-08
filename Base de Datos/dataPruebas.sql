CREATE DATABASE  IF NOT EXISTS `pruebas` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `pruebas`;
-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: 104.155.133.66    Database: pruebas
-- ------------------------------------------------------
-- Server version	5.7.34-google-log

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
SET @MYSQLDUMP_TEMP_LOG_BIN = @@SESSION.SQL_LOG_BIN;
SET @@SESSION.SQL_LOG_BIN= 0;

--
-- GTID state at the beginning of the backup 
--

SET @@GLOBAL.GTID_PURGED=/*!80000 '+'*/ '586210ee-1b35-11ec-a679-42010a800003:1-89083';

--
-- Table structure for table `aplicacion`
--

DROP TABLE IF EXISTS `aplicacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aplicacion` (
  `pkId` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `estado` char(1) NOT NULL,
  PRIMARY KEY (`pkId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aplicacion`
--

LOCK TABLES `aplicacion` WRITE;
/*!40000 ALTER TABLE `aplicacion` DISABLE KEYS */;
INSERT INTO `aplicacion` VALUES (1,'Aplicacion 1','A');
/*!40000 ALTER TABLE `aplicacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aplicacionAyuda`
--

DROP TABLE IF EXISTS `aplicacionAyuda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aplicacionAyuda` (
  `pkId` int(11) NOT NULL,
  `idAyuda` int(11) NOT NULL,
  PRIMARY KEY (`pkId`,`idAyuda`),
  KEY `idAyuda` (`idAyuda`),
  CONSTRAINT `aplicacionAyuda_ibfk_1` FOREIGN KEY (`pkId`) REFERENCES `aplicacion` (`pkId`),
  CONSTRAINT `aplicacionAyuda_ibfk_2` FOREIGN KEY (`idAyuda`) REFERENCES `ayuda` (`idAyuda`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aplicacionAyuda`
--

LOCK TABLES `aplicacionAyuda` WRITE;
/*!40000 ALTER TABLE `aplicacionAyuda` DISABLE KEYS */;
/*!40000 ALTER TABLE `aplicacionAyuda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aplicacionReporte`
--

DROP TABLE IF EXISTS `aplicacionReporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aplicacionReporte` (
  `pkId` int(11) NOT NULL,
  `idReporte` int(11) NOT NULL,
  PRIMARY KEY (`pkId`,`idReporte`),
  KEY `idReporte` (`idReporte`),
  CONSTRAINT `aplicacionReporte_ibfk_1` FOREIGN KEY (`pkId`) REFERENCES `aplicacion` (`pkId`),
  CONSTRAINT `aplicacionReporte_ibfk_2` FOREIGN KEY (`idReporte`) REFERENCES `reporte` (`idReporte`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aplicacionReporte`
--

LOCK TABLES `aplicacionReporte` WRITE;
/*!40000 ALTER TABLE `aplicacionReporte` DISABLE KEYS */;
/*!40000 ALTER TABLE `aplicacionReporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ayuda`
--

DROP TABLE IF EXISTS `ayuda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ayuda` (
  `idAyuda` int(11) NOT NULL,
  `rutaChm` varchar(80) NOT NULL,
  `rutaHtml` varchar(80) NOT NULL,
  PRIMARY KEY (`idAyuda`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ayuda`
--

LOCK TABLES `ayuda` WRITE;
/*!40000 ALTER TABLE `ayuda` DISABLE KEYS */;
INSERT INTO `ayuda` VALUES (1,'Ayudas/AyudasSistemaReparto.chm','ManualMantenimientos.html');
/*!40000 ALTER TABLE `ayuda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marca`
--

DROP TABLE IF EXISTS `marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `marca` (
  `idMarca` varchar(10) NOT NULL,
  `nombre` varchar(35) NOT NULL,
  `estatus` char(1) NOT NULL,
  PRIMARY KEY (`idMarca`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca`
--

LOCK TABLES `marca` WRITE;
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
INSERT INTO `marca` VALUES ('1','Nike','A'),('2','Adidas','A'),('3','Puma','A'),('4','Chicote','A');
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;
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
  `stock` int(11) NOT NULL,
  `precio` float NOT NULL,
  `estado` char(1) NOT NULL,
  PRIMARY KEY (`idProducto`),
  KEY `idMarca` (`idMarca`),
  CONSTRAINT `producto_ibfk_1` FOREIGN KEY (`idMarca`) REFERENCES `marca` (`idMarca`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES ('1','1','Producto1','2021-09-22','Descripcion',10,15,'I'),('2','2','Prod2','2020-05-06','Desc',150,15,'I'),('3','3','Prod3','2021-05-06','Desc',15,15,'I'),('4','2','Brayan','2021-09-15','JAJAJA',2,10,'I'),('5','4','Brayan2','2021-09-15','jjejejeje',155,120,'A'),('6','3','','2021-09-23','fasdf',15,112,'I'),('7','4','Producto 7','2021-09-25','descripcion',10,110,'A'),('8','3','Proc 8','2021-09-25','151651',11,123,'I');
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reporte`
--

DROP TABLE IF EXISTS `reporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reporte` (
  `idReporte` int(11) NOT NULL,
  `nombreReporte` varchar(20) NOT NULL,
  `rutaReporte` varchar(100) NOT NULL,
  `estado` char(1) NOT NULL,
  PRIMARY KEY (`idReporte`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporte`
--

LOCK TABLES `reporte` WRITE;
/*!40000 ALTER TABLE `reporte` DISABLE KEYS */;
INSERT INTO `reporte` VALUES (1,'Reporte de Pruebas','Reportes/productos.rpt','A');
/*!40000 ALTER TABLE `reporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'pruebas'
--

--
-- Dumping routines for database 'pruebas'
--
SET @@SESSION.SQL_LOG_BIN = @MYSQLDUMP_TEMP_LOG_BIN;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-09-26 21:28:16
