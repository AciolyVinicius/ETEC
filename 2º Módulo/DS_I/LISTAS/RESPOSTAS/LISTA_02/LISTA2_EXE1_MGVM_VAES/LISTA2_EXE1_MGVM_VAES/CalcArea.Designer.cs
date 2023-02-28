namespace LISTA2_EXE1_MGVM_VAES
{
    partial class lbl_CalcArea
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
            this.lbl_info = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.lbl_base = new System.Windows.Forms.Label();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_Area = new System.Windows.Forms.Label();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_enunciado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(10, 9);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(490, 16);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "Calculadora de área de um quadrado ou retângulo em metros quadradados";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(13, 94);
            this.txt_n1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n1.MaxLength = 4;
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(132, 22);
            this.txt_n1.TabIndex = 1;
            this.txt_n1.TextChanged += new System.EventHandler(this.txt_n1_TextChanged);
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(171, 94);
            this.txt_n2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_n2.MaxLength = 4;
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(132, 22);
            this.txt_n2.TabIndex = 2;
            // 
            // lbl_base
            // 
            this.lbl_base.AutoSize = true;
            this.lbl_base.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_base.Location = new System.Drawing.Point(13, 67);
            this.lbl_base.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_base.Name = "lbl_base";
            this.lbl_base.Size = new System.Drawing.Size(100, 16);
            this.lbl_base.TabIndex = 3;
            this.lbl_base.Text = "Base da figura";
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(168, 67);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(107, 16);
            this.lbl_altura.TabIndex = 4;
            this.lbl_altura.Text = "Altura da figura";
            // 
            // lbl_Area
            // 
            this.lbl_Area.AutoSize = true;
            this.lbl_Area.Location = new System.Drawing.Point(13, 152);
            this.lbl_Area.Name = "lbl_Area";
            this.lbl_Area.Size = new System.Drawing.Size(38, 16);
            this.lbl_Area.TabIndex = 5;
            this.lbl_Area.Text = "Área";
            // 
            // txt_area
            // 
            this.txt_area.Enabled = false;
            this.txt_area.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_area.ForeColor = System.Drawing.Color.Black;
            this.txt_area.Location = new System.Drawing.Point(12, 171);
            this.txt_area.Name = "txt_area";
            this.txt_area.ReadOnly = true;
            this.txt_area.Size = new System.Drawing.Size(291, 26);
            this.txt_area.TabIndex = 6;
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(326, 94);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(97, 23);
            this.btn_enter.TabIndex = 7;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_enunciado
            // 
            this.btn_enunciado.Location = new System.Drawing.Point(401, 174);
            this.btn_enunciado.Name = "btn_enunciado";
            this.btn_enunciado.Size = new System.Drawing.Size(89, 23);
            this.btn_enunciado.TabIndex = 8;
            this.btn_enunciado.Text = "Enunciado";
            this.btn_enunciado.UseVisualStyleBackColor = true;
            this.btn_enunciado.Click += new System.EventHandler(this.btn_enunciado_Click);
            // 
            // lbl_CalcArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 209);
            this.Controls.Add(this.btn_enunciado);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.lbl_Area);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.lbl_base);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_info);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "lbl_CalcArea";
            this.Text = "Calculando Área";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.Label lbl_base;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_Area;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_enunciado;
    }
}

