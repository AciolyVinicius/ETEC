namespace Imagem_Banco
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_ativar = new System.Windows.Forms.Button();
            this.dtvImagens = new System.Windows.Forms.DataGridView();
            this.btn_carregarimagem = new System.Windows.Forms.Button();
            this.btn_salvarimagem = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.btn_obterimagem = new System.Windows.Forms.Button();
            this.pcb_imagens = new System.Windows.Forms.PictureBox();
            this.txt_stringconexaoBD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvImagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagens)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_ativar
            // 
            this.btn_ativar.Location = new System.Drawing.Point(297, 9);
            this.btn_ativar.Name = "btn_ativar";
            this.btn_ativar.Size = new System.Drawing.Size(70, 50);
            this.btn_ativar.TabIndex = 0;
            this.btn_ativar.Text = "ATIVAR";
            this.btn_ativar.UseVisualStyleBackColor = true;
            this.btn_ativar.Click += new System.EventHandler(this.btn_ativar_Click);
            // 
            // dtvImagens
            // 
            this.dtvImagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvImagens.Location = new System.Drawing.Point(2, 253);
            this.dtvImagens.Name = "dtvImagens";
            this.dtvImagens.Size = new System.Drawing.Size(374, 71);
            this.dtvImagens.TabIndex = 1;
            // 
            // btn_carregarimagem
            // 
            this.btn_carregarimagem.Enabled = false;
            this.btn_carregarimagem.Location = new System.Drawing.Point(2, 225);
            this.btn_carregarimagem.Name = "btn_carregarimagem";
            this.btn_carregarimagem.Size = new System.Drawing.Size(171, 22);
            this.btn_carregarimagem.TabIndex = 2;
            this.btn_carregarimagem.Text = "Carregar Imagem";
            this.btn_carregarimagem.UseVisualStyleBackColor = true;
            this.btn_carregarimagem.Click += new System.EventHandler(this.btn_carregarimagem_Click);
            // 
            // btn_salvarimagem
            // 
            this.btn_salvarimagem.Enabled = false;
            this.btn_salvarimagem.Location = new System.Drawing.Point(179, 225);
            this.btn_salvarimagem.Name = "btn_salvarimagem";
            this.btn_salvarimagem.Size = new System.Drawing.Size(197, 22);
            this.btn_salvarimagem.TabIndex = 3;
            this.btn_salvarimagem.Text = "Salvar Imagem no banco de dados";
            this.btn_salvarimagem.UseVisualStyleBackColor = true;
            this.btn_salvarimagem.Click += new System.EventHandler(this.btn_salvarimagem_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(179, 115);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(197, 20);
            this.txt_codigo.TabIndex = 4;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(179, 166);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(197, 53);
            this.txt_descricao.TabIndex = 5;
            // 
            // btn_obterimagem
            // 
            this.btn_obterimagem.Enabled = false;
            this.btn_obterimagem.Location = new System.Drawing.Point(179, 68);
            this.btn_obterimagem.Name = "btn_obterimagem";
            this.btn_obterimagem.Size = new System.Drawing.Size(197, 23);
            this.btn_obterimagem.TabIndex = 6;
            this.btn_obterimagem.Text = "Obter imagem do banco de dados";
            this.btn_obterimagem.UseVisualStyleBackColor = true;
            this.btn_obterimagem.Click += new System.EventHandler(this.btn_obterimagem_Click);
            // 
            // pcb_imagens
            // 
            this.pcb_imagens.Location = new System.Drawing.Point(12, 68);
            this.pcb_imagens.Name = "pcb_imagens";
            this.pcb_imagens.Size = new System.Drawing.Size(161, 151);
            this.pcb_imagens.TabIndex = 7;
            this.pcb_imagens.TabStop = false;
            // 
            // txt_stringconexaoBD
            // 
            this.txt_stringconexaoBD.Location = new System.Drawing.Point(12, 27);
            this.txt_stringconexaoBD.Multiline = true;
            this.txt_stringconexaoBD.Name = "txt_stringconexaoBD";
            this.txt_stringconexaoBD.Size = new System.Drawing.Size(279, 32);
            this.txt_stringconexaoBD.TabIndex = 8;
            this.txt_stringconexaoBD.Text = "Data Source=L1-M16;Initial Catalog=Cadastro;Integrated Security=True";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Descrição da Imagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Código da Imagem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "String de Conexão com o SQL Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 327);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_stringconexaoBD);
            this.Controls.Add(this.pcb_imagens);
            this.Controls.Add(this.btn_obterimagem);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_salvarimagem);
            this.Controls.Add(this.btn_carregarimagem);
            this.Controls.Add(this.dtvImagens);
            this.Controls.Add(this.btn_ativar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtvImagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_imagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_ativar;
        private System.Windows.Forms.DataGridView dtvImagens;
        private System.Windows.Forms.Button btn_carregarimagem;
        private System.Windows.Forms.Button btn_salvarimagem;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Button btn_obterimagem;
        private System.Windows.Forms.PictureBox pcb_imagens;
        private System.Windows.Forms.TextBox txt_stringconexaoBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

