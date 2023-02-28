namespace Aula07_Criptografia
{
    partial class Frm_Cripto
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
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cripto = new System.Windows.Forms.Button();
            this.btn_Descripto = new System.Windows.Forms.Button();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(118, 53);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(527, 29);
            this.txt_Input.TabIndex = 0;
            // 
            // txt_Key
            // 
            this.txt_Key.Location = new System.Drawing.Point(118, 106);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.Size = new System.Drawing.Size(527, 29);
            this.txt_Key.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "INPUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "KEY";
            // 
            // btn_Cripto
            // 
            this.btn_Cripto.Location = new System.Drawing.Point(45, 181);
            this.btn_Cripto.Name = "btn_Cripto";
            this.btn_Cripto.Size = new System.Drawing.Size(220, 35);
            this.btn_Cripto.TabIndex = 4;
            this.btn_Cripto.Text = "CRIPTOGRAFAR";
            this.btn_Cripto.UseVisualStyleBackColor = true;
            this.btn_Cripto.Click += new System.EventHandler(this.btn_Cripto_Click);
            // 
            // btn_Descripto
            // 
            this.btn_Descripto.Location = new System.Drawing.Point(399, 181);
            this.btn_Descripto.Name = "btn_Descripto";
            this.btn_Descripto.Size = new System.Drawing.Size(220, 35);
            this.btn_Descripto.TabIndex = 4;
            this.btn_Descripto.Text = "DESCRIPTOGRAFAR";
            this.btn_Descripto.UseVisualStyleBackColor = true;
            this.btn_Descripto.Click += new System.EventHandler(this.btn_Descripto_Click);
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(12, 259);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.Size = new System.Drawing.Size(633, 29);
            this.txt_Output.TabIndex = 5;
            // 
            // Frm_Cripto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 300);
            this.Controls.Add(this.txt_Output);
            this.Controls.Add(this.btn_Descripto);
            this.Controls.Add(this.btn_Cripto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Key);
            this.Controls.Add(this.txt_Input);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Frm_Cripto";
            this.Text = "Criptografia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.TextBox txt_Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cripto;
        private System.Windows.Forms.Button btn_Descripto;
        private System.Windows.Forms.TextBox txt_Output;
    }
}

