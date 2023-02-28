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
public class Forno {    
    private String marca;
    private String modelo;
    private float temperatura;
    private float volume;
    private float tamanho;
    private float tempo;
    private int botao;
    
    String assar(float temperatura, float tempo){
        String feito="O bolo está pronto! ";
        return feito;   
    }
    float controlarTemperatura(float temperatura){
       return temperatura;
    }
    float controlarTempo(float tempo){
       return tempo;
    }
    
    public String getMarca() {
        return marca;
    }
    public void setMarca(String marca) {
        this.marca = marca;
    }
    public String getModelo() {
        return modelo;
    }
    public void setModelo(String modelo) {
        this.modelo = modelo;
    }
    public float getTemperatura() {
        return temperatura;
    }
    public void setTemperatura(float temperatura) {
        this.temperatura = temperatura;
    }
    public float getVolume() {
        return volume;
    }
    public void setVolume(float volume) {
        this.volume = volume;
    }
    public int getBotao() {
        return botao;
    }
    public void setBotao(int botao) {
        this.botao = botao;
    }
    public float getTamanho() {
        return tamanho;
    }
    public void setTamanho(float tamanho) {
        this.tamanho = tamanho;
    }
}
