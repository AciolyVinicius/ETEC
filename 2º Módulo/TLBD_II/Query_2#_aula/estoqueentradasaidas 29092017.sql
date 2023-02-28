CREATE DATABASE  IF NOT EXISTS `estoqueentradassaidas` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `estoqueentradassaidas`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: estoqueentradassaidas
-- ------------------------------------------------------
-- Server version	5.7.18-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categoria` (
  `cd_categoria` int(11) NOT NULL,
  `nm_categoria` varchar(50) NOT NULL,
  PRIMARY KEY (`cd_categoria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'LIMPEZA'),(2,'ALIMENTOS'),(3,'AUTOMOTIVOS');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `cd_cliente` int(11) NOT NULL,
  `nm_cliente` varchar(90) NOT NULL,
  `cd_cpf` char(11) NOT NULL,
  PRIMARY KEY (`cd_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'MALAQUIAS FERRANO','12345678901'),(2,'MIRLO QUIRINO BASTOS','65432178903'),(3,'FELISBERTA ROSANA NUNES','98765432111');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fornecedor`
--

DROP TABLE IF EXISTS `fornecedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fornecedor` (
  `cd_fornecedor` int(11) NOT NULL,
  `nm_fornecedor` varchar(80) NOT NULL,
  PRIMARY KEY (`cd_fornecedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fornecedor`
--

LOCK TABLES `fornecedor` WRITE;
/*!40000 ALTER TABLE `fornecedor` DISABLE KEYS */;
INSERT INTO `fornecedor` VALUES (1,'UM DOIS TRES DA RAZAO UM'),(2,'FOR PRODUTOS MNO');
/*!40000 ALTER TABLE `fornecedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itens_entrada`
--

DROP TABLE IF EXISTS `itens_entrada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itens_entrada` (
  `cd_entrada` int(11) NOT NULL,
  `cd_produto` int(11) NOT NULL,
  `qt_entrada` int(11) NOT NULL,
  `vl_produto` double NOT NULL,
  KEY `fk_itens_notas` (`cd_entrada`),
  KEY `fk_item_produtos` (`cd_produto`),
  CONSTRAINT `fk_item_produtos` FOREIGN KEY (`cd_produto`) REFERENCES `produto` (`cd_produto`),
  CONSTRAINT `fk_itens_notas` FOREIGN KEY (`cd_entrada`) REFERENCES `notas_entrada` (`cd_entrada`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itens_entrada`
--

LOCK TABLES `itens_entrada` WRITE;
/*!40000 ALTER TABLE `itens_entrada` DISABLE KEYS */;
INSERT INTO `itens_entrada` VALUES (1,1,11,3),(1,2,34,4),(1,3,21,2.9),(1,4,44,0.9),(2,5,100,1),(2,6,55,3.2),(2,7,87,2.22),(2,8,99,9.4);
/*!40000 ALTER TABLE `itens_entrada` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itens_saida`
--

DROP TABLE IF EXISTS `itens_saida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itens_saida` (
  `cd_saida` int(11) NOT NULL,
  `cd_produto` int(11) NOT NULL,
  `qt_saida` int(11) NOT NULL,
  `vl_produto` double NOT NULL,
  KEY `fk_item_saidas` (`cd_saida`),
  KEY `fk_item_produtos_s` (`cd_produto`),
  CONSTRAINT `fk_item_produtos_s` FOREIGN KEY (`cd_produto`) REFERENCES `produto` (`cd_produto`),
  CONSTRAINT `fk_item_saidas` FOREIGN KEY (`cd_saida`) REFERENCES `notas_saida` (`cd_saida`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itens_saida`
--

LOCK TABLES `itens_saida` WRITE;
/*!40000 ALTER TABLE `itens_saida` DISABLE KEYS */;
INSERT INTO `itens_saida` VALUES (1,1,2,5.43),(1,5,10,2.65),(1,7,1,4.98),(1,9,12,2),(2,2,5,6.3),(2,4,3,1.45),(2,6,2,6.8),(2,10,2,4.77),(2,7,1,4.98),(2,9,12,2),(1,1,2,5.43),(1,5,10,2.65),(1,7,1,4.98),(1,9,12,2),(2,2,5,6.3),(2,4,3,1.45),(2,6,2,6.8),(2,10,2,4.77),(2,7,1,4.98),(2,9,12,2);
/*!40000 ALTER TABLE `itens_saida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notas_entrada`
--

DROP TABLE IF EXISTS `notas_entrada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `notas_entrada` (
  `cd_entrada` int(11) NOT NULL,
  `cd_fornecedor` int(11) NOT NULL,
  `dt_nota_entrada` date NOT NULL,
  PRIMARY KEY (`cd_entrada`),
  KEY `fk_notas_fornecedor` (`cd_fornecedor`),
  CONSTRAINT `fk_notas_fornecedor` FOREIGN KEY (`cd_fornecedor`) REFERENCES `fornecedor` (`cd_fornecedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notas_entrada`
--

LOCK TABLES `notas_entrada` WRITE;
/*!40000 ALTER TABLE `notas_entrada` DISABLE KEYS */;
INSERT INTO `notas_entrada` VALUES (1,1,'2012-04-03'),(2,2,'2012-06-10');
/*!40000 ALTER TABLE `notas_entrada` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notas_saida`
--

DROP TABLE IF EXISTS `notas_saida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `notas_saida` (
  `cd_saida` int(11) NOT NULL,
  `cd_cliente` int(11) NOT NULL,
  `dt_nota_saida` date NOT NULL,
  PRIMARY KEY (`cd_saida`),
  KEY `fk_nota_clientes` (`cd_cliente`),
  CONSTRAINT `fk_nota_clientes` FOREIGN KEY (`cd_cliente`) REFERENCES `cliente` (`cd_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notas_saida`
--

LOCK TABLES `notas_saida` WRITE;
/*!40000 ALTER TABLE `notas_saida` DISABLE KEYS */;
INSERT INTO `notas_saida` VALUES (1,1,'2012-02-10'),(2,2,'2012-05-09');
/*!40000 ALTER TABLE `notas_saida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produto`
--

DROP TABLE IF EXISTS `produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produto` (
  `cd_produto` int(11) NOT NULL,
  `cd_categoria` int(11) NOT NULL,
  `nm_produto` varchar(100) NOT NULL,
  `qt_estoque` int(11) NOT NULL,
  PRIMARY KEY (`cd_produto`),
  KEY `fk_produto_categoria` (`cd_categoria`),
  CONSTRAINT `fk_produto_categoria` FOREIGN KEY (`cd_categoria`) REFERENCES `categoria` (`cd_categoria`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produto`
--

LOCK TABLES `produto` WRITE;
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` VALUES (1,1,'SABÃO EM PÓ',189),(2,1,'ALVEJANTE',1000),(3,1,'DETERGENTE',400),(4,1,'BOMBRIL',200),(5,2,'LEITE',556),(6,2,'BOLACHA REDONDA MABEL',211),(7,2,'MACARRÃO',222),(8,3,'CERA PARA POLIMENTO RÁPIDO',322),(9,3,'SACO DE ESTOPA',2111),(10,3,'SILICONE LÍQUIDO',98);
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-09-29 10:42:26
