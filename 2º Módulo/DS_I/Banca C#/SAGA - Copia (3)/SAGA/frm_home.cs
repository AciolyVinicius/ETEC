using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace SAGA
{
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_frequencia>().Count() > 0)
            {
                Form frequencia = Application.OpenForms["frm_frequencia"];
                frequencia.Show();
                this.Dispose();
            }
            else
            {
                frm_frequencia frequencia = new frm_frequencia();
                frequencia.Show();
                this.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
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

    }
}
