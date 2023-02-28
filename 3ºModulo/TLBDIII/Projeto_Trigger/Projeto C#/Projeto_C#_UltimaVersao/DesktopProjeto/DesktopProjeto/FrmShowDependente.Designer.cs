namespace DesktopProjeto
{
    partial class FrmShowDependente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowDependente));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeDependente = new System.Windows.Forms.Label();
            this.lblParentescoDependente = new System.Windows.Forms.Label();
            this.lblFuncionarioDependente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(14, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Funcionario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(14, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Parentesco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dependente";
            // 
            // lblNomeDependente
            // 
            this.lblNomeDependente.AutoSize = true;
            this.lblNomeDependente.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDependente.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblNomeDependente.Location = new System.Drawing.Point(14, 85);
            this.lblNomeDependente.Name = "lblNomeDependente";
            this.lblNomeDependente.Size = new System.Drawing.Size(150, 19);
            this.lblNomeDependente.TabIndex = 17;
            this.lblNomeDependente.Text = "João Silva Junior";
            // 
            // lblParentescoDependente
            // 
            this.lblParentescoDependente.AutoSize = true;
            this.lblParentescoDependente.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentescoDependente.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblParentescoDependente.Location = new System.Drawing.Point(14, 139);
            this.lblParentescoDependente.Name = "lblParentescoDependente";
            this.lblParentescoDependente.Size = new System.Drawing.Size(48, 19);
            this.lblParentescoDependente.TabIndex = 18;
            this.lblParentescoDependente.Text = "Filho";
            // 
            // lblFuncionarioDependente
            // 
            this.lblFuncionarioDependente.AutoSize = true;
            this.lblFuncionarioDependente.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionarioDependente.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblFuncionarioDependente.Location = new System.Drawing.Point(14, 197);
            this.lblFuncionarioDependente.Name = "lblFuncionarioDependente";
            this.lblFuncionarioDependente.Size = new System.Drawing.Size(181, 19);
            this.lblFuncionarioDependente.TabIndex = 19;
            this.lblFuncionarioDependente.Text = "Dependente do João";
            // 
            // FrmShowDependente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.lblFuncionarioDependente);
            this.Controls.Add(this.lblParentescoDependente);
            this.Controls.Add(this.lblNomeDependente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmShowDependente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dependente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeDependente;
        private System.Windows.Forms.Label lblParentescoDependente;
        private System.Windows.Forms.Label lblFuncionarioDependente;
    }
}