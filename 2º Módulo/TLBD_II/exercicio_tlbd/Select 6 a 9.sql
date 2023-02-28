-- 6
select iv.vl_total_produto, v.vl_venda
	from item_venda iv left join tb_venda v
		on iv.id_numero_venda = v.id_numero_venda;

-- 7
select v.id_numero_venda "ID da venda",
v.vl_venda "Valor da venda",
nf.dt_nota "Data da nota fiscal"
	from tb_nota_fiscal nf left join tb_venda v
		on nf.id_numero_venda = v.id_numero_venda;
-- 8
select v.id_numero_venda "ID da venda",
v.vl_venda "Valor da venda",
v.sg_natureza_venda "Sigla da natureza da venda",
cr.id_numero_conta_receber "ID da conta a receber",
cr.vl_conta "Valor da conta a receber",
cr.dt_vencimento "Data de vencimento da conta a receber"
	from tb_conta_receber cr join tb_venda v
		on v.id_numero_venda = cr.id_numero_venda;
-- 9
select f.id_numero_fornecedor "ID do fornecedor",
p.ds_produto "Descrição do produto",
d.id_numero_depto "ID do departamento",
d.nm_depto "Nome do departamento"
	from tb_fornecedor f right join tb_catalogo c
		on f.id_numero_fornecedor = c.id_numero_fornecedor
		left join tb_produto p
			on c.cd_produto = p.cd_produto
			left join tb_depto d
				on p.id_numero_depto = d.id_numero_depto;
			
