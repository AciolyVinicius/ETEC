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
        public FrmAddFuncionario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void btnFinalizarAddFuncionario_Click(object sender, EventArgs e)
        {
            if (txtCidadeFuncionario.Text != "" && txtCodDepartNovoFunc.Text != "" && txtCodigoNovoFunc.Text != "" && txtNomeFuncionario.Text != "" && txtSalarioFuncionario.Text != "" && txtTelefoneFuncionario.Text != "")
            {
                if(txtCodDepartGerNovoFunc.Text!="")
                {
                    serv.InsertFunc(int.Parse(txtCodigoNovoFunc.Text), txtNomeFuncionario.Text, txtCidadeFuncionario.Text, txtTelefoneFuncionario.Text, decimal.Parse(txtSalarioFuncionario.Text), int.Parse(txtCodDepartNovoFunc.Text), int.Parse(txtCodDepartGerNovoFunc.Text));
                    FrmFuncionarios principal = new FrmFuncionarios();
                    principal.Visible = true;
                    this.Hide();
                }
                else
                {
                    serv.InsertFunc(int.Parse(txtCodigoNovoFunc.Text), txtNomeFuncionario.Text, txtCidadeFuncionario.Text, txtTelefoneFuncionario.Text, decimal.Parse(txtSalarioFuncionario.Text), int.Parse(txtCodDepartNovoFunc.Text), 0);
                    FrmFuncionarios principal = new FrmFuncionarios();
                    principal.Visible = true;
                    this.Hide();
                }
            }
        }

        private void txtTelefoneFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtSalarioFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtCodDepartNovoFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtCodDepartGerNovoFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void FrmAddFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
