/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo_abstrato_02;

/**
 *
 * @author Aluno
 */
public class Modelo_abstrato_02 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Fisica f = new Fisica();
        f.setCPF("5158242572X");
        f.setNome("Mafaldo");
        f.setSalario(5000);
        f.telefone.setDdd(13);
        f.telefone.setNumero("995521426");
        System.out.println(f.toString());
        System.out.println("*Salário com desconto = R$ "+f.Desconto()+"*");
        
        Juridica j = new Juridica();
        j.setCNPJ("51582GX");
        j.setNome("Couca-Coula");
        j.setFaturamento(1000000);
        f.telefone.setDdd(13);
        f.telefone.setNumero("998856947");
        System.out.println("\n -#-\n  \n"+j.toString());
        
    }
    
}
