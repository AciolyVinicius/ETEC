/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Aluno
 */
public class Onibus extends Veiculo{
    private int qtd_passageiros;
    Montadora montadora = new Montadora();

    public int getQtd_passageiros() {
        return qtd_passageiros;
    }

    public void setQtd_passageiros(int qtd_passageiros) {
        this.qtd_passageiros = qtd_passageiros;
    }
    
    public double IPVA(){
        return (getPreco()*0.05);
    }
    
    public double seguro(){
        return (getPreco()*0.025);
    }

    @Override
    public String toString() {
        return "Onibus{" + "QtdPassageiros=" + this.getQtd_passageiros() + ", montadora=" + montadora + '}';
    }
    
    
}
