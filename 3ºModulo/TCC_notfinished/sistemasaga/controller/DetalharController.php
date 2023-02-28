<?php

class DetalharController{

	public function __construct(){
		new LoginMiddleware();
		new PermissoesMiddleware(5);
	}

	public function instituicao(){
		try {
			$instituicao = InstituicaoDAO::search();
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$page = new InstituicaoDetalharView();
		$page->mostrar($instituicao);
	}

	public function usuario(){
		$id = $_GET['id'];

		try {
			$usuario = UsuarioDAO::search($id);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$page = new UsuarioDetalharView();
		$page->mostrar($usuario);
	}

	public function curso(){
		$id = $_GET['id'];

		try {
			$curso = CursoDAO::search($id);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$page = new CursoDetalharView();
		$page->mostrar($curso);
	}

	public function disciplina(){
		$id = $_GET['id'];

		try {
			$disciplina = DisciplinaDAO::search($id);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$page = new DisciplinaDetalharView();
		$page->mostrar($disciplina);
	}

	public function turno(){
		$id = $_GET['id'];

		try {
			$turno = TurnoDAO::search($id);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$page = new TurnoDetalharView();
		$page->mostrar($turno);
	}

	public function turma(){
		$id = $_GET['id'];

		try {
			$turma = TurmaDAO::search($id);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$page = new TurmaDetalharView();
		$page->mostrar($turma);
	}
}