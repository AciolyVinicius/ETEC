/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package associacao_04;

/**
 *
 * @author Aluno
 */
public class Associacao_04 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        DeInformatica i = new DeInformatica();
        i.setDuracao(2);
        i.setCodigo(0101);
        i.setNome("Informática");
        System.out.println(i.toString()+"\n");
        
        DeTelecom t = new DeTelecom();
        t.setCoordenador("Jailson");
        t.setCodigo(0111);
        t.setNome("Telecom");
        System.out.println(t.toString()+"\n");
        
        DeEletronica e = new DeEletronica();
        e.setQtddisciplina(5);
        e.setCodigo(1101);
        e.setNome("Eletronica");
        e.coordenador.setNome("Fael");
        e.coordenador.setEndereco("Rua Janivundo Dosreal, nº385");
        System.out.println(e.toString()+"\n"+e.coordenador.toString()+"\n");
        
        Curso c = new Curso();
        c.aluno.professor.setMatr("Eletrica");
        c.aluno.professor.setNome("Gelado");
        c.aluno.setMatr("Eletrica");
        c.aluno.setNome("Senhor Incrível");
        c.setCodigo(2012);
        c.setNome("Eletricidade");
        c.disciplina.setCargahoraria(200);
        c.disciplina.setNome("Ética");
        c.disciplina.setCodigo("240-afi");
        System.out.println(c.aluno.professor.toString()+"\n"+c.aluno.toString()+"\n"+c.toString());
        
    }
    
}
