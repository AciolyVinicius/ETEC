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
    public partial class FrmDependenteFuncionario : Form
    {
        public FrmDependenteFuncionario()
        {
            InitializeComponent();
        }

        private void cmbFuncionarioAssociarDependente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsWhiteSpace(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnFinalizarAssociarDependente_Click(object sender, EventArgs e)
        {
            if(cmbFuncionarioAssociarDependente.Text.Equals("") || cmbFuncionarioAssociarDependente.Text.Equals(null))
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

        private void FrmDependenteFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("DESEJA FERCHAR O FORMULÁRIO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
