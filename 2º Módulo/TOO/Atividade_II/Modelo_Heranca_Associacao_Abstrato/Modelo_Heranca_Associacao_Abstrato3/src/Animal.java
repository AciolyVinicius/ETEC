/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Aluno
 */
public abstract class Animal {
    private int qtd_anos;
    private double peso;

    public int getQtd_anos() {
        return qtd_anos;
    }

    public void setQtd_anos(int qtd_anos) {
        this.qtd_anos = qtd_anos;
    }

    public double getPeso() {
        return peso;
    }

    public void setPeso(double peso) {
        this.peso = peso;
    }
}
