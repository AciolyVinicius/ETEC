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
        Moto m = new Moto();
        m.IPVA();
        m.seguro();
        m.setAno(2011);
        m.setCilindrada(250);
        m.setCor("Marrom");
        m.setPlaca("FEIO123");
        m.setPreco(2000);
        
        System.out.println("{\nIPVA:"+m.IPVA()+"\n Preço: "+m.getPreco()+"\n Seguro: "+m.seguro()+"\n Ano: "+m.getAno()
        +"\n Cilindrada: "+m.getCilindrada()+"\n Cor: "+m.getCor()+"\n Placa: "+m.getPlaca()+"\n}");
        
        Onibus o = new Onibus();
        o.seguro();
        o.setAno(2018);
        o.setCor("Pink");
        o.setPlaca("VAIR007");
        o.setPreco(39000);
        o.setQtd_passageiros(80);
        o.IPVA();
        
        System.out.println("{\nIPVA: "+o.IPVA()+"\n Preço: "+o.getPreco()+"\n Seguro: "+o.seguro()+"\n Ano: "+o.getAno()
        +"\n Quantiade de Passageiros: "+o.getQtd_passageiros()+"\n Cor: "+o.getCor()+"\n Placa: "+o.getPlaca()+"\n}");
        
        DePasseio dp = new DePasseio();
        dp.seguro();
        dp.IPVA();
        dp.setAno(2015);
        dp.setCor("Branquinho como um ursinho");
        dp.setDescricao("novíssimo");
        dp.setMarca("Chevrolata");
        dp.setPlaca("COCR231");
        dp.setPreco(30000);
        
        System.out.println("{\nIPVA: "+dp.IPVA()+"\n Preço: "+dp.getPreco()+"\n Seguro: "+dp.seguro()+"\n Ano: "+dp.getAno()
        +"\n Descrição: "+dp.getDescricao()+"\n Cor: "+dp.getCor()+"\n Placa: "+dp.getPlaca()+"\n Marca: "+dp.getMarca()+"\n}");
        
        Montadora mt = new Montadora();
        mt.setCnpj("74.525.745/5201-57");
        mt.setNome("Vrau Mont");
        mt.endereco.setNumero("669");
        mt.endereco.setRua("Rua Dos Perdido");
        
        System.out.println("{\nCNPJ: "+mt.getCnpj()+"\n Nome: "+mt.getNome()+"\n Número: "+mt.endereco.getNumero()+"\n Rua:"
        +mt.endereco.getRua()+"\n}");
        
        Proprietario p = new Proprietario();
        p.setCpf("787.512.654-05");
        p.setNome("Barchongo");
        p.endereco.setNumero("834");
        p.endereco.setRua("Rua Damacenos");
        
        System.out.println("{\nProprietário\n"+"CPF: "+p.getCPF()+"\n Nome: "+p.getNome()+"\n Número: "+p.endereco.getRua()
        +"\n Rua: "+p.endereco.getRua()+"\n}");
    }
    
}
