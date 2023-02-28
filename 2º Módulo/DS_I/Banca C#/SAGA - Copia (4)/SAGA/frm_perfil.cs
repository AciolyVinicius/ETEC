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
    public partial class frm_perfil : Form
    {
        public frm_perfil()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
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

        private void btn_frequencia_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_frequencia>().Count() > 0) {
                Form frequencia = Application.OpenForms["frm_frequencia"];
                frequencia.Show();
                this.Dispose();
            } else {
                frm_frequencia frequencia = new frm_frequencia();
                frequencia.Show();
                this.Dispose();
            }
        }

        private void frm_perfil_Load(object sender, EventArgs e)
        {
            VerificarTipo verifytype = new VerificarTipo();
            int tipo = Convert.ToInt32(verifytype.VerifyType());
            if (tipo<3)
            {
                btn_cadastrar.Enabled = true;
            }
            InfoUsuario info = new InfoUsuario();
            info.Informations();
            lbl_nascimento.Text = InfoUsuario.Nascimento;
            lbl_name.Text = InfoUsuario.Nome;
            lbl_contato1.Text = InfoUsuario.Contato1;
            lbl_contato2.Text = InfoUsuario.Contato2;
            lbl_endereco.Text = InfoUsuario.Endereco;
            lbl_email.Text = InfoUsuario.Email;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
    }
}
