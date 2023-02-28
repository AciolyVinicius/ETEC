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
public abstract class Animal {
    private int qtdAnos;
    private double peso;
    
    public abstract double valor();

    public int getQtdAnos() {
        return qtdAnos;
    }

    public void setQtdAnos(int qtdAnos) {
        this.qtdAnos = qtdAnos;
    }

    public double getPeso() {
        return peso;
    }

    public void setPeso(double peso) {
        this.peso = peso;
    }

    public Animal() {
    }
}
