using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopProjeto
{
    public partial class FrmAddDepartamento : Form
    {
        FormCollection OpenForms;
        public FrmAddDepartamento()
        {
            InitializeComponent();
        }

        private void txtNomeNovoDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !(Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btn_finalizar_novo_departamento_Click(object sender, EventArgs e)
        {
            if (!txtLocalizacaoNovoDepartamento.Text.Equals(null) && !txtNomeNovoDepartamento.Text.Equals(null) && !txtLocalizacaoNovoDepartamento.Text.Equals("") && !txtNomeNovoDepartamento.Text.Equals(""))
            {


                if (Application.OpenForms.OfType<FrmDepartamentos>().Count() > 0)
                {
                    Form segundo = Application.OpenForms["FrmDepartamentos"];
                    segundo.Show();
                    this.Hide();
                }
                else
                {
                    FrmDepartamentos segundo = new FrmDepartamentos();
                    segundo.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Complete os espaços adequadamente!");
            }
        }

        private void txt_localizacao_novo_departamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLocalizacaoNovoDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FrmAddDepartamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("DESEJA FERCHAR O FORMULÁRIO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                if (Application.OpenForms.OfType<FrmDepartamentos>().Count() > 0)
                {
                    Form segundo = Application.OpenForms["FrmDepartamentos"];
                    segundo.Show();
                    this.Hide();
                }
                else
                {
                    FrmDepartamentos segundo = new FrmDepartamentos();
                    segundo.Show();
                    this.Hide();
                }
            }
        }
    }
}
