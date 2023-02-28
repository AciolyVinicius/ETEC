<?php

class GerenciamentoDashboardView {
	
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
		$html .= "<h1><i class='fa fa-cog' id='icon_gerenciamento' aria-hidden='true'></i> Gerenciamento</h1>";
		$html .= "<hr>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-3'>";
		$html .= "<div class='card primary mb-3' id='itensPainel' style='background-color: #1E90FF;'>";
		$html .= "<center>";
		$html .= "<a href='" . DOCUMENT_ROOT . "/Detalhar/instituicao'>";
		$html .= "<div class='card-body text-info'>";
		$html .= "<i class='fa fa-university' aria-hidden='true'></i>";
		$html .= "<h4 class='card-title'>Instituição</h4>";
		$html .= "</div>";
		$html .= "</a>";
		$html .= "</center>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-3'>";
		$html .= "<div class='card border-primary mb-3' id='itensPainel' style='background-color: #00CD66;'>";
		$html .= "<center>";
		$html .= "<a href='" . DOCUMENT_ROOT . "/Listar/usuario'>";
		$html .= "<div class='card-body text-info'>";
		$html .= "<i class='fa fa-user' aria-hidden='true'></i>";
		$html .= "<h4 class='card-title'>Usuários</h4>";
		$html .= "</div>";
		$html .= "</a>";
		$html .= "</center>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-3'>";
		$html .= "<div class='card border-primary mb-3' id='itensPainel' style='background-color: #EE4000;'>";
		$html .= "<center>";
		$html .= "<a href='" . DOCUMENT_ROOT . "/Listar/curso'>";
		$html .= "<div class='card-body text-info'>";
		$html .= "<i class='fa fa-graduation-cap' aria-hidden='true'></i>";
		$html .= "<h4 class='card-title'>Cursos</h4>";
		$html .= "</div>";
		$html .= "</a>";
		$html .= "</center>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-3'>";
		$html .= "<div class='card border-primary mb-3' id='itensPainel' style='background-color: #9F79EE;'>";
		$html .= "<center>";
		$html .= "<a href='" . DOCUMENT_ROOT . "/Listar/disciplina'>";
		$html .= "<div class='card-body text-info'>";
		$html .= "<i class='fa fa-book' aria-hidden='true'></i>";
		$html .= "<h4 class='card-title'>Disciplinas</h4>";
		$html .= "</div>";
		$html .= "</a>";
		$html .= "</center>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";

		$html .= "<!--SEGUNDA LINHA-->";
		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-3'>";
		$html .= "<div class='card border-primary mb-3' id='itensPainel' style='background-color: #EEAD0E;'>";
		$html .= "<center>";
		$html .= "<a href='" . DOCUMENT_ROOT . "/Listar/turno'>";
		$html .= "<div class='card-body text-info'>";
		$html .= "<i class='glyphicon glyphicon-time' aria-hidden='true'></i>";
		$html .= "<h4 class='card-title'>Turnos</h4>";
		$html .= "</div>";
		$html .= "</a>";
		$html .= "</center>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-3'>";
		$html .= "<div class='card border-primary mb-3' id='itensPainel' style='background-color: #CD0000;'>";
		$html .= "<center>";
		$html .= "<a href='" . DOCUMENT_ROOT . "/Listar/turma'>";
		$html .= "<div class='card-body text-info'>";
		$html .= "<i class='fa fa-users' aria-hidden='true'></i>";
		$html .= "<h4 class='card-title'>Turmas</h4>";
		$html .= "</div>";
		$html .= "</a>";
		$html .= "</center>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";

		$html .= "<br>";
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