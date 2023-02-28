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
public class Hipopotamo extends Paquiderme{

    public float getTamanhoPresa() {
        return tamanhoPresa;
    }

    public void setTamanhoPresa(float tamanhoPresa) {
        this.tamanhoPresa = tamanhoPresa;
    }
    
    private float tamanhoPresa;
    
    public void marcarTerritorio(){
        JOptionPane.showMessageDialog(null, "Seu hipopótamo está marcando território");
    }
    
}
