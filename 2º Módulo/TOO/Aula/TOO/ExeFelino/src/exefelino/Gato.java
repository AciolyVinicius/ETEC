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
public class Gato extends Felino {
    
    private String raca;

    /**
     * @return the raca
     */
    public String getRaca() {
        return raca;
    }

    /**
     * @param raca the raca to set
     */
    public void setRaca(String raca) {
        this.raca = raca;
    }
    
    public void rosrosnar(){
        JOptionPane.showMessageDialog(null, "O gato está rosrosnando...  *-* ");
    }
}
