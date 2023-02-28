/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package heranca_eletrodomestico;

/**
 *
 * @author Guilherme
 */
public class industrial extends fogao{
    private double profundidade;

    public double getProfundidade() {
        return profundidade;
    }

    public void setProfundidade(double profundidade) {
        this.profundidade = profundidade;
    }

    @Override
    public String toString() {
        return "industrial{" + "numeroSerie=" + super.getNumeroSerie() + ", peso=" + super.getPeso() + ", marca=" + super.getMarca() + ", nome=" + super.getNome() + "qtdBocas=" + super.getQtdBocas() + ", largura=" + super.getLargura()  + "profundidade=" + profundidade + '}';
    }
    
    
}
