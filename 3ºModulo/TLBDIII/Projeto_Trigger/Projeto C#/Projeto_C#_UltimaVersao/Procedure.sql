
-- PROCEDURE
DROP procedure IF EXISTS `3func`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `3func` (f1 int, f2 int, f3 int)
BEGIN
	select nm_func 'Nome do funcionário',
    nm_endereco 'Endereço do funcionário'
		from func
			where cd_func = f1 or cd_func = f2 or cd_func = f3;
END$$
DELIMITER ;

DROP procedure IF EXISTS `func_depart`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `func_depart` ()
BEGIN
	select f.nm_func as 'Nome', d.cd_dpto 'Código do Departamento', f.vl_salario
    from func f left join dpto d
		on f.cd_dpto = d.cd_dpto
			order by f.vl_salario;
END$$
DELIMITER ;

DROP procedure IF EXISTS `func_depart_maiorque`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `func_depart_maiorque`(valor int)
BEGIN
	select distinct f.nm_func as 'Nome do Funcionário', f.cd_dpto 'Código do Departamento', f.cd_dpto_gerenciar 'Código do Departamento Gerenciado'
    from func f left join dpto d
		on f.cd_dpto = d.cd_dpto
			where f.vl_salario >  valor;
END$$
DELIMITER ;

DROP procedure IF EXISTS `projetos_funcionarios`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `projetos_funcionarios`()
BEGIN
	select p.nm_projeto, f.nm_func
		from projeto p right join func_projeto fp
			on p.cd_projeto = fp.cd_projeto
				left join func f
				on fp.cd_func = f.cd_func;
END$$
DELIMITER ;

DROP procedure IF EXISTS `func_dependente_filhoa`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `func_dependente_filhoa` ()
BEGIN
	select f.nm_func, d.nm_parentesco, d.nm_dependente 
		from dependente d right join func_dependente fd
			on d.cd_dependente = fd.cd_dependente
				left join func f
					on fd.cd_func = f.cd_func
						where trim(lower(d.nm_parentesco)) like 'filho' or trim(lower(d.nm_parentesco)) like 'filha';
END$$
DELIMITER ;

DROP procedure IF EXISTS `depart_cod`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `depart_cod`(codigo int)
BEGIN
	select * from dpto 
		where cd_dpto = codigo;
END$$
DELIMITER ;

DROP procedure IF EXISTS `func_dependente`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `func_dependente` ()
BEGIN
	select distinct f.nm_func, d.nm_parentesco, d.nm_dependente 
		from dependente d right join func_dependente fd
			on d.cd_dependente = fd.cd_dependente
				left join func f
					on fd.cd_func = f.cd_func
						order by f.nm_func;
END$$
DELIMITER ;

DROP procedure IF EXISTS `func_cidade_inicial`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `func_cidade_inicial` (inicial char)
BEGIN
	select * from func
		where nm_endereco like concat(inicial, '%');
END$$
DELIMITER ;

DROP procedure IF EXISTS `func_salario_maior_menor`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `func_salario_maior_menor`(maior decimal(9,2), menor decimal(9,2))
BEGIN
	if (maior < menor) then
	select * from func
		where vl_salario > maior and vl_salario < menor;
	else
		select * from func
		where vl_salario > menor and vl_salario < maior;
	end if;
END$$
DELIMITER ;

DROP procedure IF EXISTS `proj_verb_indefinida_xbolsas`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE DEFINER=`root`@`localhost`PROCEDURE `proj_verb_indefinida_xbolsas`(bolsas int)
BEGIN
	if (bolsas = 0) then
	select * from projeto
		where lower(nm_verbba) like 'não determinada';
	else
		select * from projeto
		where lower(nm_verbba) like 'não determinada'
        union
        select * from projeto
		where lower(nm_verbba) like concat(bolsas, '%');
	end if;
END$$
DELIMITER ;

DROP procedure IF EXISTS `proj_verb_indefinida_xtipo`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE DEFINER=`root`@`localhost`PROCEDURE `proj_verb_indefinida_xtipo`(tipo varchar(25))
BEGIN
	if (tipo = '') then
	select * from projeto
		where lower(nm_verbba) like 'não determinada';
	else
		select * from projeto
		where lower(nm_verbba) like 'não determinada'
        union
        select * from projeto
		where lower(nm_tipo) like concat('%', tipo, '%');
	end if;
END$$
DELIMITER ;

