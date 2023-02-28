/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo_abstrato_02;

/**
 *
 * @author Aluno
 */
public class Fisica extends Pessoa{
    private String CPF;
    private double salario;

    @Override
    public double Desconto() {
        double desc = getSalario()-getSalario()*5/100;
        return desc;
    }

    public String getCPF() {
        return CPF;
    }

    public void setCPF(String CPF) {
        this.CPF = CPF;
    }

    public double getSalario() {
        return salario;
    }

    public void setSalario(double salario) {
        this.salario = salario;
    }

    public Fisica() {
    }

    @Override
    public String toString() {
        return "Pessoa Fisica\n" +  "Nome = "+ super.getNome()+"\nCPF = " + CPF + "\nSalario = R$ " + salario +"\nTelefone = ("+super.telefone.getDdd()+")"+super.telefone.getNumero();
    }
    
    
}
