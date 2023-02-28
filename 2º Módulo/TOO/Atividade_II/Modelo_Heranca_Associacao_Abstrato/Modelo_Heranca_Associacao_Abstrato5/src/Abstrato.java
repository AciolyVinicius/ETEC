/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author lobin
 */
public class Abstrato {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Atendente a = new Atendente();
        a.setEndereco("Rua do Camaro");
        a.atendimentoEficaz.setDuracaoMeses(12);
        a.atendimentoEficaz.setQtdProfessores(10);
        a.patrao.setIdade(22);
        a.patrao.setNome("Mariano");
        a.setIdade(32);
        a.setMatricula("1234");
        a.setNome("Babada");
        a.setSalario(12500);
        a.setSexo("Masculino");
        a.comissao();
        a.inss();
        
        System.out.println("Atendente\n{\n Endereço: "+a.getEndereco()+"\n Duração: "+a.atendimentoEficaz.getDuracaoMeses()
        +"\n Quantidada de Professores: "+a.atendimentoEficaz.getQtdProfessores()+"\n Partrão: "+a.patrao.getNome()+
        " Idade: "+a.patrao.getIdade()+"\n Idade: "+a.getIdade()+"\n Matricula: "+a.getMatricula()+"\n Nome: "+a.getNome()
        +"\n Salario: "+a.getSalario()+"\n Sexo: "+a.getSexo()+"\n Comissão: "+a.comissao()+"\n INSS: "+a.inss()+"\n}");
        
        
        Vendedor v = new Vendedor();
        v.setNome("Rafa");
        v.setEndereco("Rua do Camarino");
        v.setMatricula("1254");
        v.setSalario(4500);
        v.setSetor("15");
        v.comissao();
        v.inss();
        v.qualidade.setTurno("Matutino");
        v.patrao.setIdade(45);
        v.patrao.setNome("Masada");
        
        
        System.out.println("\n Vendedor\n{\n Endereço: "+v.getEndereco()+"\n Turno: "+v.qualidade.getTurno()
        +"\n Partrão: "+v.patrao.getNome()+"\n Setor: "+v.getSetor()+
        " Idade: "+v.patrao.getIdade()+"\n Matricula: "+v.getMatricula()+"\n Nome: "+v.getNome()
        +"\n Salario: "+v.getSalario()+"\n Comissão: "+v.comissao()+"\n INSS: "+v.inss()+"\n}");
        
        Patrao p = new Patrao();
        p.empresa.setCNPJ("");
        p.empresa.setNome("CocaColi");
        p.setIdade(34);
        p.setNome("Zé Droguina");
        
        System.out.println("\n Empresa \n{\nCNPJ: "+p.empresa.getCNPJ()+"\n Nome: "+p.empresa.getNome()+"\n Patrão: "
        +p.getNome()+"\n Idade: "+p.getIdade()+"\n}");
        
        QualidadeTotal qt = new QualidadeTotal();
        qt.setCodigo(457);
        qt.setNome("Javinha");
        qt.setQtdAula(50);
        qt.setTurno("Matutino");
        qt.setValorHoraAula(100);
        qt.professor.setMatricula("8456");
        qt.professor.setNome("Javão");
        
        System.out.println("\nCurso: "+qt.getNome()+"\nCódigo: "+qt.getCodigo()+"\nQuantidade de auals: "+qt.getQtdAula()
        +"\nTurno: "+qt.getTurno()+"\nValor Hora<aula>: "+qt.getValorHoraAula()+"\nProfessor: "+qt.professor.getNome()
        +"\nCódigo: "+qt.professor.getMatricula());
    }
    
}
