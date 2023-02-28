/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo_heranca_associacao;

/**
 *
 * @author Aluno
 */
public class Veiculo {
    private int ano;
    public Modelo modelo = new Modelo();

    public Veiculo() {
    }
    
    public int getAno() {
        return ano;
    }

    public void setAno(int ano) {
        this.ano = ano;
    }

    @Override
    public String toString() {
        return "Veiculo { " + "Ano = " + ano + " }";
    }

    public Modelo getModelo() {
        return modelo;
    }

    public void setModelo(Modelo modelo) {
        this.modelo = modelo;
    }
    
}
