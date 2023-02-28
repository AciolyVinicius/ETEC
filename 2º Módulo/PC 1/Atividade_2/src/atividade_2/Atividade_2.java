/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package atividade_2;
import javax.swing.JOptionPane;
/**
 *
 * @author Aluno
 */
public class Atividade_2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        // E1P  que calcule o I.M.C. e exiba o resultado conforme a especificação da OMS
        String speso,salt;
        int peso, alt, md;
        speso = JOptionPane.showInputDialog("Digite seu peso: ");
        salt = JOptionPane.showInputDialog("Digite sua altura: ");
        peso = Integer.parseInt(speso);
        alt = Integer.parseInt(salt);
        float med;
        med = peso/alt*alt;
        if (18.6>med){
            JOptionPane.showMessageDialog(null, "Você está abaixo do peso.");
        }
        else{
            if(med<25){
               JOptionPane.showMessageDialog(null, "Você está com peso ideal.");             
            }
            else{
                if(med<30){
                JOptionPane.showMessageDialog(null, "Você está levemente acima do peso");    
                }
                else{
                 if(med<35){
                   JOptionPane.showMessageDialog(null, "Você está com obesidade grau I");  
                 }
                 else{
                    if(med<40){
                        JOptionPane.showMessageDialog(null, "Você está com obesidade grau II");
                        
                    }
                    else{
                        JOptionPane.showMessageDialog(null, "Você está com obesidade grau III");
                    }   
                    }
                 }  
                }
                }
                }
}
