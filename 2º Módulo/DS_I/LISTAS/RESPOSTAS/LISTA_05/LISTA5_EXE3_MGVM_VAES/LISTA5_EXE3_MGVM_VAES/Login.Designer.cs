namespace LISTA5_EXE3_MGVM_VAES
{
    partial class Login
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
            this.lbl_cadastro = new System.Windows.Forms.Label();
            this.txt_cadastro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.btn_enterCadastro = new System.Windows.Forms.Button();
            this.btn_enterLogin = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_cadastro
            // 
            this.lbl_cadastro.AutoSize = true;
            this.lbl_cadastro.Location = new System.Drawing.Point(12, 51);
            this.lbl_cadastro.Name = "lbl_cadastro";
            this.lbl_cadastro.Size = new System.Drawing.Size(38, 13);
            this.lbl_cadastro.TabIndex = 0;
            this.lbl_cadastro.Text = "Senha";
            // 
            // txt_cadastro
            // 
            this.txt_cadastro.Location = new System.Drawing.Point(64, 48);
            this.txt_cadastro.MaxLength = 4;
            this.txt_cadastro.Name = "txt_cadastro";
            this.txt_cadastro.PasswordChar = '@';
            this.txt_cadastro.Size = new System.Drawing.Size(100, 20);
            this.txt_cadastro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastrar Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(12, 124);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_senha.TabIndex = 4;
            this.lbl_senha.Text = "Senha";
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(64, 121);
            this.txt_login.MaxLength = 4;
            this.txt_login.Name = "txt_login";
            this.txt_login.PasswordChar = '@';
            this.txt_login.Size = new System.Drawing.Size(100, 20);
            this.txt_login.TabIndex = 5;
            // 
            // btn_enterCadastro
            // 
            this.btn_enterCadastro.Location = new System.Drawing.Point(190, 46);
            this.btn_enterCadastro.Name = "btn_enterCadastro";
            this.btn_enterCadastro.Size = new System.Drawing.Size(75, 23);
            this.btn_enterCadastro.TabIndex = 6;
            this.btn_enterCadastro.Text = "ENTER";
            this.btn_enterCadastro.UseVisualStyleBackColor = true;
            this.btn_enterCadastro.Click += new System.EventHandler(this.btn_enterCadastro_Click);
            // 
            // btn_enterLogin
            // 
            this.btn_enterLogin.Location = new System.Drawing.Point(190, 119);
            this.btn_enterLogin.Name = "btn_enterLogin";
            this.btn_enterLogin.Size = new System.Drawing.Size(75, 23);
            this.btn_enterLogin.TabIndex = 7;
            this.btn_enterLogin.Text = "ENTER";
            this.btn_enterLogin.UseVisualStyleBackColor = true;
            this.btn_enterLogin.Click += new System.EventHandler(this.btn_enterLogin_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(12, 181);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(106, 21);
            this.btn_fechar.TabIndex = 8;
            this.btn_fechar.Text = "FECHAR TUDO";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 214);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_enterLogin);
            this.Controls.Add(this.btn_enterCadastro);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cadastro);
            this.Controls.Add(this.lbl_cadastro);
            this.Name = "Login";
            this.Text = "CadastroLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cadastro;
        private System.Windows.Forms.TextBox txt_cadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Button btn_enterCadastro;
        private System.Windows.Forms.Button btn_enterLogin;
        private System.Windows.Forms.Button btn_fechar;
    }
}

