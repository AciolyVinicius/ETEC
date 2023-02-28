/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package exercicio_04;

/**
 *
 * @author viníciusaciolyelias
 */
public class Novo extends Imovel{
    private double acrescimo;
    
    public double getAcrescimo() {
        return acrescimo;
    }

    public void setAcrescimo(double acrescimo) {
        this.acrescimo = acrescimo;
    }
    
    public String Valor(){
        double valor = super.getPreco() + acrescimo;
        String val = ""+valor;
        return "\n Valor do móvel novo R$ "+ val + "}" ;
    }

    @Override
    public String toString() {
        return "Novo { " + "Acréscimo R$ " + acrescimo +" \n Endereço = "+super.getEndereco() +  "\n Preco R$ " + super.getPreco();
    }
    
}
