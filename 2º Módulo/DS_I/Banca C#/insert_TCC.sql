 insert into users (endereco, nome, email, cpf, rg, passwords, contato1, contato2, responsavel, contato_responsavel, email_responsavel, cpf_responsavel) values 
("", "Administrador","admin@hotmail.com", "000000000000", "0000000000", "admin123", "34334455", "997777777", "", "", "", ""),
("Rua Benedito Calisto 233, São Vicente/SP","José de Silva", "huechibalastain@hotmail.com", "645893948583", "8549284502", "supersenha", "33642945", "9974039499", "Marcelo Fernando", "997859609", "quemarherege@hotmail.com", "07089894568"),
("Rua dos Perdidos 1, Rio Branco/AC","Gutemberg Tivit", "gutemberg@hotmail.com","654898257943", "8567483759", "password123", "99734590", "996575843", "João da Silva", "995438248", "josedequebra@hotmail.com", "75849384929"),
("Avenida Josicredison 345, Rio de Janeiro/RJ", "Ruelson da Silva",  "ruaviela@hotmail.com","540295830945", "7448389582", "123PasswordSenha@", "99865432", "994657840", "Patricia Oliveira", "997487340", "filhao123oficial@hotmail.com", "88538492848"),
("Rua dos Arautos 007, Manaus/AM" ,"Janicleviston Moraes", "janicleviston@hotmail.com", "010101010101", "0101010101", "senha", "34561043", "995673876", "Padre Marcelo", "997777777", "emnobredepadredefilideespiriti@hotmail.com", "07070707077");

insert into turnos values 
(1, "Z", "Repetentes", "12:00", "17:00"),
(2, "A", "Manhã", "7:00", "12:00"),
(3, "B", "Tarde", "13:30", "18:00"),
(4, "C", "Noite", "18:30", "23:00");

insert into disciplinas values
(1, "Matemática Avançada", "Estudo de avançado de matemática", 500),
(2, "Química", "Estudo de química", 50),
(3, "Matemática", "Estudo de matemática", 75);

insert into turmas values 
(1, "A-1", "2014-02-01", "2016-11-30", 40),
(2, "A-2", "2014-02-01", "2016-11-30", 40),
(3, "B-1", "2014-02-01", "2017-11-30", 40),
(4, "B-2", "2014-02-01", "2017-11-30", 40);

insert into cursos values 
(1, "Técnico de Matemática", "Formação de matemáticos preparados para o mercado de trabalho", 750),
(2, "Ensino Básico Geral", "Estudo de matemática", 500);

insert into materiais values
(1, "Livro A3H", "Geometria avançada", ""),
(2, "Química", "Química em seu todo", ""),
(3, "Matemática", "Conceitos Básicos em Matemática", "");

insert into disciplina_curso (cursos_id,
turnos_id, turmas_id) values
(1, 4, 1),
(1, 4, 2),
(2, 2, 3),
(2, 2, 4);

insert into material_disciplina (materiais_id, disciplina_curso_id) values
(1, 1),
(3, 1),
(1, 2),
(3, 3),
(2, 4);

insert into bate_papo values
(1, "Só a classe A", "2014-02-01", "2014-11-30", false, 1),
(2, "A-2", "2016-02-01", "2014-11-30", false, 2),
(3, "A da madrugada", "2014-02-01", "2016-11-30", false, 3);

insert into mensagens values
(1, 1, "2014-04-03 15:05", "Salve Galera, como vocês estão??"),
(2, 2, "2014-10-03 16:45", "Oi!!!!"),
(3, 2, "2014-10-03 16:50", "Oi cara"),
(4, 3, "2014-10-03 16:50", "Como vocês estão??");

insert into curso_user values 
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 1);

insert into aulas values
(1, 2, "Explanação sobre Geometria Plana", "2014-03-01", "13:30", "15:35"),
(2, 2, "Cálculo de Áreas na Engenharia Civil", "2014-03-02", "13:30", "15:35"),
(3, 1, "Sobre Química Avançada", "2014-03-02", "07:00", "08:20");

