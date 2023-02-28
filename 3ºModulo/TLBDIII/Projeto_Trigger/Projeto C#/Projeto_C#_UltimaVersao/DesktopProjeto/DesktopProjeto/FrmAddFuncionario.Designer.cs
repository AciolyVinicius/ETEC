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
            this.label6 = new System.Windows.Forms.Label();
            this.txtDepartamentoFuncionario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodDepartGerNovoFunc = new System.Windows.Forms.TextBox();
            this.txtCodigoNovoFunc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCidadeFuncionario
            // 
            this.txtCidadeFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeFuncionario.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtCidadeFuncionario.Location = new System.Drawing.Point(8, 259);
            this.txtCidadeFuncionario.MaxLength = 55;
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
            this.btnFinalizarAddFuncionario.Location = new System.Drawing.Point(11, 558);
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
            this.label3.Location = new System.Drawing.Point(5, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Endereço";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtNomeFuncionario.Location = new System.Drawing.Point(8, 205);
            this.txtNomeFuncionario.MaxLength = 45;
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
            this.label2.Location = new System.Drawing.Point(8, 183);
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
            this.txtTelefoneFuncionario.Location = new System.Drawing.Point(8, 312);
            this.txtTelefoneFuncionario.MaxLength = 8;
            this.txtTelefoneFuncionario.Name = "txtTelefoneFuncionario";
            this.txtTelefoneFuncionario.Size = new System.Drawing.Size(256, 22);
            this.txtTelefoneFuncionario.TabIndex = 26;
            this.txtTelefoneFuncionario.TextChanged += new System.EventHandler(this.txtTelefoneFuncionario_TextChanged);
            this.txtTelefoneFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneFuncionario_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(5, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telefone";
            // 
            // txtSalarioFuncionario
            // 
            this.txtSalarioFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioFuncionario.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtSalarioFuncionario.Location = new System.Drawing.Point(9, 366);
            this.txtSalarioFuncionario.MaxLength = 7;
            this.txtSalarioFuncionario.Name = "txtSalarioFuncionario";
            this.txtSalarioFuncionario.Size = new System.Drawing.Size(256, 22);
            this.txtSalarioFuncionario.TabIndex = 28;
            this.txtSalarioFuncionario.TextChanged += new System.EventHandler(this.txtSalarioFuncionario_TextChanged);
            this.txtSalarioFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarioFuncionario_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(6, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Salario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(4, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Código do Departamento";
            // 
            // txtDepartamentoFuncionario
            // 
            this.txtDepartamentoFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamentoFuncionario.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtDepartamentoFuncionario.Location = new System.Drawing.Point(10, 419);
            this.txtDepartamentoFuncionario.Name = "txtDepartamentoFuncionario";
            this.txtDepartamentoFuncionario.Size = new System.Drawing.Size(256, 22);
            this.txtDepartamentoFuncionario.TabIndex = 28;
            this.txtDepartamentoFuncionario.TextChanged += new System.EventHandler(this.txtSalarioFuncionario_TextChanged);
            this.txtDepartamentoFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepartamentoFuncionario_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(11, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = " cadastro inválido)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(12, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 19);
            this.label9.TabIndex = 31;
            this.label9.Text = " inexistente tornarão o ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(12, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = " (Qualquer código duplicado ou";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkBlue;
            this.label14.Location = new System.Drawing.Point(4, 482);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 19);
            this.label14.TabIndex = 34;
            this.label14.Text = " - não obrigatório";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Location = new System.Drawing.Point(4, 463);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 19);
            this.label13.TabIndex = 35;
            this.label13.Text = "A Ser Gerenciado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(3, 444);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 19);
            this.label12.TabIndex = 36;
            this.label12.Text = "Código do Departamento ";
            // 
            // txtCodDepartGerNovoFunc
            // 
            this.txtCodDepartGerNovoFunc.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodDepartGerNovoFunc.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtCodDepartGerNovoFunc.Location = new System.Drawing.Point(11, 504);
            this.txtCodDepartGerNovoFunc.Name = "txtCodDepartGerNovoFunc";
            this.txtCodDepartGerNovoFunc.Size = new System.Drawing.Size(256, 22);
            this.txtCodDepartGerNovoFunc.TabIndex = 33;
            this.txtCodDepartGerNovoFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodDepartGerNovoFunc_KeyPress);
            // 
            // txtCodigoNovoFunc
            // 
            this.txtCodigoNovoFunc.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoNovoFunc.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtCodigoNovoFunc.Location = new System.Drawing.Point(7, 156);
            this.txtCodigoNovoFunc.MaxLength = 9;
            this.txtCodigoNovoFunc.Name = "txtCodigoNovoFunc";
            this.txtCodigoNovoFunc.Size = new System.Drawing.Size(256, 22);
            this.txtCodigoNovoFunc.TabIndex = 38;
            this.txtCodigoNovoFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoNovoFunc_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(3, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 19);
            this.label11.TabIndex = 37;
            this.label11.Text = "Código do Novo Funcionário";
            // 
            // FrmAddFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 611);
            this.Controls.Add(this.txtCodigoNovoFunc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCodDepartGerNovoFunc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDepartamentoFuncionario);
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
            this.MaximumSize = new System.Drawing.Size(300, 650);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDepartamentoFuncionario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodDepartGerNovoFunc;
        private System.Windows.Forms.TextBox txtCodigoNovoFunc;
        private System.Windows.Forms.Label label11;
    }
}