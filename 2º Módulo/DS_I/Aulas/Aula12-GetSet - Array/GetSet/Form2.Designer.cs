namespace GetSet
{
    partial class Form2
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
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.lst_Lista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(68, 31);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "label1";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Location = new System.Drawing.Point(71, 60);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(35, 13);
            this.lbl_Numero.TabIndex = 1;
            this.lbl_Numero.Text = "label2";
            // 
            // lst_Lista
            // 
            this.lst_Lista.FormattingEnabled = true;
            this.lst_Lista.Location = new System.Drawing.Point(131, 12);
            this.lst_Lista.Name = "lst_Lista";
            this.lst_Lista.Size = new System.Drawing.Size(120, 95);
            this.lst_Lista.TabIndex = 2;
            this.lst_Lista.SelectedIndexChanged += new System.EventHandler(this.lst_Lista_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 114);
            this.Controls.Add(this.lst_Lista);
            this.Controls.Add(this.lbl_Numero);
            this.Controls.Add(this.lbl_Nome);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.ListBox lst_Lista;
    }
}