<!DOCTYPE html>
<html lang="pt-BR">
<head>
	<meta charset="utf-8">
	<title>Filmes</title>
</head>
<body></body>
</html>
<?php
	$conn = mysqli_connect('localhost', 'root', 'root', 'db_suprimentos');
	class foo_mysqli extends mysqli
	{
		public function __construct($host, $usr, $pass, $bd)
		{
			parent::__construct($host, $usr, $pass, $bd);
			if (mysqli_connect_error()){
				die('Erro de conexão('.mysql_connect_errno.')'.mysqli_connect_error());
			}
		}
	}
	$bd = new foo_mysqli('localhost', 'root', 'root', 'db_suprimentos');
?>