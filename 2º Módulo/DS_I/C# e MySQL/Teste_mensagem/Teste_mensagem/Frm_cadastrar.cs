using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_mensagem
{
    public partial class Frm_cadastrar : Form
    {
        public Frm_cadastrar()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Form voltar = Application.OpenForms["Frm_inicio"];
            this.Dispose();
            voltar.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Form sair = Application.OpenForms["Frm_inicio"];
            sair.Dispose();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_login.Text != null && txt_login.Text != "")
            {
                if (txt_nome.Text != null && txt_nome.Text != "")
                {
                    if (txt_senha.Text != null && txt_senha.Text != "")
                    {
                        Cadastrar enviar_formulario = new Cadastrar();

                        enviar_formulario.Nome_login = txt_login.Text;
                        enviar_formulario.Nome_usuario = txt_nome.Text;
                        enviar_formulario.Senha_usuario = txt_senha.Text;

                        EnviaCadastro realizar_cadastro = new EnviaCadastro();

                        bool sucesso = realizar_cadastro.CadastrarUsuario(enviar_formulario);

                        if (sucesso)
                            MessageBox.Show("Sucesso no cadastro de usuário!", "Chat MilGraus - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Falha ao realizar cadastro de usuário...", "Chat MilGraus - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
