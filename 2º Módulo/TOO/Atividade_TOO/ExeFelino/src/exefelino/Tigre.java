/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exefelino;

import javax.swing.JOptionPane;

/**
 *
 * @author Aluno
 */
public class Tigre extends Felino {
    
    private String especie;
    
    public String getEspecie() {
        return especie;
    }

    public void setEspecie(String especie) {
        this.especie = especie;
    }
    
    public void nadar(){
        JOptionPane.showMessageDialog(null, "O tigre está nadando... ^-^");
    }
}
