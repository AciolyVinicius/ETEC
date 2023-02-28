<?php

class CursoDAO extends DAO{

	public static function select() {
			// Query
		$sql = "SELECT cd_curso, 
				nm_curso, ds_curso 
				FROM tb_curso";
				
		$consulta = parent::conexao()->query($sql);
		$cursos = [];
			 // Criando Objetos
		while ($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {
			$cursos[] = CursoFactory::DAO($linha);
		}
		return $cursos;
	}

	public static function insert(CursoDTO $curso) {

		$sql = "INSERT INTO tb_curso (cd_curso, 
				nm_curso, ds_curso)
				SELECT coalesce(max(cd_curso),0)+1, 
				:nm_curso, :ds_curso 
				FROM tb_curso";

		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':nm_curso', $curso->getNome());
		$statement->bindValue(':ds_curso', $curso->getDescricao());
		$statement->execute();


		$sql = "SELECT max(cd_curso) as cd_curso FROM tb_curso";
		$consulta = parent::conexao()->query($sql);

		if($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {
			$cursoId = $linha['cd_curso'];
		}

		$disciplinas = $curso->getDisciplinas();
		foreach ($disciplinas as $disciplina) {
			$sql = "INSERT INTO tb_item_curso (cd_item_curso, 
					cd_curso, cd_disciplina)
					SELECT coalesce(max(cd_item_curso),0)+1, 
					:cd_curso, :cd_disciplina 
					FROM tb_item_curso";

			$statement = parent::conexao()->prepare( $sql );
			$statement->bindValue(':cd_curso', $cursoId);
			$statement->bindValue(':cd_disciplina', $disciplina->getId());
			$statement->execute();
		}
	}

	public static function update(CursoDTO $curso) {
		$sql = "UPDATE tb_curso SET 
				nm_curso = :nm_curso, 
				ds_curso = :ds_curso 
				WHERE cd_curso = :cd_curso";

		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':cd_curso', $curso->getId());
		$statement->bindValue(':nm_curso', $curso->getNome());
		$statement->bindValue(':ds_curso', $curso->getDescricao());
		$statement->execute();

		$sql = "DELETE FROM tb_item_curso
				WHERE cd_curso = :cd_curso";
		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':cd_curso', $curso->getId());
		$statement->execute();

		$disciplinas = $curso->getDisciplinas();
		foreach ($disciplinas as $disciplina) {
			$sql = "INSERT INTO tb_item_curso (cd_item_curso, 
					cd_curso, cd_disciplina)
					SELECT coalesce(max(cd_item_curso),0)+1, 
					:cd_curso, :cd_disciplina 
					FROM tb_item_curso";

			$statement = parent::conexao()->prepare( $sql );
			$statement->bindValue(':cd_curso', $curso->getId());
			$statement->bindValue(':cd_disciplina', $disciplina->getId());
			$statement->execute();
		}
	}

	public static function delete($id){
		$sql = "DELETE FROM tb_item_curso
				WHERE cd_curso = :cd_curso";
		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':cd_curso', $id);
		$statement->execute();
		
		$sql = "DELETE FROM tb_curso
				WHERE cd_curso = :cd_curso";
		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':cd_curso', $id);
		$statement->execute();
	}

	public static function search($id) {
		$sql = "SELECT cd_curso, 
				nm_curso, ds_curso 
				FROM tb_curso 
				WHERE cd_curso = :id";
		$consulta = parent::conexao()->prepare( $sql );
		$consulta->bindValue( ':id' , $id);
		$consulta->execute();

		if($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {
			$curso = CursoFactory::DAO($linha);
		} else {
			$curso = new CursoDTO();
		}
		return $curso;
	}
}