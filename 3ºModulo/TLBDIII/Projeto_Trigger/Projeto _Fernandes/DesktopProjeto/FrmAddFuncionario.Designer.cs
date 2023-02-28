namespace DesktopProjeto
{
    partial class FrmAddFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddFuncionario));
            this.txtCidadeFuncionario = new System.Windows.Forms.TextBox();
            this.btnFinalizarAddFuncionario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefoneFuncionario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalarioFuncionario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDepartamentoFuncionario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkGerente = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtCidadeFuncionario
            // 
            this.txtCidadeFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeFuncionario.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtCidadeFuncionario.Location = new System.Drawing.Point(12, 138);
            this.txtCidadeFuncionario.Name = "txtCidadeFuncionario";
            this.txtCidadeFuncionario.Size = new System.Drawing.Size(256, 22);
            this.txtCidadeFuncionario.TabIndex = 24;
            this.txtCidadeFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCidadeFuncionario_KeyPress);
            // 
            // btnFinalizarAddFuncionario
            // 
            this.btnFinalizarAddFuncionario.BackColor = System.Drawing.Color.DarkBlue;
            this.btnFinalizarAddFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarAddFuncionario.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnFinalizarAddFuncionario.Location = new System.Drawing.Point(11, 391);
            this.btnFinalizarAddFuncionario.Name = "btnFinalizarAddFuncionario";
            this.btnFinalizarAddFuncionario.Size = new System.Drawing.Size(256, 41);
            this.btnFinalizarAddFuncionario.TabIndex = 23;
            this.btnFinalizarAddFuncionario.Text = "Finalizar";
            this.btnFinalizarAddFuncionario.UseVisualStyleBackColor = false;
            this.btnFinalizarAddFuncionario.Click += new System.EventHandler(this.btnFinalizarAddFuncionario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cidade";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtNomeFuncionario.Location = new System.Drawing.Point(12, 84);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(256, 22);
            this.txtNomeFuncionario.TabIndex = 21;
            this.txtNomeFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeFuncionario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Novo Funcionario";
            // 
            // txtTelefoneFuncionario
            // 
            this.txtTelefoneFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneFuncionario.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtTelefoneFuncionario.Location = new System.Drawing.Point(12, 191);
            this.txtTelefoneFuncionario.Name = "txtTelefoneFuncionario";
            this.txtTelefoneFuncionario.Size = new System.Drawing.Size(256, 22);
            this.txtTelefoneFuncionario.TabIndex = 26;
            this.txtTelefoneFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneFuncionario_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(9, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telefone";
            // 
            // txtSalarioFuncionario
            // 
            this.txtSalarioFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioFuncionario.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtSalarioFuncionario.Location = new System.Drawing.Point(13, 245);
            this.txtSalarioFuncionario.Name = "txtSalarioFuncionario";
            this.txtSalarioFuncionario.Size = new System.Drawing.Size(256, 22);
            this.txtSalarioFuncionario.TabIndex = 28;
            this.txtSalarioFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarioFuncionario_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(10, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Salario";
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
            this.cmbDepartamentoFuncionario.Location = new System.Drawing.Point(12, 299);
            this.cmbDepartamentoFuncionario.Name = "cmbDepartamentoFuncionario";
            this.cmbDepartamentoFuncionario.Size = new System.Drawing.Size(255, 24);
            this.cmbDepartamentoFuncionario.TabIndex = 30;
            this.cmbDepartamentoFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDepartamentoFuncionario_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(8, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Departamento";
            // 
            // chkGerente
            // 
            this.chkGerente.AutoSize = true;
            this.chkGerente.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGerente.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkGerente.Location = new System.Drawing.Point(95, 346);
            this.chkGerente.Name = "chkGerente";
            this.chkGerente.Size = new System.Drawing.Size(95, 23);
            this.chkGerente.TabIndex = 32;
            this.chkGerente.Text = "Gerente";
            this.chkGerente.UseVisualStyleBackColor = true;
            // 
            // FrmAddFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 444);
            this.Controls.Add(this.chkGerente);
            this.Controls.Add(this.cmbDepartamentoFuncionario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSalarioFuncionario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefoneFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCidadeFuncionario);
            this.Controls.Add(this.btnFinalizarAddFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 483);
            this.Name = "FrmAddFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Funcionario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddFuncionario_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCidadeFuncionario;
        private System.Windows.Forms.Button btnFinalizarAddFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefoneFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalarioFuncionario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDepartamentoFuncionario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkGerente;
    }
}