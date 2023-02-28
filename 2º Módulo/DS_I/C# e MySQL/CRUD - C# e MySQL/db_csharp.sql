create database db_csharp;

use db_csharp;

create table tb_usuario(
	cd_usuario int not null auto_increment,
    nm_usuario varchar(50),
    nm_email varchar(100),
    
    constraint pk_usuario
		primary key(cd_usuario)
);



