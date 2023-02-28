namespace SAGA
{
    partial class frm_login
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
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_saga = new System.Windows.Forms.Label();
            this.btn_saga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.BackColor = System.Drawing.Color.Transparent;
            this.btn_cadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cadastro.Location = new System.Drawing.Point(349, 25);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(91, 29);
            this.btn_cadastro.TabIndex = 15;
            this.btn_cadastro.Text = "Cadastro";
            this.btn_cadastro.UseVisualStyleBackColor = false;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_login.Location = new System.Drawing.Point(179, 246);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(112, 34);
            this.btn_login.TabIndex = 14;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(123, 181);
            this.txt_senha.MaxLength = 32;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(250, 22);
            this.txt_senha.TabIndex = 12;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(123, 133);
            this.txt_email.MaxLength = 100;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(250, 22);
            this.txt_email.TabIndex = 13;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_senha.Location = new System.Drawing.Point(61, 184);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(64, 19);
            this.lbl_senha.TabIndex = 10;
            this.lbl_senha.Text = "Senha:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_email.Location = new System.Drawing.Point(61, 136);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(57, 19);
            this.lbl_email.TabIndex = 11;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_saga
            // 
            this.lbl_saga.AutoSize = true;
            this.lbl_saga.BackColor = System.Drawing.Color.Transparent;
            this.lbl_saga.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_saga.Location = new System.Drawing.Point(172, 25);
            this.lbl_saga.Name = "lbl_saga";
            this.lbl_saga.Size = new System.Drawing.Size(119, 37);
            this.lbl_saga.TabIndex = 9;
            this.lbl_saga.Text = "S.A.G.A.";
            // 
            // btn_saga
            // 
            this.btn_saga.BackColor = System.Drawing.Color.Transparent;
            this.btn_saga.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_saga.Location = new System.Drawing.Point(15, 25);
            this.btn_saga.Name = "btn_saga";
            this.btn_saga.Size = new System.Drawing.Size(75, 29);
            this.btn_saga.TabIndex = 8;
            this.btn_saga.Text = "S.A.G.A.";
            this.btn_saga.UseVisualStyleBackColor = false;
            this.btn_saga.Click += new System.EventHandler(this.btn_saga_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::SAGA.Properties.Resources.plano_nacional_educacao;
            this.ClientSize = new System.Drawing.Size(452, 353);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_saga);
            this.Controls.Add(this.btn_saga);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S.A.G.A. - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_saga;
        private System.Windows.Forms.Button btn_saga;
    }
}