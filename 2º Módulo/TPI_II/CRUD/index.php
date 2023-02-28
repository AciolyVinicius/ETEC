<!doctype html>
<html>
	<head>
	 <meta charset="utf-8">
	 <title> Filmes </title>
	</head>
	<body>
		<nav>
			<UL>
				<li> <a href = "index.php">Visualizar</a></li>
				<li> <a href = "novo.php">Cadastrar</a></li>
				<li> <a href = "altera.php">Alterar</a></li>
				<li> <a href = "exclui.php">Excluir</a></li>
			</ul>
		</nav>
		<section>
			<h1> Filmes </h1>
			<hr>
			<?php
				include "conexao.php";
				$mysqli = new mysqli('localhost', 'root', 'root', 'filmes');
				$result = $mysqli->query("SELECT * FROM filmes");
				echo 'Código - Ano - Filme';
				while($dados = $result->fetch_object()){
					echo '<br>('.$dados->id.')';
					echo ' - '.$dados->ano;
					echo ' - '.$dados->nome;
				}
				echo "<hr>Foram encontrados ".$result->num_rows." registros";
				$result->close();
				$mysqli->close();
 			?>
		</section>
	</body>
</html>