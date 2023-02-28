using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA5_EXE3_MGVM_VAES
{
    public partial class Login : Form
    {
        int i = 0, erro = 0, max=0;
        String[] senhaC = new String[10];
        String senhaL;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_enterLogin_Click(object sender, EventArgs e)
        {
            int f = 0, h = 0;
            senhaL = txt_login.Text;
            if(erro<2)
            {
                do
                {
                    if (senhaL.Equals(senhaC[f]))
                    {
                        h = 1;
                    }
                    f++;
                } while (f < 10);

                txt_login.Text = "";

                if (h == 1)
                {
                    SegundoFR segundo = new SegundoFR();
                    segundo.Show();
                }
                else
                {
                    MessageBox.Show("Senha incorreta");
                    erro++;
                }
            }
            else
            {
                MessageBox.Show("Acabaram suas chances!");
                this.Close();
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Finalizar Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_enterCadastro_Click(object sender, EventArgs e)
        {
            String access = txt_cadastro.Text;
            if (access.Length == 4)
            {
                if (i < 10)
                {
                    senhaC[i] = txt_cadastro.Text;
                    i++;
                }
                else
                {
                    max = 1;
                }
            }
            else
            {
                if (max == 1)
                {
                    MessageBox.Show("Limite de cadastros atingido!");
                }
                else
                {
                    MessageBox.Show("A senha deverá ter 4 dígitos");
                }
            }
            txt_cadastro.Text = "";
        }
    }
}
