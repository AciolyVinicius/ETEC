/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Aluno
 */
public class DePasseio extends Veiculo{
    private String marca;
    private String descricao;
    Montadora montadora = new Montadora();

    public String getMarca() {
        return marca;
    }

    public void setMarca(String marca) {
        this.marca = marca;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }
    
    public double IPVA(){
        return (getPreco()*0.03);
    }
    
    public double seguro(){
        return (getPreco()*0.015);
    }

    @Override
    public String toString() {
        return "DePasseio{" + "marca=" + marca + ", descricao=" + descricao + ", montadora=" + montadora + '}';
    }

}
