<?php

class InstituicaoDAO extends DAO{

	public static function select() {}

	public static function insert(InstituicaoDTO $instituicao){}

	public static function update(InstituicaoDTO $instituicao){

		$sql = "UPDATE tb_instituicao SET 
				nm_instituicao = :nm_instituicao, 
				nm_fantasia = :nm_fantasia, 
				cd_cnpj = :cd_cnpj, 
				cd_contato1 = :cd_contato1, 
				cd_contato2 = :cd_contato2, 
				nm_email = :nm_email, 
				nm_rua = :nm_rua, 
				cd_numeracao = :cd_numeracao, 
				nm_bairro = :nm_bairro, 
				nm_cidade = :nm_cidade, 
				nm_estado = :nm_estado, 
				cd_cep = :cd_cep, 
				cd_mec = :cd_mec, 
				cd_alvara = :cd_alvara 
				WHERE cd_instituicao = 1";

		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':nm_instituicao', $instituicao->getNome());
		$statement->bindValue(':nm_fantasia', $instituicao->getFantasia());
		$statement->bindValue(':cd_cnpj', $instituicao->getCnpj());
		$statement->bindValue(':cd_contato1', $instituicao->getContato1());
		$statement->bindValue(':cd_contato2', $instituicao->getContato2());
		$statement->bindValue(':nm_email', $instituicao->getEmail());
		$statement->bindValue(':nm_rua', $instituicao->getRua());
		$statement->bindValue(':cd_numeracao', $instituicao->getNumeracao());
		$statement->bindValue(':nm_bairro', $instituicao->getBairro());
		$statement->bindValue(':nm_cidade', $instituicao->getCidade());
		$statement->bindValue(':nm_estado', $instituicao->getEstado());
		$statement->bindValue(':cd_cep', $instituicao->getCep());
		$statement->bindValue(':cd_mec', $instituicao->getMec());
		$statement->bindValue(':cd_alvara', $instituicao->getAlvara());
		$statement->execute();
	}

	public static function delete($id){}

	public static function search(){

		$sql = "SELECT cd_instituicao, 
				nm_instituicao, nm_fantasia, 
				cd_cnpj, cd_contato1, 
				cd_contato2, nm_email, 
				nm_rua, cd_numeracao, 
				nm_bairro, nm_cidade, 
				nm_estado, cd_cep, 
				cd_mec, cd_alvara 
				FROM tb_instituicao 
				WHERE cd_instituicao = 1";

		$consulta = parent::conexao()->prepare( $sql );
		$consulta->execute();

		if($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {
			$instituicao = InstituicaoFactory::DAO($linha);
		} else {
			$instituicao = new InstituicaoDTO();
		}

		return $instituicao;
	}
}