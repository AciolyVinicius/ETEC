<?php
/*
	DATA ACCESS OBJETO
	- Classe de acesso a camada de dados (banco)
*/
abstract class DAO{

	public static function conexao(){
		$connector = new PDO(DB_DRIVE.':host='.DB_HOSTNAME.';port='.DB_PORT.';dbname='.DB_DATABASE.';charset=utf8', DB_USERNAME, DB_PASSWORD);
		$connector->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
		return $connector;
	}
}