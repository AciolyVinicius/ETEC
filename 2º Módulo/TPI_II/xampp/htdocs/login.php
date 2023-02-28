<?php
		$usuario = 'BobEsponja';
		$senha_usuario = '12345';
		if(isset($_POST['nome_usuario'])&& isset($_POST['senha'])){
			if(($_POST['nome_usuario'] == $usuario) && ($_POST['senha'] == $senha_usuario)){
				//Setando o tempo do cookie para 2 minutos
				setcookie('nome_usuario',$_POST['nome_usuario'], time()+120);
				setcookie('senha', md5($_POST['senha']), time()+120);
				header('Location:index.php');
			}else{
				echo 'Nome de Usuário e/ou Senha Inválidas.';
			}			
		}else{
			echo 'Você deve preencher login e senha.';
		}
?>
<!DOCTYPE html>
<html>
<head lang="pt-br">
	<meta charset="UTF-8">
	<title>	Tela de Login </title>
</head>
<body>
	<h2>Tela de Login </h2>
	<form name="login" method="post" action="login.php">
		Usuário: <input type="text" name="nome_usuario"><br>
		Senha: <input type="password" name="senha"><br>
		<input type="submit" name="submit" value="ACESSAR">
	</form>
</body>
</html>