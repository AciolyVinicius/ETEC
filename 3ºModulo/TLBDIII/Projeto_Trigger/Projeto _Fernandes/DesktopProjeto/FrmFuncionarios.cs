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
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
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

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            Atualiza();
            btnShowDependente.Visible = false;
            btnEditarDependente.Visible = false;
            btnRemoverDependente.Visible = false;
        }

        public void Atualiza()
        {
            //DataTable dt = new DataTable();
            //adptAtualiza.Fill(dt);
            //dtg_dependente.DataSource = dt.DefaultView;
            dtg_funcionarios.Columns[0].HeaderText = "Nome";
            dtg_funcionarios.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_funcionarios.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_funcionarios.Columns[1].HeaderText = "Telefone";
            dtg_funcionarios.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_funcionarios.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_funcionarios.Columns[2].HeaderText = "Salario";
            dtg_funcionarios.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_funcionarios.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_funcionarios.Columns[3].HeaderText = "Departamento";
            dtg_funcionarios.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_funcionarios.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_funcionarios.Columns[4].HeaderText = "Gerente";
            dtg_funcionarios.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_funcionarios.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_funcionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

            }
        }
    }
}
