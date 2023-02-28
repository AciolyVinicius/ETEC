<?php

class DashboardController{

	public function __construct(){
		new LoginMiddleware();
	}

	public function home(){
		$avisos = AvisoDAO::select();
		$usuario = UsuarioDAO::search($_SESSION['id']);
		$page = new HomeDashboardView();
		$page->mostrar($avisos, $usuario->getTurma());
	}

	public function gerenciamento(){
		new PermissoesMiddleware(5);
		$page = new GerenciamentoDashboardView();
		$page->mostrar();
	}

	public function nota(){

		$page = new NotaDashboardView();
		$page->mostrar();
	}

	public function disciplina(){

		$page = new DisciplinaDashboardView();
		$page->mostrar();
	}

	public function perfil(){
		try {
			$usuario = UsuarioDAO::search($_SESSION['id']);
			$instituicao = InstituicaoDAO::search();
		} catch(Exception $e){
			TryCatchError::erro($e);
		}
		$page = new PerfilDashboardView();
		$page->mostrar($usuario, $instituicao);
	}

	public function logout(){
		session_destroy();
		header("Location: " . DOCUMENT_ROOT);
		die();
	}
}