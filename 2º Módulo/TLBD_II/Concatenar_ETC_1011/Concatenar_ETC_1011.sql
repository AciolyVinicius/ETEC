create database escola_abc2i2
	character set = 'utf8'
		collate = 'utf8_general_ci';

use escola_abc2i2;
create table if not exists tb_aluno(
cd_aluno int not null ,
nm_aluno varchar (100) not null,
cd_matricula char(7) not null,
dt_nascimento date,
dt_matricula date not null,
constraint pk_aluno
	primary key (cd_aluno),
unique index uq_matricula (cd_matricula ASC));
-- começar do 100 auto_increment = 100;

create table if not exists tb_prova(
cd_prova int not null,
dt_realizacao date not null,
ds_prova varchar(255) not null,
constraint pk_prova
	primary key (cd_prova));

create table if not exists tb_nota(
cd_aluno int,
cd_prova int,
qt_nota decimal (4,2),
constraint c_nota_aluno
	primary key (cd_aluno, cd_prova),
constraint fk_nota_aluno
	foreign key (cd_aluno)
		references tb_aluno(cd_aluno),
constraint fk_nota_prova
	foreign key (cd_prova)
		references tb_prova(cd_prova),
check (qt_nota >= 0));

insert into tb_aluno values
(1, 'joão michael', '123a', str_to_date('23/08/1993','%d/%m/%Y'),
current_date()),
(2, 'willian junior', '400b', str_to_date('10/04/1993','%d/%m/%Y'),
current_date()),
(3, 'kill bill', '420b', str_to_date('30/07/1993','%d/%m/%Y'),
current_date()),
(4, 'jenna kill', '010a', null, str_to_date('25/01/2014','%d/%m/%Y'));

insert into tb_prova values
(1, str_to_date('30/03/2014', '%d/%m/%Y'), 'prova a1'),
(2, str_to_date('30/04/2014', '%d/%m/%Y'), 'prova b1'),
(3, str_to_date('30/05/2014', '%d/%m/%Y'), 'prova c1'),
(4, str_to_date('30/07/2014', '%d/%m/%Y'), 'prova a2'),
(5, str_to_date('30/08/2014', '%d/%m/%Y'), 'prova b2'),
(6, str_to_date('30/09/2014', '%d/%m/%Y'), 'prova c2');

insert into tb_nota values

	-- aluno 1
	(1, 1, 10),
	(1, 2, 9.8),
	(1, 3, 8),
	(1, 4, 10),
	(1, 5, 10),
	(1, 6, 9),

	-- aluno 2
	(2, 1, 7),
	(2, 2, 7.5),
	(2, 3, 6),
	(2, 4, 8),
	(2, 5, 8.5),
	(2, 6, 9),

	-- aluno 3
	(3, 1, 9),
	(3, 2, 9),
	(3, 3, 9),
	(3, 4, 10),
	(3, 5, 10),
	(3, 6, 9.8),

	-- aluno 4
	(4, 1, 3),
	(4, 2, 6),
	(4, 3, 7),
	(4, 4, 8),
	(4, 5, 7),
	(4, 6, 7);

select * from tb_aluno;
select * from tb_prova;
select * from tb_nota;

select nm_aluno, date_format(dt_nascimento, '%d/%m/%y') 'Data de Nascimento'
	from tb_aluno;
select nm_aluno, date_format(dt_nascimento, '%D/%M/%Y') 'Data de Nascimento'
	from tb_aluno;

select nm_aluno Nome, qt_nota Nota, ds_prova 'Descrição da Prova'
from tb_aluno a
	left join tb_nota n
		on a.cd_aluno = n.cd_aluno
		right join tb_prova p
			on p.cd_prova = n.cd_prova
				order by a.nm_aluno;

select nm_aluno Nome,
(sum(n.qt_nota)/count(p.cd_prova)),
avg (n.qt_nota)
from tb_aluno a
	right join tb_nota n
		on a.cd_aluno = n.cd_aluno
		left join tb_prova p
			on n.cd_prova = p.cd_prova
				group by a.nm_aluno;