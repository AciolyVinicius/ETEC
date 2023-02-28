namespace Aula09_RegistroDoWindows
{
    partial class Frm_Registro
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
            this.grp_GravandoNoRegistro = new System.Windows.Forms.GroupBox();
            this.btn_ExcluirRegistro = new System.Windows.Forms.Button();
            this.btn_LendoRegistro = new System.Windows.Forms.Button();
            this.btn_CriarCaminho = new System.Windows.Forms.Button();
            this.txt_LendoRegistro = new System.Windows.Forms.TextBox();
            this.lbl_LendoRegistro = new System.Windows.Forms.Label();
            this.txt_ValorRegistro = new System.Windows.Forms.TextBox();
            this.lbl_ValorRegistro = new System.Windows.Forms.Label();
            this.grp_LeCaminho = new System.Windows.Forms.GroupBox();
            this.lbl_Caminho = new System.Windows.Forms.Label();
            this.btn_GravarCaminho = new System.Windows.Forms.Button();
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.txt_Caminho = new System.Windows.Forms.TextBox();
            this.grp_GravaCaminho = new System.Windows.Forms.GroupBox();
            this.lbl_CaminhoGravado = new System.Windows.Forms.Label();
            this.txt_CaminhoGravado = new System.Windows.Forms.TextBox();
            this.btn_CaminhoGravado = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grp_GravandoNoRegistro.SuspendLayout();
            this.grp_LeCaminho.SuspendLayout();
            this.grp_GravaCaminho.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_GravandoNoRegistro
            // 
            this.grp_GravandoNoRegistro.Controls.Add(this.btn_ExcluirRegistro);
            this.grp_GravandoNoRegistro.Controls.Add(this.btn_LendoRegistro);
            this.grp_GravandoNoRegistro.Controls.Add(this.btn_CriarCaminho);
            this.grp_GravandoNoRegistro.Controls.Add(this.txt_LendoRegistro);
            this.grp_GravandoNoRegistro.Controls.Add(this.lbl_LendoRegistro);
            this.grp_GravandoNoRegistro.Controls.Add(this.txt_ValorRegistro);
            this.grp_GravandoNoRegistro.Controls.Add(this.lbl_ValorRegistro);
            this.grp_GravandoNoRegistro.Location = new System.Drawing.Point(12, 12);
            this.grp_GravandoNoRegistro.Name = "grp_GravandoNoRegistro";
            this.grp_GravandoNoRegistro.Size = new System.Drawing.Size(449, 235);
            this.grp_GravandoNoRegistro.TabIndex = 0;
            this.grp_GravandoNoRegistro.TabStop = false;
            this.grp_GravandoNoRegistro.Text = "Gravando no Registro";
            // 
            // btn_ExcluirRegistro
            // 
            this.btn_ExcluirRegistro.Location = new System.Drawing.Point(185, 192);
            this.btn_ExcluirRegistro.Name = "btn_ExcluirRegistro";
            this.btn_ExcluirRegistro.Size = new System.Drawing.Size(94, 28);
            this.btn_ExcluirRegistro.TabIndex = 2;
            this.btn_ExcluirRegistro.Text = "Excluir";
            this.btn_ExcluirRegistro.UseVisualStyleBackColor = true;
            this.btn_ExcluirRegistro.Click += new System.EventHandler(this.btn_ExcluirRegistro_Click);
            // 
            // btn_LendoRegistro
            // 
            this.btn_LendoRegistro.Location = new System.Drawing.Point(49, 162);
            this.btn_LendoRegistro.Name = "btn_LendoRegistro";
            this.btn_LendoRegistro.Size = new System.Drawing.Size(73, 28);
            this.btn_LendoRegistro.TabIndex = 2;
            this.btn_LendoRegistro.Text = "Leitura";
            this.btn_LendoRegistro.UseVisualStyleBackColor = true;
            this.btn_LendoRegistro.Click += new System.EventHandler(this.btn_LendoRegistro_Click);
            // 
            // btn_CriarCaminho
            // 
            this.btn_CriarCaminho.Location = new System.Drawing.Point(49, 77);
            this.btn_CriarCaminho.Name = "btn_CriarCaminho";
            this.btn_CriarCaminho.Size = new System.Drawing.Size(73, 28);
            this.btn_CriarCaminho.TabIndex = 2;
            this.btn_CriarCaminho.Text = "Criar";
            this.btn_CriarCaminho.UseVisualStyleBackColor = true;
            this.btn_CriarCaminho.Click += new System.EventHandler(this.btn_CriarCaminho_Click);
            // 
            // txt_LendoRegistro
            // 
            this.txt_LendoRegistro.Location = new System.Drawing.Point(49, 129);
            this.txt_LendoRegistro.Name = "txt_LendoRegistro";
            this.txt_LendoRegistro.Size = new System.Drawing.Size(381, 27);
            this.txt_LendoRegistro.TabIndex = 1;
            // 
            // lbl_LendoRegistro
            // 
            this.lbl_LendoRegistro.AutoSize = true;
            this.lbl_LendoRegistro.Location = new System.Drawing.Point(31, 108);
            this.lbl_LendoRegistro.Name = "lbl_LendoRegistro";
            this.lbl_LendoRegistro.Size = new System.Drawing.Size(126, 18);
            this.lbl_LendoRegistro.TabIndex = 0;
            this.lbl_LendoRegistro.Text = "Lendo registro";
            // 
            // txt_ValorRegistro
            // 
            this.txt_ValorRegistro.Location = new System.Drawing.Point(49, 44);
            this.txt_ValorRegistro.Name = "txt_ValorRegistro";
            this.txt_ValorRegistro.Size = new System.Drawing.Size(381, 27);
            this.txt_ValorRegistro.TabIndex = 1;
            // 
            // lbl_ValorRegistro
            // 
            this.lbl_ValorRegistro.AutoSize = true;
            this.lbl_ValorRegistro.Location = new System.Drawing.Point(31, 23);
            this.lbl_ValorRegistro.Name = "lbl_ValorRegistro";
            this.lbl_ValorRegistro.Size = new System.Drawing.Size(118, 18);
            this.lbl_ValorRegistro.TabIndex = 0;
            this.lbl_ValorRegistro.Text = "Valor registro";
            // 
            // grp_LeCaminho
            // 
            this.grp_LeCaminho.Controls.Add(this.lbl_Caminho);
            this.grp_LeCaminho.Controls.Add(this.btn_GravarCaminho);
            this.grp_LeCaminho.Controls.Add(this.btn_Abrir);
            this.grp_LeCaminho.Controls.Add(this.txt_Caminho);
            this.grp_LeCaminho.Location = new System.Drawing.Point(12, 253);
            this.grp_LeCaminho.Name = "grp_LeCaminho";
            this.grp_LeCaminho.Size = new System.Drawing.Size(449, 113);
            this.grp_LeCaminho.TabIndex = 1;
            this.grp_LeCaminho.TabStop = false;
            this.grp_LeCaminho.Text = "Escolhe o Caminho";
            // 
            // lbl_Caminho
            // 
            this.lbl_Caminho.AutoSize = true;
            this.lbl_Caminho.Location = new System.Drawing.Point(23, 23);
            this.lbl_Caminho.Name = "lbl_Caminho";
            this.lbl_Caminho.Size = new System.Drawing.Size(172, 18);
            this.lbl_Caminho.TabIndex = 0;
            this.lbl_Caminho.Text = "Caminho do Arquivo";
            // 
            // btn_GravarCaminho
            // 
            this.btn_GravarCaminho.Location = new System.Drawing.Point(122, 77);
            this.btn_GravarCaminho.Name = "btn_GravarCaminho";
            this.btn_GravarCaminho.Size = new System.Drawing.Size(157, 28);
            this.btn_GravarCaminho.TabIndex = 2;
            this.btn_GravarCaminho.Text = "Grava Caminho";
            this.btn_GravarCaminho.UseVisualStyleBackColor = true;
            this.btn_GravarCaminho.Click += new System.EventHandler(this.btn_GravarCaminho_Click);
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.Location = new System.Drawing.Point(41, 77);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(73, 28);
            this.btn_Abrir.TabIndex = 2;
            this.btn_Abrir.Text = "Abrir";
            this.btn_Abrir.UseVisualStyleBackColor = true;
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // txt_Caminho
            // 
            this.txt_Caminho.Location = new System.Drawing.Point(41, 44);
            this.txt_Caminho.Name = "txt_Caminho";
            this.txt_Caminho.Size = new System.Drawing.Size(381, 27);
            this.txt_Caminho.TabIndex = 1;
            // 
            // grp_GravaCaminho
            // 
            this.grp_GravaCaminho.Controls.Add(this.lbl_CaminhoGravado);
            this.grp_GravaCaminho.Controls.Add(this.txt_CaminhoGravado);
            this.grp_GravaCaminho.Controls.Add(this.btn_CaminhoGravado);
            this.grp_GravaCaminho.Location = new System.Drawing.Point(12, 372);
            this.grp_GravaCaminho.Name = "grp_GravaCaminho";
            this.grp_GravaCaminho.Size = new System.Drawing.Size(449, 114);
            this.grp_GravaCaminho.TabIndex = 2;
            this.grp_GravaCaminho.TabStop = false;
            this.grp_GravaCaminho.Text = "Caminho gravado";
            // 
            // lbl_CaminhoGravado
            // 
            this.lbl_CaminhoGravado.AutoSize = true;
            this.lbl_CaminhoGravado.Location = new System.Drawing.Point(23, 26);
            this.lbl_CaminhoGravado.Name = "lbl_CaminhoGravado";
            this.lbl_CaminhoGravado.Size = new System.Drawing.Size(172, 18);
            this.lbl_CaminhoGravado.TabIndex = 0;
            this.lbl_CaminhoGravado.Text = "Caminho do Arquivo";
            // 
            // txt_CaminhoGravado
            // 
            this.txt_CaminhoGravado.Location = new System.Drawing.Point(41, 47);
            this.txt_CaminhoGravado.Name = "txt_CaminhoGravado";
            this.txt_CaminhoGravado.Size = new System.Drawing.Size(381, 27);
            this.txt_CaminhoGravado.TabIndex = 1;
            // 
            // btn_CaminhoGravado
            // 
            this.btn_CaminhoGravado.Location = new System.Drawing.Point(41, 80);
            this.btn_CaminhoGravado.Name = "btn_CaminhoGravado";
            this.btn_CaminhoGravado.Size = new System.Drawing.Size(167, 28);
            this.btn_CaminhoGravado.TabIndex = 2;
            this.btn_CaminhoGravado.Text = "Caminho gravado";
            this.btn_CaminhoGravado.UseVisualStyleBackColor = true;
            this.btn_CaminhoGravado.Click += new System.EventHandler(this.btn_CaminhoGravado_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frm_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 498);
            this.Controls.Add(this.grp_GravaCaminho);
            this.Controls.Add(this.grp_LeCaminho);
            this.Controls.Add(this.grp_GravandoNoRegistro);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Frm_Registro";
            this.Text = "Salvando em Registro";
            this.grp_GravandoNoRegistro.ResumeLayout(false);
            this.grp_GravandoNoRegistro.PerformLayout();
            this.grp_LeCaminho.ResumeLayout(false);
            this.grp_LeCaminho.PerformLayout();
            this.grp_GravaCaminho.ResumeLayout(false);
            this.grp_GravaCaminho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_GravandoNoRegistro;
        private System.Windows.Forms.Button btn_ExcluirRegistro;
        private System.Windows.Forms.Button btn_LendoRegistro;
        private System.Windows.Forms.Button btn_CriarCaminho;
        private System.Windows.Forms.TextBox txt_LendoRegistro;
        private System.Windows.Forms.Label lbl_LendoRegistro;
        private System.Windows.Forms.TextBox txt_ValorRegistro;
        private System.Windows.Forms.Label lbl_ValorRegistro;
        private System.Windows.Forms.GroupBox grp_LeCaminho;
        private System.Windows.Forms.Label lbl_Caminho;
        private System.Windows.Forms.Button btn_GravarCaminho;
        private System.Windows.Forms.Button btn_Abrir;
        private System.Windows.Forms.TextBox txt_Caminho;
        private System.Windows.Forms.GroupBox grp_GravaCaminho;
        private System.Windows.Forms.Label lbl_CaminhoGravado;
        private System.Windows.Forms.TextBox txt_CaminhoGravado;
        private System.Windows.Forms.Button btn_CaminhoGravado;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

