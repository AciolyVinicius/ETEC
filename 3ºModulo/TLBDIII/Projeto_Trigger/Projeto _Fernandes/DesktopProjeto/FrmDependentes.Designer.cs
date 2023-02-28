namespace DesktopProjeto
{
    partial class FrmDependentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDependentes));
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDependente = new System.Windows.Forms.Button();
            this.btnEditarDependente = new System.Windows.Forms.Button();
            this.btnRemoverDependente = new System.Windows.Forms.Button();
            this.btnShowDependente = new System.Windows.Forms.Button();
            this.dtg_dependente = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dependente)).BeginInit();
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
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // projetosToolStripMenuItem
            // 
            this.projetosToolStripMenuItem.Name = "projetosToolStripMenuItem";
            this.projetosToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.projetosToolStripMenuItem.Text = "Projetos";
            this.projetosToolStripMenuItem.Click += new System.EventHandler(this.projetosToolStripMenuItem_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.departamentosToolStripMenuItem_Click);
            // 
            // dependentesToolStripMenuItem1
            // 
            this.dependentesToolStripMenuItem1.Name = "dependentesToolStripMenuItem1";
            this.dependentesToolStripMenuItem1.Size = new System.Drawing.Size(183, 24);
            this.dependentesToolStripMenuItem1.Text = "Dependentes";
            this.dependentesToolStripMenuItem1.Click += new System.EventHandler(this.dependentesToolStripMenuItem1_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dependentes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddDependente
            // 
            this.btnAddDependente.AutoSize = true;
            this.btnAddDependente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(58)))));
            this.btnAddDependente.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDependente.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddDependente.Location = new System.Drawing.Point(223, 47);
            this.btnAddDependente.Name = "btnAddDependente";
            this.btnAddDependente.Size = new System.Drawing.Size(113, 29);
            this.btnAddDependente.TabIndex = 4;
            this.btnAddDependente.Text = "Cadastrar";
            this.btnAddDependente.UseVisualStyleBackColor = false;
            this.btnAddDependente.Click += new System.EventHandler(this.btnAddDependente_Click);
            // 
            // btnEditarDependente
            // 
            this.btnEditarDependente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));
            this.btnEditarDependente.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDependente.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEditarDependente.Location = new System.Drawing.Point(497, 47);
            this.btnEditarDependente.Name = "btnEditarDependente";
            this.btnEditarDependente.Size = new System.Drawing.Size(113, 29);
            this.btnEditarDependente.TabIndex = 5;
            this.btnEditarDependente.Text = "Editar";
            this.btnEditarDependente.UseVisualStyleBackColor = false;
            this.btnEditarDependente.Click += new System.EventHandler(this.btnEditarDependente_Click);
            // 
            // btnRemoverDependente
            // 
            this.btnRemoverDependente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));
            this.btnRemoverDependente.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverDependente.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnRemoverDependente.Location = new System.Drawing.Point(640, 47);
            this.btnRemoverDependente.Name = "btnRemoverDependente";
            this.btnRemoverDependente.Size = new System.Drawing.Size(113, 29);
            this.btnRemoverDependente.TabIndex = 6;
            this.btnRemoverDependente.Text = "Remover";
            this.btnRemoverDependente.UseVisualStyleBackColor = false;
            this.btnRemoverDependente.Click += new System.EventHandler(this.btnRemoverDependente_Click);
            // 
            // btnShowDependente
            // 
            this.btnShowDependente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));
            this.btnShowDependente.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDependente.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnShowDependente.Location = new System.Drawing.Point(360, 47);
            this.btnShowDependente.Name = "btnShowDependente";
            this.btnShowDependente.Size = new System.Drawing.Size(113, 29);
            this.btnShowDependente.TabIndex = 7;
            this.btnShowDependente.Text = "Visualizar";
            this.btnShowDependente.UseVisualStyleBackColor = false;
            this.btnShowDependente.Click += new System.EventHandler(this.btnShowDependente_Click);
            // 
            // dtg_dependente
            // 
            this.dtg_dependente.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtg_dependente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_dependente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_dependente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtg_dependente.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_dependente.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_dependente.GridColor = System.Drawing.Color.DarkBlue;
            this.dtg_dependente.Location = new System.Drawing.Point(26, 93);
            this.dtg_dependente.Name = "dtg_dependente";
            this.dtg_dependente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_dependente.Size = new System.Drawing.Size(727, 277);
            this.dtg_dependente.TabIndex = 8;
            this.dtg_dependente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome do Dependente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 350;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tipo de Parentesco";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // FrmDependentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(779, 384);
            this.Controls.Add(this.dtg_dependente);
            this.Controls.Add(this.btnShowDependente);
            this.Controls.Add(this.btnRemoverDependente);
            this.Controls.Add(this.btnEditarDependente);
            this.Controls.Add(this.btnAddDependente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(795, 423);
            this.Name = "FrmDependentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GesProject";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDependentes_FormClosing);
            this.Load += new System.EventHandler(this.FrmDependentes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dependente)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddDependente;
        private System.Windows.Forms.Button btnEditarDependente;
        private System.Windows.Forms.Button btnRemoverDependente;
        private System.Windows.Forms.Button btnShowDependente;
        private System.Windows.Forms.DataGridView dtg_dependente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}