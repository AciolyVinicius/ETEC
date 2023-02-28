/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package heranca_empresa;

/**
 *
 * @author Guilherme
 */
public class Heranca_empresa {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        vendedor vende = new vendedor();
        vende.setComissao(500);
        vende.setValorVendas(10);
        vende.setNumeroSeccao(8);
        vende.setSalarioBase(900);
        vende.setIRS(1);
        vende.setNome("Alexandre");
        vende.setContribuinte(568);
        vende.setIdade(70);
        
        System.out.println(vende.toString());
        
        operario operar = new operario();
        operar.setComissao(500);
        operar.setValorProducao(90);
        operar.setNumeroSeccao(1);
        operar.setSalarioBase(1000);
        operar.setIRS(4);
        operar.setNome("Maurício");
        operar.setContribuinte(568);
        operar.setIdade(50);
        
        System.out.println(operar.toString());
        
        // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        
        administrador admin = new administrador();
        admin.setAjudasDeCusto(50);
        admin.setNumeroSeccao(5);
        admin.setSalarioBase(1000);
        admin.setIRS(1);
        admin.setNome("Pablo");
        admin.setContribuinte(568);
        admin.setIdade(56);
        
        System.out.println(admin.toString());
        
        // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        
        cliente client = new cliente();
        client.setPlafond(4000);
        client.setValorEmDivida(5000);
        client.setNome("Guilherme");
        client.setContribuinte(568);
        client.setIdade(65);
        
        System.out.println(client.toString());
        
        // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        
        empregado empre = new empregado();
        empre.setNumeroSeccao(8);
        empre.setSalarioBase(500);
        empre.setIRS(1);
        empre.setNome("João");
        empre.setContribuinte(568);
        empre.setIdade(68);
        
        System.out.println(empre.toString());
        
        // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        
        fornecedor fornec = new fornecedor();
        fornec.setPlafond(10);
        fornec.setValorEmDivida(400);
        fornec.setNome("Pedro");
        fornec.setContribuinte(568);
        fornec.setIdade(12);
        
        System.out.println(fornec.toString());
        
        // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
        
    }
    
}
