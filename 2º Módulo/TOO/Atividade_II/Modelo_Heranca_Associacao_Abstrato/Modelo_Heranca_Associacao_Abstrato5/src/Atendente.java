/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author lobin
 */
public class Atendente extends Funcionario{
    private int idade;
    private String sexo;
    AtendimentoEficaz atendimentoEficaz = new AtendimentoEficaz();

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    public String getSexo() {
        return sexo;
    }

    public void setSexo(String sexo) {
        this.sexo = sexo;
    }
    
    public double comissao(){
        return (getSalario()*0.05);
    } 
    
    public double inss(){
        return (getSalario()*0.15);
    } 
    
}
