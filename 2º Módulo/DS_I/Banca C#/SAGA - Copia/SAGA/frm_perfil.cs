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
    public partial class frm_perfil : Form
    {
        public frm_perfil()
        {
            InitializeComponent();
            lbl_email.Text = Classe.Emaill;
            lbl_nome.Text = Classe.Nomee;
        
        }

        private void frm_perfil_Load(object sender, EventArgs e)
        {

        }

        private void btn_notas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_notas>().Count() > 0)
            {
                Form notas = Application.OpenForms["frm_notas"];
                notas.Show();
                this.Hide();
            }
            else
            {
                frm_notas login = new frm_notas();
                login.Show();
                this.Hide();
            }
        }

        private void btn_frequencia_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_frequencia>().Count() > 0)
            {
                Form frequencia = Application.OpenForms["frm_frequencia"];
                frequencia.Show();
                this.Hide();
            }
            else
            {
                frm_frequencia frequencia = new frm_frequencia();
                frequencia.Show();
                this.Hide();
            }
        }

        private void btn_avisos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_index_aluno>().Count() > 0)
            {
                Form avisos = Application.OpenForms["frm_index"];
                avisos.Show();
                this.Hide();
            }
            else
            {
                frm_index_aluno avisos = new frm_index_aluno();
                avisos.Show();
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
