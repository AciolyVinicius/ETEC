CREATE VIEW `dbSaga`.`Tarefas do Aluno` AS 
select t.nm_tarefa 'Tarefas', sum(t.nm_tarefa) 'Total de tarefas' 
	from tb_tarefa t left join item_geral_usuario ug 
	on t.cd_geral_usuario = ug.cd_geral_usuario
		left join tb_usuario u 
		on ug.cd_usuario = u.cd_usuario 
			left join tb_instituicao ins 
			on u.cd_instituicao = ins.cd_instituicao 
				where ins.nm_instituicao like 'teste' and u.nm_usuario like 'teste';

CREATE VIEW `dbSaga`.`Avaliacões do Aluno` AS
select a.nm_avaliacao 'Avaliacoes', sum(a.nm_avaliacao) 'Total de Avaliacoes' 
	from tb_avaliacao a left join item_geral_usuario gr 
	on a.cd_geral_usuario = gr.cd_geral_usuario
		left join tb_usuario u
		on gr.cd_usuario = u.cd_usuario
			left join tb_instituicao ins 
			on u.cd_instituicao = ins.cd_instituicao
				where ins.nm_instituicao like 'teste' and u.nm_usuario = 'teste';

CREATE VIEW `dbSaga`.`Material das Disciplinas` AS
	select d.nm_disciplina 'Disciplina', m.ds_material 'Descrição do Material'
		from tb_disciplina d right join item_cdtt cdtt
			on d.cd_disciplina = cdtt.cd_disciplina
			right join item_material_cdtt md 
				on cdtt.cd_cdtt = md.cd_cdtt
				left join tb_material m
					on md.cd_material = m.cd_material;

CREATE VIEW `dbSaga`.`Informações do Usuário` as select u.nm_usuario 'Usuario', i.nm_instituicao 'Instituicao', i.cd_contato1 'Contato', i.nm_email 'Email', a.nm_avaliacao 'Avaliacao'
	from tb_usuario u
		left join tb_instituicao i
			on u.cd_instituicao = i.cd_instituicao
				right join item_geral_usuario it
					on u.cd_usuario = it.cd_usuario
						right join tb_avaliacao as a
							on it.cd_geral_usuario = a.cd_geral_usuario;

CREATE VIEW `dbSaga`.`Turma` AS
	select tur.nm_turma 'Nome da turma', tur.qt_usuario 'Quantidade de usuários da turma', bp.nm_bate_papo 'Sala de bate papo'
		from tb_turma tur right join item_cdtt cdtt on tur.cd_turma = cdtt.cd_turma
			right join tb_bate_papo bp on cdtt.cd_cdtt = bp.cd_cdtt;