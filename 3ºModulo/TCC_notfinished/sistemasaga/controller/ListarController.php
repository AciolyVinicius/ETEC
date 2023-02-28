<?php

class ListarController{

	public function __construct(){
		new LoginMiddleware();
		new PermissoesMiddleware(5);
	}

	public function usuario(){
		try{
			$usuarios = UsuarioDAO::select();
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$page = new UsuarioListarView();
		$page->mostrar($usuarios);
	}

	public function curso(){
		try{
			$cursos = CursoDAO::select();
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$page = new CursoListarView();
		$page->mostrar($cursos);
	}

	public function disciplina(){
		try{
			$disciplinas = DisciplinaDAO::select();
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$page = new DisciplinaListarView();
		$page->mostrar($disciplinas);
	}

	public function turno(){
		try{
			$turnos = TurnoDAO::select();
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$page = new TurnoListarView();
		$page->mostrar($turnos);
	}

	public function turma(){
		try{
			$turmas = TurmaDAO::select();
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$page = new TurmaListarView();
		$page->mostrar($turmas);
	}
}