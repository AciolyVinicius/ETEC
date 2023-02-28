<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8">
</head>
<body>
	<?php
		if(isset($_COOKIE['cookie_teste'])){
			echo 'Você já esteve aqui recentemente, '.$_COOKIE['cookie_teste'];
		}
		else{
			setcookie('cookie_teste',' Fulano de Tal', time()+10);
			echo '<P> Bem-vindo! </p> Este é o início da sua visualização';
			echo '<p> O cookie durará 10 segundos</p>';
		}
	
	?>
<body>
</html>