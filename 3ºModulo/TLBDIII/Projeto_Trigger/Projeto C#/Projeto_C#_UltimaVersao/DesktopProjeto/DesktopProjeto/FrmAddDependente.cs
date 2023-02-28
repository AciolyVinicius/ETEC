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
    public partial class FrmAddDependente : Form
    {
        FormCollection OpenForms;
        WebProjeto.WebService1SoapClient serv = new WebProjeto.WebService1SoapClient();
        public FrmAddDependente()
        {
            InitializeComponent();
        }

        private void btn_continuar_novo_dependente_Click(object sender, EventArgs e)
        {
            if (!txtCodigoNovoDependente.Text.Equals(null)&& !txtCodigoFuncNovoDepen.Text.Equals(null)&&!txtNomeNovoDependente.Text.Equals(null) && !cmbParentescoNovoDependente.Text.Equals(null) || !txtCodigoNovoDependente.Text.Equals("") && !txtCodigoFuncNovoDepen.Text.Equals("")&&!txtNomeNovoDependente.Text.Equals("") && !cmbParentescoNovoDependente.Text.Equals("")) {
                serv.InsertDependente(int.Parse(txtCodigoFuncNovoDepen.Text), int.Parse(txtCodigoNovoDependente.Text), txtNomeNovoDependente.Text, cmbParentescoNovoDependente.Text);
                if (Application.OpenForms.OfType<FrmDependentes>().Count() > 0)
                {
                    Form segundo = Application.OpenForms["FrmDependentes"];
                    segundo.Show();
                    this.Hide();
                }
                else
                {
                    FrmDependentes segundo = new FrmDependentes();
                    segundo.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Complete os espaços adequadamente!");
            }
        }

        private void txtNomeNovoDependente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !(Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void cmb_parentesco_novo_dependente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbParentescoNovoDependente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsWhiteSpace(e.KeyChar))||(Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_nome_novo_dependente_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddDependente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("DESEJA FERCHAR O FORMULÁRIO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                if (Application.OpenForms.OfType<FrmDependentes>().Count() > 0)
                {
                    Form segundo = Application.OpenForms["FrmDependentes"];
                    segundo.Show();
                    this.Hide();
                }
                else
                {
                    FrmDependentes segundo = new FrmDependentes();
                    segundo.Show();
                    this.Hide();
                }
            }
        }

        private void txtCodigoNovoDependente_KeyPress(object sender, KeyPressEventArgs e)
        {
            string numbers = "1234567890";
            if (!(numbers.Contains(e.KeyChar.ToString().ToUpper())) && e.KeyChar.ToString().Count() > 9)
            {
                e.Handled = true;
            }
        }

        private void txtCodigoFuncNovoDepen_KeyPress(object sender, KeyPressEventArgs e)
        {
            string numbers = "1234567890";
            if (!(numbers.Contains(e.KeyChar.ToString().ToUpper())) && e.KeyChar.ToString().Count() > 9)
            {
                e.Handled = true;
            }
        }
    }
}
