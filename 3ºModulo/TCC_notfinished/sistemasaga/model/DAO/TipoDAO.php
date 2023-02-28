<?php

class TipoDAO extends DAO{

	public static function select() {
			// Query
		$sql = "SELECT cd_tipo, 
				nm_tipo 
				FROM tb_tipo";
				
		$consulta = parent::conexao()->query($sql);
		$tipos = [];
			 // Criando Objetos
		while ($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {
			$tipos[] = TipoFactory::DAO($linha);
		}
		return $tipos;
	}

	public static function search($id) {
		$sql = "SELECT cd_tipo, 
				nm_tipo 
				FROM tb_tipo 
				WHERE cd_tipo = :id";
		$consulta = parent::conexao()->prepare( $sql );
		$consulta->bindValue( ':id' , $id);
		$consulta->execute();

		if($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {
			$tipo = TipoFactory::DAO($linha);
		} else {
			$tipo = new TipoDTO();
		}
		return $tipo;
	}
}