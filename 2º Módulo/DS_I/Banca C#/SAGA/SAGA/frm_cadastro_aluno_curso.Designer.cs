namespace SAGA
{
    partial class frm_cadastro_aluno_curso
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
            this.pnl_topo = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.lst_alunos_disponiveis = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_pesquisa_aluno = new System.Windows.Forms.ListBox();
            this.ckb_pesquisar_aluno = new System.Windows.Forms.CheckBox();
            this.txt_pesquisa_aluno = new System.Windows.Forms.TextBox();
            this.btn_pesquisa_aluno = new System.Windows.Forms.Button();
            this.lst_curso = new System.Windows.Forms.ListBox();
            this.btn_vincular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_turno = new System.Windows.Forms.ListBox();
            this.pnl_topo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_topo
            // 
            this.pnl_topo.BackColor = System.Drawing.Color.DarkBlue;
            this.pnl_topo.Controls.Add(this.btn_home);
            this.pnl_topo.Location = new System.Drawing.Point(-205, -2);
            this.pnl_topo.Name = "pnl_topo";
            this.pnl_topo.Size = new System.Drawing.Size(882, 84);
            this.pnl_topo.TabIndex = 3;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.White;
            this.btn_home.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.Black;
            this.btn_home.Location = new System.Drawing.Point(755, 14);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(124, 52);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            // 
            // lst_alunos_disponiveis
            // 
            this.lst_alunos_disponiveis.FormattingEnabled = true;
            this.lst_alunos_disponiveis.Location = new System.Drawing.Point(15, 124);
            this.lst_alunos_disponiveis.Name = "lst_alunos_disponiveis";
            this.lst_alunos_disponiveis.Size = new System.Drawing.Size(199, 82);
            this.lst_alunos_disponiveis.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alunos";
            // 
            // lst_pesquisa_aluno
            // 
            this.lst_pesquisa_aluno.Enabled = false;
            this.lst_pesquisa_aluno.FormattingEnabled = true;
            this.lst_pesquisa_aluno.Location = new System.Drawing.Point(15, 269);
            this.lst_pesquisa_aluno.Name = "lst_pesquisa_aluno";
            this.lst_pesquisa_aluno.Size = new System.Drawing.Size(199, 95);
            this.lst_pesquisa_aluno.TabIndex = 5;
            // 
            // ckb_pesquisar_aluno
            // 
            this.ckb_pesquisar_aluno.AutoSize = true;
            this.ckb_pesquisar_aluno.Location = new System.Drawing.Point(15, 212);
            this.ckb_pesquisar_aluno.Name = "ckb_pesquisar_aluno";
            this.ckb_pesquisar_aluno.Size = new System.Drawing.Size(102, 17);
            this.ckb_pesquisar_aluno.TabIndex = 6;
            this.ckb_pesquisar_aluno.Text = "Pesquisar Aluno";
            this.ckb_pesquisar_aluno.UseVisualStyleBackColor = true;
            this.ckb_pesquisar_aluno.CheckedChanged += new System.EventHandler(this.ckb_pesquisar_aluno_CheckedChanged);
            // 
            // txt_pesquisa_aluno
            // 
            this.txt_pesquisa_aluno.Enabled = false;
            this.txt_pesquisa_aluno.Location = new System.Drawing.Point(15, 235);
            this.txt_pesquisa_aluno.Name = "txt_pesquisa_aluno";
            this.txt_pesquisa_aluno.Size = new System.Drawing.Size(131, 20);
            this.txt_pesquisa_aluno.TabIndex = 7;
            // 
            // btn_pesquisa_aluno
            // 
            this.btn_pesquisa_aluno.Enabled = false;
            this.btn_pesquisa_aluno.Location = new System.Drawing.Point(152, 233);
            this.btn_pesquisa_aluno.Name = "btn_pesquisa_aluno";
            this.btn_pesquisa_aluno.Size = new System.Drawing.Size(62, 23);
            this.btn_pesquisa_aluno.TabIndex = 8;
            this.btn_pesquisa_aluno.Text = "ENTER";
            this.btn_pesquisa_aluno.UseVisualStyleBackColor = true;
            this.btn_pesquisa_aluno.Click += new System.EventHandler(this.btn_pesquisa_aluno_Click);
            // 
            // lst_curso
            // 
            this.lst_curso.FormattingEnabled = true;
            this.lst_curso.Location = new System.Drawing.Point(428, 124);
            this.lst_curso.Name = "lst_curso";
            this.lst_curso.Size = new System.Drawing.Size(238, 82);
            this.lst_curso.TabIndex = 9;
            this.lst_curso.SelectedIndexChanged += new System.EventHandler(this.lst_curso_SelectedIndexChanged);
            // 
            // btn_vincular
            // 
            this.btn_vincular.Location = new System.Drawing.Point(285, 163);
            this.btn_vincular.Name = "btn_vincular";
            this.btn_vincular.Size = new System.Drawing.Size(75, 23);
            this.btn_vincular.TabIndex = 10;
            this.btn_vincular.Text = "Vincular";
            this.btn_vincular.UseVisualStyleBackColor = true;
            this.btn_vincular.Click += new System.EventHandler(this.btn_vincular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Turno";
            // 
            // lst_turno
            // 
            this.lst_turno.Enabled = false;
            this.lst_turno.FormattingEnabled = true;
            this.lst_turno.Location = new System.Drawing.Point(428, 236);
            this.lst_turno.Name = "lst_turno";
            this.lst_turno.Size = new System.Drawing.Size(237, 69);
            this.lst_turno.TabIndex = 13;
            // 
            // frm_cadastro_aluno_curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 376);
            this.Controls.Add(this.lst_turno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_vincular);
            this.Controls.Add(this.lst_curso);
            this.Controls.Add(this.btn_pesquisa_aluno);
            this.Controls.Add(this.txt_pesquisa_aluno);
            this.Controls.Add(this.ckb_pesquisar_aluno);
            this.Controls.Add(this.lst_pesquisa_aluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_alunos_disponiveis);
            this.Controls.Add(this.pnl_topo);
            this.Name = "frm_cadastro_aluno_curso";
            this.Text = "S.A.G.A. - Cadastro do Aluno ao Cursos";
            this.Load += new System.EventHandler(this.frm_cadastro_aluno_curso_Load);
            this.pnl_topo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_topo;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.ListBox lst_alunos_disponiveis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_pesquisa_aluno;
        private System.Windows.Forms.CheckBox ckb_pesquisar_aluno;
        private System.Windows.Forms.TextBox txt_pesquisa_aluno;
        private System.Windows.Forms.Button btn_pesquisa_aluno;
        private System.Windows.Forms.ListBox lst_curso;
        private System.Windows.Forms.Button btn_vincular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_turno;
    }
}