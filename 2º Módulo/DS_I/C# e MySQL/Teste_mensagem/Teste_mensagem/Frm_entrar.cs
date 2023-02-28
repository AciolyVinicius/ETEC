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
    public partial class Frm_entrar : Form
    {


        public Frm_entrar()
        {
            InitializeComponent();
            
        }
        
        private void Frm_entrar_Load(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Form voltar = Application.OpenForms["Frm_inicio"];
            this.Dispose();
            voltar.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Form voltar = Application.OpenForms["Frm_inicio"];
            voltar.Dispose();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_login.Text != null && txt_login.Text != "")
            {
                if (txt_senha.Text != null && txt_login.Text != "")
                {
                    Entrar verificar_registro = new Entrar();

                    verificar_registro.Nome_login = txt_login.Text;
                    verificar_registro.Senha_usuario = txt_senha.Text;

                    VerificaCadastro entrar = new VerificaCadastro();
                    bool sucesso = entrar.Verificar(verificar_registro);                   

                    if (sucesso)
                    {                        
                        Frm_principal entrou = new Frm_principal();                   
                        entrou.Show();
                        this.Dispose();
                        int codigo = entrar.ObterCodigo(verificar_registro);
                        CodigoUsuario.Codigo_usuario = codigo;
                       
                    }
                    else
                        MessageBox.Show("Erro ao entrar no aplicativo! Preencha o formulário corretamente", "Chat MilGraus - Entrar", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }
    }
}