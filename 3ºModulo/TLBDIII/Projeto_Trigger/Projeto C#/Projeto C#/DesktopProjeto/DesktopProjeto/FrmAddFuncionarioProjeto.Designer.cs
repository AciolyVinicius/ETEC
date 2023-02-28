namespace DesktopProjeto
{
    partial class FrmAddFuncionarioProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddFuncionarioProjeto));
            this.lstFuncionarios1 = new System.Windows.Forms.ListBox();
            this.btnAddFuncionarioProjeto = new System.Windows.Forms.Button();
            this.btnRemoveFuncionarioProjeto = new System.Windows.Forms.Button();
            this.lstFuncionarios2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblQtdHora = new System.Windows.Forms.Label();
            this.txtNmHora = new System.Windows.Forms.NumericUpDown();
            this.lblFuncionarioHora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNmHora)).BeginInit();
            this.SuspendLayout();
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
            this.lstFuncionarios1.Location = new System.Drawing.Point(12, 76);
            this.lstFuncionarios1.Name = "lstFuncionarios1";
            this.lstFuncionarios1.Size = new System.Drawing.Size(151, 116);
            this.lstFuncionarios1.TabIndex = 0;
            // 
            // btnAddFuncionarioProjeto
            // 
            this.btnAddFuncionarioProjeto.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAddFuncionarioProjeto.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFuncionarioProjeto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddFuncionarioProjeto.Location = new System.Drawing.Point(169, 99);
            this.btnAddFuncionarioProjeto.Name = "btnAddFuncionarioProjeto";
            this.btnAddFuncionarioProjeto.Size = new System.Drawing.Size(75, 30);
            this.btnAddFuncionarioProjeto.TabIndex = 1;
            this.btnAddFuncionarioProjeto.Text = ">>";
            this.btnAddFuncionarioProjeto.UseVisualStyleBackColor = false;
            this.btnAddFuncionarioProjeto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveFuncionarioProjeto
            // 
            this.btnRemoveFuncionarioProjeto.BackColor = System.Drawing.Color.DarkBlue;
            this.btnRemoveFuncionarioProjeto.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFuncionarioProjeto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveFuncionarioProjeto.Location = new System.Drawing.Point(169, 135);
            this.btnRemoveFuncionarioProjeto.Name = "btnRemoveFuncionarioProjeto";
            this.btnRemoveFuncionarioProjeto.Size = new System.Drawing.Size(75, 30);
            this.btnRemoveFuncionarioProjeto.TabIndex = 2;
            this.btnRemoveFuncionarioProjeto.Text = "<<";
            this.btnRemoveFuncionarioProjeto.UseVisualStyleBackColor = false;
            this.btnRemoveFuncionarioProjeto.Click += new System.EventHandler(this.btnRemoveFuncionarioProjeto_Click);
            // 
            // lstFuncionarios2
            // 
            this.lstFuncionarios2.BackColor = System.Drawing.Color.Azure;
            this.lstFuncionarios2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFuncionarios2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lstFuncionarios2.FormattingEnabled = true;
            this.lstFuncionarios2.ItemHeight = 16;
            this.lstFuncionarios2.Location = new System.Drawing.Point(252, 76);
            this.lstFuncionarios2.Name = "lstFuncionarios2";
            this.lstFuncionarios2.Size = new System.Drawing.Size(151, 116);
            this.lstFuncionarios2.TabIndex = 3;
            this.lstFuncionarios2.DoubleClick += new System.EventHandler(this.lstFuncionarios2_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Associar Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Funcionarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(248, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Associados";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(391, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblQtdHora
            // 
            this.lblQtdHora.AutoSize = true;
            this.lblQtdHora.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdHora.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblQtdHora.Location = new System.Drawing.Point(12, 200);
            this.lblQtdHora.Name = "lblQtdHora";
            this.lblQtdHora.Size = new System.Drawing.Size(184, 19);
            this.lblQtdHora.TabIndex = 10;
            this.lblQtdHora.Text = "Quantidade de Horas";
            // 
            // txtNmHora
            // 
            this.txtNmHora.BackColor = System.Drawing.Color.Azure;
            this.txtNmHora.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNmHora.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtNmHora.Location = new System.Drawing.Point(252, 217);
            this.txtNmHora.Name = "txtNmHora";
            this.txtNmHora.Size = new System.Drawing.Size(151, 22);
            this.txtNmHora.TabIndex = 11;
            // 
            // lblFuncionarioHora
            // 
            this.lblFuncionarioHora.AutoSize = true;
            this.lblFuncionarioHora.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionarioHora.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblFuncionarioHora.Location = new System.Drawing.Point(16, 223);
            this.lblFuncionarioHora.Name = "lblFuncionarioHora";
            this.lblFuncionarioHora.Size = new System.Drawing.Size(52, 16);
            this.lblFuncionarioHora.TabIndex = 12;
            this.lblFuncionarioHora.Text = "label4";
            // 
            // FrmAddFuncionarioProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(415, 319);
            this.Controls.Add(this.lblFuncionarioHora);
            this.Controls.Add(this.txtNmHora);
            this.Controls.Add(this.lblQtdHora);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstFuncionarios2);
            this.Controls.Add(this.btnRemoveFuncionarioProjeto);
            this.Controls.Add(this.btnAddFuncionarioProjeto);
            this.Controls.Add(this.lstFuncionarios1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddFuncionarioProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Associar Funcionario ao Projeto";
            this.Load += new System.EventHandler(this.FrmFuncionarioProjeto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNmHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFuncionarios1;
        private System.Windows.Forms.Button btnAddFuncionarioProjeto;
        private System.Windows.Forms.Button btnRemoveFuncionarioProjeto;
        private System.Windows.Forms.ListBox lstFuncionarios2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblQtdHora;
        private System.Windows.Forms.NumericUpDown txtNmHora;
        private System.Windows.Forms.Label lblFuncionarioHora;
    }
}