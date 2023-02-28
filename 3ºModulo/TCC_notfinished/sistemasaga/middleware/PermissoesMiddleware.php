<?php

class PermissoesMiddleware {
	public function __construct($permissao)
	{
		if (!($_SESSION['tipo_id'] >= $permissao))
		{
			header("Location: " . DOCUMENT_ROOT . "/Dashboard/home");
			die();
		}
	}
}