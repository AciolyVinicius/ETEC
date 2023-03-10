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
    public partial class frm_frequencia : Form
    {
        public frm_frequencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btn_notas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_notas>().Count() > 0) {
                Form notas = Application.OpenForms["frm_notas"];
                notas.Show();
                this.Dispose();
            } else {
                frm_notas notas = new frm_notas();
                notas.Show();
                this.Dispose();
            }
        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_perfil>().Count() > 0) {
                Form perfil = Application.OpenForms["frm_perfil"];
                perfil.Show();
                this.Dispose();
            } else {
                frm_perfil perfil = new frm_perfil();
                perfil.Show();
                this.Dispose();
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_cadastro>().Count() > 0)
            {
                Form cadastro = Application.OpenForms["frm_cadastro"];
                cadastro.Show();
                this.Dispose();
            }
            else
            {
                frm_cadastro cadastro = new frm_cadastro();
                cadastro.Show();
                this.Dispose();
            }
        }

        private void frm_frequencia_Load(object sender, EventArgs e)
        {
            VerificarTipo verifytype = new VerificarTipo();
            int tipo = Convert.ToInt32(verifytype.VerifyType());
            if (tipo < 3)
            {
                btn_cadastrar.Enabled = true;
            }
        }

        private void btn_anotacoes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_anotacoes>().Count() > 0) {
                Form anotacao = Application.OpenForms["frm_anotacoes"];
                anotacao.Show();
                this.Dispose();
            } else {
                frm_anotacoes anotacao = new frm_anotacoes();
                anotacao.Show();
                this.Dispose();
            }
        }
    }
}
