/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cook;

import javax.swing.JOptionPane;

/**
 *
 * @author Aluno
 */
public class Cook {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Bolo bolinho = new Bolo();
        bolinho.setSabor(JOptionPane.showInputDialog("Digite o sabor do bolo: "));
        bolinho.setFormato(JOptionPane.showInputDialog("Digite o formato do bolo: "));
        bolinho.setRecheio(JOptionPane.showInputDialog("Digite o recheio do bolo: "));
        bolinho.setCobertura(JOptionPane.showInputDialog("Digite a cobertura do bolo: "));
        bolinho.setTamanho(Float.parseFloat(JOptionPane.showInputDialog("Digite o tamanho do bolo em metros: ")));
        bolinho.setCamadas(Integer.parseInt(JOptionPane.showInputDialog("Digite a quantidade de camadas do bolo: ")));
        
        Forno forninho = new Forno();
        forninho.setMarca(JOptionPane.showInputDialog("Digite a marca do forno: "));
        forninho.setModelo(JOptionPane.showInputDialog("Digite o modelo do forno: "));
        forninho.setVolume(Float.parseFloat(JOptionPane.showInputDialog("Digite o volume do forno em metros cúbicos: ")));
        forninho.setTamanho(Float.parseFloat(JOptionPane.showInputDialog("Digite o tamanho do forno em metros: ")));
        forninho.setBotao(Integer.parseInt(JOptionPane.showInputDialog("Digite a quantidade de botões no forno: ")));
        JOptionPane.showMessageDialog(null, forninho.assar(Float.parseFloat(JOptionPane.showInputDialog("Digite o valor da temperatura do forno em Celsius: ")),Float.parseFloat(JOptionPane.showInputDialog("Digite o tempo para assar em minutos: "))));
    
        JOptionPane.showMessageDialog(null, forninho.getMarca());
        JOptionPane.showMessageDialog(null, forninho.getModelo());
        JOptionPane.showMessageDialog(null, forninho.getTemperatura());
        JOptionPane.showMessageDialog(null, forninho.getVolume());
        JOptionPane.showMessageDialog(null, forninho.getTamanho());
        JOptionPane.showMessageDialog(null, forninho.getBotao());
        
        JOptionPane.showMessageDialog(null, bolinho.getSabor());
        JOptionPane.showMessageDialog(null, bolinho.getFormato());
        JOptionPane.showMessageDialog(null, bolinho.getRecheio());
        JOptionPane.showMessageDialog(null, bolinho.getCobertura());
        JOptionPane.showMessageDialog(null, bolinho.getTamanho());
        JOptionPane.showMessageDialog(null, bolinho.getCamadas());
    }
    
}
