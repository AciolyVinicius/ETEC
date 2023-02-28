/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package memoria;

import java.awt.Image;
import java.io.File;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.imageio.ImageIO;
import javax.swing.Icon;
import javax.swing.ImageIcon;
import javax.swing.JFileChooser;
import javax.swing.JLabel;
import javax.swing.JButton;
import javax.swing.JOptionPane;
import javax.swing.filechooser.FileNameExtensionFilter;

/**
 *
 * @author Aluno
 */
public class JFRand extends javax.swing.JFrame {

    JButton[] jogo;
    //Um seletor de arquivos
    JFileChooser escolha;

    /**
     * Creates new form NewJFrame
     */
    public JFRand() {
        initComponents();
        jogo = new JButton[]{b1, b2, b3, b4, b5, b6};
        int[] valgame;
        escolha = new JFileChooser();
        //Permitir que se escolha vários arquivos
        escolha.setDialogTitle("Escolha pelo menos " + jogo.length + " imagens para o Jogo da Memória");
        escolha.setMultiSelectionEnabled(true);
        //Permitir que se escolha apenas imagens
        escolha.setFileFilter(new FileNameExtensionFilter("Imagens", "bmp", "png", "jpg"));
        escolha.setAcceptAllFileFilterUsed(false);

    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        btnSortear = new javax.swing.JButton();
        jPanel1 = new javax.swing.JPanel();
        b1 = new javax.swing.JButton();
        b2 = new javax.swing.JButton();
        b3 = new javax.swing.JButton();
        b4 = new javax.swing.JButton();
        b5 = new javax.swing.JButton();
        b6 = new javax.swing.JButton();
        btnJogar = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        btnSortear.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnSortear.setText("Sortear");
        btnSortear.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSortearActionPerformed(evt);
            }
        });

        jPanel1.setLayout(new java.awt.GridLayout(2, 3));

        b1.setBorder(javax.swing.BorderFactory.createEtchedBorder());
        b1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                b1ActionPerformed(evt);
            }
        });
        jPanel1.add(b1);

        b2.setBorder(javax.swing.BorderFactory.createEtchedBorder());
        b2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                b2ActionPerformed(evt);
            }
        });
        jPanel1.add(b2);

        b3.setBorder(javax.swing.BorderFactory.createEtchedBorder());
        b3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                b3ActionPerformed(evt);
            }
        });
        jPanel1.add(b3);

        b4.setBorder(javax.swing.BorderFactory.createEtchedBorder());
        jPanel1.add(b4);

        b5.setBorder(javax.swing.BorderFactory.createEtchedBorder());
        jPanel1.add(b5);

        b6.setBorder(javax.swing.BorderFactory.createEtchedBorder());
        jPanel1.add(b6);

        btnJogar.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnJogar.setText("Jogar");
        btnJogar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnJogarActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, 567, Short.MAX_VALUE)
            .addGroup(layout.createSequentialGroup()
                .addGap(155, 155, 155)
                .addComponent(btnSortear)
                .addGap(112, 112, 112)
                .addComponent(btnJogar)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, 329, Short.MAX_VALUE)
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnSortear)
                    .addComponent(btnJogar))
                .addGap(32, 32, 32))
        );

        setBounds(0, 0, 583, 460);
    }// </editor-fold>//GEN-END:initComponents

    private void btnSortearActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSortearActionPerformed
        try {
            carregaImagens();
        } catch (IOException ex) {}
        
    }//GEN-LAST:event_btnSortearActionPerformed

    private void btnJogarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnJogarActionPerformed
           for(int i = 0; i < jogo.length; i++) {
               try {
                   jogo[i].setIcon(new ImageIcon(ImageIO.read(new File("src/memoria/oque.jpg")).
                           getScaledInstance(b1.getWidth(), b1.getHeight(),
                                   Image.SCALE_AREA_AVERAGING)));
               } catch (IOException ex) {
                   System.out.println(ex.getMessage());
               }
        }
      
    }//GEN-LAST:event_btnJogarActionPerformed

    private void b3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_b3ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_b3ActionPerformed

    private void b2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_b2ActionPerformed
       
    }//GEN-LAST:event_b2ActionPerformed

    private void b1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_b1ActionPerformed
       
    }//GEN-LAST:event_b1ActionPerformed

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
            java.util.logging.Logger.getLogger(JFRand.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(JFRand.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(JFRand.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(JFRand.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new JFRand().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton b1;
    private javax.swing.JButton b2;
    private javax.swing.JButton b3;
    private javax.swing.JButton b4;
    private javax.swing.JButton b5;
    private javax.swing.JButton b6;
    private javax.swing.JButton btnJogar;
    private javax.swing.JButton btnSortear;
    private javax.swing.JPanel jPanel1;
    // End of variables declaration//GEN-END:variables

        public void carregaImagens() throws IOException {
        //Um vetor de arquivos
        File[] imagens = null;
        //Um vetor de icones que serão embaralhados
        Icon[] ic = new Icon[jogo.length];
        //Primeiro armazena todos os caminhos das imagens selecionadas
        if (escolha.showOpenDialog(this) == JFileChooser.APPROVE_OPTION) {
            imagens = escolha.getSelectedFiles();
        }
     //Depois faz a distribuição das imagens nos botoes
        //A alocação será aleatória, cada imagem estará em 2 lugares distintos
        int sort1, sort2;
        for (int i = 0; i < ic.length/2; i++) {//Roda só a metade pois carrega de 2 em 2 imagens
            //Faz um sorteio de posição para uma imagem
            do {
                sort1 = (int) (Math.random() * (ic.length));
            } while (ic[sort1] != null);
            ic[sort1] = new ImageIcon(ImageIO.read(imagens[sort1]).
                    getScaledInstance(b1.getWidth(), b1.getHeight(),
                            Image.SCALE_AREA_AVERAGING));
                            
          //A mesma imagem para uma posição diferente
         do {
                sort2 = (int) (Math.random() * (ic.length));
        } while (ic[sort2] != null);
            ic[sort2] = new ImageIcon(ImageIO.read(imagens[sort1]).
                    getScaledInstance(b1.getWidth(), b1.getHeight(),
                            Image.SCALE_AREA_AVERAGING));
        }
        //Coloca cada imagem na devida label
        for (int i = 0; i < jogo.length; i++) {
            jogo[i].setIcon(ic[i]);
        }
        
    }   //Atenção: Para validar se o usuário vai acertar cada imagem é necessário criar
    //algum tipo de combinação com as imagens iguais e as labels. Use sua criatividade para resolver
    //isso.
    //Não carregue fotos muito grandes pois pode travar a aplicação

    

}
