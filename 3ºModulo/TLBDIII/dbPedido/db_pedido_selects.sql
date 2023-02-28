CREATE VIEW vw_metro (Codigo,Nome,Unidade) AS
	select cd_produto, nm_produto, sg_unidade
		from tb_produto
			where sg_unidade = 'm';

show tables;
desc vw_metro;
select * from vw_metro where nome like 'l%';

create view vw_salario (Codigo,Nome,Salario, Anual) as
	select cd_vendedor, nm_vendedor, vl_salario, vl_salario*12
		from tb_vendedor;
	
select * from vw_salario;

select * from tb_pedido 
	where cd_vendedor in (select cd_vendedor from tb_vendedor)
		and cd_cliente in (select cd_cliente from tb_cliente);

select * from vw_lista_pedida;

select * from tb_cliente;

select * from vw_clientes_joao;

