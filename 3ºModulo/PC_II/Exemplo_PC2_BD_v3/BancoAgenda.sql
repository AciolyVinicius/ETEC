create database agenda;
use agenda;


create table vinculo(
	  codigo int not null auto_increment,
    tipo varchar (45)not null,

    constraint pk_vinculo
		primary key(codigo)
);

create table contato(
	telefone char(13) not null,
    nome varchar(45) not null,
    tipo int not null,

    constraint pk_contato
		primary key(telefone),
        
	constraint fk_contato_vinculo
		foreign key(tipo)
			references vinculo(codigo)
);

insert into vinculo(tipo) values
('Familia'),
('Trabalho'),
('Escola'),
('Amigos');