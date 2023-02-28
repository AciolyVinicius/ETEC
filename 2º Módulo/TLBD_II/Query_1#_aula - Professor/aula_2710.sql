insert into tb_estado (cd_uf, nm_uf, sg_uf)
select max(cd_uf)+1, "Minas Gerais", "MG"
	from tb_estado;

select * from tb_cidade;

insert into tb_cidade (cd_cidade, cd_uf, nm_cidade)
	select max(cd_cidade)+1, 5,"Belo Horizonte"
	from tb_cidade;

insert into tb_aluno (cd_aluno, cd_cidade, nm_aluno, dt_nascimento)
	select max(cd_aluno)+1, 15,"Vacilao Lab3", "2001-01-01"
	from tb_aluno;

select * from tb_aluno;

delete from tb_aluno where cd_aluno = 41;

create table bkp_aluno
select * from tb_aluno;

show tables;
desc bkp_aluno;
select * from bkp_aluno;

delete from bkp_aluno;
delete from bkp_aluno where cd_aluno in (select cd_aluno from tb_aluno);

set sql_safe_deletes = 0;
set sql_safe_updates = 0;
set sql_safe_updates = 1;

insert into bkp_aluno
	select * from tb_aluno 
		where cd_aluno = 8;

delete from tb_aluno where cd_aluno = 41;