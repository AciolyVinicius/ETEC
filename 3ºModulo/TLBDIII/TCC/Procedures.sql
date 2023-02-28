create procedure sp_saudacao()
	select "Welcome to the Heaven" as 'Good título';

DELIMITER $$
USE `db_pedido_3i2`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `vendedores`(
	in produto varchar(65),
    in klg float)
BEGIN
	select `tb_vendedor`.*
		from `tb_vendedor`
			right join `tb_pedido`
			on `tb_vendedor`.`cd_vendedor` =  `tb_pedido`.`cd_vendedor`
				right join `item_pedido`
				on `tb_pedido`.`cd_pedido` = `item_pedido`.`cd_pedido` 
					left join `tb_produto`
					on `item_pedido`.`cd_produto` = `tb_produto`.`cd_produto`
					where `item_pedido`.`qt_produto` > klg
                    and `tb_produto`.`nm_produto` < produto;
END$$

DELIMITER ;

DELIMITER $$
USE `db_pedido_3i2`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_reaj`(
	in reajuste float,
	in bonus float,
    in categoria char(1))
BEGIN
	select nm_vendedor as 'Vendedor', 
    vl_salario as 'Salário Atual',
    (vl_salario*reajuste)+bonus as 'Novo Salário'
		from tb_vendedor
			where sg_comissao = categoria
				order by nm_vendedor;
END$$
DELIMITER ;

call sp_saudacao();
call sp_sauda1();
call sp_sauda2('França');
call sp_reaj(1.5, 700, 'c');

call vendedores('chocolate', 10);

show tables;
desc tb_pedido;


-- --------------------------------------------------- --
Delimiter $$
USE `db_pedido_3i2`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_decide_1`(in a float, in b float)
BEGIN 
	declare x float;
    set x = a + b;
    if (x>10) then
		select x;
	else select "Valor não corresponde";
        end if;
END$$
Delimiter ;

Delimiter $$
Use `db_pedido_3i2`$$
Create definer = `root`@`localhost` Procedure `Múltiplo de 3` (in num float)
Begin
	declare analise float;
    declare inter int;
    set analise = num / 3;
    set inter = num/3;
    if (analise!=inter) then
		select ("Não é múltiplo de 3") as Resultado;
	else 
		select ("É múltiplo de 3") as Resultado;
	end if;
END$$
Delimiter ;

call `Múltiplo de 3`(12);

Delimiter $$
Use `db_pedido_3i2`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_nome_mes`()
BEGIN
	declare valor integer;
    declare nome varchar(9);
    set valor = month(curdate());
    if(valor = 1) then
		set nome = "janeiro";
        
	elseif(valor = 2) then
		set nome = "fevereiro";
        
	elseif(valor = 3) then
		set nome = "março";
        
        elseif(valor = 4) then
		set nome = "abril";
        
        elseif(valor = 5) then
		set nome = "maio";
        
        elseif(valor = 6) then
		set nome = "junho";
        
          elseif(valor = 7) then
		set nome = "julho";
        
          elseif(valor = 8) then
		set nome = "agosto";
        
          elseif(valor = 9) then
		set nome = "setembro";
        
          elseif(valor = 10) then
		set nome = "outubro";
        
          elseif(valor = 11) then
		set nome = "novembro";
        
          elseif(valor = 12) then
		set nome = "dezembro";
        
        
        end if;
        
         select nome;

END$$
Delimiter ;
call sp_nome_mes();


Delimiter $$
Use `db_pedido_3i2`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_ins_vendedor`(
in codigo int, 
in nome varchar(50),
in comissao char(1),
in salario decimal (9,2))
Begin
	if exists(select cd_vendedor from tb_vendedor where cd_vendedor = codigo) then
		select concat('Funcionário:', nome, ' não cadastrado pois o codigo', codigo, 
        'já existe') as atencao;
	else 
    insert into tb_vendedor (cd_vendedor, nm_vendedor, sg_comissao, vl_salario)
    values (codigo, nome, comissao, salario);
    select concat('Funcionario: ', nome, ' cadastrado  com sucesso') as Informação;
	end if;
END$$
Delimiter ;
call `sp_ins_vendedor` (10, 'Leonardo Tavares', 'c', 7000);

Delimiter $$
Use `db_pedido_3i2`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_nome_mes2`()
BEGIN
	declare valor integer;
    set valor = month(curdate());
    case valor
    when 1 then
		select "janeiro";
        
	when 2 then
		select "fevereiro";
        
	when 3 then
		select "março";
        
	when 4 then
	select "abril";
        
	when 5 then
	select "maio";
        
	when 6 then
	select "junho";
        
	when 7 then
	select "julho";
        
	when 8 then
	select "agosto";
        
	when 9 then
	select "setembro";
        
	when 10 then
	select "outubro";
        
	when 11 then
	select "novembro";
        
	when 12 then
	select "dezembro";
        
        
	end case;

END$$
Delimiter ;
call sp_nome_mes2();

DELIMITER $$
USE `db_pedido_3i2`$$
CREATE PROCEDURE sp_comissao(
in bonus decimal(9,2),
in comissao char(1)
)
BEGIN
	declare percent decimal(9,2);
    case comissao
		when 'c' then
			set percent = 1.1;
		when 'b' then
			set percent = 1.075;
		when 'a' then
			set percent = 1.05;
	end case;
    select
    nm_vendedor as vendedor,
	vl_salario as 'Salário Atual',
    (vl_salario * percent) + bonus as 'Novo Salário'
		from tb_vendedor
			where sg_comissao = comissao;
END$$
DELIMITER ;
call sp_comissao(0, 'b');

DELIMITER $$
USE `db_pedido_3i2`$$
Create procedure sp_fat(
in val int)
BEGIN
	declare fator, i int;
	set fator = 1;
    set i = 1;
    calc: loop
		set fator = fator * i;
        set i = i+1;
        if (i > val) then
			leave calc;
		end if;
	end loop calc;
    select fator;
END$$
DELIMITER ;
call sp_fat(5);

DELIMITER $$
USE `db_pedido_3i2`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_fat1`(
in val int)
BEGIN
	declare fator, i int;
	set fator = 1;
    set i = 1;
    calc: repeat
		set fator = fator * i;
        set i = i+1;
        until (i > val) end repeat calc;
    select fator;
END$$
DELIMITER ;
call sp_fat1(5);

