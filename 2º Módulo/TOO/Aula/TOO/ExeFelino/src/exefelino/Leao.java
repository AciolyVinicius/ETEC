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
public class Leao extends Felino {

    public float getJuba() {
        return juba;
    }

    public void setJuba(float juba) {
        this.juba = juba;
    }
    
    private float juba;
    
    public void rugir(){
        JOptionPane.showMessageDialog(null, "O leão ruge... x-x");
    }
}
