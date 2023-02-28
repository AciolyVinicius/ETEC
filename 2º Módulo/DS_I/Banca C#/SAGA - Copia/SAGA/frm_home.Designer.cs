namespace SAGA
{
    partial class frm_home
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
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_saga = new System.Windows.Forms.Label();
            this.lbl_resto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_login.Location = new System.Drawing.Point(772, 12);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 50);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_saga
            // 
            this.lbl_saga.AutoSize = true;
            this.lbl_saga.BackColor = System.Drawing.Color.Transparent;
            this.lbl_saga.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_saga.Location = new System.Drawing.Point(284, 166);
            this.lbl_saga.Name = "lbl_saga";
            this.lbl_saga.Size = new System.Drawing.Size(312, 107);
            this.lbl_saga.TabIndex = 1;
            this.lbl_saga.Text = "SAGA";
            // 
            // lbl_resto
            // 
            this.lbl_resto.AutoSize = true;
            this.lbl_resto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_resto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_resto.Location = new System.Drawing.Point(260, 298);
            this.lbl_resto.Name = "lbl_resto";
            this.lbl_resto.Size = new System.Drawing.Size(380, 24);
            this.lbl_resto.TabIndex = 2;
            this.lbl_resto.Text = "Aquele irá lhe ajudar na sua S.A.G.A.";
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::SAGA.Properties.Resources.criativo;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lbl_resto);
            this.Controls.Add(this.lbl_saga);
            this.Controls.Add(this.btn_login);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S.A.G.A. - Sistema de Aprendizagem e Gestão Acadêmica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_saga;
        private System.Windows.Forms.Label lbl_resto;
    }
}

