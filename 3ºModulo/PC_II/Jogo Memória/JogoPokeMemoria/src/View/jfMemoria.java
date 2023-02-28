/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package View;

import java.awt.CardLayout;
import java.awt.Image;
import java.io.File;
import java.io.IOException;
import java.util.Arrays;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.imageio.ImageIO;
import javax.swing.Icon;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFileChooser;
import javax.swing.SwingConstants;
import javax.swing.filechooser.FileNameExtensionFilter;
import Classes.IconeJogo;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.concurrent.TimeUnit;
import javax.swing.JOptionPane;
/**
 *
 * @author Aluno
 */
public class jfMemoria extends javax.swing.JFrame {

    //Conta tempo de jogo
    Thread tF1, tF2;
    Thread tM1, tM2;
    Thread tD1, tD2;
    
    //Boolean para parar e continuar thread
    boolean thF = true;
    boolean thM = true;
    boolean thD = true;
    
    //armazena todos os botoes
    JButton FacilBtn[];
    JButton MedioBtn[];
    JButton DificilBtn[];
    
    //armazena todos os caminhos
    String[] Facil[];
    String[] Medio[];
    String[] Dificil[];
    
    //abrir os arquivos
    JFileChooser escolhaF;
    JFileChooser escolhaM;
    JFileChooser escolhaD;
    
    //icones dos botoes
    Icon icF1, icF2;
    Icon icM1, icM2;
    Icon icD1, icD2;
    
    //calcular quantos foram clicados
    int contF, contM, contD;
    int contFT, contMT, contDT;
    
    //pega as chaves dos botoes clicados
    int F1 = 100, F2 = 100;
    int M1 = 100, M2 = 100;
    int D1 = 100, D2 = 100;
    
    //verifica se a comparação bate ou não
    boolean VF = false;
    boolean VM = false;
    boolean VD = false;
    
    //para puxar as imagens
    File[] imagens;
    
    //Onde as imagens estao alocadas
    ImageIcon[] icF, icM, icD;
    
    /**
     * Creates new form jfMemoria
     */
    public jfMemoria() {
        initComponents();
        
        this.setExtendedState(MAXIMIZED_BOTH);
        
        lblDJogar.setHorizontalAlignment(SwingConstants.CENTER);
        btnDJogar.setHorizontalAlignment(SwingConstants.CENTER);
        lblMJogar.setHorizontalAlignment(SwingConstants.CENTER);
        btnDJogar.setHorizontalAlignment(SwingConstants.CENTER);
        lblFJogar.setHorizontalAlignment(SwingConstants.CENTER);
        btnDJogar.setHorizontalAlignment(SwingConstants.CENTER);
        setLocationRelativeTo(null);
        
        FacilBtn = new JButton[]{btnF1, btnF2, btnF3, btnF4, btnF5, btnF6, btnF7, btnF8, btnF9, btnF10, btnF11, btnF12};
        MedioBtn = new JButton[]{btnM1, btnM2, btnM3, btnM4, btnM5, btnM6, btnM7, btnM8, btnM9, btnM10, 
            btnM11, btnM12, btnM13, btnM14, btnM15, btnM16, btnM17, btnM18, btnM19, btnM20};
        DificilBtn = new JButton[]{btnD1, btnD2, btnD3, btnD4, btnD5, btnD6, btnD7, btnD8, btnD9, btnD10, 
            btnD11, btnD12, btnD13, btnD14, btnD15, btnD16, btnD17, btnD18, btnD19, btnD20, btnD21, btnD22,
            btnD23, btnD24, btnD25, btnD26, btnD27, btnD28, btnD29, btnD30, 
            btnD31, btnD32, btnD33, btnD34, btnD35, btnD36, btnD37, btnD38, btnD39, btnD40};
        
        icF = new IconeJogo[FacilBtn.length];
        icM = new IconeJogo[MedioBtn.length];
        icD = new IconeJogo[DificilBtn.length];
        
        escolhaF = new JFileChooser();        
        //Permitir que se escolha vários arquivos
        escolhaF.setDialogTitle("Escolha pelo menos " + FacilBtn.length + " imagens para o Jogo da Memória");
        escolhaF.setMultiSelectionEnabled(true);
        //Permitir que se escolha apenas imagens
        escolhaF.setFileFilter(new FileNameExtensionFilter("Imagens", "bmp", "png", "jpg"));
        escolhaF.setAcceptAllFileFilterUsed(false);
        
        escolhaM = new JFileChooser();        
        //Permitir que se escolha vários arquivos
        escolhaM.setDialogTitle("Escolha pelo menos " + MedioBtn.length + " imagens para o Jogo da Memória");
        escolhaM.setMultiSelectionEnabled(true);
        //Permitir que se escolha apenas imagens
        escolhaM.setFileFilter(new FileNameExtensionFilter("Imagens", "bmp", "png", "jpg"));
        escolhaM.setAcceptAllFileFilterUsed(false);
        
        escolhaD = new JFileChooser();        
        //Permitir que se escolha vários arquivos
        escolhaD.setDialogTitle("Escolha pelo menos " + DificilBtn.length + " imagens para o Jogo da Memória");
        escolhaD.setMultiSelectionEnabled(true);
        //Permitir que se escolha apenas imagens
        escolhaD.setFileFilter(new FileNameExtensionFilter("Imagens", "bmp", "png", "jpg"));
        escolhaD.setAcceptAllFileFilterUsed(false);
        
        contF = 0;
        contM = 0;
        contD = 0;
        contFT = 0;
        contMT = 0;
        contDT = 0;
        
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        pnlBase = new javax.swing.JPanel();
        pnlHome = new javax.swing.JPanel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        pnlFacil = new javax.swing.JPanel();
        pnlJogoF = new javax.swing.JPanel();
        btnF1 = new javax.swing.JButton();
        btnF2 = new javax.swing.JButton();
        btnF3 = new javax.swing.JButton();
        btnF4 = new javax.swing.JButton();
        btnF5 = new javax.swing.JButton();
        btnF6 = new javax.swing.JButton();
        btnF7 = new javax.swing.JButton();
        btnF8 = new javax.swing.JButton();
        btnF9 = new javax.swing.JButton();
        btnF10 = new javax.swing.JButton();
        btnF11 = new javax.swing.JButton();
        btnF12 = new javax.swing.JButton();
        lblFTentativas = new javax.swing.JLabel();
        lblFCronometroInd = new javax.swing.JLabel();
        btnFJogar = new javax.swing.JButton();
        lblFJogar = new javax.swing.JLabel();
        lblFTentativasQtd = new javax.swing.JLabel();
        lblFCronometro = new javax.swing.JLabel();
        pnlMedio = new javax.swing.JPanel();
        pblJogoM = new javax.swing.JPanel();
        btnM1 = new javax.swing.JButton();
        btnM2 = new javax.swing.JButton();
        btnM3 = new javax.swing.JButton();
        btnM4 = new javax.swing.JButton();
        btnM5 = new javax.swing.JButton();
        btnM6 = new javax.swing.JButton();
        btnM7 = new javax.swing.JButton();
        btnM8 = new javax.swing.JButton();
        btnM9 = new javax.swing.JButton();
        btnM10 = new javax.swing.JButton();
        btnM11 = new javax.swing.JButton();
        btnM12 = new javax.swing.JButton();
        btnM13 = new javax.swing.JButton();
        btnM14 = new javax.swing.JButton();
        btnM15 = new javax.swing.JButton();
        btnM16 = new javax.swing.JButton();
        btnM17 = new javax.swing.JButton();
        btnM18 = new javax.swing.JButton();
        btnM19 = new javax.swing.JButton();
        btnM20 = new javax.swing.JButton();
        lblMJogar = new javax.swing.JLabel();
        btnMJogar = new javax.swing.JButton();
        lblMCronometroInd = new javax.swing.JLabel();
        lblMTentativasQtd = new javax.swing.JLabel();
        lblMTentativas = new javax.swing.JLabel();
        lblMCronometro = new javax.swing.JLabel();
        pnlDificil = new javax.swing.JPanel();
        pnlJogoD = new javax.swing.JPanel();
        btnD1 = new javax.swing.JButton();
        btnD2 = new javax.swing.JButton();
        btnD3 = new javax.swing.JButton();
        btnD4 = new javax.swing.JButton();
        btnD5 = new javax.swing.JButton();
        btnD6 = new javax.swing.JButton();
        btnD7 = new javax.swing.JButton();
        btnD8 = new javax.swing.JButton();
        btnD9 = new javax.swing.JButton();
        btnD10 = new javax.swing.JButton();
        btnD11 = new javax.swing.JButton();
        btnD12 = new javax.swing.JButton();
        btnD13 = new javax.swing.JButton();
        btnD14 = new javax.swing.JButton();
        btnD15 = new javax.swing.JButton();
        btnD16 = new javax.swing.JButton();
        btnD17 = new javax.swing.JButton();
        btnD18 = new javax.swing.JButton();
        btnD19 = new javax.swing.JButton();
        btnD20 = new javax.swing.JButton();
        btnD21 = new javax.swing.JButton();
        btnD22 = new javax.swing.JButton();
        btnD23 = new javax.swing.JButton();
        btnD24 = new javax.swing.JButton();
        btnD25 = new javax.swing.JButton();
        btnD26 = new javax.swing.JButton();
        btnD27 = new javax.swing.JButton();
        btnD28 = new javax.swing.JButton();
        btnD29 = new javax.swing.JButton();
        btnD30 = new javax.swing.JButton();
        btnD31 = new javax.swing.JButton();
        btnD32 = new javax.swing.JButton();
        btnD33 = new javax.swing.JButton();
        btnD34 = new javax.swing.JButton();
        btnD35 = new javax.swing.JButton();
        btnD36 = new javax.swing.JButton();
        btnD37 = new javax.swing.JButton();
        btnD38 = new javax.swing.JButton();
        btnD39 = new javax.swing.JButton();
        btnD40 = new javax.swing.JButton();
        lblDJogar = new javax.swing.JLabel();
        btnDJogar = new javax.swing.JButton();
        lblDCronometroInd = new javax.swing.JLabel();
        lblDTentativasQtd = new javax.swing.JLabel();
        lblDTentativas = new javax.swing.JLabel();
        lblDCronometro = new javax.swing.JLabel();
        jMenuBar1 = new javax.swing.JMenuBar();
        jMenu1 = new javax.swing.JMenu();
        Home = new javax.swing.JMenuItem();
        jMenu2 = new javax.swing.JMenu();
        menuFacil = new javax.swing.JMenuItem();
        menuMedio = new javax.swing.JMenuItem();
        menuDificil = new javax.swing.JMenuItem();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Poke Memória");
        getContentPane().setLayout(new java.awt.BorderLayout());

        pnlBase.setFont(new java.awt.Font("Times New Roman", 0, 12)); // NOI18N
        pnlBase.setLayout(new java.awt.CardLayout());

        pnlHome.setBackground(new java.awt.Color(0, 0, 102));
        pnlHome.setFont(new java.awt.Font("Times New Roman", 0, 12)); // NOI18N

        jLabel3.setFont(new java.awt.Font("Times New Roman", 1, 60)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(255, 255, 255));
        jLabel3.setText("Poke Memória");

        javax.swing.GroupLayout pnlHomeLayout = new javax.swing.GroupLayout(pnlHome);
        pnlHome.setLayout(pnlHomeLayout);
        pnlHomeLayout.setHorizontalGroup(
            pnlHomeLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlHomeLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel2, javax.swing.GroupLayout.DEFAULT_SIZE, 1029, Short.MAX_VALUE)
                .addContainerGap())
            .addGroup(pnlHomeLayout.createSequentialGroup()
                .addGap(58, 58, 58)
                .addComponent(jLabel3)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        pnlHomeLayout.setVerticalGroup(
            pnlHomeLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnlHomeLayout.createSequentialGroup()
                .addGap(64, 64, 64)
                .addComponent(jLabel2)
                .addGap(18, 18, 18)
                .addComponent(jLabel3)
                .addContainerGap(615, Short.MAX_VALUE))
        );

