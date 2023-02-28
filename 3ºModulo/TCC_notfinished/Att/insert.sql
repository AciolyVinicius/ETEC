INSERT INTO `tb_aviso` (`cd_aviso`, `cd_curso`, `cd_turma`, `nm_aviso`, `ds_aviso`, `im_anexo`, `cd_usuario`) VALUES
(1, NULL, NULL, 'OI', 'fewfewe', '', 1),
(2, 1, NULL, 'Azul', '123', '', 1),
(3, NULL, 1, 'afqwf', 'ewgqe', '', 1);

INSERT INTO `tb_curso` (`cd_curso`, `nm_curso`, `ds_curso`) VALUES
(1, 'Informática', 'Informática voltada a programação'),
(2, 'Ensino Médio', 'Ensino Médio de alta qualidade');

INSERT INTO `tb_disciplina` (`cd_disciplina`, `nm_disciplina`, `ds_disciplina`, `qt_carga_horaria`) VALUES
(1, 'Banco de Dados', 'TLBD', 200),
(2, 'Programação', 'LP', 200),
(3, 'Português', 'LTT', 200),
(4, 'Geografia', NULL, 75),
(5, 'História', NULL, 75),
(6, 'Sociologia', NULL, 75),
(7, 'Artes', NULL, 75),
(8, 'Química', NULL, 75),
(9, 'Física', NULL, 75),
(10, 'Matemática', NULL, 100);

INSERT INTO `tb_instituicao` (`cd_instituicao`, `nm_instituicao`, `nm_fantasia`, `cd_cnpj`, `cd_contato1`, `cd_contato2`, `nm_email`, `nm_rua`, `cd_numeracao`, `nm_bairro`, `nm_cidade`, `nm_estado`, `cd_cep`, `cd_mec`, `cd_alvara`) VALUES
(1, 'Escola Técnica Doutora Ruth Cardoso', 'Etec Dra Ruth Cardoso', '25364625350196', '334587341', '234435553', 'etec@email.com', 'Praça Coronel Lopes', '123', 'Centro', 'São Vicente', 'SP', '11310-020', '121432424', '435322221');

INSERT INTO `tb_item_curso` (`cd_item_curso`, `cd_curso`, `cd_disciplina`) VALUES
(1, 1, 1),
(2, 1, 2),
(3, 1, 3),
(4, 2, 3),
(5, 2, 4),
(6, 2, 5),
(7, 2, 6),
(8, 2, 7),
(9, 2, 8),
(10, 2, 9),
(11, 2, 10);

INSERT INTO `tb_tipo` (`cd_tipo`, `nm_tipo`) VALUES
(1, 'Aluno'),
(2, 'Representante'),
(3, 'Professor'),
(4, 'Coordenador de Curso'),
(5, 'Secretaria'),
(6, 'Diretor'),
(7, 'Administrador');

INSERT INTO `tb_turma` (`cd_turma`, `cd_turno`, `cd_curso`, `nm_turma`, `ds_turma`, `dt_inicio`, `dt_final`, `qt_capacidade`) VALUES
(1, 1, 1, '1I1', 'Informática Matutina', '2018-01-01', '2018-12-31', 35),
(2, 3, 1, '1I3', 'Informática Noturno', '2018-05-09', '2018-05-18', 40);

INSERT INTO `tb_turno` (`cd_turno`, `nm_turno`, `ds_turno`, `hr_inicio`, `hr_final`) VALUES
(1, 'Manhã', 'Turno de manhã', '07:00:00', '12:00:00'),
(2, 'Vespertino', 'Turno a tarde', '13:30:00', '18:00:00'),
(3, 'Noturno', 'Turno a noite', '19:00:00', '22:55:00');


