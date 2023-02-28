using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAGA
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_saga_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_saga>().Count() > 0) {
                Form saga = Application.OpenForms["frm_saga"];
                saga.Show();
                this.Dispose();
            } else {
                frm_saga saga = new frm_saga();
                saga.Show();
                this.Dispose();
            }
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_cadastro>().Count() > 0) {
                Form cadastro = Application.OpenForms["frm_cadastro"];
                cadastro.Show();
                this.Dispose();
            } else {
                frm_cadastro cadastro = new frm_cadastro();
                cadastro.Show();
                this.Dispose();
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_email.Text != "" || txt_senha.Text != "") {

                Login entering = new Login();
                entering.Nome_login = txt_email.Text;
                entering.Senha_usuario = txt_senha.Text;

                Login checking = new Login();
                Boolean yesno = checking.Verificar(entering);

                if (yesno) {
                    if (Application.OpenForms.OfType<frm_home>().Count() > 0) {
                        Form home = Application.OpenForms["frm_home"];
                        home.Show();
                        this.Dispose();
                    } else {
                        frm_home home = new frm_home();
                        home.Show();
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Valores incorretos!");
                }
            } else {
                MessageBox.Show("Prenncha tudo corretamente!");
            }
        }
    }
}
