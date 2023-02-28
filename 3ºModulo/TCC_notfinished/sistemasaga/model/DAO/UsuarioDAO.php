<?php

class UsuarioDAO extends DAO{

	public static function select() {
			// Query
		$sql = "SELECT cd_usuario, 
				nm_usuario, nm_sobrenome, 
				dt_nascimento, nm_email, 
				im_foto, cd_cpf, 
				cd_rg, cd_contato1, 
				cd_contato2, cd_cep, 
				nm_rua, cd_numeracao, 
				nm_bairro, nm_cidade, 
				nm_estado, nm_responsavel, 
				cd_contato_responsavel, nm_email_responsavel, 
				cd_cpf_responsavel, cd_tipo, 
				cd_turma 
				FROM tb_usuario";
		$consulta = parent::conexao()->query($sql);
		$usuarios = [];
			 // Criando Objetos
		while ($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {

			$usuarios[] = UsuarioFactory::DAO($linha);
		}
		return $usuarios;
	}

	public static function insert(UsuarioDTO $usuario){
		$sql = "INSERT INTO tb_usuario (cd_usuario, 
				nm_usuario, nm_sobrenome, 
				dt_nascimento, nm_email, 
				im_foto, cd_cpf, 
				cd_rg, cd_senha, 
				cd_contato1, cd_contato2, 
				cd_cep, nm_rua, 
				cd_numeracao, nm_bairro, 
				nm_cidade, nm_estado, 
				nm_responsavel, cd_contato_responsavel, 
				nm_email_responsavel, cd_cpf_responsavel, 
				cd_tipo, cd_turma) 
				SELECT coalesce(max(cd_usuario),0)+1, 
				:nm_usuario, :nm_sobrenome, 
				:dt_nascimento, :nm_email, 
				:im_foto, :cd_cpf, 
				:cd_rg, :cd_senha, 
				:cd_contato1, :cd_contato2, 
				:cd_cep, :nm_rua, 
				:cd_numeracao, :nm_bairro, 
				:nm_cidade, :nm_estado, 
				:nm_responsavel, :cd_contato_responsavel, 
				:nm_email_responsavel, :cd_cpf_responsavel, 
				:cd_tipo, :cd_turma 
				FROM tb_usuario";
		$statement = parent::conexao()->prepare( $sql );

		$statement->bindValue(':nm_usuario', $usuario->getNome());
		$statement->bindValue(':nm_sobrenome', $usuario->getSobrenome());
		$statement->bindValue(':dt_nascimento', $usuario->getNascimento());
		$statement->bindValue(':nm_email', $usuario->getEmail());
		$statement->bindValue(':im_foto', $usuario->getFoto());
		$statement->bindValue(':cd_cpf', $usuario->getCpf());
		$statement->bindValue(':cd_rg', $usuario->getRg());
		$statement->bindValue(':cd_senha', password_hash($usuario->getCpf(), PASSWORD_DEFAULT, ['cost' => 14]));
		$statement->bindValue(':cd_contato1', $usuario->getContato1());
		$statement->bindValue(':cd_contato2', $usuario->getContato2());
		$statement->bindValue(':cd_cep', $usuario->getCep());
		$statement->bindValue(':nm_rua', $usuario->getRua());
		$statement->bindValue(':cd_numeracao', $usuario->getNumeracao());
		$statement->bindValue(':nm_bairro', $usuario->getBairro());
		$statement->bindValue(':nm_cidade', $usuario->getCidade());
		$statement->bindValue(':nm_estado', $usuario->getEstado());
		$statement->bindValue(':nm_responsavel', $usuario->getNomeResponsavel());
		$statement->bindValue(':cd_contato_responsavel', $usuario->getContatoResponsavel());
		$statement->bindValue(':nm_email_responsavel', $usuario->getEmailResponsavel());
		$statement->bindValue(':cd_cpf_responsavel', $usuario->getCpfResponsavel());
		$statement->bindValue(':cd_tipo', $usuario->getTipo()->getId());
		$statement->bindValue(':cd_turma', $usuario->getTurma()->getId());
		$statement->execute();
	}

