<!doctype html>
<html>
	<head lang="pt-br">
		<meta charset="utf-8">
		<title> AULA 2 - FORMULÁRIOS</title>
	</head>
	<body>
		<h1> VISUALIZANDO SAÍDA DE POST </h1>
		<?php
			echo "Olá " . $_POST["nome"] "
			(email: ".$_POST["email"] .")<br><br>";
			echo "Sua mensagem: " . $_POST["menagem"];
		?>
		<p></p><p></p>
		<a href="index2.html">INÍCIO</a>
	</body>
</html>