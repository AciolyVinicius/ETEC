<?php

class CursoDetalharView {

	private $curso;
	
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
		$html .= "<h1><i class='fa fa-graduation-cap' aria-hidden='true'></i> Visualizar Curso</h1>	";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-4'>";
		$html .= "<h1><a href='" . DOCUMENT_ROOT . "/Listar/curso' id='btnListagem' class='btn btn-default pull-right'><i class='fa fa-list'></i> Listagem</a></h1>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<hr>";
		$html .= "<div class='box-body'>";
		$html .= "<div class='col-12 col-md-12 jumbotron'>";
		$html .= "<center><h2>" . $this->curso->getNome() . "</h2></center>";
		$html .= "<br>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-md-3'></div>";
		$html .= "<div class='col-md-9'>";
		$html .= "<p>";
		$html .= "<strong>Nome:</strong> " . $this->curso->getNome() . "<br>";
		if (strlen($this->curso->getDescricao()) > 0) {
			$html .= "<strong>Descrição: </strong> " . $this->curso->getDescricao() . "<br>";
		}
		$html .= "<br><strong>Disciplinas:</strong><br>";
		$disciplinas = $this->curso->getDisciplinas();
		foreach ($disciplinas as $disciplina) {
			$html .="<a href='" . DOCUMENT_ROOT . "/Detalhar/disciplina?id=" . $disciplina->getId() . "'>" . $disciplina->getNome() . "</a><br>";
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
		$html .= "	</div>";
		include_once "view/layout/footer.php";
		
		return $html;
	}
	
	public function mostrar($curso){
		$this->curso = $curso;
		echo $this->gerar();
	}
}