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
-- Table `dbsaga`.`tb_curso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_curso` (
  `cd_curso` INT(11) NOT NULL AUTO_INCREMENT,
  `nm_curso` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_curso`))
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
  `nm_estado` VARCHAR(3) NULL DEFAULT NULL,
  `cd_cep` VARCHAR(20) NULL DEFAULT NULL,
  `cd_mec` VARCHAR(30) NULL DEFAULT NULL,
  `cd_alvara` VARCHAR(15) NULL DEFAULT NULL,
  UNIQUE INDEX (`nm_instituicao`),
  PRIMARY KEY (`cd_instituicao`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

-- -----------------------------------------------------
-- Table `dbsaga`.`tb_turma`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_turma` (
  `cd_turma` INT(11) NOT NULL AUTO_INCREMENT,
  `nm_turma` VARCHAR(100) NULL DEFAULT NULL,
  `dt_inicio` DATE NULL DEFAULT NULL,
  `dt_final` DATE NULL DEFAULT NULL,
  `qt_usuario` INT(6) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_turma`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_turno`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_turno` (
  `cd_turno` INT(11) NOT NULL AUTO_INCREMENT,
  `nm_turno` VARCHAR(100) NULL DEFAULT NULL,
  `hr_inicio` TIME NULL DEFAULT NULL,
  `hr_final` TIME NULL DEFAULT NULL,
  PRIMARY KEY (`cd_turno`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_disciplina`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_disciplina` (
  `cd_disciplina` INT(11) NOT NULL AUTO_INCREMENT,
  `nm_disciplina` VARCHAR(150) NULL DEFAULT NULL,
  `qt_carga_horaria` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_disciplina`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE TABLE IF NOT EXISTS `dbsaga`.`item_curso_disciplina`(
  `cd_curso_disciplina` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_curso` INT(11) ,
  `cd_disciplina` INT(11),
  PRIMARY KEY(`cd_curso_disciplina`),
  CONSTRAINT `fk_disciplina_item_curso`
    FOREIGN KEY (`cd_curso`)
    REFERENCES `dbsaga`.`tb_curso` (`cd_curso`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_curso_item_disciplina`
    FOREIGN KEY (`cd_disciplina`)
    REFERENCES `dbsaga`.`tb_disciplina` (`cd_disciplina`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;
-- -----------------------------------------------------
-- Table `dbsaga`.`item_cdtt`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`item_cdtt` (
  `cd_cdtt` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_curso` INT(11) NOT NULL,
  `cd_turma` INT(11) NOT NULL,
  `cd_turno` INT(11) NOT NULL,
  PRIMARY KEY (`cd_cdtt`),
  INDEX `curso_idx` (`cd_curso` ASC),
  INDEX `turma_idx` (`cd_turma` ASC),
  INDEX `turno_idx` (`cd_turno` ASC),
  CONSTRAINT `fk_cdtt_item_curso`
    FOREIGN KEY (`cd_curso`)
    REFERENCES `dbsaga`.`tb_curso` (`cd_curso`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_cdtt_item_turma`
    FOREIGN KEY (`cd_turma`)
    REFERENCES `dbsaga`.`tb_turma` (`cd_turma`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_cdtt_item_turno`
    FOREIGN KEY (`cd_turno`)
    REFERENCES `dbsaga`.`tb_turno` (`cd_turno`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_usuario` (
  `cd_usuario` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_instituicao` INT(11) NOT NULL,
  `nm_usuario` VARCHAR(150) NULL DEFAULT NULL,
  `nm_sobrenome` VARCHAR(150) NULL DEFAULT NULL,
  `dt_nascimento` DATE NULL DEFAULT NULL,
  `nm_email` VARCHAR(150) NULL DEFAULT NULL,
  `im_foto` BLOB NULL DEFAULT NULL,
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
  `nm_estado` VARCHAR(3) NULL DEFAULT NULL,
  `nm_responsavel` VARCHAR(150) NULL DEFAULT NULL,
  `cd_contato_responsavel` VARCHAR(20) NULL DEFAULT NULL,
  `nm_email_responsavel` VARCHAR(150) NULL DEFAULT NULL,
  `cd_cpf_responsavel` VARCHAR(20) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_usuario`),
  UNIQUE INDEX `email_UNIQUE` (`nm_email` ASC),
  UNIQUE INDEX `cpf_UNIQUE` (`cd_cpf` ASC),
  CONSTRAINT `fk_usuario_instituicao`
	FOREIGN KEY (`cd_instituicao`)
		REFERENCES `dbsaga`.`tb_instituicao` (`cd_instituicao`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`item_geral_usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`item_geral_usuario` (
  `cd_geral_usuario` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_usuario` INT(11) NOT NULL,
  `cd_cdtt` INT(11) NOT NULL,
  PRIMARY KEY (`cd_geral_usuario`),
  UNIQUE INDEX `usuario_cdtt_idx` (`cd_usuario` ASC, `cd_cdtt` ASC),
  CONSTRAINT `fk_geral_usuario_item_usuario`
    FOREIGN KEY (`cd_usuario`)
    REFERENCES `dbsaga`.`tb_usuario` (`cd_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_geral_usuario_item_cdtt`
    FOREIGN KEY (`cd_cdtt`)
    REFERENCES `dbsaga`.`tb_cdtt` (`cd_cdtt`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_material`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_material` (
  `cd_material` INT(11) NOT NULL AUTO_INCREMENT,
  `nm_material` VARCHAR(100) NULL DEFAULT NULL,
  `im_anexo` BLOB NULL DEFAULT NULL,
  PRIMARY KEY (`cd_material`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`item_material_cdtt`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`item_material_cdtt` (
  `cd_material_cdtt` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_cdtt` INT(11) NOT NULL,
  `cd_material` INT(11) NOT NULL,
  PRIMARY KEY (`cd_material_cdtt`),
  INDEX `cdtt_idx` (`cd_cdtt` ASC),
  INDEX `material_idx` (`cd_material` ASC),
  CONSTRAINT `fk_material_item_cdtt`
    FOREIGN KEY (`cd_cdtt`)
    REFERENCES `dbsaga`.`item_cdtt` (`cd_cdtt`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_cdtt_item_material`
    FOREIGN KEY (`cd_material`)
    REFERENCES `dbsaga`.`tb_material` (`cd_material`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_role`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_role` (
  `cd_role` INT(11) NOT NULL AUTO_INCREMENT,
  `nm_role` VARCHAR(100) NULL DEFAULT NULL,
  `ds_role` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_role`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_permissao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_permissao` (
  `cd_permissao` INT(11) NOT NULL AUTO_INCREMENT,
  `nm_permissao` VARCHAR(100) NULL DEFAULT NULL,
  `ds_descricao` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_permissao`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`item_permissao_role`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`item_permissao_role` (
  `cd_role` INT(11) NOT NULL,
  `cd_permissao` INT(11) NOT NULL,
  INDEX `role_idx` (`cd_role` ASC),
  INDEX `permissao_idx` (`cd_permissao` ASC),
  CONSTRAINT `fk_permissao_item_role`
    FOREIGN KEY (`cd_role`)
    REFERENCES `dbsaga`.`tb_role` (`cd_role`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_role_item_permissao`
    FOREIGN KEY (`cd_permissao`)
    REFERENCES `dbsaga`.`tb_permissao` (`cd_permissao`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`item_usuario_role`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`item_usuario_role` (
  `cd_usuario` INT(11) NOT NULL,
  `cd_role` INT(11) NOT NULL,
  INDEX `usuario_idx` (`cd_usuario` ASC),
  INDEX `role_idx` (`cd_role` ASC),
  CONSTRAINT `fk_role_item_usuario`
    FOREIGN KEY (`cd_usuario`)
    REFERENCES `dbsaga`.`tb_usuario` (`cd_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuario_item_role`
    FOREIGN KEY (`cd_role`)
    REFERENCES `dbsaga`.`tb_role` (`cd_role`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`tb_bate_papo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_bate_papo` (
  `cd_bate_papo` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_cdtt` INT(11) NOT NULL,
  `nm_bate_papo` VARCHAR(150) NULL DEFAULT NULL,
  `dt_inicio` DATE NULL DEFAULT NULL,
  `dt_final` DATE NULL DEFAULT NULL,
  `ic_limpar` TINYINT(1) NULL DEFAULT NULL,
  PRIMARY KEY (`cd_bate_papo`),
  INDEX `cdtt_idx` (`cd_cdtt` ASC),
  CONSTRAINT `fk_bate_papo_cdtt`
    FOREIGN KEY (`cd_cdtt`)
    REFERENCES `dbsaga`.`item_cdtt` (`cd_cdtt`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


-- -----------------------------------------------------
-- Table `dbsaga`.`mensagem`
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
-- Table `dbsaga`.`tb_anotacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_anotacao` (
  `cd_anotacao` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_geral_usuario` INT(11) NOT NULL,
  `nm_anotacao` VARCHAR(150) NULL DEFAULT NULL,
  `ds_anotacao` LONGTEXT NULL DEFAULT NULL,
  `dt_anotacao` DATE NULL DEFAULT NULL,
  PRIMARY KEY (`cd_anotacao`),
  INDEX `geral_usuario_idx` (`cd_geral_usuario` ASC),
  CONSTRAINT `fk_anotacao_geral_usuario`
    FOREIGN KEY (`cd_geral_usuario`)
    REFERENCES `dbsaga`.`item_geral_usuario` (`cd_geral_usuario`)
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
  `cd_cdtt` INT(11) NOT NULL,
  `nm_aula` VARCHAR(150) NULL DEFAULT NULL,
  `dt_aula` DATE NULL DEFAULT NULL,
  `hr_inicio_aula` DATETIME NULL DEFAULT NULL,
  `hr_final_aula` DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (`cd_aula`),
  INDEX `cdtt_idx` (`cd_cdtt` ASC),
  CONSTRAINT `fk_aula_cdtt`
    FOREIGN KEY (`cd_cdtt`)
    REFERENCES `dbsaga`.`tb_cdtt` (`cd_cdtt`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


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
  CONSTRAINT `fk_avaliacao_geral_usuario`
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
  `cd_usuario` INT(11) NOT NULL,
  `cd_curso` INT(11) NOT NULL,
  `cd_turma` INT(11) NOT NULL,
  `nm_aviso` VARCHAR(100) NULL DEFAULT NULL,
  `ds_aviso` LONGTEXT NULL DEFAULT NULL,
  `im_anexo` BLOB NULL DEFAULT NULL,
  PRIMARY KEY (`cd_aviso`),
  INDEX `usuario_idx` (`cd_usuario` ASC),
  INDEX `curso_idx` (`cd_curso` ASC),
  INDEX `turma_idx` (`cd_turma` ASC),
  CONSTRAINT `fk_aviso_usuario`
    FOREIGN KEY (`cd_usuario`)
    REFERENCES `dbsaga`.`tb_usuario` (`cd_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
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
-- Table `dbsaga`.`tb_lembrete`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_lembrete` (
  `cd_lembrete` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_usuario` INT(11) NOT NULL,
  `nm_lembrete` VARCHAR(150) NULL DEFAULT NULL,
  `ds_lembrete` VARCHAR(255) NULL DEFAULT NULL,
  `dt_inicio_lembrete` DATE NULL DEFAULT NULL,
  `dt_final_lembrete` DATE NULL DEFAULT NULL,
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
-- Table `dbsaga`.`tb_tarefa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbsaga`.`tb_tarefa` (
  `cd_tarefa` INT(11) NOT NULL AUTO_INCREMENT,
  `cd_geral_usuario` INT(11) NOT NULL,
  `nm_tarefa` VARCHAR(100) NULL DEFAULT NULL,
  `ds_tarefa` LONGTEXT NULL DEFAULT NULL,
  `dt_inicio_tarefa` DATE NULL DEFAULT NULL,
  `dt_final_tarefa` DATE NULL DEFAULT NULL,
  PRIMARY KEY (`cd_tarefa`),
  INDEX `geral_usuario_idx` (`cd_geral_usuario` ASC),
  CONSTRAINT `fk_tarefa_geral_usuario`
    FOREIGN KEY (`cd_geral_usuario`)
    REFERENCES `dbsaga`.`item_geral_usuario` (`cd_geral_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
