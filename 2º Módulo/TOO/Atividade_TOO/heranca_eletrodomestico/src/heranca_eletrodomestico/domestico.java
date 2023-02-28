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
public class domestico extends fogao {
    private String tipo;

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    @Override
    public String toString() {
        return "domestico{" + "numeroSerie=" + super.getNumeroSerie() + ", peso=" + super.getPeso() + ", marca=" + super.getMarca() + ", nome=" + super.getNome() + "qtdBocas=" + super.getQtdBocas() + ", largura=" + super.getLargura()  + "tipo=" + tipo + '}';
    }
    
    
}
