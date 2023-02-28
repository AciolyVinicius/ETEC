using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopProjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtUsuario.Text != null && txtSenha.Text != "" && txtSenha.Text != null) {
                if (txtUsuario.Text == "user" && txtSenha.Text == "123") { // trocar pelos valores do banco
                    FrmPrincipal principal = new FrmPrincipal();
                    principal.Visible = true;
                    this.Hide();
                } else {
                    MessageBox.Show("Usuário ou senha incorretos!", "Tente novamente.");
                }
            } else {
                MessageBox.Show("Preencha todos os campos!", "Tente novamente.");
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsNumber(e.KeyChar) || Char.IsPunctuation(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }
    }
}