insert into frequencia values
(1, "2014-03-01",true,1, 1, ""),
(2, "2014-03-02",false, 1, 2, ""),
(3, "2014-03-01",true, 2, 3, ""),
(4, "2014-03-02", true, 1, 2, "");

insert into anotacoes values
(1, "Aula 1", "Hoje foi legal", "Hoje a aula foi muito interessante, foi tão interessante que eu acabei por gravar tudo, por isso eu não vou anotar nada, eu sou muito inteligente.", "2014-05-29", 1),
(2, "Aula 2", "Aula do professor Xavie", "Bom, ele colocou tudo na minha mente, agora eu passo em uma faculdade pública.", "2014-03-22", 2);

insert into avaliacoes values
(1, "Prova Teórica", "Fazer um resumão da matéria", "2014-05-16", 8, 2),
(2, "Atividade Prática", "Elaborar uma maquete da matéria vista em sala", "2014-09-15",10, 1);

insert into roles (nome, ds_role) values
("1", "Administrador"),
("2", "Gerenciador"),
("3", "Professor"),
("4", "Aluno");

insert into role_user (users_id, roles_id) values
(1, 1),
(2, 3),
(3, 4),
(4, 4),
(5, 4);

insert into estados (nome, sg_estado) values
("Acre","AC"),
("Alagoas","AL"),
("Amapá","AP"),
("Amazonas","AM"),
("Bahia","BA"),
("Ceará","CE"),
("Distrito Federal","DF"),
("Espírito Santo","ES"),
("Goiás","GO"),
("Maranhão","MA"),
("Mato Grosso","MT"),
("Mato Grosso do Sul","MS"),
("Minas Gerais","MG"),
("Pará","PA"),
("Paraíba","PB"),
("Paraná","PR"),
("Pernambuco","PE"),
("Piauí","PI"),
("Rio de Janeiro","RJ"),
("Rio Grande do Norte","RN"),
("Rio Grande do Sul","RS"),
("Rondônia","RO"),
("Roraima","RR"),
("Santa Catarina","SC"),
("São Paulo","SP"),
("Sergipe","SE"),
("Tocantins", "TO");

-- Parte para C#
insert into tb_disciplina (nm_disciplina, ds_disciplina) values
("Matemática", "Matemática em Geral"),
("Java", "Aprender a programar na linguagem Java"),
("Inglês","Língua estrangeira");

insert into tb_disciplinar (cd_disciplina_curso, cd_disciplina) values 
(2, 1),
(2, 2),
(1, 1);

select d.* from tb_disciplina d
        where d.cd_disciplina not in (select dr.cd_disciplina from tb_disciplinar dr);
        
select * from tb_disciplina;

SELECT d.* FROM tb_disciplina d
                WHERE d.cd_disciplina NOT IN (SELECT dr.cd_disciplina
												FROM tb_disciplinar dr
													LEFT JOIN tb_disciplina d
														ON  dr.cd_disciplina = d.cd_disciplina
														WHERE d.nm_disciplina <>  "Matemática");
                                                        
SELECT t.* FROM turnos t
	RIGHT JOIN disciplina_curso dc
		ON t.id = dc.turnos_id
		LEFT JOIN cursos c
			ON dc.cursos_id = c.id  
			WHERE c.nome LIKE 'Técnico%'
				GROUP BY t.id; 
select id from cursos where nome like replace('Ensino Básico Geral
', '\n', '');
insert into disciplina_curso (cursos_id, turnos_id, turmas_id) values
((select id from cursos where nome like replace('Ensino Básico Geral
', '\n', '')), (select id from turnos where ds_turno like 'Manhã'), (select id from turmas where nome like 'A-1'));

insert into tb_disciplinar (cd_disciplina_curso, cd_disciplina) values
((select id from disciplina_curso where cursos_id =  (select id from cursos where nome like 'Ensino Básico Geral') AND turnos_id = (SELECT id FROM turnos WHERE ds_turno LIKE 'Manhã') AND turmas_id = (SELECT id FROM turmas WHERE nome LIKE 'A-1')),(select cd_disciplina from tb_disciplina where nm_disciplina like 'Matemática'));
