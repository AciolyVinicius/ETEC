<?php

require_once "view/disciplina/Disciplina1View.php";
require_once "view/disciplina/Disciplina2View.php";

class DisciplinaController{

	public function __construct(){
		new LoginMiddleware();
	}

	public function disciplina1(){

		$page = new Disciplina1View();
		$page->mostrar();
	}

	public function disciplina2(){

		$page = new Disciplina2View();
		$page->mostrar();
	}
}