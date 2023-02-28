/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package exercicio_03;

/**
 *
 * @author viníciusaciolyelias
 */
public class CamaroteSuperior extends VIP{
    private double vlAdd;
    double val = ValorVIP();
    
    public CamaroteSuperior() {
    }

    public double getVlAdd() {
        return vlAdd;
    }

    public void setVlAdd(double vlAdd) {
        this.vlAdd = vlAdd;
    }

    @Override
    public String toString() {
        double vl = getVlAdd() + val;
        return "Camarote Superio { " + "Valor R$ " + vl + " }";
    }
    
    
}
