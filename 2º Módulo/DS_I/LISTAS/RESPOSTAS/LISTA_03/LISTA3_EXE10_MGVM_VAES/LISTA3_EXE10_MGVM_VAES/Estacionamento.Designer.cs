namespace LISTA3_EXE10_MGVM_VAES
{
    partial class frm_estacionamento
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
            this.lbl_hora_entrada = new System.Windows.Forms.Label();
            this.lbl_minuto_entrada = new System.Windows.Forms.Label();
            this.txt_minuto_entrada = new System.Windows.Forms.TextBox();
            this.lbl_hora_saida = new System.Windows.Forms.Label();
            this.txt_hora_saida = new System.Windows.Forms.TextBox();
            this.lbl_minuto_saida = new System.Windows.Forms.Label();
            this.txt_minuto_saida = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_enunciado = new System.Windows.Forms.Button();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_hora_entrada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_hora_entrada
            // 
            this.lbl_hora_entrada.AutoSize = true;
            this.lbl_hora_entrada.Location = new System.Drawing.Point(8, 14);
            this.lbl_hora_entrada.Name = "lbl_hora_entrada";
            this.lbl_hora_entrada.Size = new System.Drawing.Size(123, 22);
            this.lbl_hora_entrada.TabIndex = 0;
            this.lbl_hora_entrada.Text = "Hora entrada:";
            // 
            // lbl_minuto_entrada
            // 
            this.lbl_minuto_entrada.AutoSize = true;
            this.lbl_minuto_entrada.Location = new System.Drawing.Point(8, 71);
            this.lbl_minuto_entrada.Name = "lbl_minuto_entrada";
            this.lbl_minuto_entrada.Size = new System.Drawing.Size(138, 22);
            this.lbl_minuto_entrada.TabIndex = 2;
            this.lbl_minuto_entrada.Text = "Minuto entrada:";
            // 
            // txt_minuto_entrada
            // 
            this.txt_minuto_entrada.Location = new System.Drawing.Point(12, 96);
            this.txt_minuto_entrada.MaxLength = 2;
            this.txt_minuto_entrada.Name = "txt_minuto_entrada";
            this.txt_minuto_entrada.Size = new System.Drawing.Size(119, 29);
            this.txt_minuto_entrada.TabIndex = 3;
            this.txt_minuto_entrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_minuto_entrada_KeyPress);
            // 
            // lbl_hora_saida
            // 
            this.lbl_hora_saida.AutoSize = true;
            this.lbl_hora_saida.Location = new System.Drawing.Point(8, 162);
            this.lbl_hora_saida.Name = "lbl_hora_saida";
            this.lbl_hora_saida.Size = new System.Drawing.Size(107, 22);
            this.lbl_hora_saida.TabIndex = 0;
            this.lbl_hora_saida.Text = "Hora saída:";
            // 
            // txt_hora_saida
            // 
            this.txt_hora_saida.Location = new System.Drawing.Point(12, 187);
            this.txt_hora_saida.MaxLength = 2;
            this.txt_hora_saida.Name = "txt_hora_saida";
            this.txt_hora_saida.Size = new System.Drawing.Size(119, 29);
            this.txt_hora_saida.TabIndex = 1;
            this.txt_hora_saida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hora_saida_KeyPress);
            // 
            // lbl_minuto_saida
            // 
            this.lbl_minuto_saida.AutoSize = true;
            this.lbl_minuto_saida.Location = new System.Drawing.Point(8, 219);
            this.lbl_minuto_saida.Name = "lbl_minuto_saida";
            this.lbl_minuto_saida.Size = new System.Drawing.Size(122, 22);
            this.lbl_minuto_saida.TabIndex = 2;
            this.lbl_minuto_saida.Text = "Minuto saída:";
            // 
            // txt_minuto_saida
            // 
            this.txt_minuto_saida.Location = new System.Drawing.Point(12, 244);
            this.txt_minuto_saida.MaxLength = 2;
            this.txt_minuto_saida.Name = "txt_minuto_saida";
            this.txt_minuto_saida.Size = new System.Drawing.Size(119, 29);
            this.txt_minuto_saida.TabIndex = 3;
            this.txt_minuto_saida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_minuto_saida_KeyPress);
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(12, 279);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(119, 58);
            this.btn_enter.TabIndex = 4;
            this.btn_enter.Text = "ENTER";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_enunciado
            // 
            this.btn_enunciado.Location = new System.Drawing.Point(227, 12);
            this.btn_enunciado.Name = "btn_enunciado";
            this.btn_enunciado.Size = new System.Drawing.Size(135, 32);
            this.btn_enunciado.TabIndex = 5;
            this.btn_enunciado.Text = "ENUNCIADO";
            this.btn_enunciado.UseVisualStyleBackColor = true;
            this.btn_enunciado.Click += new System.EventHandler(this.btn_enunciado_Click);
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(209, 162);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(153, 22);
            this.lbl_valor.TabIndex = 6;
            this.lbl_valor.Text = "Valor a ser pago:";
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.Color.White;
            this.txt_valor.Enabled = false;
            this.txt_valor.Location = new System.Drawing.Point(213, 199);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.ReadOnly = true;
            this.txt_valor.Size = new System.Drawing.Size(149, 29);
            this.txt_valor.TabIndex = 7;
            // 
            // txt_hora_entrada
            // 
            this.txt_hora_entrada.Location = new System.Drawing.Point(12, 39);
            this.txt_hora_entrada.Name = "txt_hora_entrada";
            this.txt_hora_entrada.Size = new System.Drawing.Size(119, 29);
            this.txt_hora_entrada.TabIndex = 8;
            // 
            // frm_estacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 352);
            this.Controls.Add(this.txt_hora_entrada);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.btn_enunciado);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.txt_minuto_saida);
            this.Controls.Add(this.txt_minuto_entrada);
            this.Controls.Add(this.lbl_minuto_saida);
            this.Controls.Add(this.lbl_minuto_entrada);
            this.Controls.Add(this.txt_hora_saida);
            this.Controls.Add(this.lbl_hora_saida);
            this.Controls.Add(this.lbl_hora_entrada);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frm_estacionamento";
            this.Text = "Estacionamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hora_entrada;
        private System.Windows.Forms.Label lbl_minuto_entrada;
        private System.Windows.Forms.TextBox txt_minuto_entrada;
        private System.Windows.Forms.Label lbl_hora_saida;
        private System.Windows.Forms.TextBox txt_hora_saida;
        private System.Windows.Forms.Label lbl_minuto_saida;
        private System.Windows.Forms.TextBox txt_minuto_saida;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_enunciado;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_hora_entrada;
    }
}

