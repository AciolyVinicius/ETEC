call  `3func`(298456511, 398569902, 1002225623);
call func_depart();
call func_depart_maiorque(980);
call projetos_funcionarios();
call func_dependente_filhoa();
call depart_cod(211);
call func_dependente();
call func_cidade_inicial('j');
call func_salario_maior_menor(970, 2501);
call proj_verb_indefinida_xbolsas(5);
call proj_verb_indefinida_xtipo('parcial');
call func_dependente_nao_filhoa();
call func_depart_gerenciam_em_projeto();
call exclui_dependente(3768);
call update_dependente(3322, 'clacla', 'Filho');
call exclui_dpto(456);
call update_dpto (466, 'Blabla', null);
call exclui_func(298456511);
call update_func(105462221, null, null, null, null, 231, 233242);
call select_projeto_nao_concluido();
call exclui_projeto(21);
call update_projeto(46, true,'SALVE CUMPADI', 'Dos bom', null, 223453245, 398569902);
call select_projeto_concluido();
call excluir_func_projeto(105462221, 21);
call update_func_projeto(105462221,21, 1002225623,NULL,56);
call insert_dependente(298456511, 132, 'Claudio', 'Pai');
call insert_projeto(123, 'Meh', 'Tipo', 'Verbba', 120, null);
call insert_func(12132, 'Jones', 'Tanjuana', 36255894, 900.00, 2112, null);
call insert_func_projeto(105462221, 56, 52);
call projet_associado_func(56);
call projet_nao_associado_func(21);

select * from departamento_projetos;
select * from funcionarios_projetos_horas;
select * from funcionarios_dependentes;