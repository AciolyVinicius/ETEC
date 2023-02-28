namespace SAGA
{
    partial class frm_notas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_notas));
            this.pnl_topo = new System.Windows.Forms.Panel();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_perfil = new System.Windows.Forms.Button();
            this.btn_notas = new System.Windows.Forms.Button();
            this.btn_frequencia = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_saga = new System.Windows.Forms.Panel();
            this.lbl_saga = new System.Windows.Forms.Label();
            this.pnl_topo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_saga.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_topo
            // 
            this.pnl_topo.BackColor = System.Drawing.Color.DarkBlue;
            this.pnl_topo.Controls.Add(this.btn_cadastro);
            this.pnl_topo.Controls.Add(this.pictureBox1);
            this.pnl_topo.Controls.Add(this.btn_home);
            this.pnl_topo.Controls.Add(this.btn_perfil);
            this.pnl_topo.Controls.Add(this.btn_notas);
            this.pnl_topo.Controls.Add(this.btn_frequencia);
            this.pnl_topo.Location = new System.Drawing.Point(-1, -1);
            this.pnl_topo.Name = "pnl_topo";
            this.pnl_topo.Size = new System.Drawing.Size(169, 569);
            this.pnl_topo.TabIndex = 13;
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.BackColor = System.Drawing.Color.White;
            this.btn_cadastro.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro.ForeColor = System.Drawing.Color.Black;
            this.btn_cadastro.Location = new System.Drawing.Point(3, 120);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(151, 52);
            this.btn_cadastro.TabIndex = 25;
            this.btn_cadastro.Text = "Cadastro";
            this.btn_cadastro.UseVisualStyleBackColor = false;
            this.btn_cadastro.Visible = false;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click_1);
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
            this.btn_home.Location = new System.Drawing.Point(3, 231);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(151, 46);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_perfil
            // 
            this.btn_perfil.BackColor = System.Drawing.Color.White;
            this.btn_perfil.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_perfil.ForeColor = System.Drawing.Color.Black;
            this.btn_perfil.Location = new System.Drawing.Point(3, 178);
            this.btn_perfil.Name = "btn_perfil";
            this.btn_perfil.Size = new System.Drawing.Size(151, 46);
            this.btn_perfil.TabIndex = 2;
            this.btn_perfil.Text = "Perfil";
            this.btn_perfil.UseVisualStyleBackColor = false;
            this.btn_perfil.Click += new System.EventHandler(this.btn_perfil_Click);
            // 
            // btn_notas
            // 
            this.btn_notas.BackColor = System.Drawing.Color.Transparent;
            this.btn_notas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notas.Location = new System.Drawing.Point(3, 284);
            this.btn_notas.Name = "btn_notas";
            this.btn_notas.Size = new System.Drawing.Size(151, 46);
            this.btn_notas.TabIndex = 1;
            this.btn_notas.Text = "Notas";
            this.btn_notas.UseVisualStyleBackColor = false;
            // 
            // btn_frequencia
            // 
            this.btn_frequencia.BackColor = System.Drawing.Color.White;
            this.btn_frequencia.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_frequencia.Location = new System.Drawing.Point(3, 336);
            this.btn_frequencia.Name = "btn_frequencia";
            this.btn_frequencia.Size = new System.Drawing.Size(151, 46);
            this.btn_frequencia.TabIndex = 1;
            this.btn_frequencia.Text = "Frequência";
            this.btn_frequencia.UseVisualStyleBackColor = false;
            this.btn_frequencia.Click += new System.EventHandler(this.btn_frequencia_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(174, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1020, 393);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Curso: Engenharia de Computação";
            // 
            // pnl_saga
            // 
            this.pnl_saga.BackColor = System.Drawing.Color.Black;
            this.pnl_saga.Controls.Add(this.lbl_saga);
            this.pnl_saga.Location = new System.Drawing.Point(166, -1);
            this.pnl_saga.Name = "pnl_saga";
            this.pnl_saga.Size = new System.Drawing.Size(1040, 56);
            this.pnl_saga.TabIndex = 24;
            // 
            // lbl_saga
            // 
            this.lbl_saga.AutoSize = true;
            this.lbl_saga.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saga.ForeColor = System.Drawing.Color.White;
            this.lbl_saga.Location = new System.Drawing.Point(890, 0);
            this.lbl_saga.Name = "lbl_saga";
            this.lbl_saga.Size = new System.Drawing.Size(147, 56);
            this.lbl_saga.TabIndex = 0;
            this.lbl_saga.Text = "SAGA";
            // 
            // frm_notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1201, 561);
            this.Controls.Add(this.pnl_saga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnl_topo);
            this.MaximizeBox = false;
            this.Name = "frm_notas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S.A.G.A. - Notas";
            this.Load += new System.EventHandler(this.frm_notas_Load);
            this.pnl_topo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_saga;
        private System.Windows.Forms.Label lbl_saga;
        private System.Windows.Forms.Button btn_cadastro;
    }
}