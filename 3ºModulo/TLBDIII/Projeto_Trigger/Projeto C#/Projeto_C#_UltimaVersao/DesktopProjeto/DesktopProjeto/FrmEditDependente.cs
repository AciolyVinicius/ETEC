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
        WebProjeto.WebService1SoapClient serv = new WebProjeto.WebService1SoapClient();
        public FrmEditDependente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!txtCodigoDepart.Text.Equals("")&& !txtCodigoDepart.Text.Equals(null))
            {
                serv.UpdateDependente(int.Parse(txtCodigoDepart.Text), txtNome.Text, cmbPar.Text);
            }
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

        private void txtCodigoDepart_KeyPress(object sender, KeyPressEventArgs e)
        {
            string numbers = "1234567890";
            if (!(numbers.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
            }
        }

        private void cmbPar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsWhiteSpace(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
