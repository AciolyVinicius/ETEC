namespace LISTA5_EXE1_MGVM_VAES
{
    partial class frm_imc
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
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(21, 152);
            this.btn_enter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(125, 34);
            this.btn_enter.TabIndex = 0;
            this.btn_enter.Text = "ENTER";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(178, 152);
            this.btn_back.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(125, 34);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "VOLTAR";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(157, 31);
            this.txt_altura.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_altura.MaxLength = 4;
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(191, 26);
            this.txt_altura.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "ALTURA";
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(157, 69);
            this.txt_peso.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_peso.MaxLength = 3;
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(191, 26);
            this.txt_peso.TabIndex = 2;
            this.txt_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_peso_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "PESO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "FÓRMULA UTILIZADA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_imc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 229);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_enter);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_imc";
            this.Text = "IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}