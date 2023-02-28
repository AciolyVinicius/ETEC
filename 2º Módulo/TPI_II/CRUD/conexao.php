<!DOCTYPE html>
<html lang="pt-br">
<head>
	<title>Filmes</title>
	<meta charset="utf-8">
</head></html>
<?php
	$conn = mysqli_connect('localhost', 'root', 'root', 'filmes');

	class foo_mysqli extends mysqli {
		public function __construct($host,$usr,$pass,$bd)
		{
			parent:: __construct($host,$usr,$pass,$bd);
			if (mysqli_connect_error()){
				die('Connect Error('.mysqli_connect_error());
			}
		}
	}

	$bd = new foo_mysqli('localhost', 'root', 'root', 'filmes');

?>