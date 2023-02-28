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
public class Juridica extends Pessoa
{
    private String CNPJ;
    private double faturamento;

    public String getCNPJ() {
        return CNPJ;
    }

    public void setCNPJ(String CNPJ) {
        this.CNPJ = CNPJ;
    }

    public double getFaturamento() {
        return faturamento;
    }

    public void setFaturamento(double faturamento) {
        this.faturamento = faturamento;
    }

    public Juridica() {
    }

    @Override
    public double Desconto() {
        double desc = getFaturamento()+getFaturamento()*2/100;
        return desc;
    }    

    @Override
    public String toString() {
        return "Juridica\n" + "CNPJ = " + CNPJ + "\nFaturamento = R$ " + faturamento;
    }
    
}
