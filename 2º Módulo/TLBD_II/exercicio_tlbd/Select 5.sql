select id_numero_depto_superior "Valor Hierárquico",
id_numero_depto "Código do Departamento",
nm_depto "Nome do Departamento"
from tb_depto
	order by id_numero_depto_superior;