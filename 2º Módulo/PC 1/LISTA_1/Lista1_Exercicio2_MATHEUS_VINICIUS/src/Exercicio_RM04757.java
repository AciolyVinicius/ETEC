
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
public class Exercicio_RM04757 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int n1, n2, soma04757, num;
        n1=Integer.parseInt(JOptionPane.showInputDialog("Insira um valor: " ));
        n2=Integer.parseInt(JOptionPane.showInputDialog("Insira um outro valor: " ));
        soma04757 = n1+n2;
        if(n1>n2)
        {
            int aux=n1;
            n1=n2;
            n2=aux;
        }
        num=n1;
        soma04757 = n1+n2;
        String inter=""+n1+"\n";
        do{
            num=num+1;
            soma04757 = soma04757+num;
            inter = inter+"\n"+num+"\n";
       }while(n2-1>num);
        JOptionPane.showMessageDialog(null,"INTERVALO: \n" + inter +"\n"+n2+ "\n \n A soma desses números é: "+soma04757);
    }
    
}
