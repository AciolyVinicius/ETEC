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
    public partial class FrmAddProjeto : Form
    {
        FormCollection OpenForms;
        public FrmAddProjeto()
        {
            InitializeComponent();
        }

        private void btnContinuarNovoProjeto_Click(object sender, EventArgs e)
        {
            if (!txtNomeNovoProjeto.Text.Equals(null) && !txtTipoNovoProjeto.Text.Equals(null) && !txtVerbaNovoProjeto.Equals(null) && !cmbDepartamentoFuncionario.Text.Equals(null) || !txtNomeNovoProjeto.Text.Equals("") && !txtTipoNovoProjeto.Text.Equals("") && !txtVerbaNovoProjeto.Text.Equals("") && !cmbDepartamentoFuncionario.Text.Equals(""))
            {
                if (Application.OpenForms.OfType<FrmAddFuncionarioProjeto>().Count() > 0)
                {
                    Form segundo = Application.OpenForms["FrmAddFuncionarioProjeto"];
                    segundo.Show();
                    this.Hide();
                }
                else
                {
                    FrmAddFuncionarioProjeto segundo = new FrmAddFuncionarioProjeto();
                    segundo.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente!");
            }
        }

        private void txtNomeNovoProjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !(Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtTipoNovoProjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !(Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtVerbaNovoProjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            string numbers = "1234567890.";
            if (!(numbers.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
            }
        }

        private void cmbDepartamentoFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsWhiteSpace(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void FrmAddProjeto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("DESEJA FERCHAR O FORMULÁRIO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
