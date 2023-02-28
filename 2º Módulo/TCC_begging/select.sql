select  cur.id,
u.nome Nome,
f.dt_frequencia Dia,
f.status Presente,
c.nome Curso,
d.nome Disciplina
	from users u right join curso_user cur
		on u.id = cur.users_id
		left join disciplina_curso dc
			on cur.disciplina_curso_id = dc.id
		right join frequencia f
			on f.curso_user_id = cur.id
			left join cursos c
				on c.id = dc.cursos_id
				left join disciplinas d
					on d.id = dc.disciplinas_id
						where u.id=1;