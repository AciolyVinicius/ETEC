namespace Multiforms_28_09_2017
{
    partial class Frm_Segundo
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
            this.btn_principal = new System.Windows.Forms.Button();
            this.btn_terceiro = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_principal
            // 
            this.btn_principal.Location = new System.Drawing.Point(41, 100);
            this.btn_principal.Name = "btn_principal";
            this.btn_principal.Size = new System.Drawing.Size(75, 23);
            this.btn_principal.TabIndex = 0;
            this.btn_principal.Text = "Principal";
            this.btn_principal.UseVisualStyleBackColor = true;
            this.btn_principal.Click += new System.EventHandler(this.btn_principal_Click);
            // 
            // btn_terceiro
            // 
            this.btn_terceiro.Location = new System.Drawing.Point(157, 100);
            this.btn_terceiro.Name = "btn_terceiro";
            this.btn_terceiro.Size = new System.Drawing.Size(75, 23);
            this.btn_terceiro.TabIndex = 0;
            this.btn_terceiro.Text = "Terceiro";
            this.btn_terceiro.UseVisualStyleBackColor = true;
            this.btn_terceiro.Click += new System.EventHandler(this.btn_terceiro_Click);
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(27, 58);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(100, 20);
            this.txt_input.TabIndex = 1;
            this.txt_input.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(146, 58);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(100, 20);
            this.txt_output.TabIndex = 2;
            // 
            // Frm_Segundo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 178);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.btn_terceiro);
            this.Controls.Add(this.btn_principal);
            this.Name = "Frm_Segundo";
            this.Text = "Frm_Segundo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_principal;
        private System.Windows.Forms.Button btn_terceiro;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_output;
    }
}