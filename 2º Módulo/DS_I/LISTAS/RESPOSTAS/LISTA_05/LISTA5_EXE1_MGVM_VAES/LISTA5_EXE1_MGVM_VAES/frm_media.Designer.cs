namespace LISTA5_EXE1_MGVM_VAES
{
    partial class frm_media
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
            this.btn_end = new System.Windows.Forms.Button();
            this.txt_media = new System.Windows.Forms.TextBox();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.txt_3 = new System.Windows.Forms.TextBox();
            this.txt_4 = new System.Windows.Forms.TextBox();
            this.lbl_media = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(228, 199);
            this.btn_end.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(125, 34);
            this.btn_end.TabIndex = 0;
            this.btn_end.Text = "FINALIZAR";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // txt_media
            // 
            this.txt_media.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_media.Enabled = false;
            this.txt_media.Location = new System.Drawing.Point(212, 272);
            this.txt_media.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_media.MaxLength = 2;
            this.txt_media.Name = "txt_media";
            this.txt_media.Size = new System.Drawing.Size(164, 26);
            this.txt_media.TabIndex = 1;
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(212, 22);
            this.txt_1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_1.MaxLength = 3;
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(164, 26);
            this.txt_1.TabIndex = 2;
            this.txt_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_1_KeyPress);
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(212, 60);
            this.txt_2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_2.MaxLength = 3;
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(164, 26);
            this.txt_2.TabIndex = 2;
            this.txt_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_2_KeyPress);
            // 
            // txt_3
            // 
            this.txt_3.Location = new System.Drawing.Point(212, 98);
            this.txt_3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_3.MaxLength = 3;
            this.txt_3.Name = "txt_3";
            this.txt_3.Size = new System.Drawing.Size(164, 26);
            this.txt_3.TabIndex = 2;
            this.txt_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_3_KeyPress);
            // 
            // txt_4
            // 
            this.txt_4.Location = new System.Drawing.Point(212, 136);
            this.txt_4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_4.MaxLength = 3;
            this.txt_4.Name = "txt_4";
            this.txt_4.Size = new System.Drawing.Size(164, 26);
            this.txt_4.TabIndex = 2;
            this.txt_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_4_KeyPress);
            // 
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_media.Location = new System.Drawing.Point(265, 336);
            this.lbl_media.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(0, 13);
            this.lbl_media.TabIndex = 3;
            this.lbl_media.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(458, 322);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(125, 34);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // frm_media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 376);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_media);
            this.Controls.Add(this.txt_4);
            this.Controls.Add(this.txt_3);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.txt_media);
            this.Controls.Add(this.btn_end);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_media";
            this.Text = "Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.TextBox txt_media;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.TextBox txt_3;
        private System.Windows.Forms.TextBox txt_4;
        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.Button btn_voltar;
    }
}