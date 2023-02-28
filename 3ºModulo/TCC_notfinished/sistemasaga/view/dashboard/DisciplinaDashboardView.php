<?php

class DisciplinaDashboardView {
	
	private function gerar(){
		
		include_once "view/layout/header.php";

		$html .= "<!-- Content Wrapper. Contains page content -->";
		$html .= "<div class='content-wrapper'>";
		$html .= "<!-- Main content -->";
		$html .= "<section class='content'>";

		$html .= "<div class='row'>";
		$html .= "<div class='col-md-12'>";
		$html .= "<div class='box'>";
		$html .= "<div class='box-header'>";
		$html .= "<h3 class='box-title'>";
		$html .= "<h1><i class='fa fa-book' id='icon_gerenciamento' aria-hidden='true'></i> Minhas Disciplinas</h1>";
		$html .= "<hr>";

		$html .= "<div class='col-12 col-md-3'>";
		$html .= "<div class='card border-primary mb-3' id='itensPainel'>";
		$html .= "<center>";
		$html .= "<a href='" . DOCUMENT_ROOT . "/Disciplina/disciplina1'>";
		$html .= "<div class='card-body text-info'>";
		$html .= "<i class='fa fa-book' aria-hidden='true'></i>";
		$html .= "<h4 class='card-title'>Disciplina 1</h4>";
		$html .= "</div>";
		$html .= "</a>";
		$html .= "</center>";
		$html .= "</div>";
		$html .= "</div>";

		$html .= "<div class='col-12 col-md-3'>";
		$html .= "<div class='card border-primary mb-3' id='itensPainel'>";
		$html .= "<center>";
		$html .= "<a href='" . DOCUMENT_ROOT . "/Disciplina/disciplina2'>";
		$html .= "<div class='card-body text-info'>";
		$html .= "<i class='fa fa-book' aria-hidden='true'></i>";
		$html .= "<h4 class='card-title'>Disciplina 2</h4>";
		$html .= "</div>";
		$html .= "</a>";
		$html .= "</center>";
		$html .= "</div>";
		$html .= "</div>";

		$html .= "</h3>";
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
	
	public function mostrar(){
		echo $this->gerar();
	}
}