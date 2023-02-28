<?php
	/* Conteúdo das variáveis */
	session_start('login');
	$usuario = 'BobEsponja';
	$senha_usuario = '12345';
	$_SESSION['logado']='0'; // uso da variável session de nome logado, com valor 0, pois o usuário ainda não fez login
	
	if(isset($_POST['nome_usuario'])&& isset($_POST['senha'])){
		if(($_POST['nome_usuario'] == $usuario) && ($_POST['senha'] == $senha_usuario)){
			//Setando o tempo do cookie para 2 minutos
			setcookie('nome_usuario',$_POST['nome_usuario'], time()+120);
			setcookie('senha', md5($_POST['senha']), time()+120);
			$_SESSION['logado']='1';
			
			header('Location:indexcookiesession.php');//chama outra página
			
		}else{
			echo 'Nome de Usuário e/ou Senha Inválidas.';//login e senha inválidos
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
	<form name="login" method="post" action="loginsession.php">
		Usuário: <input type="text" name="nome_usuario"><br>
		Senha: <input type="password" name="senha"><br>
		<input type="submit" name="submit" value="ACESSAR">
	</form>
</body>
</html>