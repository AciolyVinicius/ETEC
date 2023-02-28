using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoAzulMarinho
{
    public partial class FrmLogin : Form
    {
        private char separador = ';';
        public FrmLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
            if (!Directory.Exists(@"C:\login"))
            {
                Directory.CreateDirectory(@"C:\login");
            }
            FileInfo arquivo = new FileInfo(@"C:\login\LogFile.txt");
            if (!arquivo.Exists)
            {
                arquivo.Create();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != "" && txtSenha.Text.Trim() != "")
            {
                FileInfo arquivo = new FileInfo(@"C:\login\LogFile.txt");
                StreamWriter gravar = arquivo.AppendText();
                gravar.WriteLine(txtUsuario.Text.Trim() + separador + txtSenha.Text.Trim());
                gravar.Close();
                gravar.Dispose();
                txtUsuario.Text = "";
                txtSenha.Text = "";
            }else
            {
                MessageBox.Show("Preencha os campos","Aviso!");
            }
            txtUsuario.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != "" && txtSenha.Text.Trim() != "")
            {
                StreamReader leitura = new StreamReader(@"C:\login\LogFile.txt");
                String linha;
                bool login = false;
                while ((linha = leitura.ReadLine())!=null)
                {
                    char token = separador;
                    String[] output = linha.Split(token);
                    if(output[0] == txtUsuario.Text.Trim() && output[1] == txtSenha.Text.Trim())
                    {
                        MessageBox.Show("Logado com sucesso!","Sucesso!");
                        login = true;
                        break;
                        txtUsuario.Text = "";
                        txtSenha.Text = "";
                    }
                }
                leitura.Close();
                if (!login)
                {
                    MessageBox.Show("Usuário ou senha estão incorretos", "Aviso!");
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                }
                txtUsuario.Focus();
                txtUsuario.Dispose();
            }
            else
            {
                MessageBox.Show("Preencha os campos", "Aviso!");
            }
        }

        private void btnRelatório_Click(object sender, EventArgs e)
        {
            Atualiza();
            txtUsuario.Focus();
        }
        public void Atualiza()
        {
            String[] row;
            dgvLogin.Rows.Clear();
            StreamReader leitura = new StreamReader(@"C:\login\LogFile.txt");
            String linha;
            while ((linha = leitura.ReadLine()) != null)
            {
                String[] output = linha.Split(separador);
                row = new String[] { output[0], output[1] };
                dgvLogin.Rows.Add(row);
            }
            leitura.Close();
            leitura.Dispose();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Finalizar?", "Finalizando!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.ExitThread();
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Finalizar?", "Finalizando!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.ExitThread();
            txtUsuario.Focus();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ';')
            {
                e.Handled = true;
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ';')
            {
                e.Handled = true;
            }
        }
    }
}
