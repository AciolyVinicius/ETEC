<?php

class UsuarioDetalharView {

	private $usuario;
	
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
		$html .= "<h1><i class='fa fa-user' aria-hidden='true'></i> Visualizar Usuário</h1>	";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-4'>";
		$html .= "<h1><a href='" . DOCUMENT_ROOT . "/Listar/usuario' id='btnListagem' class='btn btn-default pull-right'><i class='fa fa-list'></i> Listagem</a></h1>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<hr>";
		$html .= "<div class='box-body'>";
		$html .= "<div class='col-12 col-md-12 jumbotron'>";
		$html .= "<center><h2>" . $this->usuario->getNome() . "</h2></center>";
		$html .= "<br>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-md-3'></div>";
		$html .= "<div class='col-md-9'>";
		$html .= "<p>";
		$html .= "<strong>Nome:</strong> " . $this->usuario->getNome() . " " . $this->usuario->getSobrenome() . "<br>";
		$html .= "<strong>Data de Nascimento: </strong> " . $this->usuario->getNascimento() . "<br>";
		$html .= "<strong>Endereço: </strong> " . $this->usuario->getRua() . ", " . $this->usuario->getNumeracao() . " - " . $this->usuario->getBairro() . " - " . $this->usuario->getCidade() . " - " . $this->usuario->getEstado() . "<br>";
		$html .= "<strong>CEP: </strong> " . $this->usuario->getCep() . "<br>";
		$html .= "<strong>E-mail:</strong> " . $this->usuario->getEmail() . "<br>";
		$html .= "<strong>CPF:</strong> " . $this->usuario->getCpf() . "<br>";
		$html .= "<strong>RG:</strong> " . $this->usuario->getRg() . "<br>";
		$html .= "<strong>Contato Primário:</strong> " . $this->usuario->getContato1() . "<br>";
		if (strlen($this->usuario->getContato2()) > 0) {
			$html .= "<strong>Contato Secundário:</strong> " . $this->usuario->getContato2() . "<br>";
		}

		if (strlen($this->usuario->getNomeResponsavel()) > 0) {
			$html .= "<strong>Nome do Responsavel:</strong> " . $this->usuario->getNomeResponsavel() . "<br>";
			$html .= "<strong>CPF do Responsavel:</strong> " . $this->usuario->getCpfResponsavel() . "<br>";
			$html .= "<strong>E-mail do Responsavel:</strong> " . $this->usuario->getEmailResponsavel() . "<br>";
			$html .= "<strong>Contato do Responsavel:</strong> " . $this->usuario->getContatoResponsavel() . "";
		}
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
	
	public function mostrar($usuario){
		$this->usuario = $usuario;
		echo $this->gerar();
	}
}