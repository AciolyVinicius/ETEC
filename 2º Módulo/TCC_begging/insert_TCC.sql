 insert into users values 
(1, "Administrador", "2000-07-07", "admin@hotmail.com", "", "000000000000", "0000000000", "admin123", "34334455", "997777777", "", "", "", ""),
(2, "José de Silva", "1980-07-29", "huechibalastain@hotmail.com", "", "645893948583", "8549284502", "supersenha", "33642945", "9974039499", "Marcelo Fernando", "997859609", "quemarherege@hotmail.com", "07089894568"),
(3, "Gutemberg Tivit", "1990-10-11", "gutemberg@hotmail.com", "", "654898257943", "8567483759", "password123", "99734590", "996575843", "João da Silva", "995438248", "josedequebra@hotmail.com", "75849384929"),
(4, "Ruelson da Silva", "1999-02-21", "ruaviela@hotmail.com", "", "540295830945", "7448389582", "123PasswordSenha@", "99865432", "994657840", "Patricia Oliveira", "997487340", "filhao123oficial@hotmail.com", "88538492848"),
(5, "Janicleviston Moraes", "1955-05-20", "janicleviston@hotmail.com", "", "010101010101", "0101010101", "senha", "34561043", "995673876", "Padre Marcelo", "997777777", "emnobredepadredefilideespiriti@hotmail.com", "07070707077");

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
(1, "A-1", "2014-02-01", "2014-11-30", 40),
(2, "A-2", "2014-02-01", "2016-11-30", 40),
(3, "B-3", "2014-02-01", "2017-11-30", 40);

insert into cursos values 
(1, "Técnico de Matemática", "Formação de matemáticos preparados para o mercado de trabalho", 750),
(2, "Ensino Básico Geral", "Estudo de matemática", 500);

insert into materiais values
(1, "Livro A3H", "Geometria avançada", ""),
(2, "Química", "Química em seu todo", ""),
(3, "Matemática", "Conceitos Básicos em Matemática", "");

insert into material_disciplina values
(1, 5, 1),
(2, 2, 2),
(3, 3, 2),
(4, 2, 3),
(5, 3, 3);

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

insert into role_user values
(1, 1, 1);