<?php

class AvisoDTO
{
	private $id;
	private $nome;
	private $descricao;
	private $anexo;
    private $curso;
    private $turma;
    private $usuario;

    public function getId(){return $this->id;}
    public function setId($id){$this->id = $id;}

    public function getNome(){return $this->nome;}
    public function setNome($nome){$this->nome = $nome;}

    public function getDescricao(){return $this->descricao;}
    public function setDescricao($descricao){$this->descricao = $descricao;}

    public function getAnexo(){return $this->anexo;}
    public function setAnexo($anexo){$this->anexo = $anexo;}

    public function getCurso(){return $this->curso;}
    public function setCurso(CursoDTO $curso){$this->curso = $curso;}

    public function getTurma(){return $this->turma;}
    public function setTurma(TurmaDTO $turma){$this->turma = $turma;}

    public function getUsuario(){return $this->usuario;}
    public function setUsuario(UsuarioDTO $usuario){$this->usuario = $usuario;}
}