select 
d.cd_disciplina as codigo,
d.nm_disciplina as Nome
	from tb_disciplina as d
		where d.cd_disciplina
			not in (select cd_disciplina
						from tb_matricula);

select 
d.cd_disciplina as codigo,
d.nm_disciplina as Nome
	from tb_disciplina as d
		where 
			not exists (select cd_disciplina
							from tb_matricula as m
								where m.cd_disciplina = d.cd_disciplina);

select
c.nm_cidade "Nome da Cidade",
(select e.sg_uf from tb_estado e 
	where e.cd_uf = c.cd_uf)
		from tb_cidade c;

select
c.nm_cidade "Nome da Cidade",
(select e.sg_uf from tb_estado e 
	where e.cd_uf = c.cd_uf) UF
	from tb_cidade c;

select distinct
(select ee.sg_uf sg from tb_estado ee
		where ee.cd_uf = c.cd_uf) UF,
(select count(cc.cd_cidade) from tb_cidade cc
	join tb_estado ee
		on ee.cd_uf = cc.cd_uf
			where ee.cd_uf = c.cd_uf) as "Total de cidades por estado"
	from tb_cidade c;

select distinct
(select ee.sg_uf sg from tb_estado ee
		where ee.cd_uf = c.cd_uf) UF,
(select count(cc.cd_cidade) from tb_cidade cc
	join tb_estado ee
		on ee.cd_uf = cc.cd_uf
			where ee.cd_uf = c.cd_uf) as "Total de cidades por estado"
	from tb_cidade c
		where (select count(cc.cd_cidade) from tb_cidade cc
			join tb_estado ee
				on ee.cd_uf = cc.cd_uf
					where ee.cd_uf = c.cd_uf) > 3;

select 
m.cd_matricula,
m.dt_matricula,
m.cd_disciplina
	from tb_matricula m
		join (select cd_disciplina
				from tb_disciplina
					where cd_disciplina
						in (select cd_disciplina
								from tb_matricula)) as d
			on d.cd_disciplina = m.cd_disciplina;

select distinct
t.aa_ano,
tu.nm_turno,
c.nm_curso,
d.nm_disciplina,
t.qt_serie
	from tb_matricula m
		join (select cd_disciplina, nm_disciplina
				from tb_disciplina
					where cd_disciplina
						in (select cd_disciplina
								from tb_matricula)) as d
			on d.cd_disciplina = m.cd_disciplina
			join tb_turma as t
				on t.cd_turma = m.cd_turma
				join tb_turno as tu
					on tu.cd_turno = t.cd_turno
					join tb_curso c
						on c.cd_curso = t.cd_curso   
						order by tu.nm_turno;