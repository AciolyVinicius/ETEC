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
        WebProjeto.WebService1SoapClient serv = new WebProjeto.WebService1SoapClient();
        public FrmAddProjeto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int f;
            f = 0;
            if (txtFunc.Text != "")
            {
                f = int.Parse(txtFunc.Text);
            }
            if (txtCodigoNovoProjeto.Text!=""&&txtCodigoDepartNovoProjeto.Text!=""&&txtNome.Text!=""&&txtTipo.Text != "" && txtVerba.Text != "")
            {
                serv.InsertProj(int.Parse(txtCodigoNovoProjeto.Text), txtNome.Text, txtTipo.Text, txtVerba.Text,int.Parse(txtCodigoDepartNovoProjeto.Text), f);
                FrmProjetos principal = new FrmProjetos();
                principal.Visible = true;
                this.Hide();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoNovoProjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void CodigoDepartNovoProjeto_KeyPress(object sender, KeyPressEventArgs e)
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
