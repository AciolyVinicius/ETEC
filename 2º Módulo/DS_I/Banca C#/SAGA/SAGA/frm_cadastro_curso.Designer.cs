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
            this.label10 = new System.Windows.Forms.Label();
            this.lst_turma = new System.Windows.Forms.ListBox();
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
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Disciplina:";
            // 
            // txt_nome_disciplina
            // 
            this.txt_nome_disciplina.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_disciplina.Location = new System.Drawing.Point(638, 164);
            this.txt_nome_disciplina.Name = "txt_nome_disciplina";
            this.txt_nome_disciplina.Size = new System.Drawing.Size(110, 26);
            this.txt_nome_disciplina.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição da Disciplina:";
            // 
            // txt_descricao_disciplina
            // 
            this.txt_descricao_disciplina.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao_disciplina.Location = new System.Drawing.Point(639, 212);
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
            this.btn_cadastrar_disciplina.Location = new System.Drawing.Point(173, 313);
            this.btn_cadastrar_disciplina.Name = "btn_cadastrar_disciplina";
            this.btn_cadastrar_disciplina.Size = new System.Drawing.Size(136, 52);
            this.btn_cadastrar_disciplina.TabIndex = 7;
            this.btn_cadastrar_disciplina.Text = "Cadastrar";
            this.btn_cadastrar_disciplina.UseVisualStyleBackColor = false;
            this.btn_cadastrar_disciplina.Click += new System.EventHandler(this.btn_cadastrar_disciplina_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome do Curso:";
            // 
            // txt_nome_curso
            // 
            this.txt_nome_curso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_curso.Location = new System.Drawing.Point(186, 108);
            this.txt_nome_curso.Name = "txt_nome_curso";
            this.txt_nome_curso.Size = new System.Drawing.Size(110, 26);
            this.txt_nome_curso.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descrição do Curso:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_descricao_curso
            // 
            this.txt_descricao_curso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao_curso.Location = new System.Drawing.Point(186, 212);
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
            this.btn_cadastrar_curso.Location = new System.Drawing.Point(630, 313);
            this.btn_cadastrar_curso.Name = "btn_cadastrar_curso";
            this.btn_cadastrar_curso.Size = new System.Drawing.Size(136, 52);
            this.btn_cadastrar_curso.TabIndex = 7;
            this.btn_cadastrar_curso.Text = "Cadastrar";
            this.btn_cadastrar_curso.UseVisualStyleBackColor = false;
            this.btn_cadastrar_curso.Click += new System.EventHandler(this.btn_cadastrar_curso_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Carga horária total:";
            // 
            // txt_carga_horaria
            // 
            this.txt_carga_horaria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_carga_horaria.Location = new System.Drawing.Point(186, 168);
            this.txt_carga_horaria.Name = "txt_carga_horaria";
            this.txt_carga_horaria.Size = new System.Drawing.Size(110, 26);
            this.txt_carga_horaria.TabIndex = 9;
            // 
            // lst_curso
            // 
            this.lst_curso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_curso.ItemHeight = 18;
            this.lst_curso.Location = new System.Drawing.Point(21, 482);
            this.lst_curso.Name = "lst_curso";
            this.lst_curso.Size = new System.Drawing.Size(275, 202);
            this.lst_curso.TabIndex = 13;
            this.lst_curso.SelectedIndexChanged += new System.EventHandler(this.lst_curso_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Selecione um curso:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(362, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Adicione uma disciplina:";
            // 
            // lst_disciplina
            // 
            this.lst_disciplina.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_disciplina.ItemHeight = 18;
            this.lst_disciplina.Location = new System.Drawing.Point(365, 481);
            this.lst_disciplina.Name = "lst_disciplina";
            this.lst_disciplina.Size = new System.Drawing.Size(295, 130);
            this.lst_disciplina.TabIndex = 16;
            this.lst_disciplina.SelectedIndexChanged += new System.EventHandler(this.lst_disciplina_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-37, 313);
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
            this.btn_vincular.Location = new System.Drawing.Point(365, 634);
            this.btn_vincular.Name = "btn_vincular";
            this.btn_vincular.Size = new System.Drawing.Size(295, 52);
            this.btn_vincular.TabIndex = 18;
            this.btn_vincular.Text = "Vincular";
            this.btn_vincular.UseVisualStyleBackColor = false;
            this.btn_vincular.Click += new System.EventHandler(this.btn_vincular_Click);
            // 
            // lst_turno
            // 
            this.lst_turno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_turno.ItemHeight = 18;
            this.lst_turno.Location = new System.Drawing.Point(682, 470);
            this.lst_turno.Name = "lst_turno";
            this.lst_turno.Size = new System.Drawing.Size(154, 40);
            this.lst_turno.TabIndex = 19;
            this.lst_turno.SelectedIndexChanged += new System.EventHandler(this.lst_turno_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(679, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Selecione o turno:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(679, 550);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Selecione a turma:";
            // 
            // lst_turma
            // 
            this.lst_turma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_turma.ItemHeight = 18;
            this.lst_turma.Location = new System.Drawing.Point(682, 571);
            this.lst_turma.Name = "lst_turma";
            this.lst_turma.Size = new System.Drawing.Size(154, 40);
            this.lst_turma.TabIndex = 22;
            this.lst_turma.SelectedIndexChanged += new System.EventHandler(this.lst_turma_SelectedIndexChanged);
            // 
            // frm_cadastro_curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 697);
            this.Controls.Add(this.lst_turma);
            this.Controls.Add(this.label10);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lst_turma;
    }
}