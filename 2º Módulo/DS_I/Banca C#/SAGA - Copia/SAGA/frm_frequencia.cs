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
    public partial class frm_frequencia : Form
    {
        public frm_frequencia()
        {
            InitializeComponent();
        }

        private void btn_notas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_notas>().Count() > 0)
            {
                Form home = Application.OpenForms["frm_notas"];
                home.Show();
                this.Hide();
            }
            else
            {
                frm_notas home = new frm_notas();
                home.Show();
                this.Hide();
            }
        }

        private void btn_frequencia_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_index_aluno>().Count() > 0)
            {
                Form index = Application.OpenForms["frm_index"];
                index.Show();
                this.Hide();
            }
            else
            {
                frm_index_aluno index = new frm_index_aluno();
                index.Show();
                this.Hide();
            }
        }

        private void btn_perfil_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_perfil>().Count() > 0)
            {
                Form perfil = Application.OpenForms["frm_perfil"];
                perfil.Show();
                this.Hide();
            }
            else
            {
                frm_perfil perfil = new frm_perfil();
                perfil.Show();
                this.Hide();
            }
        }

        private void btn_saga_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_home>().Count() > 0)
            {
                Form home = Application.OpenForms["frm_home"];
                home.Show();
                this.Hide();
            }
            else
            {
                frm_home home = new frm_home();
                home.Show();
                this.Hide();
            }
        }
    }
}
