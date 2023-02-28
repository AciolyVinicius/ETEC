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
public class Pobre extends Pessoa{
    
    public void trabalha (){
        System.out.println(super.getNome()+" pessoa está trabalhando");
    }

    @Override
    public String toString() {
        return "Pobre{\n{ Nome = " + super.getNome()+", Idade em anos = "+super.getIdade()+" }";
    }
}
