namespace VendasRoupa
{
    partial class Venda
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçãoDaLojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediçãoDosProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasRoupaDataSet = new VendasRoupa.VendasRoupaDataSet();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new VendasRoupa.VendasRoupaDataSetTableAdapters.ProdutoTableAdapter();
            this.tableAdapterManager = new VendasRoupa.VendasRoupaDataSetTableAdapters.TableAdapterManager();
            this.produtoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_vender = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_qt = new System.Windows.Forms.TextBox();
            this.txt_nm_comprador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cd = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasRoupaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(458, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaçãoDaLojaToolStripMenuItem,
            this.visualizaçãoToolStripMenuItem,
            this.ediçãoDosProdutosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // informaçãoDaLojaToolStripMenuItem
            // 
            this.informaçãoDaLojaToolStripMenuItem.Name = "informaçãoDaLojaToolStripMenuItem";
            this.informaçãoDaLojaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.informaçãoDaLojaToolStripMenuItem.Text = "Informação da Loja";
            this.informaçãoDaLojaToolStripMenuItem.Click += new System.EventHandler(this.informaçãoDaLojaToolStripMenuItem_Click);
            // 
            // visualizaçãoToolStripMenuItem
            // 
            this.visualizaçãoToolStripMenuItem.Name = "visualizaçãoToolStripMenuItem";
            this.visualizaçãoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.visualizaçãoToolStripMenuItem.Text = "Visualização";
            this.visualizaçãoToolStripMenuItem.Click += new System.EventHandler(this.visualizaçãoToolStripMenuItem_Click);
            // 
            // ediçãoDosProdutosToolStripMenuItem
            // 
            this.ediçãoDosProdutosToolStripMenuItem.Name = "ediçãoDosProdutosToolStripMenuItem";
            this.ediçãoDosProdutosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ediçãoDosProdutosToolStripMenuItem.Text = "Edição dos Produtos";
            this.ediçãoDosProdutosToolStripMenuItem.Click += new System.EventHandler(this.ediçãoDosProdutosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // vendasRoupaDataSet
            // 
            this.vendasRoupaDataSet.DataSetName = "VendasRoupaDataSet";
            this.vendasRoupaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.vendasRoupaDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProdutoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = VendasRoupa.VendasRoupaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produtoDataGridView
            // 
            this.produtoDataGridView.AutoGenerateColumns = false;
            this.produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.produtoDataGridView.DataSource = this.produtoBindingSource;
            this.produtoDataGridView.Location = new System.Drawing.Point(12, 47);
            this.produtoDataGridView.Name = "produtoDataGridView";
            this.produtoDataGridView.Size = new System.Drawing.Size(444, 220);
            this.produtoDataGridView.TabIndex = 2;
            this.produtoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produtoDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Código";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn2.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha o produto:";
            // 
            // btn_vender
            // 
            this.btn_vender.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vender.Location = new System.Drawing.Point(12, 411);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(109, 37);
            this.btn_vender.TabIndex = 4;
            this.btn_vender.Text = "Vender";
            this.btn_vender.UseVisualStyleBackColor = true;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome do Comprador";
            // 
            // txt_qt
            // 
            this.txt_qt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qt.Location = new System.Drawing.Point(188, 327);
            this.txt_qt.Name = "txt_qt";
            this.txt_qt.Size = new System.Drawing.Size(167, 26);
            this.txt_qt.TabIndex = 7;
            this.txt_qt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qt_KeyPress);
            // 
            // txt_nm_comprador
            // 
            this.txt_nm_comprador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nm_comprador.Location = new System.Drawing.Point(188, 364);
            this.txt_nm_comprador.Name = "txt_nm_comprador";
            this.txt_nm_comprador.Size = new System.Drawing.Size(167, 26);
            this.txt_nm_comprador.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Código do Produto";
            // 
            // txt_cd
            // 
            this.txt_cd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cd.Location = new System.Drawing.Point(188, 290);
            this.txt_cd.Name = "txt_cd";
            this.txt_cd.Size = new System.Drawing.Size(167, 26);
            this.txt_cd.TabIndex = 7;
            this.txt_cd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cd_KeyPress);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 457);
            this.Controls.Add(this.txt_nm_comprador);
            this.Controls.Add(this.txt_cd);
            this.Controls.Add(this.txt_qt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_vender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.produtoDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Enabled = false;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasRoupaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediçãoDosProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçãoDaLojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private VendasRoupaDataSet vendasRoupaDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private VendasRoupaDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private VendasRoupaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView produtoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_qt;
        private System.Windows.Forms.TextBox txt_nm_comprador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cd;
    }
}