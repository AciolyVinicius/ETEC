/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo_associacao_ii;

/**
 *
 * @author Aluno
 */
public class Proprietario{
    public String getNomeDoProprietario() {
        return nomeDoProprietario;
    }

    public void setNomeDoProprietario(String nomeDoProprietario) {
        this.nomeDoProprietario = nomeDoProprietario;
    }

    public String getEndereco() {
        return endereco;
    }

    public void setEndereco(String endereco) {
        this.endereco = endereco;
    }
    
    private String nomeDoProprietario;
    private String endereco;
    public Filiacao filiacao = new Filiacao ();
    
    @Override
    public String toString() {
        return "\n Proprietario {" + "nomeDoProprietario=" + nomeDoProprietario + ", endereco=" + endereco + " };";
    }
}
