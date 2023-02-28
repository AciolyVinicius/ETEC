/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package heranca;

/**
 *
 * @author Aluno
 */
public class Animal {
    //Encapsulamento - proteger os atributos, colocando-os como private e gerar getters e setter
    private String nome;
    private String genero;
    private float tam;
    private float peso;

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getGenero() {
        return genero;
    }

    public void setGenero(String genero) {
        this.genero = genero;
    }

    public float getTam() {
        return tam;
    }

    public void setTam(float tam) {
        this.tam = tam;
    }

    public float getPeso() {
        return peso;
    }

    public void setPeso(float peso) {
        this.peso = peso;
    }
    
    
}
