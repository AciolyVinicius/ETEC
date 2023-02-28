<!DOCTYPE html>
<html lang="pt-br">
<head>
	<meta charset="utf-8">
	<title>AULA 2 - FORMULÁRIOS</title>
</head>
<body>
	<h1>VISUALIZANDO</h1>
	<?php
		echo "Seu processador é: " . $_POST["processador"] . "<br>";
		//verifica se usuário escolheu livro
		if(isset ($_POST["livros"])){
			echo "O(s) livro(s) que você deseja comprar: <br>";
			//faz loop para os livros
			foreach($_POST["livros"] as $livro)
			{
				echo "- " . $livro . "<br>";
			}
		}
		else
		{
			echo "Você não escolheu nenhum livro!";
		}
	?>
	<p></p><p></p>
	<a href="index2.html">INÍCIO</a>
<body>
</html>