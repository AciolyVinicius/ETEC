namespace SAGA
{
    partial class frm_perfil
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
            this.btn_avisos = new System.Windows.Forms.Button();
            this.btn_frequencia = new System.Windows.Forms.Button();
            this.btn_notas = new System.Windows.Forms.Button();
            this.btn_saga = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_avisos
            // 
            this.btn_avisos.BackColor = System.Drawing.Color.Transparent;
            this.btn_avisos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_avisos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_avisos.Location = new System.Drawing.Point(12, 254);
            this.btn_avisos.Name = "btn_avisos";
            this.btn_avisos.Size = new System.Drawing.Size(261, 35);
            this.btn_avisos.TabIndex = 42;
            this.btn_avisos.Text = "Avisos";
            this.btn_avisos.UseVisualStyleBackColor = false;
            this.btn_avisos.Click += new System.EventHandler(this.btn_avisos_Click);
            // 
            // btn_frequencia
            // 
            this.btn_frequencia.BackColor = System.Drawing.Color.Transparent;
            this.btn_frequencia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_frequencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_frequencia.Location = new System.Drawing.Point(12, 179);
            this.btn_frequencia.Name = "btn_frequencia";
            this.btn_frequencia.Size = new System.Drawing.Size(261, 35);
            this.btn_frequencia.TabIndex = 44;
            this.btn_frequencia.Text = "Frequência";
            this.btn_frequencia.UseVisualStyleBackColor = false;
            this.btn_frequencia.Click += new System.EventHandler(this.btn_frequencia_Click);
            // 
            // btn_notas
            // 
            this.btn_notas.BackColor = System.Drawing.Color.Transparent;
            this.btn_notas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_notas.Location = new System.Drawing.Point(12, 95);
            this.btn_notas.Name = "btn_notas";
            this.btn_notas.Size = new System.Drawing.Size(261, 35);
            this.btn_notas.TabIndex = 45;
            this.btn_notas.Text = "Notas";
            this.btn_notas.UseVisualStyleBackColor = false;
            this.btn_notas.Click += new System.EventHandler(this.btn_notas_Click);
            // 
            // btn_saga
            // 
            this.btn_saga.BackColor = System.Drawing.Color.Transparent;
            this.btn_saga.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_saga.Location = new System.Drawing.Point(298, 12);
            this.btn_saga.Name = "btn_saga";
            this.btn_saga.Size = new System.Drawing.Size(99, 42);
            this.btn_saga.TabIndex = 39;
            this.btn_saga.Text = "S.A.G.A.";
            this.btn_saga.UseVisualStyleBackColor = false;
            this.btn_saga.Click += new System.EventHandler(this.btn_saga_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_nome.Location = new System.Drawing.Point(347, 98);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(165, 32);
            this.lbl_nome.TabIndex = 46;
            this.lbl_nome.Text = "__________";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_email.Location = new System.Drawing.Point(347, 204);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(165, 32);
            this.lbl_email.TabIndex = 46;
            this.lbl_email.Text = "__________";
            // 
            // frm_perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::SAGA.Properties.Resources.Note1;
            this.ClientSize = new System.Drawing.Size(668, 355);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_avisos);
            this.Controls.Add(this.btn_frequencia);
            this.Controls.Add(this.btn_notas);
            this.Controls.Add(this.btn_saga);
            this.Name = "frm_perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAGA - Perfil";
            this.Load += new System.EventHandler(this.frm_perfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_avisos;
        private System.Windows.Forms.Button btn_frequencia;
        private System.Windows.Forms.Button btn_notas;
        private System.Windows.Forms.Button btn_saga;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_email;
    }
}