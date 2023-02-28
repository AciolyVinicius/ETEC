namespace Aula02
{
    partial class Frm_Delete
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
            this.btn_Ptbd = new System.Windows.Forms.Button();
            this.btn_Pesquisa = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Ptbd
            // 
            this.btn_Ptbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ptbd.Location = new System.Drawing.Point(5, 7);
            this.btn_Ptbd.Name = "btn_Ptbd";
            this.btn_Ptbd.Size = new System.Drawing.Size(42, 15);
            this.btn_Ptbd.TabIndex = 29;
            this.btn_Ptbd.Text = "PT-BD";
            this.btn_Ptbd.UseVisualStyleBackColor = true;
            this.btn_Ptbd.Click += new System.EventHandler(this.btn_Ptbd_Click_1);
            // 
            // btn_Pesquisa
            // 
            this.btn_Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisa.Location = new System.Drawing.Point(5, 227);
            this.btn_Pesquisa.Name = "btn_Pesquisa";
            this.btn_Pesquisa.Size = new System.Drawing.Size(110, 31);
            this.btn_Pesquisa.TabIndex = 23;
            this.btn_Pesquisa.Text = "Pesquisa";
            this.btn_Pesquisa.UseVisualStyleBackColor = true;
            this.btn_Pesquisa.Click += new System.EventHandler(this.btn_Pesquisa_Click_1);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(227, 227);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 31);
            this.btn_Back.TabIndex = 25;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click_1);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deletar.Location = new System.Drawing.Point(121, 227);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(100, 31);
            this.btn_Deletar.TabIndex = 24;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click_1);
            // 
            // lbl_Message
            // 
            this.lbl_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.ForeColor = System.Drawing.Color.Red;
            this.lbl_Message.Location = new System.Drawing.Point(12, 177);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(308, 24);
            this.lbl_Message.TabIndex = 28;
            this.lbl_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(79, 115);
            this.txt_Password.MaxLength = 9;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(174, 29);
            this.txt_Password.TabIndex = 22;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(75, 88);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 24);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "Password";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.Location = new System.Drawing.Point(79, 34);
            this.txt_Usuario.MaxLength = 9;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(174, 29);
            this.txt_Usuario.TabIndex = 21;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(75, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(81, 24);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "Usuário";
            // 
            // Frm_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 264);
            this.Controls.Add(this.btn_Ptbd);
            this.Controls.Add(this.btn_Pesquisa);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Frm_Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "- - - DELETE - - - ";
            this.Load += new System.EventHandler(this.Frm_Delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_Ptbd;
        internal System.Windows.Forms.Button btn_Pesquisa;
        internal System.Windows.Forms.Button btn_Back;
        internal System.Windows.Forms.Button btn_Deletar;
        internal System.Windows.Forms.Label lbl_Message;
        internal System.Windows.Forms.TextBox txt_Password;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txt_Usuario;
        internal System.Windows.Forms.Label Label1;

    }
}