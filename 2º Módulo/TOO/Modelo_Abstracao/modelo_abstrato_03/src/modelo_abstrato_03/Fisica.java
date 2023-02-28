/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo_abstrato_03;

/**
 *
 * @author Aluno
 */
public class Fisica extends Pessoa{
    private String CPF;
    private double salario;
    Cachorro cachorro = new Cachorro();
    
    @Override
    public double Desconto() {
        double desc = getSalario()+getSalario()*5/100;
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
    
    
}
