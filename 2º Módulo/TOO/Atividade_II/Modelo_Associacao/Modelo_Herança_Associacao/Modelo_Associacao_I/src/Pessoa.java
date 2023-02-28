/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Aluno
 */
public class Pessoa {
    private String codigo;
    private String nome;
    private int idade;
    public Veiculo veiculo = new Veiculo();

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

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    @Override
    public String toString() {
        return " Pessoa \n {" + "codigo= " + codigo + ", nome= " + nome + ", idade= " + idade + "}" + veiculo ;
    }
    
}
