namespace SAGA
{
    partial class frm_perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_perfil));
            this.pnl_topo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_perfil = new System.Windows.Forms.Button();
            this.btn_notas = new System.Windows.Forms.Button();
            this.btn_frequencia = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnl_saga = new System.Windows.Forms.Panel();
            this.lbl_saga = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_contato1 = new System.Windows.Forms.Label();
            this.lbl_contato2 = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.lst_cursos = new System.Windows.Forms.ListBox();
            this.lbl_periodo = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.pnl_topo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_saga.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_topo
            // 
            this.pnl_topo.BackColor = System.Drawing.Color.DarkBlue;
            this.pnl_topo.Controls.Add(this.pictureBox1);
            this.pnl_topo.Controls.Add(this.btn_home);
            this.pnl_topo.Controls.Add(this.btn_cadastrar);
            this.pnl_topo.Controls.Add(this.btn_perfil);
            this.pnl_topo.Controls.Add(this.btn_notas);
            this.pnl_topo.Controls.Add(this.btn_frequencia);
            this.pnl_topo.Location = new System.Drawing.Point(0, 0);
            this.pnl_topo.Name = "pnl_topo";
            this.pnl_topo.Size = new System.Drawing.Size(166, 565);
            this.pnl_topo.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 102);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.White;
            this.btn_home.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(7, 231);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(151, 46);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_perfil
            // 
            this.btn_perfil.BackColor = System.Drawing.Color.Transparent;
            this.btn_perfil.Enabled = false;
            this.btn_perfil.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_perfil.ForeColor = System.Drawing.Color.Black;
            this.btn_perfil.Location = new System.Drawing.Point(7, 178);
            this.btn_perfil.Name = "btn_perfil";
            this.btn_perfil.Size = new System.Drawing.Size(151, 46);
            this.btn_perfil.TabIndex = 2;
            this.btn_perfil.Text = "Perfil";
            this.btn_perfil.UseVisualStyleBackColor = false;
            // 
            // btn_notas
            // 
            this.btn_notas.BackColor = System.Drawing.Color.White;
            this.btn_notas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notas.Location = new System.Drawing.Point(7, 284);
            this.btn_notas.Name = "btn_notas";
            this.btn_notas.Size = new System.Drawing.Size(151, 46);
            this.btn_notas.TabIndex = 1;
            this.btn_notas.Text = "Notas";
            this.btn_notas.UseVisualStyleBackColor = false;
            this.btn_notas.Click += new System.EventHandler(this.btn_notas_Click);
            // 
            // btn_frequencia
            // 
            this.btn_frequencia.BackColor = System.Drawing.Color.White;
            this.btn_frequencia.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_frequencia.Location = new System.Drawing.Point(7, 336);
            this.btn_frequencia.Name = "btn_frequencia";
            this.btn_frequencia.Size = new System.Drawing.Size(151, 46);
            this.btn_frequencia.TabIndex = 1;
            this.btn_frequencia.Text = "Frequência";
            this.btn_frequencia.UseVisualStyleBackColor = false;
            this.btn_frequencia.Click += new System.EventHandler(this.btn_frequencia_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(185, 131);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(70, 24);
            this.lbl_nome.TabIndex = 14;
            this.lbl_nome.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data de nascimento: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cursos: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Semestre atual: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "E-mail: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Período:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Telefone: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(185, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Endereço: ";
            // 
            // pnl_saga
            // 
            this.pnl_saga.BackColor = System.Drawing.Color.Black;
            this.pnl_saga.Controls.Add(this.lbl_saga);
            this.pnl_saga.Location = new System.Drawing.Point(164, 0);
            this.pnl_saga.Name = "pnl_saga";
            this.pnl_saga.Size = new System.Drawing.Size(722, 56);
            this.pnl_saga.TabIndex = 23;
            // 
            // lbl_saga
            // 
            this.lbl_saga.AutoSize = true;
            this.lbl_saga.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saga.ForeColor = System.Drawing.Color.White;
            this.lbl_saga.Location = new System.Drawing.Point(571, 0);
            this.lbl_saga.Name = "lbl_saga";
            this.lbl_saga.Size = new System.Drawing.Size(147, 56);
            this.lbl_saga.TabIndex = 0;
            this.lbl_saga.Text = "SAGA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(420, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 32);
            this.label8.TabIndex = 24;
            this.label8.Text = "Dados pessoais";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(261, 131);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 24);
            this.lbl_name.TabIndex = 14;
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nascimento.Location = new System.Drawing.Point(400, 165);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(0, 24);
            this.lbl_nascimento.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(185, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Telefone: ";
            // 
            // lbl_contato1
            // 
            this.lbl_contato1.AutoSize = true;
            this.lbl_contato1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contato1.Location = new System.Drawing.Point(292, 189);
            this.lbl_contato1.Name = "lbl_contato1";
            this.lbl_contato1.Size = new System.Drawing.Size(0, 24);
            this.lbl_contato1.TabIndex = 20;
            // 
            // lbl_contato2
            // 
            this.lbl_contato2.AutoSize = true;
            this.lbl_contato2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contato2.Location = new System.Drawing.Point(292, 218);
            this.lbl_contato2.Name = "lbl_contato2";
            this.lbl_contato2.Size = new System.Drawing.Size(0, 24);
            this.lbl_contato2.TabIndex = 20;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(271, 247);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(0, 24);
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endereco.Location = new System.Drawing.Point(303, 271);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(0, 24);
            this.lbl_endereco.TabIndex = 21;
            // 
            // lst_cursos
            // 
            this.lst_cursos.Enabled = false;
            this.lst_cursos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_cursos.FormattingEnabled = true;
            this.lst_cursos.ItemHeight = 25;
            this.lst_cursos.Location = new System.Drawing.Point(269, 375);
            this.lst_cursos.Name = "lst_cursos";
            this.lst_cursos.Size = new System.Drawing.Size(361, 29);
            this.lst_cursos.TabIndex = 25;
            // 
            // lbl_periodo
            // 
            this.lbl_periodo.AutoSize = true;
            this.lbl_periodo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_periodo.Location = new System.Drawing.Point(281, 436);
            this.lbl_periodo.Name = "lbl_periodo";
            this.lbl_periodo.Size = new System.Drawing.Size(0, 24);
            this.lbl_periodo.TabIndex = 19;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cadastrar.Enabled = false;
            this.btn_cadastrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.Black;
            this.btn_cadastrar.Location = new System.Drawing.Point(7, 126);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(151, 46);
            this.btn_cadastrar.TabIndex = 2;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // frm_perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lst_cursos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnl_saga);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_contato1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_contato2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_periodo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_nascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.pnl_topo);
            this.MaximizeBox = false;
            this.Name = "frm_perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S.A.G.A. - Perfil";
            this.Load += new System.EventHandler(this.frm_perfil_Load);
            this.pnl_topo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_saga.ResumeLayout(false);
            this.pnl_saga.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_topo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_perfil;
        private System.Windows.Forms.Button btn_notas;
        private System.Windows.Forms.Button btn_frequencia;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnl_saga;
        private System.Windows.Forms.Label lbl_saga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_contato1;
        private System.Windows.Forms.Label lbl_contato2;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.ListBox lst_cursos;
        private System.Windows.Forms.Label lbl_periodo;
        private System.Windows.Forms.Button btn_cadastrar;
    }
}