-- MySQL Script generated by MySQL Workbench
-- Mon Jun 18 22:17:23 2018
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema dbsaga
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema dbsaga
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `dbsaga` DEFAULT CHARACTER SET latin1 ;
USE `dbsaga` ;

-- -----------------------------------------------------
-- Table `dbsaga`.`tb_material`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_material` (
  `cd_material` INT(11) NOT NULL AUTO_INCREMENT,
  `nm_material` VARCHAR(100) NULL DEFAULT NULL,
  `ds_material` VARCHAR(255) NULL DEFAULT NULL,
  `im_anexo_material` BLOB NULL DEFAULT NULL,
  PRIMARY KEY (`cd_material`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_turno`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_turno` (
  `cd_turno` INT(11) NOT NULL AUTO_INCREMENT,
  `nm_turno` VARCHAR(100) NULL DEFAULT NULL,
  `ds_turno` VARCHAR(255) NULL DEFAULT NULL,
  `hr_inicio` TIME NULL DEFAULT NULL,
  `hr_final` TIME NULL DEFAULT NULL,
  PRIMARY KEY (`cd_turno`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_curso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_curso` (
  `cd_curso` INT(11) NOT NULL AUTO_INCREMENT,
  `nm_curso` VARCHAR(100) CHARACTER SET 'latin1' COLLATE 'latin1_bin' NULL DEFAULT NULL,
  `ds_curso` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_curso`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_turma`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_turma` (
  `cd_turma` INT(11) NOT NULL,
  `cd_turno` INT(11) NULL DEFAULT NULL,
  `cd_curso` INT(11) NULL DEFAULT NULL,
  `nm_turma` VARCHAR(100) NULL DEFAULT NULL,
  `ds_turma` VARCHAR(255) NULL DEFAULT NULL,
  `dt_inicio` DATE NULL DEFAULT NULL,
  `dt_final` DATE NULL DEFAULT NULL,
  `qt_capacidade` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_turma`),
  INDEX `turno_idx` (`cd_turno` ASC),
  INDEX `fk_turma_curso_idx` (`cd_curso` ASC),
  CONSTRAINT `fk_cdtt_item_turno`
    FOREIGN KEY (`cd_turno`)
    REFERENCES `dbsaga`.`tb_turno` (`cd_turno`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_turma_curso`
    FOREIGN KEY (`cd_curso`)
    REFERENCES `dbsaga`.`tb_curso` (`cd_curso`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`item_material_cdtt`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`item_material_cdtt` (
  `cd_material_cdtt` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_turma` INT(11) NOT NULL,
  `cd_material` INT(11) NOT NULL,
  PRIMARY KEY (`cd_material_cdtt`),
  INDEX `cdtt_idx` (`cd_turma` ASC),
  INDEX `material_idx` (`cd_material` ASC),
  CONSTRAINT `fk_cdtt_item_material`
    FOREIGN KEY (`cd_material`)
    REFERENCES `dbsaga`.`tb_material` (`cd_material`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_material_item_cdtt`
    FOREIGN KEY (`cd_turma`)
    REFERENCES `dbsaga`.`tb_turma` (`cd_turma`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_tipo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_tipo` (
  `cd_tipo` INT(11) NOT NULL,
  `nm_tipo` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_tipo`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_usuario` (
  `cd_usuario` INT(11) NOT NULL AUTO_INCREMENT,
  `nm_usuario` VARCHAR(150) NULL DEFAULT NULL,
  `nm_sobrenome` VARCHAR(150) NULL DEFAULT NULL,
  `dt_nascimento` DATE NULL DEFAULT NULL,
  `nm_email` VARCHAR(150) NULL DEFAULT NULL,
  `im_foto` VARCHAR(255) NULL DEFAULT NULL,
  `cd_cpf` VARCHAR(15) NULL DEFAULT NULL,
  `cd_rg` VARCHAR(15) NULL DEFAULT NULL,
  `cd_senha` VARCHAR(60) NULL DEFAULT NULL,
  `cd_contato1` VARCHAR(20) NULL DEFAULT NULL,
  `cd_contato2` VARCHAR(20) NULL DEFAULT NULL,
  `cd_cep` VARCHAR(20) NULL DEFAULT NULL,
  `nm_rua` VARCHAR(150) NULL DEFAULT NULL,
  `cd_numeracao` VARCHAR(8) NULL DEFAULT NULL,
  `nm_bairro` VARCHAR(100) NULL DEFAULT NULL,
  `nm_cidade` VARCHAR(100) NULL DEFAULT NULL,
  `nm_estado` VARCHAR(2) NULL DEFAULT NULL,
  `nm_responsavel` VARCHAR(150) NULL DEFAULT NULL,
  `cd_contato_responsavel` VARCHAR(20) NULL DEFAULT NULL,
  `nm_email_responsavel` VARCHAR(150) NULL DEFAULT NULL,
  `cd_cpf_responsavel` VARCHAR(20) NULL DEFAULT NULL,
  `cd_tipo` INT(11) NULL DEFAULT NULL,
  `cd_turma` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_usuario`),
  UNIQUE INDEX `email_UNIQUE` (`nm_email` ASC),
  UNIQUE INDEX `cpf_UNIQUE` (`cd_cpf` ASC),
  INDEX `fk_usuario_tipo` (`cd_tipo` ASC),
  INDEX `fk_usuario_turma` (`cd_turma` ASC),
  CONSTRAINT `fk_usuario_tipo`
    FOREIGN KEY (`cd_tipo`)
    REFERENCES `dbsaga`.`tb_tipo` (`cd_tipo`),
  CONSTRAINT `fk_usuario_turma`
    FOREIGN KEY (`cd_turma`)
    REFERENCES `dbsaga`.`tb_turma` (`cd_turma`))
ENGINE = InnoDB
AUTO_INCREMENT = 32
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_anotacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_anotacao` (
  `cd_anotacao` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_usuario` INT(11) NOT NULL,
  `nm_anotacao` VARCHAR(150) NULL DEFAULT NULL,
  `ds_anotacao` LONGTEXT NULL DEFAULT NULL,
  `dt_anotacao` DATE NULL DEFAULT NULL,
  PRIMARY KEY (`cd_anotacao`),
  INDEX `geral_usuario_idx` (`cd_usuario` ASC),
  CONSTRAINT `fk_anotacao_usuario`
    FOREIGN KEY (`cd_usuario`)
    REFERENCES `dbsaga`.`tb_usuario` (`cd_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_arquivo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_arquivo` (
  `cd_arquivo` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_usuario` INT(11) NOT NULL,
  `nm_arquivo` VARCHAR(150) NULL DEFAULT NULL,
  `ds_arquivo` VARCHAR(255) NULL DEFAULT NULL,
  `im_anexo_arquivo` BLOB NULL DEFAULT NULL,
  PRIMARY KEY (`cd_arquivo`),
  INDEX `usuario_idx` (`cd_usuario` ASC),
  CONSTRAINT `fk_arquivo_usuario`
    FOREIGN KEY (`cd_usuario`)
    REFERENCES `dbsaga`.`tb_usuario` (`cd_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_aula`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_aula` (
  `cd_aula` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_turma` INT(11) NOT NULL,
  `nm_aula` VARCHAR(150) NULL DEFAULT NULL,
  `dt_aula` DATE NULL DEFAULT NULL,
  `hr_inicio` DATETIME NULL DEFAULT NULL,
  `hr_final` DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (`cd_aula`),
  INDEX `cdtt_idx` (`cd_turma` ASC),
  CONSTRAINT `fk_aula_cdtt`
    FOREIGN KEY (`cd_turma`)
    REFERENCES `dbsaga`.`tb_turma` (`cd_turma`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_disciplina`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_disciplina` (
  `cd_disciplina` INT(11) NOT NULL AUTO_INCREMENT,
  `nm_disciplina` VARCHAR(150) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `ds_disciplina` VARCHAR(255) CHARACTER SET 'utf8' NULL DEFAULT NULL,
  `qt_carga_horaria` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_disciplina`))
ENGINE = InnoDB
AUTO_INCREMENT = 11
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`item_geral_usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`item_geral_usuario` (
  `cd_geral_usuario` INT NOT NULL,
  `cd_usuario` INT NULL,
  `cd_disciplina` INT NULL,
  PRIMARY KEY (`cd_geral_usuario`),
  INDEX `cd_usuario_idx` (`cd_usuario` ASC),
  INDEX `cd_disciplina_idx` (`cd_disciplina` ASC),
  CONSTRAINT `cd_usuario`
    FOREIGN KEY (`cd_usuario`)
    REFERENCES `dbsaga`.`tb_usuario` (`cd_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `cd_disciplina`
    FOREIGN KEY (`cd_disciplina`)
    REFERENCES `dbsaga`.`tb_disciplina` (`cd_disciplina`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_avaliacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_avaliacao` (
  `cd_avaliacao` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_geral_usuario` INT(11) NOT NULL,
  `nm_avaliacao` VARCHAR(150) NULL DEFAULT NULL,
  `ds_avaliacao` VARCHAR(255) NULL DEFAULT NULL,
  `dt_avaliacao` DATE NULL DEFAULT NULL,
  `cd_nota_avaliacao` VARCHAR(8) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_avaliacao`),
  INDEX `geral_usuario_idx` (`cd_geral_usuario` ASC),
  CONSTRAINT `cd_geral_usuario`
    FOREIGN KEY (`cd_geral_usuario`)
    REFERENCES `dbsaga`.`item_geral_usuario` (`cd_geral_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_aviso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_aviso` (
  `cd_aviso` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_curso` INT(11) NULL DEFAULT NULL,
  `cd_turma` INT(11) NULL DEFAULT NULL,
  `nm_aviso` VARCHAR(100) NULL DEFAULT NULL,
  `ds_aviso` LONGTEXT NULL DEFAULT NULL,
  `im_anexo` BLOB NULL DEFAULT NULL,
  `cd_usuario` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_aviso`),
  INDEX `curso_idx` (`cd_curso` ASC),
  INDEX `fk_avisos_turma_idx` (`cd_turma` ASC),
  INDEX `fk_aviso_usuario` (`cd_usuario` ASC),
  CONSTRAINT `fk_aviso_usuario`
    FOREIGN KEY (`cd_usuario`)
    REFERENCES `dbsaga`.`tb_usuario` (`cd_usuario`),
  CONSTRAINT `fk_avisos_curso`
    FOREIGN KEY (`cd_curso`)
    REFERENCES `dbsaga`.`tb_curso` (`cd_curso`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_avisos_turma`
    FOREIGN KEY (`cd_turma`)
    REFERENCES `dbsaga`.`tb_turma` (`cd_turma`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_bate_papo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_bate_papo` (
  `cd_bate_papo` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_turma` INT(11) NOT NULL,
  `nm_bate_papo` VARCHAR(150) NULL DEFAULT NULL,
  `dt_inicio_bate_papo` DATE NULL DEFAULT NULL,
  `dt_final_bate_papo` DATE NULL DEFAULT NULL,
  `ic_limpar_bate_papo` TINYINT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_bate_papo`),
  INDEX `cdtt_idx` (`cd_turma` ASC),
  CONSTRAINT `fk_bate_papo_cdtt`
    FOREIGN KEY (`cd_turma`)
    REFERENCES `dbsaga`.`tb_turma` (`cd_turma`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_frequencia`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_frequencia` (
  `cd_frequencia` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_geral_usuario` INT(11) NOT NULL,
  `cd_aula` INT(11) NOT NULL,
  `dt_frequencia` DATE NULL DEFAULT NULL,
  `ic_status` TINYINT(1) NULL DEFAULT NULL,
  `ds_justificar_falta` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_frequencia`),
  INDEX `geral_usuario_idx` (`cd_geral_usuario` ASC),
  INDEX `aula_idx` (`cd_aula` ASC),
  CONSTRAINT `fk_frequencia_geral_usuario`
    FOREIGN KEY (`cd_geral_usuario`)
    REFERENCES `dbsaga`.`item_geral_usuario` (`cd_geral_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_frequencia_aula`
    FOREIGN KEY (`cd_aula`)
    REFERENCES `dbsaga`.`tb_aula` (`cd_aula`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_instituicao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_instituicao` (
  `cd_instituicao` INT(11) NOT NULL AUTO_INCREMENT,
  `nm_instituicao` VARCHAR(100) NULL DEFAULT NULL,
  `nm_fantasia` VARCHAR(100) NULL DEFAULT NULL,
  `cd_cnpj` VARCHAR(20) NULL DEFAULT NULL,
  `cd_contato1` VARCHAR(20) NULL DEFAULT NULL,
  `cd_contato2` VARCHAR(20) NULL DEFAULT NULL,
  `nm_email` VARCHAR(100) NULL DEFAULT NULL,
  `nm_rua` VARCHAR(150) NULL DEFAULT NULL,
  `cd_numeracao` VARCHAR(8) NULL DEFAULT NULL,
  `nm_bairro` VARCHAR(100) NULL DEFAULT NULL,
  `nm_cidade` VARCHAR(100) NULL DEFAULT NULL,
  `nm_estado` VARCHAR(2) NULL DEFAULT NULL,
  `cd_cep` VARCHAR(20) NULL DEFAULT NULL,
  `cd_mec` VARCHAR(30) NULL DEFAULT NULL,
  `cd_alvara` VARCHAR(15) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_instituicao`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_item_curso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_item_curso` (
  `cd_item_curso` INT(11) NOT NULL,
  `cd_curso` INT(11) NULL DEFAULT NULL,
  `cd_disciplina` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_item_curso`),
  INDEX `fk_item_disciplina_idx` (`cd_disciplina` ASC),
  INDEX `fk_item_curso_idx` (`cd_curso` ASC),
  CONSTRAINT `fk_item_curso`
    FOREIGN KEY (`cd_curso`)
    REFERENCES `dbsaga`.`tb_curso` (`cd_curso`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_item_disciplina`
    FOREIGN KEY (`cd_disciplina`)
    REFERENCES `dbsaga`.`tb_disciplina` (`cd_disciplina`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_lembrete`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_lembrete` (
  `cd_lembrete` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_usuario` INT(11) NOT NULL,
  `nm_lembrete` VARCHAR(150) NULL DEFAULT NULL,
  `ds_lembrete` VARCHAR(255) NULL DEFAULT NULL,
  `dt_inicio` DATE NULL DEFAULT NULL,
  `dt_final` DATE NULL DEFAULT NULL,
  PRIMARY KEY (`cd_lembrete`),
  INDEX `usuario_idx` (`cd_usuario` ASC),
  CONSTRAINT `fk_lembrete_usuario`
    FOREIGN KEY (`cd_usuario`)
    REFERENCES `dbsaga`.`tb_usuario` (`cd_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_mensagem`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_mensagem` (
  `cd_mensagem` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_bate_papo` INT(11) NOT NULL,
  `ds_mensagem` VARCHAR(255) NULL DEFAULT NULL,
  `dt_mensagem` DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (`cd_mensagem`),
  INDEX `bate_papo_idx` (`cd_bate_papo` ASC),
  CONSTRAINT `fk_mensagem_bate_papo`
    FOREIGN KEY (`cd_bate_papo`)
    REFERENCES `dbsaga`.`tb_bate_papo` (`cd_bate_papo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_tarefa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_tarefa` (
  `cd_tarefa` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_geral_usuario` INT(11) NOT NULL,
  `nm_tarefa` VARCHAR(100) NULL DEFAULT NULL,
  `ds_tarefa` LONGTEXT NULL DEFAULT NULL,
  `dt_inicio` DATE NULL DEFAULT NULL,
  `dt_final` DATE NULL DEFAULT NULL,
  PRIMARY KEY (`cd_tarefa`),
  INDEX `geral_usuario_idx` (`cd_geral_usuario` ASC),
  CONSTRAINT `cd_geral_usuario`
    FOREIGN KEY (`cd_geral_usuario`)
    REFERENCES `dbsaga`.`item_geral_usuario` (`cd_geral_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
