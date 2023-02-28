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
public class Caminhao extends Veiculo{
    private int qtdEixos;

    public int getQtdEixos() {
        return qtdEixos;
    }

    public void setQtdEixos(int qtdEixos) {
        this.qtdEixos = qtdEixos;
    }

    public Caminhao() {
    }
    

    @Override
    public String toString() {
        return "Caminhao \n {" + "Eixos = " + qtdEixos + " }";
    }
    
}
