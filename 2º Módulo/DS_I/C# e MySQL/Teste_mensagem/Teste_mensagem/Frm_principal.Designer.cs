namespace Teste_mensagem
{
    partial class Frm_principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.txt_mensagem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_usuario_destino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sair_conta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_recebe_mensagem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHAT MILGRAUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Envie e receba mensagens muito loucas pela vida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mensagens enviadas e recebidas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_enviar);
            this.groupBox1.Controls.Add(this.txt_mensagem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_usuario_destino);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 241);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enviar mensagem";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(206, 198);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(200, 30);
            this.btn_enviar.TabIndex = 4;
            this.btn_enviar.Text = "E N V I A R";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // txt_mensagem
            // 
            this.txt_mensagem.Location = new System.Drawing.Point(6, 108);
            this.txt_mensagem.Multiline = true;
            this.txt_mensagem.Name = "txt_mensagem";
            this.txt_mensagem.Size = new System.Drawing.Size(597, 75);
            this.txt_mensagem.TabIndex = 3;
            this.txt_mensagem.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mensagem:";
            // 
            // txt_usuario_destino
            // 
            this.txt_usuario_destino.Location = new System.Drawing.Point(171, 36);
            this.txt_usuario_destino.Name = "txt_usuario_destino";
            this.txt_usuario_destino.Size = new System.Drawing.Size(436, 29);
            this.txt_usuario_destino.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome do usuário:";
            // 
            // btn_sair_conta
            // 
            this.btn_sair_conta.Location = new System.Drawing.Point(323, 579);
            this.btn_sair_conta.Name = "btn_sair_conta";
            this.btn_sair_conta.Size = new System.Drawing.Size(200, 30);
            this.btn_sair_conta.TabIndex = 6;
            this.btn_sair_conta.Text = "SAIR DA CONTA";
            this.btn_sair_conta.UseVisualStyleBackColor = true;
            this.btn_sair_conta.Click += new System.EventHandler(this.btn_sair_conta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_recebe_mensagem
            // 
            this.txt_recebe_mensagem.BackColor = System.Drawing.Color.White;
            this.txt_recebe_mensagem.Location = new System.Drawing.Point(16, 395);
            this.txt_recebe_mensagem.Multiline = true;
            this.txt_recebe_mensagem.Name = "txt_recebe_mensagem";
            this.txt_recebe_mensagem.ReadOnly = true;
            this.txt_recebe_mensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_recebe_mensagem.Size = new System.Drawing.Size(613, 172);
            this.txt_recebe_mensagem.TabIndex = 11;
            this.txt_recebe_mensagem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_recebe_mensagem_MouseClick_2);
            this.txt_recebe_mensagem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txt_recebe_mensagem_MouseMove);
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(641, 622);
            this.ControlBox = false;
            this.Controls.Add(this.txt_recebe_mensagem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_sair_conta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat MilGraus - Enviando e Recebendo Mensagens";
            this.Load += new System.EventHandler(this.Frm_principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_mensagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_usuario_destino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Button btn_sair_conta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_recebe_mensagem;
    }
}