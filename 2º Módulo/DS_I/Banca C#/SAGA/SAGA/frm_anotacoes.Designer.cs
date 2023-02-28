namespace SAGA
{
    partial class frm_anotacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_anotacoes));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_perfil = new System.Windows.Forms.Button();
            this.btn_notas = new System.Windows.Forms.Button();
            this.btn_frequencia = new System.Windows.Forms.Button();
            this.pnl_topo = new System.Windows.Forms.Panel();
            this.btn_anotacoes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lst_disciplina = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_topo.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_home.Location = new System.Drawing.Point(7, 242);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(151, 46);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.White;
            this.btn_cadastrar.Enabled = false;
            this.btn_cadastrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.Black;
            this.btn_cadastrar.Location = new System.Drawing.Point(7, 140);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(151, 46);
            this.btn_cadastrar.TabIndex = 2;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_perfil
            // 
            this.btn_perfil.BackColor = System.Drawing.Color.White;
            this.btn_perfil.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_perfil.ForeColor = System.Drawing.Color.Black;
            this.btn_perfil.Location = new System.Drawing.Point(7, 191);
            this.btn_perfil.Name = "btn_perfil";
            this.btn_perfil.Size = new System.Drawing.Size(151, 46);
            this.btn_perfil.TabIndex = 2;
            this.btn_perfil.Text = "Perfil";
            this.btn_perfil.UseVisualStyleBackColor = false;
            this.btn_perfil.Click += new System.EventHandler(this.btn_perfil_Click);
            // 
            // btn_notas
            // 
            this.btn_notas.BackColor = System.Drawing.Color.White;
            this.btn_notas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notas.Location = new System.Drawing.Point(7, 295);
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
            this.btn_frequencia.Location = new System.Drawing.Point(7, 348);
            this.btn_frequencia.Name = "btn_frequencia";
            this.btn_frequencia.Size = new System.Drawing.Size(151, 46);
            this.btn_frequencia.TabIndex = 1;
            this.btn_frequencia.Text = "Frequência";
            this.btn_frequencia.UseVisualStyleBackColor = false;
            this.btn_frequencia.Click += new System.EventHandler(this.btn_frequencia_Click);
            // 
            // pnl_topo
            // 
            this.pnl_topo.BackColor = System.Drawing.Color.DarkBlue;
            this.pnl_topo.Controls.Add(this.btn_anotacoes);
            this.pnl_topo.Controls.Add(this.pictureBox1);
            this.pnl_topo.Controls.Add(this.btn_home);
            this.pnl_topo.Controls.Add(this.btn_cadastrar);
            this.pnl_topo.Controls.Add(this.btn_perfil);
            this.pnl_topo.Controls.Add(this.btn_notas);
            this.pnl_topo.Controls.Add(this.btn_frequencia);
            this.pnl_topo.Location = new System.Drawing.Point(1, 0);
            this.pnl_topo.Name = "pnl_topo";
            this.pnl_topo.Size = new System.Drawing.Size(166, 569);
            this.pnl_topo.TabIndex = 14;
            // 
            // btn_anotacoes
            // 
            this.btn_anotacoes.BackColor = System.Drawing.Color.Transparent;
            this.btn_anotacoes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anotacoes.Location = new System.Drawing.Point(7, 403);
            this.btn_anotacoes.Name = "btn_anotacoes";
            this.btn_anotacoes.Size = new System.Drawing.Size(151, 46);
            this.btn_anotacoes.TabIndex = 5;
            this.btn_anotacoes.Text = "Anotações";
            this.btn_anotacoes.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(418, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Adicionar anotação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Título da anotação";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(400, 126);
            this.monthCalendar1.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(2017, 11, 30, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Defina qual é o dia máximo para a entrega";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(320, 340);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(411, 138);
            this.textBox2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Escreva aqui suas anotações";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(173, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 35);
            this.button2.TabIndex = 22;
            this.button2.Text = "Anotações já cadastradas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lst_disciplina
            // 
            this.lst_disciplina.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_disciplina.FormattingEnabled = true;
            this.lst_disciplina.ItemHeight = 24;
            this.lst_disciplina.Location = new System.Drawing.Point(681, 170);
            this.lst_disciplina.Name = "lst_disciplina";
            this.lst_disciplina.Size = new System.Drawing.Size(191, 76);
            this.lst_disciplina.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(677, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Escolha a disciplina";
            // 
            // frm_anotacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lst_disciplina);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnl_topo);
            this.Name = "frm_anotacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S.A.G.A. - Anotações";
            this.Load += new System.EventHandler(this.frm_anotacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_topo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_perfil;
        private System.Windows.Forms.Button btn_notas;
        private System.Windows.Forms.Button btn_frequencia;
        private System.Windows.Forms.Panel pnl_topo;
        private System.Windows.Forms.Button btn_anotacoes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lst_disciplina;
        private System.Windows.Forms.Label label4;
    }
}