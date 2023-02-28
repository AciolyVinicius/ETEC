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
public class Cachorro extends Animal {
    public String late(){
        String late = "O cachorro está latindo";
        return late;
    }

    @Override
    public String toString() {
        return "Cachorro {\n{ " + "Nome = " + super.getNome() + ", Raça = "+ super.getRaca()+" }";
    }
}
