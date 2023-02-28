/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package banco;

/**
 *
 * @author Aluno
 */
public class Banco {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Conta c = new Conta(157, "Eu", 150, 200);
        
        Conta c2 = new Conta();
        c2.setNumero(333);
        c2.setDono("Mamais");
        c2.setLimite(2);
        c2.setSaldo(-1000);
        
        c.transferencia(c2, 1);
        
        Conta cJ = new Conta(158, c.getDono(), 2500, 1000);
                
        System.out.println(c.getDono());
        System.out.println(c2.getDono() + ", saldo: " + c2.getSaldo());
    }
    
}
