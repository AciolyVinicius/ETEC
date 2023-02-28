/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Aluno
 */
public class ExercicioRM04757 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // Faça um programa que receba um nome do tipo “JoaoBatista”, “MariaSilva”, e separe os nomes de acordo com as letras maiúsculas. 
        //De maneira que fique assim “Joao Batista”, “Maria Silva”.
        String jb04757="JoaoBatista", ms="MariaSilva";
        String jjb=jb04757.substring(4);
        String jjjb=jb04757.substring(0,4);
        jb04757= jjjb+" "+jjb;
        String mms=ms.substring(5);
        String mmms=ms.substring(0,5);
        ms = mmms +" "+ mms;
        System.out.println(jb04757);
        System.out.println(ms);
    }
    
}
