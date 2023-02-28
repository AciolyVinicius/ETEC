<?php

class DisciplinaFormularioView {

	private $disciplina;
	private $controller;
	
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
		$html .= "<h1><i class='fa fa-book' aria-hidden='true'></i> " . $this->controller ." Disciplina</h1>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-4'>";
		$html .= "<h1><a href='" . DOCUMENT_ROOT . "/Listar/disciplina' id='btnListagem' class='btn btn-default pull-right'><i class='fa fa-list'></i> Listagem</a></h1>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<hr>";
		$html .= "<form method='post' action='" . DOCUMENT_ROOT . "/" . $this->controller ."/disciplinas'>";
		$html .= "<div class='box-body'>";
		$html .= "<div class='row clearfix'>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-12'>";
		$html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Nome</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='nome' required='' value='" . $this->disciplina->getNome() . "' class='form-control' id='nome' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-12'>";
		$html .= "<label for='carga_horaria' class='control-label'><span class='text-danger'>*</span>Carga Horaria</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='number' name='carga_horaria' required='' value='" . $this->disciplina->getCargaHoraria() . "' class='form-control' id='carga_horaria' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<div class='col-12 col-md-12'>";
		$html .= "<label for='descricao' class='control-label'>Descrição</label>";
		$html .= "<div class='form-group'>";
		$html .= "<textarea class='form-control' name='descricao' id='descricao' rows='5'>" . $this->disciplina->getDescricao() . "</textarea>";
		$html .= "<input type='hidden' required='' name='id' value='" . $this->disciplina->getId() . "'>";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='box-footer'>";
		$html .= "<div class='col-6 col-md-6'>";
		$html .= "<button id='btnCadastrar' type='submit' class='btn btn-success'>";
		$html .= "<i class='fa fa-check'></i> Salvar";
		$html .= "</button>";
		$html .= "</form>";
		$html .= "<form action='" . DOCUMENT_ROOT . "/Listar/disciplina'>";
		$html .= "</div>";
		$html .= "<div class='col-6 col-md-6'>";
		$html .= "<button id='btnCancelar' type='' class='btn btn-danger'>";
		$html .= "<i class='fa fa-times'></i> Cancelar";
		$html .= "</button>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</form>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</section>";
		$html .= "<!-- /.content -->";
		$html .= "</div>";

		include_once "view/layout/footer.php";
		
		return $html;
	}
	
	public function mostrar($disciplina, $controller){
		$this->disciplina = $disciplina;
		$this->controller = $controller;
		echo $this->gerar();
	}
}