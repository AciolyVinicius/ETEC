using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (Application.OpenForms.OfType<frm_home>().Count() > 0)
            {
                Form home = Application.OpenForms["frm_home"];
                home.Show();
                this.Dispose();
            }
            else
            {
                frm_home home = new frm_home();
                home.Show();
                this.Dispose();
            }
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_cadastrar>().Count() > 0)
            {
                Form cadastrar = Application.OpenForms["frm_cadastrar"];
                cadastrar.Show();
                this.Dispose();
            }
            else
            {
                frm_cadastrar cadastro = new frm_cadastrar();
                cadastro.Show();
                this.Dispose();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_email.Text != null && txt_email.Text != "")
            {
                if (txt_senha.Text != null && txt_senha.Text != "")
                {
                    Classe verificar_registro = new Classe();

                    verificar_registro.Nome_login = txt_email.Text;
                    verificar_registro.Senha_usuario = txt_senha.Text;

                    Classe entrar = new Classe();
                    bool sucesso = entrar.Verificar(verificar_registro);

                    if (sucesso)
                    {
                        Classe na = new Classe();
                        na.Nome_login = txt_email.Text;
                        na.Senha_usuario = txt_senha.Text;

                        Classe name = new SAGA.Classe();
                        String n = name.Nm_nome(na);
                        Classe.Nomee = n;
                        Classe.Emaill = txt_email.Text;
                        frm_index_aluno entrou = new frm_index_aluno();
                        entrou.Show();
                        this.Dispose();

                    }
                    else
                        MessageBox.Show("Erro ao entrar no site! Preencha o formulário corretamente", "SAGA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }
    }
}
