<?php

class InstituicaoDetalharView {

	private $instituicao;
	
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
		$html .= "<h1><i class='fa fa-university' id='icon_gerenciamento' aria-hidden='true'></i> Instituição</h1>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-4'>";
		$html .= "<h1><a href='" . DOCUMENT_ROOT . "/Editar/instituicao' id='btnListagem' class='btn btn-warning pull-right'><i class='fa fa-search'></i> Editar Dados</a></h1>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<hr>";
		$html .= "<div class='box-body'>";
		$html .= "<div class='container'>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<h3>";
		$html .= "<strong class='text-primary'>Nome da Instituição</strong><br>";
		$html .= "<p class='text'>";
		$html .= $this->instituicao->getNome();
		$html .= "</p>";
		$html .= "<br>";
		$html .= "<strong class='text-primary'>Nome Fantasia da Instituição</strong><br>";
		$html .= "<p class='text'>";
		$html .= $this->instituicao->getFantasia();
		$html .= "</p>";
		$html .= "<br>";
		$html .= "<strong class='text-primary'>Contato Primário</strong><br>";
		$html .= "<p class='text'>";
		$html .= $this->instituicao->getContato1();
		$html .= "</p>";
		if (strlen($this->instituicao->getContato2()) > 0) {
			$html .= "<br>";
			$html .= "<strong class='text-primary'>Contato Secundário</strong><br>";
			$html .= "<p class='text'>";
			$html .= $this->instituicao->getContato2();
			$html .= "</p>";
		}
		$html .= "<br>";
		$html .= "<strong class='text-primary'>E-mail</strong><br>";
		$html .= "<p class='text'>";
		$html .= $this->instituicao->getEmail();
		$html .= "</p>";
		$html .= "</h3>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<h3>";
		$html .= "<strong class='text-primary'>CEP</strong><br>";
		$html .= "<p class='text'>";
		$html .= $this->instituicao->getCep();
		$html .= "</p>";
		$html .= "<br>";
		$html .= "<strong class='text-primary'>Endereço</strong><br>";
		$html .= "<p class='text'>";
		$html .= $this->instituicao->getRua().", ". $this->instituicao->getNumeracao()." - ".$this->instituicao->getBairro()." - ".$this->instituicao->getCidade()." - ".$this->instituicao->getEstado();
		$html .= "</p>";
		$html .= "<br>";
		$html .= "<strong class='text-primary'>CNPJ</strong><br>";
		$html .= "<p class='text'>";
		$html .= $this->instituicao->getCnpj();
		$html .= "</p>";
		$html .= "<br>";
		$html .= "<strong class='text-primary'>MEC</strong><br>";
		$html .= "<p class='text'>";
		$html .= $this->instituicao->getMec();
		$html .= "</p>";
		$html .= "<br>";
		$html .= "<strong class='text-primary'>Alvara</strong><br>";
		$html .= "<p class='text'>";
		$html .= $this->instituicao->getAlvara();
		$html .= "</p>";
		$html .= "</h3>";
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
	
	public function mostrar($instituicao){
		$this->instituicao = $instituicao;
		echo $this->gerar();
	}
}