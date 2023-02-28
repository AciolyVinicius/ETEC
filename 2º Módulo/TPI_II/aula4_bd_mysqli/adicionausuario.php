<!doctype html>
<html>
<head>
	<meta charset="utf-8">
	<title>AULA CRUD</title>
</head>
<body>
	<?php
		
		//iniciar sessão
		session_start();
		
		//verifica se o usúario esta logado no sistema
		if ($_SESSION['logado'] != true){
			header('Location: index.php');
		}
		else{
			echo '<h1> Seja bem-vendo, ' .$_SESSION['usu'].'</h1>';
		}
	?>
	
	<h1>ADICIONANDO USUÁRIO</h1>
		<form action="validainsert.php" method="POST">
			
			LOGIN: <input type="text" name="add_login" required="required"><br><br>
			SENHA: <input type="password" name="add_senha" required="required"><br><br>
			
			<input type="submit" value="SALVAR">
			
		</form>
		
	<a href="logout.php">SAIR DO SISTEMA</a>
</body>
</html>