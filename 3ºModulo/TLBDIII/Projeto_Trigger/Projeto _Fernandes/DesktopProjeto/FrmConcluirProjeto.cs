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
        FormCollection OpenForms;
        public FrmConcluirProjeto()
        {
            InitializeComponent();
        }

        private void btnConcluirProjeto_Click(object sender, EventArgs e)
        {
            //lstProjetoConcluido.Items.Add(lstProjetoAndamento.GetItemText(lstProjetoAndamento.Text));
            //lstProjetoAndamento.Items.RemoveAt(lstProjetoAndamento.SelectedIndex);
            if (Application.OpenForms.OfType<FrmPrincipal>().Count() > 0)
            {
                Form segundo = Application.OpenForms["FrmPrincipal"];
                segundo.Show();
                this.Hide();
            }
            else
            {
                FrmPrincipal segundo = new FrmPrincipal();
                segundo.Show();
                this.Hide();
            }
        }

        private void FrmConcluirProjeto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("DESEJA FERCHAR O FORMULÁRIO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
