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
        f.setCpf("514852547-01");
        f.setNome("Juão Cabeçao");
        f.setSalario(1300);
        f.telefone.setDdd(11);
        f.telefone.setNumero("514851425");
        f.desconto();
        f.cachorro.setNome("Uauau");
        f.cachorro.setPeso(10);
        f.cachorro.setQtd_anos(1);
        f.cachorro.setRaca("Dalmata");
        
        Juridica j = new Juridica();
        j.setCnpj("45.354.789/9090-00");
        j.setNome("Elizabete");
        j.setFaturamento(1100);
        j.telefone.setDdd(13);
        j.telefone.setNumero("845684875");
        j.desconto();
        
        Baleia b = new Baleia();
        b.setAltura(30);
        b.setEspecie("Jubate");
        b.setPeso(300000);
        b.setQtd_anos(40);
        
        
        System.out.println("Pessoa Física\n{"+"\n"+"CPF: "+f.getCpf()+"\n"+"Nome: "+f.getNome()+"\n"+"Salario: "+f.getSalario()
        +"\n"+"Telefone: "+"("+f.telefone.getDDD()+")"+f.telefone.getNumero()+"\n"+"Desconto <5%>: "+f.desconto()+"\n Cachorro\n "
        +f.cachorro.getNome()+"Peso: "+f.cachorro.getPeso()+"Idade: "+f.cachorro.getQtd_anos()+"Raca/: "+f.cachorro.getRaca()+"\n}\n");
        
        System.out.println("Pessoa Juridica\n{"+"\n"+"CNPJ: "+j.getCnpj()+"\n"+"Nome: "+j.getNome()+"\n"+"Faturamento: "+j.getFaturamento()
        +"\n"+"Telefone: "+"("+j.telefone.getDDD()+")"+j.telefone.getNumero()+"\n"+"Desconto <2%>: "+j.desconto()+"\n}\n");
        
        System.out.println("Baleia\n{"+"\n"+"Altura: "+b.getAltura()+"\nEspecie: "+b.getEspecie()+"\nPeso: "+b.getPeso()+"\nIdade: "+b.getQtd_anos()+"\n}");
    }
    
}
