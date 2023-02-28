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
    public partial class FrmProjetos : Form
    {
        WebProjeto.WebService1SoapClient serv = new WebProjeto.WebService1SoapClient();
        public FrmProjetos()
        {
            InitializeComponent();
            carregaProjeto();
        }

        public void carregaProjeto()
        {
            dtg_projetos.DataSource = serv.Projeto().DefaultView;
        }
        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Visible = true;
            this.Dispose();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionarios funcionarios = new FrmFuncionarios();
            funcionarios.Visible = true;
            this.Dispose();
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
        

        private void FrmProjetos_Load(object sender, EventArgs e)
        {
        }

        private void btnAddDependente_Click(object sender, EventArgs e)
        {
            FrmAddProjeto addProjeto = new FrmAddProjeto();
            addProjeto.Visible = true;
        }

        private void btnShowDependente_Click(object sender, EventArgs e)
        {
            FrmShowProjeto showProjeto = new FrmShowProjeto();
            showProjeto.Visible = true;
        }

        private void btnEditarDependente_Click(object sender, EventArgs e)
        {
            FrmEditProjeto editProjeto = new FrmEditProjeto();
            editProjeto.Visible = true;
        }

        private void btnRemoverDependente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover este projeto do sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                serv.ExcluiProjeto(int.Parse(dtg_projetos
                    .SelectedRows[0].Cells[0].Value.ToString()));
            }
        }

        private void btnAt_Click(object sender, EventArgs e)
        {
            carregaProjeto();
        }

        private void btnProjFunc_Click(object sender, EventArgs e)
        {
            FrmAddFuncionarioProjeto editProjeto = new FrmAddFuncionarioProjeto();
            editProjeto.Visible = true;
        }
    }
}
