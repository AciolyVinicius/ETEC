SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `mydb` ;
create table if not exists `mydb`.`tb_adm` (
cd_adm int not null auto_increment,
nm_adm varchar(100) null,
cd_email varchar(100) NOT NULL,
cd_senha varchar (100) NOT NULL,
CONSTRAINT pk_adm
	PRIMARY KEY (cd_adm));
-- -----------------------------------------------------
-- Table `mydb`.`tb_tipo_socio`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`tb_tipo_socio` (
  `cd_tipo_socio` INT(11) NOT NULL AUTO_INCREMENT,
  `ds_tipo_socio` TEXT NULL COMMENT 'Se é titular ou dependente\n' ,
  PRIMARY KEY (`cd_tipo_socio`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`tb_socio`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`tb_socio` (
  `cd_socio` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_tipo_socio` INT(11) NULL ,
  `nm_socio` VARCHAR(100) NULL ,
  PRIMARY KEY (`cd_socio`) ,
  INDEX `fk_tipo_socio_socio_idx` (`cd_tipo_socio` ASC) ,
  CONSTRAINT `fk_socio_tipo_socio`
    FOREIGN KEY (`cd_tipo_socio` )
    REFERENCES `mydb`.`tb_tipo_socio` (`cd_tipo_socio` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`tb_vendedor`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`tb_vendedor` (
  `cd_vendedor` INT(11) NOT NULL AUTO_INCREMENT,
  `nm_vendedor` VARCHAR(100) NULL ,
  PRIMARY KEY (`cd_vendedor`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`tb_titulo`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`tb_titulo` (
  `cd_titulo` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_socio` INT(11) NULL ,
  `cd_vendedor` INT(11) NULL ,
  `dt_venda` DATE NOT NULL,
  `ds_titulo` TEXT NULL ,
  `vl_comissao` DECIMAL(9,2) NULL ,
  `qt_parcelamento` INT(4) NULL ,
  `vl_parcela` DECIMAL(9,2) NULL ,
  `vl_joia_avista` DECIMAL(9,2) NULL ,
  `vl_manutencao` DECIMAL(9,2) NULL ,
  INDEX `fk_titulo_socio_idx` (`cd_socio` ASC) ,
  INDEX `fk_titulo_vendedor_idx` (`cd_vendedor` ASC) ,
  PRIMARY KEY (`cd_titulo`) ,
  CONSTRAINT `fk_titulo_socio`
    FOREIGN KEY (`cd_socio` )
    REFERENCES `mydb`.`tb_socio` (`cd_socio` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_titulo_vendedor`
    FOREIGN KEY (`cd_vendedor` )
    REFERENCES `mydb`.`tb_vendedor` (`cd_vendedor` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`tb_parcela_joia`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`tb_parcela_joia` (
  `cd_titulo` INT(11) NULL AUTO_INCREMENT,
  `cd_parcela_mes` INT(6) NULL COMMENT 'cd_parcela irá definir qual o mes da parcela\n' ,
  `ic_pagamento` TINYINT(1) NULL ,
  `cd_parcela_ano` YEAR NULL ,
  INDEX `fk_mensalidade_titulo` (`cd_titulo` ASC) ,
  CONSTRAINT `fk_mensalidade_titulo`
    FOREIGN KEY (`cd_titulo` )
    REFERENCES `mydb`.`tb_titulo` (`cd_titulo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`tb_manutencao`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `mydb`.`tb_manutencao` (
  `cd_titulo` INT(11) NULL AUTO_INCREMENT,
  `cd_mes` INT(6) NULL ,
  `ic_pagamento` TINYINT(1) NULL ,
  `cd_ano` YEAR NULL ,
  INDEX `fk_manutencao_titulo_idx` (`cd_titulo` ASC) ,
  CONSTRAINT `fk_manutencao_titulo`
    FOREIGN KEY (`cd_titulo` )
    REFERENCES `mydb`.`tb_titulo` (`cd_titulo` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `mydb` ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
