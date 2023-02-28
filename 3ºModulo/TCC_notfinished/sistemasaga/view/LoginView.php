<?php

class LoginView {
	
	private function gerar(){

		$html = "<!DOCTYPE html>";
		$html .= "<html>";
		$html .= "<head>";
		$html .= "<meta charset='UTF-8'>";
		$html .= "<!-- Meta Padrão -->";
		$html .= "<meta http-equiv='X-UA-Compatible' content='IE=edge,chrome=1'>";
		$html .= "<meta name='viewport' content='width=device-width, initial-scale=1.0, maximum-scale=1.0'>";
		$html .= "<!-- Propriedades do Site -->";
		$html .= "<title>S.A.G.A. - Sistema de Aprendizagem e Gestão Academica</title>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/reset.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/site.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/container.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/grid.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/header.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/image.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/menu.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/divider.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/dropdown.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/segment.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/button.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/list.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/icon.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/sidebar.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/transition.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/form.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/css/login.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/css/index.css'>";
		$html .= "<!-- Scripts -->";
		$html .= "<script src='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/jquery-3.2.1.min.js'></script>";
		$html .= "<script src='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/visibility.js'></script>";
		$html .= "<script src='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/sidebar.js'></script>";
		$html .= "<script src='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/transition.js'></script>";
		$html .= "<script src='". DOCUMENT_ROOT ."/public/js/login.js'></script>";
		$html .= "</head>";
		$html .= "<body class='pushable'>";
		$html .= "<!-- Conteúdo da Página -->";
		$html .= "<!-- Parte 1 -->";
		$html .= "<div class='pusher'>";
		$html .= "<div class='ui inverted vertical center aligned segment' id='teste'>";
		$html .= "<div class='ui container'>";
		$html .= "<div class='ui large secondary inverted pointing menu'>";
		$html .= "<a href='". DOCUMENT_ROOT ."' style='color: white; margin-left: 6%; margin-top: 15px; font-size: 40px;'>S.A.G.A.</a>";
		$html .= "<div class='right item'>";
		$html .= "<a class='ui inverted blue button' href='". DOCUMENT_ROOT ."' style='margin-left: -7%;'>Início </a>";
		$html .= "<a class='ui inverted red button' href='". DOCUMENT_ROOT ."/Principal/solicitar' style='margin-left: 7%;'>Solicitar</a>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<center><form class='ui form' action='". DOCUMENT_ROOT ."/Login/login' method='post' onsubmit='return validar(this);'>";
		$html .= "<h1 class='ui dividing header'><br>Acessar Sistema<br></h1><br>";
		$html .= "<div class='ui zero column middle aligned very relaxed stackable grid'>";
		$html .= "<div class='column'>";
		$html .= "<div class='ui form'>";
		$html .= "<div class='field'>";
		$html .= "<label for='email'>E-mail</label>";
		$html .= "<div class='ui left icon input'>";
		$html .= "<input type='email' id='email' name='email' required='required' placeholder='exemplo@exemplo.com' style='width: 400px;'>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='field'>";
		$html .= "<label for='senha'>Senha</label>";
		$html .= "<div class='ui left icon input'>";
		$html .= "<input type='password' id='senha' name='senha' size='35' required='' style='width: 400px;'>";
		$html .= "</div>";
		$html .= "</div>";
		if (isset($_SESSION['password'])) {
			$html .= "<p class='introp'>E-mail ou/e senha estão incorretos<p>";
			unset($_SESSION['password']);
		}
		$html .= "<center>";
		$html .= "<input class='ui checkbox' type='checkbox' name='esquecer'> Manter-me logado<br><br>";
		$html .= "<input type='submit' value='Entrar' class='ui green button'><br><br>";
		$html .= "<a href=''>Esqueceu sua senha?</a>";
		$html .= "</center>";
		$html .= "</form></center>";
		$html .= "</body>";
		$html .= "</html>";

		return $html;
	}
	public function mostrar(){

		echo $this->gerar();

	}
}
?>