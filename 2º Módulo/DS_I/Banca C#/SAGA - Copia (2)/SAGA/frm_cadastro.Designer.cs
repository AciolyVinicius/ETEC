namespace SAGA
{
    partial class frm_cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro));
            this.pnl_topo = new System.Windows.Forms.Panel();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_cSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.txt_celular = new System.Windows.Forms.Label();
            this.txt_contato1 = new System.Windows.Forms.TextBox();
            this.txt_contato2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nome_responsavel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_contato_responsavel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_email_responsavel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cpf_responsavel = new System.Windows.Forms.TextBox();
            this.lst_tipo = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnl_topo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_topo
            // 
            this.pnl_topo.BackColor = System.Drawing.Color.DarkBlue;
            this.pnl_topo.Controls.Add(this.btn_entrar);
            this.pnl_topo.Location = new System.Drawing.Point(1, -3);
            this.pnl_topo.Name = "pnl_topo";
            this.pnl_topo.Size = new System.Drawing.Size(882, 75);
            this.pnl_topo.TabIndex = 1;
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.White;
            this.btn_entrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.Color.Black;
            this.btn_entrar.Location = new System.Drawing.Point(747, 15);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(124, 52);
            this.btn_entrar.TabIndex = 1;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "*Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "*E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "*Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "*Confirmar senha:";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(448, 212);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(277, 32);
            this.txt_nome.TabIndex = 6;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(448, 250);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(277, 32);
            this.txt_email.TabIndex = 7;
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(448, 291);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(277, 32);
            this.txt_senha.TabIndex = 8;
            // 
            // txt_cSenha
            // 
            this.txt_cSenha.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cSenha.Location = new System.Drawing.Point(448, 336);
            this.txt_cSenha.Name = "txt_cSenha";
            this.txt_cSenha.PasswordChar = '*';
            this.txt_cSenha.Size = new System.Drawing.Size(277, 32);
            this.txt_cSenha.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 317);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(448, 987);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 62);
            this.button1.TabIndex = 11;
            this.button1.Text = "Salvar dados";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(325, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 75);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cadastre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "*CPF:";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpf.Location = new System.Drawing.Point(448, 374);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.PasswordChar = '*';
            this.txt_cpf.Size = new System.Drawing.Size(277, 32);
            this.txt_cpf.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(387, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "*RG:";
            // 
            // txt_rg
            // 
            this.txt_rg.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rg.Location = new System.Drawing.Point(448, 412);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.PasswordChar = '*';
            this.txt_rg.Size = new System.Drawing.Size(277, 32);
            this.txt_rg.TabIndex = 9;
            // 
            // txt_celular
            // 
            this.txt_celular.AutoSize = true;
            this.txt_celular.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celular.Location = new System.Drawing.Point(159, 453);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(283, 24);
            this.txt_celular.TabIndex = 5;
            this.txt_celular.Text = "*Contato(celular ou telefone):\r\n";
            // 
            // txt_contato1
            // 
            this.txt_contato1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contato1.Location = new System.Drawing.Point(448, 450);
            this.txt_contato1.Name = "txt_contato1";
            this.txt_contato1.PasswordChar = '*';
            this.txt_contato1.Size = new System.Drawing.Size(277, 32);
            this.txt_contato1.TabIndex = 9;
            // 
            // txt_contato2
            // 
            this.txt_contato2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contato2.Location = new System.Drawing.Point(448, 488);
            this.txt_contato2.Name = "txt_contato2";
            this.txt_contato2.PasswordChar = '*';
            this.txt_contato2.Size = new System.Drawing.Size(277, 32);
            this.txt_contato2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(167, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Contato(celular ou telefone):\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(308, 529);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Responsável:";
            // 
            // txt_nome_responsavel
            // 
            this.txt_nome_responsavel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_responsavel.Location = new System.Drawing.Point(448, 526);
            this.txt_nome_responsavel.Name = "txt_nome_responsavel";
            this.txt_nome_responsavel.PasswordChar = '*';
            this.txt_nome_responsavel.Size = new System.Drawing.Size(277, 32);
            this.txt_nome_responsavel.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(236, 567);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "Contato responsável:";
            // 
            // txt_contato_responsavel
            // 
            this.txt_contato_responsavel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contato_responsavel.Location = new System.Drawing.Point(448, 564);
            this.txt_contato_responsavel.Name = "txt_contato_responsavel";
            this.txt_contato_responsavel.PasswordChar = '*';
            this.txt_contato_responsavel.Size = new System.Drawing.Size(277, 32);
            this.txt_contato_responsavel.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(248, 605);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 48);
            this.label11.TabIndex = 5;
            this.label11.Text = "E-mail responsavel:\r\n\r\n";
            // 
            // txt_email_responsavel
            // 
            this.txt_email_responsavel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email_responsavel.Location = new System.Drawing.Point(448, 602);
            this.txt_email_responsavel.Name = "txt_email_responsavel";
            this.txt_email_responsavel.PasswordChar = '*';
            this.txt_email_responsavel.Size = new System.Drawing.Size(277, 32);
            this.txt_email_responsavel.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(264, 643);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 48);
            this.label12.TabIndex = 5;
            this.label12.Text = "CPF responsavel:\r\n\r\n";
            // 
            // txt_cpf_responsavel
            // 
            this.txt_cpf_responsavel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpf_responsavel.Location = new System.Drawing.Point(448, 640);
            this.txt_cpf_responsavel.Name = "txt_cpf_responsavel";
            this.txt_cpf_responsavel.PasswordChar = '*';
            this.txt_cpf_responsavel.Size = new System.Drawing.Size(277, 32);
            this.txt_cpf_responsavel.TabIndex = 9;
            // 
            // lst_tipo
            // 
            this.lst_tipo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_tipo.FormattingEnabled = true;
            this.lst_tipo.ItemHeight = 23;
            this.lst_tipo.Items.AddRange(new object[] {
            "Administrador",
            "Gerenciador",
            "Professor",
            "Aluno"});
            this.lst_tipo.Location = new System.Drawing.Point(448, 678);
            this.lst_tipo.Name = "lst_tipo";
            this.lst_tipo.Size = new System.Drawing.Size(277, 27);
            this.lst_tipo.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(389, 682);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 23);
            this.label13.TabIndex = 19;
            this.label13.Text = "Tipo:";
            // 
            // frm_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 1061);
            this.Controls.Add(this.lst_tipo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_cpf_responsavel);
            this.Controls.Add(this.txt_email_responsavel);
            this.Controls.Add(this.txt_contato_responsavel);
            this.Controls.Add(this.txt_nome_responsavel);
            this.Controls.Add(this.txt_contato2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_contato1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_cSenha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_celular);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_topo);
            this.MaximizeBox = false;
            this.Name = "frm_cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S.A.G.A. - Cadastro";
            this.pnl_topo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_topo;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_cSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.Label txt_celular;
        private System.Windows.Forms.TextBox txt_contato1;
        private System.Windows.Forms.TextBox txt_contato2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nome_responsavel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_contato_responsavel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_email_responsavel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_cpf_responsavel;
        private System.Windows.Forms.ListBox lst_tipo;
        private System.Windows.Forms.Label label13;
    }
}