using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskTabuada
{
    public partial class FrmTabuada : Form
    {
        ServiceTabuada.WebServiceSoapClient serv = new ServiceTabuada.WebServiceSoapClient();
        public FrmTabuada()
        {
            InitializeComponent();
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            lstN.Items.Clear();
            int cont=0;
            do {

                lstN.Items.Add(txtN.Text + " . " + cont + " = " + serv.Tabuada(Double.Parse(txtN.Text), cont));
                cont++;

            } while (cont < 11);
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
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
