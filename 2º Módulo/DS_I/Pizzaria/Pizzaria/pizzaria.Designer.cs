namespace Pizzaria
{
    partial class pizzaria
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
            this.lst_borda_recheada = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckb_borda = new System.Windows.Forms.CheckBox();
            this.lst_pizza1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckb_meia = new System.Windows.Forms.CheckBox();
            this.lst_pizza2 = new System.Windows.Forms.ListBox();
            this.btn_finalizar_compra = new System.Windows.Forms.Button();
            this.btn_nova_pizza = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_borda_recheada
            // 
            this.lst_borda_recheada.Enabled = false;
            this.lst_borda_recheada.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_borda_recheada.FormattingEnabled = true;
            this.lst_borda_recheada.ItemHeight = 22;
            this.lst_borda_recheada.Items.AddRange(new object[] {
            "Calabresa moída",
            "Mussarela",
            "Catupiry"});
            this.lst_borda_recheada.Location = new System.Drawing.Point(493, 77);
            this.lst_borda_recheada.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lst_borda_recheada.Name = "lst_borda_recheada";
            this.lst_borda_recheada.Size = new System.Drawing.Size(384, 70);
            this.lst_borda_recheada.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borda recheada:";
            // 
            // ckb_borda
            // 
            this.ckb_borda.AutoSize = true;
            this.ckb_borda.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_borda.Location = new System.Drawing.Point(493, 55);
            this.ckb_borda.Name = "ckb_borda";
            this.ckb_borda.Size = new System.Drawing.Size(15, 14);
            this.ckb_borda.TabIndex = 2;
            this.ckb_borda.UseVisualStyleBackColor = true;
            this.ckb_borda.CheckedChanged += new System.EventHandler(this.ckb_borda_CheckedChanged);
            // 
            // lst_pizza1
            // 
            this.lst_pizza1.FormattingEnabled = true;
            this.lst_pizza1.ItemHeight = 22;
            this.lst_pizza1.Items.AddRange(new object[] {
            "Calabresa\tR$15,00",
            "Mussarela\tR$15,00",
            "Portuguesa\tR$16,50",
            "Quatro queijos\tR$20,00",
            "Aliche\t\tR$25,00"});
            this.lst_pizza1.Location = new System.Drawing.Point(12, 60);
            this.lst_pizza1.Name = "lst_pizza1";
            this.lst_pizza1.Size = new System.Drawing.Size(361, 114);
            this.lst_pizza1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pizza:";
            // 
            // ckb_meia
            // 
            this.ckb_meia.AutoSize = true;
            this.ckb_meia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_meia.Location = new System.Drawing.Point(16, 180);
            this.ckb_meia.Name = "ckb_meia";
            this.ckb_meia.Size = new System.Drawing.Size(104, 26);
            this.ckb_meia.TabIndex = 5;
            this.ckb_meia.Text = "1/2 a 1/2";
            this.ckb_meia.UseVisualStyleBackColor = true;
            this.ckb_meia.CheckedChanged += new System.EventHandler(this.ckb_meia_CheckedChanged);
            // 
            // lst_pizza2
            // 
            this.lst_pizza2.Enabled = false;
            this.lst_pizza2.FormattingEnabled = true;
            this.lst_pizza2.ItemHeight = 22;
            this.lst_pizza2.Items.AddRange(new object[] {
            "Calabresa\tR$15,00",
            "Mussarela\tR$15,00",
            "Portuguesa\tR$16,50",
            "Quatro queijos\tR$20,00",
            "Aliche\t\tR$25,00"});
            this.lst_pizza2.Location = new System.Drawing.Point(16, 212);
            this.lst_pizza2.Name = "lst_pizza2";
            this.lst_pizza2.Size = new System.Drawing.Size(361, 114);
            this.lst_pizza2.TabIndex = 3;
            // 
            // btn_finalizar_compra
            // 
            this.btn_finalizar_compra.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar_compra.Location = new System.Drawing.Point(493, 305);
            this.btn_finalizar_compra.Name = "btn_finalizar_compra";
            this.btn_finalizar_compra.Size = new System.Drawing.Size(222, 38);
            this.btn_finalizar_compra.TabIndex = 6;
            this.btn_finalizar_compra.Text = "FINALIZAR COMPRA";
            this.btn_finalizar_compra.UseVisualStyleBackColor = true;
            this.btn_finalizar_compra.Click += new System.EventHandler(this.btn_finalizar_compra_Click);
            // 
            // btn_nova_pizza
            // 
            this.btn_nova_pizza.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nova_pizza.Location = new System.Drawing.Point(721, 305);
            this.btn_nova_pizza.Name = "btn_nova_pizza";
            this.btn_nova_pizza.Size = new System.Drawing.Size(156, 38);
            this.btn_nova_pizza.TabIndex = 6;
            this.btn_nova_pizza.Text = "NOVA PIZZA";
            this.btn_nova_pizza.UseVisualStyleBackColor = true;
            this.btn_nova_pizza.Click += new System.EventHandler(this.btn_nova_pizza_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(429, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "OBRIGADO POR NOS ESCOLHER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Custo: R$1,50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(429, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "<3";
            // 
            // pizzaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 373);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_nova_pizza);
            this.Controls.Add(this.btn_finalizar_compra);
            this.Controls.Add(this.ckb_meia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_pizza2);
            this.Controls.Add(this.lst_pizza1);
            this.Controls.Add(this.ckb_borda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_borda_recheada);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "pizzaria";
            this.Text = "Pizzaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_borda_recheada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckb_borda;
        private System.Windows.Forms.ListBox lst_pizza1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckb_meia;
        private System.Windows.Forms.ListBox lst_pizza2;
        private System.Windows.Forms.Button btn_finalizar_compra;
        private System.Windows.Forms.Button btn_nova_pizza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

