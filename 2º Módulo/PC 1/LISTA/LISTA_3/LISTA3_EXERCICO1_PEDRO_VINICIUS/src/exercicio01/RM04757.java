/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercicio01;

import java.text.DecimalFormat;
import javax.swing.JOptionPane;

/**
 *
 * @author Aluno
 */
public class RM04757 extends javax.swing.JFrame {

    /**
     * Creates new form RM04757
     */
    public RM04757() {
        initComponents();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jd_imposto = new javax.swing.JDialog();
        brn_imposto = new javax.swing.JButton();
        lbl_salario = new javax.swing.JLabel();
        txt_imposto = new javax.swing.JTextField();
        jd_luz = new javax.swing.JDialog();
        lbl_luz = new javax.swing.JLabel();
        txt_luz = new javax.swing.JTextField();
        btn_luz = new javax.swing.JButton();
        lbl_luz1 = new javax.swing.JLabel();
        lbl_luz3 = new javax.swing.JLabel();
        lbl_luz4 = new javax.swing.JLabel();
        lbl_luz5 = new javax.swing.JLabel();
        lbl_luz6 = new javax.swing.JLabel();
        txt_verde = new javax.swing.JTextField();
        txt_amarela = new javax.swing.JTextField();
        txt_vermelha = new javax.swing.JTextField();
        lbl_luz2 = new javax.swing.JLabel();
        jPanel1 = new javax.swing.JPanel();
        btn_enunciado = new javax.swing.JButton();
        jMenuBar1 = new javax.swing.JMenuBar();
        jm_menu = new javax.swing.JMenu();
        im_imposto = new javax.swing.JMenuItem();
        im_luz = new javax.swing.JMenuItem();

        brn_imposto.setFont(new java.awt.Font("Arial", 0, 24)); // NOI18N
        brn_imposto.setText("OK");

        lbl_salario.setFont(new java.awt.Font("Arial", 0, 24)); // NOI18N
        lbl_salario.setText("SAL??RIO ATUAL");

        txt_imposto.setFont(new java.awt.Font("Arial", 0, 24)); // NOI18N

        javax.swing.GroupLayout jd_impostoLayout = new javax.swing.GroupLayout(jd_imposto.getContentPane());
        jd_imposto.getContentPane().setLayout(jd_impostoLayout);
        jd_impostoLayout.setHorizontalGroup(
            jd_impostoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jd_impostoLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jd_impostoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(javax.swing.GroupLayout.Alignment.LEADING, jd_impostoLayout.createSequentialGroup()
                        .addComponent(lbl_salario)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 106, Short.MAX_VALUE))
                    .addComponent(txt_imposto, javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jd_impostoLayout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addComponent(brn_imposto, javax.swing.GroupLayout.PREFERRED_SIZE, 120, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addGap(32, 32, 32))
        );
        jd_impostoLayout.setVerticalGroup(
            jd_impostoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jd_impostoLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(lbl_salario)
                .addGap(18, 18, 18)
                .addComponent(txt_imposto, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(36, 36, 36)
                .addComponent(brn_imposto)
                .addContainerGap(35, Short.MAX_VALUE))
        );

        jd_luz.getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        lbl_luz.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
        lbl_luz.setText("CONSUMO MENSAL EM KWh (Eletropaulo):");
        jd_luz.getContentPane().add(lbl_luz, new org.netbeans.lib.awtextra.AbsoluteConstraints(23, 11, -1, -1));

        txt_luz.setFont(new java.awt.Font("Arial", 0, 24)); // NOI18N
        txt_luz.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_luzKeyTyped(evt);
            }
        });
        jd_luz.getContentPane().add(txt_luz, new org.netbeans.lib.awtextra.AbsoluteConstraints(23, 82, 502, -1));

        btn_luz.setFont(new java.awt.Font("Arial", 0, 24)); // NOI18N
        btn_luz.setText("OK");
        btn_luz.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_luzActionPerformed(evt);
            }
        });
        jd_luz.getContentPane().add(btn_luz, new org.netbeans.lib.awtextra.AbsoluteConstraints(531, 80, 113, -1));

        lbl_luz1.setFont(new java.awt.Font("Arial", 0, 24)); // NOI18N
        lbl_luz1.setText("Residencial");
        jd_luz.getContentPane().add(lbl_luz1, new org.netbeans.lib.awtextra.AbsoluteConstraints(23, 42, -1, -1));

        lbl_luz3.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
        lbl_luz3.setText("BANDEIRAS (APROXIMADAMENTE)");
        jd_luz.getContentPane().add(lbl_luz3, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 128, -1, -1));

        lbl_luz4.setFont(new java.awt.Font("Arial", 0, 24)); // NOI18N
        lbl_luz4.setText("VERDE:");
        jd_luz.getContentPane().add(lbl_luz4, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 168, -1, -1));

        lbl_luz5.setFont(new java.awt.Font("Arial", 0, 24)); // NOI18N
        lbl_luz5.setText("VERMELHA:");
        jd_luz.getContentPane().add(lbl_luz5, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 250, -1, -1));

        lbl_luz6.setFont(new java.awt.Font("Arial", 0, 24)); // NOI18N
        lbl_luz6.setText("AMARELA:");
        jd_luz.getContentPane().add(lbl_luz6, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 209, -1, -1));

        txt_verde.setFont(new java.awt.Font("Arial", 0, 24)); // NOI18N
        txt_verde.setEnabled(false);
        txt_verde.setName(""); // NOI18N
        txt_verde.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_verdeKeyTyped(evt);
            }
        });
        jd_luz.getContentPane().add(txt_verde, new org.netbeans.lib.awtextra.AbsoluteConstraints(149, 162, 505, -1));

        txt_amarela.setFont(new java.awt.Font("Arial", 0, 24)); // NOI18N
        txt_amarela.setEnabled(false);
        txt_amarela.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_amarelaKeyTyped(evt);
            }
        });
        jd_luz.getContentPane().add(txt_amarela, new org.netbeans.lib.awtextra.AbsoluteConstraints(149, 203, 505, -1));

        txt_vermelha.setFont(new java.awt.Font("Arial", 0, 24)); // NOI18N
        txt_vermelha.setEnabled(false);
        txt_vermelha.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_vermelhaKeyTyped(evt);
            }
        });
        jd_luz.getContentPane().add(txt_vermelha, new org.netbeans.lib.awtextra.AbsoluteConstraints(149, 244, 505, -1));

        lbl_luz2.setFont(new java.awt.Font("Arial", 0, 24)); // NOI18N
        lbl_luz2.setText("Residencial");

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        getContentPane().setLayout(new javax.swing.BoxLayout(getContentPane(), javax.swing.BoxLayout.LINE_AXIS));

        jPanel1.setBackground(new java.awt.Color(51, 51, 51));

        btn_enunciado.setFont(new java.awt.Font("Arial", 0, 18)); // NOI18N
        btn_enunciado.setText("Enunciado");
        btn_enunciado.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_enunciadoActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addContainerGap(38, Short.MAX_VALUE)
                .addComponent(btn_enunciado)
                .addContainerGap())
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addContainerGap(40, Short.MAX_VALUE)
                .addComponent(btn_enunciado)
                .addContainerGap())
        );

        getContentPane().add(jPanel1);

        jMenuBar1.setFont(new java.awt.Font("Arial", 0, 24)); // NOI18N
        jMenuBar1.setMargin(new java.awt.Insets(0, 100, 0, 100));

        jm_menu.setText("MENU");
        jm_menu.setFont(new java.awt.Font("Arial", 1, 36)); // NOI18N

        im_imposto.setFont(new java.awt.Font("Arial", 0, 24)); // NOI18N
        im_imposto.setText("Imposto de renda com base no sal??rio anual");
        im_imposto.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                im_impostoActionPerformed(evt);
            }
        });
        jm_menu.add(im_imposto);

        im_luz.setFont(new java.awt.Font("Arial", 0, 24)); // NOI18N
        im_luz.setText("Valor da conta de luz");
        im_luz.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                im_luzActionPerformed(evt);
            }
        });
        jm_menu.add(im_luz);

        jMenuBar1.add(jm_menu);

        setJMenuBar(jMenuBar1);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void im_impostoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_im_impostoActionPerformed
        jd_imposto.setSize(500,500);
        jd_imposto.setLocationRelativeTo(this);
        jd_imposto.setModal(true);
        jd_imposto.setVisible(true);
    }//GEN-LAST:event_im_impostoActionPerformed

    private void im_luzActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_im_luzActionPerformed
        jd_luz.setSize(700,350);
        jd_luz.setLocationRelativeTo(this);
        jd_luz.setModal(true);
        jd_luz.setVisible(true);
    }//GEN-LAST:event_im_luzActionPerformed

    private void txt_luzKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_luzKeyTyped
        if (!Character.isDigit(evt.getKeyChar())){
            evt.consume();
        }
    }//GEN-LAST:event_txt_luzKeyTyped

    private void btn_luzActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_luzActionPerformed
        Double value = Double.parseDouble(txt_luz.getText());
        Double difverde, difamarela = 0.44, difvermelha = 0.47, verde = 21.83, amarela = 22.61, vermelha = 24.17, valorverde, valoramarela, valorvermelha;
        difverde = 42.0/100;
        Double diferenca;
        if(value<=50){
            txt_verde.setText("" + 21.83/100);
            txt_amarela.setText(""+22.61);
            txt_vermelha.setText(""+24.17);          
        }
        else{
            diferenca = value - 50;
            valorverde = diferenca*difverde + verde;
            DecimalFormat vv = new DecimalFormat("0.##");
            String green = vv.format(valorverde);
            txt_verde.setText(""+green);
            valoramarela = diferenca*difamarela + amarela;
            DecimalFormat vam = new DecimalFormat("0.##");
            String yellow = vam.format(valoramarela);
            txt_amarela.setText(""+yellow);
            valorvermelha = diferenca*difvermelha + vermelha;
            DecimalFormat vver = new DecimalFormat("0.##");
            String red = vver.format(valorvermelha);
            txt_vermelha.setText(""+red);
        }
    }//GEN-LAST:event_btn_luzActionPerformed

    private void btn_enunciadoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_enunciadoActionPerformed
        JOptionPane.showMessageDialog(null, " Seu programa ter?? um Menu Calcular com duas op????es (Sub-menus): \n 1 - Imposto de renda com base no sal??rio anual; \n 2- Valor da conta de luz. \n a. Ao clicar no primeiro sub-menu abrir?? uma JDialog onde o usu??rio ir?? digitar seu sal??rio anual e ao clicar em OK ser?? exibido o quanto ir?? pagar ao Le??o em um painel interno com cor de fundo azul. \nN??o permitir que dados n??o num??ricos e fora da faixa estabelecida sejam aceitos. \n b. Ao clicar no segundo sub-menu dever?? ser exibido um JDialog onde o usu??rio ira digitar o consumo mensal em KWh e ao clicar em OK ser?? calculada a conta de luz correspondente de acordo com a \nfaixa de consumo (pesquisar as bandeiras tarif??rias), desconsiderar o custeio de ilumina????o p??blica e tributos.  \n" +
"OBS: N??o permitir que dados n??o num??ricos e negativos sejam aceitos. ");
    }//GEN-LAST:event_btn_enunciadoActionPerformed

    private void txt_verdeKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_verdeKeyTyped
        // TODO add your handling code here:
    }//GEN-LAST:event_txt_verdeKeyTyped

    private void txt_amarelaKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_amarelaKeyTyped
        // TODO add your handling code here:
    }//GEN-LAST:event_txt_amarelaKeyTyped

    private void txt_vermelhaKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_vermelhaKeyTyped
        // TODO add your handling code here:
    }//GEN-LAST:event_txt_vermelhaKeyTyped

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
            java.util.logging.Logger.getLogger(RM04757.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(RM04757.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(RM04757.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(RM04757.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new RM04757().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton brn_imposto;
    private javax.swing.JButton btn_enunciado;
    private javax.swing.JButton btn_luz;
    private javax.swing.JMenuItem im_imposto;
    private javax.swing.JMenuItem im_luz;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JDialog jd_imposto;
    private javax.swing.JDialog jd_luz;
    private javax.swing.JMenu jm_menu;
    private javax.swing.JLabel lbl_luz;
    private javax.swing.JLabel lbl_luz1;
    private javax.swing.JLabel lbl_luz2;
    private javax.swing.JLabel lbl_luz3;
    private javax.swing.JLabel lbl_luz4;
    private javax.swing.JLabel lbl_luz5;
    private javax.swing.JLabel lbl_luz6;
    private javax.swing.JLabel lbl_salario;
    private javax.swing.JTextField txt_amarela;
    private javax.swing.JTextField txt_imposto;
    private javax.swing.JTextField txt_luz;
    private javax.swing.JTextField txt_verde;
    private javax.swing.JTextField txt_vermelha;
    // End of variables declaration//GEN-END:variables
}
