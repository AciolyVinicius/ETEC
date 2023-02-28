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
    public partial class FrmDependentes : Form
    {
        WebProjeto.WebService1SoapClient serv = new WebProjeto.WebService1SoapClient();
        public FrmDependentes()
        {
            InitializeComponent();
            carregaDep();
        }

        public void carregaDep()
        {
            dtg_dependente.DataSource = serv.Dependente().DefaultView;
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
                FrmAddDependente segundo = new FrmAddDependente();
                segundo.Show();
        }

        private void btnEditarDependente_Click(object sender, EventArgs e)
        {              
                FrmEditDependente segundo = new FrmEditDependente();
                segundo.Show();
        }


        private void FrmDependentes_Load(object sender, EventArgs e)
        {
        }

        public void dtg_dependente_CellContentClick(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void btnRemoverDependente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover este dependente do sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (dtg_dependente.SelectedRows.Count > 0)
                {
                    serv.ExcluiDependente(int.Parse(dtg_dependente
                    .SelectedRows[0].Cells[0].Value.ToString()), int.Parse(dtg_dependente
                    .SelectedRows[0].Cells[4].Value.ToString()));
                    carregaDep();
                }
            }
        }

        private void btnShowDependente_Click(object sender, EventArgs e)
        {
                FrmShowDependente segundo = new FrmShowDependente();
                segundo.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmDependentes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("DESEJA FERCHAR O FORMULÁRIO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnAt_Click(object sender, EventArgs e)
        {
            carregaDep();
        }

        private void projetosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmProjetos editFuncionario = new FrmProjetos();
            editFuncionario.Visible = true;
            this.Dispose();
        }
    }
}
