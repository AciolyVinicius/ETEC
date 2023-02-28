<?php

class TurnoFactory {
	public static function DAO($params)
	{
		$turno = new TurnoDTO();
		if (isset($params['cd_turno'])) {
			$turno->setId($params['cd_turno']);
		}
		$turno->setNome($params['nm_turno']);
		$turno->setDescricao($params['ds_turno']);
		$turno->setHoraInicio($params['hr_inicio']);
		$turno->setHoraFinal($params['hr_final']);

		return $turno;
	}
	public static function prog($params)
	{
		$turno = new TurnoDTO();
		if (isset($params['id'])) {
			$turno->setId($params['id']);
		}

		$turno->setNome($params['nome']);
		$turno->setDescricao($params['descricao']);
		$turno->setHoraInicio($params['hora_inicio']);
		$turno->setHoraFinal($params['hora_final']);

		return $turno;
	}
}