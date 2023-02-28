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
    public partial class FrmEditProjeto : Form
    {
        WebProjeto.WebService1SoapClient serv = new WebProjeto.WebService1SoapClient();
        public FrmEditProjeto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nome = "", tipo = "", verba = "";
            Boolean conc = false;
            int dpto = 0, cdf = 0;
            if (txtCodigoFunc.Text.Equals("") && txtCodigoFunc.Text.Equals(null))
            {
                cdf = int.Parse(txtCodigoFunc.Text);
            }
            if (txtNomeProjeto.Text.Equals("") && txtNomeProjeto.Text.Equals(null))
            {
                nome = txtNomeProjeto.Text;
            }
            if (txtDepartamentoFuncionario.Text.Equals("") && txtDepartamentoFuncionario.Text.Equals(null))
            {
                dpto = int.Parse(txtDepartamentoFuncionario.Text);
            }
            if (txtTipoProjeto.Text.Equals("") && txtTipoProjeto.Text.Equals(null))
            {
                tipo = txtTipoProjeto.Text;
            }
            if (txtVerbaProjeto.Text.Equals("") && txtVerbaProjeto.Text.Equals(null))
            {
                verba = txtVerbaProjeto.Text;
            }
            if (!txtCodProj.Text.Equals("") && !txtCodProj.Text.Equals(null))
            {
                serv.UpdateProjeto(int.Parse(txtCodProj.Text), false, nome, tipo, verba, dpto, cdf);
            }
            if (Application.OpenForms.OfType<FrmFuncionarios>().Count() > 0)
            {
                Form segundo = Application.OpenForms["FrmFuncionarios"];
                segundo.Show();
                this.Hide();
            }
            else
            {
                FrmFuncionarios segundo = new FrmFuncionarios();
                segundo.Show();
                this.Hide();
            }
        }
    }
}
