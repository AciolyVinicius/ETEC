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
public class Assistente extends Funcionario{
    Funcionario func = new Funcionario();
    
    @Override
    public String toString() {
        return "Assistente{ \n" +  func.toString() +"\n}";
    }
    
}