DROP procedure IF EXISTS `func_dependente_nao_filhoa`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `func_dependente_nao_filhoa` ()
BEGIN
	select distinct f.nm_func, d.nm_parentesco, d.nm_dependente 
		from dependente d right join func_dependente fd
			on d.cd_dependente = fd.cd_dependente
				left join func f
					on fd.cd_func = f.cd_func
						where trim(lower(d.nm_parentesco)) not like '%filho%' and trim(lower(d.nm_parentesco)) not like '%filha%';
END$$
DELIMITER ;

DROP procedure IF EXISTS `func_depart_gerenciam_em_projeto`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `func_depart_gerenciam_em_projeto`()
BEGIN
	select distinct f.nm_func as 'Nome do Funcionário', f.cd_dpto 'Código do Departamento', f.cd_dpto_gerenciar 'Código do Departamento Gerenciado'
    from func f left join dpto d
		on f.cd_dpto = d.cd_dpto
			left join projeto p
				on f.cd_func = p.cd_cpf_func
					where f.cd_dpto_gerenciar is not null;
END$$
DELIMITER ;

USE `dpto_projeto`;
DROP procedure IF EXISTS `exclui_dependente`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `exclui_dependente` (id int, idf int)
BEGIN
	if((select nm_parentesco from func_dependente where cd_dependente = id and cd_func = idf)<>'') then
		delete from func_dependente where cd_dependente = id and cd_func = idf;
	end if;
	if((select nm_parentesco from func_dependente where cd_dependente = id)=null)then
		delete from dependente where cd_dependente = id;
    end if;
END$$
DELIMITER ;

USE `dpto_projeto`;
DROP procedure IF EXISTS `update_dependente`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `update_dependente`(id int, nome varchar(50) , parentesco varchar(15))
BEGIN
	if(id>0) then
		if ((select nm_dependente from dependente where cd_dependente = id) <>'') then
			if(nome<>'') then
				update dependente set nm_dependente = nome 
					where cd_dependente = id;
			end if;
			if(parentesco<>'') then	
				update dependente set nm_parentesco = parentesco
					where cd_dependente = id;
			end if;
		end if;
	end if;
END$$
DELIMITER ;

USE `dpto_projeto`;
DROP procedure IF EXISTS `exclui_dpto`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `exclui_dpto`(id int)
BEGIN
	if (id>0) then
		if((select nm_dpto from dpto where cd_dpto = id)<>'') then
			update projeto set projeto.cd_dpto = null where projeto.cd_dpto = id;
			update func set func.cd_dpto = null where func.cd_dpto = id;
			update func set func.cd_dpto_gerenciar = null where func.cd_dpto = id;
			delete from dpto where dpto.cd_dpto = id;
		end if;
    end if;
END$$
DELIMITER ;

USE `dpto_projeto`;
DROP procedure IF EXISTS `update_dpto`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `update_dpto` (id int, nome varchar(35), localizacao varchar(20))
BEGIN
	if (id>0) then
		if((select nm_dpto from dpto where cd_dpto = id)<>'') then
			if(nome<>'') then
				update dpto set nm_dpto = nome where cd_dpto = id;
			end if;
			if (localizacao<>'') then
				update dpto set nm_localizacao = localizacao where cd_dpto = id;
			end if;
		end if;
	end if;
END$$
DELIMITER ;

USE `dpto_projeto`;
DROP procedure IF EXISTS `exclui_func`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `exclui_func` (id int)
BEGIN
	declare dp int(11);
	if (id>0) then
		if((select nm_func from func where cd_func = id)<>'') then			
            if((select cd_func from func_projeto where cd_func = id)<>'') then
				delete from func_projeto where cd_func = id;
            end if;
			update func set cd_dpto = null where cd_func = id;
			update func set cd_dpto_gerenciar = null where cd_func = id;
			if ((select cd_func from func_dependente where cd_func = id)<>'') then
				set dp = (select d.cd_dependente
				from dependente d
					right join func_dependente fc
						on d.cd_dependente = fc.cd_dependente
							where fc.cd_func = id);	
				delete from func_dependente where cd_func = id;    
				delete from dependente where cd_dependente = dp;
            end if;
			delete from func where cd_func = id;
	end if;    
	end if;
END$$
DELIMITER ;

USE `dpto_projeto`;
DROP procedure IF EXISTS `update_func`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `update_func` (id int, nome varchar(50), endereco varchar(60), telefone char(9), salario decimal(9,2), dp int, dpger int)
BEGIN
	if (id>0) then
		if ((select nm_func from func where cd_func = id)<>'') then 
			if(nome<>'') then
				update func set nm_func = nome where cd_func = id;
			end if;
			if(endereco<>'') then
				update func set nm_endereco = endereco where cd_func = id;
			end if;
			if(telefone<>'') then
				update func set cd_telefone = telefone where cd_func = id;
			end if;
			if(salario<>'') then
				update func set vl_salario = salario where cd_func = id;
			end if;
			if(dp<>'') then
				if ((select nm_dpto from dpto where cd_dpto = dp)<>'') then
					update func set cd_dpto = dp where cd_func = id;
				end if;
			end if;
			if(dpger>0) then
				if ((select nm_dpto from dpto where cd_dpto = dpger)<>'') then
					update func set cd_dpto_gerenciar = dpger where cd_func = id;
				end if;
			end if;
		end if;
	end if;
