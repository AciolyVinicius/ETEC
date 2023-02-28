-- retornar os produtos agrupados por categoria e ordenados por categorias e produtos 
select p.nm_produto as Produto, c.nm_categoria as Categoria
	from produto as p join categoria as c
		on c.cd_categoria = p.cd_categoria
			group by c.nm_categoria, p.nm_produto
				order by c.nm_categoria, p.nm_produto;

select count(p.nm_produto) as "Quantidade de Produtos", c.nm_categoria as Categoria
	from produto as p join categoria as c
		on c.cd_categoria = p.cd_categoria
			group by c.nm_categoria
				order by c.nm_categoria, p.nm_produto;

select
ne.dt_nota_entrada as "Data de entrada",
f.nm_fornecedor as "Nome do Fornecedor",
c.nm_categoria as "Nome da Categoria",
p.nm_produto "Nome do produto",
ie.qt_entrada "Quantidade de Entrada",
ie.vl_produto "Valor do produto" 
	from
	notas_entrada ne,
	fornecedor f,
	categoria c,
	produto p,
	itens_entrada ie
		where
		c.cd_categoria = p.cd_categoria and
		f.cd_fornecedor = ne.cd_fornecedor and
		ie.cd_entrada = ne.cd_entrada and
		p.cd_produto = ie.cd_produto
			group by c.nm_categoria,
			p.nm_produto,
			f.nm_fornecedor
				order by c.nm_categoria, p.nm_produto;

select
ne.dt_nota_entrada as "Data de entrada",
f.nm_fornecedor as "Nome do Fornecedor",
c.nm_categoria as "Nome da Categoria",
p.nm_produto "Nome do produto",
ie.qt_entrada "Quantidade de Entrada",
ie.vl_produto "Valor do produto"
	from notas_entrada ne join fornecedor f
		on f.cd_fornecedor = ne.cd_fornecedor
		join itens_entrada ie
			on ie.cd_entrada = ne.cd_entrada
			join produto p
				on p.cd_produto = ie.cd_produto
				join categoria c
					on c.cd_categoria = p.cd_categoria
					order by ne.dt_nota_entrada , f.nm_fornecedor, c.nm_categoria, p.nm_produto;

-- Alterar o exemplo anterior e retornar, além de um campo calculado do total de cada item de entrada
-- os produtos que entraram com um subtotal por item (>) que R$100,00
select
ne.dt_nota_entrada as "Data de entrada",
f.nm_fornecedor as "Nome do Fornecedor",
c.nm_categoria as "Nome da Categoria",
p.nm_produto "Nome do produto",
ie.qt_entrada "Quantidade de Entrada",
ie.vl_produto "Valor do produto",
(ie.qt_entrada * ie.vl_produto) as Subtotal
	from notas_entrada ne join fornecedor f
		on f.cd_fornecedor = ne.cd_fornecedor
		join itens_entrada ie
			on ie.cd_entrada = ne.cd_entrada
			join produto p
				on p.cd_produto = ie.cd_produto
				join categoria c
					on c.cd_categoria = p.cd_categoria
					where (ie.qt_entrada * ie.vl_produto) > 100 
						and (ie.qt_entrada * ie.vl_produto) < 150
							order by ne.dt_nota_entrada , f.nm_fornecedor, c.nm_categoria, p.nm_produto;

-- Retornar o total geral por nota de saída
select 
s.cd_saida as "Número da Nota",
s.dt_nota_saida,
sum((i.qt_saida * i.vl_produto)) as "Total da Nota"
	from 
	notas_saida s
	join itens_saida i
		on i.cd_saida = s.cd_saida
			join cliente c
				on c.cd_cliente = s.cd_cliente
				group by s.cd_saida, s.dt_nota_saida;