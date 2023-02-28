namespace Aula09_RegistroDoWindows
{
    partial class Frm_Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_GravandoNoRegistro = new System.Windows.Forms.GroupBox();
            this.btn_CriarCaminho = new System.Windows.Forms.Button();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_CPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ValorRegistro = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.lst_Listar = new System.Windows.Forms.ListBox();
            this.btn_ExcluirLista = new System.Windows.Forms.Button();
            this.grp_Login = new System.Windows.Forms.GroupBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Senha_Login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Usuario_Login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CPF_Login = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtExcluir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtCPFEditar = new System.Windows.Forms.TextBox();
            this.txtSenhaEdit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsuarioEdit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grp_GravandoNoRegistro.SuspendLayout();
            this.grp_Login.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_GravandoNoRegistro
            // 
            this.grp_GravandoNoRegistro.Controls.Add(this.btn_CriarCaminho);
            this.grp_GravandoNoRegistro.Controls.Add(this.txt_Senha);
            this.grp_GravandoNoRegistro.Controls.Add(this.txt_Usuario);
            this.grp_GravandoNoRegistro.Controls.Add(this.txt_CPF);
            this.grp_GravandoNoRegistro.Controls.Add(this.label2);
            this.grp_GravandoNoRegistro.Controls.Add(this.label1);
            this.grp_GravandoNoRegistro.Controls.Add(this.lbl_ValorRegistro);
            this.grp_GravandoNoRegistro.Location = new System.Drawing.Point(12, 12);
            this.grp_GravandoNoRegistro.Name = "grp_GravandoNoRegistro";
            this.grp_GravandoNoRegistro.Size = new System.Drawing.Size(449, 225);
            this.grp_GravandoNoRegistro.TabIndex = 0;
            this.grp_GravandoNoRegistro.TabStop = false;
            this.grp_GravandoNoRegistro.Text = "Gravando no Registro";
            // 
            // btn_CriarCaminho
            // 
            this.btn_CriarCaminho.Location = new System.Drawing.Point(357, 191);
            this.btn_CriarCaminho.Name = "btn_CriarCaminho";
            this.btn_CriarCaminho.Size = new System.Drawing.Size(73, 28);
            this.btn_CriarCaminho.TabIndex = 2;
            this.btn_CriarCaminho.Text = "Criar";
            this.btn_CriarCaminho.UseVisualStyleBackColor = true;
            this.btn_CriarCaminho.Click += new System.EventHandler(this.btn_CriarCaminho_Click);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(49, 146);
            this.txt_Senha.MaxLength = 10;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(381, 27);
            this.txt_Senha.TabIndex = 1;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(49, 95);
            this.txt_Usuario.MaxLength = 10;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(381, 27);
            this.txt_Usuario.TabIndex = 1;
            // 
            // txt_CPF
            // 
            this.txt_CPF.Location = new System.Drawing.Point(49, 44);
            this.txt_CPF.MaxLength = 11;
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(381, 27);
            this.txt_CPF.TabIndex = 1;
            this.txt_CPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CPF_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // lbl_ValorRegistro
            // 
            this.lbl_ValorRegistro.AutoSize = true;
            this.lbl_ValorRegistro.Location = new System.Drawing.Point(31, 23);
            this.lbl_ValorRegistro.Name = "lbl_ValorRegistro";
            this.lbl_ValorRegistro.Size = new System.Drawing.Size(38, 18);
            this.lbl_ValorRegistro.TabIndex = 0;
            this.lbl_ValorRegistro.Text = "CPF";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(674, 23);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(75, 30);
            this.btn_Listar.TabIndex = 3;
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // lst_Listar
            // 
            this.lst_Listar.FormattingEnabled = true;
            this.lst_Listar.ItemHeight = 18;
            this.lst_Listar.Location = new System.Drawing.Point(476, 59);
            this.lst_Listar.Name = "lst_Listar";
            this.lst_Listar.Size = new System.Drawing.Size(273, 418);
            this.lst_Listar.TabIndex = 4;
            this.lst_Listar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_Listar_MouseDoubleClick);
            // 
            // btn_ExcluirLista
            // 
            this.btn_ExcluirLista.Location = new System.Drawing.Point(108, 112);
            this.btn_ExcluirLista.Name = "btn_ExcluirLista";
            this.btn_ExcluirLista.Size = new System.Drawing.Size(167, 28);
            this.btn_ExcluirLista.TabIndex = 2;
            this.btn_ExcluirLista.Text = "Excluir Registro";
            this.btn_ExcluirLista.UseVisualStyleBackColor = true;
            this.btn_ExcluirLista.Click += new System.EventHandler(this.btn_CaminhoGravado_Click);
            // 
            // grp_Login
            // 
            this.grp_Login.Controls.Add(this.btn_Login);
            this.grp_Login.Controls.Add(this.txt_Senha_Login);
            this.grp_Login.Controls.Add(this.label3);
            this.grp_Login.Controls.Add(this.txt_Usuario_Login);
            this.grp_Login.Controls.Add(this.label4);
            this.grp_Login.Controls.Add(this.txt_CPF_Login);
            this.grp_Login.Controls.Add(this.label5);
            this.grp_Login.Location = new System.Drawing.Point(12, 253);
            this.grp_Login.Name = "grp_Login";
            this.grp_Login.Size = new System.Drawing.Size(449, 227);
            this.grp_Login.TabIndex = 1;
            this.grp_Login.TabStop = false;
            this.grp_Login.Text = "Login";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(357, 191);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(73, 28);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Senha_Login
            // 
            this.txt_Senha_Login.Location = new System.Drawing.Point(49, 146);
            this.txt_Senha_Login.MaxLength = 10;
            this.txt_Senha_Login.Name = "txt_Senha_Login";
            this.txt_Senha_Login.PasswordChar = '*';
            this.txt_Senha_Login.Size = new System.Drawing.Size(381, 27);
            this.txt_Senha_Login.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPF";
            // 
            // txt_Usuario_Login
            // 
            this.txt_Usuario_Login.Location = new System.Drawing.Point(49, 95);
            this.txt_Usuario_Login.MaxLength = 10;
            this.txt_Usuario_Login.Name = "txt_Usuario_Login";
            this.txt_Usuario_Login.Size = new System.Drawing.Size(381, 27);
            this.txt_Usuario_Login.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Usuário";
            // 
            // txt_CPF_Login
            // 
            this.txt_CPF_Login.Location = new System.Drawing.Point(49, 44);
            this.txt_CPF_Login.MaxLength = 11;
            this.txt_CPF_Login.Name = "txt_CPF_Login";
            this.txt_CPF_Login.Size = new System.Drawing.Size(381, 27);
            this.txt_CPF_Login.TabIndex = 1;
            this.txt_CPF_Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CPF_Login_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Senha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ExcluirLista);
            this.groupBox1.Controls.Add(this.txtExcluir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(767, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deletar";
            // 
            // txtExcluir
            // 
            this.txtExcluir.Location = new System.Drawing.Point(9, 63);
            this.txtExcluir.Name = "txtExcluir";
            this.txtExcluir.ReadOnly = true;
            this.txtExcluir.Size = new System.Drawing.Size(250, 27);
            this.txtExcluir.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "CPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "CPFs dos Indivíduos:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.txtCPFEditar);
            this.groupBox2.Controls.Add(this.txtSenhaEdit);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtUsuarioEdit);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(767, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 277);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(165, 229);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(73, 28);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtCPFEditar
            // 
            this.txtCPFEditar.Location = new System.Drawing.Point(49, 44);
            this.txtCPFEditar.Name = "txtCPFEditar";
            this.txtCPFEditar.ReadOnly = true;
            this.txtCPFEditar.Size = new System.Drawing.Size(189, 27);
            this.txtCPFEditar.TabIndex = 1;
            // 
            // txtSenhaEdit
            // 
            this.txtSenhaEdit.Location = new System.Drawing.Point(49, 146);
            this.txtSenhaEdit.MaxLength = 10;
            this.txtSenhaEdit.Name = "txtSenhaEdit";
            this.txtSenhaEdit.PasswordChar = '*';
            this.txtSenhaEdit.Size = new System.Drawing.Size(189, 27);
            this.txtSenhaEdit.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "CPF";
            // 
            // txtUsuarioEdit
            // 
            this.txtUsuarioEdit.Location = new System.Drawing.Point(49, 95);
            this.txtUsuarioEdit.MaxLength = 10;
            this.txtUsuarioEdit.Name = "txtUsuarioEdit";
            this.txtUsuarioEdit.Size = new System.Drawing.Size(189, 27);
            this.txtUsuarioEdit.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Senha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Usuário";
            // 
            // Frm_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lst_Listar);
            this.Controls.Add(this.btn_Listar);
            this.Controls.Add(this.grp_Login);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_GravandoNoRegistro);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Frm_Registro";
            this.Text = "Salvando em Registro";
            this.grp_GravandoNoRegistro.ResumeLayout(false);
            this.grp_GravandoNoRegistro.PerformLayout();
            this.grp_Login.ResumeLayout(false);
            this.grp_Login.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_GravandoNoRegistro;
        private System.Windows.Forms.Button btn_CriarCaminho;
        private System.Windows.Forms.TextBox txt_CPF;
        private System.Windows.Forms.Label lbl_ValorRegistro;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.ListBox lst_Listar;
        private System.Windows.Forms.Button btn_ExcluirLista;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_Login;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Senha_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Usuario_Login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CPF_Login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtExcluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtSenhaEdit;
        private System.Windows.Forms.TextBox txtUsuarioEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCPFEditar;
        private System.Windows.Forms.Label label10;
    }
}

