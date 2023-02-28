using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DesktopProjeto
{
    public partial class FrmDepartamentos : Form
    {
        WebProjeto.WebService1SoapClient serv = new WebProjeto.WebService1SoapClient();
        FormCollection OpenForms;
        public FrmDepartamentos()
        {
            InitializeComponent();
            carregaDpto();
        }

        public void carregaDpto()
        {
            dtg_departamento.DataSource = serv.Departamento().DefaultView;
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void funcionariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
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

        private void projetosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmProjetos>().Count() > 0)
            {
                Form segundo = Application.OpenForms["FrmProjetos"];
                segundo.Show();
                this.Hide();
            }
            else
            {
                FrmProjetos segundo = new FrmProjetos();
                segundo.Show();
                this.Hide();
            }
        }

        private void departamentosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        }

        private void dependentesToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmDepartamentos_Load(object sender, EventArgs e)
        {
        }

        private void btnAddDepartamento_Click(object sender, EventArgs e)
        {
                FrmAddDepartamento segundo = new FrmAddDepartamento();
                segundo.Show();
        }

        private void btnShowDepartamento_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmShowDepartamento>().Count() > 0)
            {
                Form segundo = Application.OpenForms["FrmShowDepartamento"];
                segundo.Show();
                this.Hide();
            }
            else
            {
                FrmShowDepartamento segundo = new FrmShowDepartamento();
                segundo.Show();
                this.Hide();
            }
        }

        private void btnEditarDepartamento_Click(object sender, EventArgs e)
        {
            
                FrmEditDepartamento segundo = new FrmEditDepartamento();
                segundo.Show();
        }

        private void btnRemoverDeparmento_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover este departamento do sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (dtg_departamento.SelectedRows.Count > 0)
                {
                    serv.ExcluiDpto(int.Parse(dtg_departamento
                    .SelectedRows[0].Cells[0].Value.ToString()));
                    carregaDpto();
                }
            }
        }

        private void FrmDepartamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("DESEJA FERCHAR O FORMULÁRIO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnAt_Click(object sender, EventArgs e)
        {
            carregaDpto();
        }

        private void projetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProjetos editFuncionario = new FrmProjetos();
            editFuncionario.Visible = true;
            this.Dispose();
        }
    }
}
