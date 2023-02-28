/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package associacao_03;

/**
 *
 * @author Aluno
 */
public class Associacao_03 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Cachorro c = new Cachorro();
        c.setNome("Auau");
        c.setRaca("Pastor Alemão");
        c.setIdade(5);
        c.proprietario.setNome("Carlos");
        c.proprietario.setEndereco("Rua Chimara, nº3");
        c.proprietario.setCpf("010101010101");
        c.proprietario.setTelefone("32568945");
        System.out.println("\n"+c.toString()+"\n"+c.proprietario.toString());
        
        Gato g = new Gato();
        g.setNome("Mimi");
        g.setTipopelo("Burgês");
        g.proprietario.setNome("Quiana");
        g.proprietario.setEndereco("Rua Babaro, nº324");
        g.proprietario.setCpf("010101542021");
        g.proprietario.setTelefone("32552155");
        System.out.println("\n"+g.toString()+"\n"+g.proprietario.toString());
    }
    
}
