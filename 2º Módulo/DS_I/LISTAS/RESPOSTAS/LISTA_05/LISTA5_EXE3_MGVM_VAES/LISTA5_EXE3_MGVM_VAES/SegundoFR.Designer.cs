namespace LISTA5_EXE3_MGVM_VAES
{
    partial class SegundoFR
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
            this.lbl_segundo = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_segundo
            // 
            this.lbl_segundo.AutoSize = true;
            this.lbl_segundo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_segundo.Location = new System.Drawing.Point(130, 69);
            this.lbl_segundo.Name = "lbl_segundo";
            this.lbl_segundo.Size = new System.Drawing.Size(392, 32);
            this.lbl_segundo.TabIndex = 0;
            this.lbl_segundo.Text = "Programa em Desenvolvimento";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(12, 169);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // SegundoFR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 204);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lbl_segundo);
            this.Name = "SegundoFR";
            this.Text = "SegundoFR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_segundo;
        private System.Windows.Forms.Button btn_voltar;
    }
}