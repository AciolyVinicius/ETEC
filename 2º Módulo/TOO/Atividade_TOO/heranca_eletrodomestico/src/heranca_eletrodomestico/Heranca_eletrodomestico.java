/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package heranca_eletrodomestico;

/**
 *
 * @author Guilherme
 */
public class Heranca_eletrodomestico {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        domestico domestico = new domestico();
        domestico.setTipo("Ferro");
        domestico.setQtdBocas(6);
        domestico.setLargura(20);
        domestico.setNumeroSerie(5154169);
        domestico.setPeso(50);
        domestico.setMarca("Polishop");
        domestico.setNome("LimpaJanela");
        
        System.out.println(domestico.toString());
        
        industrial indus = new industrial();
        indus.setProfundidade(25.5);
        indus.setQtdBocas(5);
        indus.setLargura(100);
        indus.setNumeroSerie(9598169);
        indus.setPeso(140);
        indus.setMarca("Polishop");
        indus.setNome("OMelhor");
        
        System.out.println(indus.toString());
    }
    
}
