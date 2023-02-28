<?php

class AvisoDAO extends DAO{

	public static function select() {
			// Query
		$sql = "SELECT cd_aviso, 
				nm_aviso, ds_aviso, 
				im_anexo, cd_curso, 
				cd_turma, cd_usuario 
				FROM tb_aviso";
				
		$consulta = parent::conexao()->query($sql);
		$avisos = [];
			 // Criando Objetos
		while ($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {
			$avisos[] = AvisoFactory::DAO($linha);
		}
		return $avisos;
	}

	public static function insert(AvisoDTO $aviso) {

		$usuario = UsuarioDAO::search($_SESSION['id']);

		$sql = "INSERT INTO tb_aviso (cd_aviso, 
				nm_aviso, ds_aviso, 
				im_anexo, cd_curso, 
				cd_turma, cd_usuario)
				SELECT coalesce(max(cd_aviso),0)+1, 
				:nm_aviso, :ds_aviso, 
				:im_anexo, :cd_curso, 
				:cd_turma, :cd_usuario 
				FROM tb_aviso";

		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':nm_aviso', $aviso->getNome());
		$statement->bindValue(':ds_aviso', $aviso->getDescricao());
		$statement->bindValue(':im_anexo', $aviso->getAnexo());
		if ($_SESSION['tipo_id'] == 2) {
			$statement->bindValue(':cd_turma', $usuario->getTurma()->getId());
		} else {
			$statement->bindValue(':cd_turma', null);
		}
		if ($_SESSION['tipo_id'] == 4) {
			$statement->bindValue(':cd_curso', $usuario->getTurma()->getCurso()->getId());
		} else {
			$statement->bindValue(':cd_curso', null);
		}
		$statement->bindValue(':cd_usuario', $_SESSION['id']);
		$statement->execute();
	}

	public static function update(AvisoDTO $aviso) {
		$sql = "UPDATE tb_aviso SET 
				nm_aviso = :nm_aviso, 
				ds_aviso = :ds_aviso, 
				im_anexo = :im_anexo, 
				cd_curso = :cd_curso, 
				cd_turma = :cd_turma, 
				cd_usuario = :cd_usuario 
				WHERE cd_aviso = :cd_aviso";

		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':cd_aviso', $aviso->getId());
		$statement->bindValue(':nm_aviso', $aviso->getNome());
		$statement->bindValue(':ds_aviso', $aviso->getDescricao());
		$statement->bindValue(':im_anexo', $aviso->getAnexo());
		$statement->bindValue(':cd_curso', $aviso->getCurso()->getId());
		$statement->bindValue(':cd_turma', $aviso->getTurma()->getId());
		$statement->bindValue(':cd_usuario', $aviso->getUsuario()->getId());
		$statement->execute();
	}

	public static function delete($id){		
		$sql = "DELETE FROM tb_aviso
				WHERE cd_aviso = :cd_aviso";
		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':cd_aviso', $id);
		$statement->execute();
	}

	public static function search($id) {
		$sql = "SELECT cd_aviso, 
				nm_aviso, ds_aviso, 
				im_anexo, cd_curso, 
				cd_turma, cd_usuario  
				FROM tb_aviso 
				WHERE cd_aviso = :id";
		$consulta = parent::conexao()->prepare( $sql );
		$consulta->bindValue( ':id' , $id);
		$consulta->execute();

		if($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {
			$aviso = AvisoFactory::DAO($linha);
		} else {
			$aviso = new AvisoDTO();
		}
		return $aviso;
	}
}