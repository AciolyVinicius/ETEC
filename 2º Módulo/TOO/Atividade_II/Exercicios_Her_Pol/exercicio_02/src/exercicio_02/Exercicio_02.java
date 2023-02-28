/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercicio_02;

/**
 *
 * @author Aluno
 */
public class Exercicio_02 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       Cachorro c = new Cachorro();
        c.setNome("Marley");
        c.setRaca("Vira Ouro");
        System.out.println("\n"+c.toString()+"\n" +c.late()+"\n & \n"+ c.caminha()+"\n}\n ");
        
        Gato g = new Gato();
        g.setNome("Nina");
        g.setRaca("Qualquer");
        System.out.println(g.toString()+"\n"+g.mia()+ "\n & \n"+ g.caminha()+"\n}\n ");
        
        //-c
        Pobre p = new Pobre();
        p.setIdade(23);
        p.setNome("Drigo");        
        System.out.println(p.toString());
        p.trabalha();
        System.out.println("}");
        
        Miseravel m = new Miseravel();
        m.setIdade(37);
        m.setNome("Brogada");
        System.out.println(m.toString());
        m.mendiga();
        System.out.println("}");
        
        Rica r = new Rica();
        r.setIdade(27);
        r.setNome("Juadi");
        r.setDinheiro(10000);
        System.out.println(r.toString());
        r.fazCompras();
        System.out.println("}");
    }
    
}
