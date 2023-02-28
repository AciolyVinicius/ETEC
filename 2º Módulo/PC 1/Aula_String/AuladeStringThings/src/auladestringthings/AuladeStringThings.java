/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package auladestringthings;

/**
 *
 * @author francis e charles 2º módulo de Informática ETEC 
 */
public class AuladeStringThings {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        String escola="";
//======================================        
        //CONCATENAR +=
        escola+="ruthinha";
        System.out.println(escola);
//======================================        
        //Tamanho da String
        System.out.println(escola.length());  
//======================================        
        //REMOVER ESPAÇOS EM BRANCO do início e fim, use trim
        escola="   ruthinha";
        System.out.println(escola);
        System.out.println(escola.trim());
        
        escola="ruthinha";
//======================================       
        
       //MAIUSCULO
        System.out.println(escola.toUpperCase());  
//======================================        
       //MINUSCULO 
         System.out.println(escola.toLowerCase());  
//======================================         
         //COMPARAÇÃO
         String escolar="RuthinhA";
         System.out.println(escola.equals(escolar));  //saida booleana dizendo falso
         //ou seja é case sensitive
         System.out.println(escola.equalsIgnoreCase(escolar));//saida booleana dizendo           //true, este ignora Maiusculas e minusculas
//========================================         
        //SUBSTRING
               
        /*
        r 0
        u 1
        t 2
        h 3
        i 4
        n 5
        h 6
        a 7
        */    
        escola="ruthinha";
        System.out.println(escola.substring(2,5));
        
//=========================================
        //INDEXOF Retorna o índice dentro da sequência de caracteres da primeira ocorrência da substring especificada (s). O valor -1 como retorno indica que não existe uma ocorrência.
        System.out.println("Indexof. Letra u está no índice : "+ escola.indexOf("u"));
        
//=========================================        
        //CHARAT traz o que existe no indice tal
        System.out.println("Charat do 4 indice. O que está no índice 4?  "+ escola.charAt(4) );

//=========================================
   //usando For
       for(int i=0;i<escola.length();i++){
        System.out.println("A posição "+(i+1)+" tem a letra: " +escola.charAt(i));
    }
    }
    
}
