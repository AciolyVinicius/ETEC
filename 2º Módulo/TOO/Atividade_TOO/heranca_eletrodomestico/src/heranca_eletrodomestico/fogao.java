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
public class fogao extends eletrodomestico {
    private int qtdBocas;
    private double largura;

    public int getQtdBocas() {
        return qtdBocas;
    }

    public void setQtdBocas(int qtdBocas) {
        this.qtdBocas = qtdBocas;
    }

    public double getLargura() {
        return largura;
    }

    public void setLargura(double largura) {
        this.largura = largura;
    }

    @Override
    public String toString() {
        return "fogao{" + "numeroSerie=" + super.getNumeroSerie() + ", peso=" + super.getPeso() + ", marca=" + super.getMarca() + ", nome=" + super.getNome() + "qtdBocas=" + qtdBocas + ", largura=" + largura + '}';
    }
    
    
}
