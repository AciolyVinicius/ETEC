namespace WorkFile
{
    partial class FrmDiretorio
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
            this.btn_CriaDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DelDir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ListDir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_CriaFile = new System.Windows.Forms.Button();
            this.lst_Relacione = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Properties = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ReadFile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_DelFile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_WriteFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CriaDir
            // 
            this.btn_CriaDir.Location = new System.Drawing.Point(14, 35);
            this.btn_CriaDir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_CriaDir.Name = "btn_CriaDir";
            this.btn_CriaDir.Size = new System.Drawing.Size(113, 32);
            this.btn_CriaDir.TabIndex = 0;
            this.btn_CriaDir.Text = "Códido 1";
            this.btn_CriaDir.UseVisualStyleBackColor = true;
            this.btn_CriaDir.Click += new System.EventHandler(this.btn_CriaDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Criar Diretório";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Excluir Diretório";
            // 
            // btn_DelDir
            // 
            this.btn_DelDir.Location = new System.Drawing.Point(14, 117);
            this.btn_DelDir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_DelDir.Name = "btn_DelDir";
            this.btn_DelDir.Size = new System.Drawing.Size(113, 32);
            this.btn_DelDir.TabIndex = 2;
            this.btn_DelDir.Text = "Código 2";
            this.btn_DelDir.UseVisualStyleBackColor = true;
            this.btn_DelDir.Click += new System.EventHandler(this.btn_DelDir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Listar Arq. e Dir.";
            // 
            // btn_ListDir
            // 
            this.btn_ListDir.Location = new System.Drawing.Point(14, 198);
            this.btn_ListDir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_ListDir.Name = "btn_ListDir";
            this.btn_ListDir.Size = new System.Drawing.Size(113, 32);
            this.btn_ListDir.TabIndex = 4;
            this.btn_ListDir.Text = " Código 3";
            this.btn_ListDir.UseVisualStyleBackColor = true;
            this.btn_ListDir.Click += new System.EventHandler(this.btn_ListDir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Criar Arquivo";
            // 
            // btn_CriaFile
            // 
            this.btn_CriaFile.Location = new System.Drawing.Point(14, 283);
            this.btn_CriaFile.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_CriaFile.Name = "btn_CriaFile";
            this.btn_CriaFile.Size = new System.Drawing.Size(113, 32);
            this.btn_CriaFile.TabIndex = 6;
            this.btn_CriaFile.Text = "Código 4";
            this.btn_CriaFile.UseVisualStyleBackColor = true;
            this.btn_CriaFile.Click += new System.EventHandler(this.btn_CriaFile_Click);
            // 
            // lst_Relacione
            // 
            this.lst_Relacione.FormattingEnabled = true;
            this.lst_Relacione.ItemHeight = 18;
            this.lst_Relacione.Location = new System.Drawing.Point(137, 14);
            this.lst_Relacione.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lst_Relacione.Name = "lst_Relacione";
            this.lst_Relacione.Size = new System.Drawing.Size(371, 328);
            this.lst_Relacione.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Propriedades";
            // 
            // btn_Properties
            // 
            this.btn_Properties.Location = new System.Drawing.Point(518, 283);
            this.btn_Properties.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Properties.Name = "btn_Properties";
            this.btn_Properties.Size = new System.Drawing.Size(113, 32);
            this.btn_Properties.TabIndex = 15;
            this.btn_Properties.Text = "Código 8";
            this.btn_Properties.UseVisualStyleBackColor = true;
            this.btn_Properties.Click += new System.EventHandler(this.btn_Properties_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lendo Arquivo";
            // 
            // btn_ReadFile
            // 
            this.btn_ReadFile.Location = new System.Drawing.Point(518, 198);
            this.btn_ReadFile.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_ReadFile.Name = "btn_ReadFile";
            this.btn_ReadFile.Size = new System.Drawing.Size(113, 32);
            this.btn_ReadFile.TabIndex = 13;
            this.btn_ReadFile.Text = "Código 7";
            this.btn_ReadFile.UseVisualStyleBackColor = true;
            this.btn_ReadFile.Click += new System.EventHandler(this.btn_ReadFile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Excluir Arquivo";
            // 
            // btn_DelFile
            // 
            this.btn_DelFile.Location = new System.Drawing.Point(521, 117);
            this.btn_DelFile.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_DelFile.Name = "btn_DelFile";
            this.btn_DelFile.Size = new System.Drawing.Size(113, 32);
            this.btn_DelFile.TabIndex = 11;
            this.btn_DelFile.Text = "Código 6";
            this.btn_DelFile.UseVisualStyleBackColor = true;
            this.btn_DelFile.Click += new System.EventHandler(this.btn_DelFile_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Escrever Arquivo";
            // 
            // btn_WriteFile
            // 
            this.btn_WriteFile.Location = new System.Drawing.Point(518, 35);
            this.btn_WriteFile.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_WriteFile.Name = "btn_WriteFile";
            this.btn_WriteFile.Size = new System.Drawing.Size(113, 32);
            this.btn_WriteFile.TabIndex = 9;
            this.btn_WriteFile.Text = "Código 5";
            this.btn_WriteFile.UseVisualStyleBackColor = true;
            this.btn_WriteFile.Click += new System.EventHandler(this.btn_WriteFile_Click);
            // 
            // FrmDiretorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 351);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Properties);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_ReadFile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_DelFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_WriteFile);
            this.Controls.Add(this.lst_Relacione);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_CriaFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ListDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_DelDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CriaDir);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmDiretorio";
            this.Text = "Diretorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CriaDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DelDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ListDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_CriaFile;
        private System.Windows.Forms.ListBox lst_Relacione;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Properties;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ReadFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_DelFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_WriteFile;
    }
}

