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
    public partial class frm_notas : Form
    {
        public frm_notas()
        {
            InitializeComponent();
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

        private void btn_cadastro_Click(object sender, EventArgs e)
        {

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

        private void frm_notas_Load(object sender, EventArgs e)
        {
            VerificarTipo verify = new VerificarTipo();
            if (3>Convert.ToInt32(verify.VerifyType()))
            {
                btn_cadastro.Visible = true;
            }
        }

        private void btn_cadastro_Click_1(object sender, EventArgs e)
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
