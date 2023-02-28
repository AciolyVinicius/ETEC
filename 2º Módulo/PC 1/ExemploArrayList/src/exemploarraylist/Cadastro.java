/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exemploarraylist;

/**
 *
 * @author Aluno
 */
public class Cadastro {
    private String nome;
    private String curso;
    private boolean bolsista;

    public Cadastro(String nome, String curso, boolean bolsista) {
        this.nome = nome;
        this.curso = curso;
        this.bolsista = bolsista;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getCurso() {
        return curso;
    }

    public void setCurso(String curso) {
        this.curso = curso;
    }

    public boolean isBolsista() {
        return bolsista;
    }

    public void setBolsista(boolean bolsista) {
        this.bolsista = bolsista;
    }
    
}
