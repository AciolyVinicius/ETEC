<!DOCTYPE html>
<html lang="pt-br">
<head>
	<meta charset="utf-8">
	<title>AULA 2 - FORMULÁRIOS</title>
</head>
<body>
	<h1>VISUALIZANDO</h1>
	<?php
		//verificar se o usuário escolheu algum número
		if (isset($_POST["numeros"]))
		{
			echo "Os números de sua preferência são: <br>";
			
			//faz loop pelo array dos números
			foreach($_POST["numeros"] as $numero){
				echo "- " . $numero . " <br>";
			}
		}
		else
		{
			echo "Você não escolheu um número preferido! <br>";
		}
		
		//Verifica de o usuário quer receber newsletter
		if (isset($_POST["news"]))
		{
			echo "Você deseja receber as novidades por email! ";
		}
		else
		{
			echo "Você não quer receber novidades por email...";
		}
		?>
		<p></p><p></p>
		<a href="index2.html">INÍCIO</a>
</body>
</html>