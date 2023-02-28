<?php

class DeletarController{

	public function __construct(){
		new LoginMiddleware();
		new PermissoesMiddleware(5);
	}
	
	public function usuario(){
		$id = $_POST['id'];
		try {
			UsuarioDAO::delete($id);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}
		header("Location: " . DOCUMENT_ROOT . "/Listar/usuario");
		die();
	}

	public function turno(){
		$id = $_POST['id'];
		try {
			TurnoDAO::delete($id);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		header("Location: " . DOCUMENT_ROOT . "/Listar/turno");
		die();
	}

	public function disciplina(){
		$id = $_POST['id'];
		try {
			DisciplinaDAO::delete($id);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		header("Location: " . DOCUMENT_ROOT . "/Listar/disciplina");
		die();
	}

	public function curso(){
		$id = $_POST['id'];
		try {
			CursoDAO::delete($id);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		header("Location: " . DOCUMENT_ROOT . "/Listar/curso");
		die();
	}

	public function turma(){
		$id = $_POST['id'];
		try {
			TurmaDAO::delete($id);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		header("Location: " . DOCUMENT_ROOT . "/Listar/turma");
		die();
	}
}