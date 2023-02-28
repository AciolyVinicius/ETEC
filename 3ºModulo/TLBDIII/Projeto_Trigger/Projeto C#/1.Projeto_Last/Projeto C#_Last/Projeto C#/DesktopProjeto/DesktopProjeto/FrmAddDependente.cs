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
        WebProjeto.WebService1SoapClient serv = new WebProjeto.WebService1SoapClient();
        public FrmAddDependente()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCodigoFuncNovoDepen.Text != "" && txtNomeNovoDependente.Text != "" && comboBox1.Text != "" && txtCodigoNovoDependente.Text != "") {
                serv.InsertDependente(int.Parse(txtCodigoFuncNovoDepen.Text), int.Parse(txtCodigoNovoDependente.Text), txtNomeNovoDependente.Text, comboBox1.Text);
                FrmDependentes dependenteFuncionario = new FrmDependentes();
                dependenteFuncionario.Visible = true;
                this.Dispose();
            }

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCodigoNovoDependente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
