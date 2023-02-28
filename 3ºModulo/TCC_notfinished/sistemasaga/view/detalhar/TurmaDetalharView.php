<?php

class TurmaDetalharView {

	private $turma;
	
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
		$html .= "<h1><i class='fa fa-users' aria-hidden='true'></i> Visualizar Turma</h1>	";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-4'>";
		$html .= "<h1><a href='" . DOCUMENT_ROOT . "/Listar/turma' id='btnListagem' class='btn btn-default pull-right'><i class='fa fa-list'></i> Listagem</a></h1>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<hr>";
		$html .= "<div class='box-body'>";
		$html .= "<div class='col-12 col-md-12 jumbotron'>";
		$html .= "<center><h2>" . $this->turma->getNome() . "</h2></center>";
		$html .= "<br>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-md-3'></div>";
		$html .= "<div class='col-md-9'>";
		$html .= "<p>";
		$html .= "<strong>Nome:</strong> " . $this->turma->getNome() . "<br>";
		$html .= "<strong>Data Inicial da Turma:</strong> " . $this->turma->getDataInicio() . "<br>";
		$html .= "<strong>Data de Termino da Turma:</strong> " . $this->turma->getDataFinal() . "<br>";
		$html .= "<strong>Capacidade Maxima:</strong> " . $this->turma->getCapacidade() . " Alunos<br>";
		$html .= "<strong>Curso:</strong> " . $this->turma->getCurso()->getNome() . "<br>";
		$html .= "<strong>Turno:</strong> " . $this->turma->getTurno()->getNome() . "<br>";
		if (strlen($this->turma->getDescricao()) > 0) {
			$html .= "<strong>Descrição: </strong> " . $this->turma->getDescricao() . "<br><br>";
		}
		$html .= "<strong id='atualTurma'>Atualmente:</strong> 37 Alunos Ativos";
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
	
	public function mostrar($turma){
		$this->turma = $turma;
		echo $this->gerar();
	}
}