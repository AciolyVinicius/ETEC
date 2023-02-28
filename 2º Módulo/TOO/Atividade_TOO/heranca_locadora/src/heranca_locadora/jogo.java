/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package heranca_locadora;

/**
 *
 * @author Guilherme
 */
public class jogo extends item{
    private int memoria;
    private String tipo;

    public int getMemoria() {
        return memoria;
    }

    public void setMemoria(int memoria) {
        this.memoria = memoria;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    @Override
    public String toString() {
        return "jogo{" + "id=" + super.getId() + ", titulo=" + super.getTitulo() + ", Descricao=" + super.getDescricao() + ", preco=" + super.getPreco() + ", numeroDias=" + super.getNumeroDias() + ", categoria=" + super.getCategoria() + "memoria=" + memoria + ", tipo=" + tipo + '}';
    }
    
    
}
