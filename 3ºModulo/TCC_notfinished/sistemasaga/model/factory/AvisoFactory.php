<?php

class AvisoFactory {
	public static function DAO($params)
	{
		$aviso = new AvisoDTO();
		if (isset($params['cd_aviso'])) {
			$aviso->setId($params['cd_aviso']);
		}
		$aviso->setNome($params['nm_aviso']);
		$aviso->setDescricao($params['ds_aviso']);
		$aviso->setAnexo($params['im_anexo']);

		$curso = CursoDAO::search($params['cd_curso']);
		$aviso->setCurso($curso);

		$turma = TurmaDAO::search($params['cd_turma']);
		$aviso->setTurma($turma);

		$usuario = UsuarioDAO::search($params['cd_usuario']);
		$aviso->setUsuario($usuario);

		return $aviso;
	}
	public static function prog($params)
	{
		$aviso = new AvisoDTO();
		if (isset($params['id'])) {
			$aviso->setId($params['id']);
		}

		$aviso->setNome($params['nome']);
		$aviso->setDescricao($params['descricao']);
		$aviso->setAnexo($params['anexo']);

		$curso = new CursoDTO();
		$curso->setId($params["curso"]);
		$aviso->setCurso($curso);

		$turma = new TurmaDTO();
		$turma->setId($params["turma"]);
		$aviso->setTurma($turma);

		$usuario = new UsuarioDTO();
		$usuario->setId($params["usuario"]);
		$aviso->setUsuario($usuario);

		return $aviso;
	}
}