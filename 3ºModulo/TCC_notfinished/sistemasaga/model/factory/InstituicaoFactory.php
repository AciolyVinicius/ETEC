<?php

class InstituicaoFactory {
	public static function DAO($params)
	{
		$instituicao = new InstituicaoDTO();
		$instituicao->setNome($params['nm_instituicao']);
		$instituicao->setFantasia($params['nm_fantasia']);
		$instituicao->setCnpj($params['cd_cnpj']);
		$instituicao->setContato1($params['cd_contato1']);
		$instituicao->setContato2($params['cd_contato2']);
		$instituicao->setEmail($params['nm_email']);
		$instituicao->setRua($params['nm_rua']);
		$instituicao->setNumeracao($params['cd_numeracao']);
		$instituicao->setBairro($params['nm_bairro']);
		$instituicao->setCidade($params['nm_cidade']);
		$instituicao->setEstado($params['nm_estado']);
		$instituicao->setCep($params['cd_cep']);
		$instituicao->setMec($params['cd_mec']);
		$instituicao->setAlvara($params['cd_alvara']);

		return $instituicao;
	}
	public static function prog($params)
	{
		$instituicao = new InstituicaoDTO();
		$instituicao->setNome($params["nome"]);
		$instituicao->setFantasia($params["nome_fantasia"]);
		$instituicao->setCnpj($params["cnpj"]);
		$instituicao->setContato1($params["contato1"]);
		$instituicao->setContato2($params["contato2"]);
		$instituicao->setEmail($params["email"]);
		$instituicao->setCep($params["cep"]);
		$instituicao->setRua($params["rua"]);
		$instituicao->setNumeracao($params["numeracao"]);
		$instituicao->setBairro($params["bairro"]);
		$instituicao->setCidade($params["cidade"]);
		$instituicao->setEstado($params["estado"]);
		$instituicao->setMec($params["mec"]);
		$instituicao->setAlvara($params["alvara"]);

		return $instituicao;
	}
}