<?php

class CursoFactory {
	public static function DAO($params)
	{
		$curso = new CursoDTO();
		if (isset($params['cd_curso'])) {
			$curso->setId($params['cd_curso']);
		}
		$curso->setNome($params['nm_curso']);
		$curso->setDescricao($params['ds_curso']);

		$disciplinas = DisciplinaDAO::searchCurso($params['cd_curso']);
		$curso->setDisciplinas($disciplinas);

		return $curso;
	}
	public static function prog($params)
	{
		$curso = new CursoDTO();
		if (isset($params['id'])) {
			$curso->setId($params['id']);
		}
		$curso->setNome($params['nome']);
		$curso->setDescricao($params['descricao']);

		$disciplinas = DisciplinaDAO::select();
		$arrayDisciplinas = [];
		foreach ($disciplinas as $disciplina) {
			if (isset($params['disciplina'.$disciplina->getId()])) {
				$arrayDisciplinas[] = $disciplina;
			}
		}

		$curso->setDisciplinas($arrayDisciplinas);

		return $curso;
	}
}