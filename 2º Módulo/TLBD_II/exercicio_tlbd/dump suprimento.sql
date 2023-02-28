CREATE DATABASE  IF NOT EXISTS `db_suprimentos` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `db_suprimentos`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: db_suprimentos
-- ------------------------------------------------------
-- Server version	5.6.36

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
-- Table structure for table `item_orcamento`
--

DROP TABLE IF EXISTS `item_orcamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `item_orcamento` (
  `id_numero_orcamento` int(11) NOT NULL DEFAULT '0',
  `id_numero_item_orcamento` int(11) NOT NULL DEFAULT '0',
  `cd_produto` int(11) DEFAULT NULL,
  `sg_unidade_produto` char(2) DEFAULT NULL,
  `qt_produto` decimal(9,2) DEFAULT NULL,
  `vl_produto` decimal(9,2) DEFAULT NULL,
  `vl_total_produto` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`id_numero_orcamento`,`id_numero_item_orcamento`),
  KEY `cd_produto` (`cd_produto`),
  CONSTRAINT `item_orcamento_ibfk_1` FOREIGN KEY (`cd_produto`) REFERENCES `tb_produto` (`cd_produto`),
  CONSTRAINT `item_orcamento_ibfk_2` FOREIGN KEY (`id_numero_orcamento`) REFERENCES `tb_orcamento` (`id_numero_orcamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_orcamento`
--

LOCK TABLES `item_orcamento` WRITE;
/*!40000 ALTER TABLE `item_orcamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `item_orcamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item_pedido`
--

DROP TABLE IF EXISTS `item_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `item_pedido` (
  `id_numero_pedido` int(11) NOT NULL DEFAULT '0',
  `id_numero_item_pedido` int(11) NOT NULL DEFAULT '0',
  `cd_produto` int(11) DEFAULT NULL,
  `qt_produto` decimal(9,2) DEFAULT NULL,
  `vl_produto` decimal(9,2) DEFAULT NULL,
  `vl_total_produto` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`id_numero_pedido`,`id_numero_item_pedido`),
  KEY `cd_produto` (`cd_produto`),
  CONSTRAINT `item_pedido_ibfk_1` FOREIGN KEY (`id_numero_pedido`) REFERENCES `tb_pedido` (`id_numero_pedido`),
  CONSTRAINT `item_pedido_ibfk_2` FOREIGN KEY (`id_numero_pedido`) REFERENCES `tb_pedido` (`id_numero_pedido`),
  CONSTRAINT `item_pedido_ibfk_3` FOREIGN KEY (`id_numero_pedido`) REFERENCES `tb_pedido` (`id_numero_pedido`),
  CONSTRAINT `item_pedido_ibfk_4` FOREIGN KEY (`cd_produto`) REFERENCES `tb_produto` (`cd_produto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_pedido`
--

LOCK TABLES `item_pedido` WRITE;
/*!40000 ALTER TABLE `item_pedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `item_pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item_suprimento`
--

