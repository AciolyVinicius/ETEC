use db_suprimentos;

select * from tb_venda;

/*Obter o numero, valor e a data das vendas realizadas para consumidor 1*/

select c.id_numero_consumidor as 'Consumidor', 
v.id_numero_venda as 'Número Compras', 
v.vl_venda as 'Valor Compra', 
v.dt_venda as 'Data Compra'
	from tb_venda v join tb_consumidor c
		on c.id_numero_consumidor = v.id_numero_consumidor
			where c.id_numero_consumidor = 1;

/*Obter o nome do consumidor 1 e a soma das vendas para ele realizadas*/

select c.nm_consumidor as 'Nome Consumidor 1',
sum((v.vl_venda)) as 'Soma Compras'
	from tb_venda v join tb_consumidor c
		on c.id_numero_consumidor = v.id_numero_consumidor
			where c.id_numero_consumidor = 1;

/*Obter o nome do consumidor 1 e a média das vendas para ele realizadas*/

select c.nm_consumidor as 'Nome Consumidor 1', 
avg((v.vl_venda)) as 'Média Compras'
	from tb_venda v join tb_consumidor c
		on c.id_numero_consumidor = v.id_numero_consumidor
			where c.id_numero_consumidor = 1;

/*Obter o nome do consumidor 1, a menor e a maior venda para ele realizada*/

select c.nm_consumidor as 'Nome Consumidor 1',
max((v.vl_venda)) as 'Maior Compra',
min((v.vl_venda)) as 'Menor Compra'
	from tb_venda v join tb_consumidor c
		on c.id_numero_consumidor = v.id_numero_consumidor
			where c.id_numero_consumidor = 1;

/*Mostrar a hirerarquia (com numero e nome) dos departamentos da empresa*/

select * from tb_depto;

select d.id_numero_depto as 'Numero Departamento',
d.nm_depto as 'Nome Departamento'
from tb_depto d;