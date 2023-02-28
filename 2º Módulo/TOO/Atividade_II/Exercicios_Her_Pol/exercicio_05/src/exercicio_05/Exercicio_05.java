/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package exercicio_05;

import javax.swing.JOptionPane;

/**
 *
 * @author viníciusaciolyelias
 */
public class Exercicio_05 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        //-a
        Tecnico tec = new Tecnico();
        tec.setBonussal(10);
        tec.assistente.func.setMatricula(150);
        System.out.println("-a \n"+tec.toString());
        
        Administrativo adm = new Administrativo();
        adm.setTurno("Noite");
        adm.setAdnoturno(15.5);
        adm.assistente.func.setMatricula(502);
        System.out.println(adm.toString()+"\n");
        
        //-b
        Cachorro c = new Cachorro();
        c.setNome("Marley");
        c.setRaca("Vira Ouro");
        System.out.println("-b \n"+c.toString()+"\n" +c.late()+"\n & \n"+ c.caminha()+"\n}\n ");
        
        Gato g = new Gato();
        g.setNome("Nina");
        g.setRaca("Qualquer");
        System.out.println(g.toString()+"\n"+g.mia()+ "\n & \n"+ g.caminha()+"\n}\n ");
        
        //-c
        Pobre p = new Pobre();
        p.setIdade(23);
        p.setNome("Drigo");
        System.out.println("-c");        
        System.out.println(p.toString());
        p.trabalha();
        System.out.println("}");
        
        Miseravel m = new Miseravel();
        m.setIdade(37);
        m.setNome("Brogada");
        System.out.println(m.toString());
        m.mendiga();
        System.out.println("}");
        
        Rica r = new Rica();
        r.setIdade(27);
        r.setNome("Juadi");
        r.setDinheiro(10000);
        System.out.println(r.toString());
        r.fazCompras();
        System.out.println("}\n\n-d");
        
        //-d
        Ingresso i = new Ingresso();
        i.setValor(100);
        i.ImprimeValor();
        int ff, k;
        do{
        k = 0;
        ff = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite: 1 para Ingresso Normal ou 2 para ingresso VIP"));
        if(ff==1){
            Normal n = new Normal();
            n.setValor(i.getValor());
            n.Normal();
        }
        else if(ff==2){
            VIP v = new VIP();
            v.setValorAdd(100.55);
            v.Valor();
            ff = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite: 1 para Camarote Inferior ou 2 para Camarote Superior"));
            if (ff==1){
                CamaroteInferior ci = new CamaroteInferior();
                ci.setLocalizacao("Ao lado do som");
                System.out.println(ci.toString()+"\n\n-e");
            }
            else{
                CamaroteSuperior cs = new CamaroteSuperior();
                cs.setVlAdd(50);
                System.out.println(cs.toString()+"\n\n-e");
            }
        }
        else{
            JOptionPane.showMessageDialog(null, "Dígito inválido!");
            k = 1;
        }
        }while(k==1);
        
        //-e
        ff = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite: 1 para Imóvel Novo ou 2 para Imóvel velho"));
        int lll;
        do{
        lll = 0;
        if(ff==1){
        Novo n = new Novo();
        n.setPreco(320);
        n.setEndereco("Rua João Banalho 2");
        n.setAcrescimo(120);
        System.out.println(n.toString()+n.Valor());
        }
        else if(2==ff)
        {
            Velho v = new Velho ();
            v.setPreco(250);
            v.setEndereco("Rua Benedito 287");
            v.setDesconto(50);
            System.out.println(v.toString()+v.Valor());
        
        }
        else{
            lll = 1;
        }
        }while(lll == 1);
    }
    
}
