<?php

class PerfilDashboardView {

	private $usuario;
	private $instituicao;
	
	private function gerar(){
		include_once "view/layout/header.php";
		$html.= "<!-- Content Wrapper. Contains page content -->";
		$html.= "<div class='content-wrapper'>";
		$html.= "<!-- Main content -->";
		$html.= "<section class='content'>";
		$html.= "<div class='row'>";
		$html.= "<div class='col-12 col-md-12'>";
		$html.= "<div class='box'>";
		$html.= "<div class='box-header'>";
		$html.= "<div class='col-12 col-md-12'>";
		$html.= "<h1><i class='fa fa-user' aria-hidden='true'></i> Perfil</h1>	";
		$html.= "</div>";
		$html.= "</div>";
		$html.= "<div class='box-body'>";

		$html.= "<ul class='nav nav-tabs' id='myTab' role='tablist'>";
		$html.= "<li class='nav-item active'>";
		$html.= "<a class='nav-link active' id='home-tab' data-toggle='tab' href='#home' role='tab' aria-controls='home' aria-selected='true'>Meus Dados</a>";
		$html.= "</li>";
		if (strlen($this->usuario->getNomeResponsavel()) > 0) {
			$html.= "<li class='nav-item'>";
			$html.= "<a class='nav-link' id='profile-tab' data-toggle='tab' href='#profile' role='tab' aria-controls='profile' aria-selected='false'>Dados do Responsavel</a>";
			$html.= "</li>";
		}
		$html.= "<li class='nav-item'>";
		$html.= "<a class='nav-link' id='contact-tab' data-toggle='tab' href='#contact' role='tab' aria-controls='contact' aria-selected='false'>Dados da Instituição</a>";
		$html.= "</li>";
		$html.= "</ul>";
		$html.= "<div class='tab-content' id='myTabContent'>";
		$html.= "<div class='tab-pane fade active in' id='home' role='tabpanel' aria-labelledby='home-tab'>";

		$html.= "<div class='row'>";
		$html.= "<div class='col-12 col-md-3'>";
		$html.= "<center><img id='imgPerfil' src='".DOCUMENT_ROOT.$_SESSION['foto']."?v=".Date("Y.m.d.G.i.s")."'></center>";
		$html.= "</div>";
		$html.= "<div class='col-12 col-md-5'>";
		$html.= "<h3>";
		$html.= "<strong class='text-primary'>Categoria</strong><br>";
		$html.= "<span class='text'>";
		$html.= $_SESSION['tipo_nome'];
		$html.= "</span>";
		$html.= "<br><br>";
		$html.= "<strong class='text-primary'>Nome</strong><br>";
		$html.= "<span class='text'>";
		$html .= $this->usuario->getNome()." ".$this->usuario->getSobrenome();
		$html.= "</span>";
		$html.= "<br><br>";
		$html.= "<strong class='text-primary'>Data</strong><br>";
		$html.= "<span class='text'>";
		$html .= $this->usuario->getNascimento();
		$html.= "</span>";
		$html.= "<br><br>";
		$html.= "<strong class='text-primary'>RG</strong><br>";
		$html.= "<span class='text'>";
		$html .= $this->usuario->getRg();
		$html.= "</span>";
		$html.= "<br><br>";
		$html.= "<strong class='text-primary'>CPF</strong><br>";
		$html.= "<span class='text'>";
		$html .= $this->usuario->getCpf();
		$html.= "</span>";
		$html.= "<br><br>";
		$html.= "<strong class='text-primary'>Endereço</strong><br>";
		$html.= "<span class='text'>";
		$html .= $this->usuario->getRua().", ". $this->usuario->getNumeracao()." - ".$this->usuario->getBairro()." - ".$this->usuario->getCidade()." - ".$this->usuario->getEstado();
		$html.= "</span>";
		$html.= "</h3>";
		$html.= "</div>";
		$html.= "<div class='col-12 col-md-4'>";
		$html.= "<h3>";
		$html.= "<strong class='text-primary'>E-mail</strong><br>";
		$html.= "<span class='text'>";
		$html .= $this->usuario->getEmail();
		$html.= "</span>";
		$html.= "<br><br>";
		$html.= "<strong class='text-primary'>Contato Primário</strong><br>";
		$html.= "<span class='text'>";
		$html .= $this->usuario->getContato1();
		$html.= "</span>";
		if (strlen($this->usuario->getContato2()) > 0) {
			$html.= "<br><br>";
			$html.= "<strong class='text-primary'>Contato Secundário</strong><br>";
			$html.= "<span class='text'>";
			$html .= $this->usuario->getContato2();
			$html.= "</span>";
		}
		$html.= "<br>";
		$html.= "<br>";
		if (strlen($this->usuario->getTurma()->getNome()) > 0) {
			$html.= "<strong class='text-primary'>Curso</strong><br>".$this->usuario->getTurma()->getCurso()->getNome()."<br><br>";
			$html.= "<strong class='text-primary'>Turma</strong><br>".$this->usuario->getTurma()->getNome()."<br><br>";
			$html.= "<strong class='text-primary'>Turno</strong><br>".$this->usuario->getTurma()->getTurno()->getNome();
		}
		$html.= "</h3>";
		$html.= "</div>";
		$html.= "</div>";

		$html.= "</div>";
		$html.= "<div class='tab-pane fade' id='profile' role='tabpanel' aria-labelledby='profile-tab'>";

		$html.= "<div class='row'>";
		$html.= "<div class='col-12 col-md-2'>";
		$html.= "<!--<center><img id='imgPerfil' src='/tcc/resources/img/teste.jpg'></center>-->";
		$html.= "</div>";
		$html.= "<div class='col-12 col-md-5'>";
		$html.= "<h3>";
		$html.= "<strong class='text-primary'>Nome do Responsavel</strong><br>";
		$html.= "<span class='text'>";
		$html .= $this->usuario->getNomeResponsavel();
		$html.= "</span>";
		$html.= "<br><br>";
		$html.= "<strong class='text-primary'>E-mail do Responsavel</strong><br>";
		$html.= "<span class='text'>";
		$html .= $this->usuario->getEmailResponsavel();
		$html.= "</span>";
		$html.= "</h3>";
		$html.= "</div>";
		$html.= "<div class='col-12 col-md-5'>";
		$html.= "<h3>";
		$html.= "<strong class='text-primary'>CPF do Responsavel</strong><br>";
		$html.= "<span class='text'>";
		$html .= $this->usuario->getCpfResponsavel();
		$html.= "</span>";
		$html.= "<br><br>";
		$html.= "<strong class='text-primary'>Contato</strong><br>";
		$html.= "<span class='text'>";
		$html .= $this->usuario->getContatoResponsavel();
		$html.= "</span>";
		$html.= "</h3>";
		$html.= "</div>";
		$html.= "</div>";

		$html.= "</div>";
		$html.= "<div class='tab-pane fade' id='contact' role='tabpanel' aria-labelledby='contact-tab'>";

		$html.= "<div class='row'>";
		$html.= "<div class='col-12 col-md-2'>";
		$html.= "<!--<center><img id='imgPerfil' src='/tcc/resources/img/teste.jpg'></center>-->";
		$html.= "</div>";
		$html.= "<div class='col-12 col-md-5'>";
		$html.= "<h3>";
		$html.= "<strong class='text-primary'>Instituição</strong><br>";
		$html.= "<span class='text'>";
		$html .= $this->instituicao->getFantasia();
		$html.= "</span>";
		$html.= "<br><br>";
		$html.= "<strong class='text-primary'>E-mail Instituicional</strong><br>";
		$html.= "<span class='text'>";
		$html .= $this->instituicao->getEmail();
		$html.= "</span>";
		$html.= "</h3>";
		$html.= "</div>";
		$html.= "<div class='col-12 col-md-5'>";
		$html.= "<h3>";
		$html.= "<strong class='text-primary'>Contato Primário</strong><br>";
		$html.= "<span class='text'>";
		$html .= $this->instituicao->getContato1();
		$html.= "</span>";
		$html.= "<br><br>";
		$html.= "<strong class='text-primary'>Contato Secundário</strong><br>";
		$html.= "<span class='text'>";
		$html .= $this->instituicao->getContato2();
		$html.= "</span>";
		$html.= "</h3>";
		$html.= "</div>";
		$html.= "</div>";
		$html.= "<div class='row'>";
		$html.= "<div class='col-12 col-md-2'></div>";
		$html.= "<div class='col-md-8'>";
		$html.= "<h3>";
		$html.= "<strong class='text-primary'>Endereço</strong><br>";
		$html.= "<span class='text'>";
		$html .= $this->instituicao->getRua().", ". $this->instituicao->getNumeracao()." - ".$this->instituicao->getBairro()." - ".$this->instituicao->getCidade()." - ".$this->instituicao->getEstado();
		$html.= "</span>";
		$html.= "</h3>";
		$html.= "</div>";
		$html.= "</div>";

		$html.= "</div>";
		$html.= "</div>";

		$html.= "</div>";
		$html.= "</div>";
		$html.= "</div>";
		$html.= "</div>";

		$html.= "</section>";
		$html.= "<!-- /.content -->";
		$html.= "</div>";
		include_once "view/layout/footer.php";
		return $html;
	}
	
	public function mostrar($usuario, $instituicao){
		$this->usuario = $usuario;
		$this->instituicao = $instituicao;
		echo $this->gerar();
	}
}