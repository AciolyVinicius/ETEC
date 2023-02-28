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
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome completo";
            // 
            // txtNomeNovoDependente
            // 
            this.txtNomeNovoDependente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeNovoDependente.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtNomeNovoDependente.Location = new System.Drawing.Point(16, 85);
            this.txtNomeNovoDependente.Name = "txtNomeNovoDependente";
            this.txtNomeNovoDependente.Size = new System.Drawing.Size(256, 22);
            this.txtNomeNovoDependente.TabIndex = 2;
            this.txtNomeNovoDependente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeNovoDependente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Parentesco";
            // 
            // cmbParentescoNovoDependente
            // 
            this.cmbParentescoNovoDependente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbParentescoNovoDependente.Location = new System.Drawing.Point(17, 140);
            this.cmbParentescoNovoDependente.Name = "cmbParentescoNovoDependente";
            this.cmbParentescoNovoDependente.Size = new System.Drawing.Size(255, 24);
            this.cmbParentescoNovoDependente.TabIndex = 4;
            this.cmbParentescoNovoDependente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbParentescoNovoDependente_KeyPress);
            // 
            // btn_continuar_novo_dependente
            // 
            this.btn_continuar_novo_dependente.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_continuar_novo_dependente.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuar_novo_dependente.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_continuar_novo_dependente.Location = new System.Drawing.Point(16, 235);
            this.btn_continuar_novo_dependente.Name = "btn_continuar_novo_dependente";
            this.btn_continuar_novo_dependente.Size = new System.Drawing.Size(256, 41);
            this.btn_continuar_novo_dependente.TabIndex = 8;
            this.btn_continuar_novo_dependente.Text = "Continuar";
            this.btn_continuar_novo_dependente.UseVisualStyleBackColor = false;
            this.btn_continuar_novo_dependente.Click += new System.EventHandler(this.btn_continuar_novo_dependente_Click);
            // 
            // FrmAddDependente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 292);
            this.Controls.Add(this.btn_continuar_novo_dependente);
            this.Controls.Add(this.cmbParentescoNovoDependente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeNovoDependente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 331);
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
    }
}