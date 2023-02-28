/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package zoologico;

/**
 *
 * @author Aluno
 */
public class Tigre {
    private String nome;
    private String cor;
    private double peso;
    private boolean genero;
    private int idade;
    private String raca;
    
    public String getNome(){
        return nome; 
    }
    public String getCor(){
        return cor; 
    }
    public double getPeso(){
        return peso; 
    }
    public boolean getGenero(){
        return genero; 
    }
    public int getIdade(){
        return idade; 
    }
    public String getRaca(){
        return raca; 
    }
    
    public void setNome(String nome){
        this.nome = nome;
    }
    public void setCor(String cor){
        this.cor = cor;
    }
    public void setPeso(double peso){
        this.peso = peso;
    }
    public void setGenero(boolean genero){
        this.genero = genero;
    }
    public void setIdade(int idade){
        this.idade = idade;
    }
    public void setRaca(String raca){
        this.raca = raca;
    }
}
