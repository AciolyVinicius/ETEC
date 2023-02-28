using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDMySQL
{
    public partial class Frm_inserir : Form
    {
        public Frm_inserir()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Certeza que deseja sair?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Form sair = Application.OpenForms["Frm_principal"];
                sair.Dispose();
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Form voltar = Application.OpenForms["Frm_principal"];
            this.Dispose();
            voltar.Show();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text != null && txt_nome.Text != "")
            {
                if (txt_email.Text != null && txt_email.Text != "")
                {
                    String nome = txt_nome.Text.ToUpper();
                    String email = txt_email.Text.ToUpper();

                    ObterDados registro = new ObterDados();
                    Inserir insercao = new Inserir();

                    registro.Nome = nome;
                    registro.Email = email;
                    bool teste = insercao.Cadastrar(registro);

                    if (teste)
                        MessageBox.Show("Inserção realizada!", "Inserção de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Inserção falhou...", "Inserção de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }
    }
}
