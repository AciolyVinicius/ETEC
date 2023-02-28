namespace LISTA2_EXE11_MGVM_VAES
{
    partial class lbl_tanquecarro
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
            this.grp_combustivel = new System.Windows.Forms.GroupBox();
            this.rdb_alcool = new System.Windows.Forms.RadioButton();
            this.rdb_combustivel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_capacidade = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_gasto = new System.Windows.Forms.TextBox();
            this.grp_combustivel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_enunciado
            // 
            this.btn_enunciado.Location = new System.Drawing.Point(191, 14);
            this.btn_enunciado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_enunciado.Name = "btn_enunciado";
            this.btn_enunciado.Size = new System.Drawing.Size(100, 35);
            this.btn_enunciado.TabIndex = 0;
            this.btn_enunciado.Text = "Enunciado";
            this.btn_enunciado.UseVisualStyleBackColor = true;
            this.btn_enunciado.Click += new System.EventHandler(this.btn_enunciado_Click);
            // 
            // grp_combustivel
            // 
            this.grp_combustivel.Controls.Add(this.rdb_alcool);
            this.grp_combustivel.Controls.Add(this.rdb_combustivel);
            this.grp_combustivel.Location = new System.Drawing.Point(12, 14);
            this.grp_combustivel.Name = "grp_combustivel";
            this.grp_combustivel.Size = new System.Drawing.Size(152, 91);
            this.grp_combustivel.TabIndex = 1;
            this.grp_combustivel.TabStop = false;
            this.grp_combustivel.Text = "Tipo de combustível";
            // 
            // rdb_alcool
            // 
            this.rdb_alcool.AutoSize = true;
            this.rdb_alcool.Location = new System.Drawing.Point(6, 55);
            this.rdb_alcool.Name = "rdb_alcool";
            this.rdb_alcool.Size = new System.Drawing.Size(65, 24);
            this.rdb_alcool.TabIndex = 1;
            this.rdb_alcool.TabStop = true;
            this.rdb_alcool.Text = "Álcool";
            this.rdb_alcool.UseVisualStyleBackColor = true;
            // 
            // rdb_combustivel
            // 
            this.rdb_combustivel.AutoSize = true;
            this.rdb_combustivel.Location = new System.Drawing.Point(6, 25);
            this.rdb_combustivel.Name = "rdb_combustivel";
            this.rdb_combustivel.Size = new System.Drawing.Size(101, 24);
            this.rdb_combustivel.TabIndex = 0;
            this.rdb_combustivel.TabStop = true;
            this.rdb_combustivel.Text = "Combustível";
            this.rdb_combustivel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Capacidade de combustível";
            // 
            // txt_capacidade
            // 
            this.txt_capacidade.Location = new System.Drawing.Point(12, 150);
            this.txt_capacidade.MaxLength = 5;
            this.txt_capacidade.Name = "txt_capacidade";
            this.txt_capacidade.Size = new System.Drawing.Size(173, 26);
            this.txt_capacidade.TabIndex = 3;
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(12, 182);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(71, 34);
            this.btn_enter.TabIndex = 4;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gasto para encher o tanque";
            // 
            // txt_gasto
            // 
            this.txt_gasto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_gasto.Enabled = false;
            this.txt_gasto.Location = new System.Drawing.Point(12, 266);
            this.txt_gasto.MaxLength = 5;
            this.txt_gasto.Name = "txt_gasto";
            this.txt_gasto.ReadOnly = true;
            this.txt_gasto.Size = new System.Drawing.Size(173, 26);
            this.txt_gasto.TabIndex = 6;
            // 
            // lbl_tanquecarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 319);
            this.Controls.Add(this.txt_gasto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.txt_capacidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_combustivel);
            this.Controls.Add(this.btn_enunciado);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "lbl_tanquecarro";
            this.Text = "TanqueCarro";
            this.grp_combustivel.ResumeLayout(false);
            this.grp_combustivel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enunciado;
        private System.Windows.Forms.GroupBox grp_combustivel;
        private System.Windows.Forms.RadioButton rdb_alcool;
        private System.Windows.Forms.RadioButton rdb_combustivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_capacidade;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_gasto;
    }
}

