/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author lobin
 */
public abstract class Curso {
    private int codigo;
    private String nome;
    private double valorHoraAula;
    private int qtdAula;
    Professor professor = new Professor();

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public double getValorHoraAula() {
        return valorHoraAula;
    }

    public void setValorHoraAula(double valorHoraAula) {
        this.valorHoraAula = valorHoraAula;
    }

    public int getQtdAula() {
        return qtdAula;
    }

    public void setQtdAula(int qtdAula) {
        this.qtdAula = qtdAula;
    }
    
    public double comissao(){
        return (getQtdAula()*getValorHoraAula());
    } 
   
    
}
