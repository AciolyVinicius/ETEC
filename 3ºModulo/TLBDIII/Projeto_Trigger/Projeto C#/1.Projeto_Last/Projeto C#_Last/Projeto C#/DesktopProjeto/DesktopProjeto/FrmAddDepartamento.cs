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
    public partial class FrmAddDepartamento : Form
    {
        WebProjeto.WebService1SoapClient serv = new WebProjeto.WebService1SoapClient();
        public FrmAddDepartamento()
        {
            InitializeComponent();
        }

        private void btnNovoDepart_Click(object sender, EventArgs e)
        {
            if (txtNovoCodigoDepartamento.Text != "" && txtNovoNomeDepartamento.Text != "" && txtNovoLocalizacaoDepartamento.Text != "")
            {
                serv.InsertDepart(int.Parse(txtNovoCodigoDepartamento.Text.ToString()), txtNovoNomeDepartamento.Text, txtNovoLocalizacaoDepartamento.Text);
                FrmDepartamentos principal = new FrmDepartamentos();
                principal.Visible = true;
                this.Hide();
            }
        }

        private void txtNovoCodigoDepartamento_KeyPress(object sender, KeyPressEventArgs e)
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
