/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercicio_01;

/**
 *
 * @author Aluno
 */
public class Tecnico extends Assistente{
    private double bonussal;
    Assistente assistente = new Assistente();
    
    public double getBonussal() {
        return bonussal;
    }

    public void setBonussal(double bonussal) {
        this.bonussal = bonussal;
    }

    @Override
    public String toString() {
        return "Tecnico { \n { " + "Bônus no salário R$ " + bonussal +" } \n {"+ assistente.toString();
    }
    
    
}
