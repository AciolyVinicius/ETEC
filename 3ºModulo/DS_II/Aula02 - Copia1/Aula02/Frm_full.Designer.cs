namespace Aula02
{
    partial class Frm_full
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
            this.txt_ConfirmFull = new System.Windows.Forms.TextBox();
            this.lbl_confirm = new System.Windows.Forms.Label();
            this.txt_PasswordFull = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UsuarioFull = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dbDadosDataSet = new Aula02.dbDadosDataSet();
            this.tb_loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_loginTableAdapter = new Aula02.dbDadosDataSetTableAdapters.tb_loginTableAdapter();
            this.tableAdapterManager = new Aula02.dbDadosDataSetTableAdapters.TableAdapterManager();
            this.tb_loginDGV = new System.Windows.Forms.DataGridView();
            this.btn_incluirFull = new System.Windows.Forms.Button();
            this.btn_exluirFull = new System.Windows.Forms.Button();
            this.btn_updateFull = new System.Windows.Forms.Button();
            this.btn_zerarFull = new System.Windows.Forms.Button();
            this.btn_cancelarFull = new System.Windows.Forms.Button();
            this.lbl_MessageFull = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbDadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_loginDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ConfirmFull
            // 
            this.txt_ConfirmFull.Location = new System.Drawing.Point(368, 49);
            this.txt_ConfirmFull.MaxLength = 10;
            this.txt_ConfirmFull.Name = "txt_ConfirmFull";
            this.txt_ConfirmFull.Size = new System.Drawing.Size(201, 26);
            this.txt_ConfirmFull.TabIndex = 19;
            // 
            // lbl_confirm
            // 
            this.lbl_confirm.AutoSize = true;
            this.lbl_confirm.Location = new System.Drawing.Point(266, 57);
            this.lbl_confirm.Name = "lbl_confirm";
            this.lbl_confirm.Size = new System.Drawing.Size(98, 18);
            this.lbl_confirm.TabIndex = 22;
            this.lbl_confirm.Text = "Confirmação";
            // 
            // txt_PasswordFull
            // 
            this.txt_PasswordFull.Location = new System.Drawing.Point(368, 12);
            this.txt_PasswordFull.MaxLength = 10;
            this.txt_PasswordFull.Name = "txt_PasswordFull";
            this.txt_PasswordFull.Size = new System.Drawing.Size(201, 26);
            this.txt_PasswordFull.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(266, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Senha";
            // 
            // txt_UsuarioFull
            // 
            this.txt_UsuarioFull.Location = new System.Drawing.Point(82, 32);
            this.txt_UsuarioFull.MaxLength = 10;
            this.txt_UsuarioFull.Name = "txt_UsuarioFull";
            this.txt_UsuarioFull.Size = new System.Drawing.Size(167, 26);
            this.txt_UsuarioFull.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Usuário";
            // 
            // dbDadosDataSet
            // 
            this.dbDadosDataSet.DataSetName = "dbDadosDataSet";
            this.dbDadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_loginBindingSource
            // 
            this.tb_loginBindingSource.DataMember = "tb_login";
            this.tb_loginBindingSource.DataSource = this.dbDadosDataSet;
            // 
            // tb_loginTableAdapter
            // 
            this.tb_loginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_loginTableAdapter = this.tb_loginTableAdapter;
            this.tableAdapterManager.UpdateOrder = Aula02.dbDadosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_loginDGV
            // 
            this.tb_loginDGV.AutoGenerateColumns = false;
            this.tb_loginDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_loginDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tb_loginDGV.DataSource = this.tb_loginBindingSource;
            this.tb_loginDGV.Location = new System.Drawing.Point(12, 97);
            this.tb_loginDGV.Name = "tb_loginDGV";
            this.tb_loginDGV.ReadOnly = true;
            this.tb_loginDGV.Size = new System.Drawing.Size(557, 184);
            this.tb_loginDGV.TabIndex = 23;
            // 
            // btn_incluirFull
            // 
            this.btn_incluirFull.Location = new System.Drawing.Point(46, 334);
            this.btn_incluirFull.Name = "btn_incluirFull";
            this.btn_incluirFull.Size = new System.Drawing.Size(92, 36);
            this.btn_incluirFull.TabIndex = 24;
            this.btn_incluirFull.Text = "Incluir";
            this.btn_incluirFull.UseVisualStyleBackColor = true;
            this.btn_incluirFull.Click += new System.EventHandler(this.btn_incluirFull_Click);
            // 
            // btn_exluirFull
            // 
            this.btn_exluirFull.Location = new System.Drawing.Point(144, 334);
            this.btn_exluirFull.Name = "btn_exluirFull";
            this.btn_exluirFull.Size = new System.Drawing.Size(92, 36);
            this.btn_exluirFull.TabIndex = 25;
            this.btn_exluirFull.Text = "Excluir";
            this.btn_exluirFull.UseVisualStyleBackColor = true;
            this.btn_exluirFull.Click += new System.EventHandler(this.btn_exluirFull_Click);
            // 
            // btn_updateFull
            // 
            this.btn_updateFull.Location = new System.Drawing.Point(242, 334);
            this.btn_updateFull.Name = "btn_updateFull";
            this.btn_updateFull.Size = new System.Drawing.Size(92, 36);
            this.btn_updateFull.TabIndex = 26;
            this.btn_updateFull.Text = "Update";
            this.btn_updateFull.UseVisualStyleBackColor = true;
            this.btn_updateFull.Click += new System.EventHandler(this.btn_updateFull_Click);
            // 
            // btn_zerarFull
            // 
            this.btn_zerarFull.Location = new System.Drawing.Point(340, 334);
            this.btn_zerarFull.Name = "btn_zerarFull";
            this.btn_zerarFull.Size = new System.Drawing.Size(92, 36);
            this.btn_zerarFull.TabIndex = 27;
            this.btn_zerarFull.Text = "Zerar";
            this.btn_zerarFull.UseVisualStyleBackColor = true;
            this.btn_zerarFull.Click += new System.EventHandler(this.btn_zerarFull_Click);
            // 
            // btn_cancelarFull
            // 
            this.btn_cancelarFull.Location = new System.Drawing.Point(438, 334);
            this.btn_cancelarFull.Name = "btn_cancelarFull";
            this.btn_cancelarFull.Size = new System.Drawing.Size(92, 36);
            this.btn_cancelarFull.TabIndex = 28;
            this.btn_cancelarFull.Text = "Cancelar";
            this.btn_cancelarFull.UseVisualStyleBackColor = true;
            // 
            // lbl_MessageFull
            // 
            this.lbl_MessageFull.AutoSize = true;
            this.lbl_MessageFull.Location = new System.Drawing.Point(9, 301);
            this.lbl_MessageFull.Name = "lbl_MessageFull";
            this.lbl_MessageFull.Size = new System.Drawing.Size(0, 18);
            this.lbl_MessageFull.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nm_usuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "nm_usuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 249;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cd_senha";
            this.dataGridViewTextBoxColumn2.HeaderText = "cd_senha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 248;
            // 
            // Frm_full
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 382);
            this.Controls.Add(this.lbl_MessageFull);
            this.Controls.Add(this.btn_cancelarFull);
            this.Controls.Add(this.btn_zerarFull);
            this.Controls.Add(this.btn_updateFull);
            this.Controls.Add(this.btn_exluirFull);
            this.Controls.Add(this.btn_incluirFull);
            this.Controls.Add(this.tb_loginDGV);
            this.Controls.Add(this.txt_ConfirmFull);
            this.Controls.Add(this.lbl_confirm);
            this.Controls.Add(this.txt_PasswordFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_UsuarioFull);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_full";
            this.Text = "Full";
            this.Load += new System.EventHandler(this.Frm_full_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_loginDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ConfirmFull;
        private System.Windows.Forms.Label lbl_confirm;
        private System.Windows.Forms.TextBox txt_PasswordFull;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UsuarioFull;
        private System.Windows.Forms.Label label1;
        private dbDadosDataSet dbDadosDataSet;
        private System.Windows.Forms.BindingSource tb_loginBindingSource;
        private dbDadosDataSetTableAdapters.tb_loginTableAdapter tb_loginTableAdapter;
        private dbDadosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tb_loginDGV;
        private System.Windows.Forms.Button btn_incluirFull;
        private System.Windows.Forms.Button btn_exluirFull;
        private System.Windows.Forms.Button btn_updateFull;
        private System.Windows.Forms.Button btn_zerarFull;
        private System.Windows.Forms.Button btn_cancelarFull;
        private System.Windows.Forms.Label lbl_MessageFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}