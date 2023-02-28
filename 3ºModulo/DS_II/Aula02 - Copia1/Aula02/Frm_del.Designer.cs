namespace Aula02
{
    partial class Frm_del
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
            this.txt_PasswordDel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UsuarioDel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.lbl_del = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_PasswordDel
            // 
            this.txt_PasswordDel.Location = new System.Drawing.Point(12, 104);
            this.txt_PasswordDel.MaxLength = 10;
            this.txt_PasswordDel.Name = "txt_PasswordDel";
            this.txt_PasswordDel.Size = new System.Drawing.Size(265, 26);
            this.txt_PasswordDel.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(117, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Senha";
            // 
            // txt_UsuarioDel
            // 
            this.txt_UsuarioDel.Location = new System.Drawing.Point(12, 38);
            this.txt_UsuarioDel.MaxLength = 10;
            this.txt_UsuarioDel.Name = "txt_UsuarioDel";
            this.txt_UsuarioDel.Size = new System.Drawing.Size(265, 26);
            this.txt_UsuarioDel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuário";
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(12, 239);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(101, 44);
            this.btn_deletar.TabIndex = 15;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(96, 136);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(102, 42);
            this.btn_pesquisar.TabIndex = 16;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(180, 239);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(97, 44);
            this.btn_voltar.TabIndex = 17;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // lbl_del
            // 
            this.lbl_del.AutoSize = true;
            this.lbl_del.Location = new System.Drawing.Point(12, 196);
            this.lbl_del.Name = "lbl_del";
            this.lbl_del.Size = new System.Drawing.Size(0, 18);
            this.lbl_del.TabIndex = 18;
            // 
            // Frm_del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 295);
            this.Controls.Add(this.lbl_del);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.txt_PasswordDel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_UsuarioDel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_del";
            this.Text = "Deletar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_PasswordDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UsuarioDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label lbl_del;
    }
}