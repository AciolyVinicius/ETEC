using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskCalculadora
{
    public partial class Frm_Calcular : Form
    {
        ServiceCalculadora.WebServiceSoapClient serv = new ServiceCalculadora.WebServiceSoapClient();
        public Frm_Calcular()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = serv.Somar(Double.Parse(txt1.Text), Double.Parse(txt2.Text)).ToString();
        }

        private void btnSubt_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = serv.Subtrair(Double.Parse(txt1.Text), Double.Parse(txt2.Text)).ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = serv.Multiplicar(Double.Parse(txt1.Text), Double.Parse(txt2.Text)).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (Double.Parse(txt2.Text)!=0)
            {
                lbl_resultado.Text = serv.Dividir(Double.Parse(txt1.Text), Double.Parse(txt2.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Divisor não pode ser 0");
            }
        }

        private void Frm_Calcular_Load(object sender, EventArgs e)
        {

        }
    }
}
