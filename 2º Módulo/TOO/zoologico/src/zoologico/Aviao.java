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
public class Aviao {
    private float tamanho;
    private double peso;
    private String cor;
    private String material;
    private String asas;
    private String trempouso;
    
    public float getTamanho(){
        return tamanho; 
    }
    public String getCor(){
        return cor; 
    }
    public double getPeso(){
        return peso; 
    }
    public String getMaterial(){
        return material; 
    }
    public String getAsas(){
        return asas; 
    }
    public String getTrempouso(){
        return trempouso; 
    }
    
    public void setTamanho(float tamanho){
        this.tamanho = tamanho;
    }
    public void setCor(String cor){
        this.cor = cor;
    }
    public void setPeso(double peso){
        this.peso = peso;
    }
    public void setMaterial(String material){
        this.material = material;
    }
    public void setAsas(String asas){
        this.asas = asas;
    }
    public void setTrempouso(String trempouso){
        this.trempouso = trempouso;
    }
}
