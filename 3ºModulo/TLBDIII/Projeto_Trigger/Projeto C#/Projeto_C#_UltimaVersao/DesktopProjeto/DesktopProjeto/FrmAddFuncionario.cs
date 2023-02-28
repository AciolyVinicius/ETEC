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
    public partial class FrmAddFuncionario : Form
    {
        WebProjeto.WebService1SoapClient serv = new WebProjeto.WebService1SoapClient();
        FormCollection OpenForms;
        public FrmAddFuncionario()
        {
            InitializeComponent();
        }

        private void txtNomeFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !(Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtCidadeFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtTelefoneFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefoneFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtSalarioFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalarioFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            string numbers = "1234567890";
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

        private void btnFinalizarAddFuncionario_Click(object sender, EventArgs e)
        {
            if(!txtCodDepartGerNovoFunc.Text.Equals(null)&& !txtCidadeFuncionario.Text.Equals(null) && !txtNomeFuncionario.Text.Equals(null) && !txtSalarioFuncionario.Text.Equals(null) && !txtTelefoneFuncionario.Text.Equals(null) && !txtDepartamentoFuncionario.Text.Equals(null) || !txtCodDepartGerNovoFunc.Text.Equals("")&&!txtCidadeFuncionario.Text.Equals("") && !txtNomeFuncionario.Text.Equals("") && !txtSalarioFuncionario.Text.Equals("") && !txtTelefoneFuncionario.Text.Equals("") && !txtDepartamentoFuncionario.Text.Equals(""))
            {
                if (!txtCodDepartGerNovoFunc.Text.Equals(""))
                {
                    serv.InsertFunc(int.Parse(txtCodigoNovoFunc.Text.ToString()), txtNomeFuncionario.Text.ToString(), txtCidadeFuncionario.Text.ToString(), txtTelefoneFuncionario.Text.ToString(), int.Parse(txtSalarioFuncionario.Text.ToString()), int.Parse(txtDepartamentoFuncionario.Text.ToString()), int.Parse(txtCodDepartGerNovoFunc.Text.ToString()));
                }
                else
                {
                    serv.InsertFunc(int.Parse(txtCodigoNovoFunc.Text.ToString()), txtNomeFuncionario.Text.ToString(), txtCidadeFuncionario.Text.ToString(), txtTelefoneFuncionario.Text.ToString(), int.Parse(txtSalarioFuncionario.Text.ToString()), int.Parse(txtDepartamentoFuncionario.Text.ToString()), 0);
                }
                if (Application.OpenForms.OfType<FrmFuncionarios>().Count() > 0)
                {
                    Form segundo = Application.OpenForms["FrmFuncionarios"];
                    segundo.Show();
                    this.Hide();
                }
                else
                {
                    FrmFuncionarios segundo = new FrmFuncionarios();
                    segundo.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Complete os espaços adequadamente!");
            }
        }

        private void FrmAddFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("DESEJA FERCHAR O FORMULÁRIO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                if (Application.OpenForms.OfType<FrmFuncionarios>().Count() > 0)
                {
                    Form segundo = Application.OpenForms["FrmFuncionarios"];
                    segundo.Show();
                    this.Hide();
                }
                else
                {
                    FrmFuncionarios segundo = new FrmFuncionarios();
                    segundo.Show();
                    this.Hide();
                }
            }
        }

        private void txtCodigoNovoFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            string numbers = "1234567890";
            if (!(numbers.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
            }
        }

        private void txtDepartamentoFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            string numbers = "1234567890";
            if (!(numbers.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
            }
        }

        private void txtCodDepartGerNovoFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            string numbers = "1234567890";
            if (!(numbers.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
            }
        }
    }
}
