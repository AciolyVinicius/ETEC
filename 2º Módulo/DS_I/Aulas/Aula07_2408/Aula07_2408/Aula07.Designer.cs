namespace Aula07_2408
{
    partial class lbl_aula07
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdb_list = new System.Windows.Forms.RadioButton();
            this.rdb_combo = new System.Windows.Forms.RadioButton();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.lst_nome = new System.Windows.Forms.ListBox();
            this.cmb_nome = new System.Windows.Forms.ComboBox();
            this.btn_excluirlist = new System.Windows.Forms.Button();
            this.btn_excluircombo = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.grp_inclusaodados = new System.Windows.Forms.GroupBox();
            this.grp_inclusaodados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(6, 16);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(54, 19);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            this.textBox1.TabIndex = 1;
            // 
            // rdb_list
            // 
            this.rdb_list.AutoSize = true;
            this.rdb_list.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_list.Location = new System.Drawing.Point(13, 43);
            this.rdb_list.Name = "rdb_list";
            this.rdb_list.Size = new System.Drawing.Size(131, 21);
            this.rdb_list.TabIndex = 2;
            this.rdb_list.TabStop = true;
            this.rdb_list.Text = "Incluir na ListBox";
            this.rdb_list.UseVisualStyleBackColor = true;
            // 
            // rdb_combo
            // 
            this.rdb_combo.AutoSize = true;
            this.rdb_combo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_combo.Location = new System.Drawing.Point(158, 43);
            this.rdb_combo.Name = "rdb_combo";
            this.rdb_combo.Size = new System.Drawing.Size(155, 21);
            this.rdb_combo.TabIndex = 3;
            this.rdb_combo.TabStop = true;
            this.rdb_combo.Text = " Incluir no ComboBox";
            this.rdb_combo.UseVisualStyleBackColor = true;
            // 
            // btn_incluir
            // 
            this.btn_incluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incluir.Location = new System.Drawing.Point(34, 121);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(319, 33);
            this.btn_incluir.TabIndex = 4;
            this.btn_incluir.Text = "INCLUIR";
            this.btn_incluir.UseVisualStyleBackColor = true;
            // 
            // lst_nome
            // 
            this.lst_nome.FormattingEnabled = true;
            this.lst_nome.ItemHeight = 14;
            this.lst_nome.Items.AddRange(new object[] {
            "Anacieto",
            "Astrogilda",
            "Epaminondas",
            "Tiburcio"});
            this.lst_nome.Location = new System.Drawing.Point(34, 176);
            this.lst_nome.Name = "lst_nome";
            this.lst_nome.Size = new System.Drawing.Size(131, 102);
            this.lst_nome.TabIndex = 5;
            this.lst_nome.SelectedIndexChanged += new System.EventHandler(this.lst_nome_SelectedIndexChanged);
            // 
            // cmb_nome
            // 
            this.cmb_nome.FormattingEnabled = true;
            this.cmb_nome.Location = new System.Drawing.Point(202, 176);
            this.cmb_nome.Name = "cmb_nome";
            this.cmb_nome.Size = new System.Drawing.Size(151, 22);
            this.cmb_nome.TabIndex = 6;
            this.cmb_nome.SelectedIndexChanged += new System.EventHandler(this.cmb_nome_SelectedIndexChanged);
            // 
            // btn_excluirlist
            // 
            this.btn_excluirlist.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluirlist.Location = new System.Drawing.Point(34, 314);
            this.btn_excluirlist.Name = "btn_excluirlist";
            this.btn_excluirlist.Size = new System.Drawing.Size(131, 23);
            this.btn_excluirlist.TabIndex = 7;
            this.btn_excluirlist.Text = "Excluir da ListBox";
            this.btn_excluirlist.UseVisualStyleBackColor = true;
            this.btn_excluirlist.Click += new System.EventHandler(this.btn_excluirlist_Click);
            // 
            // btn_excluircombo
            // 
            this.btn_excluircombo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluircombo.Location = new System.Drawing.Point(202, 314);
            this.btn_excluircombo.Name = "btn_excluircombo";
            this.btn_excluircombo.Size = new System.Drawing.Size(151, 23);
            this.btn_excluircombo.TabIndex = 8;
            this.btn_excluircombo.Text = "Excluir da ComboBox";
            this.btn_excluircombo.UseVisualStyleBackColor = true;
            this.btn_excluircombo.Click += new System.EventHandler(this.btn_excluircombo_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(34, 365);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(319, 29);
            this.btn_sair.TabIndex = 9;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // grp_inclusaodados
            // 
            this.grp_inclusaodados.Controls.Add(this.textBox1);
            this.grp_inclusaodados.Controls.Add(this.lbl_nome);
            this.grp_inclusaodados.Controls.Add(this.rdb_list);
            this.grp_inclusaodados.Controls.Add(this.rdb_combo);
            this.grp_inclusaodados.Location = new System.Drawing.Point(34, 40);
            this.grp_inclusaodados.Name = "grp_inclusaodados";
            this.grp_inclusaodados.Size = new System.Drawing.Size(319, 75);
            this.grp_inclusaodados.TabIndex = 10;
            this.grp_inclusaodados.TabStop = false;
            this.grp_inclusaodados.Text = "Inclusão de Dados";
            // 
            // lbl_aula07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 406);
            this.Controls.Add(this.grp_inclusaodados);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_excluircombo);
            this.Controls.Add(this.btn_excluirlist);
            this.Controls.Add(this.cmb_nome);
            this.Controls.Add(this.lst_nome);
            this.Controls.Add(this.btn_incluir);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "lbl_aula07";
            this.Text = "Desenvolvimento de Softwares 1 - Aula 07";
            this.Load += new System.EventHandler(this.lbl_aula07_Load);
            this.grp_inclusaodados.ResumeLayout(false);
            this.grp_inclusaodados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdb_list;
        private System.Windows.Forms.RadioButton rdb_combo;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.ListBox lst_nome;
        private System.Windows.Forms.ComboBox cmb_nome;
        private System.Windows.Forms.Button btn_excluirlist;
        private System.Windows.Forms.Button btn_excluircombo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.GroupBox grp_inclusaodados;
    }
}

