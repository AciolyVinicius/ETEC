/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo_abstrato_03;

/**
 *
 * @author Aluno
 */
public class Cachorro extends Animal{
    private String nome;
    private String raca;

    public Cachorro() {
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getRaca() {
        return raca;
    }

    public void setRaca(String raca) {
        this.raca = raca;
    }

    @Override
    public double valor() {
        double valor;
        valor = super.getPeso() * super.getQtdAnos() / 2;
        return valor;
    }
    
    
}
