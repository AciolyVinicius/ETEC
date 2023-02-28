/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package heranca_empresa;

/**
 *
 * @author Guilherme
 */
public class empregado extends pessoa {
    private int numeroSeccao;
    private float salarioBase;
    private float IRS;

    public float getIRS() {
        return IRS;
    }

    public void setIRS(float IRS) {
        this.IRS = IRS;
    }

    public int getNumeroSeccao() {
        return numeroSeccao;
    }

    public void setNumeroSeccao(int numeroSeccao) {
        this.numeroSeccao = numeroSeccao;
    }

    public float getSalarioBase() {
        return salarioBase;
    }

    public void setSalarioBase(float salarioBase) {
        this.salarioBase = salarioBase;
    }

    @Override
    public String toString() {
        return "empregado{" +"iRS= "+ IRS + "nome= " + super.getNome() + ", contribuinte=" + super.getContribuinte() + ", idade=" + super.getIdade() +  "numeroSeccao=" + numeroSeccao + ", salarioBase=" + salarioBase + '}';
    }
    
    public float calcularSalario()
    {
        return 0;
    }
    
}
