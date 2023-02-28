namespace Multiforms_28_09_2017
{
    partial class Frm_Principal
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
            this.btn_segundo = new System.Windows.Forms.Button();
            this.btn_terceiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_segundo
            // 
            this.btn_segundo.Location = new System.Drawing.Point(37, 66);
            this.btn_segundo.Name = "btn_segundo";
            this.btn_segundo.Size = new System.Drawing.Size(75, 23);
            this.btn_segundo.TabIndex = 0;
            this.btn_segundo.Text = "Segundo";
            this.btn_segundo.UseVisualStyleBackColor = true;
            this.btn_segundo.Click += new System.EventHandler(this.btn_segundo_Click);
            // 
            // btn_terceiro
            // 
            this.btn_terceiro.Location = new System.Drawing.Point(170, 66);
            this.btn_terceiro.Name = "btn_terceiro";
            this.btn_terceiro.Size = new System.Drawing.Size(75, 23);
            this.btn_terceiro.TabIndex = 1;
            this.btn_terceiro.Text = "Terceiro";
            this.btn_terceiro.UseVisualStyleBackColor = true;
            this.btn_terceiro.Click += new System.EventHandler(this.btn_terceiro_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.Controls.Add(this.btn_terceiro);
            this.Controls.Add(this.btn_segundo);
            this.Name = "Frm_Principal";
            this.Text = "Frm_Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_segundo;
        private System.Windows.Forms.Button btn_terceiro;
    }
}