        pnlBase.add(pnlHome, "cardHome");
        pnlHome.getAccessibleContext().setAccessibleName("cardHome");

        pnlFacil.setBackground(new java.awt.Color(0, 0, 102));
        pnlFacil.setFont(new java.awt.Font("Times New Roman", 0, 12)); // NOI18N

        pnlJogoF.setBackground(new java.awt.Color(204, 204, 255));
        pnlJogoF.setLayout(new java.awt.GridLayout(2, 3));

        btnF1.setBorder(null);
        btnF1.setEnabled(false);
        btnF1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnF1ActionPerformed(evt);
            }
        });
        pnlJogoF.add(btnF1);

        btnF2.setBorder(null);
        btnF2.setEnabled(false);
        btnF2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnF2ActionPerformed(evt);
            }
        });
        pnlJogoF.add(btnF2);

        btnF3.setBorder(null);
        btnF3.setEnabled(false);
        btnF3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnF3ActionPerformed(evt);
            }
        });
        pnlJogoF.add(btnF3);

        btnF4.setBorder(null);
        btnF4.setEnabled(false);
        btnF4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnF4ActionPerformed(evt);
            }
        });
        pnlJogoF.add(btnF4);

        btnF5.setBorder(null);
        btnF5.setEnabled(false);
        btnF5.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnF5ActionPerformed(evt);
            }
        });
        pnlJogoF.add(btnF5);

        btnF6.setBorder(null);
        btnF6.setEnabled(false);
        btnF6.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnF6ActionPerformed(evt);
            }
        });
        pnlJogoF.add(btnF6);

        btnF7.setBorder(null);
        btnF7.setEnabled(false);
        btnF7.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnF7ActionPerformed(evt);
            }
        });
        pnlJogoF.add(btnF7);

        btnF8.setBorder(null);
        btnF8.setEnabled(false);
        btnF8.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnF8ActionPerformed(evt);
            }
        });
        pnlJogoF.add(btnF8);

        btnF9.setBorder(null);
        btnF9.setEnabled(false);
        btnF9.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnF9ActionPerformed(evt);
            }
        });
        pnlJogoF.add(btnF9);

        btnF10.setBorder(null);
        btnF10.setEnabled(false);
        btnF10.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnF10ActionPerformed(evt);
            }
        });
        pnlJogoF.add(btnF10);

        btnF11.setBorder(null);
        btnF11.setEnabled(false);
        btnF11.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnF11ActionPerformed(evt);
            }
        });
        pnlJogoF.add(btnF11);

        btnF12.setBorder(null);
        btnF12.setEnabled(false);
        btnF12.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnF12ActionPerformed(evt);
            }
        });
        pnlJogoF.add(btnF12);

        lblFTentativas.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        lblFTentativas.setForeground(new java.awt.Color(255, 255, 255));
        lblFTentativas.setText("Tentativas:");

        lblFCronometroInd.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        lblFCronometroInd.setForeground(new java.awt.Color(255, 255, 255));
        lblFCronometroInd.setText("Cronometro:");

        btnFJogar.setFont(new java.awt.Font("Tahoma", 0, 5)); // NOI18N
        btnFJogar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagens/Icone.png"))); // NOI18N
        btnFJogar.setEnabled(false);
        btnFJogar.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        btnFJogar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnFJogarActionPerformed(evt);
            }
        });

        lblFJogar.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        lblFJogar.setForeground(new java.awt.Color(255, 255, 255));
        lblFJogar.setText("JOGAR");
        lblFJogar.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);

        lblFTentativasQtd.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        lblFTentativasQtd.setForeground(new java.awt.Color(255, 255, 255));
        lblFTentativasQtd.setText("Tentativas");

        lblFCronometro.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        lblFCronometro.setForeground(new java.awt.Color(255, 255, 255));
        lblFCronometro.setText("Cronometro");

        javax.swing.GroupLayout pnlFacilLayout = new javax.swing.GroupLayout(pnlFacil);
        pnlFacil.setLayout(pnlFacilLayout);
        pnlFacilLayout.setHorizontalGroup(
            pnlFacilLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(pnlJogoF, javax.swing.GroupLayout.DEFAULT_SIZE, 1049, Short.MAX_VALUE)
            .addGroup(pnlFacilLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlFacilLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnlFacilLayout.createSequentialGroup()
                        .addComponent(lblFJogar)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnFJogar, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                    .addGroup(pnlFacilLayout.createSequentialGroup()
                        .addGroup(pnlFacilLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(lblFTentativas)
                            .addComponent(lblFTentativasQtd)
                            .addComponent(lblFCronometroInd)
                            .addComponent(lblFCronometro))
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
        );
        pnlFacilLayout.setVerticalGroup(
            pnlFacilLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlFacilLayout.createSequentialGroup()
                .addComponent(pnlJogoF, javax.swing.GroupLayout.PREFERRED_SIZE, 413, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGroup(pnlFacilLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(pnlFacilLayout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnFJogar))
                    .addGroup(pnlFacilLayout.createSequentialGroup()
                        .addGap(15, 15, 15)
                        .addComponent(lblFJogar)))
                .addGap(18, 18, 18)
                .addComponent(lblFTentativas)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(lblFTentativasQtd)
                .addGap(18, 18, 18)
                .addComponent(lblFCronometroInd)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(lblFCronometro)
                .addContainerGap(173, Short.MAX_VALUE))
        );

        pnlBase.add(pnlFacil, "cardFacil");

        pnlMedio.setBackground(new java.awt.Color(0, 0, 102));
        pnlMedio.setFont(new java.awt.Font("Times New Roman", 0, 12)); // NOI18N

        pblJogoM.setBackground(new java.awt.Color(204, 204, 255));
        pblJogoM.setLayout(new java.awt.GridLayout(4, 3));

        btnM1.setBorder(null);
        btnM1.setEnabled(false);
        btnM1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM1ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM1);

        btnM2.setBorder(null);
        btnM2.setEnabled(false);
        btnM2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM2ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM2);

        btnM3.setBorder(null);
        btnM3.setEnabled(false);
        btnM3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM3ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM3);

        btnM4.setBorder(null);
        btnM4.setEnabled(false);
        btnM4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM4ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM4);

        btnM5.setBorder(null);
        btnM5.setEnabled(false);
        btnM5.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM5ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM5);

        btnM6.setBorder(null);
        btnM6.setEnabled(false);
        btnM6.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM6ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM6);

        btnM7.setBorder(null);
        btnM7.setEnabled(false);
        btnM7.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM7ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM7);

        btnM8.setBorder(null);
        btnM8.setEnabled(false);
        btnM8.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM8ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM8);

        btnM9.setBorder(null);
        btnM9.setEnabled(false);
        btnM9.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM9ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM9);

        btnM10.setBorder(null);
        btnM10.setEnabled(false);
        btnM10.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM10ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM10);

        btnM11.setBorder(null);
        btnM11.setEnabled(false);
        btnM11.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM11ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM11);

        btnM12.setBorder(null);
        btnM12.setEnabled(false);
        btnM12.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM12ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM12);

        btnM13.setBorder(null);
        btnM13.setEnabled(false);
        btnM13.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM13ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM13);

        btnM14.setBorder(null);
        btnM14.setEnabled(false);
        btnM14.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM14ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM14);

        btnM15.setBorder(null);
        btnM15.setEnabled(false);
        btnM15.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM15ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM15);

        btnM16.setBorder(null);
        btnM16.setEnabled(false);
        btnM16.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM16ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM16);

        btnM17.setBorder(null);
        btnM17.setEnabled(false);
        btnM17.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM17ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM17);

        btnM18.setBorder(null);
        btnM18.setEnabled(false);
        btnM18.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM18ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM18);

        btnM19.setBorder(null);
        btnM19.setEnabled(false);
        btnM19.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM19ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM19);

        btnM20.setBorder(null);
        btnM20.setEnabled(false);
        btnM20.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnM20ActionPerformed(evt);
            }
        });
        pblJogoM.add(btnM20);

        lblMJogar.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        lblMJogar.setForeground(new java.awt.Color(255, 255, 255));
        lblMJogar.setText("JOGAR");

        btnMJogar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagens/Icone.png"))); // NOI18N
        btnMJogar.setBorder(null);
        btnMJogar.setEnabled(false);
        btnMJogar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnMJogarActionPerformed(evt);
            }
        });

        lblMCronometroInd.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        lblMCronometroInd.setForeground(new java.awt.Color(255, 255, 255));
        lblMCronometroInd.setText("Cronometro:");

        lblMTentativasQtd.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        lblMTentativasQtd.setForeground(new java.awt.Color(255, 255, 255));
        lblMTentativasQtd.setText("Tentativas");

        lblMTentativas.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        lblMTentativas.setForeground(new java.awt.Color(255, 255, 255));
        lblMTentativas.setText("Tentativas:");

        lblMCronometro.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        lblMCronometro.setForeground(new java.awt.Color(255, 255, 255));
        lblMCronometro.setText("Cronometro");

        javax.swing.GroupLayout pnlMedioLayout = new javax.swing.GroupLayout(pnlMedio);
        pnlMedio.setLayout(pnlMedioLayout);
        pnlMedioLayout.setHorizontalGroup(
            pnlMedioLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlMedioLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlMedioLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(pnlMedioLayout.createSequentialGroup()
                        .addComponent(lblMJogar)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnMJogar, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                    .addGroup(pnlMedioLayout.createSequentialGroup()
                        .addGroup(pnlMedioLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(lblMTentativas)
                            .addComponent(lblMTentativasQtd)
                            .addComponent(lblMCronometroInd)
                            .addComponent(lblMCronometro))
                        .addGap(0, 928, Short.MAX_VALUE)))
                .addContainerGap())
            .addGroup(pnlMedioLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addComponent(pblJogoM, javax.swing.GroupLayout.DEFAULT_SIZE, 1049, Short.MAX_VALUE))
        );
        pnlMedioLayout.setVerticalGroup(
            pnlMedioLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnlMedioLayout.createSequentialGroup()
                .addGap(0, 493, Short.MAX_VALUE)
                .addGroup(pnlMedioLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(btnMJogar, javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(lblMJogar, javax.swing.GroupLayout.Alignment.TRAILING))
                .addGap(34, 34, 34)
                .addComponent(lblMTentativas)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(lblMTentativasQtd)
                .addGap(18, 18, 18)
                .addComponent(lblMCronometroInd)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(lblMCronometro)
                .addGap(91, 91, 91))
            .addGroup(pnlMedioLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(pnlMedioLayout.createSequentialGroup()
                    .addComponent(pblJogoM, javax.swing.GroupLayout.PREFERRED_SIZE, 461, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGap(0, 284, Short.MAX_VALUE)))
        );

        pnlBase.add(pnlMedio, "cardMedio");

        pnlDificil.setBackground(new java.awt.Color(0, 0, 102));
        pnlDificil.setFont(new java.awt.Font("Times New Roman", 0, 12)); // NOI18N

        pnlJogoD.setBackground(new java.awt.Color(204, 204, 255));
        pnlJogoD.setLayout(new java.awt.GridLayout(5, 8));

        btnD1.setBorder(null);
        btnD1.setEnabled(false);
        btnD1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD1ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD1);

        btnD2.setBorder(null);
        btnD2.setEnabled(false);
        btnD2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD2ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD2);

        btnD3.setBorder(null);
        btnD3.setEnabled(false);
        btnD3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD3ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD3);

        btnD4.setBorder(null);
        btnD4.setEnabled(false);
        btnD4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD4ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD4);

        btnD5.setBorder(null);
        btnD5.setEnabled(false);
        btnD5.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD5ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD5);

        btnD6.setBorder(null);
        btnD6.setEnabled(false);
        btnD6.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD6ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD6);

        btnD7.setBorder(null);
        btnD7.setEnabled(false);
        btnD7.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD7ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD7);

        btnD8.setBorder(null);
        btnD8.setEnabled(false);
        btnD8.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD8ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD8);

        btnD9.setBorder(null);
        btnD9.setEnabled(false);
        btnD9.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD9ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD9);

        btnD10.setBorder(null);
        btnD10.setEnabled(false);
        btnD10.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD10ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD10);

        btnD11.setBorder(null);
        btnD11.setEnabled(false);
        btnD11.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD11ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD11);

        btnD12.setBorder(null);
        btnD12.setEnabled(false);
        btnD12.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD12ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD12);

        btnD13.setBorder(null);
        btnD13.setEnabled(false);
        btnD13.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD13ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD13);

        btnD14.setBorder(null);
        btnD14.setEnabled(false);
        btnD14.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD14ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD14);

        btnD15.setBorder(null);
        btnD15.setEnabled(false);
        btnD15.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD15ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD15);

        btnD16.setBorder(null);
        btnD16.setEnabled(false);
        btnD16.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD16ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD16);

        btnD17.setBorder(null);
        btnD17.setEnabled(false);
        btnD17.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD17ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD17);

        btnD18.setBorder(null);
        btnD18.setEnabled(false);
        btnD18.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD18ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD18);

        btnD19.setBorder(null);
        btnD19.setEnabled(false);
        btnD19.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD19ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD19);

        btnD20.setBorder(null);
        btnD20.setEnabled(false);
        btnD20.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD20ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD20);

        btnD21.setBorder(null);
        btnD21.setEnabled(false);
        btnD21.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD21ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD21);

        btnD22.setBorder(null);
        btnD22.setEnabled(false);
        btnD22.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD22ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD22);

        btnD23.setBorder(null);
        btnD23.setEnabled(false);
        btnD23.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD23ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD23);

        btnD24.setBorder(null);
        btnD24.setEnabled(false);
        btnD24.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD24ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD24);

        btnD25.setBorder(null);
        btnD25.setEnabled(false);
        btnD25.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD25ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD25);

        btnD26.setBorder(null);
        btnD26.setEnabled(false);
        btnD26.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD26ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD26);

        btnD27.setBorder(null);
        btnD27.setEnabled(false);
        btnD27.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD27ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD27);

        btnD28.setBorder(null);
        btnD28.setEnabled(false);
        btnD28.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD28ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD28);

        btnD29.setBorder(null);
        btnD29.setEnabled(false);
        btnD29.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD29ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD29);

        btnD30.setBorder(null);
        btnD30.setEnabled(false);
        btnD30.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD30ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD30);

        btnD31.setBorder(null);
        btnD31.setEnabled(false);
        btnD31.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD31ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD31);

        btnD32.setBorder(null);
        btnD32.setEnabled(false);
        btnD32.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD32ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD32);

        btnD33.setBorder(null);
        btnD33.setEnabled(false);
        btnD33.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD33ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD33);

        btnD34.setBorder(null);
        btnD34.setEnabled(false);
        btnD34.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD34ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD34);

        btnD35.setBorder(null);
        btnD35.setEnabled(false);
        btnD35.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD35ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD35);

        btnD36.setBorder(null);
        btnD36.setEnabled(false);
        btnD36.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD36ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD36);

        btnD37.setBorder(null);
        btnD37.setEnabled(false);
        btnD37.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD37ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD37);

        btnD38.setBorder(null);
        btnD38.setEnabled(false);
        btnD38.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD38ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD38);

        btnD39.setBorder(null);
        btnD39.setEnabled(false);
        btnD39.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD39ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD39);

        btnD40.setBorder(null);
        btnD40.setEnabled(false);
        btnD40.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnD40ActionPerformed(evt);
            }
        });
        pnlJogoD.add(btnD40);

        lblDJogar.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        lblDJogar.setForeground(new java.awt.Color(255, 255, 255));
        lblDJogar.setText("JOGAR");

        btnDJogar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagens/Icone.png"))); // NOI18N
        btnDJogar.setBorder(null);
        btnDJogar.setEnabled(false);
        btnDJogar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnDJogarActionPerformed(evt);
            }
        });

        lblDCronometroInd.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        lblDCronometroInd.setForeground(new java.awt.Color(255, 255, 255));
        lblDCronometroInd.setText("Cronometro:");

        lblDTentativasQtd.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        lblDTentativasQtd.setForeground(new java.awt.Color(255, 255, 255));
        lblDTentativasQtd.setText("Tentativas");

        lblDTentativas.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        lblDTentativas.setForeground(new java.awt.Color(255, 255, 255));
        lblDTentativas.setText("Tentativas:");

        lblDCronometro.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        lblDCronometro.setForeground(new java.awt.Color(255, 255, 255));
        lblDCronometro.setText("Cronometro");

        javax.swing.GroupLayout pnlDificilLayout = new javax.swing.GroupLayout(pnlDificil);
        pnlDificil.setLayout(pnlDificilLayout);
        pnlDificilLayout.setHorizontalGroup(
            pnlDificilLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlDificilLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(pnlDificilLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(pnlDificilLayout.createSequentialGroup()
                        .addComponent(lblDJogar)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnDJogar, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                    .addGroup(pnlDificilLayout.createSequentialGroup()
                        .addGroup(pnlDificilLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(lblDTentativas)
                            .addComponent(lblDTentativasQtd)
                            .addComponent(lblDCronometroInd)
                            .addComponent(lblDCronometro))
                        .addGap(0, 928, Short.MAX_VALUE)))
                .addContainerGap())
            .addGroup(pnlDificilLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addComponent(pnlJogoD, javax.swing.GroupLayout.DEFAULT_SIZE, 1049, Short.MAX_VALUE))
        );
        pnlDificilLayout.setVerticalGroup(
            pnlDificilLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pnlDificilLayout.createSequentialGroup()
                .addContainerGap(566, Short.MAX_VALUE)
                .addGroup(pnlDificilLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(lblDJogar, javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(btnDJogar, javax.swing.GroupLayout.Alignment.TRAILING))
                .addGap(16, 16, 16)
                .addComponent(lblDTentativas)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(lblDTentativasQtd)
                .addGap(18, 18, 18)
                .addComponent(lblDCronometroInd)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(lblDCronometro)
                .addGap(36, 36, 36))
            .addGroup(pnlDificilLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(pnlDificilLayout.createSequentialGroup()
                    .addComponent(pnlJogoD, javax.swing.GroupLayout.PREFERRED_SIZE, 539, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGap(0, 206, Short.MAX_VALUE)))
        );

        pnlBase.add(pnlDificil, "cardDificil");

        getContentPane().add(pnlBase, java.awt.BorderLayout.CENTER);
        pnlBase.getAccessibleContext().setAccessibleName("pnlBase");

        jMenu1.setText("Home");

        Home.setText("Início");
        Home.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                HomeActionPerformed(evt);
            }
        });
        jMenu1.add(Home);

        jMenuBar1.add(jMenu1);

        jMenu2.setText("Jogo");

        menuFacil.setText("Nível Fácil");
        menuFacil.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                menuFacilActionPerformed(evt);
            }
        });
        jMenu2.add(menuFacil);

        menuMedio.setText("Nível Médio");
        menuMedio.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                menuMedioActionPerformed(evt);
            }
        });
        jMenu2.add(menuMedio);

        menuDificil.setText("Nível Difícil");
        menuDificil.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                menuDificilActionPerformed(evt);
            }
        });
        jMenu2.add(menuDificil);

        jMenuBar1.add(jMenu2);

        setJMenuBar(jMenuBar1);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void menuFacilActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_menuFacilActionPerformed
        ((CardLayout)pnlBase.getLayout()).show(pnlBase,"cardFacil");
        try {
            carregaImagensFacil();
        } catch (IOException ex) {
            Logger.getLogger(jfMemoria.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_menuFacilActionPerformed

    private void menuMedioActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_menuMedioActionPerformed
        ((CardLayout)pnlBase.getLayout()).show(pnlBase,"cardMedio");
        try {
            carregaImagensMedio();
        } catch (IOException ex) {
            Logger.getLogger(jfMemoria.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_menuMedioActionPerformed

    private void menuDificilActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_menuDificilActionPerformed
        ((CardLayout)pnlBase.getLayout()).show(pnlBase,"cardDificil");
        try {
            carregaImagensDificil();
        } catch (IOException ex) {
            Logger.getLogger(jfMemoria.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_menuDificilActionPerformed

    private void HomeActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_HomeActionPerformed
        ((CardLayout)pnlBase.getLayout()).show(pnlBase,"cardHome");
    }//GEN-LAST:event_HomeActionPerformed

    private void btnD39ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD39ActionPerformed
        btnD39.setIcon(icD[38]);
        verificaD(btnD39.getIcon(), 38);
    }//GEN-LAST:event_btnD39ActionPerformed

    private void btnD24ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD24ActionPerformed
        btnD24.setIcon(icD[23]);
        verificaD(btnD24.getIcon(), 23);
    }//GEN-LAST:event_btnD24ActionPerformed

    private void btnFJogarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnFJogarActionPerformed
        for(int i = 0; i < FacilBtn.length; i++) {
               try {
                   FacilBtn[i].setIcon(new ImageIcon(ImageIO.read(new File("src/Imagens/Interrogacao.png")).
                           getScaledInstance(btnF1.getWidth(), btnF1.getHeight(),
                                   Image.SCALE_FAST)));
                   FacilBtn[i].setEnabled(true);
               } catch (IOException ex) {
                   System.out.println(ex.getMessage());
               }
        }
        thF = true;
        btnFJogar.setEnabled(false);
        TempoJogoF();
        contF=0;
        contFT=0;
    }//GEN-LAST:event_btnFJogarActionPerformed

    private void btnMJogarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMJogarActionPerformed
        for(int i = 0; i < MedioBtn.length; i++) {
               try {
                   MedioBtn[i].setIcon(new ImageIcon(ImageIO.read(new File("src/Imagens/Interrogacao.png")).
                           getScaledInstance(btnM1.getWidth(), btnM1.getHeight(),
                                   Image.SCALE_FAST)));
                   MedioBtn[i].setEnabled(true);
               } catch (IOException ex) {
                   System.out.println(ex.getMessage());
               }
        }
        thM = true;
        btnMJogar.setEnabled(false);
        TempoJogoM();
        contM=0;
        contMT=0;
    }//GEN-LAST:event_btnMJogarActionPerformed

    private void btnDJogarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnDJogarActionPerformed
        for(int i = 0; i < DificilBtn.length; i++) {
               try {
                   DificilBtn[i].setIcon(new ImageIcon(ImageIO.read(new File("src/Imagens/Interrogacao.png")).
                           getScaledInstance(btnD1.getWidth(), btnD1.getHeight(),
                                   Image.SCALE_FAST)));
                   DificilBtn[i].setEnabled(true);
               } catch (IOException ex) {
                   System.out.println(ex.getMessage());
               }
        }
        thD = true;
        btnDJogar.setEnabled(false);
        TempoJogoD();
        contD = 0;
        contDT = 0;
    }//GEN-LAST:event_btnDJogarActionPerformed

    private void btnF1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnF1ActionPerformed
        btnF1.setIcon(icF[0]);
        verificaF(btnF1.getIcon(),0);
    }//GEN-LAST:event_btnF1ActionPerformed

    private void btnF2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnF2ActionPerformed
        btnF2.setIcon(icF[1]);
        verificaF(btnF2.getIcon(),1);
    }//GEN-LAST:event_btnF2ActionPerformed

    private void btnF3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnF3ActionPerformed
        btnF3.setIcon(icF[2]);        
        verificaF(btnF3.getIcon(),2);
    }//GEN-LAST:event_btnF3ActionPerformed

    private void btnF4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnF4ActionPerformed
        btnF4.setIcon(icF[3]);
        verificaF(btnF4.getIcon(),3);
    }//GEN-LAST:event_btnF4ActionPerformed

    private void btnF5ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnF5ActionPerformed
        btnF5.setIcon(icF[4]);
        verificaF(btnF5.getIcon(),4);
    }//GEN-LAST:event_btnF5ActionPerformed

    private void btnF6ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnF6ActionPerformed
        btnF6.setIcon(icF[5]);
        verificaF(btnF6.getIcon(),5);
    }//GEN-LAST:event_btnF6ActionPerformed

    private void btnF7ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnF7ActionPerformed
        btnF7.setIcon(icF[6]);
        verificaF(btnF7.getIcon(),6);
    }//GEN-LAST:event_btnF7ActionPerformed

    private void btnF8ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnF8ActionPerformed
        btnF8.setIcon(icF[7]);
        verificaF(btnF8.getIcon(),7);
    }//GEN-LAST:event_btnF8ActionPerformed

    private void btnF9ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnF9ActionPerformed
        btnF9.setIcon(icF[8]);
        verificaF(btnF9.getIcon(),8);
    }//GEN-LAST:event_btnF9ActionPerformed

    private void btnF10ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnF10ActionPerformed
        btnF10.setIcon(icF[9]);
        verificaF(btnF10.getIcon(),9);
    }//GEN-LAST:event_btnF10ActionPerformed

    private void btnF11ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnF11ActionPerformed
        btnF11.setIcon(icF[10]);
        verificaF(btnF11.getIcon(),10);
    }//GEN-LAST:event_btnF11ActionPerformed

    private void btnF12ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnF12ActionPerformed
        btnF12.setIcon(icF[11]);
        verificaF(btnF12.getIcon(),11);
    }//GEN-LAST:event_btnF12ActionPerformed

    private void btnM1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM1ActionPerformed
        btnM1.setIcon(icM[0]);
        verificaM(btnM1.getIcon(),0);
    }//GEN-LAST:event_btnM1ActionPerformed

    private void btnM2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM2ActionPerformed
        btnM2.setIcon(icM[1]);
        verificaM(btnM2.getIcon(),1);
    }//GEN-LAST:event_btnM2ActionPerformed

    private void btnM4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM4ActionPerformed
        btnM4.setIcon(icM[3]);
        verificaM(btnM4.getIcon(), 3);
    }//GEN-LAST:event_btnM4ActionPerformed

    private void btnM3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM3ActionPerformed
        btnM3.setIcon(icM[2]);
        verificaM(btnM3.getIcon(), 2);
    }//GEN-LAST:event_btnM3ActionPerformed

    private void btnM5ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM5ActionPerformed
        btnM5.setIcon(icM[4]);
        verificaM(btnM5.getIcon(), 4);
    }//GEN-LAST:event_btnM5ActionPerformed

    private void btnM6ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM6ActionPerformed
        btnM6.setIcon(icM[5]);
        verificaM(btnM6.getIcon(), 5);
    }//GEN-LAST:event_btnM6ActionPerformed

    private void btnM7ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM7ActionPerformed
        btnM7.setIcon(icM[6]);
        verificaM(btnM7.getIcon(), 6);
    }//GEN-LAST:event_btnM7ActionPerformed

    private void btnM8ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM8ActionPerformed
        btnM8.setIcon(icM[7]);
        verificaM(btnM8.getIcon(), 7);
    }//GEN-LAST:event_btnM8ActionPerformed

    private void btnM9ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM9ActionPerformed
        btnM9.setIcon(icM[8]);
        verificaM(btnM9.getIcon(), 8);
    }//GEN-LAST:event_btnM9ActionPerformed

    private void btnM10ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM10ActionPerformed
        btnM10.setIcon(icM[9]);
        verificaM(btnM10.getIcon(), 9);
    }//GEN-LAST:event_btnM10ActionPerformed

    private void btnM11ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM11ActionPerformed
        btnM11.setIcon(icM[10]);
        verificaM(btnM11.getIcon(), 10);
    }//GEN-LAST:event_btnM11ActionPerformed

    private void btnM12ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM12ActionPerformed
        btnM12.setIcon(icM[11]);
        verificaM(btnM12.getIcon(), 11);
    }//GEN-LAST:event_btnM12ActionPerformed

    private void btnM13ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM13ActionPerformed
        btnM13.setIcon(icM[12]);
        verificaM(btnM13.getIcon(), 12);
    }//GEN-LAST:event_btnM13ActionPerformed

    private void btnM14ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM14ActionPerformed
        btnM14.setIcon(icM[13]);
        verificaM(btnM14.getIcon(), 13);
    }//GEN-LAST:event_btnM14ActionPerformed

    private void btnM15ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM15ActionPerformed
        btnM15.setIcon(icM[14]);
        verificaM(btnM15.getIcon(), 14);
    }//GEN-LAST:event_btnM15ActionPerformed

    private void btnM16ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM16ActionPerformed
        btnM16.setIcon(icM[15]);
        verificaM(btnM16.getIcon(), 15);
    }//GEN-LAST:event_btnM16ActionPerformed

    private void btnM17ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM17ActionPerformed
        btnM17.setIcon(icM[16]);
        verificaM(btnM17.getIcon(), 16);
    }//GEN-LAST:event_btnM17ActionPerformed

    private void btnM18ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM18ActionPerformed
        btnM18.setIcon(icM[17]);
        verificaM(btnM18.getIcon(), 17);
    }//GEN-LAST:event_btnM18ActionPerformed

    private void btnM19ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM19ActionPerformed
        btnM19.setIcon(icM[18]);
        verificaM(btnM19.getIcon(), 18);
    }//GEN-LAST:event_btnM19ActionPerformed

    private void btnM20ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnM20ActionPerformed
        btnM20.setIcon(icM[19]);
        verificaM(btnM20.getIcon(), 19);
    }//GEN-LAST:event_btnM20ActionPerformed

    private void btnD1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD1ActionPerformed
        btnD1.setIcon(icD[0]);
        verificaD(btnD1.getIcon(), 0);
    }//GEN-LAST:event_btnD1ActionPerformed

    private void btnD2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD2ActionPerformed
        btnD2.setIcon(icD[1]);
        verificaD(btnD2.getIcon(), 1);
    }//GEN-LAST:event_btnD2ActionPerformed

    private void btnD4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD4ActionPerformed
        btnD4.setIcon(icD[3]);
        verificaD(btnD4.getIcon(), 3);
    }//GEN-LAST:event_btnD4ActionPerformed

    private void btnD3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD3ActionPerformed
        btnD3.setIcon(icD[2]);
        verificaD(btnD3.getIcon(), 2);
    }//GEN-LAST:event_btnD3ActionPerformed

    private void btnD5ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD5ActionPerformed
        btnD5.setIcon(icD[4]);
        verificaD(btnD5.getIcon(), 4);
    }//GEN-LAST:event_btnD5ActionPerformed

    private void btnD6ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD6ActionPerformed
        btnD6.setIcon(icD[5]);
        verificaD(btnD6.getIcon(), 5);
    }//GEN-LAST:event_btnD6ActionPerformed

    private void btnD7ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD7ActionPerformed
        btnD7.setIcon(icD[6]);
        verificaD(btnD7.getIcon(), 6);
    }//GEN-LAST:event_btnD7ActionPerformed

    private void btnD8ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD8ActionPerformed
        btnD8.setIcon(icD[7]);
        verificaD(btnD8.getIcon(), 7);
    }//GEN-LAST:event_btnD8ActionPerformed

    private void btnD9ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD9ActionPerformed
        btnD9.setIcon(icD[8]);
        verificaD(btnD9.getIcon(), 8);
    }//GEN-LAST:event_btnD9ActionPerformed

    private void btnD10ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD10ActionPerformed
        btnD10.setIcon(icD[9]);
        verificaD(btnD10.getIcon(), 9);
    }//GEN-LAST:event_btnD10ActionPerformed

    private void btnD11ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD11ActionPerformed
        btnD11.setIcon(icD[10]);
        verificaD(btnD11.getIcon(), 10);
    }//GEN-LAST:event_btnD11ActionPerformed

    private void btnD12ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD12ActionPerformed
        btnD12.setIcon(icD[11]);
        verificaD(btnD12.getIcon(), 11);
    }//GEN-LAST:event_btnD12ActionPerformed

    private void btnD13ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD13ActionPerformed
        btnD13.setIcon(icD[12]);
        verificaD(btnD13.getIcon(), 12);
    }//GEN-LAST:event_btnD13ActionPerformed

    private void btnD14ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD14ActionPerformed
        btnD14.setIcon(icD[13]);
        verificaD(btnD14.getIcon(), 13);
    }//GEN-LAST:event_btnD14ActionPerformed

    private void btnD15ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD15ActionPerformed
        btnD15.setIcon(icD[14]);
        verificaD(btnD15.getIcon(), 14);
    }//GEN-LAST:event_btnD15ActionPerformed

    private void btnD16ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD16ActionPerformed
        btnD16.setIcon(icD[15]);
        verificaD(btnD16.getIcon(), 15);
    }//GEN-LAST:event_btnD16ActionPerformed

    private void btnD17ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD17ActionPerformed
        btnD17.setIcon(icD[16]);
        verificaD(btnD17.getIcon(), 16);
    }//GEN-LAST:event_btnD17ActionPerformed

    private void btnD18ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD18ActionPerformed
        btnD18.setIcon(icD[17]);
        verificaD(btnD18.getIcon(), 17);
    }//GEN-LAST:event_btnD18ActionPerformed

    private void btnD19ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD19ActionPerformed
        btnD19.setIcon(icD[18]);
        verificaD(btnD19.getIcon(), 18);
    }//GEN-LAST:event_btnD19ActionPerformed

    private void btnD20ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD20ActionPerformed
        btnD20.setIcon(icD[19]);
        verificaD(btnD20.getIcon(), 19);
    }//GEN-LAST:event_btnD20ActionPerformed

    private void btnD21ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD21ActionPerformed
        btnD21.setIcon(icD[20]);
        verificaD(btnD21.getIcon(), 20);
    }//GEN-LAST:event_btnD21ActionPerformed

    private void btnD22ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD22ActionPerformed
        btnD22.setIcon(icD[21]);
        verificaD(btnD22.getIcon(), 21);
    }//GEN-LAST:event_btnD22ActionPerformed

    private void btnD23ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD23ActionPerformed
        btnD23.setIcon(icD[22]);
        verificaD(btnD23.getIcon(), 22);
    }//GEN-LAST:event_btnD23ActionPerformed

    private void btnD25ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD25ActionPerformed
        btnD25.setIcon(icD[24]);
        verificaD(btnD25.getIcon(), 24);
    }//GEN-LAST:event_btnD25ActionPerformed

    private void btnD26ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD26ActionPerformed
        btnD26.setIcon(icD[25]);
        verificaD(btnD26.getIcon(), 25);
    }//GEN-LAST:event_btnD26ActionPerformed

    private void btnD27ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD27ActionPerformed
        btnD27.setIcon(icD[26]);
        verificaD(btnD27.getIcon(), 26);
    }//GEN-LAST:event_btnD27ActionPerformed

    private void btnD28ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD28ActionPerformed
        btnD28.setIcon(icD[27]);
        verificaD(btnD28.getIcon(), 27);
    }//GEN-LAST:event_btnD28ActionPerformed

    private void btnD29ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD29ActionPerformed
        btnD29.setIcon(icD[28]);
        verificaD(btnD29.getIcon(), 28);
    }//GEN-LAST:event_btnD29ActionPerformed

    private void btnD31ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD31ActionPerformed
        btnD31.setIcon(icD[30]);
        verificaD(btnD31.getIcon(), 30);
    }//GEN-LAST:event_btnD31ActionPerformed

    private void btnD30ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD30ActionPerformed
        btnD30.setIcon(icD[29]);
        verificaD(btnD30.getIcon(), 29);
    }//GEN-LAST:event_btnD30ActionPerformed

    private void btnD32ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD32ActionPerformed
        btnD32.setIcon(icD[31]);
        verificaD(btnD32.getIcon(), 31);
    }//GEN-LAST:event_btnD32ActionPerformed

    private void btnD33ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD33ActionPerformed
        btnD33.setIcon(icD[32]);
        verificaD(btnD33.getIcon(), 32);
    }//GEN-LAST:event_btnD33ActionPerformed

    private void btnD34ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD34ActionPerformed
        btnD34.setIcon(icD[33]);
        verificaD(btnD34.getIcon(), 33);
    }//GEN-LAST:event_btnD34ActionPerformed

    private void btnD35ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD35ActionPerformed
        btnD35.setIcon(icD[34]);
        verificaD(btnD35.getIcon(), 34);
    }//GEN-LAST:event_btnD35ActionPerformed

    private void btnD36ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD36ActionPerformed
        btnD36.setIcon(icD[35]);
        verificaD(btnD36.getIcon(), 35);
    }//GEN-LAST:event_btnD36ActionPerformed

    private void btnD37ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD37ActionPerformed
        btnD37.setIcon(icD[36]);
        verificaD(btnD37.getIcon(), 36);
    }//GEN-LAST:event_btnD37ActionPerformed

    private void btnD38ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD38ActionPerformed
        btnD38.setIcon(icD[37]);
        verificaD(btnD38.getIcon(), 37);
    }//GEN-LAST:event_btnD38ActionPerformed

    private void btnD40ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnD40ActionPerformed
        btnD40.setIcon(icD[39]);
        verificaD(btnD40.getIcon(), 39);
    }//GEN-LAST:event_btnD40ActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(jfMemoria.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(jfMemoria.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(jfMemoria.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(jfMemoria.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new jfMemoria().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JMenuItem Home;
    private javax.swing.JButton btnD1;
    private javax.swing.JButton btnD10;
    private javax.swing.JButton btnD11;
    private javax.swing.JButton btnD12;
    private javax.swing.JButton btnD13;
    private javax.swing.JButton btnD14;
    private javax.swing.JButton btnD15;
    private javax.swing.JButton btnD16;
    private javax.swing.JButton btnD17;
    private javax.swing.JButton btnD18;
    private javax.swing.JButton btnD19;
    private javax.swing.JButton btnD2;
    private javax.swing.JButton btnD20;
    private javax.swing.JButton btnD21;
    private javax.swing.JButton btnD22;
    private javax.swing.JButton btnD23;
    private javax.swing.JButton btnD24;
    private javax.swing.JButton btnD25;
    private javax.swing.JButton btnD26;
    private javax.swing.JButton btnD27;
    private javax.swing.JButton btnD28;
    private javax.swing.JButton btnD29;
    private javax.swing.JButton btnD3;
    private javax.swing.JButton btnD30;
    private javax.swing.JButton btnD31;
    private javax.swing.JButton btnD32;
    private javax.swing.JButton btnD33;
    private javax.swing.JButton btnD34;
    private javax.swing.JButton btnD35;
    private javax.swing.JButton btnD36;
    private javax.swing.JButton btnD37;
    private javax.swing.JButton btnD38;
    private javax.swing.JButton btnD39;
    private javax.swing.JButton btnD4;
    private javax.swing.JButton btnD40;
    private javax.swing.JButton btnD5;
    private javax.swing.JButton btnD6;
    private javax.swing.JButton btnD7;
    private javax.swing.JButton btnD8;
    private javax.swing.JButton btnD9;
    private javax.swing.JButton btnDJogar;
    private javax.swing.JButton btnF1;
    private javax.swing.JButton btnF10;
    private javax.swing.JButton btnF11;
    private javax.swing.JButton btnF12;
    private javax.swing.JButton btnF2;
    private javax.swing.JButton btnF3;
    private javax.swing.JButton btnF4;
    private javax.swing.JButton btnF5;
    private javax.swing.JButton btnF6;
    private javax.swing.JButton btnF7;
    private javax.swing.JButton btnF8;
    private javax.swing.JButton btnF9;
    private javax.swing.JButton btnFJogar;
    private javax.swing.JButton btnM1;
    private javax.swing.JButton btnM10;
    private javax.swing.JButton btnM11;
    private javax.swing.JButton btnM12;
    private javax.swing.JButton btnM13;
    private javax.swing.JButton btnM14;
    private javax.swing.JButton btnM15;
    private javax.swing.JButton btnM16;
    private javax.swing.JButton btnM17;
    private javax.swing.JButton btnM18;
    private javax.swing.JButton btnM19;
    private javax.swing.JButton btnM2;
    private javax.swing.JButton btnM20;
    private javax.swing.JButton btnM3;
    private javax.swing.JButton btnM4;
    private javax.swing.JButton btnM5;
    private javax.swing.JButton btnM6;
    private javax.swing.JButton btnM7;
    private javax.swing.JButton btnM8;
    private javax.swing.JButton btnM9;
    private javax.swing.JButton btnMJogar;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JMenu jMenu1;
    private javax.swing.JMenu jMenu2;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JLabel lblDCronometro;
    private javax.swing.JLabel lblDCronometroInd;
    private javax.swing.JLabel lblDJogar;
    private javax.swing.JLabel lblDTentativas;
    private javax.swing.JLabel lblDTentativasQtd;
    private javax.swing.JLabel lblFCronometro;
    private javax.swing.JLabel lblFCronometroInd;
    private javax.swing.JLabel lblFJogar;
    private javax.swing.JLabel lblFTentativas;
    private javax.swing.JLabel lblFTentativasQtd;
    private javax.swing.JLabel lblMCronometro;
    private javax.swing.JLabel lblMCronometroInd;
    private javax.swing.JLabel lblMJogar;
    private javax.swing.JLabel lblMTentativas;
    private javax.swing.JLabel lblMTentativasQtd;
    private javax.swing.JMenuItem menuDificil;
    private javax.swing.JMenuItem menuFacil;
    private javax.swing.JMenuItem menuMedio;
    private javax.swing.JPanel pblJogoM;
    private javax.swing.JPanel pnlBase;
    private javax.swing.JPanel pnlDificil;
    private javax.swing.JPanel pnlFacil;
    private javax.swing.JPanel pnlHome;
    private javax.swing.JPanel pnlJogoD;
    private javax.swing.JPanel pnlJogoF;
    private javax.swing.JPanel pnlMedio;
    // End of variables declaration//GEN-END:variables

    public void carregaImagensFacil() throws IOException {
        Arrays.fill(icF, null); 
        Arrays.fill(icM, null); 
        Arrays.fill(icD, null); // Pega todo o array ic e poe null nas posições
        //Primeiro armazena todos os caminhos das imagens selecionadas
        do{
            if (escolhaF.showOpenDialog(this) == JFileChooser.APPROVE_OPTION) {
                imagens = escolhaF.getSelectedFiles();
            }
        }while(imagens.length<12);
        //Depois faz a distribuição das imagens nos botoes
        //A alocação será aleatória, cada imagem estará em 2 lugares distintos
        int sort1, sort2;
        for (int i = 0; i < icF.length/2; i++) {//Roda só a metade pois carrega de 2 em 2 imagens
            //Faz um sorteio de posição para uma imagem
            do {
                sort1 = (int) (Math.random() * (icF.length));
            } while (icF[sort1] != null);
            icF[sort1] = new IconeJogo(ImageIO.read(imagens[sort1]).
                    getScaledInstance(btnF1.getWidth(), btnF1.getHeight(),
                            Image.SCALE_FAST));
            ((IconeJogo)icF[sort1]).setChave(contF);
          //A mesma imagem para uma posição diferente
         do {
                sort2 = (int) (Math.random() * (icF.length));
        } while (icF[sort2] != null);
            icF[sort2] = new IconeJogo(ImageIO.read(imagens[sort1]).
                    getScaledInstance(btnF1.getWidth(), btnF1.getHeight(),
                            Image.SCALE_FAST));
            ((IconeJogo)icF[sort2]).setChave(contF);
            contF++;
        }
        //Coloca cada imagem na devida label
        for (int i = 0; i < FacilBtn.length; i++) {
            FacilBtn[i].setIcon(icF[i]);
            FacilBtn[i].setEnabled(false);
        }
        btnFJogar.setEnabled(true);
    }
    public void carregaImagensMedio() throws IOException {
        Arrays.fill(icF, null); 
        Arrays.fill(icM, null); 
        Arrays.fill(icD, null);// Pega todo o array ic e poe null nas posições
        //Primeiro armazena todos os caminhos das imagens selecionadas
        do{
            if (escolhaM.showOpenDialog(this) == JFileChooser.APPROVE_OPTION) {
                imagens = escolhaM.getSelectedFiles();
            }
        }while(imagens.length<20);
     //Depois faz a distribuição das imagens nos botoes
        //A alocação será aleatória, cada imagem estará em 2 lugares distintos
        int sort1, sort2;
        for (int i = 0; i < icM.length/2; i++) {//Roda só a metade pois carrega de 2 em 2 imagens
            //Faz um sorteio de posição para uma imagem
            do {
                sort1 = (int) (Math.random() * (icM.length));
            } while (icM[sort1] != null);
            icM[sort1] = new IconeJogo(ImageIO.read(imagens[sort1]).
                    getScaledInstance(btnM1.getWidth(), btnM1.getHeight(),
                            Image.SCALE_FAST));
            ((IconeJogo)icM[sort1]).setChave(contM);
          //A mesma imagem para uma posição diferente
         do {
                sort2 = (int) (Math.random() * (icM.length));
            } while (icM[sort2] != null);
            icM[sort2] = new IconeJogo(ImageIO.read(imagens[sort1]).
                    getScaledInstance(btnM1.getWidth(), btnM1.getHeight(),
                            Image.SCALE_FAST));
            ((IconeJogo)icM[sort2]).setChave(contM);
            contM++;
        }
        //Coloca cada imagem na devida label
        for (int i = 0; i < MedioBtn.length; i++) {
            MedioBtn[i].setIcon(icM[i]);
            MedioBtn[i].setEnabled(false);
        }
        btnMJogar.setEnabled(true);
    }
    public void carregaImagensDificil() throws IOException {
        Arrays.fill(icF, null); 
        Arrays.fill(icM, null); 
        Arrays.fill(icD, null); // Pega todo o array ic e poe null nas posições
        //Primeiro armazena todos os caminhos das imagens selecionadas
        do{
            if (escolhaD.showOpenDialog(this) == JFileChooser.APPROVE_OPTION) {
                imagens = escolhaD.getSelectedFiles();
            }
        }while(imagens.length<40);
     //Depois faz a distribuição das imagens nos botoes
        //A alocação será aleatória, cada imagem estará em 2 lugares distintos
        int sort1, sort2;
        for (int i = 0; i < icD.length/2; i++) {//Roda só a metade pois carrega de 2 em 2 imagens
            //Faz um sorteio de posição para uma imagem
            do {
                sort1 = (int) (Math.random() * (icD.length));
            } while (icD[sort1] != null);
            icD[sort1] = new IconeJogo(ImageIO.read(imagens[sort1]).
                    getScaledInstance(btnD1.getWidth(), btnD1.getHeight(),
                            Image.SCALE_FAST));
            ((IconeJogo)icD[sort1]).setChave(contD);                
          //A mesma imagem para uma posição diferente
         do {
                sort2 = (int) (Math.random() * (icD.length));
            } while (icD[sort2] != null);
            icD[sort2] = new IconeJogo(ImageIO.read(imagens[sort1]).
                    getScaledInstance(btnD1.getWidth(), btnD1.getHeight(),
                            Image.SCALE_FAST));
            ((IconeJogo)icD[sort2]).setChave(contD);
            contD++;
        }
        //Coloca cada imagem na devida label
        for (int i = 0; i < DificilBtn.length; i++) {
            DificilBtn[i].setIcon(icD[i]);
            DificilBtn[i].setEnabled(false);
        }        
        btnDJogar.setEnabled(true);
    } 
    
    private void verificaF(Icon icon, int F){
        //verifica se os ícones já estão associados para a comparação
        if (icF1==null){
            if(F1!=100 && F2!=100){
                FacilBtn[F1].setEnabled(true);
                FacilBtn[F2].setEnabled(true);
                viraF(); 
            }            
            icF1=icon;  
            F1 = F;
            FacilBtn[F1].setEnabled(false);
        }
        else{
            icF2=icon;  
            F2 = F;
            FacilBtn[F2].setEnabled(false);
        }
        //compara as chaves
        if(icF1!=null && icF2!=null){            
            if(((IconeJogo)icF1).getChave()==((IconeJogo)icF2).getChave()){
                thF = false;
                System.out.println("Acertou!");     
                F1 = 100;
                F2 = 100;
                contFT++;
                contF++;
                if(contF==6){
                    JOptionPane.showMessageDialog(null, "VOCÊ VENCEU");
                    btnFJogar.setEnabled(true);
                    contF = 0;
                }
            }
            else{
                System.out.println("Errou!");   
                contFT++;
            }    
            lblFTentativasQtd.setText(contFT+"");
            icF1=null;
            icF2=null;            
            //desvincular os ícones de verificação
                
                //Colocar a Interrrogação de volta
                //Não permitir que se clique 2x na mesma label
                //Dica: Use o atributo Name da label
                //getName e setName
        }
    }
    private void verificaM(Icon icon, int M) {
        //verifica se os ícones já estão associados para a comparação
        if (icM1==null){
            if(M1!=100 && M2!=100){
                MedioBtn[M1].setEnabled(true);
                MedioBtn[M2].setEnabled(true);
                viraM(); 
            }            
            icM1=icon;  
            M1 = M;
            MedioBtn[M1].setEnabled(false);
        }
        else{
            icM2=icon;  
            M2 = M;
            MedioBtn[M2].setEnabled(false);
        }
        //compara as chaves
        if(icM1!=null && icM2!=null){            
            if(((IconeJogo)icM1).getChave()==((IconeJogo)icM2).getChave()){
                thM = false;
                System.out.println("Acertou!");     
                M1 = 100;
                M2 = 100;
                contMT++;
                contM++;
                if(contM==10){
                    JOptionPane.showMessageDialog(null, "VOCÊ VENCEU");
                    contM = 0;
                    btnMJogar.setEnabled(true);
                }
            }
            else{
                System.out.println("Errou!");   
                contMT++;
            }            
            lblMTentativas.setText(contMT+"");
            icM1=null;
            icM2=null;            
            //desvincular os ícones de verificação
                
                //Colocar a Interrrogação de volta
                //Não permitir que se clique 2x na mesma label
                //Dica: Use o atributo Name da label
                //getName e setName
        }
    }
    private void verificaD(Icon icon, int D) {
        //verifica se os ícones já estão associados para a comparação
        if (icD1==null){
            if(D1!=100 && D2!=100){
                DificilBtn[D1].setEnabled(true);
                DificilBtn[D2].setEnabled(true);
                viraD(); 
            }            
            icD1=icon;  
            D1 = D;
            DificilBtn[D1].setEnabled(false);
        }
        else{
            icD2=icon;  
            D2 = D;
            DificilBtn[D2].setEnabled(false);
        }
        //compara as chaves
        if(icD1!=null && icD2!=null){            
            if(((IconeJogo)icD1).getChave()==((IconeJogo)icD2).getChave()){
                System.out.println("Acertou!");     
                D1 = 100;
                D2 = 100;
                contDT++;
                contD++;
                if(contD==20){
                    thD = false;
                    JOptionPane.showMessageDialog(null, "VOCÊ VENCEU");
                    contD  = 0;
                    btnDJogar.setEnabled(true);
                }
            }
            else{
                System.out.println("Errou!");   
                contDT++;
            }            
            lblDTentativas.setText(contDT+"");
            icD1=null;
            icD2=null;            
            //desvincular os ícones de verificação
                
                //Colocar a Interrrogação de volta
                //Não permitir que se clique 2x na mesma label
                //Dica: Use o atributo Name da label
                //getName e setName
        }
    }
    
    private void viraF (){
        try{
            FacilBtn[F1].setIcon(new ImageIcon(ImageIO.read(new File("src/Imagens/Interrogacao.png")).
                           getScaledInstance(btnF1.getWidth(), btnF1.getHeight(),
                                   Image.SCALE_FAST)));
            FacilBtn[F2].setIcon(new ImageIcon(ImageIO.read(new File("src/Imagens/Interrogacao.png")).
                           getScaledInstance(btnF1.getWidth(), btnF1.getHeight(),
                                   Image.SCALE_FAST)));
            }
            catch(Exception ex){
                JOptionPane.showMessageDialog(null, ex.getMessage());
            }
    }
    private void viraM (){
        try{
            MedioBtn[M1].setIcon(new ImageIcon(ImageIO.read(new File("src/Imagens/Interrogacao.png")).
                           getScaledInstance(btnM1.getWidth(), btnM1.getHeight(),
                                   Image.SCALE_FAST)));
            MedioBtn[M2].setIcon(new ImageIcon(ImageIO.read(new File("src/Imagens/Interrogacao.png")).
                           getScaledInstance(btnM1.getWidth(), btnM1.getHeight(),
                                   Image.SCALE_FAST)));
            }
            catch(Exception ex){
                JOptionPane.showMessageDialog(null, ex.getMessage());
            }
    }
    private void viraD (){
        try{
            DificilBtn[D1].setIcon(new ImageIcon(ImageIO.read(new File("src/Imagens/Interrogacao.png")).
                           getScaledInstance(btnD1.getWidth(), btnD1.getHeight(),
                                   Image.SCALE_FAST)));
            DificilBtn[D2].setIcon(new ImageIcon(ImageIO.read(new File("src/Imagens/Interrogacao.png")).
                           getScaledInstance(btnD1.getWidth(), btnD1.getHeight(),
                                   Image.SCALE_FAST)));
            }
            catch(Exception ex){
                JOptionPane.showMessageDialog(null, ex.getMessage());
            }
    }
    
    private void TempoJogoF() {
        tF1 = new Thread() { // CLASSE INTERNA CRIADA DIRETAMENTE
            // SOBREESCRITA DO METODO RUN()
            
            @Override
            public void run() { 
                long t = Long.parseLong(System.currentTimeMillis()+"");
                // REPETIÇÃO INFINITA (ENQUANTO O PROGRAMA ESTIVER ABERTO)
                long tempo;
                while (thF) {
                    tempo=((Long.parseLong(System.currentTimeMillis()+"")-t)/1000);
                    lblFCronometro.setText(tempo+"");
                }
            }
        };
        // CHAMA O METODO RUN(), EXIBE A HORA
        tF1.start(); // EXECUTA O METODO QUE FOI SOBRESCRITO
    }
    private void TempoJogoM() {
        tM1 = new Thread() { // CLASSE INTERNA CRIADA DIRETAMENTE
            // SOBREESCRITA DO METODO RUN()
            
            @Override
            public void run() {
                long t = Long.parseLong(System.currentTimeMillis()+"");
                // REPETIÇÃO INFINITA (ENQUANTO O PROGRAMA ESTIVER ABERTO)
                long tempo;
                while (thM) {
                    tempo=((Long.parseLong(System.currentTimeMillis()+"")-t)/1000);
                    lblMCronometro.setText(tempo+"");
                }
            }
        };
        // CHAMA O METODO RUN(), EXIBE A HORA
        tM1.start(); // EXECUTA O METODO QUE FOI SOBRESCRITO
    }
    private void TempoJogoD() {
        tD1 = new Thread() { // CLASSE INTERNA CRIADA DIRETAMENTE
            // SOBREESCRITA DO METODO RUN()
            
            @Override
            public void run() {
                long t = Long.parseLong(System.currentTimeMillis()+"");
                // REPETIÇÃO INFINITA (ENQUANTO O PROGRAMA ESTIVER ABERTO)
                long tempo;
                while (thD) {
                    tempo=((Long.parseLong(System.currentTimeMillis()+"")-t)/1000);
                    lblDCronometro.setText(tempo+"");
                }
            }
        };
        // CHAMA O METODO RUN(), EXIBE A HORA
        tD1.start(); // EXECUTA O METODO QUE FOI SOBRESCRITO
    }
}
