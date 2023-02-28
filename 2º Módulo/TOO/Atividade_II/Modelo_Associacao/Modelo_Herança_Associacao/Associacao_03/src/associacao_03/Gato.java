/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package associacao_03;

/**
 *
 * @author Aluno
 */
public class Gato extends Animal{
    private String nome;
    private String tipopelo;

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getTipopelo() {
        return tipopelo;
    }

    public void setTipopelo(String tipopelo) {
        this.tipopelo = tipopelo;
    }

    @Override
    public String toString() {
        return "Gato{" + "nome=" + nome + ", tipopelo=" + tipopelo + '}';
    }
    
}
