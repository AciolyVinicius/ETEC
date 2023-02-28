<?php

class CursoDTO
{
	private $id;
	private $nome;
	private $descricao;
	private $disciplinas;

    public function getId(){return $this->id;}
    public function setId($id){$this->id = $id;}

    public function getNome(){return $this->nome;}
    public function setNome($nome){$this->nome = $nome;}

    public function getDescricao(){return $this->descricao;}
    public function setDescricao($descricao){$this->descricao = $descricao;}

    public function getDisciplinas(){return $this->disciplinas;}
    public function setDisciplinas($disciplinas){$this->disciplinas = $disciplinas;}
}