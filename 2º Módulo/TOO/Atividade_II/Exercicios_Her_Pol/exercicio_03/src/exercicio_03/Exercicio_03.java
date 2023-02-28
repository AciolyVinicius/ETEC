/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package exercicio_03;

/**
 *
 * @author viníciusaciolyelias
 */
public class Exercicio_03 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Ingresso i = new Ingresso();
        i.setValor(100);
        i.ImprimeValor();
        
        Normal n = new Normal();
        n.setValor(i.getValor());
        n.Normal();
        
        VIP v = new VIP();
        v.setValorAdd(100.55);
        v.Valor();
        
        CamaroteInferior ci = new CamaroteInferior();
        ci.setLocalizacao("Ao lado do som");
        System.out.println(""+ci.toString());
        
        CamaroteSuperior cs = new CamaroteSuperior();
        cs.setVlAdd(50);
        System.out.println(""+cs.toString());
    }
    
}
