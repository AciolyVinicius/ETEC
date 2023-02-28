namespace LISTA2_EXE7_MGVM_VAES
{
    partial class lbl_produto
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
            this.lbl_preco = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.lbl_desconto = new System.Windows.Forms.Label();
            this.txt_desconto = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.lbl_pagar = new System.Windows.Forms.Label();
            this.txt_pagar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_enunciado
            // 
            this.btn_enunciado.Location = new System.Drawing.Point(322, 14);
            this.btn_enunciado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_enunciado.Name = "btn_enunciado";
            this.btn_enunciado.Size = new System.Drawing.Size(98, 32);
            this.btn_enunciado.TabIndex = 0;
            this.btn_enunciado.Text = "Enunciado";
            this.btn_enunciado.UseVisualStyleBackColor = true;
            this.btn_enunciado.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(8, 23);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(121, 23);
            this.lbl_preco.TabIndex = 1;
            this.lbl_preco.Text = "Preço em Reais";
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(12, 49);
            this.txt_preco.MaxLength = 4;
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(161, 29);
            this.txt_preco.TabIndex = 2;
            // 
            // lbl_desconto
            // 
            this.lbl_desconto.AutoSize = true;
            this.lbl_desconto.Location = new System.Drawing.Point(8, 114);
            this.lbl_desconto.Name = "lbl_desconto";
            this.lbl_desconto.Size = new System.Drawing.Size(146, 23);
            this.lbl_desconto.TabIndex = 3;
            this.lbl_desconto.Text = "Desconto em Reais";
            // 
            // txt_desconto
            // 
            this.txt_desconto.Location = new System.Drawing.Point(12, 140);
            this.txt_desconto.MaxLength = 4;
            this.txt_desconto.Name = "txt_desconto";
            this.txt_desconto.Size = new System.Drawing.Size(161, 29);
            this.txt_desconto.TabIndex = 4;
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(12, 175);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 39);
            this.btn_enter.TabIndex = 5;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // lbl_pagar
            // 
            this.lbl_pagar.AutoSize = true;
            this.lbl_pagar.Location = new System.Drawing.Point(215, 146);
            this.lbl_pagar.Name = "lbl_pagar";
            this.lbl_pagar.Size = new System.Drawing.Size(130, 23);
            this.lbl_pagar.TabIndex = 6;
            this.lbl_pagar.Text = "Preço a ser pago";
            // 
            // txt_pagar
            // 
            this.txt_pagar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_pagar.Enabled = false;
            this.txt_pagar.Location = new System.Drawing.Point(219, 175);
            this.txt_pagar.Name = "txt_pagar";
            this.txt_pagar.ReadOnly = true;
            this.txt_pagar.Size = new System.Drawing.Size(146, 29);
            this.txt_pagar.TabIndex = 7;
            // 
            // lbl_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 226);
            this.Controls.Add(this.txt_pagar);
            this.Controls.Add(this.lbl_pagar);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.txt_desconto);
            this.Controls.Add(this.lbl_desconto);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.lbl_preco);
            this.Controls.Add(this.btn_enunciado);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "lbl_produto";
            this.Text = "Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enunciado;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label lbl_desconto;
        private System.Windows.Forms.TextBox txt_desconto;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label lbl_pagar;
        private System.Windows.Forms.TextBox txt_pagar;
    }
}

