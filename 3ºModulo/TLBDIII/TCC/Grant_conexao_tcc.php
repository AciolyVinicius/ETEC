<?php
/*
	DATA ACCESS OBJETO
	- Classe de acesso a camada de dados (banco)
*/
abstract class DAO{

	public static function conexao(){
			//$connector = new PDO(DB_DRIVE.':host='.DB_HOSTNAME.';port='.DB_PORT.';dbname='.DB_DATABASE.';charset=utf8', DB_USERNAME, DB_PASSWORD);
		if ($_SESSION['id'] == 1) {
			$connector = new PDO('mysql:host=localhost;port=3306;dbname=dbsaga;charset=utf8', 'admin', 'sagagrouplovesteachersoftlbd');
		} else {
			$connector = new PDO('mysql:host=localhost;port=3306;dbname=dbsaga;charset=utf8', 'usuario', 'sagagrouplovesteachersoftlbd');
		}
		$connector->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
		return $connector;
	}
}