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
public class televisao extends eletrodomestico {
    private int polegadas;
    private String tipo;

    public int getPolegadas() {
        return polegadas;
    }

    public void setPolegadas(int polegadas) {
        this.polegadas = polegadas;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    @Override
    public String toString() {
        return "televisao{" +  "numeroSerie=" + super.getNumeroSerie() + ", peso=" + super.getPeso() + ", marca=" + super.getMarca() + ", nome=" + super.getNome() +"polegadas=" + polegadas + ", tipo=" + tipo + '}';
    }
    
    
}
