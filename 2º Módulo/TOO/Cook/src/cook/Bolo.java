/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cook;

/**
 *
 * @author Aluno
 */
public class Bolo {
    private String sabor;
    private String formato;
    private String cobertura;
    private String recheio;
    private int camadas;
    private float tamanho;

    public String getSabor() {
        return sabor;
    }
    public void setSabor(String sabor) {
        this.sabor = sabor;
    }
    public String getFormato() {
        return formato;
    }
    public void setFormato(String formato) {
        this.formato = formato;
    }
    public String getCobertura() {
        return cobertura;
    }
    public void setCobertura(String cobertura) {
        this.cobertura = cobertura;
    }
    public String getRecheio() {
        return recheio;
    }
    public void setRecheio(String recheio) {
        this.recheio = recheio;
    }
    public int getCamadas() {
        return camadas;
    }
    public void setCamadas(int camadas) {
        this.camadas = camadas;
    }
    public float getTamanho() {
        return tamanho;
    }
    public void setTamanho(float tamanho) {
        this.tamanho = tamanho;
    }
}
