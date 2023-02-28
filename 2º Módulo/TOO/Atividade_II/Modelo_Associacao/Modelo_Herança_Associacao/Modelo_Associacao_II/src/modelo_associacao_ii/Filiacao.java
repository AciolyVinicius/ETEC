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
public class Filiacao {
    public String getNomeDoPai() {
        return nomeDoPai;
    }

    public void setNomeDoPai(String nomeDoPai) {
        this.nomeDoPai = nomeDoPai;
    }

    public String getNomeDaMae() {
        return nomeDaMae;
    }

    public void setNomeDaMae(String nomeDaMae) {
        this.nomeDaMae = nomeDaMae;
    }
    
    private String nomeDoPai;
    private String nomeDaMae;

    @Override
    public String toString() {
        return "\n Filiacao {" + "nomeDoPai=" + nomeDoPai + ", nomeDaMae=" + nomeDaMae + "};";
    }
}
