/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package polimorfismo;

/**
 *
 * @author Aluno
 */
public class Polimorfismo {

    /**
     * @param args the command line arguments
     */
    public static class Test{
        public void fazerAnimalComer(Animal animal){
            animal.comer();
        }
    }
    public static void main(String[] args) {
        Test t = new Test();
        t.fazerAnimalComer(new Animal());
        t.fazerAnimalComer(new Cao());
        t.fazerAnimalComer(new Tigre());
    }
    
}

