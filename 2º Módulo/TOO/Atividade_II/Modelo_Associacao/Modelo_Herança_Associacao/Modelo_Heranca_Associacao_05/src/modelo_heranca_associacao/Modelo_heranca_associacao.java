/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo_heranca_associacao;

/**
 *
 * @author Aluno
 */
public class Modelo_heranca_associacao {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Moto moto = new Moto();
        moto.setAno(2015);
        moto.setCilindrada(1000);
        moto.modelo.setDescricao("YUGIHAAHRA");
        moto.modelo.marca.setDescricao("YAMANA");
        moto.modelo.marca.pais.setNome("Brazil");
        moto.modelo.marca.pais.setCapital("Brasília");
        moto.tipo.setDescricao("Super Potente");
        System.out.println(moto.toString()+"\n"+moto.modelo.toString()+"\n"+moto.modelo.marca.toString()+"\n"+moto.tipo.toString()+"\n"+moto.modelo.marca.pais.toString()+"\n"+"\n");
        
        Carro carro = new Carro();
        carro.setAno(2015);
        carro.setQtdPassageiros(5);
        carro.modelo.setDescricao("Altomático e com alto desempenho");
        carro.modelo.marca.setDescricao("Ronda");
        carro.modelo.marca.pais.setNome("Japão");
        carro.modelo.marca.pais.setCapital("Tóquio");
        System.out.println(carro.toString()+"\n"+carro.modelo.toString()+"\n"+carro.modelo.marca.toString()+"\n"+carro.modelo.marca.pais.toString()+"\n"+"\n");
        
        Caminhao caminhao = new Caminhao();
        caminhao.setAno(2017);
        caminhao.setQtdEixos(10);
        caminhao.modelo.setDescricao("Mercedes-Benz");
        caminhao.modelo.marca.setDescricao("MXV");
        caminhao.modelo.marca.pais.setNome("Estados Unidos");
        caminhao.modelo.marca.pais.setCapital("Washington DC");
        System.out.println(caminhao.toString()+"\n"+caminhao.modelo.toString()+"\n"+caminhao.modelo.marca.toString()+"\n"+caminhao.modelo.marca.pais.toString()+"\n"+"\n");
    }
    
}
