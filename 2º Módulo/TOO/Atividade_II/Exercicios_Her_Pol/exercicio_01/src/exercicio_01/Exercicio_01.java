/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercicio_01;

/**
 *
 * @author Aluno
 */
public class Exercicio_01 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Tecnico tec = new Tecnico();
        tec.setBonussal(10);
        tec.assistente.func.setMatricula(150);
        System.out.println("\n"+tec.toString());
        
        Administrativo adm = new Administrativo();
        adm.setTurno("Noite");
        adm.setAdnoturno(15.5);
        adm.assistente.func.setMatricula(502);
        System.out.println(adm.toString()+"\n");
    }
    
}
