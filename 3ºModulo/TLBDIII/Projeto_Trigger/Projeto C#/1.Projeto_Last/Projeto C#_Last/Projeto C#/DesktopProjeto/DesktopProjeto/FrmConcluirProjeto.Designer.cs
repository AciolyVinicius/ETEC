namespace DesktopProjeto
{
    partial class FrmConcluirProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConcluirProjeto));
            this.btnConcluirProjeto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoProjeto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConcluirProjeto
            // 
            this.btnConcluirProjeto.BackColor = System.Drawing.Color.DarkBlue;
            this.btnConcluirProjeto.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirProjeto.ForeColor = System.Drawing.Color.White;
            this.btnConcluirProjeto.Location = new System.Drawing.Point(12, 151);
            this.btnConcluirProjeto.Name = "btnConcluirProjeto";
            this.btnConcluirProjeto.Size = new System.Drawing.Size(260, 51);
            this.btnConcluirProjeto.TabIndex = 4;
            this.btnConcluirProjeto.Text = "Concluir";
            this.btnConcluirProjeto.UseVisualStyleBackColor = false;
            this.btnConcluirProjeto.Click += new System.EventHandler(this.btnConcluirProjeto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Concluir Projeto";
            // 
            // txtCodigoProjeto
            // 
            this.txtCodigoProjeto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProjeto.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtCodigoProjeto.Location = new System.Drawing.Point(16, 85);
            this.txtCodigoProjeto.Name = "txtCodigoProjeto";
            this.txtCodigoProjeto.Size = new System.Drawing.Size(256, 22);
            this.txtCodigoProjeto.TabIndex = 21;
            this.txtCodigoProjeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoNovoProjeto_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(12, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Código do Projeto Existente";
            // 
            // FrmConcluirProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.txtCodigoProjeto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConcluirProjeto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConcluirProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concluir Projeto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConcluirProjeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoProjeto;
        private System.Windows.Forms.Label label6;
    }
}