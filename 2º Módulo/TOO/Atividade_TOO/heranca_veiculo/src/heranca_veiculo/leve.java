/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package heranca_veiculo;

/**
 *
 * @author Guilherme
 */
public class leve extends veiculo {
    private int qtdPortas;

    public int getQtdPortas() {
        return qtdPortas;
    }

    public void setQtdPortas(int qtdPortas) {
        this.qtdPortas = qtdPortas;
    }

    @Override
    public String toString() {
        return "leve{" +"chassi=" + super.getChassi() + ", ano=" + super.getAno() + "qtdPortas=" + qtdPortas + '}';
    }
    
    
}
