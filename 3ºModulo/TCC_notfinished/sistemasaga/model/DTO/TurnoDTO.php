<?php

class TurnoDTO
{
	private $id;
	private $nome;
	private $descricao;
	private $horaInicio;
	private $horaFinal;

    public function getId(){return $this->id;}
    public function setId($id){$this->id = $id;}

    public function getNome(){return $this->nome;}
    public function setNome($nome){$this->nome = $nome;}

    public function getDescricao(){return $this->descricao;}
    public function setDescricao($descricao){$this->descricao = $descricao;}

    public function getHoraInicio(){return $this->horaInicio;}
    public function setHoraInicio($horaInicio){$this->horaInicio = $horaInicio;}

    public function getHoraFinal(){return $this->horaFinal;}
    public function setHoraFinal($horaFinal){$this->horaFinal = $horaFinal;}
}