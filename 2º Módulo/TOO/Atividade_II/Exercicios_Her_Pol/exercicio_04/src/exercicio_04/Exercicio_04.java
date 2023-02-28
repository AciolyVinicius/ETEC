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
public class Exercicio_04 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Velho v = new Velho ();
        v.setPreco(250);
        v.setEndereco("Rua Benedito 287");
        v.setDesconto(50);
        System.out.println(v.toString()+v.Valor()+"\n");
        
        Novo n = new Novo();
        n.setPreco(320);
        n.setEndereco("Rua João Banalho 2");
        n.setAcrescimo(120);
        System.out.println(n.toString()+n.Valor());
    }
    
}
