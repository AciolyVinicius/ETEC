<?php

class TurnoDetalharView {

	private $turno;
	
	private function gerar(){

		include_once "view/layout/header.php";
		$html .= "<!-- Content Wrapper. Contains page content -->";
		$html .= "<div class='content-wrapper'>";
		$html .= "<!-- Main content -->";
		$html .= "<section class='content'>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-12'>";
		$html .= "<div class='box'>";
		$html .= "<div class='box-header'>";
		$html .= "<div class='col-12 col-md-8'>";
		$html .= "<h1><i class='glyphicon glyphicon-time' aria-hidden='true'></i> Visualizar Turno</h1>	";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-4'>";
		$html .= "<h1><a href='" . DOCUMENT_ROOT . "/Listar/turno' id='btnListagem' class='btn btn-default pull-right'><i class='fa fa-list'></i> Listagem</a></h1>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<hr>";
		$html .= "<div class='box-body'>";
		$html .= "<div class='col-12 col-md-12 jumbotron'>";
		$html .= "<center><h2>" . $this->turno->getNome() . "</h2></center>";
		$html .= "<br>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-md-3'></div>";
		$html .= "<div class='col-md-9'>";
		$html .= "<p>";
		$html .= "<strong>Nome:</strong> " . $this->turno->getNome() . "<br>";
		$html .= "<strong>Hora de Inicio:</strong> " . $this->turno->getHoraInicio() . "<br>";
		$html .= "<strong>Hora de Termino: </strong> " . $this->turno->getHoraFinal() . "<br>";
		if (strlen($this->turno->getDescricao()) > 0) {
			$html .= "<strong>Descrição: </strong> " . $this->turno->getDescricao();
		}
		$html .= "</p>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</section>";
		$html .= "<!-- /.content -->";
		$html .= "</div>";
		include_once "view/layout/footer.php";
		
		return $html;
	}
	
	public function mostrar($turno){
		$this->turno = $turno;
		echo $this->gerar();
	}
}