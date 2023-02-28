namespace Separador
{
    partial class Frm_separador
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_token = new System.Windows.Forms.TextBox();
            this.btn_separador = new System.Windows.Forms.Button();
            this.lst_separar = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(78, 15);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(260, 26);
            this.txt_input.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Token";
            // 
            // txt_token
            // 
            this.txt_token.Location = new System.Drawing.Point(77, 54);
            this.txt_token.MaxLength = 1;
            this.txt_token.Name = "txt_token";
            this.txt_token.Size = new System.Drawing.Size(100, 26);
            this.txt_token.TabIndex = 3;
            // 
            // btn_separador
            // 
            this.btn_separador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_separador.Location = new System.Drawing.Point(183, 51);
            this.btn_separador.Name = "btn_separador";
            this.btn_separador.Size = new System.Drawing.Size(155, 29);
            this.btn_separador.TabIndex = 4;
            this.btn_separador.Text = "SEPARADOR";
            this.btn_separador.UseVisualStyleBackColor = true;
            this.btn_separador.Click += new System.EventHandler(this.btn_separador_Click);
            // 
            // lst_separar
            // 
            this.lst_separar.FormattingEnabled = true;
            this.lst_separar.ItemHeight = 18;
            this.lst_separar.Location = new System.Drawing.Point(12, 110);
            this.lst_separar.Name = "lst_separar";
            this.lst_separar.Size = new System.Drawing.Size(326, 130);
            this.lst_separar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output";
            // 
            // Frm_separador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 252);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_separar);
            this.Controls.Add(this.btn_separador);
            this.Controls.Add(this.txt_token);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_separador";
            this.Text = "Separador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_token;
        private System.Windows.Forms.Button btn_separador;
        private System.Windows.Forms.ListBox lst_separar;
        private System.Windows.Forms.Label label3;
    }
}

