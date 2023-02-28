<?php

class TurmaDTO
{
	private $id;
	private $nome;
	private $descricao;
    private $capacidade;
    private $dataInicio;
    private $dataFinal;
    private $curso;
    private $turno;

    public function getId(){return $this->id;}
    public function setId($id){$this->id = $id;}

    public function getNome(){return $this->nome;}
    public function setNome($nome){$this->nome = $nome;}

    public function getDescricao(){return $this->descricao;}
    public function setDescricao($descricao){$this->descricao = $descricao;}

    public function getCapacidade(){return $this->capacidade;}
    public function setCapacidade($capacidade){$this->capacidade = $capacidade;}

    public function getDataInicio(){return $this->dataInicio;}
    public function setDataInicio($dataInicio){$this->dataInicio = $dataInicio;}

    public function getDataFinal(){return $this->dataFinal;}
    public function setDataFinal($dataFinal){$this->dataFinal = $dataFinal;}

    public function getCurso(){return $this->curso;}
    public function setCurso(CursoDTO $curso){$this->curso = $curso;}

    public function getTurno(){return $this->turno;}
    public function setTurno(TurnoDTO $turno){$this->turno = $turno;}
}