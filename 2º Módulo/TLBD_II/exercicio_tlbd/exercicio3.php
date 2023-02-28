<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>Exercício - 2</title>
	<link rel="stylesheet" type="text/css" href="bootstrap/css/bootstrap.css">
</head>
<body>
	<div class="container">
		<div class="row">
			<?php
				include "conexao.php";
				$mysqli = new mysqli('localhost', 'root', 'root', 'db_suprimentos');
				$result = $mysqli->query("SELECT tb_consumidor.nm_consumidor,
					avg((tb_venda.vl_venda))
					FROM tb_venda JOIN tb_consumidor
						ON tb_consumidor.id_numero_consumidor = tb_venda.id_numero_consumidor
							WHERE tb_consumidor.id_numero_consumidor = 1");

				echo "Nome do consumidor 1 - Soma das compras";
				while ($fetch = $result->fetch_assoc()){
					echo "<p>";
					foreach ($fetch as $campo => $valor){
						echo $campo . ' => ' .$valor . ' | ';
					}
					echo "</p>";
				}
				$result->close();
				$mysqli->close();
			?>
		</div>
	</div>
</body>
</html>