	public static function update( $usuario){
		$sql = "UPDATE tb_usuario SET 
				nm_usuario = :nm_usuario, 
				nm_sobrenome = :nm_sobrenome, 
				dt_nascimento = :dt_nascimento, 
				nm_email = :nm_email, 
				cd_cpf = :cd_cpf, 
				cd_rg = :cd_rg, 
				cd_contato1 = :cd_contato1, 
				cd_contato2 = :cd_contato2, 
				cd_cep = :cd_cep, 
				nm_rua = :nm_rua, 
				cd_numeracao = :cd_numeracao, 
				nm_bairro = :nm_bairro, 
				nm_cidade = :nm_cidade, 
				nm_estado = :nm_estado, 
				nm_responsavel = :nm_responsavel, 
				cd_contato_responsavel = :cd_contato_responsavel, 
				nm_email_responsavel = :nm_email_responsavel, 
				cd_cpf_responsavel = :cd_cpf_responsavel, 
				cd_tipo = :cd_tipo, 
				cd_turma = :cd_turma 
				WHERE cd_usuario = :cd_usuario";
		$statement = parent::conexao()->prepare( $sql );

		$statement->bindValue(':cd_usuario', $usuario->getId());
		$statement->bindValue(':nm_usuario', $usuario->getNome());
		$statement->bindValue(':nm_sobrenome', $usuario->getSobrenome());
		$statement->bindValue(':dt_nascimento', $usuario->getNascimento());
		$statement->bindValue(':nm_email', $usuario->getEmail());
		$statement->bindValue(':cd_cpf', $usuario->getCpf());
		$statement->bindValue(':cd_rg', $usuario->getRg());
		$statement->bindValue(':cd_contato1', $usuario->getContato1());
		$statement->bindValue(':cd_contato2', $usuario->getContato2());
		$statement->bindValue(':cd_cep', $usuario->getCep());
		$statement->bindValue(':nm_rua', $usuario->getRua());
		$statement->bindValue(':cd_numeracao', $usuario->getNumeracao());
		$statement->bindValue(':nm_bairro', $usuario->getBairro());
		$statement->bindValue(':nm_cidade', $usuario->getCidade());
		$statement->bindValue(':nm_estado', $usuario->getEstado());
		$statement->bindValue(':nm_responsavel', $usuario->getNomeResponsavel());
		$statement->bindValue(':cd_contato_responsavel', $usuario->getContatoResponsavel());
		$statement->bindValue(':nm_email_responsavel', $usuario->getEmailResponsavel());
		$statement->bindValue(':cd_cpf_responsavel', $usuario->getCpfResponsavel());
		$statement->bindValue(':cd_tipo', $usuario->getTipo()->getId());
		$statement->bindValue(':cd_turma', $usuario->getTurma()->getId());
		$statement->execute();
	}

	public static function delete($id){
		$sql = "DELETE FROM tb_usuario 
				WHERE cd_usuario = :cd_usuario";
		$statement = parent::conexao()->prepare( $sql );
		$statement->bindValue(':cd_usuario', $id);
		$statement->execute();
	}

	public static function search($id){
		$sql = "SELECT cd_usuario, 
				nm_usuario, nm_sobrenome, 
				dt_nascimento, nm_email, 
				im_foto, cd_cpf, 
				cd_rg, cd_contato1, 
				cd_contato2, cd_cep, 
				nm_rua, cd_numeracao, 
				nm_bairro, nm_cidade, 
				nm_estado, nm_responsavel, 
				cd_contato_responsavel, nm_email_responsavel, 
				cd_cpf_responsavel, cd_tipo, 
				cd_turma 
				FROM tb_usuario 
				WHERE cd_usuario = :id";

		$consulta = parent::conexao()->prepare( $sql );
		$consulta->bindValue( ':id' , $id);
		$consulta->execute();

		if($linha = $consulta->fetch(PDO::FETCH_ASSOC)) {
			$usuario = UsuarioFactory::DAO($linha);
		} else {
			$usuario = new UsuarioDTO();
		}

		return $usuario;
	}
}