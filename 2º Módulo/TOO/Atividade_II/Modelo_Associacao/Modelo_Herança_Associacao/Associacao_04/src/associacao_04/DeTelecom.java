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
public class DeTelecom extends Curso{
    private String coordenador;

    public String getCoordenador() {
        return coordenador;
    }

    public void setCoordenador(String coordenador) {
        this.coordenador = coordenador;
    }

    @Override
    public String toString() {
        return "DeTelecom{" + "coordenador=" + coordenador + '}';
    }

    
    
    
}
