namespace DesktopProjeto
{
    partial class FrmDependenteFuncionario
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
            this.cmbFuncionarioAssociarDependente = new System.Windows.Forms.ComboBox();
            this.btnFinalizarAssociarDependente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbFuncionarioAssociarDependente
            // 
            this.cmbFuncionarioAssociarDependente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionarioAssociarDependente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFuncionarioAssociarDependente.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.cmbFuncionarioAssociarDependente.FormattingEnabled = true;
            this.cmbFuncionarioAssociarDependente.Items.AddRange(new object[] {
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
            this.cmbFuncionarioAssociarDependente.Location = new System.Drawing.Point(17, 78);
            this.cmbFuncionarioAssociarDependente.Name = "cmbFuncionarioAssociarDependente";
            this.cmbFuncionarioAssociarDependente.Size = new System.Drawing.Size(255, 24);
            this.cmbFuncionarioAssociarDependente.TabIndex = 18;
            this.cmbFuncionarioAssociarDependente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFuncionarioAssociarDependente_KeyPress);
            // 
            // btnFinalizarAssociarDependente
            // 
            this.btnFinalizarAssociarDependente.BackColor = System.Drawing.Color.DarkBlue;
            this.btnFinalizarAssociarDependente.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarAssociarDependente.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnFinalizarAssociarDependente.Location = new System.Drawing.Point(16, 117);
            this.btnFinalizarAssociarDependente.Name = "btnFinalizarAssociarDependente";
            this.btnFinalizarAssociarDependente.Size = new System.Drawing.Size(256, 41);
            this.btnFinalizarAssociarDependente.TabIndex = 17;
            this.btnFinalizarAssociarDependente.Text = "Finalizar";
            this.btnFinalizarAssociarDependente.UseVisualStyleBackColor = false;
            this.btnFinalizarAssociarDependente.Click += new System.EventHandler(this.btnFinalizarAssociarDependente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(14, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Funcionario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Associar Dependente";
            // 
            // FrmDependenteFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 178);
            this.ControlBox = false;
            this.Controls.Add(this.cmbFuncionarioAssociarDependente);
            this.Controls.Add(this.btnFinalizarAssociarDependente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 217);
            this.Name = "FrmDependenteFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Associar Dependente ao Funcionario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDependenteFuncionario_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFuncionarioAssociarDependente;
        private System.Windows.Forms.Button btnFinalizarAssociarDependente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}