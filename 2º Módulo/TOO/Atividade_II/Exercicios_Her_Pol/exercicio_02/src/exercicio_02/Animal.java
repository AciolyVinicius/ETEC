/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercicio_02;

/**
 *
 * @author Aluno
 */
public class Animal {
    private String nome;
    private String raca;
    
    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getRaca() {
        return raca;
    }

    public void setRaca(String raca) {
        this.raca = raca;
    }

    public String Animal(String nome) {
        System.out.println(nome);
        return nome;
    }
    
    public String caminha (){
        String caminha = "Está caminhando";
        return caminha;
    }
    
    @Override
    public String toString() {
        return "Animal{" + "nome=" + nome + ", raca=" + raca + '}';
    }    
}