END$$
DELIMITER ;

USE `dpto_projeto`;
DROP procedure IF EXISTS `select_projeto_nao_concluido`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `select_projeto_nao_concluido` ()
BEGIN
	select nm_projeto from projeto where ic_concluido = false;
END$$
DELIMITER ;

USE `dpto_projeto`;
DROP procedure IF EXISTS `select_projeto_concluido`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_projeto_concluido`()
BEGIN
	select nm_projeto from projeto where ic_concluido = true;
END$$
DELIMITER ;

USE `dpto_projeto`;
DROP procedure IF EXISTS `exclui_projeto`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `exclui_projeto` (id int)
BEGIN
	if (id>0) then
		if ((select nm_projeto from projeto where cd_projeto = id)<>'') then 
			delete from func_projeto where cd_projeto = id;
			delete from projeto where cd_projeto = id;
		end if;
    end if;
END$$
DELIMITER ;

USE `dpto_projeto`;
DROP procedure IF EXISTS `update_projeto`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `update_projeto` (id int, conc boolean,nome varchar(30), tipo varchar(25), verba varchar(25), dp int, cdf int)
BEGIN
	if (id>0) then
		if ((select nm_projeto from projeto where cd_projeto = id)<>'') then
			if (conc<>'') then
				update projeto set ic_concluido = conc where cd_projeto = id;
			end if;         
			if (nome<>'') then
				update projeto set nm_projeto = nome where cd_projeto = id;
			end if;
			if (tipo<>'') then
				update projeto set nm_tipo = tipo where cd_projeto = id;
			end if;
			if (verba<>'') then
				update projeto set nm_verbba = verba where cd_projeto = id;
			end if;
			if (dp>0) then
				if ((select nm_dpto from dpto where cd_dpto = dp)<>'') then
					update projeto set cd_dpto = dp where cd_projeto = id;
				end if;
			end if;
			if (cdf>0) then
				if ((select nm_func from func where cd_func = cdf)<>'') then
					update projeto set cd_cpf_func = cdf where cd_projeto = id;
				end if;
			end if;
		end if;
	end if;
END$$
DELIMITER ;

USE `dpto_projeto`;
DROP procedure IF EXISTS `excluir_func_projeto`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `excluir_func_projeto` (idf int, idp int)
BEGIN
	if(idf>0 and idp>0) then
		if((select qt_hora from func_projeto where cd_func = idf and cd_projeto = idp)<>'') then
			delete from func_projeto where cd_func = idf and cd_projeto = idp;
		end if;
	end if;
END$$
DELIMITER ;

-- para aqui
USE `dpto_projeto`;
DROP procedure IF EXISTS `update_func_projeto`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `update_func_projeto` (idf int, idp int, aidf int, aidp int, hora tinyint(4))
BEGIN
	declare hrf int(4);
    declare hrp int(4);
	if (idf>0 and idp>0) then
		if (hora <> '' and (select qt_hora from func_projeto where cd_func = idf and cd_projeto = idp)<>'') then
			set hrf = idf;
			set hrp = idp;
            if (aidf>0 and aidp>0 and (select nm_func from func where cd_func = aidf)<>'' and (select nm_projeto from projeto where cd_projeto = aidp)<>'') then
				if ((select qt_hora from func_projeto where cd_func = aidf and cd_projeto = aidp) is null) then
					update func_projeto set cd_func = aidf and cd_projeto = aidp where cd_func = idf and cd_projeto = idp;
                    set hrf = aidf;
                    set hrp = idp;
				end if;
            else
				if (aidf>0 and aidp<0) then
					if ((select qt_hora from func_projeto where cd_func = aidf and cd_projeto = idp) is null) then
						update func_projeto set cd_func = aidf where cd_func = idf and cd_projeto = idp;
						set hrf = aidf;
					end if;
				end if;
                if (aidp>0 and aidf<0)then
					if ((select qt_hora from func_projeto where cd_func = idf and cd_projeto = aidp) is null) then
						update func_projeto set cd_projeto = aidp where cd_projeto = idp and cd_func = aidf;
						set hrp = idp;
					end if;
				end if;
			end if;
			update func_projeto set qt_hora = hora where cd_func = hrf and cd_projeto = hrp;
		end if;
    end if;
END$$
DELIMITER ;

USE `dpto_projeto`;
DROP procedure IF EXISTS `insert_dependente`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `insert_dependente` (idf int, idd int, nome varchar(50), parente char(15))
BEGIN
if(idf>0) then
	if ((select cd_func from func where idf = cd_func) <> '') then
		if(idd>0) then
			if((select nm_dependente from dependente where cd_dependente = idd) is null) then
				if(nome <> '') then
					if(parente <>'') then
						insert into dependente values
							(idd, nome, parente);
						insert into func_dependente values
							(idf, idd);
					end if;
				end if;
            end if;
        end if;
    end if;
end if;
END$$
DELIMITER ;

USE `dpto_projeto`;
DROP procedure IF EXISTS `insert_dpto`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_dpto`(id int, nome varchar(35), localizacao varchar(20))
BEGIN
	if(id>0) then
		if ((select cd_dpto from dpto where id = cd_dpto) is null) then		
			if(nome <> '') then
				if(localizacao <>'') then
					insert into dpto values
						(id, nome, localizacao);
				end if;
			end if;
        end if;
    end if;
