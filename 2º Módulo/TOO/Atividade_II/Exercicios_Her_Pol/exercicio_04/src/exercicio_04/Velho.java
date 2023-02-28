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
public class Velho extends Imovel{
    private double desconto;

    public double getDesconto() {
        return desconto;
    }

    public void setDesconto(double desconto) {
        this.desconto = desconto;
    }
    
    public String Valor(){
        double valor = super.getPreco() - desconto;
        String val = ""+ valor;
        return "\n Valor do imóvel velho R$ "+val+" }";
    }

    @Override
    public String toString() {
        return "Velho { " + "Desconto R$ " + desconto +" \n Endereço = "+super.getEndereco() +  "\n Preco R$ " + super.getPreco() ;
    }
    
    
}
