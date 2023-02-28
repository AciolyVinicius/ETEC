namespace DesktopProjeto
{
    partial class FrmAddProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddProjeto));
            this.btnContinuarNovoProjeto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeNovoProjeto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoNovoProjeto = new System.Windows.Forms.TextBox();
            this.txtVerbaNovoProjeto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDepartamentoFuncionario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnContinuarNovoProjeto
            // 
            this.btnContinuarNovoProjeto.BackColor = System.Drawing.Color.DarkBlue;
            this.btnContinuarNovoProjeto.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuarNovoProjeto.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnContinuarNovoProjeto.Location = new System.Drawing.Point(15, 390);
            this.btnContinuarNovoProjeto.Name = "btnContinuarNovoProjeto";
            this.btnContinuarNovoProjeto.Size = new System.Drawing.Size(256, 41);
            this.btnContinuarNovoProjeto.TabIndex = 14;
            this.btnContinuarNovoProjeto.Text = "Continuar";
            this.btnContinuarNovoProjeto.UseVisualStyleBackColor = false;
            this.btnContinuarNovoProjeto.Click += new System.EventHandler(this.btnContinuarNovoProjeto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo";
            // 
            // txtNomeNovoProjeto
            // 
            this.txtNomeNovoProjeto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeNovoProjeto.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtNomeNovoProjeto.Location = new System.Drawing.Point(17, 85);
            this.txtNomeNovoProjeto.Name = "txtNomeNovoProjeto";
            this.txtNomeNovoProjeto.Size = new System.Drawing.Size(256, 22);
            this.txtNomeNovoProjeto.TabIndex = 11;
            this.txtNomeNovoProjeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeNovoProjeto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Novo Projeto";
            // 
            // txtTipoNovoProjeto
            // 
            this.txtTipoNovoProjeto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoNovoProjeto.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtTipoNovoProjeto.Location = new System.Drawing.Point(17, 139);
            this.txtTipoNovoProjeto.Name = "txtTipoNovoProjeto";
            this.txtTipoNovoProjeto.Size = new System.Drawing.Size(256, 22);
            this.txtTipoNovoProjeto.TabIndex = 15;
            this.txtTipoNovoProjeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoNovoProjeto_KeyPress);
            // 
            // txtVerbaNovoProjeto
            // 
            this.txtVerbaNovoProjeto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerbaNovoProjeto.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtVerbaNovoProjeto.Location = new System.Drawing.Point(16, 192);
            this.txtVerbaNovoProjeto.Name = "txtVerbaNovoProjeto";
            this.txtVerbaNovoProjeto.Size = new System.Drawing.Size(256, 22);
            this.txtVerbaNovoProjeto.TabIndex = 17;
            this.txtVerbaNovoProjeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVerbaNovoProjeto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(13, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Verba";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(13, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Departamento";
            // 
            // cmbDepartamentoFuncionario
            // 
            this.cmbDepartamentoFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamentoFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamentoFuncionario.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.cmbDepartamentoFuncionario.FormattingEnabled = true;
            this.cmbDepartamentoFuncionario.Items.AddRange(new object[] {
            "Comercial",
            "Jurídico",
            "Financeiro",
            "Tecnologia da informação",
            "Recursos Humanos",
            "Marketing",
            "Presidência"});
            this.cmbDepartamentoFuncionario.Location = new System.Drawing.Point(16, 247);
            this.cmbDepartamentoFuncionario.Name = "cmbDepartamentoFuncionario";
            this.cmbDepartamentoFuncionario.Size = new System.Drawing.Size(255, 24);
            this.cmbDepartamentoFuncionario.TabIndex = 31;
            this.cmbDepartamentoFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDepartamentoFuncionario_KeyPress);
            // 
            // FrmAddProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 443);
            this.Controls.Add(this.cmbDepartamentoFuncionario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVerbaNovoProjeto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTipoNovoProjeto);
            this.Controls.Add(this.btnContinuarNovoProjeto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeNovoProjeto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 482);
            this.Name = "FrmAddProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Projeto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddProjeto_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinuarNovoProjeto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeNovoProjeto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoNovoProjeto;
        private System.Windows.Forms.TextBox txtVerbaNovoProjeto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDepartamentoFuncionario;
    }
}