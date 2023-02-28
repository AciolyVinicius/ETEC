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
    public partial class FrmEditDepartamento : Form
    {
        WebProjeto.WebService1SoapClient serv = new WebProjeto.WebService1SoapClient();
        public FrmEditDepartamento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!txtCodigoDepart.Text.Equals("") && !txtCodigoDepart.Text.Equals(null))
            {
                String nome = "", local = "";
                if (!String.IsNullOrEmpty(txtNomeDepart.Text))
                {
                    nome = txtNomeDepart.Text;
                }
                if (!String.IsNullOrEmpty(txtLocalDepart.Text))
                {
                    local = txtLocalDepart.Text;
                }
                serv.UpdateDpto(int.Parse(txtCodigoDepart.Text), nome, local);
                if (Application.OpenForms.OfType<FrmDepartamentos>().Count() > 0)
                {
                    Form segundo = Application.OpenForms["FrmDepartamentos"];
                    segundo.Show();
                    this.Hide();
                }
                else
                {
                    FrmDepartamentos segundo = new FrmDepartamentos();
                    segundo.Show();
                    this.Hide();
                }
            }
        }

        private void txtCodigoDepart_KeyPress(object sender, KeyPressEventArgs e)
        {
            string numbers = "1234567890.";
            if (!(numbers.Contains(e.KeyChar.ToString().ToUpper())))
            {
                e.Handled = true;
            }
        }
    }
}
