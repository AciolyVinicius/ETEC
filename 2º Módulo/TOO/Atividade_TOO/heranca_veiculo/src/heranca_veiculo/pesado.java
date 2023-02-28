/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package heranca_veiculo;

/**
 *
 * @author Guilherme
 */
public class pesado extends veiculo{
    private String nome;
    private int capacidadeCarga;

    public String getNome() {
        return nome;
    }

    public int getCapacidadeCarga() {
        return capacidadeCarga;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public void setCapacidadeCarga(int capacidadeCarga) {
        this.capacidadeCarga = capacidadeCarga;
    }

    @Override
    public String toString() {
        return "pesado{" + "chassi=" + super.getChassi() + ", ano=" + super.getAno() + "nome=" + nome + ", capacidadeCarga=" + capacidadeCarga + '}';
    }
    
    
}
