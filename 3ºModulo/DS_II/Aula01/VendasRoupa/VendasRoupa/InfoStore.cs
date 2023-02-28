using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendasRoupa
{
    public partial class InfoStore : Form
    {
        public InfoStore()
        {
            InitializeComponent();
        }

        private void ediçãoDosProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProduts edit = new EditProduts();
            edit.Show();
        }

        private void visualizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Visualizacao view = new Visualizacao();
            view.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Venda venda = new Venda();
            venda.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja sair?", "Finalizar Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
