<?php

class HomeDashboardView {

	private $avisos;
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
		$html .= "<h1><i class='fa fa-dashboard' aria-hidden='true'></i> Home</h1>	";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<hr>";
		$html .= "<div class='box-body'>";
		$html .= "<div class='col-12 col-md-8'>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-10'>";
		$html .= "<h2><i class='fa fa-bullhorn'></i> Avisos</h2>";
		$html .= "</div>";

		if ($_SESSION['tipo_id'] == 2 || $_SESSION['tipo_id'] >= 4) {
			$html .= "<div class='col-12 col-md-2'>";
			$html .= "<h3><a href='' id='btnListagem' class='btn btn-success' data-toggle='modal' data-target='#exampleModal1'><i class='fa fa-plus'></i> Avisos</a></h3>";
			$html .= "</div>";
		}
		$html .= "</div>";

		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-12'>";

		$html .= "<!--primeira table de avisos-->";
		$html .= "<div class='panel panel-info'>";
		$html .= "<div class='panel-heading'>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-md-11'>";
		$html .= "<h3 class='panel-title' id='tituloHome'>Avisos Gerais</h3>";
		$html .= "</div>";
		$html .= "<div class='col-md-1' id='btnHome'>";
		$html .= "<a class='btn btn-default btn-clickable pull-right'>";
		$html .= "<i class='fa fa-chevron-down'></i> ";
		$html .= "</a>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='panel-body table-responsive'>";
		$html .= "<table class='table table-hover'>";
		$html .= "<thead>";
		$html .= "<th class='text-center'>Titulo</th>";
		$html .= "<th class='text-center'>Data</th>";
		$html .= "<th class='text-center'>Autor</th>";
		$html .= "<th class='text-center'>Categoria</th>";
		$html .= "<th class='text-center'>Ação</th>";
		$html .= "</thead>";
		$html .= "<tbody>";

		foreach ($this->avisos as $aviso) {
			if (!($aviso->getCurso()->getId() > 0 || $aviso->getTurma()->getId() > 0)) {
				$html .= "<tr>";
				$html .= "<td class='text-center'>".$aviso->getNome()."</td>";
				$html .= "<td class='text-center'>10/03/2018</td>";
				$html .= "<td class='text-center'>".$aviso->getUsuario()->getNome()."</td>";
				$html .= "<td class='text-center'>".$aviso->getUsuario()->getTipo()->getNome()."</td>";
				$html .= "<td class='text-center'>";
				$html .= "<a href='' class='btn btn-info' data-toggle='modal' data-target='#exampleModal2'><i class='fa fa-eye'></i></a> ";
				$html .= "<a href='' class='btn btn-warning' data-toggle='modal' data-target='#exampleModal3'><i class='fa fa-pencil'></i></a> ";
				$html .= "<a href='' class='btn btn-danger' data-toggle='modal' data-target='#exampleModalCenter'><i class='fa fa-trash'></i></a>";
				$html .= "</td>";
				$html .= "</tr>";
			}
		}
		$html .= "</tbody>";
		$html .= "</table>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<!--fim primeira table de avisos-->";
		$html .= "<!--segunda table de avisos-->";
		$html .= "<div class='panel panel-info'>";
		$html .= "<div class='panel-heading'>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-md-11'>";
		$html .= "<h3 class='panel-title' id='tituloHome'>Avisos Curso</h3>";
		$html .= "</div>";
		$html .= "<div class='col-md-1' id='btnHome'>";
		$html .= "<a class='btn btn-default btn-clickable pull-right'>";
		$html .= "<i class='fa fa-chevron-down'></i> ";
		$html .= "</a>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='panel-body table-responsive'>";

		$html .= "<table class='table table-hover'>";
		$html .= "<thead>";
		$html .= "<th class='text-center'>Titulo</th>";
		$html .= "<th class='text-center'>Data</th>";
		$html .= "<th class='text-center'>Autor</th>";
		$html .= "<th class='text-center'>Categoria</th>";
		$html .= "<th class='text-center'>Ação</th>";
		$html .= "</thead>";
		$html .= "<tbody>";
		foreach ($this->avisos as $aviso) {
			if ($aviso->getCurso()->getId() > 0 && !($aviso->getTurma()->getId() > 0) && $this->turma->getCurso()->getId() == $aviso->getCurso()->getId()) {
				$html .= "<tr>";
				$html .= "<td class='text-center'>".$aviso->getNome()."</td>";
				$html .= "<td class='text-center'>10/03/2018</td>";
				$html .= "<td class='text-center'>".$aviso->getUsuario()->getNome()."</td>";
				$html .= "<td class='text-center'>".$aviso->getUsuario()->getTipo()->getNome()."</td>";
				$html .= "<td class='text-center'>";
				$html .= "<a href='' class='btn btn-info'><i class='fa fa-eye'></i></a> ";
				$html .= "<a href='' class='btn btn-warning'><i class='fa fa-pencil'></i></a> ";
				$html .= "<a href='' class='btn btn-danger'><i class='fa fa-trash'></i></a>";
				$html .= "</td>";
				$html .= "</tr>";
			}
		}

