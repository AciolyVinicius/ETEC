<!doctype html>
<html>
	<head>
		<meta charset="utf-8">
		<title> AULA 2 - FORMULÁRIOS</title>
	</head>
	<body>
		<h1> VISUALIZANDO SAIDA GET</h1>
		<?php
			echo "O nome é: " . $_GET["campo1"];
			echo "<br>A idade é: " . $_GET["campo2"];
		?>
		<p></p>
		<a href="index.html">INÍCIO</a>
	</body>
</html>