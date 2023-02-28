/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package heranca_locadora;

/**
 *
 * @author Guilherme
 */
public class Heranca_locadora {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        filme flm = new filme();
        flm.setDiretor("Valmir");
        flm.setDuracao(140);
        flm.setId(102);
        flm.setTitulo("A volta dos que não foram");
        flm.setDescricao("Filme daora");
        flm.setPreco(299);
        flm.setNumeroDias(1);
        flm.setCategoria("A");
        System.out.println(flm.toString());
                  
    
        jogo jg = new jogo();
        jg.setMemoria(4);
        jg.setTipo("PS2");
        jg.setId(101);
        jg.setTitulo("GTA");
        jg.setDescricao("Sensacional");
        jg.setPreco(89.99);
        jg.setNumeroDias(9);
        jg.setCategoria("B");
        System.out.println(jg.toString());
    }
}
