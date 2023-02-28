CREATE SCHEMA `biblio`;
USE `biblio` ;

-- -----------------------------------------------------
-- Table `Biblioteca.db`.`tb_categoria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS tb_categoria(
  `cd_categoria` INT(5) NOT NULL AUTO_INCREMENT,
  `nm_categoria` VARCHAR(20) NULL,
  PRIMARY KEY (`cd_categoria`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Biblioteca.db`.`tb_material`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS tb_tipo_material (
  `cd_material` INT(5) NOT NULL AUTO_INCREMENT,
  `nm_tipo` VARCHAR(10) NULL,
  PRIMARY KEY (`cd_material`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Biblioteca.db`.`tb_acervo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS tb_acervo (
  `cd_acervo` INT(12) NOT NULL AUTO_INCREMENT,
  `nm_titulo` VARCHAR(40) NULL,
  `nm_edicao` VARCHAR(40) NULL,
  `nm_autor` VARCHAR(40) NULL,
  `nm_editora` VARCHAR(15) NULL,
  `ic_ativo` BOOLEAN,
  `cd_categoria` INT(5) NOT NULL,
  `cd_material` INT(5) NOT NULL,
  PRIMARY KEY (`cd_acervo`),
  INDEX `fk_tb_acervo_tb_categoria_idx` (`cd_categoria` ASC) ,
  INDEX `fk_tb_acervo_tb_material_idx` (`cd_material` ASC),
  CONSTRAINT `fk_tb_acervo_tb_categoria`
    FOREIGN KEY (`cd_categoria`)
    REFERENCES tb_categoria (`cd_categoria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_acervo_tb_material1`
    FOREIGN KEY (`cd_material`)
    REFERENCES tb_tipo_material (`cd_material`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `Biblioteca.db`.`tb_curso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS tb_curso (
  `cd_curso` INT(3) NOT NULL AUTO_INCREMENT,
  `nm_curso` VARCHAR(15) NULL,
  PRIMARY KEY (`cd_curso`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Biblioteca.db`.`tb_usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS tb_usuario (
  `cd_usuario` INT(6) NOT NULL AUTO_INCREMENT,
  `nm_usuario` VARCHAR(50) NULL,
  `cd_senha` VARCHAR(50) NULL,
  `cd_telefone` VARCHAR(14) NULL,
  `nm_email` VARCHAR(50) NULL,
  `ic_professor` BOOLEAN,
  `ic_ativo` BOOLEAN,
  `cd_curso` INT(3) NOT NULL,
  PRIMARY KEY (`cd_usuario`),
  INDEX `fk_tb_usuario_tb_curso_idx` (`cd_curso` ASC),
  CONSTRAINT `fk_tb_usuario_tb_curso`
    FOREIGN KEY (`cd_curso`)
    REFERENCES tb_curso (`cd_curso`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Biblioteca.db`.`tb_emprestimo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS tb_emprestimo (
  `cd_emprestimo` INT(6) NOT NULL auto_increment,
  `cd_usuario` INT(6) NOT NULL COMMENT '',
  `cd_acervo` INT(12) NOT NULL COMMENT '',
  `dt_saida` DATE DEFAULT NULL,
  `dt_devolucao` DATE DEFAULT NULL,
  `ic_devolvido` BOOLEAN,
  PRIMARY KEY (`cd_emprestimo`),
  INDEX `fk_tb_emprestimo_tb_usuario_idx` (`cd_usuario` ASC),
  INDEX `fk_tb_emprestimo_tb_acervo_idx` (`cd_acervo` ASC),
  CONSTRAINT `fk_tb_emprestimo_tb_usuario`
    FOREIGN KEY (`cd_usuario`)
    REFERENCES tb_usuario (`cd_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_emprestimo_tb_acervo`
    FOREIGN KEY (`cd_acervo`)
    REFERENCES tb_acervo (`cd_acervo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

insert into tb_categoria values
(1, "Educacional"),
(2, "Científico"),
(3, "Informativo"),
(4, "Fictício"),
(5, "Recreativo");

insert into tb_tipo_material values
(1, "Livro"),
(2, "Revista"),
(3, "Jornal"),
(4, "Artigo");


insert into tb_acervo values
(1, "Matemática", "1º", "Saura Salina", "VilaSaura", true, 1, 1),
(2, "As viajens de Dino", "1º", "Saura Salina", "VilaSaura", true, 5, 1),
(3, "Sauro se torna um grande escritor", "", "Getúlio Vargas", "GLOBO", true, 3, 3),
(4, "O grande altruísmo renegado", "1º", "Saura Salina", "VilaSaura", true, 2, 4),
(5, "A arte dentro de nossa sociedade", "", "Getúlio Vargas", "GLOBO", true, 5, 2),
(6, "Eu sou demais", "1º", "Saura Salina", "VilaSaura", true, 4, 1);

insert into tb_curso values
(1, "Administrador"),
(2, "Ensino Médio"),
(3, "Ensino Técnico");

insert into tb_usuario (cd_usuario, nm_usuario, cd_senha, nm_email, ic_ativo, cd_curso, cd_telefone, ic_professor) values
(1, "ADMINISTRADOR", "SENHASENHA", "admin@admin.com", true, 1,  1399832937, false),
(2, "Kellen", "eusoudemais", "kellen@gmail.com", true, 1, 139983464582 , true),
(3, "João Castro", "jojo", "joaojoao@gmail.com", true, 2, 13997734555 , false),
(4, "Alessandro", "oieusoudollynho", "aless@@gmail.com", true, 3, 13997465935 , true),
(5, "Crybabye", "importadobaby", "cry@gmail.com", true, 3, 13997465934 , false),
(6, "Matheus", "guedes", "matheus@gmail.com", true, 2, 13997235934 , false),
(7, "Saura Dino", "Saura", "saura@gmail.com", true, 2, 13996658934 , false),
(8, "Joster", "Souzika", "joster@gmail.com", true, 3, 13997455934 , false),
(9, "Gabiastro", "GabiGolNoPedaco", "gabiel@gmail.com", true, 2, 13997474834 , false),
(10, "Klaus", "EnemFeelings", "klaus@hotmail.com", true, 2, 13997482734 , true),
(11, "Jinga", "JingaMinhaFia", "jinga@hotmail.com", true, 3, 13999847634 , false),
(12, "Ostreu", "ostradoceu", "ostraminina@hotmail.com", true, 2, 139997648534 , true),
(13, "Camilo", "CameloMeuQuerido", "camilo@hotmail.com", true, 3, 13997463645 , false);

SELECT * FROM tb_usuario where ic_ativo is true;

DROP TRIGGER IF EXISTS `biblio`.`calculaData`;
DELIMITER $$
USE `biblio`$$
CREATE DEFINER = CURRENT_USER TRIGGER `calculaData` BEFORE INSERT ON `tb_emprestimo` FOR EACH ROW
BEGIN
	declare dias INT(3);
    declare user INT(6);
    set user = new.cd_usuario;
	if((select ic_professor from tb_usuario where tb_usuario.cd_usuario = user)) then
		set dias = 7;
	else
		set dias = 5;
	end if;
	set new.dt_saida = curdate();
	set new.dt_devolucao = date_add(curdate(), interval dias day);
END$$
DELIMITER ;

DROP TRIGGER IF EXISTS `biblio`.`ativoFalse`;
DELIMITER $$
USE `biblio`$$
CREATE DEFINER = CURRENT_USER TRIGGER `ativoFalse` AFTER INSERT ON `tb_emprestimo` FOR EACH ROW
BEGIN
	declare user INT(6);
    declare acervo INT(6);
	set user = new.cd_usuario;
	set acervo = new.cd_acervo;
	update tb_usuario 
		set tb_usuario.ic_ativo = false
			where tb_usuario.cd_usuario = user;
	update tb_acervo 
		set tb_acervo.ic_ativo = false
			where tb_acervo.cd_acervo = user;
END$$
DELIMITER ;

insert into tb_emprestimo values
(1, 2, 1, null, null, false),
(2, 3, 2, null, null, false),
(3, 4, 3, null, null, false),
(4, 5, 4, null, null, false),
(5, 6, 5, null, null, false),
(6, 7, 6, null, null, false);
SELECT * FROM tb_emprestimo;