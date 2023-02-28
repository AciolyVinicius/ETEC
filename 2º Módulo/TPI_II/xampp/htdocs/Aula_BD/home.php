<doctype html>
<html>
<head>
	<meta charset="utf-8">
	<title>AULA 4 - ACESSO ACEITO </title>
	<link rel="stylesheet" href="css/estilo.css">
</head>
<body>
<?php
	//iniciando a sessao
	session_start();
	
	//Verifico se o usuário está logado no sistema
	if ($_SESSION["logado"] != TRUE){
		//se for FALSE, ou seja, se ele não logou, indicar a página index
		header("Location:index.html");
	}
	else{
		echo "<h1>Seja bem-vindo, ".$SESSION['usu']."</h1>";
		session_destroy(); //Finalizando a sesão para impedir
		//botão retornar do browser, como precisa que a variável
		//de sessão logado esteja TRUE, se isso não ocorrer ele
		//ele não irá acessar a página
	}
?>
	<div id="caixa">
		<h1>SUCESSO NO ACESSO!</h1>
		
		<img src="img/etec.jpf"><br><br><br><br>
		<a href="logout.php">SAIR DO SISTEMA</a>
	</div>
</body>
</html>