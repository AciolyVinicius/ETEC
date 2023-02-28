/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package exercicio_05;

/**
 *
 * @author viníciusaciolyelias
 */
public class VIP extends Ingresso{
    static private double valorAdd;
    private double valor = getValor();

    public VIP() {
    }
    
    public double getValorAdd() {
        return valorAdd;
    }

    public void setValorAdd(double valorAdd) {
        this.valorAdd = valorAdd;
    }

    public void Valor(){
        double v = valor + getValorAdd();
        System.out.println("Valor do ingresso VIP R$ "+ v);        
    }
    
    public double ValorVIP(){
        double v = valor + getValorAdd();
        return(v);
    }
}
