/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercicio_05;

/**
 *
 * @author Aluno
 */
public class Rica extends Pessoa{
    private double dinheiro;
    
    public double getDinheiro() {
        return dinheiro;
    }

    public void setDinheiro(double dinheiro) {
        this.dinheiro = dinheiro;
    }
    
    public void fazCompras(){
        System.out.println(super.getNome()+" está fazendo compras");
    }

    @Override
    public String toString() {
        return "Rica{\n{ Nome = " + super.getNome()+", Idade em anos = "+super.getIdade()+", Quantidade de dinheiro R$ "+dinheiro+" }";
    }
     
}
