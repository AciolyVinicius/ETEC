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
    public partial class frm_anotacoes : Form
    {
        public frm_anotacoes()
        {
            InitializeComponent();
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

        private void btn_home_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_home>().Count() > 0)
            {
                Form home = Application.OpenForms["frm_home"];
                home.Show();
                this.Dispose();
            }
            else
            {
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

        private void btn_frequencia_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicionado com sucesso!");
        }

        private void frm_anotacoes_Load(object sender, EventArgs e)
        {
            VerificarTipo verifytype = new SAGA.VerificarTipo();
            int tipo = Convert.ToInt32(verifytype.VerifyType());
            if (tipo < 3)
            {
                btn_cadastrar.Enabled = true;
            }
            AtualizarListaDisciplina loaddiscipline = new AtualizarListaDisciplina();
            int numerosdisciplina = loaddiscipline.DisciplinesNumbers(), countdisciplina = 0;
            do
            {
                countdisciplina++;
                String listadisciplina = loaddiscipline.DisciplinesList(countdisciplina);
                lst_disciplina.Items.Add(listadisciplina);

            } while (countdisciplina < numerosdisciplina);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nenhuma anotação cadastrada!");
        }
    }
}