		$html .= "</tbody>";
		$html .= "</table>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<!--fim segunda table de avisos-->";
		$html .= "<!--terceira table de avisos-->";
		$html .= "<div class='panel panel-info'>";
		$html .= "<div class='panel-heading'>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-md-11'>";
		$html .= "<h3 class='panel-title' id='tituloHome'>Avisos Turma</h3>";
		$html .= "</div>";
		$html .= "<div class='col-md-1' id='btnHome'>";
		$html .= "<a class='btn btn-default btn-clickable pull-right'>";
		$html .= "<i class='fa fa-chevron-down'></i> ";
		$html .= "</a>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='panel-body table-responsive'>";

		$html .= "<table class='table table-hover'>";
		$html .= "<thead>";
		$html .= "<th class='text-center'>Titulo</th>";
		$html .= "<th class='text-center'>Data</th>";
		$html .= "<th class='text-center'>Autor</th>";
		$html .= "<th class='text-center'>Categoria</th>";
		$html .= "<th class='text-center'>Ação</th>";
		$html .= "</thead>";
		$html .= "<tbody>";

		foreach ($this->avisos as $aviso) {
			if (!($aviso->getCurso()->getId()) > 0 && $aviso->getTurma()->getId() > 0 && $this->turma->getId() == $aviso->getTurma()->getId()) {
				$html .= "<tr>";
				$html .= "<td class='text-center'>".$aviso->getNome()."</td>";
				$html .= "<td class='text-center'>10/03/2018</td>";
				$html .= "<td class='text-center'>".$aviso->getUsuario()->getNome()."</td>";
				$html .= "<td class='text-center'>".$aviso->getUsuario()->getTipo()->getNome()."</td>";
				$html .= "<td class='text-center'>";
				$html .= "<a href='' class='btn btn-info'><i class='fa fa-eye'></i></a> ";
				$html .= "<a href='' class='btn btn-warning'><i class='fa fa-pencil'></i></a> ";
				$html .= "<a href='' class='btn btn-danger'><i class='fa fa-trash'></i></a>";
				$html .= "</td>";
				$html .= "</tr>";
			}
		}

		$html .= "</tbody>";
		$html .= "</table>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<!--fim terceira table de avisos-->";
		$html .= "</div>	";
		$html .= "</div>	";
		$html .= "</div>";


		$html .= "<div class='col-12 col-md-4'>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-9'>";
		$html .= "<h2><i class='fa fa-line-chart'></i> Status</h2>";
		$html .= "</div>";
		$html .= "</div>";

		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-12'>";
		$html .= "<!--primeiro grafico home-->";
		$html .= "<div class='panel panel-info'>";
		$html .= "<div class='panel-heading'>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-md-10'>";
		$html .= "<h3 class='panel-title' id='tituloHome'>Frequencia</h3>  ";
		$html .= "</div>";
		$html .= "<div class='col-md-2' id='btnHome'>";
		$html .= "<a class='btn btn-default btn-clickable pull-right'>";
		$html .= "<i class='fa fa-chevron-down'></i> ";
		$html .= "</a>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='panel-body'>";
		$html .= "<center>";
		$html .= "<div class='circles'>";
		$html .= "<div class='first circle'>";
		$html .= "<h4><strong></strong></h4>";
		$html .= "<span>Media de Frequencia</span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</center>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<!--fim primeiro grafico home-->";
		$html .= "<!--segundo grafico home-->";
		$html .= "<div class='panel panel-info'>";
		$html .= "<div class='panel-heading'>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-md-10'>";
		$html .= "<h3 class='panel-title' id='tituloHome'>Notas</h3>  ";
		$html .= "</div>";
		$html .= "<div class='col-md-2' id='btnHome'>";
		$html .= "<a class='btn btn-default btn-clickable pull-right'>";
		$html .= "<i class='fa fa-chevron-down'></i> ";
		$html .= "</a>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='panel-body'>";
		$html .= "<center>";
		$html .= "<div class='circles'>";
		$html .= "<div class='second circle'>";
		$html .= "<h4><strong></strong></h4>";
		$html .= "<span>Media das Notas</span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</center>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<!--fim segundo grafico home-->";
		$html .= "<!--terceiro grafico home-->";
		$html .= "<div class='panel panel-info'>";
		$html .= "<div class='panel-heading'>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-md-10'>";
		$html .= "<h3 class='panel-title' id='tituloHome'>Conclusão Curso</h3>  ";
		$html .= "</div>";
		$html .= "<div class='col-md-2' id='btnHome'>";
		$html .= "<a class='btn btn-default btn-clickable pull-right'>";
		$html .= "<i class='fa fa-chevron-down'></i> ";
		$html .= "</a>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='panel-body'>";
		$html .= "<center>";
		$html .= "<div class='circles'>";
		$html .= "<div class='third circle'>";
		$html .= "<h4><strong></strong></h4>";
		$html .= "<span>Media de Conclusão</span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</center>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<!--fim terceiro grafico home-->";
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

