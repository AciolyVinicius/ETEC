/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package exercicio_04;

/**
 *
 * @author viníciusaciolyelias
 */
public class Imovel {
    private String endereco;
    private double preco;

    public String getEndereco() {
        return endereco;
    }

    public void setEndereco(String endereco) {
        this.endereco = endereco;
    }

    public double getPreco() {
        return preco;
    }

    public void setPreco(double preco) {
        this.preco = preco;
    }

    @Override
    public String toString() {
        return "Imovel{" + "endereco=" + endereco + ", preco=" + preco + '}';
    }
}
