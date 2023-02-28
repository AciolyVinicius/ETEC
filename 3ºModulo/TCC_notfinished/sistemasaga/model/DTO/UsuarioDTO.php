<?php

class UsuarioDTO
{
	private $id;
	private $nome;
	private $sobrenome;
	private $nascimento;
	private $email;
	private $foto;
	private $cpf;
	private $rg;
	private $senha;
	private $contato1;
	private $contato2;
	private $cep;
	private $rua;
	private $numeracao;
	private $bairro;
	private $cidade;
	private $estado;
	private $nomeResponsavel;
	private $contatoResponsavel;
	private $emailResponsavel;
	private $cpfResponsavel;
	private $tipo;
	private $turma;

	public function getId(){return $this->id;}
	public function setId($id){$this->id = $id;}

	public function getNome(){return $this->nome;}
	public function setNome($nome){$this->nome = $nome;}

	public function getSobrenome(){return $this->sobrenome;}
	public function setSobrenome($sobrenome){$this->sobrenome = $sobrenome;}

	public function getNascimento(){return $this->nascimento;}
	public function setNascimento($nascimento){$this->nascimento = $nascimento;}

	public function getEmail(){return $this->email;}
	public function setEmail($email){$this->email = $email;}

	public function getFoto(){return $this->foto;}
	public function setFoto($foto){$this->foto = $foto;}

	public function getCpf(){return $this->cpf;}
	public function setCpf($cpf){$this->cpf = $cpf;}

	public function getRg(){return $this->rg;}
	public function setRg($rg){$this->rg = $rg;}

	public function getSenha(){return $this->senha;}
	public function setSenha($senha){$this->senha = $senha;}

	public function getContato1(){return $this->contato1;}
	public function setContato1($contato1){$this->contato1 = $contato1;}

	public function getContato2(){return $this->contato2;}
	public function setContato2($contato2){$this->contato2 = $contato2;}

	public function getCep(){return $this->cep;}
	public function setCep($cep){$this->cep = $cep;}

	public function getRua(){return $this->rua;}
	public function setRua($rua){$this->rua = $rua;}

	public function getNumeracao(){return $this->numeracao;}
	public function setNumeracao($numeracao){$this->numeracao = $numeracao;}

	public function getBairro(){return $this->bairro;}
	public function setBairro($bairro){$this->bairro = $bairro;}

	public function getCidade(){return $this->cidade;}
	public function setCidade($cidade){$this->cidade = $cidade;}

	public function getEstado(){return $this->estado;}
	public function setEstado($estado){$this->estado = $estado;}

	public function getNomeResponsavel(){return $this->nomeResponsavel;}
	public function setNomeResponsavel($nomeResponsavel){$this->nomeResponsavel = $nomeResponsavel;}

	public function getContatoResponsavel(){return $this->contatoResponsavel;}
	public function setContatoResponsavel($contatoResponsavel){$this->contatoResponsavel = $contatoResponsavel;}

	public function getEmailResponsavel(){return $this->emailResponsavel;}
	public function setEmailResponsavel($emailResponsavel){$this->emailResponsavel = $emailResponsavel;}

	public function getCpfResponsavel(){return $this->cpfResponsavel;}
	public function setCpfResponsavel($cpfResponsavel){$this->cpfResponsavel = $cpfResponsavel;}

	public function getTipo(){return $this->tipo;}
	public function setTipo(TipoDTO $tipo){$this->tipo = $tipo;}

	public function getTurma(){return $this->turma;}
	public function setTurma(TurmaDTO $turma){$this->turma = $turma;}
}