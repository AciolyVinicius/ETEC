/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package associacao_04;

/**
 *
 * @author Aluno
 */
public class DeInformatica extends Curso{
    private int duracao;

    public int getDuracao() {
        return duracao;
    }

    public void setDuracao(int duracao) {
        this.duracao = duracao;
    }

    @Override
    public String toString() {
        return "DeInformatica{" + "duracao=" + duracao + '}';
    }
    
    
}
