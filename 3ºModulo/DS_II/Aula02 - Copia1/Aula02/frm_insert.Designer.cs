namespace Aula02
{
    partial class Frm_insert
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_PasswordInsert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UsuarioInsert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_confirm = new System.Windows.Forms.Label();
            this.txt_ConfirmInsert = new System.Windows.Forms.TextBox();
            this.lbl_MessageInsert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(206, 265);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 41);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(16, 265);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 41);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_PasswordInsert
            // 
            this.txt_PasswordInsert.Location = new System.Drawing.Point(16, 104);
            this.txt_PasswordInsert.MaxLength = 10;
            this.txt_PasswordInsert.Name = "txt_PasswordInsert";
            this.txt_PasswordInsert.Size = new System.Drawing.Size(265, 26);
            this.txt_PasswordInsert.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(108, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha";
            // 
            // txt_UsuarioInsert
            // 
            this.txt_UsuarioInsert.Location = new System.Drawing.Point(16, 38);
            this.txt_UsuarioInsert.MaxLength = 10;
            this.txt_UsuarioInsert.Name = "txt_UsuarioInsert";
            this.txt_UsuarioInsert.Size = new System.Drawing.Size(265, 26);
            this.txt_UsuarioInsert.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuário";
            // 
            // lbl_confirm
            // 
            this.lbl_confirm.AutoSize = true;
            this.lbl_confirm.Location = new System.Drawing.Point(85, 141);
            this.lbl_confirm.Name = "lbl_confirm";
            this.lbl_confirm.Size = new System.Drawing.Size(98, 18);
            this.lbl_confirm.TabIndex = 16;
            this.lbl_confirm.Text = "Confirmação";
            this.lbl_confirm.Click += new System.EventHandler(this.lbl_confirm_Click);
            // 
            // txt_ConfirmInsert
            // 
            this.txt_ConfirmInsert.Location = new System.Drawing.Point(16, 170);
            this.txt_ConfirmInsert.MaxLength = 10;
            this.txt_ConfirmInsert.Name = "txt_ConfirmInsert";
            this.txt_ConfirmInsert.Size = new System.Drawing.Size(265, 26);
            this.txt_ConfirmInsert.TabIndex = 3;
            this.txt_ConfirmInsert.TextChanged += new System.EventHandler(this.txt_ConfirmInsert_TextChanged);
            // 
            // lbl_MessageInsert
            // 
            this.lbl_MessageInsert.AutoSize = true;
            this.lbl_MessageInsert.Location = new System.Drawing.Point(13, 216);
            this.lbl_MessageInsert.Name = "lbl_MessageInsert";
            this.lbl_MessageInsert.Size = new System.Drawing.Size(0, 18);
            this.lbl_MessageInsert.TabIndex = 18;
            // 
            // Frm_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 318);
            this.Controls.Add(this.lbl_MessageInsert);
            this.Controls.Add(this.txt_ConfirmInsert);
            this.Controls.Add(this.lbl_confirm);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_PasswordInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_UsuarioInsert);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_insert";
            this.Load += new System.EventHandler(this.Frm_insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_PasswordInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UsuarioInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_confirm;
        private System.Windows.Forms.TextBox txt_ConfirmInsert;
        private System.Windows.Forms.Label lbl_MessageInsert;
    }
}