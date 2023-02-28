namespace Multiforms_28_09_2017
{
    partial class Frm_Terceiro
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
            this.txt_output = new System.Windows.Forms.TextBox();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_segundo = new System.Windows.Forms.Button();
            this.btn_principal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(152, 50);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(100, 20);
            this.txt_output.TabIndex = 6;
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(33, 50);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(100, 20);
            this.txt_input.TabIndex = 5;
            this.txt_input.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            // 
            // btn_segundo
            // 
            this.btn_segundo.Location = new System.Drawing.Point(163, 92);
            this.btn_segundo.Name = "btn_segundo";
            this.btn_segundo.Size = new System.Drawing.Size(75, 23);
            this.btn_segundo.TabIndex = 3;
            this.btn_segundo.Text = "Segundo";
            this.btn_segundo.UseVisualStyleBackColor = true;
            this.btn_segundo.Click += new System.EventHandler(this.btn_segundo_Click);
            // 
            // btn_principal
            // 
            this.btn_principal.Location = new System.Drawing.Point(47, 92);
            this.btn_principal.Name = "btn_principal";
            this.btn_principal.Size = new System.Drawing.Size(75, 23);
            this.btn_principal.TabIndex = 4;
            this.btn_principal.Text = "Principal";
            this.btn_principal.UseVisualStyleBackColor = true;
            this.btn_principal.Click += new System.EventHandler(this.btn_principal_Click);
            // 
            // Frm_Terceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 165);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.btn_segundo);
            this.Controls.Add(this.btn_principal);
            this.Name = "Frm_Terceiro";
            this.Text = "Frm_Terceiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_segundo;
        private System.Windows.Forms.Button btn_principal;
    }
}