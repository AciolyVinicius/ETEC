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
        public FrmAddDependente()
        {
            InitializeComponent();
        }

        private void btn_continuar_novo_dependente_Click(object sender, EventArgs e)
        {
            if (!txtNomeNovoDependente.Text.Equals(null) && !cmbParentescoNovoDependente.Text.Equals(null) || !txtNomeNovoDependente.Text.Equals("") && !cmbParentescoNovoDependente.Text.Equals("")) {


                if (Application.OpenForms.OfType<FrmDependenteFuncionario>().Count() > 0) {
                    Form segundo = Application.OpenForms["FrmDependenteFuncionario"];
                    segundo.Show();
                    this.Hide();
                } else {
                    FrmDependenteFuncionario segundo = new FrmDependenteFuncionario();
                    segundo.Show();
                    this.Hide();
                }
            } else {
                MessageBox.Show("Complete os espaços adequadamente!");
            }
        }

        private void txtNomeNovoDependente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !(Char.IsWhiteSpace(e.KeyChar))) {
                e.Handled = true;
            }
        }

        private void cmbParentescoNovoDependente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsWhiteSpace(e.KeyChar))||(Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        

        private void FrmAddDependente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("DESEJA FERCHAR O FORMULÁRIO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                if (Application.OpenForms.OfType<FrmDependentes>().Count() > 0) {
                    Form segundo = Application.OpenForms["FrmDependentes"];
                    segundo.Show();
                    this.Hide();
                } else {
                    FrmDependentes segundo = new FrmDependentes();
                    segundo.Show();
                    this.Hide();
                }
            }
        }
    }
}
