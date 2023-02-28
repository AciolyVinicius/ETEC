-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.5.35-MariaDB


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

--
-- Create schema db_pedido_etim
--

CREATE DATABASE IF NOT EXISTS db_pedido_3i2;
USE db_pedido_3i2;

--
-- Definition of table `item_pedido`
--

DROP TABLE IF EXISTS `item_pedido`;
CREATE TABLE `item_pedido` (
  `cd_pedido` int(11) NOT NULL DEFAULT '0',
  `cd_produto` int(11) NOT NULL DEFAULT '0',
  `qt_produto` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`cd_pedido`,`cd_produto`),
  KEY `fk_item_produto` (`cd_produto`),
  CONSTRAINT `fk_item_pedido` FOREIGN KEY (`cd_pedido`) REFERENCES `tb_pedido` (`cd_pedido`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_item_produto` FOREIGN KEY (`cd_produto`) REFERENCES `tb_produto` (`cd_produto`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `item_pedido`
--

/*!40000 ALTER TABLE `item_pedido` DISABLE KEYS */;
INSERT INTO `item_pedido` (`cd_pedido`,`cd_produto`,`qt_produto`) VALUES 
 (91,77,'40.00'),
 (97,77,'20.00'),
 (98,77,'5.00'),
 (101,13,'5.00'),
 (101,31,'9.00'),
 (101,78,'18.00'),
 (103,53,'37.00'),
 (104,53,'32.00'),
 (105,78,'10.00'),
 (108,13,'17.00'),
 (111,25,'10.00'),
 (111,78,'70.00'),
 (119,13,'6.00'),
 (119,22,'10.00'),
 (119,53,'43.00'),
 (119,77,'40.00'),
 (121,25,'10.00'),
 (121,31,'35.00'),
 (137,13,'8.00'),
 (138,22,'10.00'),
 (138,53,'18.00'),
 (138,77,'35.00'),
 (143,31,'20.00'),
 (143,78,'10.00'),
 (148,25,'10.00'),
 (148,31,'7.00'),
 (148,45,'8.00'),
 (148,77,'3.00'),
 (148,78,'30.00'),
 (189,78,'45.00'),
 (203,31,'6.00');
/*!40000 ALTER TABLE `item_pedido` ENABLE KEYS */;


--
-- Definition of table `tb_cliente`
--

DROP TABLE IF EXISTS `tb_cliente`;
CREATE TABLE `tb_cliente` (
  `cd_cliente` int(11) NOT NULL,
  `nm_cliente` varchar(50) DEFAULT NULL,
  `nm_endereco` varchar(60) DEFAULT NULL,
  `nm_cidade` varchar(20) DEFAULT NULL,
  `cd_cep` char(8) DEFAULT NULL,
  `sg_uf` char(2) DEFAULT NULL,
  `cd_cnpj` char(14) DEFAULT NULL,
  PRIMARY KEY (`cd_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_cliente`
--

/*!40000 ALTER TABLE `tb_cliente` DISABLE KEYS */;
INSERT INTO `tb_cliente` (`cd_cliente`,`nm_cliente`,`nm_endereco`,`nm_cidade`,`cd_cep`,`sg_uf`,`cd_cnpj`) VALUES 
 (110,'Jorge','Rua Caiapo,13','Curitiba','30078500','PR','1451226498349'),
 (130,'Edmar','Rua da Praia sn/','Salvador','30078900','BA','234632842349'),
 (157,'Paulo','Tv. Morais c/3','Londrina',NULL,'PR','12736557123474'),
 (180,'Livio','Av Beira Mar n.1256','Florianopolis','30077500','SC','2176357102329'),
 (201,'Beth','Av. Climério n.45','São Paulo','25679300','SP','3284822303242'),
 (222,'Lucia','Rua Itabira 123 lj 9','Belo Horizonte','22124391','MG','2812525393488'),
 (234,'Jose','Quadra 3 bl. 3 sl. 1003','Brasília','22841650','DF','4887441212545'),
 (260,'Susana','Rua Lopes Mendes, 12','Niteroi','30046500','RJ','1578985223657'),
 (290,'Renato','Rua Meireles n. 123 bl2 sl 345','São Paulo','30225900','SP','7887414700019'),
 (390,'Sebastiao','Rua da Igreja n.10','Uberaba','30438700','MG','0212587401477'),
 (410,'Rodolfo','Largo da Lapa 27 Sobrado','Rio de Janeiro','30078900','RJ','1273657123469'),
 (720,'Ana','Rua 17 n. 19','Niteroi','24358310','RJ','12113231000134'),
 (830,'Mauricio','Av. Paulista 1236 sl/ 2345','São Paulo','30126083','SP','3281698574656'),
 (870,'Flávio','Av. Pres. Vargas, 10','São Paulo','22763931','SP','2253412693879');
/*!40000 ALTER TABLE `tb_cliente` ENABLE KEYS */;


--
-- Definition of table `tb_pedido`
--

DROP TABLE IF EXISTS `tb_pedido`;
CREATE TABLE `tb_pedido` (
  `cd_pedido` int(11) NOT NULL,
  `dt_pedido` date DEFAULT NULL,
  `qt_prazo_entrega` tinyint(4) DEFAULT NULL,
  `cd_cliente` int(11) DEFAULT NULL,
  `cd_vendedor` int(11) DEFAULT NULL,
  PRIMARY KEY (`cd_pedido`),
  KEY `fk_pedido_cliente` (`cd_cliente`),
  KEY `fk_pedido_vendedor` (`cd_vendedor`),
  CONSTRAINT `fk_pedido_cliente` FOREIGN KEY (`cd_cliente`) REFERENCES `tb_cliente` (`cd_cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_pedido_vendedor` FOREIGN KEY (`cd_vendedor`) REFERENCES `tb_vendedor` (`cd_vendedor`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_pedido`
--

/*!40000 ALTER TABLE `tb_pedido` DISABLE KEYS */;
INSERT INTO `tb_pedido` (`cd_pedido`,`dt_pedido`,`qt_prazo_entrega`,`cd_cliente`,`cd_vendedor`) VALUES 
 (91,'2012-03-07',20,260,11),
 (97,'2012-02-01',20,720,101),
 (98,'2011-12-12',20,410,310),
 (101,'2012-03-07',15,720,101),
 (103,'2012-02-01',20,260,11),
 (104,'2012-07-09',30,110,101),
 (105,'2011-12-13',15,180,240),
 (108,'2012-06-06',108,290,310),
 (111,'2012-02-01',20,260,240),
 (119,'2012-03-07',119,390,250),
 (121,'2012-02-01',20,410,310),
 (137,'2012-06-06',20,720,720),
 (138,'2012-06-06',20,260,11),
 (143,'2011-12-13',30,201,101),
 (148,'2012-06-06',20,720,101),
 (172,'2012-03-07',127,410,11),
 (189,'2012-06-06',15,870,213),
 (203,'2012-07-09',30,830,250);
/*!40000 ALTER TABLE `tb_pedido` ENABLE KEYS */;


--
-- Definition of table `tb_produto`
--

DROP TABLE IF EXISTS `tb_produto`;
CREATE TABLE `tb_produto` (
  `cd_produto` int(11) NOT NULL,
  `nm_produto` varchar(40) DEFAULT NULL,
  `sg_unidade` char(3) DEFAULT NULL,
  `vl_preco_unitario` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`cd_produto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_produto`
--

/*!40000 ALTER TABLE `tb_produto` DISABLE KEYS */;
INSERT INTO `tb_produto` (`cd_produto`,`nm_produto`,`sg_unidade`,`vl_preco_unitario`) VALUES 
 (13,'Ouro','G','6.18'),
 (22,'Linho','M','0.11'),
 (25,'Queijo','Kg','0.97'),
 (30,'Açucar','SAC','0.30'),
 (31,'Chocolate','BAR','0.87'),
 (45,'Madeira','M','0.25'),
 (53,'Linha','M','1.80'),
 (77,'Papel','M','1.05'),
 (78,'Vinho','L','2.00'),
 (87,'Cano','M','1.97');
/*!40000 ALTER TABLE `tb_produto` ENABLE KEYS */;


--
-- Definition of table `tb_vendedor`
--

DROP TABLE IF EXISTS `tb_vendedor`;
CREATE TABLE `tb_vendedor` (
  `cd_vendedor` int(11) NOT NULL,
  `nm_vendedor` varchar(50) DEFAULT NULL,
  `sg_comissao` char(1) DEFAULT NULL,
  `vl_salario` decimal(9,2) DEFAULT NULL,
  PRIMARY KEY (`cd_vendedor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_vendedor`
--

/*!40000 ALTER TABLE `tb_vendedor` DISABLE KEYS */;
INSERT INTO `tb_vendedor` (`cd_vendedor`,`nm_vendedor`,`sg_comissao`,`vl_salario`) VALUES 
 (11,'João','C','2780.00'),
 (101,'João Paulo','C','2650.00'),
 (213,'Jonas','A','2300.00'),
 (240,'Antonio','C','9500.00'),
 (250,'Maurício','B','2930.00'),
 (310,'Josias','B','870.00'),
 (720,'Felipe','A','4600.00'),
 (6789,'Antonomasia','A','2345.89'),
 (6790,'Astrogildo','C','7896.67');
/*!40000 ALTER TABLE `tb_vendedor` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
