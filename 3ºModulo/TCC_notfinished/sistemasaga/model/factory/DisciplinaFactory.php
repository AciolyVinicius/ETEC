<?php

class DisciplinaFactory {
	public static function DAO($params)
	{
		$disciplina = new DisciplinaDTO();
		if (isset($params['cd_disciplina'])) {
			$disciplina->setId($params['cd_disciplina']);
		}
		$disciplina->setNome($params['nm_disciplina']);
		$disciplina->setDescricao($params['ds_disciplina']);
		$disciplina->setCargaHoraria($params['qt_carga_horaria']);
		return $disciplina;
	}
	public static function prog($params)
	{
		$disciplina = new DisciplinaDTO();
		if (isset($params['id'])) {
			$disciplina->setId($params['id']);
		}
		$disciplina->setNome($params["nome"]);
		$disciplina->setDescricao($params["descricao"]);
		$disciplina->setCargaHoraria($params["carga_horaria"]);

		return $disciplina;
	}
}