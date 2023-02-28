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
    public partial class FrmEditDependente : Form
    {
        public FrmEditDependente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals(null) && !cmbParentesco.Text.Equals(null) && !cmbFuncionario.Text.Equals(null) || !txtNome.Text.Equals("") &&  !cmbParentesco.Text.Equals("") && !cmbFuncionario.Text.Equals("")) {
                if (Application.OpenForms.OfType<FrmDependentes>().Count() > 0) {
                    Form segundo = Application.OpenForms["FrmDependentes"];
                    segundo.Show();
                    this.Hide();
                } else {
                    FrmDependentes segundo = new FrmDependentes();
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
    }
}
