/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package heranca;

/**
 *
 * @author Aluno
 */
public class Heranca {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Catioro c = new Catioro();
        c.setCor("Preto");
        c.setGenero("Masc");
        c.setNome("Shalom");
        c.setPeso(300);
        c.setRaca("Pincher");
        c.setTam(25);
        
        System.out.println(c.toString());
    }
    
}
