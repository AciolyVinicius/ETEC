<?php

class CursoFormularioView {

	private $curso;
	private $disciplinas;
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
		$html .= "<h1><i class='fa fa-graduation-cap' aria-hidden='true'></i> ".$this->controller." Curso</h1>	";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-4'>";
		$html .= "<h1><a href='" . DOCUMENT_ROOT . "/Listar/curso' id='btnListagem' class='btn btn-default pull-right'><i class='fa fa-list'></i> Listagem</a></h1>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<hr>";
		$html .= "<form method='post' action='" . DOCUMENT_ROOT . "/" . $this->controller ."/cursos'>";
		$html .= "<div class='box-body'>";
		$html .= "<div class='row clearfix'>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-12'>";
		$html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Nome</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='nome' required='' value='".$this->curso->getNome()."' class='form-control' id='nome' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-12' id='formDescricao'>";
		$html .= "<div class='col-12 col-md-12'>";
		$html .= "<label for='descricao' class='control-label'>Descricao</label>";
		$html .= "<div class='form-group'>";
		$html .= "<textarea class='form-control' name='descricao' id='descricao' rows='8'>".$this->curso->getDescricao()."</textarea>";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Disciplinas</label>	";
		$html .= "<div class='row  box-disciplinas'>";
		foreach ($this->disciplinas as $disciplina) {
			$checked = '';
			if ($this->controller == "Editar") {
				$cursoDisciplinas = $this->curso->getDisciplinas();
				foreach ($cursoDisciplinas as $cursoDisciplina) {
					if ($cursoDisciplina->getId() == $disciplina->getId()) {
						$checked = "checked=''";
					}
				}
			}
			$html .= "<div class='col-12 col-md-6'>";
			$html .= "<div class='col-12 col-md-12'>";
			$html .= "<div class='form-check'>";
			$html .= "<input ".$checked." type='checkbox' class='form-check-input' id='disciplina".$disciplina->getId()."' name='disciplina".$disciplina->getId()."'>";
			$html .= "<label class='form-check-label' for='disciplina".$disciplina->getId()."'>".$disciplina->getNome()."</label>";
			$html .= "</div>";
			$html .= "</div>";
			$html .= "</div>";
		}
		$html .= "<input type='hidden' required='' name='id' value='" . $this->curso->getId() . "'>";
		$html .= "</div>";
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
		$html .= "<form action='" . DOCUMENT_ROOT . "/Listar/curso'>";
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
	
	public function mostrar($curso, $disciplinas, $controller){
		$this->curso = $curso;
		$this->disciplinas = $disciplinas;
		$this->controller = $controller;
		echo $this->gerar();
	}
}