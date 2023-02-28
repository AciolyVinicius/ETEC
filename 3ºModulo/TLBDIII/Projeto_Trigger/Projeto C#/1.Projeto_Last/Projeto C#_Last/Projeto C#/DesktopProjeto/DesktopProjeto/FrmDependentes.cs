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
    public partial class FrmDependentes : Form
    {
        private object adptAtualiza;

        public FrmDependentes()
        {
            InitializeComponent();
            btnEditarDependente.Visible = false;
            btnRemoverDependente.Visible = false;
            btnShowDependente.Visible = false;
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

        private void btnAddDependente_Click(object sender, EventArgs e)
        {
            FrmAddDependente addDependente = new FrmAddDependente();
            addDependente.Visible = true;
        }

        private void btnEditarDependente_Click(object sender, EventArgs e)
        {
            FrmEditDependente editDependente = new FrmEditDependente();
            editDependente.Visible = true;
        }

        public void Atualiza()
        {
            //DataTable dt = new DataTable();
            //adptAtualiza.Fill(dt);
            //dtg_dependente.DataSource = dt.DefaultView;
            dtg_dependente.Columns[0].HeaderText = "Nome do Dependente";
            dtg_dependente.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_dependente.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_dependente.Columns[1].HeaderText = "Parentesco";
            dtg_dependente.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_dependente.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtg_dependente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void FrmDependentes_Load(object sender, EventArgs e)
        {
            Atualiza();
        }

        public void dtg_dependente_CellContentClick(object sender, DataGridViewCellCancelEventArgs e)
        {
            int indiceselecionado = -1;
            // Se o usuário selecionou a Linha
            if (dtg_dependente.SelectedRows.Count > 0)
            {
                indiceselecionado = dtg_dependente.SelectedRows[0].Index;
                btnEditarDependente.Visible = true;
                btnShowDependente.Visible = true;
                btnRemoverDependente.Visible = true;
            }
            else
            { // Se o usuário selecionou a célula
                if (dtg_dependente.SelectedCells.Count > 0)
                {
                    indiceselecionado = dtg_dependente.SelectedCells[0].RowIndex;
                    btnEditarDependente.Visible = true;
                    btnShowDependente.Visible = true;
                    btnRemoverDependente.Visible = true;
                }
            }
            if (indiceselecionado != -1)
            {
                DataRowView dr = (DataRowView)dtg_dependente.Rows[indiceselecionado].DataBoundItem;
                btnEditarDependente.Visible = true;
                btnShowDependente.Visible = true;
                btnRemoverDependente.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void btnRemoverDependente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover este dependente do sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
            }
        }

        private void btnShowDependente_Click(object sender, EventArgs e)
        {
            FrmShowDependente showDependente = new FrmShowDependente();
            showDependente.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
