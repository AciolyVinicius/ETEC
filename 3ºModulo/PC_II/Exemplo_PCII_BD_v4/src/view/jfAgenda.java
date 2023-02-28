/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package View;

import Control.Conexao;
import Control.DaoContato;
import Model.Contato;
import Model.TabelaContato;
import java.awt.event.MouseEvent;
import java.io.IOException;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import javafx.stage.FileChooser;
import javax.swing.JFileChooser;
import javax.swing.JOptionPane;
import model.TabelaModelo;
import net.sf.jasperreports.engine.JRException;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.view.JasperViewer;
import java.text.SimpleDateFormat;
import java.util.Calendar;

/**
 *
 * @author 
 */
public class jfAgenda extends javax.swing.JFrame {
    Contato c1;
    DaoContato daoC;
    String telefoneUsuario;
    String telefone;
    JFileChooser arq;
    Thread t1, t2;
    // Verificação para novo contato
    boolean novo;
    public jfAgenda() {
        initComponents();
        setLocationRelativeTo(null);
        novo = true;
        tblRegistros.setAutoCreateRowSorter(true);
        
        daoC=new DaoContato();
        carregaContatos();
        arq = new JFileChooser();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        txtNome = new javax.swing.JTextField();
        txtTelefone = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        cmbTipo = new javax.swing.JComboBox<>();
        jLabel5 = new javax.swing.JLabel();
        btnGravar = new javax.swing.JButton();
        btnListar = new javax.swing.JButton();
        btnBuscar = new javax.swing.JButton();
        btnRelatorio = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        tblRegistros = new javax.swing.JTable();
        btnAtualizar = new javax.swing.JButton();
        btnExcluir = new javax.swing.JButton();
        lblRelogio = new javax.swing.JLabel();
        lblData = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Aula 04 - Java e MySQL");
        setBackground(new java.awt.Color(255, 255, 255));

        jLabel1.setBackground(new java.awt.Color(0, 0, 0));
        jLabel1.setFont(new java.awt.Font("Microsoft YaHei Light", 1, 36)); // NOI18N
        jLabel1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel1.setText("Agenda");

        jLabel2.setFont(new java.awt.Font("Microsoft YaHei Light", 0, 14)); // NOI18N
        jLabel2.setText("Nome");

        jLabel3.setFont(new java.awt.Font("Microsoft YaHei Light", 0, 14)); // NOI18N
        jLabel3.setText("Telefone");

        txtNome.setFont(new java.awt.Font("Microsoft YaHei Light", 0, 14)); // NOI18N
        txtNome.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                txtNomeKeyPressed(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtNomeKeyTyped(evt);
            }
        });

        txtTelefone.setFont(new java.awt.Font("Microsoft YaHei Light", 0, 14)); // NOI18N
        txtTelefone.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                txtTelefoneKeyPressed(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtTelefoneKeyTyped(evt);
            }
        });

        jLabel4.setFont(new java.awt.Font("Microsoft YaHei Light", 0, 14)); // NOI18N
        jLabel4.setText("Tipo");

        cmbTipo.setFont(new java.awt.Font("Microsoft YaHei Light", 0, 14)); // NOI18N
        cmbTipo.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "Família", "Trabalho", "Escola", "Amigos" }));

        jLabel5.setFont(new java.awt.Font("Microsoft YaHei Light", 0, 14)); // NOI18N
        jLabel5.setText("Registros");

        btnGravar.setFont(new java.awt.Font("Microsoft YaHei Light", 0, 14)); // NOI18N
        btnGravar.setText("Gravar");
        btnGravar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnGravarActionPerformed(evt);
            }
        });

        btnListar.setFont(new java.awt.Font("Microsoft YaHei Light", 0, 14)); // NOI18N
        btnListar.setText("Listar");
        btnListar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnListarActionPerformed(evt);
            }
        });

        btnBuscar.setFont(new java.awt.Font("Microsoft YaHei Light", 0, 14)); // NOI18N
        btnBuscar.setText("Buscar");
        btnBuscar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnBuscarActionPerformed(evt);
            }
        });

        btnRelatorio.setFont(new java.awt.Font("Microsoft YaHei Light", 0, 14)); // NOI18N
        btnRelatorio.setText("Relatório");
        btnRelatorio.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnRelatorioActionPerformed(evt);
            }
        });

        tblRegistros.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {

            }
        ));
        tblRegistros.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tblRegistrosMouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(tblRegistros);

        btnAtualizar.setFont(new java.awt.Font("Microsoft YaHei Light", 0, 14)); // NOI18N
        btnAtualizar.setText("Atualizar");
        btnAtualizar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAtualizarActionPerformed(evt);
            }
        });

        btnExcluir.setFont(new java.awt.Font("Microsoft YaHei Light", 0, 14)); // NOI18N
        btnExcluir.setText("Excluir");
        btnExcluir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnExcluirActionPerformed(evt);
            }
        });

        lblRelogio.setBackground(new java.awt.Color(0, 0, 0));
        lblRelogio.setFont(new java.awt.Font("Microsoft YaHei Light", 1, 18)); // NOI18N
        lblRelogio.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblRelogio.setText("Hora");

        lblData.setBackground(new java.awt.Color(0, 0, 0));
        lblData.setFont(new java.awt.Font("Microsoft YaHei Light", 1, 18)); // NOI18N
        lblData.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblData.setText("Data");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 169, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, Short.MAX_VALUE))
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 414, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(2, 2, 2))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(txtNome, javax.swing.GroupLayout.PREFERRED_SIZE, 279, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(jLabel3)
                                    .addComponent(txtTelefone, javax.swing.GroupLayout.PREFERRED_SIZE, 279, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(jLabel2)
                                    .addComponent(jLabel5)
                                    .addComponent(cmbTipo, javax.swing.GroupLayout.PREFERRED_SIZE, 279, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(jLabel4))
                                .addGap(48, 48, 48)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(btnGravar, javax.swing.GroupLayout.PREFERRED_SIZE, 89, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(btnBuscar, javax.swing.GroupLayout.PREFERRED_SIZE, 89, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(btnAtualizar, javax.swing.GroupLayout.PREFERRED_SIZE, 89, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(btnListar, javax.swing.GroupLayout.PREFERRED_SIZE, 87, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(btnExcluir, javax.swing.GroupLayout.PREFERRED_SIZE, 87, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(btnRelatorio)))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(lblData, javax.swing.GroupLayout.PREFERRED_SIZE, 113, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(lblRelogio, javax.swing.GroupLayout.PREFERRED_SIZE, 113, javax.swing.GroupLayout.PREFERRED_SIZE)))))
                .addGap(23, 23, 23))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(btnGravar, javax.swing.GroupLayout.PREFERRED_SIZE, 37, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(11, 11, 11)
                        .addComponent(btnBuscar, javax.swing.GroupLayout.PREFERRED_SIZE, 37, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(btnAtualizar, javax.swing.GroupLayout.PREFERRED_SIZE, 37, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(btnListar, javax.swing.GroupLayout.PREFERRED_SIZE, 38, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel1)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jLabel2)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(txtNome, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jLabel3)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(txtTelefone, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jLabel4)))
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(21, 21, 21)
                        .addComponent(cmbTipo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(btnRelatorio, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel5, javax.swing.GroupLayout.PREFERRED_SIZE, 29, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnExcluir, javax.swing.GroupLayout.PREFERRED_SIZE, 38, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 113, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblData)
                    .addComponent(lblRelogio))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        getAccessibleContext().setAccessibleName("Agenda");

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnGravarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnGravarActionPerformed
        if(txtNome.getText() != "" && txtTelefone.getText() != ""){
            if(novo)
            {
                daoC.adicionar(txtTelefone.getText(), txtNome.getText(), cmbTipo.getSelectedIndex()+1);
                JOptionPane.showMessageDialog(this, "Cadastro realizado com sucesso!");
            }
            else
            {
              JOptionPane.showMessageDialog(this, "Erro ao cadastrar!");
            }
        }
        carregaContatos();
    }//GEN-LAST:event_btnGravarActionPerformed

    private void btnListarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnListarActionPerformed
        carregaContatos();
    }//GEN-LAST:event_btnListarActionPerformed

    private void txtTelefoneKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtTelefoneKeyPressed
        
    }//GEN-LAST:event_txtTelefoneKeyPressed

    private void txtNomeKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtNomeKeyPressed
        
    }//GEN-LAST:event_txtNomeKeyPressed

    private void btnBuscarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnBuscarActionPerformed
        // Solicitar ao usuário que digite o nome ou o telefone a ser buscado.
        String busca=JOptionPane.showInputDialog("Digite um nome ou telefone: ","Busca");
        tblRegistros.setModel(new TabelaContato(daoC.busca(busca)));
    }//GEN-LAST:event_btnBuscarActionPerformed

    private void btnRelatorioActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRelatorioActionPerformed
        if(arq.showOpenDialog(this)==JFileChooser.APPROVE_OPTION){
            try{
            JasperViewer.viewReport(gerar(
                    arq.getSelectedFile().getCanonicalPath()), false); // false para não fechar o aplicativo ao fechar o relatorio
            }
            catch(IOException ex){
                
            }
        }
    }//GEN-LAST:event_btnRelatorioActionPerformed

    private void btnAtualizarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAtualizarActionPerformed
       if(!novo) 
        {       
            daoC.atualizar(txtNome.getText(), cmbTipo.getSelectedIndex()+1, txtTelefone.getText());
            JOptionPane.showMessageDialog(this, "Atualizados!");
            novo = true;
            carregaContatos();
        }
        else // Realiza uma nova busca!
        { 
            String busca=JOptionPane.showInputDialog("Digite um nome ou telefone: ","Busca");
            tblRegistros.setModel(new TabelaContato(daoC.busca(busca)));
            novo = false;
            JOptionPane.showMessageDialog(this, "Confirme os dados antes de atualizar");
            
        }
    }//GEN-LAST:event_btnAtualizarActionPerformed

    private void tblRegistrosMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tblRegistrosMouseClicked
        if(evt.getButton() == MouseEvent.BUTTON1){
            if(evt.getClickCount() == 2){
                //Carrega os dados para os campos
                txtTelefone.setText(""+tblRegistros.getValueAt(tblRegistros.getSelectedRow(), 0));
                txtNome.setText(""+tblRegistros.getValueAt(tblRegistros.getSelectedRow(), 1));
                cmbTipo.setSelectedItem(tblRegistros.getValueAt(tblRegistros.getSelectedRow(), 2));
                //Chave primária
                telefone = ""+tblRegistros.getValueAt(tblRegistros.getSelectedRow(), 1);   
                novo = false;
        }
        }
    }//GEN-LAST:event_tblRegistrosMouseClicked

    private void txtNomeKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtNomeKeyTyped
        if (Character.isDigit(evt.getKeyChar())||txtNome.getText().length()>45)
        {
            evt.consume();
        }
    }//GEN-LAST:event_txtNomeKeyTyped

    private void txtTelefoneKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtTelefoneKeyTyped
        if (!Character.isDigit(evt.getKeyChar())||txtTelefone.getText().length()>11)
        {
            evt.consume();
        }
    }//GEN-LAST:event_txtTelefoneKeyTyped

    private void btnExcluirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnExcluirActionPerformed
        if(!novo) 
        {       
            daoC.deletar(txtTelefone.getText());
            JOptionPane.showMessageDialog(this, "Dados removidos!");
            novo = true;
        }
        carregaContatos();
    }//GEN-LAST:event_btnExcluirActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new jfAgenda().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnAtualizar;
    private javax.swing.JButton btnBuscar;
    private javax.swing.JButton btnExcluir;
    private javax.swing.JButton btnGravar;
    private javax.swing.JButton btnListar;
    private javax.swing.JButton btnRelatorio;
    private javax.swing.JComboBox<String> cmbTipo;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JLabel lblData;
    private javax.swing.JLabel lblRelogio;
    private javax.swing.JTable tblRegistros;
    private javax.swing.JTextField txtNome;
    private javax.swing.JTextField txtTelefone;
    // End of variables declaration//GEN-END:variables

    private void carregaContatos() {
        tblRegistros.setModel(new TabelaContato(daoC.populaContatos()));
        txtNome.setText(null);
        txtTelefone.setText(null);
        cmbTipo.setSelectedIndex(-1);
        txtNome.requestFocus();
        novo = true;
    }

    private JasperPrint gerar(String arquivo) {
        JasperPrint rel = null;
        try {
            rel = JasperFillManager.fillReport(arquivo, null,                    
                    Conexao.conectar("root","root"));
        } catch (JRException ex) {
            System.out.println("Erro: "+ex.getMessage());
        }
        catch(SQLException ex){
            System.out.println("Erro: "+ex.getMessage());
        }
        return rel;
    }
    
    private void mostraHora() {
        //Instanciando 
        t1 = new Thread() {//Classe interna criada diretamente
            //Sobreescrita do méotodo run()
            @Override
            public void run() {
                //Na Thread, quando inicia
                Calendar cal;
                //Formatação
                SimpleDateFormat sd = new SimpleDateFormat("HH:mm:ss");
                //Repetição infinita
                while (true) { // Condição para rodar para sempre
                    try {
                        //Obter a data atual
                        cal = Calendar.getInstance();
                        //escrever na label
                        lblRelogio.setText(sd.format(cal.getTime()));
                        //Inserindo uma pausa para a nova requisição
                        Thread.sleep(1000);
                    } catch (InterruptedException ex) {
                    }
                }
            }

        };
        //Forçando a execução
        t1.start();
    }

    private void mostraData() {
        t2 = new Thread() {//Classe interna criada diretamente
            //Sobreescrita do méotodo run()
            @Override
            public void run() {
                //Na Thread, quando inicia
                Calendar cal;
                //Formatação
                SimpleDateFormat sd = new SimpleDateFormat("dd/MM/yyyy");
                //Repetição infinita
                while (true) { // Condição para rodar para sempre
                    try {
                        //Obter a data atual
                        cal = Calendar.getInstance();
                        //escrever na label
                        lblData.setText(sd.format(cal.getTime()));
                        //Inserindo uma pausa para a nova requisição
                        Thread.sleep(1000);
                    } catch (InterruptedException ex) {
                    }
                }
            }

        };
        //Forçando a execução
        t2.start();
    }
}
