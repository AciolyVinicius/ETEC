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
public class Disciplina {
    private String codigo;
    private String nome;
    private double cargahoraria;

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

    public double getCargahoraria() {
        return cargahoraria;
    }

    public void setCargahoraria(double cargahoraria) {
        this.cargahoraria = cargahoraria;
    }

    @Override
    public String toString() {
        return "Disciplina{" + "codigo=" + codigo + ", nome=" + nome + ", cargahoraria=" + cargahoraria + '}';
    }
    
    
}
