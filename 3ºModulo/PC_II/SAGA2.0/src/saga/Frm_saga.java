/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package saga;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

/**
 *
 * @author Aluno
 */
public class Frm_saga extends javax.swing.JFrame {

    Connection con; // Conversa com o Banco
    PreparedStatement ps; // String da query formatada
    PreparedStatement ps1; // String da query formatada
    PreparedStatement ps0; // String da query formatada
    ResultSet rs0; // Retorno do banco
    ResultSet rs; // Retorno do banco
    
    /**
     * Creates new form Frm_saga
     */
    public Frm_saga() {
        initComponents();
        setLocationRelativeTo(null);
        try{
                con = Sagas_Class.conectar("root","root");
                ps = con.prepareStatement("select tb_user.nm_user, tb_user.cd_telefone, tb_users_type.nm_users_type from tb_user right join item_user_users_type"
                        + " on tb_user.cd_user = item_user_users_type.cd_user left join tb_users_type on item_user_users_type.cd_users_type = tb_users_type.cd_users_type");
                // receber os dados do banco
                rs = ps.executeQuery();
                // os dados estao em um bloco que precisa ser percorrido por um while
                while(rs.next()){//enquanto houver um registro válido
                    txt_lista.append("Nome: "+rs.getString("tb_user.nm_user")+", Telefone: "+rs.getString("tb_user.cd_telefone")+", Tipo: "+rs.getString("tb_users_type.nm_users_type")+"\n");
                }
            }
            catch(SQLException ex){
                JOptionPane.showMessageDialog(this, "Erro: "+ex.getMessage());
            }
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        btn_cadastrar = new javax.swing.JToggleButton();
        txt_nome = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        txt_telefone = new javax.swing.JTextField();
        jLabel3 = new javax.swing.JLabel();
        cmb_tipo = new javax.swing.JComboBox<>();
        jScrollPane1 = new javax.swing.JScrollPane();
        txt_lista = new javax.swing.JTextArea();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        txt_senha = new javax.swing.JPasswordField();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        btn_cadastrar.setText("Cadastrar");
        btn_cadastrar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_cadastrarActionPerformed(evt);
            }
        });

        txt_nome.setMaximumSize(new java.awt.Dimension(50, 50));

        jLabel1.setText("Nome:");

        jLabel2.setText("Telefone:");

        jLabel3.setText("Tipo:");

        cmb_tipo.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Diretor", "Professor", "Aluno" }));

        txt_lista.setEditable(false);
        txt_lista.setColumns(20);
        txt_lista.setRows(5);
        jScrollPane1.setViewportView(txt_lista);

        jLabel4.setFont(new java.awt.Font("Arial", 1, 14)); // NOI18N
        jLabel4.setText("SAGA Cadastro");

        jLabel5.setText("Senha:");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 262, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addContainerGap()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jLabel5)
                                    .addComponent(jLabel1)
                                    .addComponent(jLabel2)
                                    .addComponent(jLabel3))
                                .addGap(18, 18, 18)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                    .addComponent(txt_nome, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addComponent(txt_telefone)
                                    .addComponent(cmb_tipo, 0, 198, Short.MAX_VALUE)
                                    .addComponent(txt_senha)))
                            .addGroup(layout.createSequentialGroup()
                                .addGap(10, 10, 10)
                                .addComponent(jLabel4))
                            .addGroup(layout.createSequentialGroup()
                                .addContainerGap()
                                .addComponent(btn_cadastrar)))
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGap(15, 15, 15)
                .addComponent(jLabel4)
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(6, 6, 6)
                        .addComponent(jLabel1, javax.swing.GroupLayout.DEFAULT_SIZE, 16, Short.MAX_VALUE))
                    .addComponent(txt_nome, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txt_telefone, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel2, javax.swing.GroupLayout.DEFAULT_SIZE, 27, Short.MAX_VALUE))
                .addGap(11, 11, 11)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel5)
                    .addComponent(txt_senha, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(cmb_tipo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel3, javax.swing.GroupLayout.DEFAULT_SIZE, 33, Short.MAX_VALUE))
                .addGap(18, 18, 18)
                .addComponent(btn_cadastrar)
                .addGap(18, 18, 18)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(22, 22, 22))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btn_cadastrarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_cadastrarActionPerformed
        String s = "";
        try {
            //Abrir a conexao
            con = Sagas_Class.conectar("root","root");
            // Para comparar
            ps0 = con.prepareStatement("select nm_user"
                        + " from tb_user where nm_user = ?");
            ps0.setString(1, txt_nome.getText());
            rs0 = ps0.executeQuery();
        } catch (SQLException ex) {
            Logger.getLogger(Frm_saga.class.getName()).log(Level.SEVERE, null, ex);
        }        
        
        try {
            while(rs0.next()){//enquanto houver um registro válido
                s = rs0.getString("tb_user.nm_user");
            }
        } catch (SQLException ex) {
            Logger.getLogger(Frm_saga.class.getName()).log(Level.SEVERE, null, ex);
        }
        
        if (s == ""){
            txt_lista.setText("");
            try{            
                con = Sagas_Class.conectar("root","root");
                //pré formatar a string da query
                ps = con.prepareStatement("insert into tb_user (cd_telefone, nm_user, cd_senha)"
                        + "values (?,?,?)");
                // definir os valores de cada índice (?)
                ps.setString(1, txt_telefone.getText());
                ps.setString(2, txt_nome.getText());
                ps.setString(3, txt_senha.getText());

                ps.execute();

                ps1 = con.prepareStatement("insert into item_user_users_type values"
                        + " ((select cd_user from tb_user where nm_user = ? and cd_telefone = ? and cd_senha = ?), ?)");            
                ps1.setString(1, txt_nome.getText());
                ps1.setString(2, txt_telefone.getText());
                ps1.setString(3, txt_senha.getText());
                ps1.setInt(4, cmb_tipo.getSelectedIndex()+1);

                ps1.execute();
            }
            catch(SQLException ex){
                JOptionPane.showMessageDialog(this, "Erro: "+ex.getMessage());
            }

            try{
                con = Sagas_Class.conectar("root","root");
                ps = con.prepareStatement("select tb_user.nm_user, tb_user.cd_telefone, tb_users_type.nm_users_type from tb_user right join item_user_users_type"
                        + " on tb_user.cd_user = item_user_users_type.cd_user left join tb_users_type on item_user_users_type.cd_users_type = tb_users_type.cd_users_type");
                // receber os dados do banco
                rs = ps.executeQuery();
                // os dados estao em um bloco que precisa ser percorrido por um while
                while(rs.next()){//enquanto houver um registro válido
                    txt_lista.append("Nome: "+rs.getString("tb_user.nm_user")+", Telefone: "+rs.getString("tb_user.cd_telefone")+", Tipo: "+rs.getString("tb_users_type.nm_users_type")+"\n");
                }
            }
            catch(SQLException ex){
                JOptionPane.showMessageDialog(this, "Erro: "+ex.getMessage());
            }
        }
        else{
            JOptionPane.showMessageDialog(null, "Usuário já existente");
        }
    }//GEN-LAST:event_btn_cadastrarActionPerformed

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
            java.util.logging.Logger.getLogger(Frm_saga.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Frm_saga.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Frm_saga.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Frm_saga.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Frm_saga().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JToggleButton btn_cadastrar;
    private javax.swing.JComboBox<String> cmb_tipo;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTextArea txt_lista;
    private javax.swing.JTextField txt_nome;
    private javax.swing.JPasswordField txt_senha;
    private javax.swing.JTextField txt_telefone;
    // End of variables declaration//GEN-END:variables
}
