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
public class Rinoceronte {
    
    private float tamanhoChifreMaior;
    private int qtdChifre;
    
    public float getTamanhoChifreMaior() {
        return tamanhoChifreMaior;
    }

    public void setTamanhoChifreMaior(float tamanhoChifreMaior) {
        this.tamanhoChifreMaior = tamanhoChifreMaior;
    }

    public int getQtdChifre() {
        return qtdChifre;
    }

    public void setQtdChifre(int qtdChifre) {
        this.qtdChifre = qtdChifre;
    }

    private void atacarComChifre(){
        JOptionPane.showMessageDialog(null,"O rinoceronte está atacando com sua presa! KEEP CALM!!!!!");
    }
}
