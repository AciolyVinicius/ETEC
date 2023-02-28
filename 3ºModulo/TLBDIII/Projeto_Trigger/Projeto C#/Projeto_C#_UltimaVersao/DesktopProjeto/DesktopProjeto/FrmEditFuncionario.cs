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
        WebProjeto.WebService1SoapClient serv = new WebProjeto.WebService1SoapClient();
        public FrmEditFuncionario()
        {
            InitializeComponent();
        }

        private void btnFinalizarEditFuncionario_Click(object sender, EventArgs e)
        {
            if (!txtCodigoFunc.Text.Equals("") || !txtCodigoFunc.Text.Equals(null))
            {
                String nome = null, end = null, telefone = null;
                int sal=0;
                int dp = 0, dpger = 0;
                if (!txtNomeFuncionario.Text.Equals("")&&!txtNomeFuncionario.Text.Equals(null))
                {
                    nome = txtNomeFuncionario.Text;
                }
                if (!txtCidadeFuncionario.Text.Equals("") && !txtCidadeFuncionario.Text.Equals(null))
                {
                    end = txtCidadeFuncionario.Text;
                }
                if (!txtTelefoneFuncionario.Text.Equals("") && !txtTelefoneFuncionario.Text.Equals(null))
                {
                    telefone = txtTelefoneFuncionario.Text;
                }
                if (!txtSalarioFuncionario.Text.Equals("") && !txtSalarioFuncionario.Text.Equals(null))
                {
                    sal = int.Parse(txtSalarioFuncionario.Text);
                }
                if (!txtDepartamentoFuncionario.Text.Equals("") && !txtDepartamentoFuncionario.Text.Equals(null))
                {
                    dp = int.Parse(txtDepartamentoFuncionario.Text);
                }
                if (!txtCodDepartGerNovoFunc.Text.Equals("") && !txtCodDepartGerNovoFunc.Text.Equals(null))
                {
                    dpger = int.Parse(txtDepartamentoFuncionario.Text);
                }            
                serv.UpdateFunc(int.Parse(txtCodigoFunc.Text), nome, end, telefone, sal, dp, dpger);
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

        private void txtCodigoFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            string numbers = "1234567890";
            if (!(numbers.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
            }
        }

        private void txtTelefoneFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            string numbers = "1234567890";
            if (!(numbers.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
            }
        }
    }
}
