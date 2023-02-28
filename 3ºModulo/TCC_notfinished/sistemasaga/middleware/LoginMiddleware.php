<?php

class LoginMiddleware {
	public function __construct()
	{
		$usuario = UsuarioDAO::search($_SESSION['id']);
		if ($usuario->getId() > 0)
		{
			$_SESSION['nome'] = $usuario->getNome();
			$_SESSION['email'] = $usuario->getEmail();
			$_SESSION['foto'] = $usuario->getFoto();
			$_SESSION['tipo_nome'] = $usuario->getTipo()->getNome();
			$_SESSION['tipo_id'] = $usuario->getTipo()->getId();
		} else {
			session_destroy();
			header("Location: " . DOCUMENT_ROOT . "/Login/principal");
			die();
		}
	}
}