<?php

class LoggedMiddleware {

	public function __construct()
	{
		if (isset($_SESSION['login']))
		{
			header("Location: " . DOCUMENT_ROOT . "/Dashboard/home");
			die();
		}
	}
}