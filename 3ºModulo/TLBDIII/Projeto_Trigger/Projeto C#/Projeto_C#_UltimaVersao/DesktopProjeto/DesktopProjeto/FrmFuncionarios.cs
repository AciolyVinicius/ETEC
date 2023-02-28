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
    public partial class FrmFuncionarios : Form
    {
        WebProjeto.WebService1SoapClient serv = new WebProjeto.WebService1SoapClient();
        public FrmFuncionarios()
        {
            InitializeComponent();
            carregaFunc();
        }

        public void carregaFunc()
        {
            dtg_funcionarios.DataSource = serv.Funcionario().DefaultView;
        }

        private void label1_Click(object sender, EventArgs e)
        {}

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Visible = true;
            this.Dispose();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void projetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProjetos projetos = new FrmProjetos();
            projetos.Visible = true;
            this.Dispose();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartamentos departamentos = new FrmDepartamentos();
            departamentos.Visible = true;
            this.Dispose();
        }

        private void dependentesToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
        }
        

        private void btnAddDependente_Click(object sender, EventArgs e)
        {
            FrmAddFuncionario addFuncionario = new FrmAddFuncionario();
            addFuncionario.Visible = true;
        }

        private void btnShowDependente_Click(object sender, EventArgs e)
        {
            FrmShowFuncionario showFuncionario = new FrmShowFuncionario();
            showFuncionario.Visible = true;
        }

        private void btnEditarDependente_Click(object sender, EventArgs e)
        {
            FrmEditFuncionario editFuncionario = new FrmEditFuncionario();
            editFuncionario.Visible = true;
        }

        private void btnRemoverDependente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover este funcionario do sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (dtg_funcionarios.SelectedRows.Count > 0)
                {
                    serv.ExcluiFunc(int.Parse(dtg_funcionarios
                    .SelectedRows[0].Cells[0].Value.ToString()));
                    carregaFunc();
                }
            }
        }

        private void btnAt_Click(object sender, EventArgs e)
        {
            carregaFunc();
        }

        private void projetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProjetos editFuncionario = new FrmProjetos();
            editFuncionario.Visible = true;
            this.Dispose();
        }
    }
}
