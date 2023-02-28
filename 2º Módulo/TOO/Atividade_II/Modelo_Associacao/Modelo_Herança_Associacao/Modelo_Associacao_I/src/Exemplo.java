

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Aluno
 */
public class Exemplo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       Pessoa ger = new Pessoa();
       
       ger.setNome("Gertrudo");
       ger.setCodigo("rsrs");
       ger.setIdade(22);
       ger.veiculo.setAno(2000);
       ger.veiculo.setPlaca("SRN-2938");
       
       System.out.println(ger.toString());
    }
    
}
