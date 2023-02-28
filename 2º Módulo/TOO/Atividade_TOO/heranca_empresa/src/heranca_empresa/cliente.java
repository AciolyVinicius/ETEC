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
public class cliente extends pessoa{
    private float plafond;
    private float valorEmDivida;

    public float getPlafond() {
        return plafond;
    }

    public void setPlafond(float plafond) {
        this.plafond = plafond;
    }

    public float getValorEmDivida() {
        return valorEmDivida;
    }

    public void setValorEmDivida(float valorEmDivida) {
        this.valorEmDivida = valorEmDivida;
    }

    @Override
    public String toString() {
        return "cliente{" + "nome=" + super.getNome() + ", contribuinte=" + super.getContribuinte() + ", idade=" + super.getIdade() +  "plafond=" + plafond + ", valorEmDivida=" + valorEmDivida + '}';
    }
    
    public float obterSaldo()
    {
        return 0;
    }
}
