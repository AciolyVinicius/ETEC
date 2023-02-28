/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package biblioteca;

import java.awt.CardLayout;
import java.awt.Color;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Calendar;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import javax.swing.DefaultListModel;
import javax.swing.JComponent;
import javax.swing.JMenuBar;
import javax.swing.JOptionPane;

/**
 *
 * @author Aluno
 */
public class jfBiblio extends javax.swing.JFrame {

    Connection con; // Conversa com o Banco
    PreparedStatement ps; // String da query formatada
    PreparedStatement ps1; // String da query formatada
    PreparedStatement ps0; // String da query formatada
    ResultSet rs0; // Retorno do banco
    ResultSet rs; // Retorno do banco
    int categoria;
    DefaultListModel listarCategoria;
    DefaultListModel listarMaterial;
    int diaatual = 11, mesatual=4, anoatual=2018;
    
    /**
     * Creates new form jfLogin
     */
    public jfBiblio() {
        initComponents();
        Calendar dtEmp = Calendar.getInstance();  
        dtEmp.set(Calendar.YEAR,1970);  
        dtEmp.set(Calendar.MONTH,1);  
        dtEmp.set(Calendar.DATE,1);  
        
        this.setLocationRelativeTo(null);
        carregaEditAcervo();
        
        listarCategoria = new DefaultListModel();
        
        try {
            //Abrir a conexao
            con = Biblio_Class.conectar("root","root");
            // Para comparar
            ps = con.prepareStatement("select nm_categoria from tb_categoria ");
            
            rs = ps.executeQuery();
            
            while (rs.next()){
                cb_categoria_cadAcervo.addItem(rs.getString(1));
            }
            
        } catch (SQLException ex) {
            Logger.getLogger(jfBiblio.class.getName()).log(Level.SEVERE, null, ex);
        }     
        
        try {
            //Abrir a conexao
            con = Biblio_Class.conectar("root","root");
            // Para comparar
            ps = con.prepareStatement("select nm_categoria from tb_categoria ");
            
            rs = ps.executeQuery();
            
            while (rs.next()){
                cb_categoria_acervo_update.addItem(rs.getString(1));
            }
            
        } catch (SQLException ex) {
            Logger.getLogger(jfBiblio.class.getName()).log(Level.SEVERE, null, ex);
        }     
         try {
            //Abrir a conexao
            con = Biblio_Class.conectar("root","root");
            // Para comparar
            ps = con.prepareStatement("select nm_tipo from tb_tipo_material ");
            
            rs = ps.executeQuery();
            
            while (rs.next()){
                cb_material_acervo_update.addItem(rs.getString(1));
            }
            
        } catch (SQLException ex) {
            Logger.getLogger(jfBiblio.class.getName()).log(Level.SEVERE, null, ex);
        }      
         
        try {
            //Abrir a conexao
            con = Biblio_Class.conectar("root","root");
            // Para comparar
            ps = con.prepareStatement("select nm_tipo from tb_tipo_material ");
            
            rs = ps.executeQuery();
            
            while (rs.next()){
                cb_tipo_material_cadAcervo.addItem(rs.getString(1));
            }
            
        } catch (SQLException ex) {
            Logger.getLogger(jfBiblio.class.getName()).log(Level.SEVERE, null, ex);
        }             
        
        try {
            //Abrir a conexao
            con = Biblio_Class.conectar("root","root");
            // Para comparar
            ps = con.prepareStatement("select nm_curso from tb_curso");
            
            rs = ps.executeQuery();
            
            while (rs.next()){
                cb_curso_pessoa1.addItem(rs.getString(1));
            }
            
        } catch (SQLException ex) {
            Logger.getLogger(jfBiblio.class.getName()).log(Level.SEVERE, null, ex);
        }     
        try {
            //Abrir a conexao
            con = Biblio_Class.conectar("root","root");
            // Para comparar
            ps = con.prepareStatement("select nm_curso from tb_curso");
            
            rs = ps.executeQuery();
            
            while (rs.next()){
                cb_curso_usuario_update.addItem(rs.getString(1));
            }
            
        } catch (SQLException ex) {
            Logger.getLogger(jfBiblio.class.getName()).log(Level.SEVERE, null, ex);
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

        jpBase = new javax.swing.JPanel();
        jpLogin = new javax.swing.JPanel();
        jPanel3 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jpLoginPart = new javax.swing.JPanel();
        jLabel2 = new javax.swing.JLabel();
        txt_nome_logar = new javax.swing.JTextField();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        txt_codigo_logar = new javax.swing.JTextField();
        btnLogar = new javax.swing.JButton();
        txt_senha_logar = new javax.swing.JPasswordField();
        lbl_confirma = new javax.swing.JLabel();
        jpAcervo = new javax.swing.JPanel();
        jPanel1 = new javax.swing.JPanel();
        jLabel5 = new javax.swing.JLabel();
        jpAcervoPart = new javax.swing.JPanel();
        jScrollPane1 = new javax.swing.JScrollPane();
        tbAcervo = new javax.swing.JTable();
        jpCadastroAcervo = new javax.swing.JPanel();
        jPanel5 = new javax.swing.JPanel();
        jLabel6 = new javax.swing.JLabel();
        jpCadastroAcervoInsert = new javax.swing.JPanel();
        jLabel35 = new javax.swing.JLabel();
        txt_editora_acervo2 = new javax.swing.JTextField();
        jLabel36 = new javax.swing.JLabel();
        txt_edicao_acervo2 = new javax.swing.JTextField();
        jLabel37 = new javax.swing.JLabel();
        jLabel38 = new javax.swing.JLabel();
        jLabel39 = new javax.swing.JLabel();
        txt_autor_acervo2 = new javax.swing.JTextField();
        btn_cadastrar_acervo2 = new javax.swing.JButton();
        jLabel40 = new javax.swing.JLabel();
        cb_tipo_material_cadAcervo = new javax.swing.JComboBox<>();
        txt_nome_acervo2 = new javax.swing.JTextField();
        cb_categoria_cadAcervo = new javax.swing.JComboBox<>();
        jpCadastroPessoa = new javax.swing.JPanel();
        jPanel6 = new javax.swing.JPanel();
        jLabel15 = new javax.swing.JLabel();
        jpCadastroPessoaInsert = new javax.swing.JPanel();
        txt_telefone_pessoa1 = new javax.swing.JTextField();
        btn_cadastrar_pessoa1 = new javax.swing.JButton();
        jLabel17 = new javax.swing.JLabel();
        jLabel25 = new javax.swing.JLabel();
        txt_nome_pessoa1 = new javax.swing.JTextField();
        jLabel26 = new javax.swing.JLabel();
        txt_email_pessoa1 = new javax.swing.JTextField();
        jLabel27 = new javax.swing.JLabel();
        jLabel28 = new javax.swing.JLabel();
        cb_curso_pessoa1 = new javax.swing.JComboBox<>();
        prof = new javax.swing.JCheckBox();
        txt_senha_pessoa1 = new javax.swing.JPasswordField();
        jpEmprestimoEmDia = new javax.swing.JPanel();
        jpAcervoPart1 = new javax.swing.JPanel();
        jScrollPane2 = new javax.swing.JScrollPane();
        tbAcervo1 = new javax.swing.JTable();
        btn_listaremdia = new javax.swing.JButton();
        jPanel2 = new javax.swing.JPanel();
        jLabel7 = new javax.swing.JLabel();
        jpEmprestimoAtrasado = new javax.swing.JPanel();
        jpAcervoPart2 = new javax.swing.JPanel();
        jScrollPane3 = new javax.swing.JScrollPane();
        tbAcervo2 = new javax.swing.JTable();
        btn_listaremdia1 = new javax.swing.JButton();
        jPanel4 = new javax.swing.JPanel();
        jLabel8 = new javax.swing.JLabel();
        jpFazerEmprestimo = new javax.swing.JPanel();
        jPanel7 = new javax.swing.JPanel();
        jLabel9 = new javax.swing.JLabel();
        jLabel18 = new javax.swing.JLabel();
        txt_codigo_fazer_conexao = new javax.swing.JTextField();
        jLabel29 = new javax.swing.JLabel();
        txt_codigo_acervo_fazer_conexao = new javax.swing.JTextField();
        jLabel30 = new javax.swing.JLabel();
        dtEmp = new javax.swing.JFormattedTextField();
        jButton1 = new javax.swing.JButton();
        jpEditarAcervo = new javax.swing.JPanel();
        jPanel8 = new javax.swing.JPanel();
        jLabel10 = new javax.swing.JLabel();
        jpCadastroAcervoInsert1 = new javax.swing.JPanel();
        jLabel41 = new javax.swing.JLabel();
        txt_editora_acervo_update = new javax.swing.JTextField();
        jLabel42 = new javax.swing.JLabel();
        txt_edicao_acervo_update = new javax.swing.JTextField();
        jLabel43 = new javax.swing.JLabel();
        jLabel44 = new javax.swing.JLabel();
        jLabel45 = new javax.swing.JLabel();
        txt_autor_acervo_update = new javax.swing.JTextField();
        btn_cadastrar_acervo3 = new javax.swing.JButton();
        jLabel46 = new javax.swing.JLabel();
        cb_material_acervo_update = new javax.swing.JComboBox<>();
        txt_nome_acervo_update = new javax.swing.JTextField();
        cb_categoria_acervo_update = new javax.swing.JComboBox<>();
        jScrollPane4 = new javax.swing.JScrollPane();
        tbAcervoEdit = new javax.swing.JTable();
        btn_lista_editacervo = new javax.swing.JButton();
        jLabel47 = new javax.swing.JLabel();
        txt_codigo_acervo_update = new javax.swing.JTextField();
        lbl_att_acervo = new javax.swing.JLabel();
        btn_excluir_acervo_update = new javax.swing.JButton();
        jLabel14 = new javax.swing.JLabel();
        jLabel19 = new javax.swing.JLabel();
        jpUsuarios = new javax.swing.JPanel();
        jPanel10 = new javax.swing.JPanel();
        jLabel16 = new javax.swing.JLabel();
        jpAcervoPart3 = new javax.swing.JPanel();
        jScrollPane5 = new javax.swing.JScrollPane();
        tbUsuario = new javax.swing.JTable();
        jpEditarUsuario = new javax.swing.JPanel();
        jPanel9 = new javax.swing.JPanel();
        jLabel11 = new javax.swing.JLabel();
        jpCadastroAcervoInsert2 = new javax.swing.JPanel();
        txt_telefone_usuario_update = new javax.swing.JTextField();
        jLabel49 = new javax.swing.JLabel();
        jLabel51 = new javax.swing.JLabel();
        jLabel52 = new javax.swing.JLabel();
        txt_email_usuario_update = new javax.swing.JTextField();
        btn_cadastrar_usuario_update = new javax.swing.JButton();
        jLabel53 = new javax.swing.JLabel();
        cb_curso_usuario_update = new javax.swing.JComboBox<>();
        txt_nome_usuario_update = new javax.swing.JTextField();
        jScrollPane6 = new javax.swing.JScrollPane();
        tbUsuarioEdit = new javax.swing.JTable();
        btn_lista_editusuario = new javax.swing.JButton();
        jLabel54 = new javax.swing.JLabel();
        txt_codigo_usuario_update = new javax.swing.JTextField();
        lbl_att_acervo1 = new javax.swing.JLabel();
        btn_excluir_usuario_update = new javax.swing.JButton();
        jLabel12 = new javax.swing.JLabel();
        jLabel13 = new javax.swing.JLabel();
        jMenuBar1 = new javax.swing.JMenuBar();
        jMenu = new javax.swing.JMenu();
        rbLogin = new javax.swing.JRadioButtonMenuItem();
        rbAcervo = new javax.swing.JRadioButtonMenuItem();
        rbCadPessoa = new javax.swing.JRadioButtonMenuItem();
        rbCadAcervo = new javax.swing.JRadioButtonMenuItem();
        rbEmprestimoEmDia = new javax.swing.JRadioButtonMenuItem();
        rbEmprestimoAtrasado = new javax.swing.JRadioButtonMenuItem();
        rbFazerEmprestimo = new javax.swing.JRadioButtonMenuItem();
        rbUsuarios = new javax.swing.JRadioButtonMenuItem();
        rbEditarAcervo = new javax.swing.JRadioButtonMenuItem();
        rbEditarUsuario = new javax.swing.JRadioButtonMenuItem();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jpBase.setLayout(new java.awt.CardLayout());

        jpLogin.setLayout(new java.awt.BorderLayout());

        jPanel3.setBackground(new java.awt.Color(0, 0, 102));

        jLabel1.setBackground(new java.awt.Color(255, 255, 255));
        jLabel1.setFont(new java.awt.Font("Verdana", 1, 36)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(255, 255, 255));
        jLabel1.setText("LOGIN");

        javax.swing.GroupLayout jPanel3Layout = new javax.swing.GroupLayout(jPanel3);
        jPanel3.setLayout(jPanel3Layout);
        jPanel3Layout.setHorizontalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addGap(221, 221, 221)
                .addComponent(jLabel1)
                .addContainerGap(265, Short.MAX_VALUE))
        );
        jPanel3Layout.setVerticalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel3Layout.createSequentialGroup()
                .addContainerGap(75, Short.MAX_VALUE)
                .addComponent(jLabel1)
                .addContainerGap())
        );

        jpLogin.add(jPanel3, java.awt.BorderLayout.PAGE_START);

        jLabel2.setFont(new java.awt.Font("Verdana", 0, 18)); // NOI18N
        jLabel2.setText("NOME:");

        txt_nome_logar.setFont(new java.awt.Font("Verdana", 0, 18)); // NOI18N
        txt_nome_logar.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_nome_logarKeyTyped(evt);
            }
        });

        jLabel3.setFont(new java.awt.Font("Verdana", 0, 18)); // NOI18N
        jLabel3.setText("SENHA:");

        jLabel4.setFont(new java.awt.Font("Verdana", 0, 18)); // NOI18N
        jLabel4.setText("CÓDIGO:");

        txt_codigo_logar.setFont(new java.awt.Font("Verdana", 0, 18)); // NOI18N
        txt_codigo_logar.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_codigo_logarKeyTyped(evt);
            }
        });

        btnLogar.setFont(new java.awt.Font("Verdana", 0, 36)); // NOI18N
        btnLogar.setText("LOGAR");
        btnLogar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnLogarActionPerformed(evt);
            }
        });

        txt_senha_logar.setFont(new java.awt.Font("Verdana", 0, 18)); // NOI18N
        txt_senha_logar.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_senha_logarKeyTyped(evt);
            }
        });

        lbl_confirma.setBackground(new java.awt.Color(255, 255, 255));
        lbl_confirma.setFont(new java.awt.Font("Verdana", 1, 18)); // NOI18N
        lbl_confirma.setForeground(new java.awt.Color(255, 255, 255));

        javax.swing.GroupLayout jpLoginPartLayout = new javax.swing.GroupLayout(jpLoginPart);
        jpLoginPart.setLayout(jpLoginPartLayout);
        jpLoginPartLayout.setHorizontalGroup(
            jpLoginPartLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jpLoginPartLayout.createSequentialGroup()
                .addGap(23, 23, 23)
                .addGroup(jpLoginPartLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jpLoginPartLayout.createSequentialGroup()
                        .addComponent(btnLogar)
                        .addGap(0, 0, Short.MAX_VALUE))
                    .addGroup(jpLoginPartLayout.createSequentialGroup()
                        .addComponent(lbl_confirma)
                        .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                    .addGroup(jpLoginPartLayout.createSequentialGroup()
                        .addGroup(jpLoginPartLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel2)
                            .addComponent(jLabel3)
                            .addComponent(jLabel4))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(jpLoginPartLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(txt_nome_logar, javax.swing.GroupLayout.PREFERRED_SIZE, 487, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txt_senha_logar)
                            .addComponent(txt_codigo_logar))
                        .addContainerGap(20, Short.MAX_VALUE))))
        );
        jpLoginPartLayout.setVerticalGroup(
            jpLoginPartLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jpLoginPartLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jpLoginPartLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(txt_nome_logar, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jpLoginPartLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3)
                    .addComponent(txt_senha_logar, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jpLoginPartLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel4)
                    .addComponent(txt_codigo_logar, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addComponent(btnLogar)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 76, Short.MAX_VALUE)
                .addComponent(lbl_confirma)
                .addContainerGap())
        );

        jpLogin.add(jpLoginPart, java.awt.BorderLayout.CENTER);

        jpBase.add(jpLogin, "login");

        jpAcervo.setBackground(new java.awt.Color(255, 255, 255));
        jpAcervo.setLayout(new java.awt.BorderLayout());

        jPanel1.setBackground(new java.awt.Color(0, 0, 102));

        jLabel5.setFont(new java.awt.Font("Verdana", 1, 36)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(255, 255, 255));
        jLabel5.setText("ACERVO");

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(223, 223, 223)
                .addComponent(jLabel5)
                .addContainerGap(224, Short.MAX_VALUE))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(37, 37, 37)
                .addComponent(jLabel5)
                .addContainerGap(49, Short.MAX_VALUE))
        );

        jpAcervo.add(jPanel1, java.awt.BorderLayout.PAGE_START);

        tbAcervo.setFont(new java.awt.Font("Arial", 0, 10)); // NOI18N
        tbAcervo.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jScrollPane1.setViewportView(tbAcervo);

        javax.swing.GroupLayout jpAcervoPartLayout = new javax.swing.GroupLayout(jpAcervoPart);
        jpAcervoPart.setLayout(jpAcervoPartLayout);
        jpAcervoPartLayout.setHorizontalGroup(
            jpAcervoPartLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jpAcervoPartLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 593, Short.MAX_VALUE)
                .addContainerGap())
        );
        jpAcervoPartLayout.setVerticalGroup(
            jpAcervoPartLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jpAcervoPartLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 246, Short.MAX_VALUE)
                .addContainerGap())
        );

        jpAcervo.add(jpAcervoPart, java.awt.BorderLayout.CENTER);

        jpBase.add(jpAcervo, "acervo");

        jpCadastroAcervo.setLayout(new java.awt.BorderLayout());

        jPanel5.setBackground(new java.awt.Color(0, 0, 102));

        jLabel6.setFont(new java.awt.Font("Verdana", 1, 36)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(255, 255, 255));
        jLabel6.setText("CADASTRO");

        javax.swing.GroupLayout jPanel5Layout = new javax.swing.GroupLayout(jPanel5);
        jPanel5.setLayout(jPanel5Layout);
        jPanel5Layout.setHorizontalGroup(
            jPanel5Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel5Layout.createSequentialGroup()
                .addGap(170, 170, 170)
                .addComponent(jLabel6)
                .addContainerGap(221, Short.MAX_VALUE))
        );
        jPanel5Layout.setVerticalGroup(
            jPanel5Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel5Layout.createSequentialGroup()
                .addContainerGap(45, Short.MAX_VALUE)
                .addComponent(jLabel6)
                .addGap(41, 41, 41))
        );

        jpCadastroAcervo.add(jPanel5, java.awt.BorderLayout.PAGE_START);

        jLabel35.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel35.setText("CATEGORIA:");

        txt_editora_acervo2.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        txt_editora_acervo2.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_editora_acervo2KeyTyped(evt);
            }
        });

        jLabel36.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel36.setText("AUTOR:");

        txt_edicao_acervo2.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        txt_edicao_acervo2.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_edicao_acervo2KeyTyped(evt);
            }
        });

        jLabel37.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel37.setText("EDIÇÃO:");

        jLabel38.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel38.setText("NOME:");

        jLabel39.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel39.setText("TIPO DE MATERIAL:");

        txt_autor_acervo2.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        txt_autor_acervo2.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_autor_acervo2KeyTyped(evt);
            }
        });

        btn_cadastrar_acervo2.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        btn_cadastrar_acervo2.setText("CADASTRAR");
        btn_cadastrar_acervo2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_cadastrar_acervo2ActionPerformed(evt);
            }
        });

        jLabel40.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel40.setText("EDITORA:");

        cb_tipo_material_cadAcervo.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N

        txt_nome_acervo2.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        txt_nome_acervo2.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_nome_acervo2KeyTyped(evt);
            }
        });

        cb_categoria_cadAcervo.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N

        javax.swing.GroupLayout jpCadastroAcervoInsertLayout = new javax.swing.GroupLayout(jpCadastroAcervoInsert);
        jpCadastroAcervoInsert.setLayout(jpCadastroAcervoInsertLayout);
        jpCadastroAcervoInsertLayout.setHorizontalGroup(
            jpCadastroAcervoInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jpCadastroAcervoInsertLayout.createSequentialGroup()
                .addGap(72, 72, 72)
                .addGroup(jpCadastroAcervoInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel35)
                    .addComponent(jLabel40)
                    .addComponent(jLabel37)
                    .addComponent(jLabel36)
                    .addComponent(jLabel38)
                    .addComponent(jLabel39))
                .addGap(28, 28, 28)
                .addGroup(jpCadastroAcervoInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(cb_tipo_material_cadAcervo, javax.swing.GroupLayout.Alignment.LEADING, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(txt_edicao_acervo2, javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(txt_autor_acervo2, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, 306, Short.MAX_VALUE)
                    .addComponent(txt_editora_acervo2, javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(txt_nome_acervo2, javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(cb_categoria_cadAcervo, javax.swing.GroupLayout.Alignment.LEADING, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addGap(66, 66, 66))
            .addGroup(jpCadastroAcervoInsertLayout.createSequentialGroup()
                .addGap(222, 222, 222)
                .addComponent(btn_cadastrar_acervo2)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        jpCadastroAcervoInsertLayout.setVerticalGroup(
            jpCadastroAcervoInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jpCadastroAcervoInsertLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jpCadastroAcervoInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txt_nome_acervo2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel38))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jpCadastroAcervoInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txt_editora_acervo2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel40))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jpCadastroAcervoInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txt_autor_acervo2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel36))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jpCadastroAcervoInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txt_edicao_acervo2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel37))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jpCadastroAcervoInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel35)
                    .addComponent(cb_categoria_cadAcervo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jpCadastroAcervoInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel39)
                    .addComponent(cb_tipo_material_cadAcervo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(14, 14, 14)
                .addComponent(btn_cadastrar_acervo2)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        jpCadastroAcervo.add(jpCadastroAcervoInsert, java.awt.BorderLayout.PAGE_END);

        jpBase.add(jpCadastroAcervo, "cadastroacervo");

        jpCadastroPessoa.setLayout(new java.awt.BorderLayout());

        jPanel6.setBackground(new java.awt.Color(0, 0, 102));

        jLabel15.setFont(new java.awt.Font("Verdana", 1, 36)); // NOI18N
        jLabel15.setForeground(new java.awt.Color(255, 255, 255));
        jLabel15.setText("CADASTRO");

        javax.swing.GroupLayout jPanel6Layout = new javax.swing.GroupLayout(jPanel6);
        jPanel6.setLayout(jPanel6Layout);
        jPanel6Layout.setHorizontalGroup(
            jPanel6Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel6Layout.createSequentialGroup()
                .addGap(182, 182, 182)
                .addComponent(jLabel15)
                .addContainerGap(209, Short.MAX_VALUE))
        );
        jPanel6Layout.setVerticalGroup(
            jPanel6Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel6Layout.createSequentialGroup()
                .addContainerGap(46, Short.MAX_VALUE)
                .addComponent(jLabel15)
                .addGap(40, 40, 40))
        );

        jpCadastroPessoa.add(jPanel6, java.awt.BorderLayout.PAGE_START);

        txt_telefone_pessoa1.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        txt_telefone_pessoa1.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_telefone_pessoa1KeyTyped(evt);
            }
        });

        btn_cadastrar_pessoa1.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        btn_cadastrar_pessoa1.setText("CADASTRAR");
        btn_cadastrar_pessoa1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_cadastrar_pessoa1ActionPerformed(evt);
            }
        });

        jLabel17.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel17.setText("NOME:");

        jLabel25.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel25.setText("SENHA:");

        txt_nome_pessoa1.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        txt_nome_pessoa1.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_nome_pessoa1KeyTyped(evt);
            }
        });

        jLabel26.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel26.setText("TELEFONE:");

        txt_email_pessoa1.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        txt_email_pessoa1.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_email_pessoa1KeyTyped(evt);
            }
        });

        jLabel27.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel27.setText("EMAIL");

        jLabel28.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel28.setText("Curso:");

        cb_curso_pessoa1.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N

        prof.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        prof.setText("PROFESSOR");

        txt_senha_pessoa1.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        txt_senha_pessoa1.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_senha_pessoa1KeyTyped(evt);
            }
        });

        javax.swing.GroupLayout jpCadastroPessoaInsertLayout = new javax.swing.GroupLayout(jpCadastroPessoaInsert);
        jpCadastroPessoaInsert.setLayout(jpCadastroPessoaInsertLayout);
        jpCadastroPessoaInsertLayout.setHorizontalGroup(
            jpCadastroPessoaInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jpCadastroPessoaInsertLayout.createSequentialGroup()
                .addGap(72, 72, 72)
                .addGroup(jpCadastroPessoaInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jpCadastroPessoaInsertLayout.createSequentialGroup()
                        .addComponent(prof)
                        .addGap(0, 0, Short.MAX_VALUE))
                    .addGroup(jpCadastroPessoaInsertLayout.createSequentialGroup()
                        .addGroup(jpCadastroPessoaInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel25)
                            .addComponent(jLabel17)
                            .addComponent(jLabel27)
                            .addComponent(jLabel26)
                            .addComponent(jLabel28))
                        .addGap(28, 28, 28)
                        .addGroup(jpCadastroPessoaInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jpCadastroPessoaInsertLayout.createSequentialGroup()
                                .addGroup(jpCadastroPessoaInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addComponent(cb_curso_pessoa1, javax.swing.GroupLayout.Alignment.LEADING, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addComponent(txt_email_pessoa1, javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(txt_telefone_pessoa1, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, 368, Short.MAX_VALUE)
                                    .addComponent(txt_nome_pessoa1, javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(txt_senha_pessoa1))
                                .addGap(66, 66, 66))
                            .addGroup(jpCadastroPessoaInsertLayout.createSequentialGroup()
                                .addGap(58, 58, 58)
                                .addComponent(btn_cadastrar_pessoa1)
                                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))))))
        );
        jpCadastroPessoaInsertLayout.setVerticalGroup(
            jpCadastroPessoaInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jpCadastroPessoaInsertLayout.createSequentialGroup()
                .addGap(41, 41, 41)
                .addGroup(jpCadastroPessoaInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txt_nome_pessoa1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel17))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jpCadastroPessoaInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txt_telefone_pessoa1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel26))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jpCadastroPessoaInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txt_email_pessoa1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel27))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jpCadastroPessoaInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel25)
                    .addComponent(txt_senha_pessoa1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jpCadastroPessoaInsertLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel28)
                    .addComponent(cb_curso_pessoa1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addComponent(prof)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(btn_cadastrar_pessoa1, javax.swing.GroupLayout.PREFERRED_SIZE, 27, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );

        jpCadastroPessoa.add(jpCadastroPessoaInsert, java.awt.BorderLayout.CENTER);

        jpBase.add(jpCadastroPessoa, "cadastropessoa");

        tbAcervo1.setFont(new java.awt.Font("Arial", 0, 10)); // NOI18N
        tbAcervo1.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jScrollPane2.setViewportView(tbAcervo1);

        btn_listaremdia.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        btn_listaremdia.setText("LISTAR");
        btn_listaremdia.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_listaremdiaActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jpAcervoPart1Layout = new javax.swing.GroupLayout(jpAcervoPart1);
        jpAcervoPart1.setLayout(jpAcervoPart1Layout);
        jpAcervoPart1Layout.setHorizontalGroup(
            jpAcervoPart1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jpAcervoPart1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jpAcervoPart1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 593, Short.MAX_VALUE)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jpAcervoPart1Layout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addComponent(btn_listaremdia)))
                .addContainerGap())
        );
        jpAcervoPart1Layout.setVerticalGroup(
            jpAcervoPart1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jpAcervoPart1Layout.createSequentialGroup()
                .addGap(39, 39, 39)
                .addComponent(btn_listaremdia)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 181, Short.MAX_VALUE)
                .addContainerGap())
        );

        jPanel2.setBackground(new java.awt.Color(0, 0, 102));

        jLabel7.setFont(new java.awt.Font("Verdana", 1, 36)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(255, 255, 255));
        jLabel7.setText("EMPRÉSTIMOS EM DIA");

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                .addContainerGap(112, Short.MAX_VALUE)
                .addComponent(jLabel7)
                .addGap(40, 40, 40))
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addGap(36, 36, 36)
                .addComponent(jLabel7)
                .addContainerGap(50, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout jpEmprestimoEmDiaLayout = new javax.swing.GroupLayout(jpEmprestimoEmDia);
        jpEmprestimoEmDia.setLayout(jpEmprestimoEmDiaLayout);
        jpEmprestimoEmDiaLayout.setHorizontalGroup(
            jpEmprestimoEmDiaLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(jpAcervoPart1, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        jpEmprestimoEmDiaLayout.setVerticalGroup(
            jpEmprestimoEmDiaLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jpEmprestimoEmDiaLayout.createSequentialGroup()
                .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jpAcervoPart1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, Short.MAX_VALUE))
        );

        jpBase.add(jpEmprestimoEmDia, "emprestimoemdia");

        tbAcervo2.setFont(new java.awt.Font("Arial", 0, 10)); // NOI18N
        tbAcervo2.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jScrollPane3.setViewportView(tbAcervo2);

        btn_listaremdia1.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        btn_listaremdia1.setText("LISTAR");
        btn_listaremdia1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_listaremdia1ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jpAcervoPart2Layout = new javax.swing.GroupLayout(jpAcervoPart2);
        jpAcervoPart2.setLayout(jpAcervoPart2Layout);
        jpAcervoPart2Layout.setHorizontalGroup(
            jpAcervoPart2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jpAcervoPart2Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jpAcervoPart2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane3)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jpAcervoPart2Layout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addComponent(btn_listaremdia1)))
                .addContainerGap())
        );
        jpAcervoPart2Layout.setVerticalGroup(
            jpAcervoPart2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jpAcervoPart2Layout.createSequentialGroup()
                .addGap(39, 39, 39)
                .addComponent(btn_listaremdia1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane3, javax.swing.GroupLayout.DEFAULT_SIZE, 181, Short.MAX_VALUE)
                .addContainerGap())
        );

        jPanel4.setBackground(new java.awt.Color(0, 0, 102));

        jLabel8.setFont(new java.awt.Font("Verdana", 1, 36)); // NOI18N
        jLabel8.setForeground(new java.awt.Color(255, 255, 255));
        jLabel8.setText("EMPRÉSTIMOS ATRASADOS");

        javax.swing.GroupLayout jPanel4Layout = new javax.swing.GroupLayout(jPanel4);
        jPanel4.setLayout(jPanel4Layout);
        jPanel4Layout.setHorizontalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel4Layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jLabel8)
                .addGap(40, 40, 40))
        );
        jPanel4Layout.setVerticalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel4Layout.createSequentialGroup()
                .addGap(36, 36, 36)
                .addComponent(jLabel8)
                .addContainerGap(50, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout jpEmprestimoAtrasadoLayout = new javax.swing.GroupLayout(jpEmprestimoAtrasado);
        jpEmprestimoAtrasado.setLayout(jpEmprestimoAtrasadoLayout);
        jpEmprestimoAtrasadoLayout.setHorizontalGroup(
            jpEmprestimoAtrasadoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel4, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addComponent(jpAcervoPart2, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        jpEmprestimoAtrasadoLayout.setVerticalGroup(
            jpEmprestimoAtrasadoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jpEmprestimoAtrasadoLayout.createSequentialGroup()
                .addComponent(jPanel4, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jpAcervoPart2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, Short.MAX_VALUE))
        );

        jpBase.add(jpEmprestimoAtrasado, "emprestimoatrasado");

        jPanel7.setBackground(new java.awt.Color(0, 0, 102));

        jLabel9.setFont(new java.awt.Font("Verdana", 1, 36)); // NOI18N
        jLabel9.setForeground(new java.awt.Color(255, 255, 255));
        jLabel9.setText("FAZER EMPRÉSTIMOS");

        javax.swing.GroupLayout jPanel7Layout = new javax.swing.GroupLayout(jPanel7);
        jPanel7.setLayout(jPanel7Layout);
        jPanel7Layout.setHorizontalGroup(
            jPanel7Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel7Layout.createSequentialGroup()
                .addContainerGap(108, Short.MAX_VALUE)
                .addComponent(jLabel9)
                .addGap(64, 64, 64))
        );
        jPanel7Layout.setVerticalGroup(
            jPanel7Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel7Layout.createSequentialGroup()
                .addGap(40, 40, 40)
                .addComponent(jLabel9)
                .addContainerGap(46, Short.MAX_VALUE))
        );

        jLabel18.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel18.setText("CÓDIGO DA PESSOA:");

        txt_codigo_fazer_conexao.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        txt_codigo_fazer_conexao.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_codigo_fazer_conexaoKeyTyped(evt);
            }
        });

        jLabel29.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel29.setText("CÓDIGO DO ITEM DO ACERVO");

        txt_codigo_acervo_fazer_conexao.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        txt_codigo_acervo_fazer_conexao.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_codigo_acervo_fazer_conexaoKeyTyped(evt);
            }
        });

        jLabel30.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel30.setText("DIA DO EMPRÉSTIMO:");

        dtEmp.setFormatterFactory(new javax.swing.text.DefaultFormatterFactory(new javax.swing.text.DateFormatter()));
        dtEmp.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        dtEmp.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                dtEmpActionPerformed(evt);
            }
        });
        dtEmp.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                dtEmpKeyTyped(evt);
            }
        });

        jButton1.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        jButton1.setText("EFETUAR EMPREÉSTIMO");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jpFazerEmprestimoLayout = new javax.swing.GroupLayout(jpFazerEmprestimo);
        jpFazerEmprestimo.setLayout(jpFazerEmprestimoLayout);
        jpFazerEmprestimoLayout.setHorizontalGroup(
            jpFazerEmprestimoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel7, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(jpFazerEmprestimoLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jpFazerEmprestimoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel29)
                    .addComponent(jLabel18)
                    .addComponent(jLabel30))
                .addGap(28, 28, 28)
                .addGroup(jpFazerEmprestimoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(txt_codigo_fazer_conexao)
                    .addComponent(txt_codigo_acervo_fazer_conexao)
                    .addComponent(dtEmp))
                .addContainerGap())
            .addGroup(jpFazerEmprestimoLayout.createSequentialGroup()
                .addGap(194, 194, 194)
                .addComponent(jButton1)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        jpFazerEmprestimoLayout.setVerticalGroup(
            jpFazerEmprestimoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jpFazerEmprestimoLayout.createSequentialGroup()
                .addComponent(jPanel7, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addGroup(jpFazerEmprestimoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txt_codigo_fazer_conexao, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel18))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(jpFazerEmprestimoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txt_codigo_acervo_fazer_conexao, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel29))
                .addGap(18, 18, 18)
                .addGroup(jpFazerEmprestimoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel30)
                    .addComponent(dtEmp, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(47, 47, 47)
                .addComponent(jButton1)
                .addContainerGap())
        );

        jpBase.add(jpFazerEmprestimo, "fazeremprestimo");

        jpEditarAcervo.setLayout(new java.awt.BorderLayout());

        jPanel8.setBackground(new java.awt.Color(0, 0, 102));

        jLabel10.setFont(new java.awt.Font("Verdana", 1, 36)); // NOI18N
        jLabel10.setForeground(new java.awt.Color(255, 255, 255));
        jLabel10.setText("ATUALIZAÇÃO");

        javax.swing.GroupLayout jPanel8Layout = new javax.swing.GroupLayout(jPanel8);
        jPanel8.setLayout(jPanel8Layout);
        jPanel8Layout.setHorizontalGroup(
            jPanel8Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel8Layout.createSequentialGroup()
                .addContainerGap(142, Short.MAX_VALUE)
                .addComponent(jLabel10)
                .addGap(180, 180, 180))
        );
        jPanel8Layout.setVerticalGroup(
            jPanel8Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel8Layout.createSequentialGroup()
                .addContainerGap(45, Short.MAX_VALUE)
                .addComponent(jLabel10)
                .addGap(41, 41, 41))
        );

        jpEditarAcervo.add(jPanel8, java.awt.BorderLayout.PAGE_START);

        jLabel41.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel41.setText("CATEGORIA:");

        txt_editora_acervo_update.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N

        jLabel42.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel42.setText("AUTOR:");

        txt_edicao_acervo_update.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        txt_edicao_acervo_update.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_edicao_acervo_updateKeyTyped(evt);
            }
        });

        jLabel43.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel43.setText("EDIÇÃO:");

        jLabel44.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel44.setText("NOME:");

        jLabel45.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel45.setText("TIPO DE MATERIAL:");

        txt_autor_acervo_update.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N

        btn_cadastrar_acervo3.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        btn_cadastrar_acervo3.setText("EDITAR");
        btn_cadastrar_acervo3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_cadastrar_acervo3ActionPerformed(evt);
            }
        });

        jLabel46.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel46.setText("EDITORA:");

        cb_material_acervo_update.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N

        txt_nome_acervo_update.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        txt_nome_acervo_update.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txt_nome_acervo_updateActionPerformed(evt);
            }
        });

        cb_categoria_acervo_update.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N

        tbAcervoEdit.setFont(new java.awt.Font("Arial", 0, 10)); // NOI18N
        tbAcervoEdit.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jScrollPane4.setViewportView(tbAcervoEdit);

        btn_lista_editacervo.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        btn_lista_editacervo.setText("REFRESH");
        btn_lista_editacervo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_lista_editacervoActionPerformed(evt);
            }
        });

        jLabel47.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel47.setText("CÓDIGO:");

        txt_codigo_acervo_update.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        txt_codigo_acervo_update.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txt_codigo_acervo_updateActionPerformed(evt);
            }
        });
        txt_codigo_acervo_update.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_codigo_acervo_updateKeyTyped(evt);
            }
        });

        lbl_att_acervo.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N

        btn_excluir_acervo_update.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        btn_excluir_acervo_update.setText("EXCLUIR");
        btn_excluir_acervo_update.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_excluir_acervo_updateActionPerformed(evt);
            }
        });

        jLabel14.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel14.setText("/");

        jLabel19.setText("PELO CÓDIGO:");

        javax.swing.GroupLayout jpCadastroAcervoInsert1Layout = new javax.swing.GroupLayout(jpCadastroAcervoInsert1);
        jpCadastroAcervoInsert1.setLayout(jpCadastroAcervoInsert1Layout);
        jpCadastroAcervoInsert1Layout.setHorizontalGroup(
            jpCadastroAcervoInsert1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jpCadastroAcervoInsert1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jpCadastroAcervoInsert1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jpCadastroAcervoInsert1Layout.createSequentialGroup()
                        .addGroup(jpCadastroAcervoInsert1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jpCadastroAcervoInsert1Layout.createSequentialGroup()
                                .addComponent(jLabel47, javax.swing.GroupLayout.DEFAULT_SIZE, 88, Short.MAX_VALUE)
                                .addGap(76, 76, 76))
                            .addGroup(jpCadastroAcervoInsert1Layout.createSequentialGroup()
                                .addComponent(jLabel44, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addGap(94, 94, 94))
                            .addGroup(jpCadastroAcervoInsert1Layout.createSequentialGroup()
                                .addComponent(jLabel46, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addGap(70, 70, 70))
                            .addGroup(jpCadastroAcervoInsert1Layout.createSequentialGroup()
                                .addComponent(jLabel42, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addGap(85, 85, 85))
                            .addGroup(jpCadastroAcervoInsert1Layout.createSequentialGroup()
                                .addComponent(jLabel43, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addGap(79, 79, 79))
                            .addGroup(jpCadastroAcervoInsert1Layout.createSequentialGroup()
                                .addComponent(jLabel41, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addGap(50, 50, 50))
                            .addComponent(jLabel45, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                        .addGap(18, 18, 18))
                    .addGroup(jpCadastroAcervoInsert1Layout.createSequentialGroup()
                        .addComponent(btn_cadastrar_acervo3)
                        .addGap(72, 72, 72)))
                .addGroup(jpCadastroAcervoInsert1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jpCadastroAcervoInsert1Layout.createSequentialGroup()
                        .addComponent(lbl_att_acervo, javax.swing.GroupLayout.DEFAULT_SIZE, 22, Short.MAX_VALUE)
                        .addGap(81, 81, 81)
                        .addComponent(jLabel19)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(btn_excluir_acervo_update, javax.swing.GroupLayout.PREFERRED_SIZE, 99, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(12, 12, 12)
                        .addComponent(jLabel14)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(btn_lista_editacervo, javax.swing.GroupLayout.PREFERRED_SIZE, 99, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jpCadastroAcervoInsert1Layout.createSequentialGroup()
                        .addGroup(jpCadastroAcervoInsert1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(txt_codigo_acervo_update)
                            .addComponent(txt_edicao_acervo_update, javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(txt_autor_acervo_update, javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(txt_editora_acervo_update, javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(txt_nome_acervo_update, javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(cb_material_acervo_update, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(cb_categoria_acervo_update, javax.swing.GroupLayout.Alignment.LEADING, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                        .addGap(18, 18, 18)
                        .addComponent(jScrollPane4, javax.swing.GroupLayout.PREFERRED_SIZE, 222, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap())
        );
        jpCadastroAcervoInsert1Layout.setVerticalGroup(
            jpCadastroAcervoInsert1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jpCadastroAcervoInsert1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jpCadastroAcervoInsert1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(jpCadastroAcervoInsert1Layout.createSequentialGroup()
                        .addComponent(jScrollPane4, javax.swing.GroupLayout.PREFERRED_SIZE, 204, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGroup(jpCadastroAcervoInsert1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jpCadastroAcervoInsert1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                .addComponent(btn_excluir_acervo_update)
                                .addComponent(jLabel19)
                                .addComponent(jLabel14, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                            .addComponent(btn_lista_editacervo)))
                    .addGroup(jpCadastroAcervoInsert1Layout.createSequentialGroup()
                        .addGap(0, 4, Short.MAX_VALUE)
                        .addGroup(jpCadastroAcervoInsert1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jLabel45)
                            .addGroup(jpCadastroAcervoInsert1Layout.createSequentialGroup()
                                .addGroup(jpCadastroAcervoInsert1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                    .addComponent(txt_codigo_acervo_update, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(jLabel47))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(jpCadastroAcervoInsert1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                    .addComponent(txt_nome_acervo_update, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(jLabel44))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(jpCadastroAcervoInsert1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                    .addComponent(txt_editora_acervo_update, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(jLabel46))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(jpCadastroAcervoInsert1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                    .addComponent(txt_autor_acervo_update, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(jLabel42))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(jpCadastroAcervoInsert1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                    .addComponent(txt_edicao_acervo_update, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(jLabel43))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(jpCadastroAcervoInsert1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                    .addComponent(cb_categoria_acervo_update, javax.swing.GroupLayout.PREFERRED_SIZE, 24, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(jLabel41))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(cb_material_acervo_update, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(jpCadastroAcervoInsert1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(btn_cadastrar_acervo3)
                            .addComponent(lbl_att_acervo))))
                .addContainerGap())
        );

        jpEditarAcervo.add(jpCadastroAcervoInsert1, java.awt.BorderLayout.PAGE_END);

        jpBase.add(jpEditarAcervo, "editaracervo");

        jpUsuarios.setBackground(new java.awt.Color(255, 255, 255));
        jpUsuarios.setLayout(new java.awt.BorderLayout());

        jPanel10.setBackground(new java.awt.Color(0, 0, 102));

        jLabel16.setFont(new java.awt.Font("Verdana", 1, 36)); // NOI18N
        jLabel16.setForeground(new java.awt.Color(255, 255, 255));
        jLabel16.setText("USUÁRIOS");

        javax.swing.GroupLayout jPanel10Layout = new javax.swing.GroupLayout(jPanel10);
        jPanel10.setLayout(jPanel10Layout);
        jPanel10Layout.setHorizontalGroup(
            jPanel10Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel10Layout.createSequentialGroup()
                .addGap(196, 196, 196)
                .addComponent(jLabel16)
                .addContainerGap(200, Short.MAX_VALUE))
        );
        jPanel10Layout.setVerticalGroup(
            jPanel10Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel10Layout.createSequentialGroup()
                .addGap(33, 33, 33)
                .addComponent(jLabel16)
                .addContainerGap(53, Short.MAX_VALUE))
        );

        jpUsuarios.add(jPanel10, java.awt.BorderLayout.PAGE_START);

        tbUsuario.setFont(new java.awt.Font("Arial", 0, 10)); // NOI18N
        tbUsuario.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jScrollPane5.setViewportView(tbUsuario);

        javax.swing.GroupLayout jpAcervoPart3Layout = new javax.swing.GroupLayout(jpAcervoPart3);
        jpAcervoPart3.setLayout(jpAcervoPart3Layout);
        jpAcervoPart3Layout.setHorizontalGroup(
            jpAcervoPart3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jpAcervoPart3Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane5, javax.swing.GroupLayout.DEFAULT_SIZE, 593, Short.MAX_VALUE)
                .addContainerGap())
        );
        jpAcervoPart3Layout.setVerticalGroup(
            jpAcervoPart3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jpAcervoPart3Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane5, javax.swing.GroupLayout.DEFAULT_SIZE, 246, Short.MAX_VALUE)
                .addContainerGap())
        );

        jpUsuarios.add(jpAcervoPart3, java.awt.BorderLayout.CENTER);

        jpBase.add(jpUsuarios, "usuario");

        jpEditarUsuario.setLayout(new java.awt.BorderLayout());

        jPanel9.setBackground(new java.awt.Color(0, 0, 102));

        jLabel11.setFont(new java.awt.Font("Verdana", 1, 36)); // NOI18N
        jLabel11.setForeground(new java.awt.Color(255, 255, 255));
        jLabel11.setText("ATUALIZAÇÃO");

        javax.swing.GroupLayout jPanel9Layout = new javax.swing.GroupLayout(jPanel9);
        jPanel9.setLayout(jPanel9Layout);
        jPanel9Layout.setHorizontalGroup(
            jPanel9Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel9Layout.createSequentialGroup()
                .addContainerGap(142, Short.MAX_VALUE)
                .addComponent(jLabel11)
                .addGap(180, 180, 180))
        );
        jPanel9Layout.setVerticalGroup(
            jPanel9Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel9Layout.createSequentialGroup()
                .addContainerGap(45, Short.MAX_VALUE)
                .addComponent(jLabel11)
                .addGap(41, 41, 41))
        );

        jpEditarUsuario.add(jPanel9, java.awt.BorderLayout.PAGE_START);

        txt_telefone_usuario_update.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        txt_telefone_usuario_update.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_telefone_usuario_updateKeyTyped(evt);
            }
        });

        jLabel49.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel49.setText("EMAIL:");

        jLabel51.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel51.setText("NOME:");

        jLabel52.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel52.setText("CURSO:");

        txt_email_usuario_update.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N

        btn_cadastrar_usuario_update.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        btn_cadastrar_usuario_update.setText("EDITAR");
        btn_cadastrar_usuario_update.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_cadastrar_usuario_updateActionPerformed(evt);
            }
        });

        jLabel53.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel53.setText("TELEFONE:");

        cb_curso_usuario_update.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N

        txt_nome_usuario_update.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        txt_nome_usuario_update.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txt_nome_usuario_updateActionPerformed(evt);
            }
        });

        tbUsuarioEdit.setFont(new java.awt.Font("Arial", 0, 10)); // NOI18N
        tbUsuarioEdit.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jScrollPane6.setViewportView(tbUsuarioEdit);

        btn_lista_editusuario.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        btn_lista_editusuario.setText("REFRESH");
        btn_lista_editusuario.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_lista_editusuarioActionPerformed(evt);
            }
        });

        jLabel54.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        jLabel54.setText("CÓDIGO:");

        txt_codigo_usuario_update.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        txt_codigo_usuario_update.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txt_codigo_usuario_updateActionPerformed(evt);
            }
        });
        txt_codigo_usuario_update.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txt_codigo_usuario_updateKeyTyped(evt);
            }
        });

        lbl_att_acervo1.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N

        btn_excluir_usuario_update.setFont(new java.awt.Font("Verdana", 0, 14)); // NOI18N
        btn_excluir_usuario_update.setText("EXCLUIR");
        btn_excluir_usuario_update.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btn_excluir_usuario_updateActionPerformed(evt);
            }
        });

        jLabel12.setText("PELO CÓDIGO:");

        jLabel13.setFont(new java.awt.Font("Tahoma", 0, 14)); // NOI18N
        jLabel13.setText("/");

        javax.swing.GroupLayout jpCadastroAcervoInsert2Layout = new javax.swing.GroupLayout(jpCadastroAcervoInsert2);
        jpCadastroAcervoInsert2.setLayout(jpCadastroAcervoInsert2Layout);
        jpCadastroAcervoInsert2Layout.setHorizontalGroup(
            jpCadastroAcervoInsert2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jpCadastroAcervoInsert2Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jpCadastroAcervoInsert2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jpCadastroAcervoInsert2Layout.createSequentialGroup()
                        .addComponent(jLabel51, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGap(94, 94, 94))
                    .addGroup(jpCadastroAcervoInsert2Layout.createSequentialGroup()
                        .addComponent(jLabel53, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGap(70, 70, 70))
                    .addGroup(jpCadastroAcervoInsert2Layout.createSequentialGroup()
                        .addComponent(jLabel49, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGap(85, 85, 85))
                    .addComponent(jLabel52, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(jpCadastroAcervoInsert2Layout.createSequentialGroup()
                        .addGroup(jpCadastroAcervoInsert2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel54)
                            .addComponent(btn_cadastrar_usuario_update))
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addGap(18, 18, 18)
                .addGroup(jpCadastroAcervoInsert2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jpCadastroAcervoInsert2Layout.createSequentialGroup()
                        .addGroup(jpCadastroAcervoInsert2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addGroup(jpCadastroAcervoInsert2Layout.createSequentialGroup()
                                .addComponent(lbl_att_acervo1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addGap(290, 290, 290))
                            .addGroup(jpCadastroAcervoInsert2Layout.createSequentialGroup()
                                .addComponent(jLabel12)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addComponent(btn_excluir_usuario_update, javax.swing.GroupLayout.PREFERRED_SIZE, 99, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(12, 12, 12)
                                .addComponent(jLabel13)
                                .addGap(17, 17, 17)))
                        .addComponent(btn_lista_editusuario, javax.swing.GroupLayout.PREFERRED_SIZE, 99, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jpCadastroAcervoInsert2Layout.createSequentialGroup()
                        .addGroup(jpCadastroAcervoInsert2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(txt_codigo_usuario_update, javax.swing.GroupLayout.PREFERRED_SIZE, 186, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txt_nome_usuario_update)
                            .addComponent(txt_telefone_usuario_update)
                            .addComponent(txt_email_usuario_update)
                            .addComponent(cb_curso_usuario_update, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jScrollPane6, javax.swing.GroupLayout.PREFERRED_SIZE, 234, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap())
        );
        jpCadastroAcervoInsert2Layout.setVerticalGroup(
            jpCadastroAcervoInsert2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jpCadastroAcervoInsert2Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jpCadastroAcervoInsert2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(jpCadastroAcervoInsert2Layout.createSequentialGroup()
                        .addComponent(jScrollPane6, javax.swing.GroupLayout.PREFERRED_SIZE, 204, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(jpCadastroAcervoInsert2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(btn_lista_editusuario)
                            .addComponent(btn_excluir_usuario_update)
                            .addComponent(jLabel12)
                            .addComponent(jLabel13, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(btn_cadastrar_usuario_update)))
                    .addGroup(jpCadastroAcervoInsert2Layout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addGroup(jpCadastroAcervoInsert2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txt_codigo_usuario_update, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel54))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(jpCadastroAcervoInsert2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txt_nome_usuario_update, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel51))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(jpCadastroAcervoInsert2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txt_telefone_usuario_update, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel53))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(jpCadastroAcervoInsert2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txt_email_usuario_update, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel49))
                        .addGap(18, 18, 18)
                        .addGroup(jpCadastroAcervoInsert2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel52)
                            .addComponent(cb_curso_usuario_update, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(62, 62, 62)
                        .addComponent(lbl_att_acervo1)))
                .addContainerGap())
        );

        jpEditarUsuario.add(jpCadastroAcervoInsert2, java.awt.BorderLayout.PAGE_END);

        jpBase.add(jpEditarUsuario, "editarusuario");

        getContentPane().add(jpBase, java.awt.BorderLayout.CENTER);

        jMenu.setText("MENU");
        jMenu.setEnabled(false);

        rbLogin.setSelected(true);
        rbLogin.setText("Login");
        rbLogin.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rbLoginActionPerformed(evt);
            }
        });
        jMenu.add(rbLogin);

        rbAcervo.setSelected(true);
        rbAcervo.setText("Acervo");
        rbAcervo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rbAcervoActionPerformed(evt);
            }
        });
        jMenu.add(rbAcervo);

        rbCadPessoa.setSelected(true);
        rbCadPessoa.setText("Cadastro de Pessoa");
        rbCadPessoa.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rbCadPessoaActionPerformed(evt);
            }
        });
        jMenu.add(rbCadPessoa);

        rbCadAcervo.setSelected(true);
        rbCadAcervo.setText("Cadastro no Acervo");
        rbCadAcervo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rbCadAcervoActionPerformed(evt);
            }
        });
        jMenu.add(rbCadAcervo);

        rbEmprestimoEmDia.setSelected(true);
        rbEmprestimoEmDia.setText("Empréstimos em Dia");
        rbEmprestimoEmDia.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rbEmprestimoEmDiaActionPerformed(evt);
            }
        });
        jMenu.add(rbEmprestimoEmDia);

        rbEmprestimoAtrasado.setSelected(true);
        rbEmprestimoAtrasado.setText("Empréstimos Atrasados");
        rbEmprestimoAtrasado.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rbEmprestimoAtrasadoActionPerformed(evt);
            }
        });
        jMenu.add(rbEmprestimoAtrasado);

        rbFazerEmprestimo.setSelected(true);
        rbFazerEmprestimo.setText("Fazer Empréstimo");
        rbFazerEmprestimo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rbFazerEmprestimoActionPerformed(evt);
            }
        });
        jMenu.add(rbFazerEmprestimo);

        rbUsuarios.setSelected(true);
        rbUsuarios.setText("Usuários");
        rbUsuarios.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rbUsuariosActionPerformed(evt);
            }
        });
        jMenu.add(rbUsuarios);

        rbEditarAcervo.setSelected(true);
        rbEditarAcervo.setText("Editar Acervo");
        rbEditarAcervo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rbEditarAcervoActionPerformed(evt);
            }
        });
        jMenu.add(rbEditarAcervo);

        rbEditarUsuario.setSelected(true);
        rbEditarUsuario.setText("Editar Usuário");
        rbEditarUsuario.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rbEditarUsuarioActionPerformed(evt);
            }
        });
        jMenu.add(rbEditarUsuario);

        jMenuBar1.add(jMenu);

        setJMenuBar(jMenuBar1);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnLogarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnLogarActionPerformed
        String passlog = "";
        try {
            //Abrir a conexao
            con = Biblio_Class.conectar("root","root");
            // Para comparar
            ps0 = con.prepareStatement("select nm_usuario"
                        + " from tb_usuario where nm_usuario = ? and cd_senha = ? and cd_usuario = ? and cd_curso = 1");
            ps0.setString(1, txt_nome_logar.getText());
            ps0.setString(2, txt_senha_logar.getText());
            ps0.setInt(3, Integer.parseInt(txt_codigo_logar.getText()));
            rs0 = ps0.executeQuery();
        } catch (SQLException ex) {
            Logger.getLogger(jfBiblio.class.getName()).log(Level.SEVERE, null, ex);
        }        
        
        try {
            while(rs0.next()){//enquanto houver um registro válido
                passlog = rs0.getString("nm_usuario");
                break;
            }
        } catch (SQLException ex) {
            Logger.getLogger(jfBiblio.class.getName()).log(Level.SEVERE, null, ex);
        }
        if (passlog == ""){
            lbl_confirma.setBackground(Color.red);
            lbl_confirma.setText("Login Inválido!");
        }
        else{
            lbl_confirma.setBackground(Color.green);
            lbl_confirma.setText("Login Completo! Seja Bem-Vindo "+txt_nome_logar.getText().toUpperCase());
            txt_nome_logar.setText("");
            txt_senha_logar.setText("");   
            txt_codigo_logar.setText("");
            jMenu.setEnabled(true);
            txt_nome_logar.setEnabled(false);
            txt_senha_logar.setEnabled(false);
            txt_codigo_logar.setEnabled(false);
            btnLogar.setEnabled(false);
        }
    }//GEN-LAST:event_btnLogarActionPerformed

    private void rbLoginActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rbLoginActionPerformed
        ((CardLayout)jpBase.getLayout()).show(jpBase, "login");
    }//GEN-LAST:event_rbLoginActionPerformed

    private void rbAcervoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rbAcervoActionPerformed
        ((CardLayout)jpBase.getLayout()).show(jpBase, "acervo");
        carregaAcervo();
    }//GEN-LAST:event_rbAcervoActionPerformed

    private void rbCadPessoaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rbCadPessoaActionPerformed
        ((CardLayout)jpBase.getLayout()).show(jpBase, "cadastropessoa");
    }//GEN-LAST:event_rbCadPessoaActionPerformed

    private void rbCadAcervoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rbCadAcervoActionPerformed
        ((CardLayout)jpBase.getLayout()).show(jpBase, "cadastroacervo");
    }//GEN-LAST:event_rbCadAcervoActionPerformed

    private void rbEmprestimoEmDiaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rbEmprestimoEmDiaActionPerformed
        ((CardLayout)jpBase.getLayout()).show(jpBase, "emprestimoemdia");
    }//GEN-LAST:event_rbEmprestimoEmDiaActionPerformed

    private void rbEmprestimoAtrasadoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rbEmprestimoAtrasadoActionPerformed
        ((CardLayout)jpBase.getLayout()).show(jpBase, "emprestimoatrasado");
    }//GEN-LAST:event_rbEmprestimoAtrasadoActionPerformed

    private void rbFazerEmprestimoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rbFazerEmprestimoActionPerformed
        ((CardLayout)jpBase.getLayout()).show(jpBase, "fazeremprestimo");
    }//GEN-LAST:event_rbFazerEmprestimoActionPerformed

    private void btn_cadastrar_acervo2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_cadastrar_acervo2ActionPerformed
        if (txt_nome_acervo2.getText()!=""&&txt_editora_acervo2.getText()!=""&&txt_autor_acervo2.getText()!=""){
        try{
        con = Biblio_Class.conectar("root","root");
        ps = con.prepareStatement("insert into tb_acervo ( nm_titulo, nm_edicao, nm_autor, nm_editora, ic_ativo, cd_categoria, cd_material)"
               + "values (?,?,?,?, TRUE, ?, ?)");
                // definir os valores de cada índice (?)
        ps.setString(1, txt_nome_acervo2.getText());
        ps.setString(2, txt_edicao_acervo2.getText());
        ps.setString(3, txt_autor_acervo2.getText());
        ps.setString(4, txt_editora_acervo2.getText());
        ps.setInt(5, cb_categoria_cadAcervo.getSelectedIndex()+1);
        ps.setInt(6, cb_tipo_material_cadAcervo.getSelectedIndex()+1);
        ps.execute();
        JOptionPane.showMessageDialog(null, "CADASTRO REALIZADO");
        txt_nome_acervo2.setText("");
        txt_edicao_acervo2.setText("");
        txt_autor_acervo2.setText("");
        txt_editora_acervo2.setText("");
        }
        catch(SQLException ex){
                JOptionPane.showMessageDialog(this, "Erro: "+ex.getMessage());
        }
        }
        else{
            JOptionPane.showMessageDialog(null, "PREENCHA TODOS OS CAMPOS CORRETAMENTE!");
        }
    }//GEN-LAST:event_btn_cadastrar_acervo2ActionPerformed

    private void btn_cadastrar_pessoa1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_cadastrar_pessoa1ActionPerformed
        Pattern p = Pattern.compile(".+@.+\\.[a-z]+");
        Matcher m = p.matcher(txt_email_pessoa1.getText());
        boolean matchFound = m.matches();
        boolean yesno;
        if(matchFound){
            
        if (txt_nome_pessoa1.getText().trim()!="" && txt_senha_pessoa1.getText().trim()!="" && txt_telefone_pessoa1.getText().trim()!="" && txt_email_pessoa1.getText().trim()!=""){
        
        if (prof.isSelected()){
            yesno = true;
        }
        else{
            yesno = false;
        }
        try{
            con = Biblio_Class.conectar("root","root");
            ps = con.prepareStatement("insert into tb_usuario ( nm_usuario, cd_senha, cd_telefone, nm_email, ic_professor, ic_ativo, cd_curso)"
                + "values (?,?,?,?,"+ yesno +", true , ?)");
            // definir os valores de cada índice (?)
            ps.setString(1, txt_nome_pessoa1.getText());
            ps.setString(2, txt_senha_pessoa1.getText());
            ps.setString(3, txt_telefone_pessoa1.getText());
            ps.setString(4, txt_email_pessoa1.getText());
            ps.setInt(5, cb_curso_pessoa1.getSelectedIndex()+1);
            ps.execute();
            JOptionPane.showMessageDialog(null, "CADASTRO REALIZADO");
            txt_nome_pessoa1.setText("");
            txt_senha_pessoa1.setText("");
            txt_telefone_pessoa1.setText("");
            txt_email_pessoa1.setText("");
        }
        catch(SQLException ex){
            JOptionPane.showMessageDialog(this, "Erro: "+ex.getMessage());
        }
        }
        else{
            JOptionPane.showMessageDialog(this, "PREENCHA OS CAMPOS CORRETAMENTE!");
        }
        } else{
            JOptionPane.showMessageDialog(this, "PREENCHA OS CAMPOS CORRETAMENTE!");
        }
    }//GEN-LAST:event_btn_cadastrar_pessoa1ActionPerformed

    private void btn_listaremdiaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_listaremdiaActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_btn_listaremdiaActionPerformed

    private void btn_listaremdia1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_listaremdia1ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_btn_listaremdia1ActionPerformed

    private void dtEmpActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_dtEmpActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_dtEmpActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        
    }//GEN-LAST:event_jButton1ActionPerformed

    private void btn_cadastrar_acervo3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_cadastrar_acervo3ActionPerformed
        updateEditAcervo(Integer.parseInt(txt_codigo_acervo_update.getText()));
    }//GEN-LAST:event_btn_cadastrar_acervo3ActionPerformed

    private void btn_lista_editacervoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_lista_editacervoActionPerformed
        carregaEditAcervo();
    }//GEN-LAST:event_btn_lista_editacervoActionPerformed

    private void txt_nome_acervo_updateActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txt_nome_acervo_updateActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txt_nome_acervo_updateActionPerformed

    private void rbUsuariosActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rbUsuariosActionPerformed
        ((CardLayout)jpBase.getLayout()).show(jpBase, "usuario");
        carregaUsuario();
    }//GEN-LAST:event_rbUsuariosActionPerformed

    private void txt_codigo_logarKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_codigo_logarKeyTyped
        String caracteres="0987654321";
        if(!caracteres.contains(evt.getKeyChar()+"")){
        evt.consume();
        }
        if(txt_codigo_logar.getText().trim().length()>5){
            evt.consume();
        }
    }//GEN-LAST:event_txt_codigo_logarKeyTyped

    private void rbEditarAcervoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rbEditarAcervoActionPerformed
        ((CardLayout)jpBase.getLayout()).show(jpBase, "editaracervo");
        carregaEditAcervo();
    }//GEN-LAST:event_rbEditarAcervoActionPerformed

    private void txt_codigo_acervo_updateActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txt_codigo_acervo_updateActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txt_codigo_acervo_updateActionPerformed

    private void txt_edicao_acervo2KeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_edicao_acervo2KeyTyped
        String caracteres="0987654321";
        if(!caracteres.contains(evt.getKeyChar()+"")){
        evt.consume();
        }
        if(txt_edicao_acervo2.getText().trim().length()>10){
            evt.consume();
        }
    }//GEN-LAST:event_txt_edicao_acervo2KeyTyped

    private void txt_telefone_pessoa1KeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_telefone_pessoa1KeyTyped
        String caracteres="0987654321";
        if(!caracteres.contains(evt.getKeyChar()+"")){
        evt.consume();
        }
        if(txt_telefone_pessoa1.getText().trim().length()>11){
            evt.consume();
        }
    }//GEN-LAST:event_txt_telefone_pessoa1KeyTyped

    private void txt_codigo_fazer_conexaoKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_codigo_fazer_conexaoKeyTyped
       String caracteres="0987654321";
        if(!caracteres.contains(evt.getKeyChar()+"")){
        evt.consume();
        }
        if(txt_codigo_logar.getText().trim().length()>5){
            evt.consume();
        }
    }//GEN-LAST:event_txt_codigo_fazer_conexaoKeyTyped

    private void txt_codigo_acervo_fazer_conexaoKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_codigo_acervo_fazer_conexaoKeyTyped
        String caracteres="0987654321";
        if(!caracteres.contains(evt.getKeyChar()+"")){
        evt.consume();
        }
        if(txt_codigo_logar.getText().trim().length()>5){
            evt.consume();
        }
    }//GEN-LAST:event_txt_codigo_acervo_fazer_conexaoKeyTyped

    private void txt_codigo_acervo_updateKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_codigo_acervo_updateKeyTyped
        String caracteres="0987654321";
        if(!caracteres.contains(evt.getKeyChar()+"")){
        evt.consume();
        }
        if(txt_codigo_logar.getText().trim().length()>10){
            evt.consume();
        }
    }//GEN-LAST:event_txt_codigo_acervo_updateKeyTyped

    private void txt_edicao_acervo_updateKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_edicao_acervo_updateKeyTyped
        String caracteres="0987654321";
        if(!caracteres.contains(evt.getKeyChar()+"")){
        evt.consume();
        }
        if(txt_codigo_logar.getText().trim().length()>10){
            evt.consume();
        }
    }//GEN-LAST:event_txt_edicao_acervo_updateKeyTyped

    private void btn_cadastrar_usuario_updateActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_cadastrar_usuario_updateActionPerformed
            if(txt_nome_usuario_update.getText()!=""&&txt_telefone_usuario_update.getText().trim()!=""&&txt_codigo_usuario_update.getText()!="" && txt_email_usuario_update.getText()!=""){
            Pattern p = Pattern.compile(".+@.+\\.[a-z]+");
            Matcher m = p.matcher(txt_email_usuario_update.getText());
            boolean matchFound = m.matches();
            if(matchFound){
                updateEditUsuario(Integer.parseInt(txt_codigo_usuario_update.getText().toString()));
                carregaEditUsuario();
            }
            else{
                JOptionPane.showMessageDialog(this, "Preencha o email corretamente!");
            }
        }
        else{
                JOptionPane.showMessageDialog(this, "Preencha tudo corretamente!");
            }        
    }//GEN-LAST:event_btn_cadastrar_usuario_updateActionPerformed

    private void txt_nome_usuario_updateActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txt_nome_usuario_updateActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txt_nome_usuario_updateActionPerformed

    private void btn_lista_editusuarioActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_lista_editusuarioActionPerformed
        carregaEditUsuario();
    }//GEN-LAST:event_btn_lista_editusuarioActionPerformed

    private void txt_codigo_usuario_updateActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txt_codigo_usuario_updateActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txt_codigo_usuario_updateActionPerformed

    private void txt_codigo_usuario_updateKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_codigo_usuario_updateKeyTyped
        // TODO add your handling code here:
    }//GEN-LAST:event_txt_codigo_usuario_updateKeyTyped

    private void rbEditarUsuarioActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rbEditarUsuarioActionPerformed
        ((CardLayout)jpBase.getLayout()).show(jpBase, "editarusuario");
        carregaEditUsuario();
    }//GEN-LAST:event_rbEditarUsuarioActionPerformed

    private void btn_excluir_usuario_updateActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_excluir_usuario_updateActionPerformed
        ExcluirEditUsuario(Integer.parseInt(txt_codigo_usuario_update.getText().toString()));
        carregaEditUsuario();
    }//GEN-LAST:event_btn_excluir_usuario_updateActionPerformed

    private void txt_telefone_usuario_updateKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_telefone_usuario_updateKeyTyped
        String caracteres="0987654321";
        if(!caracteres.contains(evt.getKeyChar()+"")){
        evt.consume();
        }
        if(txt_codigo_logar.getText().trim().length()>10){
            evt.consume();
        }
    }//GEN-LAST:event_txt_telefone_usuario_updateKeyTyped

    private void btn_excluir_acervo_updateActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btn_excluir_acervo_updateActionPerformed
        ExcluirEditAcervo(Integer.parseInt(txt_codigo_acervo_update.getText().toString()));
        carregaEditAcervo();
    }//GEN-LAST:event_btn_excluir_acervo_updateActionPerformed

    private void txt_senha_logarKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_senha_logarKeyTyped
        if(txt_senha_logar.getText().trim().length()>10){
            evt.consume();
        }
    }//GEN-LAST:event_txt_senha_logarKeyTyped

    private void txt_nome_logarKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_nome_logarKeyTyped
        if(txt_nome_logar.getText().trim().length()>10){
            evt.consume();
        }
    }//GEN-LAST:event_txt_nome_logarKeyTyped

    private void txt_nome_acervo2KeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_nome_acervo2KeyTyped
        if(txt_nome_acervo2.getText().trim().length()>10){
            evt.consume();
        }
    }//GEN-LAST:event_txt_nome_acervo2KeyTyped

    private void txt_editora_acervo2KeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_editora_acervo2KeyTyped
        if(txt_editora_acervo2.getText().trim().length()>10){
            evt.consume();
        }
    }//GEN-LAST:event_txt_editora_acervo2KeyTyped

    private void txt_autor_acervo2KeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_autor_acervo2KeyTyped
        if(txt_autor_acervo2.getText().trim().length()>10){
            evt.consume();
        }
    }//GEN-LAST:event_txt_autor_acervo2KeyTyped

    private void txt_nome_pessoa1KeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_nome_pessoa1KeyTyped
        if(txt_nome_pessoa1.getText().trim().length()>10){
            evt.consume();
        }
    }//GEN-LAST:event_txt_nome_pessoa1KeyTyped

    private void txt_email_pessoa1KeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_email_pessoa1KeyTyped
        if(txt_email_pessoa1.getText().trim().length()>10){
            evt.consume();
        }
    }//GEN-LAST:event_txt_email_pessoa1KeyTyped

    private void txt_senha_pessoa1KeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txt_senha_pessoa1KeyTyped
        if(txt_senha_pessoa1.getText().trim().length()>10){
            evt.consume();
        }
    }//GEN-LAST:event_txt_senha_pessoa1KeyTyped

    private void dtEmpKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_dtEmpKeyTyped
        // TODO add your handling code here:
    }//GEN-LAST:event_dtEmpKeyTyped

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
            java.util.logging.Logger.getLogger(jfBiblio.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(jfBiblio.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(jfBiblio.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(jfBiblio.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new jfBiblio().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnLogar;
    private javax.swing.JButton btn_cadastrar_acervo2;
    private javax.swing.JButton btn_cadastrar_acervo3;
    private javax.swing.JButton btn_cadastrar_pessoa1;
    private javax.swing.JButton btn_cadastrar_usuario_update;
    private javax.swing.JButton btn_excluir_acervo_update;
    private javax.swing.JButton btn_excluir_usuario_update;
    private javax.swing.JButton btn_lista_editacervo;
    private javax.swing.JButton btn_lista_editusuario;
    private javax.swing.JButton btn_listaremdia;
    private javax.swing.JButton btn_listaremdia1;
    private javax.swing.JComboBox<String> cb_categoria_acervo_update;
    private javax.swing.JComboBox<String> cb_categoria_cadAcervo;
    private javax.swing.JComboBox<String> cb_curso_pessoa1;
    private javax.swing.JComboBox<String> cb_curso_usuario_update;
    private javax.swing.JComboBox<String> cb_material_acervo_update;
    private javax.swing.JComboBox<String> cb_tipo_material_cadAcervo;
    private javax.swing.JFormattedTextField dtEmp;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel14;
    private javax.swing.JLabel jLabel15;
    private javax.swing.JLabel jLabel16;
    private javax.swing.JLabel jLabel17;
    private javax.swing.JLabel jLabel18;
    private javax.swing.JLabel jLabel19;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel25;
    private javax.swing.JLabel jLabel26;
    private javax.swing.JLabel jLabel27;
    private javax.swing.JLabel jLabel28;
    private javax.swing.JLabel jLabel29;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel30;
    private javax.swing.JLabel jLabel35;
    private javax.swing.JLabel jLabel36;
    private javax.swing.JLabel jLabel37;
    private javax.swing.JLabel jLabel38;
    private javax.swing.JLabel jLabel39;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel40;
    private javax.swing.JLabel jLabel41;
    private javax.swing.JLabel jLabel42;
    private javax.swing.JLabel jLabel43;
    private javax.swing.JLabel jLabel44;
    private javax.swing.JLabel jLabel45;
    private javax.swing.JLabel jLabel46;
    private javax.swing.JLabel jLabel47;
    private javax.swing.JLabel jLabel49;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel51;
    private javax.swing.JLabel jLabel52;
    private javax.swing.JLabel jLabel53;
    private javax.swing.JLabel jLabel54;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JMenu jMenu;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel10;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JPanel jPanel5;
    private javax.swing.JPanel jPanel6;
    private javax.swing.JPanel jPanel7;
    private javax.swing.JPanel jPanel8;
    private javax.swing.JPanel jPanel9;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    private javax.swing.JScrollPane jScrollPane4;
    private javax.swing.JScrollPane jScrollPane5;
    private javax.swing.JScrollPane jScrollPane6;
    private javax.swing.JPanel jpAcervo;
    private javax.swing.JPanel jpAcervoPart;
    private javax.swing.JPanel jpAcervoPart1;
    private javax.swing.JPanel jpAcervoPart2;
    private javax.swing.JPanel jpAcervoPart3;
    private javax.swing.JPanel jpBase;
    private javax.swing.JPanel jpCadastroAcervo;
    private javax.swing.JPanel jpCadastroAcervoInsert;
    private javax.swing.JPanel jpCadastroAcervoInsert1;
    private javax.swing.JPanel jpCadastroAcervoInsert2;
    private javax.swing.JPanel jpCadastroPessoa;
    private javax.swing.JPanel jpCadastroPessoaInsert;
    private javax.swing.JPanel jpEditarAcervo;
    private javax.swing.JPanel jpEditarUsuario;
    private javax.swing.JPanel jpEmprestimoAtrasado;
    private javax.swing.JPanel jpEmprestimoEmDia;
    private javax.swing.JPanel jpFazerEmprestimo;
    private javax.swing.JPanel jpLogin;
    private javax.swing.JPanel jpLoginPart;
    private javax.swing.JPanel jpUsuarios;
    private javax.swing.JLabel lbl_att_acervo;
    private javax.swing.JLabel lbl_att_acervo1;
    private javax.swing.JLabel lbl_confirma;
    private javax.swing.JCheckBox prof;
    private javax.swing.JRadioButtonMenuItem rbAcervo;
    private javax.swing.JRadioButtonMenuItem rbCadAcervo;
    private javax.swing.JRadioButtonMenuItem rbCadPessoa;
    private javax.swing.JRadioButtonMenuItem rbEditarAcervo;
    private javax.swing.JRadioButtonMenuItem rbEditarUsuario;
    private javax.swing.JRadioButtonMenuItem rbEmprestimoAtrasado;
    private javax.swing.JRadioButtonMenuItem rbEmprestimoEmDia;
    private javax.swing.JRadioButtonMenuItem rbFazerEmprestimo;
    private javax.swing.JRadioButtonMenuItem rbLogin;
    private javax.swing.JRadioButtonMenuItem rbUsuarios;
    private javax.swing.JTable tbAcervo;
    private javax.swing.JTable tbAcervo1;
    private javax.swing.JTable tbAcervo2;
    private javax.swing.JTable tbAcervoEdit;
    private javax.swing.JTable tbUsuario;
    private javax.swing.JTable tbUsuarioEdit;
    private javax.swing.JTextField txt_autor_acervo2;
    private javax.swing.JTextField txt_autor_acervo_update;
    private javax.swing.JTextField txt_codigo_acervo_fazer_conexao;
    private javax.swing.JTextField txt_codigo_acervo_update;
    private javax.swing.JTextField txt_codigo_fazer_conexao;
    private javax.swing.JTextField txt_codigo_logar;
    private javax.swing.JTextField txt_codigo_usuario_update;
    private javax.swing.JTextField txt_edicao_acervo2;
    private javax.swing.JTextField txt_edicao_acervo_update;
    private javax.swing.JTextField txt_editora_acervo2;
    private javax.swing.JTextField txt_editora_acervo_update;
    private javax.swing.JTextField txt_email_pessoa1;
    private javax.swing.JTextField txt_email_usuario_update;
    private javax.swing.JTextField txt_nome_acervo2;
    private javax.swing.JTextField txt_nome_acervo_update;
    private javax.swing.JTextField txt_nome_logar;
    private javax.swing.JTextField txt_nome_pessoa1;
    private javax.swing.JTextField txt_nome_usuario_update;
    private javax.swing.JPasswordField txt_senha_logar;
    private javax.swing.JPasswordField txt_senha_pessoa1;
    private javax.swing.JTextField txt_telefone_pessoa1;
    private javax.swing.JTextField txt_telefone_usuario_update;
    // End of variables declaration//GEN-END:variables

    private void updateEditUsuario(int an) {
        try{
            con = Biblio_Class.conectar("root","root");            
            ps = con.prepareStatement("update tb_usuario set "
                    + "nm_usuario = ?, "
                    + "cd_telefone = ?, "                    
                    + "nm_email = ?, "
                    + "cd_curso = ? "
                    + " where cd_usuario = "+ an);
            //aplicar o modelo para a tabela
            ps.setString(1, txt_nome_usuario_update.getText());
            ps.setString(2, txt_telefone_usuario_update.getText());
            ps.setString(3, txt_email_usuario_update.getText());
            ps.setInt(4, cb_curso_usuario_update.getSelectedIndex()+1);    
            ps.execute();            
            txt_nome_usuario_update.setText("");
            txt_telefone_usuario_update.setText("");
            txt_email_usuario_update.setText(""); 
            txt_codigo_usuario_update.setText("");
        }
        catch(SQLException ex){
            JOptionPane.showMessageDialog(this, "Error "+ex.getMessage());
        }
    }
    private void carregaUsuario() {
        try{
            con = Biblio_Class.conectar("root","root");
            ps = con.prepareStatement("select tb_usuario.cd_usuario as 'Código', "
                    + "tb_usuario.nm_usuario as 'Nome', "
                    + "tb_usuario.cd_telefone as 'Telefone', "                    
                    + "tb_usuario.nm_email as 'Email', "
                    + "tb_usuario.ic_ativo as 'Ativo', "
                    + "tb_curso.nm_curso as 'Curso' "
                    + "from tb_usuario left join tb_curso "
                    + " on tb_usuario.cd_curso = tb_curso.cd_curso");
            // receber os dados do banco
            rs = ps.executeQuery();
            //aplicar o modelo para a tabela
            tbUsuario.setModel(new TabelaModelo(rs));
        }
        catch(SQLException ex){
            JOptionPane.showMessageDialog(this, "Error "+ex.getMessage());
        }
    }
    private void carregaEditUsuario() {
        try{
            con = Biblio_Class.conectar("root","root");
            ps = con.prepareStatement("select cd_usuario as 'Código', "
                    + "nm_usuario as 'Nome' "
                    + "from tb_usuario");
            // receber os dados do banco
            rs = ps.executeQuery();
            //aplicar o modelo para a tabela
            tbUsuarioEdit.setModel(new TabelaModelo(rs));
        }
        catch(SQLException ex){
            JOptionPane.showMessageDialog(this, "Error "+ex.getMessage());
        }
    }
    private void ExcluirEditUsuario(int nn) {
        try{
            con = Biblio_Class.conectar("root","root");
            ps = con.prepareStatement("delete from tb_usuario where cd_usuario = " + nn + " and cd_usuario > 0");
            // receber os dados do banco
            ps.execute();
        }
        catch(SQLException ex){
            JOptionPane.showMessageDialog(this, "Error "+ex.getMessage());
        }
    }
    private void ExcluirEditAcervo(int nncc) {
        try{
            con = Biblio_Class.conectar("root","root");
            ps = con.prepareStatement("delete from tb_acervo where cd_acervo = " + nncc + " and cd_acervo > 0");
            // receber os dados do banco
            ps.execute();
        }
        catch(SQLException ex){
            JOptionPane.showMessageDialog(this, "Error "+ex.getMessage());
        }
    }
    
    private void carregaAcervo() {
        try{
            con = Biblio_Class.conectar("root","root");
            ps = con.prepareStatement("select tb_acervo.cd_acervo as 'Código', "
                    + "tb_acervo.nm_titulo as 'Título', "
                    + "tb_acervo.nm_autor as 'Autor', "                    
                    + "tb_acervo.nm_edicao as 'Edição', "
                    + "tb_acervo.nm_editora as 'Editora', "
                    + "tb_acervo.ic_ativo as 'Disponibilidade', "
                    + "tb_tipo_material.nm_tipo as 'Tipo de Material', "
                    + "tb_categoria.nm_categoria as 'Categoria' "
                    + "from tb_tipo_material right join tb_acervo "
                    + " on tb_tipo_material.cd_material = tb_acervo.cd_material left join tb_categoria "
                    + "on tb_acervo.cd_categoria = tb_categoria.cd_categoria");
            // receber os dados do banco
            rs = ps.executeQuery();
            //aplicar o modelo para a tabela
            tbAcervo.setModel(new TabelaModelo(rs));
        }
        catch(SQLException ex){
            JOptionPane.showMessageDialog(this, "Error "+ex.getMessage());
        }
    }
    
    private void carregaEditAcervo() {
        try{
            con = Biblio_Class.conectar("root","root");
            ps = con.prepareStatement("select tb_acervo.cd_acervo as 'Código',"
                    + " tb_acervo.nm_titulo as 'Título' from tb_acervo ");
            // receber os dados do banco
            rs = ps.executeQuery();
            //aplicar o modelo para a tabela
            tbAcervoEdit.setModel(new TabelaModelo(rs));
        }
        catch(SQLException ex){
            JOptionPane.showMessageDialog(this, "Error "+ex.getMessage());
        }
    }
    
    private void updateEditAcervo(int n) {
        try{
            con = Biblio_Class.conectar("root","root");            
            ps = con.prepareStatement("update tb_acervo set "
                    + "nm_titulo = ?, "
                    + "nm_autor = ?, "                    
                    + "nm_edicao = ?, "
                    + "nm_editora = ?, "
                    + "cd_material = ?, "
                    + "cd_categoria = ? "
                    + " where cd_acervo = "+n);
            //aplicar o modelo para a tabela
            ps.setString(1, txt_nome_acervo_update.getText());
            ps.setString(2, txt_autor_acervo_update.getText());
            ps.setString(3, txt_edicao_acervo_update.getText());
            ps.setString(4, txt_editora_acervo_update.getText());
            ps.setInt(5, cb_material_acervo_update.getSelectedIndex()+1);
            ps.setInt(6, cb_categoria_acervo_update.getSelectedIndex()+1);
            txt_nome_acervo_update.setText("");
            txt_codigo_acervo_update.setText("");
            txt_autor_acervo_update.setText("");
            txt_edicao_acervo_update.setText("");
            txt_editora_acervo_update.setText("");          
            ps.execute();
        }
        catch(SQLException ex){
            JOptionPane.showMessageDialog(this, "Preencha os campos corretamente!");
        }
    }
    
}
