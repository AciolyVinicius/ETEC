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
    public partial class FrmProjetos : Form
    {
        public FrmProjetos()
        {
            InitializeComponent();
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

        public void Atualiza()
        {
            //DataTable dt = new DataTable();
            //adptAtualiza.Fill(dt);
            //dtg_dependente.DataSource = dt.DefaultView;
            dtg_projetos.Columns[0].HeaderText = "Nome";
            dtg_projetos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_projetos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_projetos.Columns[1].HeaderText = "Tipo";
            dtg_projetos.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_projetos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_projetos.Columns[2].HeaderText = "Verba";
            dtg_projetos.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_projetos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_projetos.Columns[3].HeaderText = "Departamento";
            dtg_projetos.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_projetos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_projetos.Columns[4].HeaderText = "CPF Funcionario";
            dtg_projetos.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_projetos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_projetos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void FrmProjetos_Load(object sender, EventArgs e)
        {
            Atualiza();
            btnShowDependente.Visible = false;
            btnEditarDependente.Visible = false;
            btnRemoverDependente.Visible = false;
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

            }
        }
    }
}
