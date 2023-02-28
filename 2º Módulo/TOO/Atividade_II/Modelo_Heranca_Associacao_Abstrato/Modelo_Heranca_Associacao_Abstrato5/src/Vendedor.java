/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author lobin
 */
public class Vendedor extends Funcionario{
    private String setor;
    QualidadeTotal qualidade = new QualidadeTotal();

    public String getSetor() {
        return setor;
    }

    public void setSetor(String setor) {
        this.setor = setor;
    }
    
    public double comissao(){
        return (getSalario()*0.25);
    } 
    
    public double inss(){
        return (getSalario()*0.125);
    } 
    
}
