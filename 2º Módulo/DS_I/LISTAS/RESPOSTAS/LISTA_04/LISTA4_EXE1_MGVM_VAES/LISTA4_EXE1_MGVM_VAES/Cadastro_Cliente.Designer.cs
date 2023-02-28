namespace LISTA4_EXE1_MGVM_VAES
{
    partial class form_cadastro_cliente
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
            this.lbl_nome_cliente = new System.Windows.Forms.Label();
            this.txt_nome_cliente = new System.Windows.Forms.TextBox();
            this.grb_primeira_compra = new System.Windows.Forms.GroupBox();
            this.rdb_nao_primeira_compra = new System.Windows.Forms.RadioButton();
            this.rdb_sim_primeira_compra = new System.Windows.Forms.RadioButton();
            this.lbl_valor_compra = new System.Windows.Forms.Label();
            this.txt_valor_compra = new System.Windows.Forms.TextBox();
            this.grb_tipo_fatura = new System.Windows.Forms.GroupBox();
            this.rdb_60_dias = new System.Windows.Forms.RadioButton();
            this.rdb_30_dias = new System.Windows.Forms.RadioButton();
            this.rdb_avista = new System.Windows.Forms.RadioButton();
            this.grb_vendedor = new System.Windows.Forms.GroupBox();
            this.rdb_vend4 = new System.Windows.Forms.RadioButton();
            this.rdb_vend3 = new System.Windows.Forms.RadioButton();
            this.rdb_vend2 = new System.Windows.Forms.RadioButton();
            this.rdb_vend1 = new System.Windows.Forms.RadioButton();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_enunciado = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.grb_primeira_compra.SuspendLayout();
            this.grb_tipo_fatura.SuspendLayout();
            this.grb_vendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nome_cliente
            // 
            this.lbl_nome_cliente.AutoSize = true;
            this.lbl_nome_cliente.Location = new System.Drawing.Point(8, 28);
            this.lbl_nome_cliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_nome_cliente.Name = "lbl_nome_cliente";
            this.lbl_nome_cliente.Size = new System.Drawing.Size(157, 22);
            this.lbl_nome_cliente.TabIndex = 0;
            this.lbl_nome_cliente.Text = "Nome do Cliente:";
            // 
            // txt_nome_cliente
            // 
            this.txt_nome_cliente.Location = new System.Drawing.Point(12, 53);
            this.txt_nome_cliente.Name = "txt_nome_cliente";
            this.txt_nome_cliente.Size = new System.Drawing.Size(497, 29);
            this.txt_nome_cliente.TabIndex = 1;
            this.txt_nome_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_cliente_KeyPress);
            // 
            // grb_primeira_compra
            // 
            this.grb_primeira_compra.Controls.Add(this.rdb_nao_primeira_compra);
            this.grb_primeira_compra.Controls.Add(this.rdb_sim_primeira_compra);
            this.grb_primeira_compra.Location = new System.Drawing.Point(12, 101);
            this.grb_primeira_compra.Name = "grb_primeira_compra";
            this.grb_primeira_compra.Size = new System.Drawing.Size(193, 63);
            this.grb_primeira_compra.TabIndex = 2;
            this.grb_primeira_compra.TabStop = false;
            this.grb_primeira_compra.Text = "Primeira Compra?";
            // 
            // rdb_nao_primeira_compra
            // 
            this.rdb_nao_primeira_compra.AutoSize = true;
            this.rdb_nao_primeira_compra.Location = new System.Drawing.Point(76, 28);
            this.rdb_nao_primeira_compra.Name = "rdb_nao_primeira_compra";
            this.rdb_nao_primeira_compra.Size = new System.Drawing.Size(62, 26);
            this.rdb_nao_primeira_compra.TabIndex = 1;
            this.rdb_nao_primeira_compra.TabStop = true;
            this.rdb_nao_primeira_compra.Text = "Não";
            this.rdb_nao_primeira_compra.UseVisualStyleBackColor = true;
            this.rdb_nao_primeira_compra.CheckedChanged += new System.EventHandler(this.rdb_nao_primeira_compra_CheckedChanged);
            // 
            // rdb_sim_primeira_compra
            // 
            this.rdb_sim_primeira_compra.AutoSize = true;
            this.rdb_sim_primeira_compra.Location = new System.Drawing.Point(6, 28);
            this.rdb_sim_primeira_compra.Name = "rdb_sim_primeira_compra";
            this.rdb_sim_primeira_compra.Size = new System.Drawing.Size(61, 26);
            this.rdb_sim_primeira_compra.TabIndex = 0;
            this.rdb_sim_primeira_compra.TabStop = true;
            this.rdb_sim_primeira_compra.Text = "Sim";
            this.rdb_sim_primeira_compra.UseVisualStyleBackColor = true;
            this.rdb_sim_primeira_compra.CheckedChanged += new System.EventHandler(this.rdb_sim_primeira_compra_CheckedChanged);
            // 
            // lbl_valor_compra
            // 
            this.lbl_valor_compra.AutoSize = true;
            this.lbl_valor_compra.Location = new System.Drawing.Point(265, 110);
            this.lbl_valor_compra.Name = "lbl_valor_compra";
            this.lbl_valor_compra.Size = new System.Drawing.Size(157, 22);
            this.lbl_valor_compra.TabIndex = 3;
            this.lbl_valor_compra.Text = "Valor da Compra:";
            // 
            // txt_valor_compra
            // 
            this.txt_valor_compra.Location = new System.Drawing.Point(269, 135);
            this.txt_valor_compra.Name = "txt_valor_compra";
            this.txt_valor_compra.Size = new System.Drawing.Size(240, 29);
            this.txt_valor_compra.TabIndex = 4;
            this.txt_valor_compra.TextChanged += new System.EventHandler(this.txt_valor_compra_TextChanged);
            this.txt_valor_compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_compra_KeyPress);
            // 
            // grb_tipo_fatura
            // 
            this.grb_tipo_fatura.Controls.Add(this.rdb_60_dias);
            this.grb_tipo_fatura.Controls.Add(this.rdb_30_dias);
            this.grb_tipo_fatura.Controls.Add(this.rdb_avista);
            this.grb_tipo_fatura.Location = new System.Drawing.Point(18, 192);
            this.grb_tipo_fatura.Name = "grb_tipo_fatura";
            this.grb_tipo_fatura.Size = new System.Drawing.Size(173, 141);
            this.grb_tipo_fatura.TabIndex = 5;
            this.grb_tipo_fatura.TabStop = false;
            this.grb_tipo_fatura.Text = "Tipo de Fatura";
            // 
            // rdb_60_dias
            // 
            this.rdb_60_dias.AutoSize = true;
            this.rdb_60_dias.Location = new System.Drawing.Point(12, 97);
            this.rdb_60_dias.Name = "rdb_60_dias";
            this.rdb_60_dias.Size = new System.Drawing.Size(90, 26);
            this.rdb_60_dias.TabIndex = 2;
            this.rdb_60_dias.TabStop = true;
            this.rdb_60_dias.Text = "60 dias";
            this.rdb_60_dias.UseVisualStyleBackColor = true;
            // 
            // rdb_30_dias
            // 
            this.rdb_30_dias.AutoSize = true;
            this.rdb_30_dias.Location = new System.Drawing.Point(12, 65);
            this.rdb_30_dias.Name = "rdb_30_dias";
            this.rdb_30_dias.Size = new System.Drawing.Size(90, 26);
            this.rdb_30_dias.TabIndex = 1;
            this.rdb_30_dias.TabStop = true;
            this.rdb_30_dias.Text = "30 dias";
            this.rdb_30_dias.UseVisualStyleBackColor = true;
            // 
            // rdb_avista
            // 
            this.rdb_avista.AutoSize = true;
            this.rdb_avista.Location = new System.Drawing.Point(12, 33);
            this.rdb_avista.Name = "rdb_avista";
            this.rdb_avista.Size = new System.Drawing.Size(83, 26);
            this.rdb_avista.TabIndex = 0;
            this.rdb_avista.TabStop = true;
            this.rdb_avista.Text = "A vista";
            this.rdb_avista.UseVisualStyleBackColor = true;
            // 
            // grb_vendedor
            // 
            this.grb_vendedor.Controls.Add(this.rdb_vend4);
            this.grb_vendedor.Controls.Add(this.rdb_vend3);
            this.grb_vendedor.Controls.Add(this.rdb_vend2);
            this.grb_vendedor.Controls.Add(this.rdb_vend1);
            this.grb_vendedor.Location = new System.Drawing.Point(269, 192);
            this.grb_vendedor.Name = "grb_vendedor";
            this.grb_vendedor.Size = new System.Drawing.Size(240, 164);
            this.grb_vendedor.TabIndex = 6;
            this.grb_vendedor.TabStop = false;
            this.grb_vendedor.Text = "Vendedor";
            // 
            // rdb_vend4
            // 
            this.rdb_vend4.AutoSize = true;
            this.rdb_vend4.Location = new System.Drawing.Point(6, 129);
            this.rdb_vend4.Name = "rdb_vend4";
            this.rdb_vend4.Size = new System.Drawing.Size(83, 26);
            this.rdb_vend4.TabIndex = 3;
            this.rdb_vend4.TabStop = true;
            this.rdb_vend4.Text = "Carlos";
            this.rdb_vend4.UseVisualStyleBackColor = true;
            // 
            // rdb_vend3
            // 
            this.rdb_vend3.AutoSize = true;
            this.rdb_vend3.Location = new System.Drawing.Point(6, 97);
            this.rdb_vend3.Name = "rdb_vend3";
            this.rdb_vend3.Size = new System.Drawing.Size(73, 26);
            this.rdb_vend3.TabIndex = 2;
            this.rdb_vend3.TabStop = true;
            this.rdb_vend3.Text = "Maria";
            this.rdb_vend3.UseVisualStyleBackColor = true;
            // 
            // rdb_vend2
            // 
            this.rdb_vend2.AutoSize = true;
            this.rdb_vend2.Location = new System.Drawing.Point(6, 65);
            this.rdb_vend2.Name = "rdb_vend2";
            this.rdb_vend2.Size = new System.Drawing.Size(94, 26);
            this.rdb_vend2.TabIndex = 1;
            this.rdb_vend2.TabStop = true;
            this.rdb_vend2.Text = "Ernesto";
            this.rdb_vend2.UseVisualStyleBackColor = true;
            // 
            // rdb_vend1
            // 
            this.rdb_vend1.AutoSize = true;
            this.rdb_vend1.Location = new System.Drawing.Point(6, 33);
            this.rdb_vend1.Name = "rdb_vend1";
            this.rdb_vend1.Size = new System.Drawing.Size(100, 26);
            this.rdb_vend1.TabIndex = 0;
            this.rdb_vend1.TabStop = true;
            this.rdb_vend1.Text = "Joaquim";
            this.rdb_vend1.UseVisualStyleBackColor = true;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(88, 370);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(97, 31);
            this.btn_confirmar.TabIndex = 7;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(434, 370);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 31);
            this.btn_sair.TabIndex = 8;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_enunciado
            // 
            this.btn_enunciado.Location = new System.Drawing.Point(394, 12);
            this.btn_enunciado.Name = "btn_enunciado";
            this.btn_enunciado.Size = new System.Drawing.Size(115, 35);
            this.btn_enunciado.TabIndex = 9;
            this.btn_enunciado.Text = "Enunciado";
            this.btn_enunciado.UseVisualStyleBackColor = true;
            this.btn_enunciado.Click += new System.EventHandler(this.btn_enunciado_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(269, 370);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(79, 31);
            this.btn_limpar.TabIndex = 10;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // form_cadastro_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 413);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_enunciado);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.grb_vendedor);
            this.Controls.Add(this.grb_tipo_fatura);
            this.Controls.Add(this.txt_valor_compra);
            this.Controls.Add(this.lbl_valor_compra);
            this.Controls.Add(this.grb_primeira_compra);
            this.Controls.Add(this.txt_nome_cliente);
            this.Controls.Add(this.lbl_nome_cliente);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "form_cadastro_cliente";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.form_cadastro_cliente_Load);
            this.grb_primeira_compra.ResumeLayout(false);
            this.grb_primeira_compra.PerformLayout();
            this.grb_tipo_fatura.ResumeLayout(false);
            this.grb_tipo_fatura.PerformLayout();
            this.grb_vendedor.ResumeLayout(false);
            this.grb_vendedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome_cliente;
        private System.Windows.Forms.TextBox txt_nome_cliente;
        private System.Windows.Forms.GroupBox grb_primeira_compra;
        private System.Windows.Forms.RadioButton rdb_nao_primeira_compra;
        private System.Windows.Forms.RadioButton rdb_sim_primeira_compra;
        private System.Windows.Forms.Label lbl_valor_compra;
        private System.Windows.Forms.TextBox txt_valor_compra;
        private System.Windows.Forms.GroupBox grb_tipo_fatura;
        private System.Windows.Forms.RadioButton rdb_60_dias;
        private System.Windows.Forms.RadioButton rdb_30_dias;
        private System.Windows.Forms.RadioButton rdb_avista;
        private System.Windows.Forms.GroupBox grb_vendedor;
        private System.Windows.Forms.RadioButton rdb_vend4;
        private System.Windows.Forms.RadioButton rdb_vend3;
        private System.Windows.Forms.RadioButton rdb_vend2;
        private System.Windows.Forms.RadioButton rdb_vend1;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_enunciado;
        private System.Windows.Forms.Button btn_limpar;
    }
}

