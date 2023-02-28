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
    public partial class FrmDepartamentos : Form
    {
        FormCollection OpenForms;
        public FrmDepartamentos()
        {
            InitializeComponent();
        }

        /*private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {}*/

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Visible = true;
            this.Dispose();
        }

        private void funcionariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmFuncionarios funcionarios = new FrmFuncionarios();
            funcionarios.Visible = true;
            this.Dispose();
        }

        private void projetosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmProjetos projetos = new FrmProjetos();
            projetos.Visible = true;
            this.Dispose();
        }

        private void departamentosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmDepartamentos departamentos = new FrmDepartamentos();
            departamentos.Visible = true;
            this.Dispose();
        }

        private void dependentesToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmDependentes dependentes = new FrmDependentes();
            dependentes.Visible = true;
            this.Dispose();
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
            btnEditarDepartamento.Visible = false;
            btnRemoverDeparmento.Visible = false;
            btnShowDepartamento.Visible = false;
        }

        private void btnAddDepartamento_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmAddDepartamento>().Count() > 0)
            {
                Form segundo = Application.OpenForms["FrmAddDepartamento"];
                segundo.Show();
                this.Hide();
            }
            else
            {
                FrmAddDepartamento segundo = new FrmAddDepartamento();
                segundo.Show();
                this.Hide();
            }
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
            if (Application.OpenForms.OfType<FrmEditDepartamento>().Count() > 0)
            {
                Form segundo = Application.OpenForms["FrmEditDepartamento"];
                segundo.Show();
                this.Hide();
            }
            else
            {
                FrmEditDepartamento segundo = new FrmEditDepartamento();
                segundo.Show();
                this.Hide();
            }
        }

        private void btnRemoverDeparmento_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover este departamento do sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

            }
        }

        private void FrmDepartamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("DESEJA FERCHAR O FORMULÁRIO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
