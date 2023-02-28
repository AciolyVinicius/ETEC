namespace SAGA
{
    partial class frm_cadastro_curso
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
            this.pnl_topo = new System.Windows.Forms.Panel();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.pnl_topo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_topo
            // 
            this.pnl_topo.BackColor = System.Drawing.Color.DarkBlue;
            this.pnl_topo.Controls.Add(this.btn_entrar);
            this.pnl_topo.Location = new System.Drawing.Point(0, 0);
            this.pnl_topo.Name = "pnl_topo";
            this.pnl_topo.Size = new System.Drawing.Size(882, 75);
            this.pnl_topo.TabIndex = 2;
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.White;
            this.btn_entrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.Color.Black;
            this.btn_entrar.Location = new System.Drawing.Point(747, 15);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(124, 52);
            this.btn_entrar.TabIndex = 1;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            // 
            // frm_cadastro_curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 592);
            this.Controls.Add(this.pnl_topo);
            this.Name = "frm_cadastro_curso";
            this.Text = "S.A.G.A. - Cadastro de Cursos";
            this.pnl_topo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_topo;
        private System.Windows.Forms.Button btn_entrar;
    }
}