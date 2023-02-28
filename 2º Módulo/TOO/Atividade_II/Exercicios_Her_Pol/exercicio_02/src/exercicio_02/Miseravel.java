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
public class Miseravel extends Pessoa{    
    public void mendiga(){
        System.out.println(super.getNome()+" está mendigando");
    }

    @Override
    public String toString() {
        return "Miseravel{\n{ Nome = " + super.getNome()+", Idade em anos = "+super.getIdade()+" }";
    }
}
