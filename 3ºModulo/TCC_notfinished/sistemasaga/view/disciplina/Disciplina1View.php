<?php

class Disciplina1View {
	
	private function gerar(){
		
		include_once "view/layout/header.php";
		

		$html .= "<div class='content-wrapper'>";
		$html .= "<!-- Main content -->";
		$html .= "<section class='content'>";

		$html .= "<div class='row'>";
		$html .= "<div class='col-md-12'>";
		$html .= "<div class='box'>";
		$html .= "<div class='box-header'>";
		$html .= "<h3 class='box-title'>";
		$html .= "<h1><i class='fa fa-book' id='icon_gerenciamento' aria-hidden='true'></i> Disciplina 1 (visão aluno)</h1>";
		$html .= "<hr>";

		$html .= "<div class='box-body'>";

		$html .= "<ul class='nav nav-tabs' id='myTab' role='tablist'>";
		$html .= "<li class='nav-item active'>";
		$html .= "<a class='nav-link active' id='home-tab' data-toggle='tab' href='#home' role='tab' aria-controls='home' aria-selected='true'>Objetivo da Disciplina</a>";
		$html .= "</li>";
		$html .= "<li class='nav-item'>";
		$html .= "<a class='nav-link' id='profile-tab' data-toggle='tab' href='#profile' role='tab' aria-controls='profile' aria-selected='false'>Materiais</a>";
		$html .= "</li>";
		$html .= "<li class='nav-item'>";
		$html .= "<a class='nav-link' id='contact-tab' data-toggle='tab' href='#contact' role='tab' aria-controls='contact' aria-selected='false'>Anotações</a>";
		$html .= "</li>";
		$html .= "</ul>";
		$html .= "<div class='tab-content' id='myTabContent'>";
		$html .= "<div class='tab-pane fade active in' id='home' role='tabpanel' aria-labelledby='home-tab'>";

		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-12'>";
		$html .= "<h3>";
		$html .= "<strong class='text-primary'>Ementa da Disciplina</strong><br>";
		$html .= "<p class='text'>";
		$html .= "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
		tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
		quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo
		consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse
		cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non
		proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
		$html .= "</p>";
		$html .= "<br>";

		$html .= "<strong class='text-primary'>Bibliografica Utilizada</strong><br>";
		$html .= "<p class='text'>";
		$html .= "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod
		tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
		quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo
		consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse
		cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non
		proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
		$html .= "</p>";
		$html .= "<br>";
		$html .= "<strong class='text-primary'>Disciplina Ministrada por: </strong><br>";
		$html .= "<p class='text'>";
		$html .= "<li>Renan Praxades</li>";
		$html .= "<li>Ciencias da Computação</li>";
		$html .= "<li>Unisanta</li>";
		$html .= "</p>";
		$html .= "</h3>";
		$html .= "</div>";
		$html .= "</div>";

		$html .= "</div>";
		$html .= "<div class='tab-pane fade' id='profile' role='tabpanel' aria-labelledby='profile-tab'>";

		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-12'>";
		$html .= "<h3>";
		$html .= "<strong class='text-primary'>Aula 01 - Assunto da Aula - Data</strong><br>";
		$html .= "<p class='text'>";
		$html .= "Material usado em sala (slides) (ppt ou atividade para fazer)";
		$html .= "</p>";
		$html .= "<i class='fa fa-download'><a href=''> Download</a></i>";
		$html .= "<br><br><br>";

		$html .= "<strong class='text-primary'>Aula 02 - Assunto da Aula - Data</strong><br>";
		$html .= "<p class='text'>";
		$html .= "Atividade para data (pdf com instruições e etc)";
		$html .= "</p>";
		$html .= "<i class='fa fa-download'><a href=''> Download</a></i>";
		$html .= "<br><br><br>";

		$html .= "<strong class='text-primary'>Aula 03 - Assunto da Aula - Data</strong><br>";
		$html .= "<p class='text'>";
		$html .= "Revisão P1";
		$html .= "</p>";
		$html .= "<i class='fa fa-download'><a href=''> Download</a></i>";
		$html .= "<br><br><br>";
		$html .= "</h3>";
		$html .= "</div>";
		$html .= "</div>";

		$html .= "</div>";
		$html .= "<div class='tab-pane fade' id='contact' role='tabpanel' aria-labelledby='contact-tab'>";

		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-12'>";
		$html .= "<h3>";
		$html .= "<a href='' id='btnListagem' class='btn btn-success' data-toggle='modal' data-target='#exampleModal1'>";
		$html .= "<i class='fa fa-plus'></i> Anotação";
		$html .= "</a>";
		$html .= "</h3>";
		$html .= "<div class='panel'>";
		$html .= "<div class='panel-body table-responsive'>";
		$html .= "<table class='table table-hover' id='instituicoes_table'>";
		$html .= "<thead>";
		$html .= "<th>Data</th>";
		$html .= "<th>Titulo</th>";
		$html .= "<th>Baixar</th>";
		$html .= "<th>Exibir</th>";
		$html .= "<th>Editar</th>";
		$html .= "<th>Apagar</th>";
		$html .= "</thead>";
		$html .= "<tbody>";
		$html .= "<tr>";
		$html .= "<td class='text-center'>20/02/2018</td>";
		$html .= "<td class='text-center'>Aula 01 - Definição de Variaveis</td>";
		$html .= "<td class='text-center'>";
		$html .= "<a href='' class='btn btn-default'><i class='fa fa-download'></i></a>";
		$html .= "</td>";
		$html .= "<td class='text-center'>";
		$html .= "<a href='' class='btn btn-info' data-toggle='modal' data-target='#exampleModal2'><i class='fa fa-eye'></i></a>";
		$html .= "</td>";
		$html .= "<td class='text-center'>";
		$html .= "<a href='' class='btn btn-warning' data-toggle='modal' data-target='#exampleModal3'><i class='fa fa-pencil'></i></a>";
		$html .= "</td>";
		$html .= "<td class='text-center'>";
		$html .= "<a href='' class='btn btn-danger' data-toggle='modal' data-target='#exampleModalCenter'><i class='fa fa-trash'></i></a>";
		$html .= "</td>";
		$html .= "</tr>";
		$html .= "<tr>";
		$html .= "<td class='text-center'>21/02/2018</td>";
		$html .= "<td class='text-center'>Aula 02 - Fazendo Bolo</td>";
		$html .= "<td class='text-center'>";
		$html .= "<a href='' class='btn btn-default'><i class='fa fa-download'></i></a>";
		$html .= "</td>";
		$html .= "<td class='text-center'>";
		$html .= "<a href='' class='btn btn-info' data-toggle='modal' data-target='#exampleModal2'><i class='fa fa-eye'></i></a>";
		$html .= "</td>";
		$html .= "<td class='text-center'>";
		$html .= "<a href='' class='btn btn-warning' data-toggle='modal' data-target='#exampleModal3'><i class='fa fa-pencil'></i></a>";
		$html .= "</td>";
		$html .= "<td class='text-center'>";
		$html .= "<a href='' class='btn btn-danger' data-toggle='modal' data-target='#exampleModalCenter'><i class='fa fa-trash'></i></a>";
		$html .= "</td>";
		$html .= "</tr>";
		$html .= "<tr>";
		$html .= "<td class='text-center'>25/02/2018</td>";
		$html .= "<td class='text-center'>Aula 03 - Sintaxe de Programação</td>";
		$html .= "<td class='text-center'>";
		$html .= "<a href='' class='btn btn-default'><i class='fa fa-download'></i></a>";
		$html .= "</td>";
		$html .= "<td class='text-center'>";
		$html .= "<a href='' class='btn btn-info' data-toggle='modal' data-target='#exampleModal2'><i class='fa fa-eye'></i></a>";
		$html .= "</td>";
		$html .= "<td class='text-center'>";
		$html .= "<a href='' class='btn btn-warning' data-toggle='modal' data-target='#exampleModal3'><i class='fa fa-pencil'></i></a>";
		$html .= "</td>";
		$html .= "<td class='text-center'>";
		$html .= "<a href='' class='btn btn-danger' data-toggle='modal' data-target='#exampleModalCenter'><i class='fa fa-trash'></i></a>";
		$html .= "</td>";
		$html .= "</tr>";
		$html .= "</tbody>";
		$html .= "</table>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";

		$html .= "</div>";
		$html .= "</div>";

		$html .= "</div>";

		$html .= "</h3>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";

		$html .= "</section>";
		$html .= "</div>";

		include_once "view/layout/footer.php";

		$html .= "<!-- Modal Adicionar Aviso-->";
		$html .= "<div class='modal fade' id='exampleModal1' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
		$html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
		$html .= "<div class='modal-content'>";
		$html .= "<div class='modal-header'>";
		$html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
		$html .= "<i class='fa fa-pencil'> </i>  Adicionar Anotação</h3>";
		$html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
		$html .= "<i class='fa fa-times'></i>";
		$html .= "</button>";
		$html .= "</div>";
		$html .= "<div class='modal-body'>";

		$html .= "<form method='post' action='#'>";

		include_once "view/anotacao/add.php";

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

		$html .= "<!-- Modal Show Aviso-->";
		$html .= "<div class='modal fade' id='exampleModal2' tabindex='-1' role='dialog' aria-labelledby='exampleModalCenterTitle' aria-hidden='true'>";
		$html .= "<div class='modal-dialog modal-dialog-centered' role='document'>";
		$html .= "<div class='modal-content'>";
		$html .= "<div class='modal-header'>";
		$html .= "<h3 class='modal-title' id='exampleModalLongTitle'>";
		$html .= "<i class='fa fa-pencil'> </i>  Titulo Anotação</h3>";
		$html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
		$html .= "<i class='fa fa-times'></i>";
		$html .= "</button>";
		$html .= "</div>";
		$html .= "<div class='modal-body'>";

		include_once "view/anotacao/show.php";

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
		$html .= "<i class='fa fa-pencil'> </i>  Editar Anotação</h3>";
		$html .= "<button id='btnModalDelete' type='button' class='close' data-dismiss='modal' aria-label='Close'>";
		$html .= "<i class='fa fa-times'></i>";
		$html .= "</button>";
		$html .= "</div>";
		$html .= "<div class='modal-body'>";

		include_once "view/anotacao/edit.php";

		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";


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
		$html .= "Tem certeza que deseja remover esta Anotação?";
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

		return $html;
	}
	
	public function mostrar(){
		echo $this->gerar();
	}
}