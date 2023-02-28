namespace SAGA
{
    partial class frm_cadastro_curso
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome_disciplina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_descricao_disciplina = new System.Windows.Forms.TextBox();
            this.btn_cadastrar_disciplina = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome_curso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_descricao_curso = new System.Windows.Forms.TextBox();
            this.btn_cadastrar_curso = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_carga_horaria = new System.Windows.Forms.TextBox();
            this.lst_curso = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lst_disciplina = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_vincular = new System.Windows.Forms.Button();
            this.lst_turno = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl_topo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_topo
            // 
            this.pnl_topo.BackColor = System.Drawing.Color.DarkBlue;
            this.pnl_topo.Controls.Add(this.btn_home);
            this.pnl_topo.Location = new System.Drawing.Point(0, 0);
            this.pnl_topo.Name = "pnl_topo";
            this.pnl_topo.Size = new System.Drawing.Size(882, 75);
            this.pnl_topo.TabIndex = 2;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.White;
            this.btn_home.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.Black;
            this.btn_home.Location = new System.Drawing.Point(747, 15);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(124, 52);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Disciplina:";
            // 
            // txt_nome_disciplina
            // 
            this.txt_nome_disciplina.Location = new System.Drawing.Point(145, 95);
            this.txt_nome_disciplina.Name = "txt_nome_disciplina";
            this.txt_nome_disciplina.Size = new System.Drawing.Size(110, 20);
            this.txt_nome_disciplina.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição da Disciplina:";
            // 
            // txt_descricao_disciplina
            // 
            this.txt_descricao_disciplina.Location = new System.Drawing.Point(145, 149);
            this.txt_descricao_disciplina.Multiline = true;
            this.txt_descricao_disciplina.Name = "txt_descricao_disciplina";
            this.txt_descricao_disciplina.Size = new System.Drawing.Size(109, 88);
            this.txt_descricao_disciplina.TabIndex = 6;
            // 
            // btn_cadastrar_disciplina
            // 
            this.btn_cadastrar_disciplina.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_cadastrar_disciplina.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_disciplina.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar_disciplina.Location = new System.Drawing.Point(21, 322);
            this.btn_cadastrar_disciplina.Name = "btn_cadastrar_disciplina";
            this.btn_cadastrar_disciplina.Size = new System.Drawing.Size(124, 52);
            this.btn_cadastrar_disciplina.TabIndex = 7;
            this.btn_cadastrar_disciplina.Text = "Cadastrar";
            this.btn_cadastrar_disciplina.UseVisualStyleBackColor = false;
            this.btn_cadastrar_disciplina.Click += new System.EventHandler(this.btn_cadastrar_disciplina_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome do Curso:";
            // 
            // txt_nome_curso
            // 
            this.txt_nome_curso.Location = new System.Drawing.Point(536, 94);
            this.txt_nome_curso.Name = "txt_nome_curso";
            this.txt_nome_curso.Size = new System.Drawing.Size(110, 20);
            this.txt_nome_curso.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descrição do Curso:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_descricao_curso
            // 
            this.txt_descricao_curso.Location = new System.Drawing.Point(536, 188);
            this.txt_descricao_curso.Multiline = true;
            this.txt_descricao_curso.Name = "txt_descricao_curso";
            this.txt_descricao_curso.Size = new System.Drawing.Size(110, 88);
            this.txt_descricao_curso.TabIndex = 11;
            // 
            // btn_cadastrar_curso
            // 
            this.btn_cadastrar_curso.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_cadastrar_curso.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_curso.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar_curso.Location = new System.Drawing.Point(430, 322);
            this.btn_cadastrar_curso.Name = "btn_cadastrar_curso";
            this.btn_cadastrar_curso.Size = new System.Drawing.Size(124, 52);
            this.btn_cadastrar_curso.TabIndex = 7;
            this.btn_cadastrar_curso.Text = "Cadastrar";
            this.btn_cadastrar_curso.UseVisualStyleBackColor = false;
            this.btn_cadastrar_curso.Click += new System.EventHandler(this.btn_cadastrar_curso_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Carga horária total:";
            // 
            // txt_carga_horaria
            // 
            this.txt_carga_horaria.Location = new System.Drawing.Point(536, 149);
            this.txt_carga_horaria.Name = "txt_carga_horaria";
            this.txt_carga_horaria.Size = new System.Drawing.Size(110, 20);
            this.txt_carga_horaria.TabIndex = 9;
            // 
            // lst_curso
            // 
            this.lst_curso.FormattingEnabled = true;
            this.lst_curso.Location = new System.Drawing.Point(21, 517);
            this.lst_curso.Name = "lst_curso";
            this.lst_curso.Size = new System.Drawing.Size(275, 212);
            this.lst_curso.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Selecione um curso:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Adicione uma disciplina:";
            // 
            // lst_disciplina
            // 
            this.lst_disciplina.FormattingEnabled = true;
            this.lst_disciplina.Location = new System.Drawing.Point(365, 516);
            this.lst_disciplina.Name = "lst_disciplina";
            this.lst_disciplina.Size = new System.Drawing.Size(295, 147);
            this.lst_disciplina.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-32, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2025, 136);
            this.label6.TabIndex = 17;
            this.label6.Text = "_________________________________________";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_vincular
            // 
            this.btn_vincular.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_vincular.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vincular.ForeColor = System.Drawing.Color.White;
            this.btn_vincular.Location = new System.Drawing.Point(365, 669);
            this.btn_vincular.Name = "btn_vincular";
            this.btn_vincular.Size = new System.Drawing.Size(295, 52);
            this.btn_vincular.TabIndex = 18;
            this.btn_vincular.Text = "Vincular";
            this.btn_vincular.UseVisualStyleBackColor = false;
            // 
            // lst_turno
            // 
            this.lst_turno.FormattingEnabled = true;
            this.lst_turno.Location = new System.Drawing.Point(703, 516);
            this.lst_turno.Name = "lst_turno";
            this.lst_turno.Size = new System.Drawing.Size(154, 43);
            this.lst_turno.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(700, 489);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Selecione o turno:";
            // 
            // frm_cadastro_curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 741);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lst_turno);
            this.Controls.Add(this.btn_vincular);
            this.Controls.Add(this.lst_disciplina);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lst_curso);
            this.Controls.Add(this.txt_descricao_curso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_carga_horaria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nome_curso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cadastrar_curso);
            this.Controls.Add(this.btn_cadastrar_disciplina);
            this.Controls.Add(this.txt_descricao_disciplina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome_disciplina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_topo);
            this.Controls.Add(this.label6);
            this.Name = "frm_cadastro_curso";
            this.Text = "S.A.G.A. - Cadastro de Cursos";
            this.Load += new System.EventHandler(this.frm_cadastro_curso_Load);
            this.pnl_topo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_topo;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cadastrar_disciplina;
        private System.Windows.Forms.TextBox txt_nome_disciplina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_descricao_disciplina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nome_curso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_descricao_curso;
        private System.Windows.Forms.Button btn_cadastrar_curso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_carga_horaria;
        private System.Windows.Forms.ListBox lst_curso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lst_disciplina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_vincular;
        private System.Windows.Forms.ListBox lst_turno;
        private System.Windows.Forms.Label label9;
    }
}