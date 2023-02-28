namespace LISTA4_EXE3_MGVM_VAES
{
    partial class Exame
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.grb_sexo = new System.Windows.Forms.GroupBox();
            this.rdb_masculino = new System.Windows.Forms.RadioButton();
            this.rdb_feminino = new System.Windows.Forms.RadioButton();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.grb_exames = new System.Windows.Forms.GroupBox();
            this.ckb_raio = new System.Windows.Forms.CheckBox();
            this.ckb_gravidez = new System.Windows.Forms.CheckBox();
            this.ckb_sangue = new System.Windows.Forms.CheckBox();
            this.ckb_prostata = new System.Windows.Forms.CheckBox();
            this.grb_sexo.SuspendLayout();
            this.grb_exames.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(12, 9);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(95, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome do Paciente";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(12, 25);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(126, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // grb_sexo
            // 
            this.grb_sexo.Controls.Add(this.rdb_feminino);
            this.grb_sexo.Controls.Add(this.rdb_masculino);
            this.grb_sexo.Location = new System.Drawing.Point(12, 69);
            this.grb_sexo.Name = "grb_sexo";
            this.grb_sexo.Size = new System.Drawing.Size(125, 71);
            this.grb_sexo.TabIndex = 2;
            this.grb_sexo.TabStop = false;
            this.grb_sexo.Text = "Sexo";
            // 
            // rdb_masculino
            // 
            this.rdb_masculino.AutoSize = true;
            this.rdb_masculino.Location = new System.Drawing.Point(6, 19);
            this.rdb_masculino.Name = "rdb_masculino";
            this.rdb_masculino.Size = new System.Drawing.Size(73, 17);
            this.rdb_masculino.TabIndex = 0;
            this.rdb_masculino.TabStop = true;
            this.rdb_masculino.Text = "Masculino";
            this.rdb_masculino.UseVisualStyleBackColor = true;
            this.rdb_masculino.CheckedChanged += new System.EventHandler(this.rdb_masculino_CheckedChanged);
            // 
            // rdb_feminino
            // 
            this.rdb_feminino.AutoSize = true;
            this.rdb_feminino.Location = new System.Drawing.Point(6, 42);
            this.rdb_feminino.Name = "rdb_feminino";
            this.rdb_feminino.Size = new System.Drawing.Size(67, 17);
            this.rdb_feminino.TabIndex = 1;
            this.rdb_feminino.TabStop = true;
            this.rdb_feminino.Text = "Feminino";
            this.rdb_feminino.UseVisualStyleBackColor = true;
            this.rdb_feminino.CheckedChanged += new System.EventHandler(this.rdb_feminino_CheckedChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(12, 153);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(196, 153);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 4;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // grb_exames
            // 
            this.grb_exames.Controls.Add(this.ckb_prostata);
            this.grb_exames.Controls.Add(this.ckb_sangue);
            this.grb_exames.Controls.Add(this.ckb_gravidez);
            this.grb_exames.Controls.Add(this.ckb_raio);
            this.grb_exames.Location = new System.Drawing.Point(143, 69);
            this.grb_exames.Name = "grb_exames";
            this.grb_exames.Size = new System.Drawing.Size(180, 77);
            this.grb_exames.TabIndex = 5;
            this.grb_exames.TabStop = false;
            this.grb_exames.Text = "Exames";
            // 
            // ckb_raio
            // 
            this.ckb_raio.AutoSize = true;
            this.ckb_raio.Location = new System.Drawing.Point(17, 24);
            this.ckb_raio.Name = "ckb_raio";
            this.ckb_raio.Size = new System.Drawing.Size(58, 17);
            this.ckb_raio.TabIndex = 0;
            this.ckb_raio.Text = "Raio X";
            this.ckb_raio.UseVisualStyleBackColor = true;
            // 
            // ckb_gravidez
            // 
            this.ckb_gravidez.AutoSize = true;
            this.ckb_gravidez.Location = new System.Drawing.Point(100, 24);
            this.ckb_gravidez.Name = "ckb_gravidez";
            this.ckb_gravidez.Size = new System.Drawing.Size(68, 17);
            this.ckb_gravidez.TabIndex = 1;
            this.ckb_gravidez.Text = "Gravidez";
            this.ckb_gravidez.UseVisualStyleBackColor = true;
            // 
            // ckb_sangue
            // 
            this.ckb_sangue.AutoSize = true;
            this.ckb_sangue.Location = new System.Drawing.Point(17, 47);
            this.ckb_sangue.Name = "ckb_sangue";
            this.ckb_sangue.Size = new System.Drawing.Size(63, 17);
            this.ckb_sangue.TabIndex = 2;
            this.ckb_sangue.Text = "Sangue";
            this.ckb_sangue.UseVisualStyleBackColor = true;
            // 
            // ckb_prostata
            // 
            this.ckb_prostata.AutoSize = true;
            this.ckb_prostata.Location = new System.Drawing.Point(100, 47);
            this.ckb_prostata.Name = "ckb_prostata";
            this.ckb_prostata.Size = new System.Drawing.Size(65, 17);
            this.ckb_prostata.TabIndex = 3;
            this.ckb_prostata.Text = "Prostata";
            this.ckb_prostata.UseVisualStyleBackColor = true;
            // 
            // Exame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 185);
            this.Controls.Add(this.grb_exames);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.grb_sexo);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Exame";
            this.Text = "Lançamento de Exames";
            this.Load += new System.EventHandler(this.Exame_Load);
            this.grb_sexo.ResumeLayout(false);
            this.grb_sexo.PerformLayout();
            this.grb_exames.ResumeLayout(false);
            this.grb_exames.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.GroupBox grb_sexo;
        private System.Windows.Forms.RadioButton rdb_feminino;
        private System.Windows.Forms.RadioButton rdb_masculino;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.GroupBox grb_exames;
        private System.Windows.Forms.CheckBox ckb_prostata;
        private System.Windows.Forms.CheckBox ckb_sangue;
        private System.Windows.Forms.CheckBox ckb_gravidez;
        private System.Windows.Forms.CheckBox ckb_raio;
    }
}

