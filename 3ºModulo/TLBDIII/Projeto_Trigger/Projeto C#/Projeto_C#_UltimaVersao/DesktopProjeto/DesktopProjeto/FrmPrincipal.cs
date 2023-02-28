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
    public partial class FrmPrincipal : Form
    {
        WebProjeto.WebService1SoapClient serv = new WebProjeto.WebService1SoapClient();
        public FrmPrincipal()
        {
            InitializeComponent();
            carregaProjetoConcluido();
            carregaProjetoAndamento();
        }

        public void carregaProjetoConcluido()
        {
            dtg_projeto_cocluido.DataSource = serv.ProjetoConcluido().DefaultView;
        }
        public void carregaProjetoAndamento()
        {
            dtg_projetos_andamento.DataSource = serv.ProjetoAndamento().DefaultView;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            carregaProjetoConcluido();
            carregaProjetoAndamento();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionarios funcionarios = new FrmFuncionarios();
            funcionarios.Visible = true;
            this.Hide();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Visible = true;
            this.Hide();
        }

        private void projetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProjetos projetos = new FrmProjetos();
            projetos.Show();
            this.Hide();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartamentos departamentos = new FrmDepartamentos();
            departamentos.Visible = true;
            this.Hide();
        }

        private void dependentesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDependentes dependentes = new FrmDependentes();
            dependentes.Visible = true;
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAddProjetoConcluido_Click(object sender, EventArgs e)
        {
            if (dtg_projetos_andamento.SelectedRows.Count > 0)
            {
                serv.UpdateProjetoIc(int.Parse(dtg_projetos_andamento.SelectedRows[0].Cells[0].Value.ToString()), true);
                carregaProjetoConcluido();
                carregaProjetoAndamento();
            }
        }

        private void projetosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmProjetos editFuncionario = new FrmProjetos();
            editFuncionario.Visible = true;
            this.Dispose();
        }
    }
}
