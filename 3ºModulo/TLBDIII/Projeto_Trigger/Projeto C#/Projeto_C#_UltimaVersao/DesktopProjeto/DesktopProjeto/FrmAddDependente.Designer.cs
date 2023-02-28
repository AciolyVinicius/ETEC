namespace DesktopProjeto
{
    partial class FrmAddDependente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddDependente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeNovoDependente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbParentescoNovoDependente = new System.Windows.Forms.ComboBox();
            this.btn_continuar_novo_dependente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoNovoDependente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoFuncNovoDepen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo Dependente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome completo";
            // 
            // txtNomeNovoDependente
            // 
            this.txtNomeNovoDependente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeNovoDependente.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtNomeNovoDependente.Location = new System.Drawing.Point(16, 136);
            this.txtNomeNovoDependente.MaxLength = 45;
            this.txtNomeNovoDependente.Name = "txtNomeNovoDependente";
            this.txtNomeNovoDependente.Size = new System.Drawing.Size(256, 22);
            this.txtNomeNovoDependente.TabIndex = 2;
            this.txtNomeNovoDependente.TextChanged += new System.EventHandler(this.txt_nome_novo_dependente_TextChanged);
            this.txtNomeNovoDependente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeNovoDependente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(13, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Parentesco";
            // 
            // cmbParentescoNovoDependente
            // 
            this.cmbParentescoNovoDependente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParentescoNovoDependente.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.cmbParentescoNovoDependente.FormattingEnabled = true;
            this.cmbParentescoNovoDependente.Items.AddRange(new object[] {
            "Pai",
            "Mãe",
            "Esposa",
            "Marido",
            "Filho",
            "Filha",
            "Sobrinhos",
            "Avos",
            "Netos",
            "Outro"});
            this.cmbParentescoNovoDependente.Location = new System.Drawing.Point(16, 183);
            this.cmbParentescoNovoDependente.MaxLength = 14;
            this.cmbParentescoNovoDependente.Name = "cmbParentescoNovoDependente";
            this.cmbParentescoNovoDependente.Size = new System.Drawing.Size(255, 24);
            this.cmbParentescoNovoDependente.TabIndex = 4;
            this.cmbParentescoNovoDependente.SelectedIndexChanged += new System.EventHandler(this.cmb_parentesco_novo_dependente_SelectedIndexChanged);
            this.cmbParentescoNovoDependente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbParentescoNovoDependente_KeyPress);
            // 
            // btn_continuar_novo_dependente
            // 
            this.btn_continuar_novo_dependente.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_continuar_novo_dependente.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuar_novo_dependente.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_continuar_novo_dependente.Location = new System.Drawing.Point(17, 308);
            this.btn_continuar_novo_dependente.Name = "btn_continuar_novo_dependente";
            this.btn_continuar_novo_dependente.Size = new System.Drawing.Size(256, 41);
            this.btn_continuar_novo_dependente.TabIndex = 8;
            this.btn_continuar_novo_dependente.Text = "Continuar";
            this.btn_continuar_novo_dependente.UseVisualStyleBackColor = false;
            this.btn_continuar_novo_dependente.Click += new System.EventHandler(this.btn_continuar_novo_dependente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(13, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "o cadastro será invalidado)";
            // 
            // txtCodigoNovoDependente
            // 
            this.txtCodigoNovoDependente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoNovoDependente.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtCodigoNovoDependente.Location = new System.Drawing.Point(16, 89);
            this.txtCodigoNovoDependente.MaxLength = 9;
            this.txtCodigoNovoDependente.Name = "txtCodigoNovoDependente";
            this.txtCodigoNovoDependente.Size = new System.Drawing.Size(256, 22);
            this.txtCodigoNovoDependente.TabIndex = 15;
            this.txtCodigoNovoDependente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoNovoDependente_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Código (Se o código já existir ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(13, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "(Se o código não existir ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(15, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "o cadastro será invalidado)";
            // 
            // txtCodigoFuncNovoDepen
            // 
            this.txtCodigoFuncNovoDepen.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFuncNovoDepen.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtCodigoFuncNovoDepen.Location = new System.Drawing.Point(17, 270);
            this.txtCodigoFuncNovoDepen.MaxLength = 9;
            this.txtCodigoFuncNovoDepen.Name = "txtCodigoFuncNovoDepen";
            this.txtCodigoFuncNovoDepen.Size = new System.Drawing.Size(256, 22);
            this.txtCodigoFuncNovoDepen.TabIndex = 18;
            this.txtCodigoFuncNovoDepen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoFuncNovoDepen_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(13, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Código do Funcionário";
            // 
            // FrmAddDependente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCodigoFuncNovoDepen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigoNovoDependente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_continuar_novo_dependente);
            this.Controls.Add(this.cmbParentescoNovoDependente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeNovoDependente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 400);
            this.Name = "FrmAddDependente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Dependente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddDependente_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeNovoDependente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbParentescoNovoDependente;
        private System.Windows.Forms.Button btn_continuar_novo_dependente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoNovoDependente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoFuncNovoDepen;
        private System.Windows.Forms.Label label6;
    }
}