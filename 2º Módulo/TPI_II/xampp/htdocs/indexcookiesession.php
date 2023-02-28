<html lang="pt-br">
<meta charset="UTF-8">
<?php
	session_start('login');
	if (null==($_COOKIE['nome_usuario']) && null==($_COOKIE['senha']))//não permite esta página diretamente sem login
	{
		header('Location: loginsession.php');//redirecionamento para página de login
	}elseif('0' == ($_SESSION['logado']))//não permite retorno pelo navegador
	{
		header('Location: loginsession.php');//redirecionamento para página de login
	}else{
		echo 'Bem vindo de volta, '.$_COOKIE['nome_usuario'];
		echo '<br/> Seu status logado é: '.$_SESSION['logado'];//apenas mostrando conteúdo de variável de sessão
		$_SESSION['logado']='0';//a sessão não permite refresh do navegador, comente esta linha, salve e observe o que acontece
	}
?>
</html>