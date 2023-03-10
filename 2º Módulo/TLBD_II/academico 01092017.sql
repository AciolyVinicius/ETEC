-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: academico 
-- ------------------------------------------------------
-- Server version	5.7.18-log
create database academico2i2;

use academico2i2;

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
-- Table structure for table `tb_aluno`
--

DROP TABLE IF EXISTS `tb_aluno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_aluno` (
  `cd_aluno` int(11) NOT NULL,
  `cd_cidade` int(11) NOT NULL,
  `nm_aluno` varchar(100) NOT NULL,
  `dt_nascimento` date NOT NULL,
  PRIMARY KEY (`cd_aluno`),
  KEY `fk_aluno_cidade` (`cd_cidade`),
  CONSTRAINT `fk_aluno_cidade` FOREIGN KEY (`cd_cidade`) REFERENCES `tb_cidade` (`cd_cidade`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_aluno`
--

LOCK TABLES `tb_aluno` WRITE;
/*!40000 ALTER TABLE `tb_aluno` DISABLE KEYS */;
INSERT INTO `tb_aluno` VALUES (1,1,'FERDINANDO SILVA','1980-08-10'),(2,1,'FLÁVIA DA SILVA','1980-03-21'),(3,2,'MAURO DE OLIVEIRA','1979-08-01'),(4,2,'VILMA DA COSTA FERNANDES','1987-09-04'),(5,2,'EDMILSON ANTUNES PRADO','1987-10-07'),(6,3,'ABEL VIRME SINTRA','1987-01-03'),(7,3,'BIANCA XAVIER DA COSTA','1986-04-09'),(8,3,'CIVUCA MARQUES BERTIOGA','1985-12-06'),(9,3,'DAVI SIQUEIRA DE SOUSA','1984-04-03'),(10,3,'ELISABETE DE SOUSA','1987-12-20'),(11,3,'ELEANDRO MANUEL VIEIRA','1979-07-14'),(12,4,'GIULIANO SILVA','1983-01-10'),(13,4,'GERMINÍA ANTÔNIA DA COSTA','1981-06-21'),(14,4,'HAROLDO SILVA MINEIRO','1983-11-11'),(15,4,'ÍTALO SELVA DE PEDRA','1984-07-27'),(16,5,'JANETE BELA DE SOUSA','1981-09-29'),(17,5,'JONAS COLMÉIA DA SILVA','1979-10-12'),(18,5,'KALIL ASSAF MORENO','1980-12-12'),(19,6,'LIANDRA FIFA GOUVEIA','1990-10-09'),(20,7,'LEONTINO MARQUES SANCHES','1978-07-07'),(21,7,'TINOCO CORTEZ','1976-09-09'),(22,8,'THAILE AMPARO DE CABRAL','1991-08-29'),(23,8,'JURANDIR PENA BRANCA','1991-11-29'),(24,9,'CAMILA HERMES PICLES','1990-03-11'),(25,9,'GETÚLIO FATIA CAMPRIANO','1990-05-05'),(26,9,'ARMELINDO SELVA DE PEDRA','1990-05-09'),(27,9,'WILSON GOUVEIA ANTUNES','1989-05-20'),(28,9,'GETÚLIO FATIA CAMPRIANO','1991-06-15'),(29,10,'APRAZIANO MONGOLO BOLA','1992-07-12'),(30,11,'ÉRICA SINTRA','1988-09-12'),(31,12,'MARILDO BULE SOUSA','1990-12-25'),(32,12,'SÍLVIO BELO BOUNCE','1993-04-25'),(33,12,'AMBRÓSIO SALVIANO SERENO','1992-11-28'),(34,13,'JUVENTINO PARAIBA NEGAÇÃO','1993-12-21'),(35,13,'PAULA FERRADURA SELCHES','1990-08-08'),(36,13,'PRISCILA CANDURA CLEMENTE','1993-11-12'),(37,14,'GLÁUCIA TEIXEIRA GOUVEIA','1991-11-13'),(38,14,'BROCA XAVEZ','1992-02-01'),(39,14,'ANITA ANA ARETA','1989-11-04'),(40,14,'NEIFRÁSIO GIBA JUNQUEIRA','1992-03-04');
/*!40000 ALTER TABLE `tb_aluno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_cidade`
--

DROP TABLE IF EXISTS `tb_cidade`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_cidade` (
  `cd_cidade` int(11) NOT NULL,
  `cd_uf` int(11) NOT NULL,
  `nm_cidade` varchar(100) NOT NULL,
  PRIMARY KEY (`cd_cidade`),
  KEY `fk_cidade_estados` (`cd_uf`),
  CONSTRAINT `fk_cidade_estados` FOREIGN KEY (`cd_uf`) REFERENCES `tb_estado` (`cd_uf`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_cidade`
--

LOCK TABLES `tb_cidade` WRITE;
/*!40000 ALTER TABLE `tb_cidade` DISABLE KEYS */;
INSERT INTO `tb_cidade` VALUES (1,1,'Votuporanga'),(2,1,'Santa Fé do Sul'),(3,1,'São Paulo'),(4,1,'Diadema'),(5,1,'São Bernardo do Campo'),(6,1,'Ribeirão Preto'),(7,2,'Várzea Grande'),(8,2,'Colíder'),(9,2,'Cuiabá'),(10,3,'Aparecida do Taboado'),(11,3,'Paranaíba'),(12,3,'Cassilândia'),(13,4,'Maringá'),(14,4,'Curitiba');
/*!40000 ALTER TABLE `tb_cidade` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_curso`
--

DROP TABLE IF EXISTS `tb_curso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_curso` (
  `cd_curso` int(11) NOT NULL,
  `nm_curso` varchar(100) NOT NULL,
  PRIMARY KEY (`cd_curso`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_curso`
--

LOCK TABLES `tb_curso` WRITE;
/*!40000 ALTER TABLE `tb_curso` DISABLE KEYS */;
INSERT INTO `tb_curso` VALUES (1,'ENGENHARIA DA COMPUTAÇÃO'),(2,'SISTEMAS DE INFORMAÇÃO'),(3,'DIREITO'),(4,'MEDICINA');
/*!40000 ALTER TABLE `tb_curso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_disciplina`
--

DROP TABLE IF EXISTS `tb_disciplina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_disciplina` (
  `cd_disciplina` int(11) NOT NULL,
  `nm_disciplina` varchar(150) NOT NULL,
  PRIMARY KEY (`cd_disciplina`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_disciplina`
--

LOCK TABLES `tb_disciplina` WRITE;
/*!40000 ALTER TABLE `tb_disciplina` DISABLE KEYS */;
INSERT INTO `tb_disciplina` VALUES (1,'BANCO DE DADOS'),(2,'HARDWARE'),(3,'DESENVOLVIMENTO WEB'),(4,'ANATOMIA I'),(5,'PATOLOGIAS II'),(6,'SEGURANÇA'),(7,'GENÉTICA'),(8,'DIREITO CONSTITUCIONAL'),(9,'DIREITO TRIBUTÁRIO');
/*!40000 ALTER TABLE `tb_disciplina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_estado`
--

DROP TABLE IF EXISTS `tb_estado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_estado` (
  `cd_uf` int(11) NOT NULL,
  `nm_uf` varchar(90) NOT NULL,
  `sg_uf` varchar(2) NOT NULL,
  PRIMARY KEY (`cd_uf`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_estado`
--

LOCK TABLES `tb_estado` WRITE;
/*!40000 ALTER TABLE `tb_estado` DISABLE KEYS */;
INSERT INTO `tb_estado` VALUES (1,'SÃO PAULO','SP'),(2,'MATO GROSSO','MT'),(3,'MATO GROSSO DO SUL','MS'),(4,'PARANÁ','PR');
/*!40000 ALTER TABLE `tb_estado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_matricula`
--

DROP TABLE IF EXISTS `tb_matricula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_matricula` (
  `cd_matricula` int(11) NOT NULL,
  `cd_turma` int(11) NOT NULL,
  `cd_aluno` int(11) NOT NULL,
  `cd_disciplina` int(11) NOT NULL,
  `dt_matricula` date NOT NULL,
  PRIMARY KEY (`cd_matricula`),
  KEY `fk_matricula_turma` (`cd_turma`),
  KEY `fk_matricula_aluno` (`cd_aluno`),
  KEY `fk_matricula_disciplina` (`cd_disciplina`),
  CONSTRAINT `fk_matricula_aluno` FOREIGN KEY (`cd_aluno`) REFERENCES `tb_aluno` (`cd_aluno`),
  CONSTRAINT `fk_matricula_disciplina` FOREIGN KEY (`cd_disciplina`) REFERENCES `tb_disciplina` (`cd_disciplina`),
  CONSTRAINT `fk_matricula_turma` FOREIGN KEY (`cd_turma`) REFERENCES `tb_turma` (`cd_turma`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_matricula`
--

LOCK TABLES `tb_matricula` WRITE;
/*!40000 ALTER TABLE `tb_matricula` DISABLE KEYS */;
INSERT INTO `tb_matricula` VALUES (110,1,1,2,'2012-02-10'),(111,1,2,2,'2012-02-10'),(112,1,3,2,'2012-02-10'),(113,1,4,2,'2012-02-12'),(114,1,5,2,'2012-02-12'),(115,1,6,2,'2012-02-20'),(116,1,7,2,'2012-02-20'),(117,1,8,2,'2012-02-20'),(118,1,9,2,'2012-02-10'),(119,1,10,2,'2012-02-11'),(120,2,11,3,'2012-02-10'),(121,2,12,3,'2012-02-10'),(122,2,13,3,'2012-02-10'),(123,2,14,3,'2012-02-12'),(124,2,15,3,'2012-02-12'),(125,2,16,3,'2012-02-20'),(126,2,17,3,'2012-02-20'),(127,2,18,3,'2012-02-20'),(128,2,19,3,'2012-02-10'),(129,2,20,3,'2012-02-11'),(130,3,21,6,'2012-02-10'),(131,3,22,6,'2012-02-10'),(132,3,23,6,'2012-02-10'),(133,3,24,6,'2012-02-12'),(134,3,25,6,'2012-02-12'),(135,3,26,6,'2012-02-20'),(136,3,27,6,'2012-02-20'),(137,3,28,6,'2012-02-20'),(138,3,29,6,'2012-02-10'),(139,3,30,6,'2012-02-11'),(140,4,31,4,'2012-02-10'),(141,4,32,4,'2012-02-10'),(142,4,33,4,'2012-02-10'),(143,4,34,4,'2012-02-12'),(144,4,35,4,'2012-02-12'),(145,4,36,4,'2012-02-20'),(146,4,37,4,'2012-02-20'),(147,4,38,4,'2012-02-20'),(148,4,39,4,'2012-02-10'),(149,4,40,4,'2012-02-11');
/*!40000 ALTER TABLE `tb_matricula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_turma`
--

DROP TABLE IF EXISTS `tb_turma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_turma` (
  `cd_turma` int(11) NOT NULL,
  `cd_turno` int(11) NOT NULL,
  `cd_curso` int(11) NOT NULL,
  `qt_serie` smallint(6) NOT NULL,
  `aa_ano` int(11) NOT NULL,
  PRIMARY KEY (`cd_turma`),
  KEY `fk_tuma_turno` (`cd_turno`),
  KEY `fk_turma_curso` (`cd_curso`),
  CONSTRAINT `fk_tuma_turno` FOREIGN KEY (`cd_turno`) REFERENCES `tb_turno` (`cd_turno`),
  CONSTRAINT `fk_turma_curso` FOREIGN KEY (`cd_curso`) REFERENCES `tb_curso` (`cd_curso`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_turma`
--

LOCK TABLES `tb_turma` WRITE;
/*!40000 ALTER TABLE `tb_turma` DISABLE KEYS */;
INSERT INTO `tb_turma` VALUES (1,3,1,1,2012),(2,2,2,3,2012),(3,3,1,3,2012),(4,3,4,1,2012);
/*!40000 ALTER TABLE `tb_turma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_turno`
--

DROP TABLE IF EXISTS `tb_turno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_turno` (
  `cd_turno` int(11) NOT NULL,
  `nm_turno` varchar(20) NOT NULL,
  PRIMARY KEY (`cd_turno`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_turno`
--

LOCK TABLES `tb_turno` WRITE;
/*!40000 ALTER TABLE `tb_turno` DISABLE KEYS */;
INSERT INTO `tb_turno` VALUES (1,'DIURNO'),(2,'NOTURNO'),(3,'INTEGRAL');
/*!40000 ALTER TABLE `tb_turno` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-09-01 15:05:52

show tables;

select * from tb_aluno;
select nm_aluno, dt_nascimento 
	from tb_aluno
		where dt_nascimento > '1980-01-01'
		and dt_nascimento < '1983-01-01'
		and cd_cidade = 1;

select nm_uf, sg_uf
	from tb_estado
		where sg_uf = 'SP';

select count(*)
	from tb_matricula
		where dt_matricula >= '2012-02-01'
		and dt_matricula <= '2012-02-10';


select *
	from tb_matricula
		where dt_matricula >= '2012-02-01'
		and dt_matricula <= '2012-02-10';


select nm_aluno as 'Nome do Aluno', dt_nascimento as 'Data de Nascimento',
		datediff('2017-09-01',dt_nascimento) as 'Dias' 
			from tb_aluno;

select nm_aluno as 'Nome do Aluno', dt_nascimento as 'Data de Nascimento',
		datediff('2017-09-01',dt_nascimento) as 'Dias' 
			from tb_aluno;

select nm_aluno as 'Nome do Aluno', dt_nascimento as 'Data de Nascimento',
		datediff('2017-09-01',dt_nascimento) as Dias,
		datediff('2017-09-01',dt_nascimento) / 365 as 'Anos de Idade',
		datediff(curdate(),dt_nascimento) / 7 as Semanas, -- curdate vem de *current_day, pega o dia atual
		day (dt_nascimento) as Dia,
		month (dt_nascimento) as Mês,
		year (dt_nascimento) as Ano,
		dayofweek(dt_nascimento) as 'Dia da Semana'
			from tb_aluno;
