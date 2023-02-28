namespace Aula02
{
    partial class Frm_Full
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
            this.btn_zerar = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.txt_Confirm = new System.Windows.Forms.TextBox();
            this.lbl_Confirm = new System.Windows.Forms.Label();
            this.dtg_Usuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_zerar
            // 
            this.btn_zerar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_zerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zerar.Location = new System.Drawing.Point(300, 257);
            this.btn_zerar.Name = "btn_zerar";
            this.btn_zerar.Size = new System.Drawing.Size(90, 31);
            this.btn_zerar.TabIndex = 6;
            this.btn_zerar.Text = "Zerar";
            this.btn_zerar.UseVisualStyleBackColor = true;
            this.btn_zerar.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(396, 257);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(90, 31);
            this.Button2.TabIndex = 7;
            this.Button2.Text = "Cancelar";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(204, 257);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(90, 31);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.Location = new System.Drawing.Point(97, 28);
            this.txt_Usuario.MaxLength = 9;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(135, 29);
            this.txt_Usuario.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(4, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(87, 24);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Usuário:";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(350, 9);
            this.txt_Password.MaxLength = 9;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(135, 29);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.Visible = false;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(238, 14);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(106, 24);
            this.lbl_Password.TabIndex = 10;
            this.lbl_Password.Text = "Password:";
            this.lbl_Password.Visible = false;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(108, 257);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(90, 31);
            this.btn_Excluir.TabIndex = 4;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Incluir.Location = new System.Drawing.Point(12, 257);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(90, 31);
            this.btn_Incluir.TabIndex = 3;
            this.btn_Incluir.Text = "Incluir";
            this.btn_Incluir.UseVisualStyleBackColor = true;
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // txt_Confirm
            // 
            this.txt_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Confirm.Location = new System.Drawing.Point(350, 44);
            this.txt_Confirm.MaxLength = 9;
            this.txt_Confirm.Name = "txt_Confirm";
            this.txt_Confirm.Size = new System.Drawing.Size(135, 29);
            this.txt_Confirm.TabIndex = 2;
            this.txt_Confirm.Visible = false;
            // 
            // lbl_Confirm
            // 
            this.lbl_Confirm.AutoSize = true;
            this.lbl_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm.Location = new System.Drawing.Point(238, 49);
            this.lbl_Confirm.Name = "lbl_Confirm";
            this.lbl_Confirm.Size = new System.Drawing.Size(108, 24);
            this.lbl_Confirm.TabIndex = 11;
            this.lbl_Confirm.Text = "Re-Check:";
            this.lbl_Confirm.Visible = false;
            // 
            // dtg_Usuario
            // 
            this.dtg_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Usuario.Location = new System.Drawing.Point(12, 79);
            this.dtg_Usuario.Name = "dtg_Usuario";
            this.dtg_Usuario.ReadOnly = true;
            this.dtg_Usuario.Size = new System.Drawing.Size(474, 172);
            this.dtg_Usuario.TabIndex = 8;
            this.dtg_Usuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtg_Usuario_MouseClick);
            // 
            // Frm_Full
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 298);
            this.ControlBox = false;
            this.Controls.Add(this.dtg_Usuario);
            this.Controls.Add(this.txt_Confirm);
            this.Controls.Add(this.lbl_Confirm);
            this.Controls.Add(this.btn_Incluir);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.btn_zerar);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.Label1);
            this.Name = "Frm_Full";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicação Full";
            this.Load += new System.EventHandler(this.Frm_Full_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_zerar;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button btn_Update;
        internal System.Windows.Forms.TextBox txt_Usuario;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txt_Password;
        internal System.Windows.Forms.Label lbl_Password;
        internal System.Windows.Forms.Button btn_Excluir;
        internal System.Windows.Forms.Button btn_Incluir;
        internal System.Windows.Forms.TextBox txt_Confirm;
        internal System.Windows.Forms.Label lbl_Confirm;
        private System.Windows.Forms.DataGridView dtg_Usuario;
    }
}