	<?php


class SolicitarView {
	
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
		$html .= "<link rel='stylesheet' href='" . DOCUMENT_ROOT . "/public/lib/css/ui/dist/semantic.css'>";
		$html .= "<link href='https://use.fontawesome.com/releases/v5.0.8/css/all.css' rel='stylesheet'>";
		$html .= "<link rel='stylesheet' href='" . DOCUMENT_ROOT . "/css/solicitar.css'>";
		$html .= "<link rel='stylesheet' href='" . DOCUMENT_ROOT . "/public/lib/css/ui/dist/components/button.css'>";
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
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/list.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/icon.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/sidebar.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/transition.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/components/form.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/css/login.css'>";
		$html .= "<link rel='stylesheet' href='". DOCUMENT_ROOT ."/public/css/index.css'>";
		$html .= "<!-- Scripts -->";
		$html .= "<script src='". DOCUMENT_ROOT ."/public/lib/css/ui/dist/jquery-3.2.1.min.js'></script>";
		$html .= "<script src='" . DOCUMENT_ROOT . "/public/lib/js/tables.js'></script>";
		$html .= "<script src='". DOCUMENT_ROOT ."/public/js/solicitar.js'></script>";
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
		$html .= "<a class='ui inverted green button' href='". DOCUMENT_ROOT ."/Login/principal' style='margin-left: 7%;'>Entrar</a>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<!--conteudo-->";
		$html .= "<div id='conteudo' class='ui grid'>";

		$html .= "<div class='row'>";

		$html .= "<div class='seven wide column' style='margin-left: 7%;'>";
		$html .= "<br><br>";
		$html .= "<form class='ui form' action='#' method='post' onsubmit='return validar(this);'>";
		$html .= "<h2 class='ui dividing header'>Solicitar o sistema</h2>";
		$html .= "<div class='field'>";
		$html .= "<b><label for='nome'>Nome completo</label></b>";
		$html .= "<input placeholder='Nome' type='text' id='nome' name='nome' required='required' maxlength='100' onchange='nome(this.value);'>";
		$html .= "<span id='nomeCompleto'></span>";
		$html .= "</div>";
		$html .= "<div class='field'>";
		$html .= "<b><label for='instituicao'>Instituição</label></b><input placeholder='Nome da instituição' type='text' id='instituicao' name='instituicao' required='required' maxlength='100'>";
		$html .= "</div>";
		$html .= "<div class='field'>";
		$html .= "<b><label for='email'>E-mail</label></b><input type='email' id='email' name='email' placeholder='exemplo@exemplo.com' required='required' maxlength='100'>";
		$html .= "</div>";
		$html .= "<div class='fields'>";
		$html .= "<div class='field'>";
		$html .= "<label for='contato1' style='margin-left: 3%;'>Telefone fixo</label>";
		$html .= "<input type='text' id='contato1' name='contato1' placeholder='Ex: 00 0000-0000' required='required' OnKeyPress='formatar('## ####-####', this)' maxlength='12' style='margin-left: 3%;'>";
		$html .= "<span id='mensagemContato1'></span>";
		$html .= "</div>";
		$html .= "<div class='field'>";
		$html .= "<label for='contato2'><i class='fab fa-whatsapp'></i> Contato 2</label>";
		$html .= "<input type='text' id='contato2' name='contato2' placeholder='Whatsapp' OnKeyPress='formatar('## #####-####', this)' maxlength='13'>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='field'>";
		$html .= "<b><label for='mensagem' style='margin-left: -0.5%;'>Mensagem</label></b>";
		$html .= "<textarea id='mensagem' name='mensagem' maxlength='2000' rows='5' cols='30' required='required' style='margin-left: -0.5%;'></textarea>";
		$html .= "</div>";
		$html .= "<center>";
		$html .= "<input type='submit' id='enviar' value='Enviar' class='ui green button'> <br><br><br>";
		$html .= "</center>";
		$html .= "</form>";
		$html .= "</div>";
		$html .= "<div class='five wide column'>";
		$html .= "<div class='five wide column'>";
		$html .= "<img id='logo' src='" . DOCUMENT_ROOT . "/public/video/escada.png' style='margin-left: 25%; margin-top: 8%;'>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<!-- Footer -->";
		$html .= "<div class='ui inverted vertical footer segment'>";
		$html .= "<div class='ui container'>";
		$html .= "<div class='ui stackable inverted divided equal height stackable grid' style='width: 100%;'>";
		$html .= "<div class='three wide column'>";
		$html .= "<h4 class='ui inverted header'>Sobre</h4>";
		$html .= "<div class='ui inverted link list'>";
		$html .= "<a href='' class='item'>Sitemap</a>";
		$html .= "<a href='' class='item'>Contact Us</a>";
		$html .= "<a href='' class='item'>Religious Ceremonies</a>";
		$html .= "<a href='' class='item'>Gazebo Plans</a>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='three wide column'>";
		$html .= "<h4 class='ui inverted header'>Serviços</h4>";
		$html .= "<div class='ui inverted link list'>";
		$html .= "<a href='' class='item'>Banana Pre-Order</a>";
		$html .= "<a href='' class='item'>DNA FAQ</a>";
		$html .= "<a href='' class='item'>How To Access</a>";
		$html .= "<a href='' class='item'>Favorite X-Men</a>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='seven wide column'>";
		$html .= "<h4 class='ui inverted header'>Contato</h4>";
		$html .= "<a href='' class='item'><i class='icon facebook'></i>S.A.G.A.</a> <br>";
		$html .= "<a href='' class='item'><i class='icon instagram'></i>S.A.G.A.</a> <br>";
		$html .= "<a href='' class='item'><i class='icon google'></i>S.A.G.A.</a> <br>";
		$html .= "<a href='' class='item'><i class='icon youtube'></i>S.A.G.A.</a>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</body>";
		$html .= "</html>";

		return $html;
	}
	
	public function mostrar(){
		echo $this->gerar();
	}
}