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
        }

        private void btnAddDepartamento_Click(object sender, EventArgs e)
        {
            FrmAddDepartamento addDepartamento = new FrmAddDepartamento();
            addDepartamento.Visible = true;
        }

        private void btnShowDepartamento_Click(object sender, EventArgs e)
        {
            FrmShowDepartamento showDepartamento = new FrmShowDepartamento();
            showDepartamento.Visible = true;
        }

        private void btnEditarDepartamento_Click(object sender, EventArgs e)
        {
            FrmEditDepartamento editDepartamento = new FrmEditDepartamento();
            editDepartamento.Visible = true;
        }

        private void btnRemoverDeparmento_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover este departamento do sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

            }
        }
    }
}
