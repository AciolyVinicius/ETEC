<?php

class TurmaFormularioView {

	private $turma;
	private $cursos;
	private $turnos;
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
		$html .= "<h1><i class='fa fa-users' aria-hidden='true'></i> ".$this->controller." Turma</h1>	";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-4'>";
		$html .= "<h1><a href='" . DOCUMENT_ROOT . "/Listar/turma' id='btnListagem' class='btn btn-default pull-right'><i class='fa fa-list'></i> Listagem</a></h1>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<hr>";
		$html .= "<form method='post' action='" . DOCUMENT_ROOT . "/" . $this->controller ."/turmas'>";
		$html .= "<div class='box-body'>";
		$html .= "<div class='row clearfix'>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<label for='curso' class='control-label'><span class='text-danger'>*</span> Curso</label>";
		$html .= "<div class='form-group'>";
		$html .= "<select class='form-control' required='' name='curso' id='curso'>";
		foreach ($this->cursos as $key => $curso) {
			if ($this->controller == "Editar") {
				$selected = $curso->getId() == $this->turma->getCurso()->getId() ? "selected=''" : "";
			} else  {
				$selected = $key == 0 ? "selected=''" : "";
			}
			$html .= "<option ".$selected." class='text-center' value='".$curso->getId()."'>".$curso->getNome()."</option>";
		}
		$html .= "</select>";
		$html .= "</div>";
		$html .= "</div><div class='col-12 col-md-6'>";
		$html .= "<label for='turno' class='control-label'><span class='text-danger'>*</span> Turno</label>";
		$html .= "<div class='form-group'>";
		$html .= "<select class='form-control' required='' name='turno' id='turno'>";
		foreach ($this->turnos as $key => $turno) {
			if ($this->controller == "Editar") {
				$selected = $turno->getId() == $this->turma->getTurno()->getId() ? "selected=''" : "";
			} else  {
				$selected = $key == 0 ? "selected=''" : "";
			}
			$html .= "<option ".$selected." class='text-center' value='".$turno->getId()."'>".$turno->getNome()."</option>";
		}
		$html .= "</select>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Nome do Turma</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='nome' required='' value='" . $this->turma->getNome() . "' class='form-control' id='nome' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<label for='capacidade' class='control-label'><span class='text-danger'>*</span>Capacidade da Turma</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='number' name='capacidade' required='' value='" . $this->turma->getCapacidade() . "' class='form-control' id='capacidade' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<label for='data_inicio' class='control-label'><span class='text-danger'>*</span>Data de Inicio</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='date' name='data_inicio' required='' value='" . $this->turma->getDataInicio() . "' class='form-control' id='data_inicio' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<label for='data_final' class='control-label'><span class='text-danger'>*</span>Data de Termino</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='date' name='data_final' required='' value='" . $this->turma->getDataFinal() . "' class='form-control' id='data_final' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-6' id='formDescricao'>	";
		$html .= "<div class='col-12 col-md-12'>";
		$html .= "<label for='descricao' class='control-label'>Descrição</label>";
		$html .= "<div class='form-group'>";
		$html .= "<textarea class='form-control' name='descricao' id='descricao' rows='8'>" . $this->turma->getDescricao() . "</textarea>";
		$html .= "<input type='hidden' required='' name='id' value='" . $this->turma->getId() . "'>";
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
		$html .= "<form action='" . DOCUMENT_ROOT . "/Listar/turma'>";
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
	
	public function mostrar($turma, $cursos, $turnos, $controller){
		$this->turma = $turma;
		$this->cursos = $cursos;
		$this->turnos = $turnos;
		$this->controller = $controller;
		echo $this->gerar();
	}
}