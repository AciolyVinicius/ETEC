<!DOCTYPE html>

	<html>
	<head>
		<meta charset="UTF-8">
		<meta name="author" content="Vinícius Acioly">
		
	</head>
	<body>
		
<?php

	//iniciando a sessão
	session_start();
	$_SESSION['logado']=false;	//variável global de sessão logado

	// iniciando a conexão:
	//a senha do usbserver é usbw, a do Xampp é root
	$conexao = mysqli_connect("localhost","root","root","db2i2");

	//se der erro aparece alguma mensagem de erro, melhor que uma parada brusca sem retorno
	if (mysqli_connect_errno())

	{

		echo "A conexão MySQLi apresentou erro: " . mysqli_connect_error();

	}

	// checando o usuário que veio do formulário no banco de dados

	if(isset($_POST['login'])){

		$login_usuario = mysqli_real_escape_string($conexao,$_POST['login']);

		$senha_usuario = mysqli_real_escape_string($conexao,$_POST['senha']);

		$seleciona_usuario = "select * from tb_usuario where ds_login= '$login_usuario' AND ds_senha='$senha_usuario'";

		$procura = mysqli_query($conexao, $seleciona_usuario);

		$checa_usuario = mysqli_num_rows($procura); //Obtém o número de linhas em um resultado

		if($checa_usuario>0){

			$_SESSION['logado']=true;
			$_SESSION['usu']=$login_usuario;
			header("Location:adicionausuario.php");
		}

		else {

			echo "<script>confirm('Login ou Senha com erro, tente novamente!', window.location.href='index.html')</script>";
			
		}

	}

?>

	</body>


</html>




