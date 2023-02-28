/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exeequidna;

import javax.swing.JOptionPane;

/**
 *
 * @author Aluno
 */
public class Animal {
   private String nome;
    private float peso;
    private boolean sexo;
    private float tamanho;
    private String especie;
    private int idade;
    private String alimentacao;
    private String cor;
    private int idadeMaximaEspeculada;
    private String habitat;

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public float getPeso() {
        return peso;
    }

    public void setPeso(float peso) {
        this.peso = peso;
    }

    public boolean isSexo() {
        return sexo;
    }

    public void setSexo(boolean sexo) {
        this.sexo = sexo;
    }

    public float getTamanho() {
        return tamanho;
    }

    public void setTamanho(float tamanho) {
        this.tamanho = tamanho;
    }

    public String getEspecie() {
        return especie;
    }

    public void setEspecie(String especie) {
        this.especie = especie;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    public String getAlimentacao() {
        return alimentacao;
    }

    public void setAlimentacao(String alimentacao) {
        this.alimentacao = alimentacao;
    }

    public String getCor() {
        return cor;
    }

    public void setCor(String cor) {
        this.cor = cor;
    }

    public int getIdadeMaximaEspeculada() {
        return idadeMaximaEspeculada;
    }

    public void setIdadeMaximaEspeculada(int idadeMaximaEspeculada) {
        this.idadeMaximaEspeculada = idadeMaximaEspeculada;
    }

    public String getHabitat() {
        return habitat;
    }

    public void setHabitat(String habitat) {
        this.habitat = habitat;
    }
    
    public void defecar(){
       JOptionPane.showMessageDialog(null, "Seu animalzinho está defecando..."); 
    }
    public void comer() throws InterruptedException{
        JOptionPane.showMessageDialog(null, "Seu animalzinho está comendo...");
        Thread.sleep(10);
        defecar();
    }
    public void reproduzir(){
       JOptionPane.showMessageDialog(null, "Seu animalzinho está reproduzindo... você vai ter outro animalzinho! "); 
    }
}
