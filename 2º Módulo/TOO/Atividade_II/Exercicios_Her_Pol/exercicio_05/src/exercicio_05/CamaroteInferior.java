/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package exercicio_05;

/**
 *
 * @author viníciusaciolyelias
 */
public class CamaroteInferior extends VIP{
    private String localizacao;

    public CamaroteInferior() {
    }
    
    public String getLocalizacao() {
        return localizacao;
    }

    public void setLocalizacao(String localizacao) {
        this.localizacao = localizacao;
    }

    @Override
    public String toString() {
        return "Camarote Inferior { " + "localizacao = " + localizacao + " }";
    }
    
    
}
