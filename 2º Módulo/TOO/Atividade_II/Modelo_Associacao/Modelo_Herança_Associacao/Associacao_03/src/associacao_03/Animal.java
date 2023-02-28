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
public class Animal {
    private String codigo;
    public Proprietario proprietario = new Proprietario();

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    public Proprietario getProprietario() {
        return proprietario;
    }

    public void setProprietario(Proprietario proprietario) {
        this.proprietario = proprietario;
    }

    @Override
    public String toString() {
        return "Animal{" + "codigo=" + codigo + ", proprietario=" + proprietario + '}';
    }
    
    
}
