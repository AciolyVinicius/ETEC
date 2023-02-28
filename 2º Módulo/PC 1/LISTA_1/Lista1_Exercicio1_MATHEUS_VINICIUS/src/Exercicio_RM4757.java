
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
public class Exercicio_RM4757 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int n1, n2, num;
        n1=Integer.parseInt(JOptionPane.showInputDialog("Insira um valor: " ));
        n2=Integer.parseInt(JOptionPane.showInputDialog("Insira um outro valor: " ));
        if(n1>n2)
        {
            int aux=n1;
            n1=n2;
            n2=aux;
        }
        num=n1;
        String inter=""+n1+"\n";
        do{
            num=num+1;
            inter = inter+"\n"+num+"\n";
       }while(n2-1>num);
       JOptionPane.showMessageDialog(null,"INTERVALO: \n" + inter +"\n"+n2);
    }
    
}
