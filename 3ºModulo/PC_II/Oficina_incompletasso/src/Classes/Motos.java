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
public class Motos extends Veiculo{
    String marca;
    String modelo;
    int cilindradas;

    public Motos(int parseInt) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
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

    public int getCilindradas() {
        return cilindradas;
    }

    public void setCilindradas(int cilindradas) {
        this.cilindradas = cilindradas;
    }
    
    
    //Métodos da classe 
    public String trocaOleo(){
        return "Troca de óleo realizada";
    }
    
    public String balanceamento(){
        return "Balanceamento realizado";
    }
    
    public String ajusteMotor(){
        return "Ajuste do motor realizado";
    }
    
    public String ajusteCorrente(){
        return "Ajuste da corrente realizado";
    }
}
