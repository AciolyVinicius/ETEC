/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo_heranca_associacao;

/**
 *
 * @author Aluno
 */
public class Marca {
    private String descricao;
    public Pais pais = new Pais();
    
    public Pais getPais() {
        return pais;
    }

    public void setPais(Pais pais) {
        this.pais = pais;
    }
    
    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public Marca() {
    }
    

    @Override
    public String toString() {
        return "Marca \n {" + "Descrição = " + descricao + " }";
    }
    
    
}
