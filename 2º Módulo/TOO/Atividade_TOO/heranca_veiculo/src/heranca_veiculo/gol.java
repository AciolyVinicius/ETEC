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
public class gol extends leve {
    private String marca;
    private double kmRodados;
    private int qtdPassageiros;

    public String getMarca() {
        return marca;
    }

    public void setMarca(String marca) {
        this.marca = marca;
    }

    public double getKmRodados() {
        return kmRodados;
    }

    public void setKmRodados(double kmRodados) {
        this.kmRodados = kmRodados;
    }

    public int getQtdPassageiros() {
        return qtdPassageiros;
    }

    public void setQtdPassageiros(int qtdPassageiros) {
        this.qtdPassageiros = qtdPassageiros;
    }

    @Override
    public String toString() {
        return "gol{" + "chassi=" + super.getChassi() + ", ano=" + super.getAno() + "qtdPortas=" + super.getQtdPortas() + "marca=" + marca + ", kmRodados=" + kmRodados + ", qtdPassageiros=" + qtdPassageiros + '}';
    }
    
    
}
