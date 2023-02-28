<!DOCTYPE html>
	<html>
	<head>
		<meta charset="UTF-8">
		<title>AULA 4 - ACESSO ACEITO</title>	
		<link rel="stylesheet" href="css/estilo.css">
	</head>
	<body>	

	<?php

	//INICIA A SESSÃO
 	session_start();

	//Verifico se o usuário está logado no sistema
	if ($_SESSION["logado"] != TRUE) {//se for FALSO, ou seja, se ele não logou, indica a página index
 	    header("Location: index.html");	   
		}
		else {
		   echo "<h1>Seja bem-vindo, ".$_SESSION['usu']."</h1>";
		   session_destroy(); //finalizando a sessão para impedir botão retornar do browser, como precisa que a variavel de sessão logado esteja em TRUE, se isso não ocorrer, não irá acessar a página
	}
	?>
		<div id="caixa">
		<h1>SUCESSO NO ACESSO!</h1>
		
		<img src="img/etec.jpg"><br><br><br><br>
		<a href="logout.php">SAIR DO SISTEMA</a>
		
	</div>	
	</body>
</html>