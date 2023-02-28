<?php
spl_autoload_register('carregarClasse');

function carregarClasse($nomeClasse) {
	if (file_exists("model/DAO/".$nomeClasse.".php")) {
		require_once "model/DAO/".$nomeClasse.".php";

	} else if (file_exists("model/DTO/".$nomeClasse.".php")) {
		require_once "model/DTO/".$nomeClasse.".php";

	} else if (file_exists("model/factory/".$nomeClasse.".php")) {
		require_once "model/factory/".$nomeClasse.".php";

	} else if (file_exists("middleware/".$nomeClasse.".php")) {
		require_once "middleware/".$nomeClasse.".php";

	} else if (file_exists("controller/".$nomeClasse.".php")) {
		require_once "controller/".$nomeClasse.".php";

	} else if (file_exists("error/".$nomeClasse.".php")) {
		require_once "error/".$nomeClasse.".php";

	} else if (file_exists("view/".$nomeClasse.".php")) {
		require_once "view/".$nomeClasse.".php";

	} else if (file_exists("view/dashboard/".$nomeClasse.".php")) {
		require_once "view/dashboard/".$nomeClasse.".php";
		
	} else if (file_exists("view/listar/".$nomeClasse.".php")) {
		require_once "view/listar/".$nomeClasse.".php";

	} else if (file_exists("view/detalhar/".$nomeClasse.".php")) {
		require_once "view/detalhar/".$nomeClasse.".php";
		
	} else if (file_exists("view/formulario/".$nomeClasse.".php")) {
		require_once "view/formulario/".$nomeClasse.".php";

	}
}