<?php

class TurnoDAO extends DAO{

	public static function select() {
			// Query
		$sql = "SELECT cd_turno, 
				nm_turno, ds_turno, 
				hr_inicio, hr_final 
				FROM tb_turno";

		$consulta = parent::conexao()->query($sql);
		$turnos = [];
			 // Criando Objetos
		while ($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {

			$turnos[] = TurnoFactory::DAO($linha);
		}
		return $turnos;
	}

	public static function insert(TurnoDTO $turno) {

		$sql = "INSERT INTO tb_turno (cd_turno, 
				nm_turno, ds_turno, 
				hr_inicio, hr_final) 
				SELECT coalesce(max(cd_turno),0)+1, 
				:nm_turno, :ds_turno, 
				:hr_inicio, :hr_final 
				FROM tb_turno";

		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':nm_turno', $turno->getNome());
		$statement->bindValue(':ds_turno', $turno->getDescricao());
		$statement->bindValue(':hr_inicio', $turno->getHoraInicio());
		$statement->bindValue(':hr_final', $turno->getHoraFinal());
		$statement->execute();
	}

	public static function update(TurnoDTO $turno) {

		$sql = "UPDATE tb_turno SET 
				nm_turno = :nm_turno, 
				ds_turno = :ds_turno, 
				hr_inicio = :hr_inicio, 
				hr_final = :hr_final 
				WHERE cd_turno = :cd_turno";

		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':cd_turno', $turno->getId());
		$statement->bindValue(':nm_turno', $turno->getNome());
		$statement->bindValue(':ds_turno', $turno->getDescricao());
		$statement->bindValue(':hr_inicio', $turno->getHoraInicio());
		$statement->bindValue(':hr_final', $turno->getHoraFinal());
		$statement->execute();
	}

	public static function delete($id){
		$sql = "DELETE FROM tb_turno
				WHERE cd_turno = :cd_turno";
		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':cd_turno', $id);
		$statement->execute();
	}

	public static function search($id){

		$sql = "SELECT cd_turno, 
				nm_turno, ds_turno, 
				hr_inicio, hr_final 
				FROM tb_turno 
				WHERE cd_turno = :id";

		$consulta = parent::conexao()->prepare( $sql );
		$consulta->bindValue( ':id' , $id);
		$consulta->execute();

		if($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {
			$turno = TurnoFactory::DAO($linha);
		} else {
			$turno = new TurnoDTO();
		}
		return $turno;
	}
}