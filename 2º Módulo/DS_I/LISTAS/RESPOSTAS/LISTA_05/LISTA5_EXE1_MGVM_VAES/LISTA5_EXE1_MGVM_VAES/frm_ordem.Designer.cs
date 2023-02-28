namespace LISTA5_EXE1_MGVM_VAES
{
    partial class frm_ordem
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
            this.txt_um = new System.Windows.Forms.TextBox();
            this.txt_dois = new System.Windows.Forms.TextBox();
            this.txt_tres = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_um
            // 
            this.txt_um.Location = new System.Drawing.Point(83, 58);
            this.txt_um.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_um.MaxLength = 4;
            this.txt_um.Name = "txt_um";
            this.txt_um.Size = new System.Drawing.Size(292, 26);
            this.txt_um.TabIndex = 0;
            this.txt_um.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_um_KeyPress);
            // 
            // txt_dois
            // 
            this.txt_dois.Location = new System.Drawing.Point(83, 118);
            this.txt_dois.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_dois.MaxLength = 4;
            this.txt_dois.Name = "txt_dois";
            this.txt_dois.Size = new System.Drawing.Size(291, 26);
            this.txt_dois.TabIndex = 1;
            this.txt_dois.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dois_KeyPress);
            // 
            // txt_tres
            // 
            this.txt_tres.Location = new System.Drawing.Point(83, 181);
            this.txt_tres.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_tres.MaxLength = 4;
            this.txt_tres.Name = "txt_tres";
            this.txt_tres.Size = new System.Drawing.Size(291, 26);
            this.txt_tres.TabIndex = 2;
            this.txt_tres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tres_KeyPress);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(328, 273);
            this.btn_back.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(125, 34);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "VOLTAR";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(170, 219);
            this.btn_enter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(125, 34);
            this.btn_enter.TabIndex = 5;
            this.btn_enter.Text = "ENTER";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click_1);
            // 
            // frm_ordem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 324);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_tres);
            this.Controls.Add(this.txt_dois);
            this.Controls.Add(this.txt_um);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_ordem";
            this.Text = "Ordem Crescente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_um;
        private System.Windows.Forms.TextBox txt_dois;
        private System.Windows.Forms.TextBox txt_tres;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_enter;
    }
}