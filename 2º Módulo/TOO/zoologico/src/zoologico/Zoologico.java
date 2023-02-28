/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package zoologico;

/**
 *
 * @author Aluno
 */
public class Zoologico {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Papagaio astoufo = new Papagaio();
        
        astoufo.setNome("Astoufo");
        astoufo.setCor("Azul");
        astoufo.setPeso(100.5);
        astoufo.setGenero(false); 
        astoufo.setIdade(10);
        astoufo.setEspecie("Belga");
        System.out.println( "Nome do papagaio é: "+astoufo.getNome());
        
        Gato gatu = new Gato();
        
        gatu.setNome("Gatin");
        gatu.setCor("Azul");
        gatu.setPeso(100.5);
        gatu.setGenero(false); 
        gatu.setIdade(10);
        gatu.setRaca("Bebezin");
        System.out.println("Nome do gato é: "+ gatu.getNome());
        
        Raposa rapos = new Raposa();
        
        rapos.setNome("Astoufo");
        rapos.setCor("Azul");
        rapos.setPeso(100.5);
        rapos.setGenero(false); 
        rapos.setIdade(10);
        rapos.setRaca("Bebezun");
        System.out.println("Nome da raposa é: "+ rapos.getNome());
        
        Tigre crisco = new Tigre();
        
        crisco.setNome("CrisCó");
        crisco.setCor("Azul");
        crisco.setPeso(100.5);
        crisco.setGenero(false); 
        crisco.setIdade(10);
        crisco.setRaca("Bebezun");
        System.out.println("Nome do tigre é: "+ crisco.getNome());
        
        Cachorro dog = new Cachorro();
        
        dog.setNome("Doggue");
        dog.setCor("Azul");
        dog.setPeso(100.5);
        dog.setGenero(false); 
        dog.setIdade(10);
        dog.setRaca("Bebezun");
        System.out.println("Nome do cachorro é: "+ dog.getNome());
        
        Aviao avi = new Aviao();
        avi.setAsas("Lindas e maravilhosas!!");
        avi.setCor("Preto escuro igual seu coração");
        avi.setMaterial("Muito diamante.");
        avi.setPeso(10000);
        avi.setTamanho(500);
        avi.setTrempouso("Muito bom!");
        System.out.println("As asas são: "+ avi.getAsas());
    }
    
}
