namespace CRUDMySQL
{
    partial class Frm_selecionar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_email = new System.Windows.Forms.RadioButton();
            this.rdb_nome = new System.Windows.Forms.RadioButton();
            this.rdb_codigo = new System.Windows.Forms.RadioButton();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_entrada = new System.Windows.Forms.Label();
            this.txt_entrada = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELEÇÃO DE DADOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_email);
            this.groupBox1.Controls.Add(this.rdb_nome);
            this.groupBox1.Controls.Add(this.rdb_codigo);
            this.groupBox1.Location = new System.Drawing.Point(137, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar por";
            // 
            // rdb_email
            // 
            this.rdb_email.AutoSize = true;
            this.rdb_email.Location = new System.Drawing.Point(290, 40);
            this.rdb_email.Name = "rdb_email";
            this.rdb_email.Size = new System.Drawing.Size(81, 26);
            this.rdb_email.TabIndex = 2;
            this.rdb_email.Text = "E-mail";
            this.rdb_email.UseVisualStyleBackColor = true;
            this.rdb_email.CheckedChanged += new System.EventHandler(this.rdb_email_CheckedChanged);
            // 
            // rdb_nome
            // 
            this.rdb_nome.AutoSize = true;
            this.rdb_nome.Location = new System.Drawing.Point(153, 40);
            this.rdb_nome.Name = "rdb_nome";
            this.rdb_nome.Size = new System.Drawing.Size(79, 26);
            this.rdb_nome.TabIndex = 1;
            this.rdb_nome.Text = "Nome";
            this.rdb_nome.UseVisualStyleBackColor = true;
            this.rdb_nome.CheckedChanged += new System.EventHandler(this.rdb_nome_CheckedChanged);
            // 
            // rdb_codigo
            // 
            this.rdb_codigo.AutoSize = true;
            this.rdb_codigo.Checked = true;
            this.rdb_codigo.Location = new System.Drawing.Point(25, 40);
            this.rdb_codigo.Name = "rdb_codigo";
            this.rdb_codigo.Size = new System.Drawing.Size(90, 26);
            this.rdb_codigo.TabIndex = 0;
            this.rdb_codigo.TabStop = true;
            this.rdb_codigo.Text = "Código";
            this.rdb_codigo.UseVisualStyleBackColor = true;
            this.rdb_codigo.CheckedChanged += new System.EventHandler(this.rdb_codigo_CheckedChanged);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(259, 498);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(200, 30);
            this.btn_voltar.TabIndex = 3;
            this.btn_voltar.Text = "V O L T A R";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(471, 498);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(200, 30);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "S A I R";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_entrada
            // 
            this.lbl_entrada.AutoSize = true;
            this.lbl_entrada.Location = new System.Drawing.Point(54, 202);
            this.lbl_entrada.Name = "lbl_entrada";
            this.lbl_entrada.Size = new System.Drawing.Size(77, 22);
            this.lbl_entrada.TabIndex = 5;
            this.lbl_entrada.Text = "Código:";
            // 
            // txt_entrada
            // 
            this.txt_entrada.Location = new System.Drawing.Point(137, 199);
            this.txt_entrada.Name = "txt_entrada";
            this.txt_entrada.Size = new System.Drawing.Size(477, 29);
            this.txt_entrada.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "S E L E C I O N A R";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(12, 335);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(659, 143);
            this.lbl_resultado.TabIndex = 8;
            this.lbl_resultado.Text = "Resultado...";
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frm_selecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 540);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_entrada);
            this.Controls.Add(this.lbl_entrada);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Frm_selecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD - C# e MySQL (Selecionar)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_email;
        private System.Windows.Forms.RadioButton rdb_nome;
        private System.Windows.Forms.RadioButton rdb_codigo;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_entrada;
        private System.Windows.Forms.TextBox txt_entrada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_resultado;
    }
}