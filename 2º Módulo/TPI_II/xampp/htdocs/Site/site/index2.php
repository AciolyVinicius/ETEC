<!doctype html>
<html>
	<head lang="pt-br">
		<link rel="stylesheet" type="text/css" href="../css/estilo.css">
		<meta charset="utf-8">
	</head>
	<body>
		<div id="top" class="container">
			<div id="topo">
				<a href="index.html" style="margin-right: 50px; color: white">Início</a>
				Escola Técnica Doutora Ruth Cardoso
			</div>
		</div>
		<div id="retorno">
		<H1>
		<?php
			echo "Seu nome é: ".$_POST["nome"];
			echo "<br>Sua senha é: " . $_POST["senha"];
		?>
		</H1>
		</div>
		<div style="text-align:center; margin:20px; float: center"><h1>Cursos Disponíveis</h1>
			<a href="informatica.html"><h2>Informática</h2></a>
			<a href="enfermagem.html"><h2>Ajudante de Médico</h2></a>
			<a href="edificacao.html"><h2>Pedreiro</h2></a>
		</div>
		<div id="meioesquerdo" style="height: 200px">
		<?php
			echo "Sua Opinião sobre Informática: " .$_POST["opinfo"] . "<br>";
		?>
		<?php
			echo "Sua Opinião sobre Enfermagem: " .$_POST["openfer"]. "<br>";
		?>
		<?php
			echo "Sua Opinião sobre Edificações: " .$_POST["opedif"]. "<br>";
		?>
		</div>
	</body>
</html>