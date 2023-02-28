namespace SAGA
{
    partial class frm_saga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_saga));
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_saga = new System.Windows.Forms.Label();
            this.lbl_saga2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_login.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(245, 232);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(167, 57);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_saga
            // 
            this.lbl_saga.AutoSize = true;
            this.lbl_saga.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saga.Location = new System.Drawing.Point(254, 25);
            this.lbl_saga.Name = "lbl_saga";
            this.lbl_saga.Size = new System.Drawing.Size(122, 32);
            this.lbl_saga.TabIndex = 2;
            this.lbl_saga.Text = "S.A.G.A.";
            // 
            // lbl_saga2
            // 
            this.lbl_saga2.AutoSize = true;
            this.lbl_saga2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saga2.Location = new System.Drawing.Point(82, 66);
            this.lbl_saga2.Name = "lbl_saga2";
            this.lbl_saga2.Size = new System.Drawing.Size(451, 24);
            this.lbl_saga2.TabIndex = 3;
            this.lbl_saga2.Text = "Sistema de Aprendizagem e Gestão Acadêmica";
            // 
            // frm_saga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(616, 440);
            this.Controls.Add(this.lbl_saga2);
            this.Controls.Add(this.lbl_saga);
            this.Controls.Add(this.btn_login);
            this.MaximizeBox = false;
            this.Name = "frm_saga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S.A.G.A. - Sistema de Aprendizagem e Gestão Acadêmica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_saga;
        private System.Windows.Forms.Label lbl_saga2;
    }
}