END$$
DELIMITER ;

USE `dpto_projeto`;
DROP procedure IF EXISTS `insert_func`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_func`(id int, nome varchar(50), endereco varchar(60), telefone char(9), salario decimal(9,2), idpto int(11), idptoger int(11))
BEGIN
	declare ger int;
    set ger = null;
	if(id>0) then
		if ((select cd_func from func where id = cd_func) is null) then		
			if(nome <> '' and endereco <>'' and telefone <>'' and salario <>'' and idpto <>'') then
				if ((select cd_dpto from dpto where cd_dpto = idpto) <> '') then
					if (idptoger > 0 and (select cd_dpto from dpto where cd_dpto = idptoger) <>'') then
						set ger = idptoger;
                    end if;
					insert into func values
					(id, nome, endereco, telefone, salario, idpto, ger);
				end if;
			end if;
        end if;
    end if;
END$$
DELIMITER ;

USE `dpto_projeto`;
DROP procedure IF EXISTS `insert_projeto`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_projeto`(id int, nome varchar(30), tipo varchar(25), verba char(25), idpto int(11), cpffunc int(11))
BEGIN
	declare funccpf boolean;
    set funccpf = false;
	if(id>0) then
		if ((select cd_projeto from projeto where id = cd_projeto) is null) then		
			if(nome <> '' and tipo <>'' and verba <>'' and idpto <>'') then
				if ((select cd_dpto from dpto where cd_dpto = idpto) <> '') then
					if (cpffunc > 0) then                   
						if ((select cd_func from func where cd_func = cpffunc) <>'') then
							set funccpf = true;
                        end if;
                    end if;
                    if (funccpf is false) then
						set cpffunc = null;
					end if;
					insert into projeto values
						(id, false, nome, tipo, verba, idpto, cpffunc);					
				end if;
			end if;
        end if;
    end if;
END$$
DELIMITER ;

USE `dpto_projeto`;
DROP procedure IF EXISTS `insert_func_projeto`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `insert_func_projeto`(idf int(11), idp int(11), hora tinyint(4))
BEGIN
	if(idf<>'' and idp<>'' and hora <>'') then
		if ((select nm_projeto from projeto where idp = cd_projeto) <> '') then		                
			if ((select nm_func from func where cd_func = idf) <>'') then
				if ((select qt_hora from func_projeto where cd_func = idf and cd_projeto = idp) is null) then
					insert into func_projeto values
					(idf, idp, hora);	
				end if;
			end if;
        end if;
    end if;
END$$
DELIMITER ;

USE `dpto_projeto`;
DROP procedure IF EXISTS `projet_associado_func`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `projet_associado_func` (proj int(11))
BEGIN
SELECT  f.cd_func as 'Codigo do Funcionario'
FROM func f 
	right join func_projeto fp 
	on f.cd_func = fp.cd_func
		left join projeto p 
		on fp.cd_projeto = p.cd_projeto
			where p.cd_projeto = proj;
END$$
DELIMITER ;
USE `dpto_projeto`;
DROP procedure IF EXISTS `projet_nao_associado_func`;
DELIMITER $$
USE `dpto_projeto`$$
CREATE PROCEDURE `projet_nao_associado_func` (proj int(11))
BEGIN
SELECT  f.cd_func as 'Codigo do Funcionario'
FROM func f 
	where f.cd_func not in (select cd_func from func_projeto where cd_projeto = proj);
END$$
DELIMITER ;

