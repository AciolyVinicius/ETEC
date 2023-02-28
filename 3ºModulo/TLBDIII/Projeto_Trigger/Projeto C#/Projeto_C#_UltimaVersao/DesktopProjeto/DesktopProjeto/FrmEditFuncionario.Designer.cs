namespace DesktopProjeto
{
    partial class FrmEditFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditFuncionario));
            this.btnFinalizarEditFuncionario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoFunc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodDepartGerNovoFunc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDepartamentoFuncionario = new System.Windows.Forms.TextBox();
            this.txtSalarioFuncionario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefoneFuncionario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidadeFuncionario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFinalizarEditFuncionario
            // 
            this.btnFinalizarEditFuncionario.BackColor = System.Drawing.Color.DarkBlue;
            this.btnFinalizarEditFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarEditFuncionario.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnFinalizarEditFuncionario.Location = new System.Drawing.Point(16, 558);
            this.btnFinalizarEditFuncionario.Name = "btnFinalizarEditFuncionario";
            this.btnFinalizarEditFuncionario.Size = new System.Drawing.Size(256, 41);
            this.btnFinalizarEditFuncionario.TabIndex = 37;
            this.btnFinalizarEditFuncionario.Text = "Salvar";
            this.btnFinalizarEditFuncionario.UseVisualStyleBackColor = false;
            this.btnFinalizarEditFuncionario.Click += new System.EventHandler(this.btnFinalizarEditFuncionario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Editar Funcionario";
            // 
            // txtCodigoFunc
            // 
            this.txtCodigoFunc.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFunc.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtCodigoFunc.Location = new System.Drawing.Point(15, 182);
            this.txtCodigoFunc.MaxLength = 9;
            this.txtCodigoFunc.Name = "txtCodigoFunc";
            this.txtCodigoFunc.Size = new System.Drawing.Size(256, 22);
            this.txtCodigoFunc.TabIndex = 57;
            this.txtCodigoFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoFunc_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(11, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 19);
            this.label11.TabIndex = 56;
            this.label11.Text = "Código do Funcionário";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkBlue;
            this.label14.Location = new System.Drawing.Point(12, 508);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 19);
            this.label14.TabIndex = 53;
            this.label14.Text = " - não obrigatório";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkBlue;
            this.label13.Location = new System.Drawing.Point(12, 489);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 19);
            this.label13.TabIndex = 54;
            this.label13.Text = "A Ser Gerenciado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(11, 470);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 19);
            this.label12.TabIndex = 55;
            this.label12.Text = "Código do Departamento ";
            // 
            // txtCodDepartGerNovoFunc
            // 
            this.txtCodDepartGerNovoFunc.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodDepartGerNovoFunc.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtCodDepartGerNovoFunc.Location = new System.Drawing.Point(19, 530);
            this.txtCodDepartGerNovoFunc.Name = "txtCodDepartGerNovoFunc";
            this.txtCodDepartGerNovoFunc.Size = new System.Drawing.Size(256, 22);
            this.txtCodDepartGerNovoFunc.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(6, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 19);
            this.label10.TabIndex = 49;
            this.label10.Text = " cadastro inválido)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(7, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 19);
            this.label9.TabIndex = 50;
            this.label9.Text = " inexistente tornarão o ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(7, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = " (Qualquer código duplicado ou";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(12, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "Código do Departamento";
            // 
            // txtDepartamentoFuncionario
            // 
            this.txtDepartamentoFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamentoFuncionario.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtDepartamentoFuncionario.Location = new System.Drawing.Point(18, 445);
            this.txtDepartamentoFuncionario.Name = "txtDepartamentoFuncionario";
            this.txtDepartamentoFuncionario.Size = new System.Drawing.Size(256, 22);
            this.txtDepartamentoFuncionario.TabIndex = 47;
            // 
            // txtSalarioFuncionario
            // 
            this.txtSalarioFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioFuncionario.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtSalarioFuncionario.Location = new System.Drawing.Point(17, 392);
            this.txtSalarioFuncionario.MaxLength = 7;
            this.txtSalarioFuncionario.Name = "txtSalarioFuncionario";
            this.txtSalarioFuncionario.Size = new System.Drawing.Size(256, 22);
            this.txtSalarioFuncionario.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(14, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Salario";
            // 
            // txtTelefoneFuncionario
            // 
            this.txtTelefoneFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneFuncionario.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtTelefoneFuncionario.Location = new System.Drawing.Point(16, 338);
            this.txtTelefoneFuncionario.Name = "txtTelefoneFuncionario";
            this.txtTelefoneFuncionario.Size = new System.Drawing.Size(256, 22);
            this.txtTelefoneFuncionario.TabIndex = 44;
            this.txtTelefoneFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneFuncionario_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(13, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Telefone";
            // 
            // txtCidadeFuncionario
            // 
            this.txtCidadeFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeFuncionario.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtCidadeFuncionario.Location = new System.Drawing.Point(16, 285);
            this.txtCidadeFuncionario.MaxLength = 58;
            this.txtCidadeFuncionario.Name = "txtCidadeFuncionario";
            this.txtCidadeFuncionario.Size = new System.Drawing.Size(256, 22);
            this.txtCidadeFuncionario.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(13, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Endereço";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtNomeFuncionario.Location = new System.Drawing.Point(16, 231);
            this.txtNomeFuncionario.MaxLength = 48;
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(256, 22);
            this.txtNomeFuncionario.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(16, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nome completo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(13, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 19);
            this.label8.TabIndex = 49;
            this.label8.Text = "(Somente o Código do ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkBlue;
            this.label15.Location = new System.Drawing.Point(13, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(233, 19);
            this.label15.TabIndex = 49;
            this.label15.Text = " Funcionário é obrigatório)";
            // 
            // FrmEditFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 611);
            this.Controls.Add(this.txtCodigoFunc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCodDepartGerNovoFunc);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFinalizarEditFuncionario);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 650);
            this.Name = "FrmEditFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFinalizarEditFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoFunc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodDepartGerNovoFunc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDepartamentoFuncionario;
        private System.Windows.Forms.TextBox txtSalarioFuncionario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefoneFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCidadeFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
    }
}