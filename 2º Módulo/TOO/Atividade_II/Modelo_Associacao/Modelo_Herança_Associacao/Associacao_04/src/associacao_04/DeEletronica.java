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
public class DeEletronica extends Curso{
    private int qtddisciplina;
    public Coordenador coordenador = new Coordenador();

    public int getQtddisciplina() {
        return qtddisciplina;
    }

    public void setQtddisciplina(int qtddisciplina) {
        this.qtddisciplina = qtddisciplina;
    }

    public Coordenador getCoordenador() {
        return coordenador;
    }

    public void setCoordenador(Coordenador coordenador) {
        this.coordenador = coordenador;
    }

    @Override
    public String toString() {
        return "DeEletronica{" + "qtddisciplina=" + qtddisciplina + ", coordenador=" + coordenador + '}';
    }
    
}
