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
            if (Application.OpenForms.OfType<frm_cadastro_curso>().Count() > 0) {
                Form cadastro_curso = Application.OpenForms["frm_cadastro_curso"];
                cadastro_curso.Show();
                this.Dispose();
            } else {
                frm_cadastro_curso cadastro_curso = new frm_cadastro_curso();
                cadastro_curso.Show();
                this.Dispose();
            }
        }


        private void btn_salva_dados_Click(object sender, EventArgs e)
        {
            if (txt_estado.Text != "" && txt_endereco.Text != "" && txt_nome.Text != "" && txt_email.Text != "" && txt_senha.Text != "" && txt_cSenha.Text != "" && txt_cpf.Text != "" && txt_rg.Text != "" && txt_contato1.Text != "" && txt_senha.Text.Equals(txt_cSenha.Text))
            {
                String endereco, nome_responsavel, cpf_responsavel, contato_responsavel, email_responsavel, nome, nascimento, senha, cpf, rg, contato1, contato2, email;
                int usersrole = 4;
                Boolean stop = true;
                nome = txt_nome.Text;

                if (txt_nome_responsavel.Text == "")
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
                if (txt_contato2.Text == "")
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
                else if (lst_tipo.SelectedItem.ToString().Equals("Gerenciador"))
                {
                    usersrole = 2;
                }
                else if (lst_tipo.SelectedItem.ToString().Equals("Professor"))
                {
                    usersrole = 3;
                }
                else if (lst_tipo.SelectedItem.ToString().Equals("Aluno"))
                {
                    usersrole = 4;
                }
                else
                {
                    MessageBox.Show("Selecione um tipo de usuário!");
                    stop = false;
                }
                if (stop)
                {
                    VerificarEmailCadastrado verifyredundancy = new VerificarEmailCadastrado();
                    if (verifyredundancy.VerifyRegister())
                    {
                        nome = txt_nome.Text;
                        nascimento = dtp_nascimento.Text + "";
                        cpf = txt_cpf.Text;
                        senha = txt_senha.Text;
                        rg = txt_rg.Text;
                        contato1 = txt_contato1.Text;
                        email = txt_email.Text;
                        endereco = txt_endereco.Text + "/" + txt_estado.Text;

                        Cadastro.Nome = nome;
                        Cadastro.Nascimento = nascimento;
                        Cadastro.Senha = senha;
                        Cadastro.Email = email;
                        Cadastro.Cpf = cpf;
                        Cadastro.Rg = rg;
                        Cadastro.Contato1 = contato1;
                        Cadastro.Contato2 = contato2;
                        Cadastro.Nome_responsavel = nome_responsavel;
                        Cadastro.Contato_responsavel = contato_responsavel;
                        Cadastro.Email_responsavel = email_responsavel;
                        Cadastro.Cpf_responsavel = cpf_responsavel;
                        Cadastro.Usersrole = usersrole;

                        Cadastro Insert = new Cadastro();

                        if (Insert.ConfirmRegister())
                        {
                            if (Application.OpenForms.OfType<frm_login>().Count() > 0)
                            {
                                MessageBox.Show("Cadastrado!", "Tudo certo!");
                                Form login = Application.OpenForms["frm_login"];
                                login.Show();
                                this.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("Cadastrado!", "Tudo certo!");
                                frm_login login = new frm_login();
                                login.Show();
                                this.Dispose();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("O email já existe!", "Aviso");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos corretamente antes de prosseguir!", "Aviso");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente antes de prosseguir!", "Aviso");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_cadastro_curso>().Count() > 0)
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
    }
}
