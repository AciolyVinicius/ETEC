<doctype html>
<html>
<head>
	<meta charset="utf-8">
	<meta name='author' content='Vinicius Acioly'>
</head>
<body>
<?php
	//iniciando a sessao
	session_start();
	$_SESSION['logado']=false; //variavel global da sessao logado
	
	//iniciando a conexão
	//a senha do usbserver é usbw, a do Xampp é root
	$conexao = mysqli_connect("localhost", 'root', 'root', 'db2i2');
	
	//se der erro aparece alguma mensagem de erro, melhor que uma parada brusca sem retorno
	if (mysqli_connect_errno()){
		echo 'A conexão MySQLi apresentou erro: ' . mysqli_connect_error();
	}	
	
	// checando o usuário que veio do formulário no banco de dados
	if(isset($_POST['login'])){
		$login_usuario = mysqli_real_escape_string($conexao, $_POST['login']);
		$senha_usuario = mysqli_real_escape_string($conexao, $_POST['senha'])/
	
		$seleciona_usuario = "select * from tb_usuario where nm_login='$login_usuario' AND nm_senha = '$senha_usuario'" ;
		
		$procura = mysqli_query($conexao, $seleciona_usuario);
		
		$checa_usuario = mysqli_num_rows($procura); // Obtém o número de linhas em um resultado

		if($checa_usuario>0){
			$_SESSION['logado']=true;
			$_SESSION['usu']=$login_usuario;
			header("Location:home.php");
		}
		else{
			echo "<script>confirm('Login ou Senha com erro, tente novamente!',
			windows.location.href='index.html')</script>";
		}
	}
?>
</body>
</html>