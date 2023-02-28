<?php

class DisciplinaDetalharView {

	private $disciplina;
	
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
		$html .= "<h1><i class='fa fa-book' aria-hidden='true'></i> Visualizar Disciplina</h1>	";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-4'>";
		$html .= "<h1><a href='" . DOCUMENT_ROOT . "/Listar/disciplina' id='btnListagem' class='btn btn-default pull-right'><i class='fa fa-list'></i> Listagem</a></h1>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<hr>";
		$html .= "<div class='box-body'>";
		$html .= "<div class='col-12 col-md-12 jumbotron'>";
		$html .= "<center><h2>" . $this->disciplina->getNome() . "</h2></center>";
		$html .= "<br>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-md-3'></div>";
		$html .= "<div class='col-md-9'>";
		$html .= "<p>";
		$html .= "<strong>Nome:</strong> " . $this->disciplina->getNome() . "<br>";
		$html .= "<strong>Carga Horaria Total: </strong> " . $this->disciplina->getCargaHoraria() . "<br>";
		if (strlen($this->disciplina->getDescricao()) > 0) {
			$html .= "<strong>Descrição: </strong> " . $this->disciplina->getDescricao();
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
	
	public function mostrar($disciplina){
		$this->disciplina = $disciplina;
		echo $this->gerar();
	}
}