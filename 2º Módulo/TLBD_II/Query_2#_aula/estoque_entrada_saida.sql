show databases;

create database estoque;

use estoque;

create table tb_cliente(
	cd_cliente int not null,
	nm_cliente varchar(45),
	cd_cpf char(11),
	constraint pk_cliente primary key (cd_cliente)
	);


create table tb_notas_saida(
	cd_saida int not null,
	dt_saida date,
	cd_cliente int,
	constraint fk_nota_cliente
		foreign key (cd_cliente)
			references tb_cliente(cd_cliente),
	constraint pk_nota_cliente primary key (cd_saida));

create table tb_categoria(
	cd_categoria int not null,
	nm_categoria varchar(45),
	constraint pk_categoria primary key (cd_categoria));

create table tb_produto(
	cd_produto int not null,
	nm_produto varchar(45),
	qt_estoque tinyint,
	cd_categoria int,
	constraint pk_produto 
		primary key (cd_produto),
	constraint fk_produto_categoria 
		foreign key (cd_categoria) 
			references tb_categoria(cd_categoria));


create table item_saida(
	qt_saida_produto tinyint,
	vl_produto decimal(9,2),
	cd_produto int,
	cd_saida int,
	constraint fk_item_saida 
		foreign key(cd_saida)
			references tb_notas_saida(cd_saida),
	constraint fk_saida_produto 
		foreign key(cd_produto)
			references tb_produto(cd_produto));

show tables;

create table tb_fornecedor(
	cd_fornecedor int not null,
	nm_fantasia varchar(45),
	cd_cnpj char(14),
	constraint pk_fornecedor
		primary key (cd_fornecedor));

create table tb_notas_entrada(
	cd_entrada int not null,
	constraint pk_entrada primary key(cd_entrada),
	dt_entrada_produto date);

create table item_entrada(
	cd_entrada int,
	cd_produto int,
	qt_entrada_produto tinyint,
	vl_produto decimal(9,2),
	constraint fk_item_entrada foreign key (cd_entrada) references tb_notas_entrada(cd_entrada),
	constraint fk_entrada_produto foreign key (cd_produto) references tb_produto(cd_produto));