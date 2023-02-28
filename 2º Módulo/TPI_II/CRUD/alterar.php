<?php
	include "conexao.php";
	$nome = $_POST['nome'];
	$ano = $_POST['ano'];
	$id = $_POST['id'];

	//Lembrando Banco de Dados ::: UPDATE nome_tabela SET CAMPO = "novo_valor" WHERE CONDIÇÃO
	$result = $bd -> query('UPDATE filme SET nome = "'.$nome.'", ano = "'.$ano.'" WHERE id="'.$id.'"');
	if($result){
		echo "<br>Dados alterados com sucesso.<br>";
	} else {
		echo "<br>Erro ao alterar dados<br>";
	}
	//coloque salvamento no arquivo txt
	$bd -> close();
	echo "<br><a href='index.php'> <<<Voltar para Tela Principal</a>";
?>