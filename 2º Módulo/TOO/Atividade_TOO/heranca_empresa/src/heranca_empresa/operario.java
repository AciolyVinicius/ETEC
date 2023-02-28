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
public class operario extends empregado {
    private float comissao;
    private float valorProducao;

    public float getComissao() {
        return comissao;
    }

    public void setComissao(float comissao) {
        this.comissao = comissao;
    }

    public float getValorProducao() {
        return valorProducao;
    }

    public void setValorProducao(float valorProducao) {
        this.valorProducao = valorProducao;
    }

    @Override
    public String toString() {
        return "operario{" + "nome=" + super.getNome() + ", contribuinte=" + super.getContribuinte() + ", idade=" + super.getIdade() +  "numeroSeccao=" + super.getNumeroSeccao() + ", salarioBase=" + super.getSalarioBase() + "comissao=" + comissao + ", valorProducao=" + valorProducao + '}';
    }
    
    public float calcularSalario()
    {
        return 0;
    }
}
