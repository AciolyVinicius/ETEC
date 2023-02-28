<?php

class UsuarioFormularioView {

	private $usuario;
	private $tipos;
	private $turmas;
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
		$html .= "<h1><i class='fa fa-user' aria-hidden='true'></i> " . $this->controller ." Usuário</h1>	";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-4'>";
		$html .= "<h1><a href='" . DOCUMENT_ROOT . "/Listar/usuario' id='btnListagem' class='btn btn-default pull-right'><i class='fa fa-list'></i> Listagem</a></h1>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<hr>";
		$html .= "<form method='post' action='" . DOCUMENT_ROOT . "/" . $this->controller ."/usuarios' enctype='multipart/form-data'>";
		$html .= "<div class='box-body'>";
		$html .= "<div class='row clearfix'>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<label for='tipo_usuario' class='control-label'><span class='text-danger'>*</span>Tipo</label>";
		$html .= "<div class='form-group'>";
		$html .= "<select class='form-control' required='' name='tipo' id='tipo_usuario'>";
		foreach ($this->tipos as $key => $tipo) {
			if ($this->controller == "Editar") {
				$selected = $tipo->getId() == $this->usuario->getTipo()->getId() ? "selected=''" : "";
			} else  {
				$selected = $key == 0 ? "selected=''" : "";
			}
			$html .= "<option ".$selected." class='text-center' value='".$tipo->getId()."'>".$tipo->getNome()."</option>";
		}
		$html .= "</select>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<label for='turma' class='control-label'><span class='text-danger'>*</span>Turma</label>";
		$html .= "<div class='form-group'>";
		$html .= "<select class='form-control' required='' name='turma' id='turma'>";
		foreach ($this->turmas as $key => $turma) {
			if ($this->controller == "Editar") {
				$selected = $turma->getId() == $this->usuario->getTurma()->getId() ? "selected=''" : "";
			} else  {
				$selected = $key == 0 ? "selected=''" : "";
			}
			$html .= "<option ".$selected." class='text-center' value='".$turma->getId()."'>".$turma->getNome()."</option>";
		}
		$html .= "</select>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<label for='nome' class='control-label'><span class='text-danger'>*</span>Nome</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='nome' required='' value='" . $this->usuario->getNome() . "' class='form-control' id='nome' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<label for='sobrenome' class='control-label'><span class='text-danger'>*</span>Sobrenome</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='sobrenome' required='' value='" . $this->usuario->getSobrenome() . "' class='form-control' id='sobrenome' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<label for='nascimento' class='control-label'><span class='text-danger'>*</span>Nascimento</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='date' name='nascimento' required='' value='" . $this->usuario->getNascimento() . "' class='form-control' id='nascimento' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<label for='foto' class='control-label'> Foto </label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='file' name='foto' value='" . base64_encode($this->usuario->getFoto()) . "' class='form-control' id='foto' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<label for='email' class='control-label'><span class='text-danger'>*</span>Email</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='email' name='email' value='" . $this->usuario->getEmail() . "' required='' class='form-control' id='email' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-6 col-md-6'>";
		$html .= "<label for='contato1' class='control-label'><span class='text-danger'>*</span>Contato Primário</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='contato1' value='" . $this->usuario->getContato1() . "' required='' OnKeyPress='formatar('## ####-####', this)' maxlength='12' class='form-control' id='contato1' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-6 col-md-6'>";
		$html .= "<label for='contato2' class='control-label'>Contato Secundário</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='contato2'  value='" . $this->usuario->getContato2() . "' OnKeyPress='formatar('## #####-####', this)' maxlength='13' class='form-control' id='contato2' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-6 col-md-12'>";
		$html .= "<label for='cpf' class='control-label'><span class='text-danger'>*</span>CPF</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='cpf' value='" . $this->usuario->getCpf() . "' required='' OnKeyPress='formatar('###.###.###-##', this)' maxlength='14' class='form-control' id='cpf' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-6 col-md-12'>";
		$html .= "<label for='rg' class='control-label'><span class='text-danger'>*</span>RG</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='rg' value='" . $this->usuario->getRg() . "' required='' OnKeyPress='formatar('##.###.###-#', this)' maxlength='12' class='form-control' id='rg' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-12 col-md-6'>";
		$html .= "<label for='cep' class='control-label'><span class='text-danger'>*</span>Cep</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='cep' value='" . $this->usuario->getCep() . "' required='' class='form-control' id='cep' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "<div id='endRua' class='col-12 col-md-9'>";
		$html .= "<label for='rua' class='control-label'><span class='text-danger'>*</span>Rua</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='rua' required='' value='" . $this->usuario->getRua() . "' class='form-control' id='endereco' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div id='endNum' class='col-12 col-md-3'>";
		$html .= "<label for='numeracao' class='control-label'><span class='text-danger'>*</span>Numeracao</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='numeracao' required='' value='" . $this->usuario->getNumeracao() . "' class='form-control' id='' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<label for='bairro' class='control-label'><span class='text-danger'>*</span>Bairro</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='bairro' required='' value='" . $this->usuario->getBairro() . "' class='form-control' id='bairro' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "<div id='endCid' class='col-12 col-md-9'>";
		$html .= "<label for='cidade' class='control-label'><span class='text-danger'>*</span>Cidade</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='cidade' required='' value='" . $this->usuario->getCidade() . "' class='form-control' id='cidade' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div id='endEst' class='col-12 col-md-3'>";
		$html .= "<label for='estado' class='control-label'><span class='text-danger'>*</span>Estado</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='estado' required='' value='" . $this->usuario->getEstado() . "' class='form-control' id='estado' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<label for='nome_responsavel' class='control-label'>Nome do Responsavel</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='nome_responsavel' value='" . $this->usuario->getNomeResponsavel() . "' class='form-control' id='nome_responsavel' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "<label for='email_responsavel' class='control-label'>E-mail do Responsavel</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='email' name='email_responsavel' value='" . $this->usuario->getEmailResponsavel() . "' class='form-control' id='email_responsavel' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "<div class='row'>";
		$html .= "<div class='col-6 col-md-6'>";
		$html .= "<label for='cpf_responsavel' class='control-label'>CPF Responsavel</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='cpf_responsavel' value='" . $this->usuario->getCpfResponsavel() . "' OnKeyPress='formatar('###.###.###-##', this)' maxlength='14' class='form-control' id='cpf_responsavel' />";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
		$html .= "</div>";
		$html .= "<div class='col-6 col-md-6'>";
		$html .= "<label for='contato_responsavel' class='control-label'>Contato Responsavel</label>";
		$html .= "<div class='form-group'>";
		$html .= "<input type='text' name='contato_responsavel' value='" . $this->usuario->getContatoResponsavel() . "' OnKeyPress='formatar('## ####-####', this)' maxlength='12' class='form-control' id='contato_responsavel' />";
		$html .= "<input type='hidden' name='id' value='" . $this->usuario->getId() . "'>";
		$html .= "<span class='text-danger'></span>";
		$html .= "</div>";
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
		$html .= "<form action='" . DOCUMENT_ROOT . "/Listar/usuario'>";
		$html .= "<div class='col-6 col-md-6'>";
		$html .= "<button id='btnCancelar' type='submit' class='btn btn-danger'>";
		$html .= "<i class='fa fa-times'></i> Cancelar";
		$html .= "</button>";
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
	
	public function mostrar($usuario, $tipos, $turmas, $controller){
		$this->usuario = $usuario;
		$this->tipos = $tipos;
		$this->turmas = $turmas;
		$this->controller = $controller;
		echo $this->gerar();
	}
}