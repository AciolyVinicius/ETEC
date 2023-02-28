namespace CRUDMySQL
{
    partial class Frm_atualizar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_novo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_email = new System.Windows.Forms.RadioButton();
            this.rdb_nome = new System.Windows.Forms.RadioButton();
            this.txt_novo = new System.Windows.Forms.TextBox();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATUALIZAÇÃO DE DADOS";
            // 
            // lbl_novo
            // 
            this.lbl_novo.AutoSize = true;
            this.lbl_novo.Location = new System.Drawing.Point(97, 255);
            this.lbl_novo.Name = "lbl_novo";
            this.lbl_novo.Size = new System.Drawing.Size(112, 22);
            this.lbl_novo.TabIndex = 2;
            this.lbl_novo.Text = "Nome novo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_email);
            this.groupBox1.Controls.Add(this.rdb_nome);
            this.groupBox1.Location = new System.Drawing.Point(210, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atualizar";
            // 
            // rdb_email
            // 
            this.rdb_email.AutoSize = true;
            this.rdb_email.Location = new System.Drawing.Point(168, 42);
            this.rdb_email.Name = "rdb_email";
            this.rdb_email.Size = new System.Drawing.Size(81, 26);
            this.rdb_email.TabIndex = 1;
            this.rdb_email.Text = "E-mail";
            this.rdb_email.UseVisualStyleBackColor = true;
            // 
            // rdb_nome
            // 
            this.rdb_nome.AutoSize = true;
            this.rdb_nome.Checked = true;
            this.rdb_nome.Location = new System.Drawing.Point(30, 42);
            this.rdb_nome.Name = "rdb_nome";
            this.rdb_nome.Size = new System.Drawing.Size(79, 26);
            this.rdb_nome.TabIndex = 0;
            this.rdb_nome.TabStop = true;
            this.rdb_nome.Text = "Nome";
            this.rdb_nome.UseVisualStyleBackColor = true;
            this.rdb_nome.CheckedChanged += new System.EventHandler(this.rdb_nome_CheckedChanged);
            // 
            // txt_novo
            // 
            this.txt_novo.Location = new System.Drawing.Point(210, 252);
            this.txt_novo.Name = "txt_novo";
            this.txt_novo.Size = new System.Drawing.Size(377, 29);
            this.txt_novo.TabIndex = 5;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(273, 317);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(200, 40);
            this.btn_atualizar.TabIndex = 6;
            this.btn_atualizar.Text = "A T U A L I Z A R";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(97, 199);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(112, 22);
            this.lbl_email.TabIndex = 7;
            this.lbl_email.Text = "E-mail atual:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(210, 196);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(377, 29);
            this.txt_email.TabIndex = 8;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(286, 424);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(200, 30);
            this.btn_voltar.TabIndex = 9;
            this.btn_voltar.Text = "V O L T A R";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(502, 424);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(200, 30);
            this.btn_sair.TabIndex = 10;
            this.btn_sair.Text = "S A I R";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_atualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(714, 472);
            this.ControlBox = false;
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.txt_novo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_novo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_atualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD - C# e MySQL (Atualizar)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_novo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_email;
        private System.Windows.Forms.RadioButton rdb_nome;
        private System.Windows.Forms.TextBox txt_novo;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_sair;
    }
}