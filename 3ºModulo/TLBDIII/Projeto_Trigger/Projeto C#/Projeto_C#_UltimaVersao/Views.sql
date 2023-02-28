-- VIEWS
USE `dpto_projeto`;
CREATE  OR REPLACE VIEW `departamento_projetos` AS
select p.nm_projeto 'Projeto',
p.nm_tipo 'Tipo de Verba',
d.nm_dpto 'Departamento'
from projeto p left join dpto d
		on p.cd_dpto = d.cd_dpto;

CREATE OR REPLACE VIEW `funcionarios_projetos_horas` AS
select f.nm_func 'Funcionário', fp.qt_hora 'Hora trabalhada', p.nm_projeto 'Projeto'
from func f right join func_projeto fp
	on f.cd_func = fp.cd_func
	left join projeto p
		on fp.cd_projeto = p.cd_projeto;
        
CREATE OR REPLACE VIEW `funcionarios_dependentes` AS
select f.nm_func 'Funcionário', d.nm_parentesco 'Parentesco', d.nm_dependente
from func f right join func_dependente fp
	on f.cd_func = fp.cd_func
	left join dependente d
		on fp.cd_dependente = d.cd_dependente;
        
-- -------------------------------------------------------------- --
        
USE `dpto_projeto`;
CREATE  OR REPLACE VIEW `cdepartamento` AS
SELECT cd_dpto as 'Codigo',
nm_dpto as 'Nome',
nm_localizacao as 'Localização' FROM dpto;

USE `dpto_projeto`;
CREATE  OR REPLACE VIEW `cdependente` AS
SELECT  
d.cd_dependente  as 'Codigo',
d.nm_dependente as 'Nome',
d.nm_parentesco as 'Parentesco',
f.nm_func as 'Funcionario',
f.cd_func as 'Codigo do Funcionario'
FROM dependente d
	right join func_dependente fp
		ON d.cd_dependente = fp.cd_dependente
		left join func f
			on fp.cd_func = f.cd_func;

USE `dpto_projeto`;
CREATE  OR REPLACE VIEW `cfuncionario` AS
SELECT cd_func as 'Codigo',
nm_func as 'Nome',
nm_endereco as 'Endereco',
cd_telefone as 'Telefone',
vl_salario as 'Salario',
cd_dpto as 'Codigo do Departamento Vinculado',
cd_dpto_gerenciar as 'Departamento Gerenciado'
FROM func;

USE `dpto_projeto`;
CREATE  OR REPLACE VIEW `cprojeto_andamento` AS
select cd_projeto as 'Codigo',
nm_projeto as 'Projeto'
from projeto where ic_concluido = false;

USE `dpto_projeto`;
CREATE  OR REPLACE VIEW `cprojeto_concluido` AS
select cd_projeto as 'Codigo',
nm_projeto as 'Projeto'
from projeto where ic_concluido = true;

USE `dpto_projeto`;
CREATE  OR REPLACE VIEW `cprojeto` AS
SELECT cd_projeto as 'Codigo',
nm_projeto as 'Nome',
nm_tipo as 'Tipo',
nm_verbba as 'Verba',
cd_cpf_func as 'Funcionario', 
cd_dpto as 'Departamento' 
FROM projeto;