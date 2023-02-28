/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Classes;

/**
 *
 * @author Pedro
 */
public class Bicicleta extends Veiculo{
    String marca;
    String modelo;
    int aro;

    public Bicicleta(int parseInt) {
        
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

    public int getAro() {
        return aro;
    }

    public void setAro(int aro) {
        this.aro = aro;
    }
    
    //Métodos 
    public String ajusteCorrente(){
        return "Ajuste da corrente realizado";
    }
    
    public String trocaSelim(){
        return "Troca do Selim realizada";
    }
    
    public String concertoCamera(){
        return "Concerto da câmera realizada";
    }
    
    public String reparoFreios(){
        return "Reparo de freios realizado";
    }
}
