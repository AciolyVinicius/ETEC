/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package atividade_3;
import javax.swing.JOptionPane;
/**
 *
 * @author Aluno
 */
public class Atividade_3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        //Tabuada de 1 a 10 conforme a escolha do usuário
        String numdig;
        int num, rep=0;
        do{
        numdig = JOptionPane.showInputDialog("Digite um número de 1 a 10 para uma tabuada: ");
        num = Integer.parseInt(numdig);
        if(num>=1 && num<=10){
            rep=1;
        }
        }while(rep==0);
        int tab=1, numeros;
        String nn;
        nn = "";
        while(tab<=10){
            numeros = num*tab;
            nn = nn+numeros+"="+num+"*"+tab+"\n";
            tab++;
        }
        JOptionPane.showMessageDialog(null, nn);
    }
}
