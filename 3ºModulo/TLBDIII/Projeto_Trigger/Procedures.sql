ALTER TABLE func
add column ds_obs varchar(100) default null;

DROP TRIGGER IF EXISTS `dpto_projeto`.`verificaGerente_funcionarios`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE DEFINER = CURRENT_USER TRIGGER `verificaGerente_funcionarios` BEFORE UPDATE ON `func` FOR EACH ROW
BEGIN
	if((new.cd_dpto_gerenciar is not null) and (new.vl_salario < 4000)) then
		set new.vl_salario = 4000,
        new.ds_obs = 'Atenção, Salário do Gerente Alterado';
	end if;
END$$
DELIMITER ;

select * from func;
update func set vl_salario = 4500.00 where cd_func = 398569902;

/*
	verificaSalario_funcionarios verifica o valor do salário dos funcionários após uma alteração,
    sendo que o atual não pode ser menor que o anterior. Se o novo valor for menor que o anterior,
    ele recebe um acréscimo de 10% como mostram o código da regra e os dados antes e depois da 
    atualização na tabela funcionarios.
*/

DROP TRIGGER IF EXISTS `dpto_projeto`.`verificaSalario_funcionarios`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE DEFINER = CURRENT_USER TRIGGER `verificaSalario_funcionarios` BEFORE UPDATE ON `func` FOR EACH ROW
BEGIN
	if((new.vl_salario < old.vl_salario)) then
		set new.vl_salario = old.vl_salario+old.vl_salario*0.1,
        new.ds_obs = 'O Salário Do Funcionário Foi Alterado' ;
	end if;
END$$
DELIMITER ;
select * from func;
update func set vl_salario = 1500.00 where cd_func = 908562514;