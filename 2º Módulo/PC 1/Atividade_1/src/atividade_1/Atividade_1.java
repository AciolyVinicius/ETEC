 /*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package atividade_1;
import javax.swing.JOptionPane;
/**
 *
 * @author Aluno
 */
public class Atividade_1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        //Que receba nome e depois sobrenome e ano de nascimento. Exiba todos os dados
        //em uma JOptionPane com a idade calculada
        String nome,sobrenome,anostring;
        int ano;
        int idad;
        nome = JOptionPane.showInputDialog("Seu nome: ");
        sobrenome = JOptionPane.showInputDialog("Seu sobrenome: ");
        anostring = JOptionPane.showInputDialog("Seu ano de nascimento: ");
        ano = Integer.parseInt(anostring);
        idad = 2017 - ano;
        JOptionPane.showMessageDialog(null, "Seu nome é: "+nome+""+sobrenome);
        JOptionPane.showMessageDialog(null, "Você tem: "+idad);        
    }
    
}
