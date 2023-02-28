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
public class administrador extends empregado{
    private float ajudasDeCusto;

    public float getAjudasDeCusto() {
        return ajudasDeCusto;
    }

    public void setAjudasDeCusto(float ajudasDeCusto) {
        this.ajudasDeCusto = ajudasDeCusto;
    }

    @Override
    public String toString() {
        return "administrador{" + "nome=" + super.getNome() + ", contribuinte=" + super.getContribuinte() + ", idade=" + super.getIdade() +  "numeroSeccao=" + super.getNumeroSeccao() + ", salarioBase=" + super.getSalarioBase() + "ajudasDeCusto=" + ajudasDeCusto + '}';
    }
    
    public float calcularSalario()
    {
        return 0;
    }
}
