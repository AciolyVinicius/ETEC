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
    public partial class FrmConcluirProjeto : Form
    {
        WebProjeto.WebService1SoapClient serv = new WebProjeto.WebService1SoapClient();
        public FrmConcluirProjeto()
        {
            InitializeComponent();
        }

        private void btnConcluirProjeto_Click(object sender, EventArgs e)
        {
            if (txtCodigoProjeto.Text != "")
            {
                serv.UpdateProjeto(int.Parse(txtCodigoProjeto.Text), true, "", "", "",0,0);
                FrmProjetos principal = new FrmProjetos();
                principal.Visible = true;
                this.Hide();
            }
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
    }
}
