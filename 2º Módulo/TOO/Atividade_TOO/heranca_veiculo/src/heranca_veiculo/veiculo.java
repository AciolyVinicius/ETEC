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
public class veiculo {
    private int chassi;
    private int ano;

    public int getChassi() {
        return chassi;
    }

    public int getAno() {
        return ano;
    }

    public void setChassi(int chassi) {
        this.chassi = chassi;
    }

    public void setAno(int ano) {
        this.ano = ano;
    }

    @Override
    public String toString() {
        return "veiculo{" + "chassi=" + chassi + ", ano=" + ano + '}';
    }
    
    
}
