namespace LISTA5_EXE1_MGVM_VAES
{
    partial class frm_menu
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
            this.btn_ordem = new System.Windows.Forms.Button();
            this.btn_media = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_imc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ordem
            // 
            this.btn_ordem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ordem.Location = new System.Drawing.Point(20, 38);
            this.btn_ordem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_ordem.Name = "btn_ordem";
            this.btn_ordem.Size = new System.Drawing.Size(125, 34);
            this.btn_ordem.TabIndex = 0;
            this.btn_ordem.Text = "Ordem Crescente";
            this.btn_ordem.UseVisualStyleBackColor = true;
            this.btn_ordem.Click += new System.EventHandler(this.btn_ordem_Click);
            // 
            // btn_media
            // 
            this.btn_media.Location = new System.Drawing.Point(20, 80);
            this.btn_media.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_media.Name = "btn_media";
            this.btn_media.Size = new System.Drawing.Size(125, 34);
            this.btn_media.TabIndex = 1;
            this.btn_media.Text = "Média Final";
            this.btn_media.UseVisualStyleBackColor = true;
            this.btn_media.Click += new System.EventHandler(this.btn_media_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "ENUNCIADO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_imc
            // 
            this.btn_imc.Location = new System.Drawing.Point(20, 122);
            this.btn_imc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_imc.Name = "btn_imc";
            this.btn_imc.Size = new System.Drawing.Size(125, 34);
            this.btn_imc.TabIndex = 1;
            this.btn_imc.Text = "IMC";
            this.btn_imc.UseVisualStyleBackColor = true;
            this.btn_imc.Click += new System.EventHandler(this.btn_imc_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_imc);
            this.Controls.Add(this.btn_media);
            this.Controls.Add(this.btn_ordem);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ordem;
        private System.Windows.Forms.Button btn_media;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_imc;
    }
}

