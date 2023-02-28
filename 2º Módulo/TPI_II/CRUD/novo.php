<!doctype html>
<html lang="pt-br">
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
			<h1> Filmes: Cadastro </h1>
			<hr>
			<form action="insere.php" method="post">
				Nome: <input type="text" name="nome" size="50"/><br/>
				Ano: <input type="text" name="ano" size="10" maxlength="4"/><br/>
				<br/>
				<input type="submit" name="submit" value="Cadastrar"/>
			</form>
			<hr>
			<a href="index.php">HOME</a>
		</section>
	</body>
</html> <!-- essa é novo.php --> 