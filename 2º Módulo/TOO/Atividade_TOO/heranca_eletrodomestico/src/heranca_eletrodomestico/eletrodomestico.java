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
public class eletrodomestico {
    private int numeroSerie;
    private int peso;
    private String marca;
    private String nome;

    public int getNumeroSerie() {
        return numeroSerie;
    }

    public void setNumeroSerie(int numeroSerie) {
        this.numeroSerie = numeroSerie;
    }

    public int getPeso() {
        return peso;
    }

    public void setPeso(int peso) {
        this.peso = peso;
    }

    public String getMarca() {
        return marca;
    }

    public void setMarca(String marca) {
        this.marca = marca;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    @Override
    public String toString() {
        return "eletrodomestico{" + "numeroSerie=" + numeroSerie + ", peso=" + peso + ", marca=" + marca + ", nome=" + nome + '}';
    }
    
    
}
