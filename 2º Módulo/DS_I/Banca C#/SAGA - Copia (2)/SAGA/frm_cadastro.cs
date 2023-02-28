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
    public partial class frm_cadastro : Form
    {
        public frm_cadastro()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_login>().Count() > 0) {
                Form login = Application.OpenForms["frm_login"];
                login.Show();
                this.Dispose();
            } else {
                frm_login login = new frm_login();
                login.Show();
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text != "" && txt_email.Text != "" && txt_senha.Text != "" && txt_cSenha.Text != "" && txt_cpf.Text != "" && txt_rg.Text != "" && txt_contato1.Text != "")
            {
                String nome_responsavel, cpf_responsavel, contato_responsavel, email_responsavel, nome, senha, cpf, rg, contato1, contato2;
                int usersrole;
                if (txt_nome_responsavel.Text=="")
                {
                    nome_responsavel = ""; 
                }
                else
                {
                    nome_responsavel = txt_nome_responsavel.Text;
                }
                if (txt_cpf_responsavel.Text == "")
                {
                    cpf_responsavel = "";
                }
                else
                {
                    cpf_responsavel = txt_cpf_responsavel.Text;
                }
                if (txt_contato_responsavel.Text == "")
                {
                    contato_responsavel = "";
                }
                else
                {
                    contato_responsavel = txt_contato_responsavel.Text;
                }
                if (txt_email_responsavel.Text == "")
                {
                    email_responsavel = "";
                }
                else
                {
                    email_responsavel = txt_email_responsavel.Text;
                }
                if(txt_contato2.Text == "")
                {
                    contato2 = "";
                }
                else
                {
                    contato2 = txt_contato2.Text;
                }
                if (lst_tipo.SelectedItem.ToString().Equals("Administrador"))
                {
                    usersrole = 1;
                }
                    if () {
                    if (Application.OpenForms.OfType<frm_login>().Count() > 0) {
                        MessageBox.Show("Cadastrado!", "Tudo certo!");
                        Form login = Application.OpenForms["frm_login"];
                        login.Show();
                        this.Dispose();
                    } else {
                        MessageBox.Show("Cadastrado!", "Tudo certo!");
                        frm_login login = new frm_login();
                        login.Show();
                        this.Dispose();
                    }
                }
            } else {
                MessageBox.Show("Preencha todos os campos antes de prosseguir!", "Aviso");
            }
        }
    }
}
