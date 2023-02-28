<?php

class TurmaListarView {

	private $turmas;
	
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
		$html .= "<h1><i class='fa fa-users' aria-hidden='true'></i> Turmas</h1>	";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-4'>";
		$html .= "<h1><a href='" . DOCUMENT_ROOT . "/Adicionar/turma' id='btnListagem' class='btn btn-success pull-right'><i class='fa fa-plus'></i> Nova Turma</a></h1>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<hr>";
		$html .= "<div class='box-body'>";
		$html .= "<div class='panel-body'>";
		$html .= "<table id='instituicoes_table' class='table table-hover table-responsive table-bordered'>";
		$html .= "<thead class='theadTables'>";
		$html .= "<tr>";
		$html .= "<th class='text-center'>Nome Turma</th>";
		$html .= "<th class='text-center'>Curso</th>";
		$html .= "<th class='text-center'>Turno</th>";
		$html .= "<th class='text-center'>Capacidade</th>";
		$html .= "<th class='text-center'>Exibir</th>";
		$html .= "<th class='text-center'>Editar</th>";
		$html .= "<th class='text-center'>Apagar</th>";
		$html .= "</tr>";
		$html .= "</thead>";
		$html .= "<tbody>";

		foreach ($this->turmas as $turma) {
			$html .= "<tr>";
			$html .= "<td class='text-center'>" . $turma->getNome() . "</td>";
			$html .= "<td class='text-center'>" . $turma->getCurso()->getNome() . "</td>";
			$html .= "<td class='text-center'>" . $turma->getTurno()->getNome() . "</td>";
			$html .= "<td class='text-center'>" . $turma->getCapacidade() . "</td>";
			$html .= "<td class='text-center'><a href='" . DOCUMENT_ROOT . "/Detalhar/turma?id=" . $turma->getId() . "' class='btn btn-info'><i class='fa fa-eye'></i></a></td>";
			$html .= "<td class='text-center'><a href='" . DOCUMENT_ROOT . "/Editar/turma?id=" . $turma->getId() . "' class='btn btn-warning'><i class='fa fa-pencil'></i></a></td>";
			$html .= "<td class='text-center'>";
			$html .= "<!--Botão chamando o modal-->";
			$html .= "<a href='' class='btn btn-danger' data-toggle='modal' data-target='#exampleModalCenter".$turma->getId()."'><i class='fa fa-trash'></i></a>";
			$html .= "</td>";
			$html .= "</tr>";

			$html .= "<!-- Modal -->";
			$html .= "<div class='modal fade' id='exampleModalCenter".$turma->getId()."' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
			$html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
			$html .= "<div class='modal-content'>";
			$html .= "<div class='modal-header'>";
			$html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
			$html .= "<i class='fa fa-exclamation-triangle'> </i>  Atenção!</h3>";
			$html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
			$html .= "<i class='fa fa-times'></i>";
			$html .= "</button>";
			$html .= "</div>";
			$html .= "<div class='modal-body'>";
			$html .= "Tem certeza que deseja remover este Turma?";
			$html .= "</div>";
			$html .= "<div class='modal-footer'>";
			$html .= "<form method='post' action='" . DOCUMENT_ROOT . "/Deletar/turma'>";
			$html .= "<button type='button' class='btn btn-secondary' data-dismiss='modal'>Não, cancelar</button>";
			$html .= "<input type='hidden' value='".$turma->getId()."' name='id'>";
			$html .= "<button type='submit' class='btn btn-danger'><i class='fa fa-trash'></i> Sim, remover</button>";
			$html .= "</form>";
			$html .= "</div>";
			$html .= "</div>";
			$html .= "</div>";
			$html .= "</div>";
		}

		$html .= "</tbody>";
		$html .= "</table>";
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
	
	public function mostrar($turmas){
		$this->turmas = $turmas;
		echo $this->gerar();
	}
}