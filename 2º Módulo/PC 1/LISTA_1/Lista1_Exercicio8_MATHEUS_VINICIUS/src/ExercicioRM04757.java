
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
        Receber do usuário: um número inteiro positivo entre 2 e 10. Imprimir na tela a tabuada de multiplicação deste número recebido. Após imprimir, 
        perguntar ao usuário se desejar visualizar a tabuada de outro número. Exemplo:
        Inteiro recebido: 7.
        Imprimir na tela:
        7 x 1 = 7.
        7 x 2 = 14.
        [...]
        7 x 9 = 63.
        */
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
