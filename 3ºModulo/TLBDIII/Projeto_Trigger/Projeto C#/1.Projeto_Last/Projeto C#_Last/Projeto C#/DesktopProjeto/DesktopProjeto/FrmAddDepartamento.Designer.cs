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
            this.btnNovoDepart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNovoNomeDepartamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNovoLocalizacaoDepartamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNovoCodigoDepartamento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNovoDepart
            // 
            this.btnNovoDepart.BackColor = System.Drawing.Color.DarkBlue;
            this.btnNovoDepart.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoDepart.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnNovoDepart.Location = new System.Drawing.Point(15, 234);
            this.btnNovoDepart.Name = "btnNovoDepart";
            this.btnNovoDepart.Size = new System.Drawing.Size(256, 41);
            this.btnNovoDepart.TabIndex = 17;
            this.btnNovoDepart.Text = "Finalizar";
            this.btnNovoDepart.UseVisualStyleBackColor = false;
            this.btnNovoDepart.Click += new System.EventHandler(this.btnNovoDepart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(11, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Localização";
            // 
            // txtNovoNomeDepartamento
            // 
            this.txtNovoNomeDepartamento.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoNomeDepartamento.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtNovoNomeDepartamento.Location = new System.Drawing.Point(15, 137);
            this.txtNovoNomeDepartamento.Name = "txtNovoNomeDepartamento";
            this.txtNovoNomeDepartamento.Size = new System.Drawing.Size(256, 22);
            this.txtNovoNomeDepartamento.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(11, 115);
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
            // txtNovoLocalizacaoDepartamento
            // 
            this.txtNovoLocalizacaoDepartamento.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoLocalizacaoDepartamento.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtNovoLocalizacaoDepartamento.Location = new System.Drawing.Point(15, 184);
            this.txtNovoLocalizacaoDepartamento.Name = "txtNovoLocalizacaoDepartamento";
            this.txtNovoLocalizacaoDepartamento.Size = new System.Drawing.Size(256, 22);
            this.txtNovoLocalizacaoDepartamento.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Código (Se o código já existir ";
            // 
            // txtNovoCodigoDepartamento
            // 
            this.txtNovoCodigoDepartamento.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoCodigoDepartamento.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtNovoCodigoDepartamento.Location = new System.Drawing.Point(16, 90);
            this.txtNovoCodigoDepartamento.MaxLength = 10;
            this.txtNovoCodigoDepartamento.Name = "txtNovoCodigoDepartamento";
            this.txtNovoCodigoDepartamento.Size = new System.Drawing.Size(256, 22);
            this.txtNovoCodigoDepartamento.TabIndex = 13;
            this.txtNovoCodigoDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNovoCodigoDepartamento_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "o cadastro será invalidado)";
            // 
            // FrmAddDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.txtNovoLocalizacaoDepartamento);
            this.Controls.Add(this.btnNovoDepart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNovoCodigoDepartamento);
            this.Controls.Add(this.txtNovoNomeDepartamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Departamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNovoDepart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNovoNomeDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNovoLocalizacaoDepartamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNovoCodigoDepartamento;
        private System.Windows.Forms.Label label5;
    }
}