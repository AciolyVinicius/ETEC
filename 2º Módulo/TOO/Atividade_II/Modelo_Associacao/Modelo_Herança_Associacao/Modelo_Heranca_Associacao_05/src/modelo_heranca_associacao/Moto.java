/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo_heranca_associacao;

/**
 *
 * @author Aluno
 */
public class Moto extends Veiculo{
    private int cilindrada;
    public Tipo tipo = new Tipo ();

    public int getCilindrada() {
        return cilindrada;
    }

    public void setCilindrada(int cilindrada) {
        this.cilindrada = cilindrada;
    }

    public Tipo getTipo() {
        return tipo;
    }

    public void setTipo(Tipo tipo) {
        this.tipo = tipo;
    }

    public Moto() {
    }
    
    
    @Override
    public String toString() {
        return "Moto \n {" + "Cilindrada  = " + cilindrada +" }";
    }
    
    
}
