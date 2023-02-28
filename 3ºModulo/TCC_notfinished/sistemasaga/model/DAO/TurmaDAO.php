<?php

class TurmaDAO extends DAO{

	public static function select() {
			// Query
		$sql = "SELECT cd_turma, 
				nm_turma, ds_turma, 
				qt_capacidade, dt_inicio, 
				dt_final, cd_turno, 
				cd_curso 
				FROM tb_turma";

		$consulta = parent::conexao()->query($sql);
		$turmas = [];
			 // Criando Objetos
		while ($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {

			$turmas[] = TurmaFactory::DAO($linha);
		}
		return $turmas;
	}

	public static function insert(TurmaDTO $turma) {

		$sql = "INSERT INTO tb_turma (cd_turma, 
				nm_turma, ds_turma, 
				qt_capacidade, dt_inicio, 
				dt_final, cd_turno, 
				cd_curso) 
				SELECT coalesce(max(cd_turma),0)+1, 
				:nm_turma, :ds_turma, 
				:qt_capacidade, :dt_inicio, 
				:dt_final, :cd_turno, 
				:cd_curso 
				FROM tb_turma";

		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':nm_turma', $turma->getNome());
		$statement->bindValue(':ds_turma', $turma->getDescricao());
		$statement->bindValue(':qt_capacidade', $turma->getCapacidade());
		$statement->bindValue(':dt_inicio', $turma->getDataInicio());
		$statement->bindValue(':dt_final', $turma->getDataFinal());
		$statement->bindValue(':cd_turno', $turma->getTurno()->getId());
		$statement->bindValue(':cd_curso', $turma->getCurso()->getId());
		$statement->execute();
	}

	public static function update(TurmaDTO $turma) {

		$sql = "UPDATE tb_turma SET 
				nm_turma = :nm_turma, 
				ds_turma = :ds_turma, 
				qt_capacidade = :qt_capacidade, 
				dt_inicio = :dt_inicio, 
				dt_final = :dt_final, 
				cd_turno = :cd_turno, 
				cd_curso = :cd_curso 
				WHERE cd_turma = :cd_turma";

		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':cd_turma', $turma->getId());
		$statement->bindValue(':nm_turma', $turma->getNome());
		$statement->bindValue(':ds_turma', $turma->getDescricao());
		$statement->bindValue(':qt_capacidade', $turma->getCapacidade());
		$statement->bindValue(':dt_inicio', $turma->getDataInicio());
		$statement->bindValue(':dt_final', $turma->getDataFinal());
		$statement->bindValue(':cd_turno', $turma->getTurno()->getId());
		$statement->bindValue(':cd_curso', $turma->getCurso()->getId());
		$statement->execute();
	}

	public static function delete($id){
		$sql = "DELETE FROM tb_turma
				WHERE cd_turma = :cd_turma";
		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':cd_turma', $id);
		$statement->execute();
	}

	public static function search($id){

		$sql = "SELECT cd_turma, 
				nm_turma, ds_turma, 
				qt_capacidade, dt_inicio, 
				dt_final, cd_turno, 
				cd_curso 
				FROM tb_turma 
				WHERE cd_turma = :id";

		$consulta = parent::conexao()->prepare( $sql );
		$consulta->bindValue( ':id' , $id);
		$consulta->execute();

		if($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {
			$turma = TurmaFactory::DAO($linha);
		} else {
			$turma = new TurmaDTO();
		}
		return $turma;
	}
}