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
public class Pais {
    private String nome;
    private String capital;
    
    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getCapital() {
        return capital;
    }

    public void setCapital(String capital) {
        this.capital = capital;
    }

    public Pais() {
    }

    @Override
    public String toString() {
        return "País \n { " + "Nome = " + nome + ", Capital = " + capital + " }";
    }
    
    
    
}
