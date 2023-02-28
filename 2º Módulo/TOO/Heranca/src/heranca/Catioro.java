/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package heranca;

/**
 *
 * @author Aluno
 */
public class Catioro extends Animal{
    
    private String raca;
    private String cor;

    public String getRaca() {
        return raca;
    }

    public void setRaca(String raca) {
        this.raca = raca;
    }

    public String getCor() {
        return cor;
    }

    public void setCor(String cor) {
        this.cor = cor;
    }

    @Override
    public String toString() {
        return "Catioro{" + "nome=" + super.getNome() + ", genero=" + super.getGenero() + 
                ", tamanho=" + super.getTam() + ", peso=" + super.getPeso() +
                ", raca=" + raca + ", cor=" + cor + '}';
    }
    
    
}
