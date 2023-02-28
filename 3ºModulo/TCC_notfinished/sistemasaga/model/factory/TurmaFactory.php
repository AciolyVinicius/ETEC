<?php

class TurmaFactory {
	public static function DAO($params)
	{
		$turma = new TurmaDTO();
		if (isset($params['cd_turma'])) {
			$turma->setId($params['cd_turma']);
		}
		$turma->setNome($params['nm_turma']);
		$turma->setDescricao($params['ds_turma']);
		$turma->setCapacidade($params['qt_capacidade']);
		$turma->setDataInicio($params['dt_inicio']);
		$turma->setDataFinal($params['dt_final']);

		$turno = TurnoDAO::search($params['cd_turno']);
		$turma->setTurno($turno);

		$curso = CursoDAO::search($params['cd_curso']);
		$turma->setCurso($curso);

		return $turma;
	}
	public static function prog($params)
	{
		$turma = new TurmaDTO();
		if (isset($params['id'])) {
			$turma->setId($params['id']);
		}

		$turma->setNome($params['nome']);
		$turma->setDescricao($params['descricao']);
		$turma->setCapacidade($params['capacidade']);
		$turma->setDataInicio($params['data_inicio']);
		$turma->setDataFinal($params['data_final']);

		$curso = new CursoDTO();
		$curso->setId($params["curso"]);
		$turma->setCurso($curso);

		$turno = new TurnoDTO();
		$turno->setId($params["turno"]);
		$turma->setTurno($turno);

		return $turma;
	}
}