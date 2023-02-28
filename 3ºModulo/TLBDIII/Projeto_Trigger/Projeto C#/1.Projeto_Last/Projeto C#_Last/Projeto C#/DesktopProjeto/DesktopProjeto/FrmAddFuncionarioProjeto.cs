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
    public partial class FrmAddFuncionarioProjeto : Form
    {
        public FrmAddFuncionarioProjeto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstFuncionarios2.Items.Add(lstFuncionarios1.GetItemText(lstFuncionarios1.Text));
            lstFuncionarios1.Items.RemoveAt(lstFuncionarios1.SelectedIndex);
        }

        private void btnRemoveFuncionarioProjeto_Click(object sender, EventArgs e)
        {
            lstFuncionarios1.Items.Add(lstFuncionarios2.GetItemText(lstFuncionarios2.Text));
            lstFuncionarios2.Items.RemoveAt(lstFuncionarios2.SelectedIndex);
        }

        private void FrmFuncionarioProjeto_Load(object sender, EventArgs e)
        {
            lblQtdHora.Visible = false;
            txtNmHora.Visible = false;
            lblFuncionarioHora.Visible = false;
        }

        private void lstFuncionarios2_DoubleClick(object sender, EventArgs e)
        {
            int i = -1;
            i = (lstFuncionarios2.SelectedIndex);
            if (i == -1)
            {
                lblFuncionarioHora.Text = lstFuncionarios2.GetItemText(lstFuncionarios2.Text);
                lblFuncionarioHora.Visible = false;
                lblQtdHora.Visible = false;
                txtNmHora.Visible = false;
            }
            if (i >= 0)
            {
                lblFuncionarioHora.Text = lstFuncionarios2.GetItemText(lstFuncionarios2.Text);
                lblFuncionarioHora.Visible = true;
                lblQtdHora.Visible = true;
                txtNmHora.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
