namespace DesktopProjeto
{
    partial class FrmAddDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddDepartamento));
            this.btn_finalizar_novo_departamento = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeNovoDepartamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocalizacaoNovoDepartamento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_finalizar_novo_departamento
            // 
            this.btn_finalizar_novo_departamento.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_finalizar_novo_departamento.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar_novo_departamento.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_finalizar_novo_departamento.Location = new System.Drawing.Point(15, 234);
            this.btn_finalizar_novo_departamento.Name = "btn_finalizar_novo_departamento";
            this.btn_finalizar_novo_departamento.Size = new System.Drawing.Size(256, 41);
            this.btn_finalizar_novo_departamento.TabIndex = 17;
            this.btn_finalizar_novo_departamento.Text = "Finalizar";
            this.btn_finalizar_novo_departamento.UseVisualStyleBackColor = false;
            this.btn_finalizar_novo_departamento.Click += new System.EventHandler(this.btn_finalizar_novo_departamento_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Localização";
            // 
            // txtNomeNovoDepartamento
            // 
            this.txtNomeNovoDepartamento.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeNovoDepartamento.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtNomeNovoDepartamento.Location = new System.Drawing.Point(15, 84);
            this.txtNomeNovoDepartamento.Name = "txtNomeNovoDepartamento";
            this.txtNomeNovoDepartamento.Size = new System.Drawing.Size(256, 22);
            this.txtNomeNovoDepartamento.TabIndex = 13;
            this.txtNomeNovoDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeNovoDepartamento_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Novo Departamento";
            // 
            // txtLocalizacaoNovoDepartamento
            // 
            this.txtLocalizacaoNovoDepartamento.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalizacaoNovoDepartamento.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtLocalizacaoNovoDepartamento.Location = new System.Drawing.Point(15, 138);
            this.txtLocalizacaoNovoDepartamento.Name = "txtLocalizacaoNovoDepartamento";
            this.txtLocalizacaoNovoDepartamento.Size = new System.Drawing.Size(256, 22);
            this.txtLocalizacaoNovoDepartamento.TabIndex = 18;
            this.txtLocalizacaoNovoDepartamento.TextChanged += new System.EventHandler(this.txt_localizacao_novo_departamento_TextChanged);
            this.txtLocalizacaoNovoDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocalizacaoNovoDepartamento_KeyPress);
            // 
            // FrmAddDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.txtLocalizacaoNovoDepartamento);
            this.Controls.Add(this.btn_finalizar_novo_departamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeNovoDepartamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 321);
            this.Name = "FrmAddDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Departamento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddDepartamento_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_finalizar_novo_departamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeNovoDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocalizacaoNovoDepartamento;
    }
}