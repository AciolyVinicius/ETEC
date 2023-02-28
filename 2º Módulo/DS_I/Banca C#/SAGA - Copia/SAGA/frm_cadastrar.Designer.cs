namespace SAGA
{
    partial class frm_cadastrar
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_saga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_tipo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nome.Location = new System.Drawing.Point(109, 62);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(70, 24);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(202, 54);
            this.txt_nome.MaxLength = 100;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(300, 32);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_telefone.Location = new System.Drawing.Point(103, 118);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(76, 24);
            this.lbl_telefone.TabIndex = 2;
            this.lbl_telefone.Text = "Senha:";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(202, 110);
            this.txt_senha.MaxLength = 11;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(300, 32);
            this.txt_senha.TabIndex = 3;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_email.Location = new System.Drawing.Point(103, 174);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(74, 24);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "E-mail:";
            this.lbl_email.Click += new System.EventHandler(this.lbl_email_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(202, 166);
            this.txt_email.MaxLength = 100;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(300, 32);
            this.txt_email.TabIndex = 5;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cadastrar.Location = new System.Drawing.Point(388, 298);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(150, 38);
            this.btn_cadastrar.TabIndex = 14;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(302, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cadastro";
            // 
            // btn_saga
            // 
            this.btn_saga.BackColor = System.Drawing.Color.Transparent;
            this.btn_saga.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_saga.Location = new System.Drawing.Point(12, 12);
            this.btn_saga.Name = "btn_saga";
            this.btn_saga.Size = new System.Drawing.Size(100, 35);
            this.btn_saga.TabIndex = 16;
            this.btn_saga.Text = "S.A.G.A.";
            this.btn_saga.UseVisualStyleBackColor = false;
            this.btn_saga.Click += new System.EventHandler(this.btn_saga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(384, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tipo:";
            // 
            // lst_tipo
            // 
            this.lst_tipo.FormattingEnabled = true;
            this.lst_tipo.ItemHeight = 24;
            this.lst_tipo.Items.AddRange(new object[] {
            "Aluno"});
            this.lst_tipo.Location = new System.Drawing.Point(477, 232);
            this.lst_tipo.Name = "lst_tipo";
            this.lst_tipo.Size = new System.Drawing.Size(160, 28);
            this.lst_tipo.TabIndex = 18;
            // 
            // frm_cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::SAGA.Properties.Resources.plano_nacional_educacao;
            this.ClientSize = new System.Drawing.Size(649, 348);
            this.Controls.Add(this.lst_tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_saga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S.A.G.A. - Sistema de Aprendizagem e Gestão Acadêmica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_saga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_tipo;
    }
}