INSERT INTO `tb_usuario` (`cd_usuario`, `nm_usuario`, `nm_sobrenome`, `dt_nascimento`, `nm_email`, `im_foto`, `cd_cpf`, `cd_rg`, `cd_senha`, `cd_contato1`, `cd_contato2`, `cd_cep`, `nm_rua`, `cd_numeracao`, `nm_bairro`, `nm_cidade`, `nm_estado`, `nm_responsavel`, `cd_contato_responsavel`, `nm_email_responsavel`, `cd_cpf_responsavel`, `cd_tipo`, `cd_turma`) VALUES
(1, 'Alexandre', 'Saura', '1999-05-21', 'alexandresaura21@gmail.com', '/img/alexandresaura21@gmail.com/img_perfil.jpg', '33447059460', '358007288', '$2y$14$umCTFk2al9CVjeAd5URtce0ZgbJurNkqPamvJTgiVjz5LZw9ARubi', '997845124', '', '04302021', 'Rua Paracatu', '20', 'Parque Imperial', 'São Paulo', 'SP', 'Pedro de Souza Gonçalvez', '35993306885', 'pedrosouza@email.com', '04495955365', 7, 1),
(2, 'Pedro', 'Moraes', '2000-02-11', 'pedro.moraes@email.com', '', '40963073354', '483024971', 'pedro123', '997854147', '', '11330560', 'Rua Vereador José Vicente de Barros', '15', 'Vila Margarida', 'São Vicente', 'SP', 'Kevin Anderson Henrique Drumond', '95993306792', 'respon', '56116465226', 1, 1),
(3, 'Matheus', 'Guedes', '2000-01-12', 'matheus.guedes@email.com', '', '48590357473', '194793187', 'matheus123', '999999999', '', '11330070', '21 de setembro', '120', 'parque bitaru', 'São Vicente', 'SP', 'Renan Enzo da Rocha', '995847151', 'renanenzodarocha_@sp.gov.br', '27500027885', 1, 1),
(4, 'Guilherme', 'Nunes', '2001-06-13', 'guilherme.nunes@email.com', '', '22240201630', '182967475', 'guilherme123', '99958451', '', '11355150', 'Rua Antônio da Costa', '23', 'Cidade Naútica', 'São Vicente', 'SP', 'Oliver Calebe Vinicius Alves', '922673298', 'olivercalebeviniciusalves@thewishes.com.br', '53540808868', 1, 1),
(5, 'Gustavo', 'Henrique', '2000-08-15', 'gustavo.henrique@email.com', '', '31724699644', '280750857', 'gustavo123', '99851254', '', '11350270', 'Rua Francisco Dias Jorge', '15', 'Cidade Naútica', 'São Vicente', 'SP', 'Gabriel Ducati Gomes', '997098161', 'gabriel.gomes@yahoo.com', '99107371756', 1, 1),
(6, 'Henrique', 'Silva', '2001-10-19', 'henrique.silva@email.com', '', '43986036202', '409464156', 'henrique123', '998526548', '', '11349130', 'Rua Deputado Pinheiro Júnior', '11', 'Conjunto Residencial Humaitá', 'São Vicente', 'SP', 'Arthur Teixeira Machado', '957175988', 'arthur.machado@uol.com.br', '43780336588', 1, 1),
(7, 'Juliano', 'Moraes', '2000-11-20', 'juliano.moraes@email.com', '', '46876532003', '161182331', 'juliano123', '997585488', '', '11330256', 'Rua Projetada Três', '2', 'Parque Bitaru', 'São Vicente', 'SP', 'Helena Teixeira Gomes', '916884486', 'helena.gomes@hotmail.com', '77869104094', 1, 1),
(8, 'Helaman', 'Spadari', '2000-04-21', 'helaman.spadari@email.com', '', '75644085295', '181890732', 'helaman123', '997585859', '', '11310440', 'Rua Visconde de Tamandaré', '100', 'Centro', 'São Vicente', 'SP', 'Lara Machado Teixeira', '938976238', 'lara.teixeira@yahoo.com', '25736291398', 1, 1),
(9, 'Pedro', 'Guedes', '2001-02-22', 'pesdro.guedes@email.com', '', '84041315549', '149330285', 'pedro321', '999585421', '', '11330205', 'Praça Infante Dom Henrique', '21', 'Parque Bitaru', 'São Vicente', 'SP', 'Giovana Ducati Gomes', '913190739', 'giovana.gomes@uol.com.br', '88864892346', 1, 1),
(10, 'Anna', 'Bovo', '2000-01-05', 'anna.bovo@email.com', '', '50169718387', '441491649', 'anna123', '997858474', '', '11310300', 'Praça Doutor Bernardino de Campos', '35', 'Centro', 'São Vicente', 'SP', 'Ana Paula Amaral Ducati', '982262939', 'ana paula.ducati@uol.com.br', '47177648038', 1, 1),
(11, 'Adriana', 'Souza', '2001-09-04', 'adriana.souza@email.com', '', '28777717929', '271392332', 'adriana123', '997585891', '', '11390230', 'Rua Doutor Emílio Carlos', '110', 'Vila Cascatinha', 'São Vicente', 'SP', 'Mauro Machado Teixeira', '968463351', 'mauro.teixeira@uol.com.br', '60498838668', 1, 1),
(12, 'Adriano', 'Martins', '2000-08-05', 'adriano.martins@email.com', '', '53479505001', '220222514', 'adriano123', '997478851', '', '11325230', 'Rua dos Índios', '8', 'Parque Prainha', 'São Vicente', 'SP', 'João Thomas Sebastião Ribeiro', '995538727', 'joaothomassebastiaoribeiro@saojose.biz', '65553095808', 1, 1),
(13, 'Julia', 'Martins', '2001-05-02', 'julia.martins@email.com', '', '54479505001', '414225818', 'julia123', '998515452', '', '11349295', 'Rua José Ramos de Oliveira', '29', 'Conjunto Residencial Humaitá', 'São Vicente', 'SP', 'Arthur Gomes Amaral', '994361878', 'arthur.amaral@icloud.com', '37741679589', 1, 1),
(14, 'Joao', 'Manoel', '2001-07-01', 'joao.manoel@email.com', '', '31419654209', '370289389', 'joao123', '998526595', '', '11340350', 'Rua Alberto Sá de Souza Varella', '10', 'Esplanada dos Barreiros', 'São Vicente', 'SP', 'Lucas Teixeira Gomes', '983016310', 'lucas.gomes@uol.com.br', '23339412278', 1, 1),
(15, 'Renan', 'Praxedes', '2000-12-15', 'renan.praxedes@email.com', '', '29456685489', '445921432', 'renan123', '998595623', '', '11330702', 'Avenida A', '105', 'Vila Margarida', 'São Vicente', 'SP', 'Davi Amaral Machado', '955204619', 'davi.machado@hotmail.com', '75040456247', 1, 1),
(16, 'Leonardo', 'Tavares', '2001-03-12', 'leonardo.tavares@email.com', '', '80886449090', '491486613', 'leonardo123', '991529595', '', '11330777', 'Rua Dezessete', '19', 'Vila Margarida', 'São Vicente', 'SP', 'Pedro Gomes Amaral', '941150297', 'pedro.amaral@yahoo.com', '51914691270', 1, 1),
(17, 'Guilherme', 'França', '2000-12-16', 'guilherme.franca@email.com', '', '9017334584', '414225818', 'guilherme123', '998596532', '', '11347510', 'Rua Onze', '56', 'Jardim Irmã Dolores', 'São Vicente', 'SP', 'Maria Gomes Teixeira', '934745454', 'maria.teixeira@icloud.com', '92170964746', 1, 1),
(18, 'Luiz', 'Fernandes', '2001-04-19', 'luiz.fernandes@email.com', '', '59479505001', '375381296', 'luiz123', '991253535', '', '11346005', 'Praça Dário Aredes Lacerda', '45', 'Parque das Bandeiras', 'São Vicente', 'SP', 'Kauê Benjamin Galvão', '996326613', 'kauebenjamingalvao-96@ruizonline.com.br', '25604184365', 1, 1),
(19, 'Vinícius', 'Acioly', '2000-06-29', 'vinicius.acioly@email.com', '', '99958350106', '191995356', 'vinicius123', '998353635', '', '11345215', 'Rua Oito', '65', 'Vila Iolanda', 'São Vicente', 'SP', 'Kauê Sebastião Almada', '985234362', 'kkauesebastiaoalmada@estruturalbr.com.br', '01876038047', 1, 1),
(20, 'Guilherme', 'Lotito', '2002-08-30', 'guilherme.lotito@email.com', '', '31799334023', '163955268', 'guilherme321', '9984546592', '', '11390280', 'Rua Alemanha', '78', 'Catiapoã', 'São Vicente', 'SP', 'Lorenzo Diego Moreira', '983306283', 'lorenzodiegomoreira-75@yahoo.fr', '08214425204', 1, 1),
(21, 'Pedro', 'Luiz', '2000-09-10', 'pedro.luiz@email.com', '', '86525822629', '210889561', 'pedro132', '998845112', '', '11310150', 'Rua Antônio Frederico Ozanan', '38', 'Morro dos Barbosas', 'São Vicente', 'SP', 'Guilherme Caleb Cauê Nunes', '995276852', 'guilhermecalebcauenunes@hp.com', '76409626339', 1, 1),
(22, 'Mateus', 'Saura', '2002-02-20', 'mateus.saura@email.com', '', '4411083779', '134412965', 'mateus123', '997585895', '', '11345445', 'Loteamento Parque Industrial Imigrantes', '67', 'Samarita', 'São Vicente', 'SP', 'Cláudio Arthur Pinto', '993829351', 'claudioarthurpinto@iclud.com', '21405630345', 1, 1),
(23, 'Mariana', 'Barbosa', '2002-01-29', 'mariana.barbosa@email.com', '', '12434218946', '464111122', 'mariana123', '997152102', '', '11350200', 'Rua Guilherme Raposo de Almeida', '98', 'Cidade Naútica', 'São Vicente', 'SP', 'Arthur Nelson Araújo', '983971375', 'arthurnelsonaraujo_@comercialmendes.net', '00618261702', 1, 1),
(24, 'Giovana', 'Chaves', '2000-03-27', 'giovana.chaves@email.com', '', '53406360890', '30369819', 'giovana123', '997458525', '', '11349335', 'Praça Beato José de Anchieta', '97', 'Conjunto Residencial Humaitá', 'São Vicente', 'SP', 'Luan Lucas Breno da Conceição', '998246029', 'luanlucasbrenodaconceicao_@unitau.com.br', '71696219329', 1, 1),
(25, 'Talita', 'Meneguim', '2001-05-16', 'talita.meneguim@email.com', '', '79862146192', '276035276', 'talita123', '998589189', '', '11330210', 'Rua Japão', '105', 'Parque Bitaru', 'São Vicente', 'SP', 'Antonio Bento Severino Cardoso', '985462125', 'aantoniobentoseverinocardoso@origembr.com', '41466316101', 1, 1),
(26, 'Dafine', 'Machado', '2000-03-27', 'dafine.machado@email.com', '', '82127001940', '134426204', 'dafine123', '998452514', '', '11347515', 'Rua Goiás', '26', 'Jardim Irmã Dolores', 'São Vicente', 'SP', 'Geraldo Theo Tomás Porto', '981882567', 'geraldotheotomasporto_@ouplook.com', '23116844933', 1, 1),
(27, 'Giovanna', 'Andrade', '2002-03-20', 'giovanna.adrade@email.com', '', '50071033904', '260897346', 'giovanna132', '997154898', '', '11330770', 'Rua Dois Mil Cento e Sessenta e Sete', '106', 'Vila Margarida', 'São Vicente', 'SP', 'Tiago André Viana', '985419005', 'tiagoandreviana-90@rubens.adm.br', '62536223744', 1, 1),
(28, 'Velma', 'Red', '2000-03-10', 'velma.red@email.com', '', '62980630217', '369734154', 'velma123', '998989898', '', '11330120', 'Rua Agostinho Pereira Pinto Júnior', '49', 'Parque Bitaru', 'São Vicente', 'SP', 'Francisco Thomas Danilo da Silva', '981507704', 'franciscothomasdanilodasilva-73@biconsult.com.br', '81203298056', 1, 1),
(29, 'Lucas', 'Veríssimo', '2001-03-10', 'lucas.blue@email.com', '', '16280484505', '378977891', 'lucas123', '997788995', '', '11390480', 'Rua Engenheiro Mateus Maylask', '200', 'Catiapoã', 'São Vicente', 'SP', 'Juliana Giovana Tereza Duarte', '988603203', 'jjulianagiovanaterezaduarte@hotmail', '92237072264', 1, 1),
(30, 'Pablo', 'Escobare', '2002-03-13', 'pablo.yellow@email.com', '', '60701629517', '417361968', 'pablo123', '995252525', '', '11330829', 'Rua Vinte e Dois', '104', 'Vila Margarida', 'São Vicente', 'SP', 'Isabel Rayssa Joana Mendes', '998182380', 'isabelrayssajoanamendes-73@academiahct.com.br', '65166634403', 1, 1),
(31, 'Azul', 'ef', '2018-05-09', 'azul@gmail.com', '/img/azul@gmail.com/img_perfil.jpg', '123456', '32434224', '$2y$14$.UIXv3WLbt6nCWP9woQrKOI3gfTfsIBt2NB7LNkpvfEq9zr0DsQ6K', '32r23', '', '24244', '34', '353', '434', '43', 'fs', '', '', '', '', 1, 1);

