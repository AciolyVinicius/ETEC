<?php

class AdicionarController{

	private $controller = "Adicionar";

	public function __construct(){
		new LoginMiddleware();
		new PermissoesMiddleware(5);
	}

	public function usuario(){
		try {
			$tipos = TipoDAO::select();
			$turmas = TurmaDAO::select();
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		$usuario = new UsuarioDTO();
		$page = new UsuarioFormularioView();
		$page->mostrar($usuario, $tipos, $turmas, $this->controller);
	}

	public function usuarios(){
		$pasta = $_POST['email'];
		mkdir(getcwd().'/img/'.$pasta);
		if(strlen($_FILES['foto']['name'])>0){
			$extensao = pathinfo($_FILES['foto']['name'], PATHINFO_EXTENSION);
			if ($extensao == 'jpg' || $extensao == 'png') {
				$_POST['foto'] = '/img/'.$pasta.'/'. "img_perfil.jpg";
				rename($_FILES['foto']['tmp_name'],  getcwd().'/img/'.$pasta.'/'. 'img_perfil.jpg');
			}
		} else {
			copy (getcwd().'/img/perfil.jpg' , getcwd().'/img/'.$pasta.'/img_perfil.jpg');
		}
		$_POST['foto'] = '/img/'.$pasta.'/'. "img_perfil.jpg";
		
		$usuario = UsuarioFactory::prog($_POST);

		try {
			UsuarioDAO::insert($usuario);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		header("Location: " . DOCUMENT_ROOT . "/Listar/usuario");
		die();
	}

	public function turno(){
		$turno = new TurnoDTO();

		$page = new TurnoFormularioView();
		$page->mostrar($turno, $this->controller);
	}

	public function turnos(){

		$turno = TurnoFactory::prog($_POST);

		try {
			TurnoDAO::insert($turno);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		header("Location: " . DOCUMENT_ROOT . "/Listar/turno");
		die();
	}

	public function disciplina(){
		$disciplina = new DisciplinaDTO();

		$page = new DisciplinaFormularioView();
		$page->mostrar($disciplina, $this->controller);
	}

	public function disciplinas(){

		$disciplina = DisciplinaFactory::prog($_POST);

		try {
			DisciplinaDAO::insert($disciplina);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		header("Location: " . DOCUMENT_ROOT . "/Listar/disciplina");
		die();
	}

	public function curso(){
		$curso = new CursoDTO();
		try {
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
			CursoDAO::insert($curso);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		header("Location: " . DOCUMENT_ROOT . "/Listar/curso");
		die();
	}

	public function turma(){
		$turma = new TurmaDTO();

		try {
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
			TurmaDAO::insert($turma);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		header("Location: " . DOCUMENT_ROOT . "/Listar/turma");
		die();
	}
}