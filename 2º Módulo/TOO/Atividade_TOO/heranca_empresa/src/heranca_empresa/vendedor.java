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
public class vendedor extends empregado{
    private float comissao;
    private float valorVendas;

    public float getComissao() {
        return comissao;
    }

    public void setComissao(float comissao) {
        this.comissao = comissao;
    }

    public float getValorVendas() {
        return valorVendas;
    }

    public void setValorVendas(float valorVendas) {
        this.valorVendas = valorVendas;
    }

    @Override
    public String toString() {
        return "vendedor{" + "nome=" + super.getNome() + ", contribuinte=" + super.getContribuinte() + ", idade=" + super.getIdade() +  "numeroSeccao=" + super.getNumeroSeccao() + ", salarioBase=" + super.getSalarioBase() + "comissao=" + comissao + ", valorVendas= " + valorVendas + '}';
    }
    
    public float calcularSalario()
    {
        return 0;
    }
}
