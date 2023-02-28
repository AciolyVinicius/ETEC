<?php
	include "conexao.php";
	$nome = $_POST['nome'];
	$ano = $_POST['ano'];
	$result = $bd->query('INSERT INTO filme (nome, ano) VALUES ("'.$nome.'",'.$ano.')');
	 if($result){
	 	echo "<br>Dados inseridos com sucesso.<br>";
	 } else {
	 	echo "<br>Erro ao inserir dados.<br>";
	 }
	 //criar uma fu~ção que recebe um texto como parametro
	 function gravar($texto){
	 	//Variável	'arquivo' armazena o e extensao do arquivo
	 	$arquivo = "meu_arquivo.txt";

	 	//Variável $fp armazena a conexão com o arquivo e o tipo de ação
	 	$fp = fopen($arquivo, "a+");

	 	//Escreve no arquivo aberto
	 	fwrite($fp, $texto);

	 	//Fecha o arquivo
	 	fclose($fp);
	 }
	 gravar($nome." - ".$ano."\r\n"); //Pula linha no arquivo

	 $bd -> close();
	 echo "<br><a href='index.php'><<<Voltar para Tela Principal</a>";
?>