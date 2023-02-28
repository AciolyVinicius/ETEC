/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Aluno
 */
public class Abstrato {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Fisica f = new Fisica();
        f.setCPF("25046974-00");
        f.setNome("Fabrício");
        f.setSalario(1250);
        f.telefone.setDDD(15);
        f.telefone.setNumero("997764815");
        f.desconto();
        
        Juridica j = new Juridica();
        j.setCNPJ("15.874.849/8752-00");
        j.setNome("Juão do Farto");
        j.setFaturamento(1500);
        j.telefone.setDDD(11);
        j.telefone.setNumero("9877542");
        j.desconto();
        
        System.out.println("Pessoa Física\n{"+"\n"+"CPF: "+f.getCPF()+"\n"+"Nome: "+f.getNome()+"\n"+"Salario: "+f.getSalario()
        +"\n"+"Telefone: "+"("+f.telefone.getDDD()+")"+f.telefone.getNumero()+"\n"+"Desconto <5%>: "+f.desconto()+"\n}\n");
        
        System.out.println("Pessoa Juridica\n{"+"\n"+"CNPJ: "+j.getCNPJ()+"\n"+"Nome: "+j.getNome()+"\n"+"Faturamento: "+j.getFaturamento()
        +"\n"+"Telefone: "+"("+j.telefone.getDDD()+")"+j.telefone.getNumero()+"\n"+"Desconto <2%>: "+j.desconto()+"\n}");
    }
    
}
