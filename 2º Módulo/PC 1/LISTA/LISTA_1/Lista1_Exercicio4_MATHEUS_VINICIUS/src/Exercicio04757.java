
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
public class Exercicio04757 {

    /**
     * @param args the command line arguments
     */
    
    //A série de Fibonacci é formada pela sequência 1,1,2,3,5,8,13,21,34,55,... Faça um programa capaz de gerar a série até o enésimo termo. Ex. Recebe 6, imprime 8. Recebe 10, imprime 55.
    public static void main(String[] args) {
        int rm04757, num1=1, num2=1, tt=0, i=0;
        String fibonacci="";
        rm04757 = Integer.parseInt(JOptionPane.showInputDialog("Digite o enésimo termo: "));
        do {
            tt = num1+num2;
            num1 = num2;
            num2=tt;
            fibonacci = fibonacci+ "\n" + tt;
            i++; 
        }while(i<rm04757);
        JOptionPane.showMessageDialog(null, "1" +"\n"+ "1" + fibonacci);
    }
    
}
