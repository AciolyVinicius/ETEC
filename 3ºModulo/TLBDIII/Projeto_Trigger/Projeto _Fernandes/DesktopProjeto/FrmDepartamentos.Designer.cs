namespace DesktopProjeto
{
    partial class FrmDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartamentos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dependentesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtg_departamento = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowDepartamento = new System.Windows.Forms.Button();
            this.btnRemoverDeparmento = new System.Windows.Forms.Button();
            this.btnEditarDepartamento = new System.Windows.Forms.Button();
            this.btnAddDepartamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_departamento)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.gerenciamentoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.principalToolStripMenuItem.Text = "Principal";
            this.principalToolStripMenuItem.Click += new System.EventHandler(this.principalToolStripMenuItem_Click);
            // 
            // gerenciamentoToolStripMenuItem
            // 
            this.gerenciamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem,
            this.projetosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.dependentesToolStripMenuItem1});
            this.gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
            this.gerenciamentoToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.gerenciamentoToolStripMenuItem.Text = "Gerenciamento";
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click_1);
            // 
            // projetosToolStripMenuItem
            // 
            this.projetosToolStripMenuItem.Name = "projetosToolStripMenuItem";
            this.projetosToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.projetosToolStripMenuItem.Text = "Projetos";
            this.projetosToolStripMenuItem.Click += new System.EventHandler(this.projetosToolStripMenuItem_Click_1);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.departamentosToolStripMenuItem_Click_1);
            // 
            // dependentesToolStripMenuItem1
            // 
            this.dependentesToolStripMenuItem1.Name = "dependentesToolStripMenuItem1";
            this.dependentesToolStripMenuItem1.Size = new System.Drawing.Size(183, 24);
            this.dependentesToolStripMenuItem1.Text = "Dependentes";
            this.dependentesToolStripMenuItem1.Click += new System.EventHandler(this.dependentesToolStripMenuItem1_Click_1);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // dtg_departamento
            // 
            this.dtg_departamento.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtg_departamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_departamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_departamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtg_departamento.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_departamento.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_departamento.GridColor = System.Drawing.Color.DarkBlue;
            this.dtg_departamento.Location = new System.Drawing.Point(26, 90);
            this.dtg_departamento.Name = "dtg_departamento";
            this.dtg_departamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_departamento.Size = new System.Drawing.Size(727, 277);
            this.dtg_departamento.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 350;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Localização";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // btnShowDepartamento
            // 
            this.btnShowDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));
            this.btnShowDepartamento.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDepartamento.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnShowDepartamento.Location = new System.Drawing.Point(370, 44);
            this.btnShowDepartamento.Name = "btnShowDepartamento";
            this.btnShowDepartamento.Size = new System.Drawing.Size(113, 29);
            this.btnShowDepartamento.TabIndex = 13;
            this.btnShowDepartamento.Text = "Visualizar";
            this.btnShowDepartamento.UseVisualStyleBackColor = false;
            this.btnShowDepartamento.Click += new System.EventHandler(this.btnShowDepartamento_Click);
            // 
            // btnRemoverDeparmento
            // 
            this.btnRemoverDeparmento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));
            this.btnRemoverDeparmento.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverDeparmento.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnRemoverDeparmento.Location = new System.Drawing.Point(640, 44);
            this.btnRemoverDeparmento.Name = "btnRemoverDeparmento";
            this.btnRemoverDeparmento.Size = new System.Drawing.Size(113, 29);
            this.btnRemoverDeparmento.TabIndex = 12;
            this.btnRemoverDeparmento.Text = "Remover";
            this.btnRemoverDeparmento.UseVisualStyleBackColor = false;
            this.btnRemoverDeparmento.Click += new System.EventHandler(this.btnRemoverDeparmento_Click);
            // 
            // btnEditarDepartamento
            // 
            this.btnEditarDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));
            this.btnEditarDepartamento.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDepartamento.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEditarDepartamento.Location = new System.Drawing.Point(505, 44);
            this.btnEditarDepartamento.Name = "btnEditarDepartamento";
            this.btnEditarDepartamento.Size = new System.Drawing.Size(113, 29);
            this.btnEditarDepartamento.TabIndex = 11;
            this.btnEditarDepartamento.Text = "Editar";
            this.btnEditarDepartamento.UseVisualStyleBackColor = false;
            this.btnEditarDepartamento.Click += new System.EventHandler(this.btnEditarDepartamento_Click);
            // 
            // btnAddDepartamento
            // 
            this.btnAddDepartamento.AutoSize = true;
            this.btnAddDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(58)))));
            this.btnAddDepartamento.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartamento.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddDepartamento.Location = new System.Drawing.Point(237, 44);
            this.btnAddDepartamento.Name = "btnAddDepartamento";
            this.btnAddDepartamento.Size = new System.Drawing.Size(113, 29);
            this.btnAddDepartamento.TabIndex = 10;
            this.btnAddDepartamento.Text = "Cadastrar";
            this.btnAddDepartamento.UseVisualStyleBackColor = false;
            this.btnAddDepartamento.Click += new System.EventHandler(this.btnAddDepartamento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Departamentos";
            // 
            // FrmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(779, 384);
            this.Controls.Add(this.dtg_departamento);
            this.Controls.Add(this.btnShowDepartamento);
            this.Controls.Add(this.btnRemoverDeparmento);
            this.Controls.Add(this.btnEditarDepartamento);
            this.Controls.Add(this.btnAddDepartamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(795, 423);
            this.Name = "FrmDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GesProject";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDepartamentos_FormClosing);
            this.Load += new System.EventHandler(this.FrmDepartamentos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_departamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dependentesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtg_departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnShowDepartamento;
        private System.Windows.Forms.Button btnRemoverDeparmento;
        private System.Windows.Forms.Button btnEditarDepartamento;
        private System.Windows.Forms.Button btnAddDepartamento;
        private System.Windows.Forms.Label label1;
    }
}