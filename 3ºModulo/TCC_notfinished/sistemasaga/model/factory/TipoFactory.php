<?php

class TipoFactory {
	public static function DAO($params)
	{
		$tipo = new TipoDTO();
		if (isset($params['cd_tipo'])) {
			$tipo->setId($params['cd_tipo']);
		}
		$tipo->setNome($params['nm_tipo']);

		return $tipo;
	}
	public static function prog($params)
	{
		$tipo = new TipoDTO();
		if (isset($params['id'])) {
			$tipo->setId($params['id']);
		}
		$tipo->setNome($params['nome']);

		return $tipo;
	}
}