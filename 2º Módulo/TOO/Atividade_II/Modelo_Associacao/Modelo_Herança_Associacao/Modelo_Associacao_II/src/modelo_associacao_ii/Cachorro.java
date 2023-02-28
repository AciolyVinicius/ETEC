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
public class Cachorro{
    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

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
    
    private String codigo;
    private String nome;
    private String raca;
    public Filiacao filiacao = new Filiacao ();
    public Proprietario proprietario = new Proprietario ();
    
    @Override
    public String toString() {
        return "\n Cachorro {" + "codigo=" + codigo + ", nome=" + nome + ", raca=" + raca + "};";
    }
}
