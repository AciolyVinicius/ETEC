<?php
	if(null == ($_COOKIE['nome_usuario']) && null == ($_COOKIE[senha])){
		header('Location: login.php');
	} else{
		echo 'Bem-Vindo de volta, ' .$_COOKIE['nome_usuario'];
	}
?>