<?php

class InstituicaoDTO
{
	private $nome;
	private $fantasia;
	private $cnpj;
	private $contato1;
	private $contato2;
	private $email;
	private $rua;
	private $numeracao;
	private $bairro;
	private $cidade;
	private $estado;
	private $cep;
	private $mec;
	private $alvara;

    public function getNome()
    {
        return $this->nome;
    }
    
    public function setNome($nome)
    {
        $this->nome = $nome;
    }

    public function getFantasia()
    {
        return $this->fantasia;
    }
 
    public function setFantasia($fantasia)
    {
        $this->fantasia = $fantasia;
    }

    public function getCnpj()
    {
        return $this->cnpj;
    }
    
    public function setCnpj($cnpj)
    {
        $this->cnpj = $cnpj;
    }

    public function getContato1()
    {
        return $this->contato1;
    }
 
    public function setContato1($contato1)
    {
        $this->contato1 = $contato1;
    }

    public function getContato2()
    {
        return $this->contato2;
    }

    public function setContato2($contato2)
    {
        $this->contato2 = $contato2;
    }

    public function getEmail()
    {
        return $this->email;
    }
    public function setEmail($email)
    {
        $this->email = $email;
    }

    public function getRua()
    {
        return $this->rua;
    }
   
    public function setRua($rua)
    {
        $this->rua = $rua;
    }

    public function getNumeracao()
    {
        return $this->numeracao;
    }
  
    public function setNumeracao($numeracao)
    {
        $this->numeracao = $numeracao;
    }

    public function getBairro()
    {
        return $this->bairro;
    }

    public function setBairro($bairro)
    {
        $this->bairro = $bairro;
    }

    public function getCidade()
    {
        return $this->cidade;
    }

    public function setCidade($cidade)
    {
        $this->cidade = $cidade;
    }

    public function getEstado()
    {
        return $this->estado;
    }

    public function setEstado($estado)
    {
        $this->estado = $estado;
    }

    public function getCep()
    {
        return $this->cep;
    }
   
    public function setCep($cep)
    {
        $this->cep = $cep;
    }

    public function getMec()
    {
        return $this->mec;
    }
   
    public function setMec($mec)
    {
        $this->mec = $mec;
    }

    public function getAlvara()
    {
        return $this->alvara;
    }

    public function setAlvara($alvara)
    {
        $this->alvara = $alvara;
    }
}