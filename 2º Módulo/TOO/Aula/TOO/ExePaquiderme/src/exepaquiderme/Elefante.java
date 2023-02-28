/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exepaquiderme;

import javax.swing.JOptionPane;

/**
 *
 * @author Aluno
 */
public class Elefante {

    public float getTamanhoPresa() {
        return tamanhoPresa;
    }

    public void setTamanhoPresa(float tamanhoPresa) {
        this.tamanhoPresa = tamanhoPresa;
    }

    public float getAlcanceBramido() {
        return alcanceBramido;
    }

    public void setAlcanceBramido(float alcanceBramido) {
        this.alcanceBramido = alcanceBramido;
    }

    public float getAlcanceChilro() {
        return alcanceChilro;
    }

    public void setAlcanceChilro(float alcanceChilro) {
        this.alcanceChilro = alcanceChilro;
    }

    public float getTamanhoTromba() {
        return tamanhoTromba;
    }

    public void setTamanhoTromba(float tamanhoTromba) {
        this.tamanhoTromba = tamanhoTromba;
    }

    public float getEspessuraTromba() {
        return espessuraTromba;
    }

    public void setEspessuraTromba(float espessuraTromba) {
        this.espessuraTromba = espessuraTromba;
    }
    private float tamanhoPresa;
    private float alcanceBramido;
    private float alcanceChilro;
    private float tamanhoTromba;
    private float espessuraTromba;

    @Override
    public String toString() {
        return "Elefante{" + "tamanhoPresa=" + tamanhoPresa + ", alcanceBramido=" + alcanceBramido + ", alcanceChilro=" + alcanceChilro + ", tamanhoTromba=" + tamanhoTromba + ", espessuraTromba=" + espessuraTromba + '}';
    }
    
    public void bramir(){
        JOptionPane.showMessageDialog(null, "O elefante está bramindo...");
    }
    
    public void chilrar(){
        JOptionPane.showMessageDialog(null, "O elefante está chilrando...");
    }
    
    public void atacarComPresa(){
        JOptionPane.showMessageDialog(null, "O elefante está atacando com sua presa!!!!!!!");
    }
}
