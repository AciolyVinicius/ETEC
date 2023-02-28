
import javax.swing.JOptionPane;

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
        /* 
        Fazer um programa que leia uma frase e imprima somente as vogais.
        */
        String frase = JOptionPane.showInputDialog("Digite um frase: ");
        frase = frase.toLowerCase();
        String vogais, vog,lfrase, v04757="";
        vogais = "aeiou";
        for (int i = 0; i < frase.length(); i++) {
            lfrase=""+frase.charAt(i);
            for(int contv = 0 ; contv<5; contv++){
                vog=""+vogais.charAt(contv);
                if(lfrase.equalsIgnoreCase(vog)){
                    v04757+=lfrase;
                }
            }
        }
        JOptionPane.showMessageDialog(null, ""+v04757);
    }
    
}
