<?php

class LoginController{

	public function __construct() {
		new LoggedMiddleware();
	}

	public function principal(){
		$page = new LoginView();
		$page->mostrar();
	}

	public function login(){
		$email = $_POST['email'];
		$senha = $_POST['senha'];

		$login = new LoginDTO($email, $senha);

		try{
			$usuario = LoginDAO::search($login);
		} catch(Exception $e){
			TryCatchError::erro($e);
		}

		if(password_verify($login->getSenha(), $usuario->getSenha())){
			$_SESSION['id'] = $usuario->getId();
			$_SESSION['login'] = true;
			header("Location: " . DOCUMENT_ROOT . "/Dashboard/home");
		}else{
			$_SESSION['password'] = false;
			header("Location: " . DOCUMENT_ROOT . "/Login/principal");
		}
		die();
	}
}