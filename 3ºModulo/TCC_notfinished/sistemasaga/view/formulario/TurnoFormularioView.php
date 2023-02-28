<?php

class TurnoFormularioView {

	private $turno;
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
		$html .= "<h1><i class='glyphicon glyphicon-time' aria-hidden='true'></i> " . $this->controller ." Turno</h1>	";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-4'>";
		$html .= "<h1><a href='" . DOCUMENT_ROOT . "/Listar/turno' id='btnListagem' class='btn btn-default pull-right'><i class='fa fa-list'></i> Listagem</a></h1>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<hr>";
		$html .= "<form method='post' action='" . DOCUMENT_ROOT . "/" . $this->controller ."/turnos'>";
		$html .= "<div class='box-body'>";
		$html .= "<div class='row clearfix'>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-12'>";
		$html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Nome do Turno</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='nome' required='' value='" . $this->turno->getNome() . "' class='form-control' id='nome' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<label for='horaInicio' class='control-label'><span class='text-danger'>*</span>Hora de Inicio</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='time' name='hora_inicio' required='' value='" . $this->turno->getHoraInicio() . "' class='form-control' id='horaInicio' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<label for='horaTermino' class='control-label'><span class='text-danger'>*</span>Hora de Termino</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='time' name='hora_final' required='' value='" . $this->turno->getHoraFinal() . "' class='form-control' id='horaTermino' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-6' id='formDescrição'>";
		$html .= "<div class='col-12 col-md-12'>";
		$html .= "<label for='descricao' class='control-label'>Descricao</label>";
		$html .= "<div class='form-group'>";
		$html .= "<textarea class='form-control' name='descricao' id='descricao' rows='5'>" . $this->turno->getDescricao() . "</textarea>";
		$html .= "<span class='text-danger'></span>";
		$html .= "<input type='hidden' name='id' value='" . $this->turno->getId() . "'>";
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
		$html .= "</div>";
		$html .= "</form>";
		$html .= "<form action='" . DOCUMENT_ROOT . "/Listar/turno'>";
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
	
	public function mostrar($turno, $controller){
		$this->turno = $turno;
		$this->controller = $controller;
		echo $this->gerar();
	}
}