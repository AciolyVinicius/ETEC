<?php

class LoginDAO extends DAO{

	public static function select(){}
	public static function insert($obj){}
	public static function update($obj){}
	public static function delete($obj){}

	public static function search(LoginDTO $login) {
		// Query
		$sql = "SELECT cd_usuario, 
				cd_senha 
				FROM tb_usuario 
				WHERE nm_email = :email";
		$consulta = parent::conexao()->prepare( $sql );
		$consulta->bindValue( ':email' , $login->getEmail());
		$consulta->execute();

		$usuario = new UsuarioDTO();
		if($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {
			$usuario->setId($linha['cd_usuario']);
			$usuario->setSenha($linha['cd_senha']);
		}

		return $usuario;
	}
}