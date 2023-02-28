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
    public partial class Frm_inicio : Form
    {
        public Frm_inicio()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Frm_entrar entrar = new Frm_entrar();
            this.Hide();
            entrar.Show();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Frm_cadastrar cadastrar = new Frm_cadastrar();
            this.Hide();
            cadastrar.Show();
        }
    }
}
