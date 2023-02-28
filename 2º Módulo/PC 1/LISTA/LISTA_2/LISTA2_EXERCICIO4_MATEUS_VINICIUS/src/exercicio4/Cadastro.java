/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercicio4;

/**
 *
 * @author Aluno
 */
public class Cadastro {
    private int cd, ano, mes, dia, fracionamento, quantidade;
    private double valor;
    private String descricao;

    public Cadastro(int cd, int ano, int mes, int dia, int fracionamento, int quantidade, double valor, String descricao) {
        this.cd = cd;
        this.ano = ano;
        this.mes = mes;
        this.dia = dia;
        this.fracionamento = fracionamento;
        this.quantidade = quantidade;
        this.valor = valor;
        this.descricao = descricao;
    }
    
    public int getCd() {
        return cd;
    }

    public void setCd(int cd) {
        this.cd = cd;
    }   
    
    public int getAno() {
        return ano;
    }

    public void setAno(int ano) {
        this.ano = ano;
    }

    public int getMes() {
        return mes;
    }

    public void setMes(int mes) {
        this.mes = mes;
    }

    public int getDia() {
        return dia;
    }

    public void setDia(int dia) {
        this.dia = dia;
    }

    public int getFracionamento() {
        return fracionamento;
    }

    public void setFracionamento(int fracionamento) {
        this.fracionamento = fracionamento;
    }

    public int getQuantidade() {
        return quantidade;
    }

    public void setQuantidade(int quantidade) {
        this.quantidade = quantidade;
    }

    public double getValor() {
        return valor;
    }

    public void setValor(double valor) {
        this.valor = valor;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }
    
    
}
