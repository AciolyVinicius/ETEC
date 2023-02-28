<!doctype html>
<html>
	<head>
		<meta charset="UTF-8">
		<title>Retângulo</title>
	</head>
	<body>
		<?php
			// verificando se botão foi clicado
			if (isset ($_POST["botao"])){
				include_once ("Retangulo.class.php");
				//incluindo a classe Retangulo
				$retangulo = new Retangulo(); //criando o objeto
				$retangulo->SetLadoMaior($_POST["largura"]); //passando os valores digitados para a classe
				$retangulo->setLadoMenor($_POST["altura"]);
				$area = $retangulo->calculaArea();
				echo "A área do retângulo é: " . $area;
			}
		else{
		?>
		<fieldset> <legend> "CALCULA ÁREA DO RETÂNGULO"</legend>
			<form action="retangulo.php" method="post">
				Informe a largura: <input type="text" name="largura"><br>
				Informe a altura: <input type="text" name="altura"><br>
				<input type="submit" name="botao" value="Calcular área">
			</form>
		</fieldset>
	</body>
		<?php
			}
		?>
</hmtl>
