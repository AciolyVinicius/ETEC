<!doctype html>
<html>
	<head>
		<meta charset="utf-8">
	</head>
	
<?php
	$nome = $_POST['add_login'];
	$senha = $_POST['add_senha'];
	
	$strcon = mysqli_connect('localhost','root','root','db2i2') or die ('Erro ao conectar ao banco de dados');
	//muda a senha para a senha do seu banco
	
	$sql = "INSERT into tb_usuario (ds_login, ds_senha) values ('$nome', '$senha')";
	
	mysqli_query($strcon, $sql) or die ("Erro ao tentar cadastrar registro");
	
	mysqli_close($strcon);
	
	echo "Usuário cadastrado com sucesso!";
?>

</html>
	