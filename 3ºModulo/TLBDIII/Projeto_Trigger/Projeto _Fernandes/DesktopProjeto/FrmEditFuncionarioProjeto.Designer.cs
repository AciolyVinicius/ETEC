namespace DesktopProjeto
{
    partial class FrmEditFuncionarioProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditFuncionarioProjeto));
            this.txtNmHora = new System.Windows.Forms.NumericUpDown();
            this.lblQtdHora = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstFuncionarios2 = new System.Windows.Forms.ListBox();
            this.btnRemoveFuncionarioProjeto = new System.Windows.Forms.Button();
            this.btnAddFuncionarioProjeto = new System.Windows.Forms.Button();
            this.lstFuncionarios1 = new System.Windows.Forms.ListBox();
            this.lblFuncionarioHora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNmHora)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNmHora
            // 
            this.txtNmHora.BackColor = System.Drawing.Color.Azure;
            this.txtNmHora.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNmHora.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtNmHora.Location = new System.Drawing.Point(253, 219);
            this.txtNmHora.Name = "txtNmHora";
            this.txtNmHora.Size = new System.Drawing.Size(151, 22);
            this.txtNmHora.TabIndex = 21;
            // 
            // lblQtdHora
            // 
            this.lblQtdHora.AutoSize = true;
            this.lblQtdHora.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdHora.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblQtdHora.Location = new System.Drawing.Point(12, 202);
            this.lblQtdHora.Name = "lblQtdHora";
            this.lblQtdHora.Size = new System.Drawing.Size(184, 19);
            this.lblQtdHora.TabIndex = 20;
            this.lblQtdHora.Text = "Quantidade de Horas";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnFinalizar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinalizar.Location = new System.Drawing.Point(13, 256);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(391, 46);
            this.btnFinalizar.TabIndex = 19;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(249, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Associados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Funcionarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Associar Funcionario";
            // 
            // lstFuncionarios2
            // 
            this.lstFuncionarios2.BackColor = System.Drawing.Color.Azure;
            this.lstFuncionarios2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFuncionarios2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lstFuncionarios2.FormattingEnabled = true;
            this.lstFuncionarios2.ItemHeight = 16;
            this.lstFuncionarios2.Location = new System.Drawing.Point(253, 80);
            this.lstFuncionarios2.Name = "lstFuncionarios2";
            this.lstFuncionarios2.Size = new System.Drawing.Size(151, 116);
            this.lstFuncionarios2.TabIndex = 15;
            this.lstFuncionarios2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstFuncionarios2_MouseDoubleClick);
            // 
            // btnRemoveFuncionarioProjeto
            // 
            this.btnRemoveFuncionarioProjeto.BackColor = System.Drawing.Color.DarkBlue;
            this.btnRemoveFuncionarioProjeto.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFuncionarioProjeto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveFuncionarioProjeto.Location = new System.Drawing.Point(170, 139);
            this.btnRemoveFuncionarioProjeto.Name = "btnRemoveFuncionarioProjeto";
            this.btnRemoveFuncionarioProjeto.Size = new System.Drawing.Size(75, 30);
            this.btnRemoveFuncionarioProjeto.TabIndex = 14;
            this.btnRemoveFuncionarioProjeto.Text = "<<";
            this.btnRemoveFuncionarioProjeto.UseVisualStyleBackColor = false;
            this.btnRemoveFuncionarioProjeto.Click += new System.EventHandler(this.btnRemoveFuncionarioProjeto_Click);
            // 
            // btnAddFuncionarioProjeto
            // 
            this.btnAddFuncionarioProjeto.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAddFuncionarioProjeto.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFuncionarioProjeto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddFuncionarioProjeto.Location = new System.Drawing.Point(170, 103);
            this.btnAddFuncionarioProjeto.Name = "btnAddFuncionarioProjeto";
            this.btnAddFuncionarioProjeto.Size = new System.Drawing.Size(75, 30);
            this.btnAddFuncionarioProjeto.TabIndex = 13;
            this.btnAddFuncionarioProjeto.Text = ">>";
            this.btnAddFuncionarioProjeto.UseVisualStyleBackColor = false;
            this.btnAddFuncionarioProjeto.Click += new System.EventHandler(this.btnAddFuncionarioProjeto_Click);
            // 
            // lstFuncionarios1
            // 
            this.lstFuncionarios1.BackColor = System.Drawing.Color.Azure;
            this.lstFuncionarios1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFuncionarios1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lstFuncionarios1.FormattingEnabled = true;
            this.lstFuncionarios1.ItemHeight = 16;
            this.lstFuncionarios1.Items.AddRange(new object[] {
            "João",
            "Pedro",
            "Pedro",
            "Maikel",
            "Rafael",
            "Dino",
            "Guilherme",
            "Guedes"});
            this.lstFuncionarios1.Location = new System.Drawing.Point(13, 80);
            this.lstFuncionarios1.Name = "lstFuncionarios1";
            this.lstFuncionarios1.Size = new System.Drawing.Size(151, 116);
            this.lstFuncionarios1.TabIndex = 12;
            // 
            // lblFuncionarioHora
            // 
            this.lblFuncionarioHora.AutoSize = true;
            this.lblFuncionarioHora.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionarioHora.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblFuncionarioHora.Location = new System.Drawing.Point(15, 225);
            this.lblFuncionarioHora.Name = "lblFuncionarioHora";
            this.lblFuncionarioHora.Size = new System.Drawing.Size(52, 16);
            this.lblFuncionarioHora.TabIndex = 22;
            this.lblFuncionarioHora.Text = "label4";
            // 
            // FrmEditFuncionarioProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(415, 319);
            this.Controls.Add(this.lblFuncionarioHora);
            this.Controls.Add(this.txtNmHora);
            this.Controls.Add(this.lblQtdHora);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstFuncionarios2);
            this.Controls.Add(this.btnRemoveFuncionarioProjeto);
            this.Controls.Add(this.btnAddFuncionarioProjeto);
            this.Controls.Add(this.lstFuncionarios1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditFuncionarioProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Associação de Funcionario ao Projeto";
            this.Load += new System.EventHandler(this.FrmEditFuncionarioProjeto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNmHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtNmHora;
        private System.Windows.Forms.Label lblQtdHora;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstFuncionarios2;
        private System.Windows.Forms.Button btnRemoveFuncionarioProjeto;
        private System.Windows.Forms.Button btnAddFuncionarioProjeto;
        private System.Windows.Forms.ListBox lstFuncionarios1;
        private System.Windows.Forms.Label lblFuncionarioHora;
    }
}