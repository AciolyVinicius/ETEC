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
    public partial class FrmEditFuncionario : Form
    {
        public FrmEditFuncionario()
        {
            InitializeComponent();
        }

        private void btnFinalizarEditFuncionario_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals(null) && !txtCidade.Text.Equals(null) && !txtTelefone.Text.Equals(null) && !txtSalario.Text.Equals(null) && !cmbDepartamento.Text.Equals(null) || !txtNome.Text.Equals("") && !txtCidade.Text.Equals("") && !txtTelefone.Text.Equals("") && !txtSalario.Text.Equals("") && !cmbDepartamento.Text.Equals("")) {
                if (Application.OpenForms.OfType<FrmFuncionarios>().Count() > 0) {
                    Form segundo = Application.OpenForms["FrmFuncionarios"];
                    segundo.Show();
                    this.Hide();
                } else {
                    FrmFuncionarios segundo = new FrmFuncionarios();
                    segundo.Show();
                    this.Hide();
                }
            } else {
                MessageBox.Show("Preencha todos os campos corretamente!");
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !(Char.IsWhiteSpace(e.KeyChar))) {
                e.Handled = true;
            }
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !(Char.IsWhiteSpace(e.KeyChar))) {
                e.Handled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) && (Char.IsWhiteSpace(e.KeyChar))) {
                e.Handled = true;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) && (Char.IsWhiteSpace(e.KeyChar))) {
                e.Handled = true;
            }
        }
    }
}
