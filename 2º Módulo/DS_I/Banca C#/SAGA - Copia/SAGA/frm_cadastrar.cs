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
    public partial class frm_cadastrar : Form
    {
        public frm_cadastrar()
        {
            InitializeComponent();
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txt_cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text != null)
            {
                if (txt_senha.Text != null && txt_senha.Text != "")
                {
                    if (txt_email.Text != null && txt_email.Text != "")
                    {
                        if (lst_tipo.SelectedItem.ToString().Equals("Aluno")) {
                            Cadastro enviar_formulario = new Cadastro();

                            enviar_formulario.Nome = txt_nome.Text;
                            enviar_formulario.Email = txt_email.Text;
                            enviar_formulario.Senha = txt_senha.Text;
                            enviar_formulario.Tipo = 1;

                            CadastroUsuario realizar_cadastro = new CadastroUsuario();

                            bool sucesso = realizar_cadastro.CadastrarUsuario(enviar_formulario);

                            if (sucesso)
                                MessageBox.Show("Sucesso no cadastro de usuário!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Falha ao realizar cadastro de usuário...", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Cadastro enviar_formulario = new Cadastro();

                            enviar_formulario.Nome = txt_nome.Text;
                            enviar_formulario.Email = txt_email.Text;
                            enviar_formulario.Senha = txt_senha.Text;
                            enviar_formulario.Tipo = 2;

                            CadastroUsuario realizar_cadastro = new CadastroUsuario();

                            bool sucesso = realizar_cadastro.CadastrarUsuario(enviar_formulario);

                            if (sucesso)
                                MessageBox.Show("Sucesso no cadastro de usuário!", "SAGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Falha ao realizar cadastro de usuário...", "SAGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                    }
                }
            }
        }

        private void btn_saga_Click(object sender, EventArgs e)
        {
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

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }
    }
}
