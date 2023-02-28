<?php

class EditarController{

	private $controller = "Editar";

	public function __construct(){
		new LoginMiddleware();
		new PermissoesMiddleware(5);
	}

	public function instituicao(){
		try{
			$instituicao = InstituicaoDAO::search();
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$page = new InstituicaoFormularioView();
		$page->mostrar($instituicao, $this->controller);
	}

	public function instituicoes(){

		$instituicao = InstituicaoFactory::prog($_POST);

		try {
			InstituicaoDAO::update($instituicao);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		header("Location: " . DOCUMENT_ROOT . "/Detalhar/instituicao");
		die();
	}

	public function usuario(){
		$id = $_GET['id'];

		try {
			$usuario = UsuarioDAO::search($id);
			$tipos = TipoDAO::select();
			$turmas = TurmaDAO::select();
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$page = new UsuarioFormularioView();
		$page->mostrar($usuario, $tipos, $turmas, $this->controller);
	}

	public function usuarios(){

		$pasta = $_POST['email'];
		if(strlen($_FILES['foto']['name'])>0){
			$extensao = pathinfo($_FILES['foto']['name'], PATHINFO_EXTENSION);
			if ($extensao == 'jpg' || $extensao == 'png') {
				rename($_FILES['foto']['tmp_name'],  getcwd().'/img/'.$pasta.'/'. 'img_perfil.jpg');
			}
		}

		$usuario = UsuarioFactory::prog($_POST);

		try {
			UsuarioDAO::update($usuario);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		header("Location: " . DOCUMENT_ROOT . "/Listar/usuario");
		die();
	}

	public function turno(){
		$id = $_GET['id'];

		try {
			$turno = TurnoDAO::search($id);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$page = new TurnoFormularioView();
		$page->mostrar($turno, $this->controller);
	}

	public function turnos(){
		$turno = TurnoFactory::prog($_POST);

		try {
			TurnoDAO::update($turno);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		header("Location: " . DOCUMENT_ROOT . "/Listar/turno");
		die();
	}

	public function disciplina(){
		$id = $_GET['id'];

		try {
			$disciplina = DisciplinaDAO::search($id);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$page = new DisciplinaFormularioView();
		$page->mostrar($disciplina, $this->controller);
	}

	public function disciplinas(){
		$disciplina = DisciplinaFactory::prog($_POST);

		try {
			DisciplinaDAO::update($disciplina);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		header("Location: " . DOCUMENT_ROOT . "/Listar/disciplina");
		die();
	}

	public function curso(){
		$id = $_GET['id'];

		try {
			$curso = CursoDAO::search($id);
			$disciplinas = DisciplinaDAO::select();
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$page = new CursoFormularioView();
		$page->mostrar($curso, $disciplinas, $this->controller);
	}

	public function cursos(){
		$curso = CursoFactory::prog($_POST);

		try {
			CursoDAO::update($curso);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		header("Location: " . DOCUMENT_ROOT . "/Listar/curso");
		die();
	}

	public function turma(){
		$id = $_GET['id'];

		try {
			$turma = TurmaDAO::search($id);
			$cursos = CursoDAO::select();
			$turnos = TurnoDAO::select();
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$page = new TurmaFormularioView();
		$page->mostrar($turma, $cursos, $turnos, $this->controller);
	}

	public function turmas(){
		$turma = TurmaFactory::prog($_POST);

		try {
			TurmaDAO::update($turma);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		header("Location: " . DOCUMENT_ROOT . "/Listar/turma");
		die();
	}
}