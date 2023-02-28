<?php

class UsuarioFactory {
	public static function DAO($params)
	{
		$usuario = new UsuarioDTO();
		if (isset($params['cd_usuario'])) {
			$usuario->setId($params['cd_usuario']);
		}

		$usuario->setNome($params['nm_usuario']);
		$usuario->setSobrenome($params['nm_sobrenome']);
		$usuario->setNascimento($params['dt_nascimento']);
		$usuario->setEmail($params['nm_email']);
		$usuario->setFoto($params['im_foto']);
		$usuario->setCpf($params['cd_cpf']);
		$usuario->setRg($params['cd_rg']);
		$usuario->setContato1($params['cd_contato1']);
		$usuario->setContato2($params['cd_contato2']);
		$usuario->setCep($params['cd_cep']);
		$usuario->setRua($params['nm_rua']);
		$usuario->setNumeracao($params['cd_numeracao']);
		$usuario->setBairro($params['nm_bairro']);
		$usuario->setCidade($params['nm_cidade']);
		$usuario->setEstado($params['nm_estado']);
		$usuario->setNomeResponsavel($params['nm_responsavel']);
		$usuario->setContatoResponsavel($params['cd_contato_responsavel']);
		$usuario->setEmailResponsavel($params['nm_email_responsavel']);
		$usuario->setCpfResponsavel($params['cd_cpf_responsavel']);

		$tipo = TipoDAO::search($params['cd_tipo']);
		$usuario->setTipo($tipo);

		$turma = TurmaDAO::search($params['cd_turma']);
		$usuario->setTurma($turma);

		return $usuario;
	}

	public static function prog($params)
	{
		$usuario = new UsuarioDTO();
		if (isset($params['id'])) {
			$usuario->setId($params['id']);
		}

		$usuario->setNome($params['nome']);
		$usuario->setSobrenome($params['sobrenome']);
		$usuario->setNascimento($params['nascimento']);
		$usuario->setEmail($params['email']);
		$usuario->setFoto($params['foto']);
		$usuario->setCpf($params['cpf']);
		$usuario->setRg($params['rg']);
		$usuario->setContato1($params['contato1']);
		$usuario->setContato2($params['contato2']);
		$usuario->setCep($params['cep']);
		$usuario->setRua($params['rua']);
		$usuario->setNumeracao($params['numeracao']);
		$usuario->setBairro($params['bairro']);
		$usuario->setCidade($params['cidade']);
		$usuario->setEstado($params['estado']);
		$usuario->setNomeResponsavel($params['nome_responsavel']);
		$usuario->setContatoResponsavel($params['contato_responsavel']);
		$usuario->setEmailResponsavel($params['email_responsavel']);
		$usuario->setCpfResponsavel($params['cpf_responsavel']);

		$tipo = new TipoDTO();
		$tipo->setId($params['tipo']);
		$usuario->setTipo($tipo);

		$turma = new TurmaDTO();
		$turma->setId($params['turma']);
		$usuario->setTurma($turma);

		return $usuario;
	}
}