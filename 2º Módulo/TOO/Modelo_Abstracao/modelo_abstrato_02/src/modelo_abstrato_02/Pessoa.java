/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo_abstrato_02;

/**
 *
 * @author Aluno
 */
public abstract class Pessoa {
    private String nome;
    Telefone telefone = new Telefone();

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }
    public abstract double Desconto();
}
