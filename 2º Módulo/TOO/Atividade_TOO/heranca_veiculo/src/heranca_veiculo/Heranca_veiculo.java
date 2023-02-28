/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package heranca_veiculo;

/**
 *
 * @author Guilherme
 */
public class Heranca_veiculo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        gol Gol = new gol();
        Gol.setAno(1500);
        Gol.setChassi(5656169);
        Gol.setQtdPortas(5);
        Gol.setMarca("Fox");
        Gol.setKmRodados(200);
        Gol.setQtdPassageiros(5);
        
        System.out.println(Gol.toString());
    }
    
}
