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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddFuncionarioProjeto));
            this.btnAddFuncionarioProjeto = new System.Windows.Forms.Button();
            this.btnRemoveFuncionarioProjeto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FrmFinalizarAssociarFuncionario = new System.Windows.Forms.Button();
            this.txtNmHora = new System.Windows.Forms.NumericUpDown();
            this.lblQtdHora = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.dtg_associado = new System.Windows.Forms.DataGridView();
            this.dtg_nao_associado = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNmHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_associado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nao_associado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddFuncionarioProjeto
            // 
            this.btnAddFuncionarioProjeto.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAddFuncionarioProjeto.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFuncionarioProjeto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddFuncionarioProjeto.Location = new System.Drawing.Point(169, 108);
            this.btnAddFuncionarioProjeto.Name = "btnAddFuncionarioProjeto";
            this.btnAddFuncionarioProjeto.Size = new System.Drawing.Size(75, 30);
            this.btnAddFuncionarioProjeto.TabIndex = 1;
            this.btnAddFuncionarioProjeto.Text = ">>";
            this.btnAddFuncionarioProjeto.UseVisualStyleBackColor = false;
            this.btnAddFuncionarioProjeto.Visible = false;
            this.btnAddFuncionarioProjeto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveFuncionarioProjeto
            // 
            this.btnRemoveFuncionarioProjeto.BackColor = System.Drawing.Color.DarkBlue;
            this.btnRemoveFuncionarioProjeto.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFuncionarioProjeto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveFuncionarioProjeto.Location = new System.Drawing.Point(169, 144);
            this.btnRemoveFuncionarioProjeto.Name = "btnRemoveFuncionarioProjeto";
            this.btnRemoveFuncionarioProjeto.Size = new System.Drawing.Size(75, 30);
            this.btnRemoveFuncionarioProjeto.TabIndex = 2;
            this.btnRemoveFuncionarioProjeto.Text = "<<";
            this.btnRemoveFuncionarioProjeto.UseVisualStyleBackColor = false;
            this.btnRemoveFuncionarioProjeto.Visible = false;
            this.btnRemoveFuncionarioProjeto.Click += new System.EventHandler(this.btnRemoveFuncionarioProjeto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Associar/Desassociar Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Não Associado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(248, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Associado";
            // 
            // FrmFinalizarAssociarFuncionario
            // 
            this.FrmFinalizarAssociarFuncionario.BackColor = System.Drawing.Color.DarkBlue;
            this.FrmFinalizarAssociarFuncionario.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmFinalizarAssociarFuncionario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FrmFinalizarAssociarFuncionario.Location = new System.Drawing.Point(12, 261);
            this.FrmFinalizarAssociarFuncionario.Name = "FrmFinalizarAssociarFuncionario";
            this.FrmFinalizarAssociarFuncionario.Size = new System.Drawing.Size(273, 46);
            this.FrmFinalizarAssociarFuncionario.TabIndex = 7;
            this.FrmFinalizarAssociarFuncionario.Text = "Finalizar";
            this.FrmFinalizarAssociarFuncionario.UseVisualStyleBackColor = false;
            this.FrmFinalizarAssociarFuncionario.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtNmHora
            // 
            this.txtNmHora.BackColor = System.Drawing.Color.Azure;
            this.txtNmHora.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNmHora.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtNmHora.Location = new System.Drawing.Point(252, 226);
            this.txtNmHora.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txtNmHora.Name = "txtNmHora";
            this.txtNmHora.Size = new System.Drawing.Size(151, 22);
            this.txtNmHora.TabIndex = 11;
            this.txtNmHora.Visible = false;
            this.txtNmHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNmHora_KeyPress);
            // 
            // lblQtdHora
            // 
            this.lblQtdHora.AutoSize = true;
            this.lblQtdHora.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdHora.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblQtdHora.Location = new System.Drawing.Point(219, 204);
            this.lblQtdHora.Name = "lblQtdHora";
            this.lblQtdHora.Size = new System.Drawing.Size(184, 19);
            this.lblQtdHora.TabIndex = 10;
            this.lblQtdHora.Text = "Quantidade de Horas";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txtCod.Location = new System.Drawing.Point(183, 38);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(167, 22);
            this.txtCod.TabIndex = 37;
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(15, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Código do Projeto";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.DarkBlue;
            this.btnOk.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOk.Location = new System.Drawing.Point(356, 33);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(47, 30);
            this.btnOk.TabIndex = 38;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // dtg_associado
            // 
            this.dtg_associado.AllowUserToAddRows = false;
            this.dtg_associado.AllowUserToDeleteRows = false;
            this.dtg_associado.AllowUserToOrderColumns = true;
            this.dtg_associado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_associado.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtg_associado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_associado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_associado.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_associado.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_associado.GridColor = System.Drawing.Color.DarkBlue;
            this.dtg_associado.Location = new System.Drawing.Point(252, 85);
            this.dtg_associado.MultiSelect = false;
            this.dtg_associado.Name = "dtg_associado";
            this.dtg_associado.ReadOnly = true;
            this.dtg_associado.RowHeadersVisible = false;
            this.dtg_associado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_associado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_associado.Size = new System.Drawing.Size(151, 116);
            this.dtg_associado.TabIndex = 39;
            // 
            // dtg_nao_associado
            // 
            this.dtg_nao_associado.AllowUserToAddRows = false;
            this.dtg_nao_associado.AllowUserToDeleteRows = false;
            this.dtg_nao_associado.AllowUserToOrderColumns = true;
            this.dtg_nao_associado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_nao_associado.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtg_nao_associado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_nao_associado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_nao_associado.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_nao_associado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_nao_associado.GridColor = System.Drawing.Color.DarkBlue;
            this.dtg_nao_associado.Location = new System.Drawing.Point(12, 85);
            this.dtg_nao_associado.MultiSelect = false;
            this.dtg_nao_associado.Name = "dtg_nao_associado";
            this.dtg_nao_associado.ReadOnly = true;
            this.dtg_nao_associado.RowHeadersVisible = false;
            this.dtg_nao_associado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_nao_associado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_nao_associado.Size = new System.Drawing.Size(151, 116);
            this.dtg_nao_associado.TabIndex = 40;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkBlue;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(291, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 46);
            this.button2.TabIndex = 41;
            this.button2.Text = "Mudar Projeto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmAddFuncionarioProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(415, 319);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtg_nao_associado);
            this.Controls.Add(this.dtg_associado);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNmHora);
            this.Controls.Add(this.lblQtdHora);
            this.Controls.Add(this.FrmFinalizarAssociarFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveFuncionarioProjeto);
            this.Controls.Add(this.btnAddFuncionarioProjeto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(431, 358);
            this.Name = "FrmAddFuncionarioProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Associar Funcionario ao Projeto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddFuncionarioProjeto_FormClosing);
            this.Load += new System.EventHandler(this.FrmFuncionarioProjeto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNmHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_associado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nao_associado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddFuncionarioProjeto;
        private System.Windows.Forms.Button btnRemoveFuncionarioProjeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FrmFinalizarAssociarFuncionario;
        private System.Windows.Forms.NumericUpDown txtNmHora;
        private System.Windows.Forms.Label lblQtdHora;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dtg_associado;
        private System.Windows.Forms.DataGridView dtg_nao_associado;
        private System.Windows.Forms.Button button2;
    }
}