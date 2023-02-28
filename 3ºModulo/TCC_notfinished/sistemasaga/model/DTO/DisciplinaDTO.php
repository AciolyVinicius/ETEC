<?php

class DisciplinaDTO
{
	private $id;
	private $nome;
	private $descricao;
	private $cargaHoraria;

    public function getId(){return $this->id;}
    public function setId($id){$this->id = $id;}

    public function getNome(){return $this->nome;}
    public function setNome($nome){$this->nome = $nome;}

    public function getDescricao(){return $this->descricao;}
    public function setDescricao($descricao){$this->descricao = $descricao;}

    public function getCargaHoraria(){return $this->cargaHoraria;}
    public function setCargaHoraria($cargaHoraria){$this->cargaHoraria = $cargaHoraria;}
}