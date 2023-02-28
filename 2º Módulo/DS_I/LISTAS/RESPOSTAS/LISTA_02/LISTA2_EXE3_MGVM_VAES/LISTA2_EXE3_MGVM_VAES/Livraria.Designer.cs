namespace LISTA2_EXE3_MGVM_VAES
{
    partial class lbl_livraria
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
            this.btn_comprar = new System.Windows.Forms.Button();
            this.lbl_livro = new System.Windows.Forms.Label();
            this.txt_livro = new System.Windows.Forms.TextBox();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.lbl_ator = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lst_categoria = new System.Windows.Forms.ListBox();
            this.lst_pagamento = new System.Windows.Forms.ListBox();
            this.lbl_pagamento = new System.Windows.Forms.Label();
            this.lbl_ebook = new System.Windows.Forms.Label();
            this.btn_enunciado = new System.Windows.Forms.Button();
            this.chb_disponível = new System.Windows.Forms.CheckBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_comprar
            // 
            this.btn_comprar.Location = new System.Drawing.Point(288, 157);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(75, 23);
            this.btn_comprar.TabIndex = 0;
            this.btn_comprar.Text = "COMPRAR";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // lbl_livro
            // 
            this.lbl_livro.AutoSize = true;
            this.lbl_livro.Location = new System.Drawing.Point(23, 28);
            this.lbl_livro.Name = "lbl_livro";
            this.lbl_livro.Size = new System.Drawing.Size(86, 16);
            this.lbl_livro.TabIndex = 3;
            this.lbl_livro.Text = "Nome do livro";
            // 
            // txt_livro
            // 
            this.txt_livro.Location = new System.Drawing.Point(26, 47);
            this.txt_livro.MaxLength = 20;
            this.txt_livro.Name = "txt_livro";
            this.txt_livro.Size = new System.Drawing.Size(100, 22);
            this.txt_livro.TabIndex = 4;
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(192, 47);
            this.txt_autor.MaxLength = 30;
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(100, 22);
            this.txt_autor.TabIndex = 5;
            // 
            // lbl_ator
            // 
            this.lbl_ator.AutoSize = true;
            this.lbl_ator.Location = new System.Drawing.Point(189, 28);
            this.lbl_ator.Name = "lbl_ator";
            this.lbl_ator.Size = new System.Drawing.Size(93, 16);
            this.lbl_ator.TabIndex = 6;
            this.lbl_ator.Text = "Nome do autor";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(189, 85);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(174, 16);
            this.lbl_valor.TabIndex = 7;
            this.lbl_valor.Text = "Valor unitário do livro em real";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(192, 104);
            this.txt_valor.MaxLength = 5;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(171, 22);
            this.txt_valor.TabIndex = 8;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(23, 85);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(63, 16);
            this.lbl_categoria.TabIndex = 9;
            this.lbl_categoria.Text = "Categoria";
            // 
            // lst_categoria
            // 
            this.lst_categoria.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lst_categoria.FormattingEnabled = true;
            this.lst_categoria.ItemHeight = 16;
            this.lst_categoria.Items.AddRange(new object[] {
            "Romance",
            "Drama",
            "Aventura",
            "Terror",
            "Ficção"});
            this.lst_categoria.Location = new System.Drawing.Point(26, 104);
            this.lst_categoria.Name = "lst_categoria";
            this.lst_categoria.Size = new System.Drawing.Size(129, 36);
            this.lst_categoria.TabIndex = 10;
            // 
            // lst_pagamento
            // 
            this.lst_pagamento.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lst_pagamento.FormattingEnabled = true;
            this.lst_pagamento.ItemHeight = 16;
            this.lst_pagamento.Items.AddRange(new object[] {
            "Cartão de Crédito",
            "Boleto",
            "Dinheiro"});
            this.lst_pagamento.Location = new System.Drawing.Point(26, 176);
            this.lst_pagamento.Name = "lst_pagamento";
            this.lst_pagamento.Size = new System.Drawing.Size(129, 36);
            this.lst_pagamento.TabIndex = 11;
            // 
            // lbl_pagamento
            // 
            this.lbl_pagamento.AutoSize = true;
            this.lbl_pagamento.Location = new System.Drawing.Point(23, 157);
            this.lbl_pagamento.Name = "lbl_pagamento";
            this.lbl_pagamento.Size = new System.Drawing.Size(118, 16);
            this.lbl_pagamento.TabIndex = 12;
            this.lbl_pagamento.Text = "Tipo de pagamento";
            // 
            // lbl_ebook
            // 
            this.lbl_ebook.AutoSize = true;
            this.lbl_ebook.Location = new System.Drawing.Point(189, 157);
            this.lbl_ebook.Name = "lbl_ebook";
            this.lbl_ebook.Size = new System.Drawing.Size(49, 16);
            this.lbl_ebook.TabIndex = 14;
            this.lbl_ebook.Text = "Ebook ";
            // 
            // btn_enunciado
            // 
            this.btn_enunciado.Location = new System.Drawing.Point(11, 2);
            this.btn_enunciado.Name = "btn_enunciado";
            this.btn_enunciado.Size = new System.Drawing.Size(98, 23);
            this.btn_enunciado.TabIndex = 15;
            this.btn_enunciado.Text = "Enunciado";
            this.btn_enunciado.UseVisualStyleBackColor = true;
            this.btn_enunciado.Click += new System.EventHandler(this.btn_enunciado_Click);
            // 
            // chb_disponível
            // 
            this.chb_disponível.AutoSize = true;
            this.chb_disponível.ImageKey = "(none)";
            this.chb_disponível.Location = new System.Drawing.Point(192, 176);
            this.chb_disponível.Name = "chb_disponível";
            this.chb_disponível.Size = new System.Drawing.Size(85, 20);
            this.chb_disponível.TabIndex = 16;
            this.chb_disponível.Text = "Disponível";
            this.chb_disponível.UseVisualStyleBackColor = true;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(288, 186);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 17;
            this.btn_fechar.Text = "FECHAR";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // lbl_livraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(392, 251);
            this.ControlBox = false;
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.chb_disponível);
            this.Controls.Add(this.btn_enunciado);
            this.Controls.Add(this.lbl_ebook);
            this.Controls.Add(this.lbl_pagamento);
            this.Controls.Add(this.lst_pagamento);
            this.Controls.Add(this.lst_categoria);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_ator);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.txt_livro);
            this.Controls.Add(this.lbl_livro);
            this.Controls.Add(this.btn_comprar);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "lbl_livraria";
            this.Text = "Livraria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Label lbl_livro;
        private System.Windows.Forms.TextBox txt_livro;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.Label lbl_ator;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.ListBox lst_categoria;
        private System.Windows.Forms.ListBox lst_pagamento;
        private System.Windows.Forms.Label lbl_pagamento;
        private System.Windows.Forms.Label lbl_ebook;
        private System.Windows.Forms.Button btn_enunciado;
        private System.Windows.Forms.CheckBox chb_disponível;
        private System.Windows.Forms.Button btn_fechar;
    }
}

