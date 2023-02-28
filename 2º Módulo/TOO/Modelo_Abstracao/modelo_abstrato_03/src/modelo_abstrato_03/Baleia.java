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
public class Baleia extends Animal{
    private String especie;
    private double altura;

    public Baleia() {
    }

    public String getEspecie() {
        return especie;
    }

    public void setEspecie(String especie) {
        this.especie = especie;
    }

    public double getAltura() {
        return altura;
    }

    public void setAltura(double altura) {
        this.altura = altura;
    }

    @Override
    public double valor() {
        double valor;
        valor = super.getQtdAnos() * super.getPeso() * getAltura() / 2;
        return valor;
    }
    
    
}
