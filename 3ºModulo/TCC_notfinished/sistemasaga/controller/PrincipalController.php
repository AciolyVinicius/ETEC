<?php

class PrincipalController{

	public function index(){

		$page = new IndexView();
		$page->mostrar();
	}

	public function solicitar(){

		$page = new SolicitarView();
		$page->mostrar();
	}
}