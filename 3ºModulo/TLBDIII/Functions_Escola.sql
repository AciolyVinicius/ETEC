create database escola_abc character set = 'utf8' collate = 'utf8_general_ci';
use escola_abc;

create table if not exists aluno (
cd_aluno int not null,
nm_aluno varchar(100) not null,
cd_matricula varchar(10) not null,
dt_nascimento date not null,
dt_matricula date not null,
constraint pk_aluno
	primary key (cd_aluno),
constraint uq_matricula
	unique index cd_matricula_unique (cd_matricula asc)
)
engine = innodb;

create table if not exists prova (
cd_prova int not null,
dt_realizacao date not null,
ds_prova varchar (255) not null,
constraint pk_prova
	primary key (cd_prova)
) 
engine = innodb;

create table if not exists nota (
cd_aluno int not null,
cd_prova int not null,
qt_nota decimal(15,2) null,
constraint ck_nota
	primary key ( cd_aluno, cd_prova ),
index fk_aluno_prova_prova1 ( cd_prova asc ),
index fk_aluno_prova_aluno1 ( cd_aluno asc ),
constraint fk_aluno_prova_aluno1
	foreign key (cd_aluno)
		references aluno (cd_aluno),
constraint fk_aluno_prova_prova1
	foreign key (cd_prova)
		references prova (cd_prova)
)
engine = innodb;

insert into aluno (cd_aluno, nm_aluno, cd_matricula, dt_nascimento, dt_matricula) values
(1, 'joão michael', '123a', str_to_date('23/08/1993', '%d/%m/%Y'), curdate()),
(2, 'willian junior', '400b', str_to_date('10/04/1993', '%d/%m/%Y'), curdate()),
(3, 'kill bill', '420b', str_to_date('30/07/1993', '%d/%m/%Y'), curdate()),
(4, 'jenna kill', '010a', str_to_date('30/07/1983', '%d/%m/%Y'), str_to_date('25/01/2014', '%d/%m/%Y'));
select * from aluno;

insert into prova (cd_prova, dt_realizacao, ds_prova) values
(1, '2015/02/28', 'prova a1'),
(2, '2015/02/28', 'prova b1'),
(3, '2015/03/30', 'prova c1'),
(4, '2015/03/30', 'prova a2'),
(5, '2015/04/30', 'prova b2'),
(6, '2015/04/30', 'prova c2');
select * from prova;

insert into nota (cd_aluno, cd_prova, qt_nota) values
#aluno 1
(1, 1, 10),
(1, 2, 9.8),
(1, 3, 8),
(1, 4, 10),
(1, 5, 10),
(1, 6, 9),

#aluno 2
(2, 1, 7),
(2, 2, 7.5),
(2, 3, 6),
(2, 4, 8),
(2, 5, 8.5),
(2, 6, 9),

#aluno 3
(3, 1, 9),
(3, 2, 9),
(3, 3, 9),
(3, 4, 10),
(3, 5, 10),
(3, 6, 9.8),

#aluno 4
(4, 1, 5),
(4, 2, 6),
(4, 3, 7),
(4, 4, 8),
(4, 5, 7),
(4, 6, 7);

USE `escola_abc`;
DROP function IF EXISTS `calc_nota`;

DELIMITER $$
USE `escola_abc`$$
CREATE FUNCTION `calc_nota` (nota numeric(15,2))
RETURNS NUMERIC(15,2)
BEGIN
	declare peso int;
    if nota>7.5 then
		set peso = 2;
	else 
		set peso = 1;
	end if;
RETURN (nota*peso)/20;
END$$

DELIMITER ;
select distinct a.nm_aluno, p.ds_prova,
calc_nota(n.qt_nota) 'Nota Calculada',
n.qt_nota as 'Nota Original'
	from aluno a join nota n
		on a.cd_aluno = n.cd_aluno
			join prova as p
				on n.cd_prova = p.cd_prova
					order by p.ds_prova;



select distinct a.nm_aluno,
(sum(calc_nota(n.qt_nota))/6) 'Nota Calculada'
	from aluno a join nota n
		on a.cd_aluno = n.cd_aluno
			group by a.nm_aluno;

-- usando cursor
DROP procedure IF EXISTS `arredondamento_nota`;
DELIMITER $$
USE `escola_abc`$$
CREATE PROCEDURE `arredondamento_nota` ()
BEGIN
	declare nota_atual numeric(5,2);
    declare id_aluno, id_prova int;
    -- guarda resultado do select
    declare cur cursor for select qt_nota, cd_aluno, cd_prova from nota;
    -- abrimos o cursor para utiliza-lo dentro do loop
    open cur;
    -- iniciamos o loop dando um nome ao mesmo para que esse possa ser referenciado caso necessario
    myloop:
		loop
		-- atribuimos valor das colunas do cursor às variáveis que criamos anteriormente
        fetch cur into nota_atual, id_aluno, id_prova;
			if (ceil(nota_atual) - nota_atual) <= 0.2 then
				update nota 
					set qt_nota = ceil(nota_atual)
						where cd_aluno = id_aluno and
						cd_prova = id_prova;
			end if;
		end loop;
        -- fechamos o cursor
        close cur;
END$$
DELIMITER ;