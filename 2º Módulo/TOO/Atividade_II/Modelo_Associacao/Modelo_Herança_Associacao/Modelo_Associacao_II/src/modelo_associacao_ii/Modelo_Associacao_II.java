/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo_associacao_ii;

/**
 *
 * @author Aluno
 */
public class Modelo_Associacao_II {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Cachorro tobi = new Cachorro ();
        
        tobi.setNome("Tobi");
        tobi.setRaca("Vira-Lata");
        tobi.setCodigo("A1A2");
        tobi.proprietario.setEndereco("Rua São Nunca da Silva, Número 007");
        tobi.filiacao.setNomeDaMae("Tubinha");
        tobi.filiacao.setNomeDoPai("Tubinho");
        tobi.proprietario.setNomeDoProprietario("Obito");
        
        System.out.println(tobi.toString()+tobi.filiacao.toString()+tobi.proprietario.toString());
    }
    
}
