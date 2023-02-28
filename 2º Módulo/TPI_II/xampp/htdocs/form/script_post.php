<!doctype html>
<html>
	<head>
		<meta charset="utf-8">
		<title> AULA 2 - FORMULÁRIOS</title>
	</head>
	<body>
		<h1> VISUALIZANDO SAIDA POST</h1>
		<?php
			echo "O nome é: ".$_POST["campo1"];
			echo "<br>A idade é: ".$_POST["campo2"];
		?>
		<p></p>
		<a href="index.html">INÍCIO</a>
	</body>
</html>