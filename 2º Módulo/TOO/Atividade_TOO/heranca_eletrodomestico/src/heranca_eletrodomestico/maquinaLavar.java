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
public class maquinaLavar extends eletrodomestico {
    private String tipo;
    private String cor;

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public String getCor() {
        return cor;
    }

    public void setCor(String cor) {
        this.cor = cor;
    }

    @Override
    public String toString() {
        return "maquinaLavar{"+ "numeroSerie=" + super.getNumeroSerie() + ", peso=" + super.getPeso() + ", marca=" + super.getMarca() + ", nome=" + super.getNome() + "tipo=" + tipo + ", cor=" + cor + '}';
    }
    
    
}
