namespace DeskTabuada
{
    partial class FrmTabuada
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
            this.lstN = new System.Windows.Forms.ListBox();
            this.btnExe = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstN
            // 
            this.lstN.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstN.Enabled = false;
            this.lstN.FormattingEnabled = true;
            this.lstN.Location = new System.Drawing.Point(12, 89);
            this.lstN.Name = "lstN";
            this.lstN.Size = new System.Drawing.Size(260, 160);
            this.lstN.TabIndex = 0;
            // 
            // btnExe
            // 
            this.btnExe.Location = new System.Drawing.Point(12, 60);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(260, 23);
            this.btnExe.TabIndex = 1;
            this.btnExe.Text = "EXECUTAR";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(12, 13);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(260, 20);
            this.txtN.TabIndex = 2;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // FrmTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnExe);
            this.Controls.Add(this.lstN);
            this.Name = "FrmTabuada";
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstN;
        private System.Windows.Forms.Button btnExe;
        private System.Windows.Forms.TextBox txtN;
    }
}

