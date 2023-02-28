		-- PARTE 1
select * from tb_socio;

select * from tb_vendedor;

select * 
	from tb_tipo_socio;

-- Codigo do vendedor que tem tal nome
select cd_vendedor
	from tb_vendedor
		where nm_vendedor like lower("%%");

-- Valor da manutencao segundo o código do socio
select vl_manutencao
	from tb_titulo
		where cd_socio = 1;

-- O valor da joia a vista, da quantidade de parcelas e do valor individual e da cada parcela segundo o id do socio
select vl_joia_avista "Joia a vista", qt_parcelamento "Quantidade de parcelamento", vl_parcela "Valor de cada parcela"
	from tb_titulo
		where cd_socio = 2;

-- Vê o nome do socio que tem tal id
select nm_socio 
	from tb_socio
		where cd_socio = 5;

		-- PARTE 2
-- Ver os vendedores e os socios com seus respectivos titulos lincados
select v.nm_vendedor "Nome do Vendedor", s.nm_socio "Nome do Sócio" 
	from tb_vendedor v
		right join tb_titulo t
			on v.cd_vendedor = t.cd_vendedor
			left join tb_socio s
				on t.cd_socio = s.cd_socio;

-- Pegar o tipo do socio segundo seu nome
select ts.ds_tipo_socio "Tipo de Sócio", s.nm_socio "Nome do Sócio" -- 'NOME SOCIO PODE TIRAR'
	from tb_tipo_socio ts
		right join tb_socio s
			on ts.cd_tipo_socio = s.cd_tipo_socio
			where s.nm_socio like lower('%');

-- Valores das manutenções e dos nomes dos socios respectivos
select t.vl_manutencao "Valor da Manutenção", s.nm_socio "Nome do Sócio"
	from tb_titulo t
		left join tb_socio s
			on t.cd_socio = s.cd_socio;

-- PRONTO ATÉ AQUI

-- Vendedores que venderam em 2017
select s.nm_socio
	from tb_socio s
		right join tb_titulo t
			on s.cd_socio = t.cd_socio
			where YEAR(t.dt_venda) = 2017;


-- Pegar a quantidade de parcelamento, nome do sócio, nome do vendedor e o tipo de sócio
select t.qt_parcelamento "Quantidade de parcelamento da joia", s.nm_socio "Nome do Sócio", v.nm_vendedor "Nome do Vendedor", ts.ds_tipo_socio "Descrição do tipo de socio"
	from tb_vendedor v
		right join tb_titulo t
			on v.cd_vendedor = t.cd_vendedor
			left join tb_socio s
				on t.cd_socio = s.cd_socio
				left join tb_tipo_socio ts
					on s.cd_tipo_socio = ts.cd_tipo_socio;

		-- PARTE 3
-- id do sócio, nome do sócio, quantidade de parcelas pagas da joia
select s.cd_socio, s.nm_socio,
count(pj.ic_pagamento) 									
	from  tb_socio s
		right join tb_titulo t
			on s.cd_socio = t.cd_socio
				right join tb_parcela_joia pj	
					on t.cd_titulo = pj.cd_titulo
					where pj.ic_pagamento = true
						group by s.nm_socio
							order by s.cd_socio;


-- Valor da manutenção, do nome do vendedor e do nome do socio pesquisando os precos avistas das joias 
select t.vl_manutencao "Valor da Manutenção", s.nm_socio "Nome do Sócio"
	from tb_titulo t
		left join tb_socio s
			on t.cd_socio = s.cd_socio
				left join tb_vendedor v
					on t.cd_vendedor = v.cd_vendedor
				where t.vl_joia_avista = 2500;



-- Quantidade de socios do vendedor
select count(s.nm_socio), v.nm_vendedor
	from tb_socio s
		right join tb_titulo t
			on s.cd_socio = t.cd_socio
			left join tb_vendedor v
				on t.cd_vendedor = v.cd_vendedor
				group by v.nm_vendedor;

-- Valor da parcela de um socio e o seu tipo
select t.vl_parcela "Valor da parcela", s.nm_socio "Nome do sócio", ts.ds_tipo_socio "Tipo do sócio" 
	from tb_titulo t
		left join tb_socio s
			on t.cd_socio = s.cd_socio
			left join tb_tipo_socio ts
				on s.cd_tipo_socio = ts.cd_tipo_socio;

-- Pegar os socios que possuem a manutencao mais cara, e seu tipo
-- Pegar o nome dos vendedores que venderam a uma comissao maior que a media
select v.cd_vendedor, v.nm_vendedor, t.vl_comissao
	from tb_vendedor v
		right join tb_titulo t
			on v.cd_vendedor = t.cd_vendedor
			where t.vl_comissao > (select avg(vl_comissao) from tb_titulo);

-- Pegar todos os socios que estao devendo tal mes na manutencao
select t.cd_titulo,
s.nm_socio, 
m.cd_mes "Mes da manutenção que esta devendo",
m.cd_ano "Ano da manutenção que esta devendo" 
	from tb_socio s
		right join tb_titulo t
			on s.cd_socio = t.cd_socio
				left join tb_manutencao m
					on m.cd_titulo = t.cd_titulo
								where m.ic_pagamento = false
									order by t.cd_titulo;

-- Pegar o nome do vendedor que vendeu a menor joia, contando o parcelamento e o seu respectivo socio 
select v.nm_vendedor, t.vl_joia_avista, s.nm_socio
	from tb_vendedor v
		right join tb_titulo t
			on v.cd_vendedor = t.cd_vendedor
			right join tb_socio s
				on s.cd_socio = t.cd_socio
				where t.qt_parcelamento*t.vl_parcela = (select max(t.qt_parcelamento*t.vl_parcela) 
											from tb_titulo t);


			-- PARTE 4
-- Pegar o valor da manutenção, o nome do socio e o tipo do socio que possui o maior valor de manutenção
select t.vl_manutencao, s.nm_socio, ts.ds_tipo_socio
	from tb_titulo t
		left join tb_socio s
			on t.cd_socio = s.cd_socio
			left join tb_tipo_socio ts
				on s.cd_tipo_socio = ts.cd_tipo_socio
				where t.vl_manutencao = (select max(t.vl_manutencao)
												from tb_titulo t);

-- o socio que ainda nao paga a manutencao
select s.nm_socio
	from tb_socio s
		right join tb_titulo t
			on s.cd_socio = t.cd_socio
					where t.cd_titulo not in (select cd_titulo 
												from tb_manutencao) group by s.nm_socio;
-- socio que pagaria a maior joia a vista
select s.nm_socio
	from tb_socio s
		right join tb_titulo t
			on s.cd_socio = t.cd_socio
			where t.vl_joia_avista = (select max(t.vl_joia_avista)
										from tb_titulo t);

-- Pega os socios que pagam mais que a media
select 
s.nm_socio 'Nome do Sócio',
t.vl_manutencao
	from tb_socio s
		right join tb_titulo t
			on s.cd_socio = t.cd_socio
			where t.vl_manutencao > (select avg(t.vl_manutencao)
										from tb_titulo t);

