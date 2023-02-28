/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercicio_05;

/**
 *
 * @author Aluno
 */
public class Administrativo {
    private String turno;
    private double adnoturno;
    Assistente assistente = new Assistente();
        
    public String getTurno() {
        return turno;
    }

    public void setTurno(String turno) {
        this.turno = turno;
    }

    public double getAdnoturno() {
        return adnoturno;
    }

    public void setAdnoturno(double adnoturno) {
        this.adnoturno = adnoturno;
    }

    @Override
    public String toString() {
        return "Administrativo { \n{ " + "Turno = "  + turno + ", Adicional = " + adnoturno + " } \n{"+assistente.toString()+"\n"+ " }";
    }
    
    
}