		$html .= "<!-- Modal Excluir Aviso-->";
		$html .= "<div class='modal fade' id='exampleModalCenter' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
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
		$html .= "Tem certeza que deseja remover este Aviso?";
		$html .= "</div>";
		$html .= "<div class='modal-footer'>";
		$html .= "<form method='post' action='#'>";
		$html .= "<button type='button' class='btn btn-secondary' data-dismiss='modal'>Não, cancelar</button>";
		$html .= "<button type='submit' class='btn btn-danger'><i class='fa fa-trash'></i> Sim, remover</button>";
		$html .= "</form>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		
		if ($_SESSION['tipo_id'] == 2 || $_SESSION['tipo_id'] >= 4) {
			$html .= "<!-- Modal Adicionar Aviso-->";
			$html .= "<div class='modal fade' id='exampleModal1' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
			$html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
			$html .= "<div class='modal-content'>";
			$html .= "<div class='modal-header'>";
			$html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
			$html .= "<i class='fa fa-bullhorn'> </i>  Adicionar Aviso</h3>";
			$html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
			$html .= "<i class='fa fa-times'></i>";
			$html .= "</button>";
			$html .= "</div>";
			$html .= "<div class='modal-body'>";
			$html .= "<form method='post' action='" . DOCUMENT_ROOT . "/Aviso/adicionar'>";
			include_once "view/aviso/add.php";
			$html .= "</div>";
			$html .= "<div class='modal-footer'>";
			$html .= "<div class='col-12 col-md-6'>";
			$html .= "<button type='submit' id='btnCadastrar' class='btn btn-success'><i class='fa fa-check'></i> Adicionar</button>";
			$html .= "</div>";
			$html .= "<div class='col-12 col-md-6'>";
			$html .= "<button type='button' id='btnCadastrar' class='btn btn-danger' data-dismiss='modal'>Cancelar</button>";
			$html .= "</div>";
			$html .= "</form>";
			$html .= "</div>";
			$html .= "</div>";
			$html .= "</div>";
			$html .= "</div>";
		}

		$html .= "<!-- Modal Show Aviso-->";
		$html .= "<div class='modal fade' id='exampleModal2' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
		$html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
		$html .= "<div class='modal-content'>";
		$html .= "<div class='modal-header'>";
		$html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
		$html .= "<i class='fa fa-bullhorn'> </i>  Titulo Aviso</h3>";
		$html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
		$html .= "<i class='fa fa-times'></i>";
		$html .= "</button>";
		$html .= "</div>";
		$html .= "<div class='modal-body'>";

		include_once "view/aviso/show.php";

		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";

		$html .= "<!-- Modal Edit Aviso-->";
		$html .= "<div class='modal fade' id='exampleModal3' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
		$html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
		$html .= "<div class='modal-content'>";
		$html .= "<div class='modal-header'>";
		$html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
		$html .= "<i class='fa fa-bullhorn'> </i>  Editar Aviso</h3>";
		$html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
		$html .= "<i class='fa fa-times'></i>";
		$html .= "</button>";
		$html .= "</div>";
		$html .= "<div class='modal-body'>";

		include_once "view/aviso/edit.php";

		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";

		return $html;
	}
	
	public function mostrar($avisos, $turma){
		$this->avisos = $avisos;
		$this->turma = $turma;
		echo $this->gerar();
	}
}