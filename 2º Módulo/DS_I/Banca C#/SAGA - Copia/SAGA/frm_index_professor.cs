using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAGA
{
    public partial class frm_index_aluno : Form
    {
        public frm_index_aluno()
        {
            InitializeComponent();
        }

        private void btn_saga_Click(object sender, EventArgs e)
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
            if (Application.OpenForms.OfType<frm_notas>().Count() > 0)
            {
                Form notas = Application.OpenForms["frm_notas"];
                notas.Show();
                this.Dispose();
            }
            else
            {
                frm_notas notas = new frm_notas();
                notas.Show();
                this.Dispose();
            }
        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_perfil>().Count() > 0)
            {
                Form perfil = Application.OpenForms["frm_perfil"];
                perfil.Show();
                this.Dispose();
            }
            else
            {
                frm_perfil perfil = new frm_perfil();
                perfil.Show();
                this.Dispose();
            }
        }

        private void btn_frequencia_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_perfil>().Count() > 0)
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
    }
}