DROP TABLE IF EXISTS `item_suprimento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `item_suprimento` (
  `id_numero_suprimento` int(11) NOT NULL DEFAULT '0',
  `id_numero_item_suprimento` int(11) NOT NULL DEFAULT '0',
  `cd_produto` int(11) NOT NULL DEFAULT '0',
  `qt_produto` decimal(9,2) DEFAULT NULL,
  `vl_total_produto` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`id_numero_suprimento`,`id_numero_item_suprimento`,`cd_produto`),
  KEY `cd_produto` (`cd_produto`),
  CONSTRAINT `item_suprimento_ibfk_1` FOREIGN KEY (`id_numero_suprimento`) REFERENCES `tb_suprimento` (`id_numero_suprimento`),
  CONSTRAINT `item_suprimento_ibfk_2` FOREIGN KEY (`id_numero_suprimento`) REFERENCES `tb_suprimento` (`id_numero_suprimento`),
  CONSTRAINT `item_suprimento_ibfk_3` FOREIGN KEY (`cd_produto`) REFERENCES `tb_produto` (`cd_produto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_suprimento`
--

LOCK TABLES `item_suprimento` WRITE;
/*!40000 ALTER TABLE `item_suprimento` DISABLE KEYS */;
/*!40000 ALTER TABLE `item_suprimento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item_venda`
--

DROP TABLE IF EXISTS `item_venda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `item_venda` (
  `id_numero_venda` int(11) NOT NULL DEFAULT '0',
  `id_numero_item_venda` int(11) NOT NULL DEFAULT '0',
  `cd_produto` int(11) DEFAULT NULL,
  `ds_produto` varchar(80) DEFAULT NULL,
  `cd_origem_produto` char(1) DEFAULT NULL,
  `cd_tributacao` char(1) DEFAULT NULL,
  `sg_unidade_produto` char(2) DEFAULT NULL,
  `qt_produto` decimal(9,2) DEFAULT NULL,
  `vl_produto` decimal(9,2) DEFAULT NULL,
  `vl_total_produto` decimal(9,2) DEFAULT NULL,
  `pc_aliquota_imposto` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`id_numero_venda`,`id_numero_item_venda`),
  KEY `cd_produto` (`cd_produto`),
  CONSTRAINT `item_venda_ibfk_1` FOREIGN KEY (`cd_produto`) REFERENCES `tb_produto` (`cd_produto`),
  CONSTRAINT `item_venda_ibfk_2` FOREIGN KEY (`id_numero_venda`) REFERENCES `tb_venda` (`id_numero_venda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_venda`
--

LOCK TABLES `item_venda` WRITE;
/*!40000 ALTER TABLE `item_venda` DISABLE KEYS */;
INSERT INTO `item_venda` VALUES (1,1,1,'CHOCOLATE','0','0','KG',1.00,12.00,12.00,15.00),(1,2,2,'CAFE','0','0','PT',1.00,7.00,7.00,15.00),(1,3,3,'VINHO','0','0','GF',2.00,40.00,80.00,15.00),(1,4,4,'LICOR','0','0','GF',1.00,18.00,18.00,15.00),(2,1,6,'GELADEIRA','0','0','UN',1.00,900.00,900.00,15.00),(3,1,9,'TELEVISOR','0','0','UN',1.00,1200.00,1200.00,15.00),(4,1,2,'CAFE','0','0','PT',1.00,7.00,7.00,15.00),(5,1,9,'TELEVISOR','0','0','UN',1.00,1200.00,1200.00,15.00);
/*!40000 ALTER TABLE `item_venda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_caixa`
--

DROP TABLE IF EXISTS `tb_caixa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_caixa` (
  `id_numero_caixa` int(11) NOT NULL,
  `cd_numero_serie` char(10) DEFAULT NULL,
  PRIMARY KEY (`id_numero_caixa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_caixa`
--

LOCK TABLES `tb_caixa` WRITE;
/*!40000 ALTER TABLE `tb_caixa` DISABLE KEYS */;
INSERT INTO `tb_caixa` VALUES (1,'1111111111'),(2,'2222222222');
/*!40000 ALTER TABLE `tb_caixa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_catalogo`
--

DROP TABLE IF EXISTS `tb_catalogo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_catalogo` (
  `id_numero_fornecedor` int(11) NOT NULL DEFAULT '0',
  `cd_produto` int(11) NOT NULL DEFAULT '0',
  `vl_produto` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`id_numero_fornecedor`,`cd_produto`),
  KEY `cd_produto` (`cd_produto`),
  CONSTRAINT `tb_catalogo_ibfk_1` FOREIGN KEY (`id_numero_fornecedor`) REFERENCES `tb_fornecedor` (`id_numero_fornecedor`),
  CONSTRAINT `tb_catalogo_ibfk_2` FOREIGN KEY (`id_numero_fornecedor`) REFERENCES `tb_fornecedor` (`id_numero_fornecedor`),
  CONSTRAINT `tb_catalogo_ibfk_3` FOREIGN KEY (`cd_produto`) REFERENCES `tb_produto` (`cd_produto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_catalogo`
--

LOCK TABLES `tb_catalogo` WRITE;
/*!40000 ALTER TABLE `tb_catalogo` DISABLE KEYS */;
INSERT INTO `tb_catalogo` VALUES (1,1,8.00),(1,2,4.50),(1,3,28.00),(1,4,12.00),(1,5,2.80),(2,6,600.00),(3,1,7.50),(3,2,4.00),(3,3,27.00),(3,4,13.00),(3,5,2.50),(3,6,850.00),(3,10,3.50);
/*!40000 ALTER TABLE `tb_catalogo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_consumidor`
--

DROP TABLE IF EXISTS `tb_consumidor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_consumidor` (
  `id_numero_consumidor` int(11) NOT NULL,
  `sg_tipo_consumirdor` char(1) DEFAULT NULL,
  `nm_consumidor` char(60) DEFAULT NULL,
  `sg_sexo` char(1) DEFAULT NULL,
  `nm_estado_civil` varchar(10) DEFAULT NULL,
  `cd_inscricao_municipal` char(14) DEFAULT NULL,
  `cd_inscricao_estadual` char(14) DEFAULT NULL,
  `cd_inscricao_federal` char(14) DEFAULT NULL,
  `nm_logradouro` varchar(50) DEFAULT NULL,
  `nm_bairro` varchar(50) DEFAULT NULL,
  `nm_cidade` varchar(50) DEFAULT NULL,
  `sg_uf` char(2) DEFAULT NULL,
  `cd_cep` char(8) DEFAULT NULL,
  `cd_telefone_residencial` char(14) DEFAULT NULL,
  `cd_telefone_comercial` char(14) DEFAULT NULL,
  `cd_telefone_celular` char(14) DEFAULT NULL,
  `nm_email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_numero_consumidor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_consumidor`
--

LOCK TABLES `tb_consumidor` WRITE;
/*!40000 ALTER TABLE `tb_consumidor` DISABLE KEYS */;
INSERT INTO `tb_consumidor` VALUES (1,'F','ZE COMPRA TUDO','M','CASADO',NULL,NULL,NULL,'LOGRADOURO','BAIRRO','CIDADE','UF','00000000',NULL,NULL,NULL,NULL),(2,'F','ANTONIO FALIDO','M','SOLTEIRO',NULL,NULL,NULL,'LOGRADOURO','BAIRRO','CIDADE','UF','00000000',NULL,NULL,NULL,NULL),(3,'F','MARIA FIADO','F','SOLTEIRA',NULL,NULL,NULL,'LOGRADOURO','BAIRRO','CIDADE','UF','00000000',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `tb_consumidor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_conta_pagar`
--

DROP TABLE IF EXISTS `tb_conta_pagar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_conta_pagar` (
  `id_numero_conta_pagar` int(11) NOT NULL,
  `id_numero_suprimento` int(11) DEFAULT NULL,
  `dt_conta` date DEFAULT NULL,
  `vl_conta` decimal(9,2) DEFAULT NULL,
  `dt_vencimento` date DEFAULT NULL,
  `dt_pagamento` date DEFAULT NULL,
  PRIMARY KEY (`id_numero_conta_pagar`),
  KEY `id_numero_suprimento` (`id_numero_suprimento`),
  CONSTRAINT `tb_conta_pagar_ibfk_1` FOREIGN KEY (`id_numero_suprimento`) REFERENCES `tb_suprimento` (`id_numero_suprimento`),
  CONSTRAINT `tb_conta_pagar_ibfk_2` FOREIGN KEY (`id_numero_suprimento`) REFERENCES `tb_suprimento` (`id_numero_suprimento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_conta_pagar`
--

LOCK TABLES `tb_conta_pagar` WRITE;
/*!40000 ALTER TABLE `tb_conta_pagar` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_conta_pagar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_conta_receber`
--

DROP TABLE IF EXISTS `tb_conta_receber`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_conta_receber` (
  `id_numero_conta_receber` int(11) NOT NULL,
  `id_numero_venda` int(11) DEFAULT NULL,
  `dt_conta` date DEFAULT NULL,
  `vl_conta` decimal(9,2) DEFAULT NULL,
  `dt_vencimento` date DEFAULT NULL,
  `dt_recebimento` date DEFAULT NULL,
  PRIMARY KEY (`id_numero_conta_receber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_conta_receber`
--

LOCK TABLES `tb_conta_receber` WRITE;
/*!40000 ALTER TABLE `tb_conta_receber` DISABLE KEYS */;
INSERT INTO `tb_conta_receber` VALUES (1,5,'2005-06-13',300.00,'2005-07-13',NULL),(2,5,'2005-06-13',300.00,'2005-08-13',NULL),(3,5,'2005-06-13',300.00,'2005-09-13',NULL),(4,5,'2005-06-13',300.00,'2005-10-13',NULL);
/*!40000 ALTER TABLE `tb_conta_receber` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_depto`
--

DROP TABLE IF EXISTS `tb_depto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_depto` (
  `id_numero_depto` int(11) NOT NULL,
  `nm_depto` varchar(50) DEFAULT NULL,
  `id_numero_depto_superior` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_numero_depto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_depto`
--

LOCK TABLES `tb_depto` WRITE;
/*!40000 ALTER TABLE `tb_depto` DISABLE KEYS */;
INSERT INTO `tb_depto` VALUES (1,'GERAL',NULL),(2,'MATERIAL',2),(3,'SERVICOS',1),(21,'ALIMENTOS',2),(22,'BEBIDAS',2),(23,'LIMPEZA',2),(24,'ELETRICOS',2),(31,'MANUTENCAO',3),(32,'SUPORTE',3);
/*!40000 ALTER TABLE `tb_depto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_fornecedor`
--

DROP TABLE IF EXISTS `tb_fornecedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_fornecedor` (
  `id_numero_fornecedor` int(11) NOT NULL,
  `sg_tipo_fornecedor` char(1) DEFAULT NULL,
  `nm_fornecedor` varchar(60) DEFAULT NULL,
  `sg_sexo` char(1) DEFAULT NULL,
  `cd_inscricao_municipal` char(14) DEFAULT NULL,
  `cd_inscricao_estadual` char(14) DEFAULT NULL,
  `cd_inscricao_federal` char(14) DEFAULT NULL,
  `nm_logradouro` varchar(50) DEFAULT NULL,
  `nm_bairro` varchar(50) DEFAULT NULL,
  `nm_cidade` varchar(50) DEFAULT NULL,
  `sg_uf` char(2) DEFAULT NULL,
  `cd_cep` char(8) DEFAULT NULL,
  `cd_telefone_residencial` char(14) DEFAULT NULL,
  `cd_telefone_comercial` char(14) DEFAULT NULL,
  `cd_telefone_celular` char(14) DEFAULT NULL,
  `nm_email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_numero_fornecedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_fornecedor`
--

LOCK TABLES `tb_fornecedor` WRITE;
/*!40000 ALTER TABLE `tb_fornecedor` DISABLE KEYS */;
INSERT INTO `tb_fornecedor` VALUES (1,'J','EMPORIO SUSPEITO',NULL,NULL,NULL,NULL,'LOGRADOURO','BAIRRO','CIDADE','UF','00000000',NULL,NULL,NULL,NULL),(2,'A','ELETRO S/A',NULL,NULL,NULL,NULL,'LOGRADOURO','BAIRRO','CIDADE','UF','00000000',NULL,NULL,NULL,NULL),(3,'J','ARMAZEM ESCONDIDO',NULL,NULL,NULL,NULL,'LOGRADOURO','BAIRRO','CIDADE','UF','00000000',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `tb_fornecedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_moeda`
--

DROP TABLE IF EXISTS `tb_moeda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_moeda` (
  `cd_moeda` int(11) NOT NULL,
  `ds_moeda` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`cd_moeda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_moeda`
--

LOCK TABLES `tb_moeda` WRITE;
/*!40000 ALTER TABLE `tb_moeda` DISABLE KEYS */;
INSERT INTO `tb_moeda` VALUES (1,'DINHEIRO'),(2,'CHEQUE'),(3,'CARTAO'),(4,'OUTRA');
/*!40000 ALTER TABLE `tb_moeda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_nota_fiscal`
--

DROP TABLE IF EXISTS `tb_nota_fiscal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_nota_fiscal` (
  `id_numero_venda` int(11) NOT NULL,
  `dt_nota` date DEFAULT NULL,
  `nm_transportadora` varchar(50) DEFAULT NULL,
  `nm_tipo_transporte` varchar(9) DEFAULT NULL,
  `qt_peso_bruto_produto` decimal(9,2) DEFAULT NULL,
  `qt_peso_liquido_produto` decimal(9,2) DEFAULT NULL,
  `nm_embalagem` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_numero_venda`),
  CONSTRAINT `tb_nota_fiscal_ibfk_1` FOREIGN KEY (`id_numero_venda`) REFERENCES `tb_venda` (`id_numero_venda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_nota_fiscal`
--

LOCK TABLES `tb_nota_fiscal` WRITE;
/*!40000 ALTER TABLE `tb_nota_fiscal` DISABLE KEYS */;
INSERT INTO `tb_nota_fiscal` VALUES (2,'2005-06-14','O PROPRIO','TERRESTRE',80.00,70.00,'CAIXA-MADEIRA'),(3,'2005-06-14','O PROPRIO','TERRESTRE',5.00,4.00,'CAIXA-PAPELAO'),(5,'2005-06-14','A PROPRIA','TERRESTRE',5.00,4.00,'CAIXA-PAPELAO');
/*!40000 ALTER TABLE `tb_nota_fiscal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_orcamento`
--

DROP TABLE IF EXISTS `tb_orcamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_orcamento` (
  `id_numero_orcamento` int(11) NOT NULL,
  `id_numero_consumidor` int(11) DEFAULT NULL,
  `id_numero_vendedor` int(11) DEFAULT NULL,
  `dt_orcamento` date DEFAULT NULL,
  `vl_orcamento` decimal(9,2) DEFAULT NULL,
  `qt_prazo_validade` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_numero_orcamento`),
  KEY `id_numero_vendedor` (`id_numero_vendedor`),
  KEY `id_numero_consumidor` (`id_numero_consumidor`),
  CONSTRAINT `tb_orcamento_ibfk_1` FOREIGN KEY (`id_numero_vendedor`) REFERENCES `tb_vendedor` (`id_numero_vendedor`),
  CONSTRAINT `tb_orcamento_ibfk_2` FOREIGN KEY (`id_numero_consumidor`) REFERENCES `tb_consumidor` (`id_numero_consumidor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_orcamento`
--

LOCK TABLES `tb_orcamento` WRITE;
/*!40000 ALTER TABLE `tb_orcamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_orcamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pagamento`
--

DROP TABLE IF EXISTS `tb_pagamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_pagamento` (
  `id_numero_conta_pagar` int(11) NOT NULL DEFAULT '0',
  `cd_moeda` int(11) NOT NULL DEFAULT '0',
  `nm_favorecido` varchar(60) DEFAULT NULL,
  `nm_historico` varchar(80) DEFAULT NULL,
  `vl_pagamento` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`id_numero_conta_pagar`,`cd_moeda`),
  KEY `cd_moeda` (`cd_moeda`),
  CONSTRAINT `tb_pagamento_ibfk_1` FOREIGN KEY (`id_numero_conta_pagar`) REFERENCES `tb_conta_pagar` (`id_numero_conta_pagar`),
  CONSTRAINT `tb_pagamento_ibfk_2` FOREIGN KEY (`cd_moeda`) REFERENCES `tb_moeda` (`cd_moeda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pagamento`
--

LOCK TABLES `tb_pagamento` WRITE;
/*!40000 ALTER TABLE `tb_pagamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_pagamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pedido`
--

DROP TABLE IF EXISTS `tb_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_pedido` (
  `id_numero_pedido` int(11) NOT NULL,
  `id_numero_fornecedor` int(11) DEFAULT NULL,
  `id_numero_vendedor` int(11) DEFAULT NULL,
  `dt_pedido` date DEFAULT NULL,
  `vl_pedido` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`id_numero_pedido`),
  KEY `id_numero_fornecedor` (`id_numero_fornecedor`),
  KEY `id_numero_vendedor` (`id_numero_vendedor`),
  CONSTRAINT `tb_pedido_ibfk_1` FOREIGN KEY (`id_numero_fornecedor`) REFERENCES `tb_fornecedor` (`id_numero_fornecedor`),
  CONSTRAINT `tb_pedido_ibfk_2` FOREIGN KEY (`id_numero_vendedor`) REFERENCES `tb_vendedor` (`id_numero_vendedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pedido`
--

LOCK TABLES `tb_pedido` WRITE;
/*!40000 ALTER TABLE `tb_pedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_posicao_caixa`
--

DROP TABLE IF EXISTS `tb_posicao_caixa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_posicao_caixa` (
  `id_numero_caixa` int(11) NOT NULL DEFAULT '0',
  `cd_moeda` int(11) NOT NULL DEFAULT '0',
  `dt_movimento` date NOT NULL DEFAULT '0000-00-00',
  `vl_caixa` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`id_numero_caixa`,`cd_moeda`,`dt_movimento`),
  KEY `cd_moeda` (`cd_moeda`),
  CONSTRAINT `tb_posicao_caixa_ibfk_1` FOREIGN KEY (`id_numero_caixa`) REFERENCES `tb_venda` (`id_numero_caixa`),
  CONSTRAINT `tb_posicao_caixa_ibfk_2` FOREIGN KEY (`cd_moeda`) REFERENCES `tb_moeda` (`cd_moeda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_posicao_caixa`
--

LOCK TABLES `tb_posicao_caixa` WRITE;
/*!40000 ALTER TABLE `tb_posicao_caixa` DISABLE KEYS */;
INSERT INTO `tb_posicao_caixa` VALUES (1,1,'2005-06-13',124.00),(1,2,'2005-06-13',900.00),(2,2,'2005-06-13',1200.00);
/*!40000 ALTER TABLE `tb_posicao_caixa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_produto`
--

DROP TABLE IF EXISTS `tb_produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_produto` (
  `cd_produto` int(11) NOT NULL,
  `id_numero_depto` int(11) DEFAULT NULL,
  `sg_tipo_produto` char(1) DEFAULT NULL,
  `ds_produto` varchar(80) DEFAULT NULL,
  `cd_origem_produto` char(1) DEFAULT NULL,
  `cd_tributacao` char(1) DEFAULT NULL,
  `sg_unidade_produto` char(2) DEFAULT NULL,
  `vl_medio_compra` decimal(9,2) DEFAULT NULL,
  `pc_aliquota_imposto` decimal(5,2) DEFAULT NULL,
  `vl_produto` decimal(9,2) DEFAULT NULL,
  `qt_estoque` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`cd_produto`),
  UNIQUE KEY `conix01_produto` (`ds_produto`),
  KEY `id_numero_depto` (`id_numero_depto`),
  CONSTRAINT `tb_produto_ibfk_1` FOREIGN KEY (`id_numero_depto`) REFERENCES `tb_depto` (`id_numero_depto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_produto`
--

LOCK TABLES `tb_produto` WRITE;
/*!40000 ALTER TABLE `tb_produto` DISABLE KEYS */;
INSERT INTO `tb_produto` VALUES (1,21,'M','CHOCOLATE','0','0','KG',10.00,15.00,12.00,80.00),(2,21,'M','CAFE','0','0','PT',5.00,15.00,7.00,30.00),(3,22,'M','VINHO','0','0','GF',30.00,15.00,40.00,20.00),(4,22,'M','LICOR','0','0','GF',15.00,15.00,18.00,100.00),(5,23,'M','DETERGENTE','0','0','LT',4.00,15.00,18.00,150.00),(6,24,'M','GELADEIRA','0','0','UN',800.00,15.00,900.00,5.00),(7,31,'S','CONSERTO','0','0','HO',0.00,5.00,25.00,0.00),(8,32,'S','VISITA','0','0','HO',0.00,5.00,50.00,0.00),(9,24,'M','TELEVISOR','0','0','UN',1000.00,15.00,1200.00,10.00),(10,23,'M','SABAO','0','0','KG',5.00,15.00,7.00,120.00);
/*!40000 ALTER TABLE `tb_produto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_recebimento`
--

DROP TABLE IF EXISTS `tb_recebimento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_recebimento` (
  `id_numero_conta_receber` int(11) NOT NULL DEFAULT '0',
  `cd_moeda` int(11) NOT NULL DEFAULT '0',
  `nm_favorecido` varchar(60) DEFAULT NULL,
  `nm_historico` varchar(80) DEFAULT NULL,
  `vl_recenimento` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`id_numero_conta_receber`,`cd_moeda`),
  KEY `cd_moeda` (`cd_moeda`),
  CONSTRAINT `tb_recebimento_ibfk_1` FOREIGN KEY (`id_numero_conta_receber`) REFERENCES `tb_conta_receber` (`id_numero_conta_receber`),
  CONSTRAINT `tb_recebimento_ibfk_2` FOREIGN KEY (`cd_moeda`) REFERENCES `tb_moeda` (`cd_moeda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_recebimento`
--

LOCK TABLES `tb_recebimento` WRITE;
/*!40000 ALTER TABLE `tb_recebimento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_recebimento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_reposicao`
--

DROP TABLE IF EXISTS `tb_reposicao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_reposicao` (
  `id_numero_suprimento` int(11) NOT NULL DEFAULT '0',
  `id_numero_item_suprimento` int(11) NOT NULL DEFAULT '0',
  `id_numero_pedido` int(11) NOT NULL DEFAULT '0',
  `id_numero_item_pedido` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_numero_suprimento`,`id_numero_item_suprimento`,`id_numero_pedido`,`id_numero_item_pedido`),
  KEY `id_numero_pedido` (`id_numero_pedido`,`id_numero_item_pedido`),
  CONSTRAINT `tb_reposicao_ibfk_1` FOREIGN KEY (`id_numero_pedido`, `id_numero_item_pedido`) REFERENCES `item_pedido` (`id_numero_pedido`, `id_numero_item_pedido`),
  CONSTRAINT `tb_reposicao_ibfk_2` FOREIGN KEY (`id_numero_suprimento`, `id_numero_item_suprimento`) REFERENCES `item_suprimento` (`id_numero_suprimento`, `id_numero_item_suprimento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_reposicao`
--

LOCK TABLES `tb_reposicao` WRITE;
/*!40000 ALTER TABLE `tb_reposicao` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_reposicao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_suprimento`
--

DROP TABLE IF EXISTS `tb_suprimento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_suprimento` (
  `id_numero_suprimento` int(11) NOT NULL,
  `dt_suprimento` date DEFAULT NULL,
  `sg_natureza_suprimento` char(1) DEFAULT NULL,
  `vl_suprimento` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`id_numero_suprimento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_suprimento`
--

LOCK TABLES `tb_suprimento` WRITE;
/*!40000 ALTER TABLE `tb_suprimento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_suprimento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_venda`
--

DROP TABLE IF EXISTS `tb_venda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_venda` (
  `id_numero_venda` int(11) NOT NULL,
  `id_numero_vendedor` int(11) DEFAULT NULL,
  `id_numero_caixa` int(11) DEFAULT NULL,
  `id_numero_consumidor` int(11) DEFAULT NULL,
  `sg_natureza_venda` char(1) DEFAULT NULL,
  `dt_venda` date DEFAULT NULL,
  `vl_venda` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`id_numero_venda`),
  KEY `id_numero_vendedor` (`id_numero_vendedor`),
  KEY `id_numero_caixa` (`id_numero_caixa`),
  KEY `id_numero_consumidor` (`id_numero_consumidor`),
  CONSTRAINT `tb_venda_ibfk_1` FOREIGN KEY (`id_numero_vendedor`) REFERENCES `tb_vendedor` (`id_numero_vendedor`),
  CONSTRAINT `tb_venda_ibfk_2` FOREIGN KEY (`id_numero_caixa`) REFERENCES `tb_caixa` (`id_numero_caixa`),
  CONSTRAINT `tb_venda_ibfk_3` FOREIGN KEY (`id_numero_consumidor`) REFERENCES `tb_consumidor` (`id_numero_consumidor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_venda`
--

LOCK TABLES `tb_venda` WRITE;
/*!40000 ALTER TABLE `tb_venda` DISABLE KEYS */;
INSERT INTO `tb_venda` VALUES (1,1,1,1,'V','2005-06-13',124.00),(2,1,1,1,'V','2005-06-13',900.00),(3,1,2,1,'V','2005-06-13',1200.00),(4,2,1,2,'V','2005-06-13',7.00),(5,1,2,3,'P','2005-06-13',1200.00);
/*!40000 ALTER TABLE `tb_venda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_vendedor`
--

DROP TABLE IF EXISTS `tb_vendedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_vendedor` (
  `id_numero_vendedor` int(11) NOT NULL,
  `nm_vendedor` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`id_numero_vendedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_vendedor`
--

LOCK TABLES `tb_vendedor` WRITE;
/*!40000 ALTER TABLE `tb_vendedor` DISABLE KEYS */;
INSERT INTO `tb_vendedor` VALUES (1,'JOAO VENDE TUDO'),(2,'JUCA QUASE PARANDO');
/*!40000 ALTER TABLE `tb_vendedor` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-07-18 10:34:11
