namespace LISTA5_EXE4_MGVM_VAES
{
    partial class frm_pizzaria
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
            this.lbl_pizzaria = new System.Windows.Forms.Label();
            this.pnl_design = new System.Windows.Forms.Panel();
            this.btn_enunciado = new System.Windows.Forms.Button();
            this.cmb_borda = new System.Windows.Forms.ComboBox();
            this.cmb_pizza2 = new System.Windows.Forms.ComboBox();
            this.cmb_pizza1 = new System.Windows.Forms.ComboBox();
            this.chb_borda = new System.Windows.Forms.CheckBox();
            this.chb_meio = new System.Windows.Forms.CheckBox();
            this.grb_entrega = new System.Windows.Forms.GroupBox();
            this.rdb_nao = new System.Windows.Forms.RadioButton();
            this.rdb_sim = new System.Windows.Forms.RadioButton();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_adc = new System.Windows.Forms.Button();
            this.lst_pedido = new System.Windows.Forms.ListBox();
            this.pnl_design.SuspendLayout();
            this.grb_entrega.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_pizzaria
            // 
            this.lbl_pizzaria.AutoSize = true;
            this.lbl_pizzaria.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pizzaria.Location = new System.Drawing.Point(187, 9);
            this.lbl_pizzaria.Name = "lbl_pizzaria";
            this.lbl_pizzaria.Size = new System.Drawing.Size(121, 36);
            this.lbl_pizzaria.TabIndex = 0;
            this.lbl_pizzaria.Text = "Pizzaria";
            // 
            // pnl_design
            // 
            this.pnl_design.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnl_design.Controls.Add(this.lbl_pizzaria);
            this.pnl_design.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_design.Location = new System.Drawing.Point(12, 12);
            this.pnl_design.Name = "pnl_design";
            this.pnl_design.Size = new System.Drawing.Size(489, 54);
            this.pnl_design.TabIndex = 14;
            // 
            // btn_enunciado
            // 
            this.btn_enunciado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_enunciado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_enunciado.Location = new System.Drawing.Point(2, 452);
            this.btn_enunciado.Name = "btn_enunciado";
            this.btn_enunciado.Size = new System.Drawing.Size(87, 27);
            this.btn_enunciado.TabIndex = 4;
            this.btn_enunciado.Text = "Enunciado";
            this.btn_enunciado.UseVisualStyleBackColor = false;
            this.btn_enunciado.Click += new System.EventHandler(this.btn_enunciado_Click);
            // 
            // cmb_borda
            // 
            this.cmb_borda.Enabled = false;
            this.cmb_borda.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_borda.FormattingEnabled = true;
            this.cmb_borda.Items.AddRange(new object[] {
            "Calabresa Moída",
            "Mussarela",
            "Catupiry"});
            this.cmb_borda.Location = new System.Drawing.Point(284, 140);
            this.cmb_borda.Name = "cmb_borda";
            this.cmb_borda.Size = new System.Drawing.Size(186, 29);
            this.cmb_borda.TabIndex = 19;
            // 
            // cmb_pizza2
            // 
            this.cmb_pizza2.Enabled = false;
            this.cmb_pizza2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pizza2.FormattingEnabled = true;
            this.cmb_pizza2.Items.AddRange(new object[] {
            "Calabresa - R$19,00",
            "Mussarela - R$ 19,00",
            "Portuguesa - R$25,50",
            "Quatro queijos - R$25,50"});
            this.cmb_pizza2.Location = new System.Drawing.Point(18, 169);
            this.cmb_pizza2.Name = "cmb_pizza2";
            this.cmb_pizza2.Size = new System.Drawing.Size(210, 29);
            this.cmb_pizza2.TabIndex = 17;
            // 
            // cmb_pizza1
            // 
            this.cmb_pizza1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pizza1.FormattingEnabled = true;
            this.cmb_pizza1.Items.AddRange(new object[] {
            "Calabresa - R$19,00",
            "Mussarela - R$ 19,00",
            "Portuguesa - R$25,50",
            "Quatro queijos - R$25,50"});
            this.cmb_pizza1.Location = new System.Drawing.Point(18, 119);
            this.cmb_pizza1.Name = "cmb_pizza1";
            this.cmb_pizza1.Size = new System.Drawing.Size(210, 29);
            this.cmb_pizza1.TabIndex = 18;
            // 
            // chb_borda
            // 
            this.chb_borda.AutoSize = true;
            this.chb_borda.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_borda.Location = new System.Drawing.Point(294, 99);
            this.chb_borda.Name = "chb_borda";
            this.chb_borda.Size = new System.Drawing.Size(176, 26);
            this.chb_borda.TabIndex = 16;
            this.chb_borda.Text = "Borda Recheada?";
            this.chb_borda.UseVisualStyleBackColor = true;
            // 
            // chb_meio
            // 
            this.chb_meio.AutoSize = true;
            this.chb_meio.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_meio.Location = new System.Drawing.Point(18, 86);
            this.chb_meio.Name = "chb_meio";
            this.chb_meio.Size = new System.Drawing.Size(143, 26);
            this.chb_meio.TabIndex = 15;
            this.chb_meio.Text = "Meio a Meio?";
            this.chb_meio.UseVisualStyleBackColor = true;
            // 
            // grb_entrega
            // 
            this.grb_entrega.Controls.Add(this.rdb_nao);
            this.grb_entrega.Controls.Add(this.rdb_sim);
            this.grb_entrega.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_entrega.Location = new System.Drawing.Point(18, 214);
            this.grb_entrega.Name = "grb_entrega";
            this.grb_entrega.Size = new System.Drawing.Size(127, 91);
            this.grb_entrega.TabIndex = 22;
            this.grb_entrega.TabStop = false;
            this.grb_entrega.Text = "Entrega?";
            // 
            // rdb_nao
            // 
            this.rdb_nao.AutoSize = true;
            this.rdb_nao.Location = new System.Drawing.Point(25, 58);
            this.rdb_nao.Name = "rdb_nao";
            this.rdb_nao.Size = new System.Drawing.Size(62, 26);
            this.rdb_nao.TabIndex = 0;
            this.rdb_nao.TabStop = true;
            this.rdb_nao.Text = "Não";
            this.rdb_nao.UseVisualStyleBackColor = true;
            // 
            // rdb_sim
            // 
            this.rdb_sim.AutoSize = true;
            this.rdb_sim.Location = new System.Drawing.Point(25, 35);
            this.rdb_sim.Name = "rdb_sim";
            this.rdb_sim.Size = new System.Drawing.Size(59, 26);
            this.rdb_sim.TabIndex = 0;
            this.rdb_sim.TabStop = true;
            this.rdb_sim.Text = "Sim";
            this.rdb_sim.UseVisualStyleBackColor = true;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.Location = new System.Drawing.Point(365, 265);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(105, 33);
            this.btn_finalizar.TabIndex = 21;
            this.btn_finalizar.Text = "Finalizar Compra";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            // 
            // btn_adc
            // 
            this.btn_adc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adc.Location = new System.Drawing.Point(284, 214);
            this.btn_adc.Name = "btn_adc";
            this.btn_adc.Size = new System.Drawing.Size(186, 37);
            this.btn_adc.TabIndex = 20;
            this.btn_adc.Text = "Adicionar Pizza";
            this.btn_adc.UseVisualStyleBackColor = true;
            // 
            // lst_pedido
            // 
            this.lst_pedido.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_pedido.FormattingEnabled = true;
            this.lst_pedido.ItemHeight = 21;
            this.lst_pedido.Location = new System.Drawing.Point(18, 334);
            this.lst_pedido.Name = "lst_pedido";
            this.lst_pedido.Size = new System.Drawing.Size(483, 88);
            this.lst_pedido.TabIndex = 23;
            // 
            // frm_pizzaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(513, 491);
            this.Controls.Add(this.lst_pedido);
            this.Controls.Add(this.grb_entrega);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_adc);
            this.Controls.Add(this.cmb_borda);
            this.Controls.Add(this.cmb_pizza2);
            this.Controls.Add(this.cmb_pizza1);
            this.Controls.Add(this.chb_borda);
            this.Controls.Add(this.chb_meio);
            this.Controls.Add(this.pnl_design);
            this.Controls.Add(this.btn_enunciado);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_pizzaria";
            this.Text = "Pizzaria Topzera";
            this.pnl_design.ResumeLayout(false);
            this.pnl_design.PerformLayout();
            this.grb_entrega.ResumeLayout(false);
            this.grb_entrega.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pizzaria;
        private System.Windows.Forms.Panel pnl_design;
        private System.Windows.Forms.Button btn_enunciado;
        private System.Windows.Forms.ComboBox cmb_borda;
        private System.Windows.Forms.ComboBox cmb_pizza2;
        private System.Windows.Forms.ComboBox cmb_pizza1;
        private System.Windows.Forms.CheckBox chb_borda;
        private System.Windows.Forms.CheckBox chb_meio;
        private System.Windows.Forms.GroupBox grb_entrega;
        private System.Windows.Forms.RadioButton rdb_nao;
        private System.Windows.Forms.RadioButton rdb_sim;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Button btn_adc;
        private System.Windows.Forms.ListBox lst_pedido;
    }
}

