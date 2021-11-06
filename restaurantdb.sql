-- MariaDB dump 10.19  Distrib 10.5.10-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: restaurantdb
-- ------------------------------------------------------
-- Server version	10.5.10-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categoria_platos`
--

DROP TABLE IF EXISTS `categoria_platos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoria_platos` (
  `idcategoria` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`idcategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria_platos`
--

LOCK TABLES `categoria_platos` WRITE;
/*!40000 ALTER TABLE `categoria_platos` DISABLE KEYS */;
INSERT INTO `categoria_platos` VALUES (1,'Platos'),(2,'Postres'),(3,'Bebidas');
/*!40000 ALTER TABLE `categoria_platos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura`
--

DROP TABLE IF EXISTS `factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factura` (
  `numFactura` int(11) NOT NULL,
  `totalFactura` double NOT NULL,
  `nombreCliente` varchar(50) DEFAULT NULL,
  `nit` int(11) DEFAULT NULL,
  PRIMARY KEY (`numFactura`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura`
--

LOCK TABLES `factura` WRITE;
/*!40000 ALTER TABLE `factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `plato`
--

DROP TABLE IF EXISTS `plato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `plato` (
  `idplato` int(11) NOT NULL AUTO_INCREMENT,
  `nombrePlato` varchar(50) NOT NULL,
  `descripcion` varchar(80) DEFAULT NULL,
  `precio` double NOT NULL,
  `idcategoria` int(11) NOT NULL,
  `imagen` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`idplato`),
  KEY `idcategoria` (`idcategoria`),
  CONSTRAINT `plato_ibfk_1` FOREIGN KEY (`idcategoria`) REFERENCES `categoria_platos` (`idcategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `plato`
--

LOCK TABLES `plato` WRITE;
/*!40000 ALTER TABLE `plato` DISABLE KEYS */;
INSERT INTO `plato` VALUES (1,'Caponata','Guiso de verduras agridulces de la gastronomía de Sicilia',39,1,'..\\..\\Resources\\Caponata.jpg'),(2,'Minestrone','Sopa de verduras y legumbres',28,1,'..\\..\\Resources\\Minestrone.jpg'),(3,'Parmigiana','Pastel de berenjenas y quesos',35,1,'..\\..\\Resources\\Parmigiana.jpg'),(4,'Polenta','Pastel a base de harina de maíz, farro o cebada',25,1,'..\\..\\Resources\\Polenta.jpg'),(5,'Farinata','Plato ligur con harina de garbanzos',25,1,'..\\..\\Resources\\Farinata.jpg'),(6,'Bagna Cauda','Sopa caliente hecha con verduras, quesos y anchoas',30,1,'..\\..\\Resources\\BagnaCauda.jpg'),(7,'Frittata di verdure','Tortilla de verduras',25,1,'..\\..\\Resources\\FrittataVerdure.jpg'),(8,'Ravioli','Pasta rellena con jamon, queso y salsa',35,1,'..\\..\\Resources\\Ravioli.jpg'),(9,'Lasagne','Láminas de pasta intercaladas con capas de salsa bolognesa y queso',45,1,'..\\..\\Resources\\Lasagna.jpg'),(10,'Spaghetti alla Carbonara','spaghetti con salsa hecha de huevos, parmesano, aceite de oliva, pancetta',25,1,'..\\..\\Resources\\Spaghetti.jpg'),(11,'Risotto alla carbonara','Risotto con yema de huevo, guanciale y queso pecorino',35,1,'..\\..\\Resources\\Risotto.jpg'),(12,'Pizza marinara','Sus ingredientes básicos son el tomate, el orégano y el ajo',50,1,'..\\..\\Resources\\Marinara.jpg'),(13,'Pizza Margherita','Sus ingredientes básicos son tomate, mozzarella y albahaca',5,1,'..\\..\\Resources\\Margarita.jpg'),(14,'Pizza Napoletana','Hecha con Mozzarella di Bufala Campana, tomate de San Marzano Y albahaca',7,1,'..\\..\\Resources\\Napolitana.jpg'),(15,'Cassata','Tarta a base de ricotta, bizcocho, mazapán, fruta confitada y azúcar glas',15,2,'..\\..\\Resources\\Cassata.jpg'),(16,'Gelato','Elaborado con una base de grasa láctea, leche entera y azúcar',15,2,'..\\..\\Resources\\Gelato.jpg'),(17,'Panna cotta','Elaborado con crema de leche, azúcar y gelificantes, parecido al flan',20,2,'..\\..\\Resources\\PannaCotta.jpg'),(18,'Strudel','Pastel con forma de remolino relleno de manzana',20,2,'..\\..\\Resources\\Strudel.jpg'),(19,'Torta caprese','Pastel de chocolate y almendras o nueces',10,2,'..\\..\\Resources\\Caprese.jpg'),(20,'Tiramisú','Pastel frío que se monta en capas humedecidas con cafe',10,2,'..\\..\\Resources\\Tiramisu.jpg'),(21,'Agua','600ml',5,3,'..\\..\\Resources\\Agua.jpg'),(22,'Coca Cola','500ml',7,3,'..\\..\\Resources\\Cocacola.jpg'),(23,'Limonada','300ml',7,3,'..\\..\\Resources\\Limonada.jpg'),(24,'7up','500ml',7,3,'..\\..\\Resources\\7up.jpg'),(25,'Vino Tinto','Bebida alcoholica, botella de 700ml',40,3,'..\\..\\Resources\\Tinto.jpg'),(26,'Vino Blanco','Bebida alcoholica, botella de 700ml',40,3,'..\\..\\Resources\\Blanco.jpg'),(27,'Cerveza','Bebida alcoholica, botella de 710ml',20,3,'..\\..\\Resources\\Cerveza.jpg');
/*!40000 ALTER TABLE `plato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `platos_pedido`
--

DROP TABLE IF EXISTS `platos_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `platos_pedido` (
  `idplato` int(11) NOT NULL,
  `numFactura` int(11) NOT NULL,
  PRIMARY KEY (`idplato`,`numFactura`),
  KEY `numFactura` (`numFactura`),
  CONSTRAINT `platos_pedido_ibfk_1` FOREIGN KEY (`idplato`) REFERENCES `plato` (`idplato`),
  CONSTRAINT `platos_pedido_ibfk_2` FOREIGN KEY (`numFactura`) REFERENCES `factura` (`numFactura`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `platos_pedido`
--

LOCK TABLES `platos_pedido` WRITE;
/*!40000 ALTER TABLE `platos_pedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `platos_pedido` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-11-05 19:26:40
