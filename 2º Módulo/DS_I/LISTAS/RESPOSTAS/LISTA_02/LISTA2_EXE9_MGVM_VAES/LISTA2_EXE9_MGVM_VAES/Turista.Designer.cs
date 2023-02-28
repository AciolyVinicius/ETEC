namespace LISTA2_EXE9_MGVM_VAES
{
    partial class lbl_turista
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
            this.btn_enunciado = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_dolar = new System.Windows.Forms.Label();
            this.lbl_cotacao = new System.Windows.Forms.Label();
            this.lbl_real = new System.Windows.Forms.Label();
            this.txt_real = new System.Windows.Forms.TextBox();
            this.txt_cotacao = new System.Windows.Forms.TextBox();
            this.txt_dolar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_enunciado
            // 
            this.btn_enunciado.Location = new System.Drawing.Point(342, 18);
            this.btn_enunciado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_enunciado.Name = "btn_enunciado";
            this.btn_enunciado.Size = new System.Drawing.Size(100, 35);
            this.btn_enunciado.TabIndex = 0;
            this.btn_enunciado.Text = "Enunciado";
            this.btn_enunciado.UseVisualStyleBackColor = true;
            this.btn_enunciado.Click += new System.EventHandler(this.btn_enunciado_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_dolar
            // 
            this.lbl_dolar.AutoSize = true;
            this.lbl_dolar.Location = new System.Drawing.Point(12, 18);
            this.lbl_dolar.Name = "lbl_dolar";
            this.lbl_dolar.Size = new System.Drawing.Size(135, 20);
            this.lbl_dolar.TabIndex = 2;
            this.lbl_dolar.Text = "Quantidade em Dólar";
            // 
            // lbl_cotacao
            // 
            this.lbl_cotacao.AutoSize = true;
            this.lbl_cotacao.Location = new System.Drawing.Point(12, 92);
            this.lbl_cotacao.Name = "lbl_cotacao";
            this.lbl_cotacao.Size = new System.Drawing.Size(186, 20);
            this.lbl_cotacao.TabIndex = 3;
            this.lbl_cotacao.Text = "Cotação do Dólar para o Real";
            // 
            // lbl_real
            // 
            this.lbl_real.AutoSize = true;
            this.lbl_real.Location = new System.Drawing.Point(287, 92);
            this.lbl_real.Name = "lbl_real";
            this.lbl_real.Size = new System.Drawing.Size(94, 20);
            this.lbl_real.TabIndex = 4;
            this.lbl_real.Text = "Valor em Real";
            // 
            // txt_real
            // 
            this.txt_real.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_real.Enabled = false;
            this.txt_real.Location = new System.Drawing.Point(291, 115);
            this.txt_real.Name = "txt_real";
            this.txt_real.ReadOnly = true;
            this.txt_real.Size = new System.Drawing.Size(151, 26);
            this.txt_real.TabIndex = 5;
            // 
            // txt_cotacao
            // 
            this.txt_cotacao.Location = new System.Drawing.Point(16, 115);
            this.txt_cotacao.MaxLength = 5;
            this.txt_cotacao.Name = "txt_cotacao";
            this.txt_cotacao.Size = new System.Drawing.Size(158, 26);
            this.txt_cotacao.TabIndex = 6;
            // 
            // txt_dolar
            // 
            this.txt_dolar.Location = new System.Drawing.Point(16, 41);
            this.txt_dolar.MaxLength = 5;
            this.txt_dolar.Name = "txt_dolar";
            this.txt_dolar.Size = new System.Drawing.Size(158, 26);
            this.txt_dolar.TabIndex = 7;
            // 
            // lbl_turista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 175);
            this.Controls.Add(this.txt_dolar);
            this.Controls.Add(this.txt_cotacao);
            this.Controls.Add(this.txt_real);
            this.Controls.Add(this.lbl_real);
            this.Controls.Add(this.lbl_cotacao);
            this.Controls.Add(this.lbl_dolar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_enunciado);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "lbl_turista";
            this.Text = "Turista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enunciado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_dolar;
        private System.Windows.Forms.Label lbl_cotacao;
        private System.Windows.Forms.Label lbl_real;
        private System.Windows.Forms.TextBox txt_real;
        private System.Windows.Forms.TextBox txt_cotacao;
        private System.Windows.Forms.TextBox txt_dolar;
    }
}

