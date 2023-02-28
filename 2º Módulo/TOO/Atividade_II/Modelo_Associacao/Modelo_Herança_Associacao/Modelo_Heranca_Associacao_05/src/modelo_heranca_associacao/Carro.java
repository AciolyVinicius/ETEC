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
public class Carro extends Veiculo{
    private int qtdPassageiros;

    public int getQtdPassageiros() {
        return qtdPassageiros;
    }

    public void setQtdPassageiros(int qtdPassageiros) {
        this.qtdPassageiros = qtdPassageiros;
    }

    public Carro() {
    }
    
    
    @Override
    public String toString() {
        return "Carro \n { " + "Passageiros=" + qtdPassageiros + " }";
    }
    
}
