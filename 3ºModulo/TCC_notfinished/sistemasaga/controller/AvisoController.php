<?php

class AvisoController{

	public function __construct(){
		if (!($_SESSION['tipo_id'] == 2 || $_SESSION['tipo_id'] >= 4)) {
			new PermissoesMiddleware(4);
		}
	}

	public function Adicionar(){

		$aviso = AvisoFactory::prog($_POST);

		try {
			AvisoDAO::insert($aviso);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		header("Location: " . DOCUMENT_ROOT . "/Dashboard/home");
		die();
	}

	public function Editar(){

		$page = new IndexView();
		$page->mostrar();
	}

	public function Deletar(){

		$page = new IndexView();
		$page->mostrar();
	}
}