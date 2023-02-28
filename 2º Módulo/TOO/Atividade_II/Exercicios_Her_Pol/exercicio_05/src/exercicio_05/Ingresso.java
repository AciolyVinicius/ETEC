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
public class Ingresso {
    static private double valor;

    public Ingresso() {
    }
    
    public double getValor() {
        return valor;
    }

    public void setValor(double valor) {
        this.valor = valor;
    }
    
    public void ImprimeValor(){
        System.out.println("Valor do ingresso R$ "+ getValor());
    }
}
