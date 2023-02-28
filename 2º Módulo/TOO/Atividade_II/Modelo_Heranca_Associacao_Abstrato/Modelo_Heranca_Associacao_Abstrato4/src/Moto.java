/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Aluno
 */
public class Moto extends Veiculo{
    private int cilindrada;

    public int getCilindrada() {
        return cilindrada;
    }

    public void setCilindrada(int cilindrada) {
        this.cilindrada = cilindrada;
    }
    
    public double IPVA(){
        return (getPreco()*0.08);
    }
    
    public double seguro(){
        return (getPreco()*0.05);
    }

    @Override
    public String toString() {
        return "Moto{" + "cilindrada=" + cilindrada + '}';
    }
    
}
