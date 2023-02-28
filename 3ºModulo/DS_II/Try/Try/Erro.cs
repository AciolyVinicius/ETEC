using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try
{
    public partial class Erro : Form
    {
        public Erro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nm1, nm2;
            nm1 = Double.Parse(txtNum1.Text);
            nm2 = Double.Parse(txtNum2.Text);
            lblResultado.Text = nm1 + nm2 + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double nm1, nm2;
                nm1 = Double.Parse(txtNum1.Text);
                nm2 = Double.Parse(txtNum2.Text);
                lblResultado.Text = nm1 + nm2 + "";
            }
            catch (FormatException)
            {
                lblResultado.Text = "Formato de número inválido";
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double nm1, nm2;
                nm1 = Double.Parse(txtNum1.Text);
                nm2 = Double.Parse(txtNum2.Text);
                lblResultado.Text = nm1 + nm2 + "";
                if(nm1 < 0 || nm2 < 0)
                {
                    throw new Exception("O número deve ser positivo!");
                }
            }
            catch (FormatException)
            {
                lblResultado.Text = "Formato de número inválido";
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
        }
    }
}
