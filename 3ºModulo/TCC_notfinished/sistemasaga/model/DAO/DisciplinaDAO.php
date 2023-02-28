<?php

class DisciplinaDAO extends DAO{

	public static function select() {
			// Query
		$sql = "SELECT cd_disciplina, 
				nm_disciplina, ds_disciplina, 
				qt_carga_horaria 
				FROM tb_disciplina";
		$consulta = parent::conexao()->query($sql);
		$disciplinas = [];
			 // Criando Objetos
		while ($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {

			$disciplinas[] = DisciplinaFactory::DAO($linha);
		}
		return $disciplinas;
	}

	public static function insert(DisciplinaDTO $disciplina) {

		$sql = "INSERT INTO tb_disciplina (cd_disciplina, 
				nm_disciplina, ds_disciplina, 
				qt_carga_horaria) 
				SELECT coalesce(max(cd_disciplina),0)+1, 
				:nm_disciplina, :ds_disciplina, 
				:qt_carga_horaria 
				FROM tb_disciplina";

		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':nm_disciplina', $disciplina->getNome());
		$statement->bindValue(':ds_disciplina', $disciplina->getDescricao());
		$statement->bindValue(':qt_carga_horaria', $disciplina->getCargaHoraria());
		$statement->execute();
	}

	public static function update(DisciplinaDTO $disciplina) {

		$sql = "UPDATE tb_disciplina SET 
				nm_disciplina = :nm_disciplina, 
				ds_disciplina = :ds_disciplina, 
				qt_carga_horaria = :qt_carga_horaria 
				WHERE cd_disciplina = :cd_disciplina";

		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':cd_disciplina', $disciplina->getId());
		$statement->bindValue(':nm_disciplina', $disciplina->getNome());
		$statement->bindValue(':ds_disciplina', $disciplina->getDescricao());
		$statement->bindValue(':qt_carga_horaria', $disciplina->getCargaHoraria());
		$statement->execute();		
	}

	public static function delete($id){
		$sql = "DELETE FROM tb_disciplina
				WHERE cd_disciplina = :cd_disciplina";
		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':cd_disciplina', $id);
		$statement->execute();
	}

	public static function search($id) {
		$sql = "SELECT cd_disciplina, 
				nm_disciplina, ds_disciplina, 
				qt_carga_horaria 
				FROM tb_disciplina 
				WHERE cd_disciplina = :id";

		$consulta = parent::conexao()->prepare( $sql );
		$consulta->bindValue( ':id' , $id);
		$consulta->execute();

		if($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {
			$disciplina = DisciplinaFactory::DAO($linha);
		} else {
			$disciplina = new DisciplinaDTO();
		}
		return $disciplina;
	}

	public static function searchCurso($id) {
		$sql = "SELECT d.cd_disciplina, 
				nm_disciplina, ds_disciplina, 
				qt_carga_horaria 
				FROM tb_disciplina AS d
				INNER JOIN tb_item_curso AS c
				ON c.cd_disciplina = d.cd_disciplina
				WHERE c.cd_curso = :id";

		$consulta = parent::conexao()->prepare( $sql );
		$consulta->bindValue( ':id' , $id);
		$consulta->execute();

		$disciplinas = [];
			 // Criando Objetos
		while ($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {

			$disciplinas[] = DisciplinaFactory::DAO($linha);
		}
		return $disciplinas;
	}
}