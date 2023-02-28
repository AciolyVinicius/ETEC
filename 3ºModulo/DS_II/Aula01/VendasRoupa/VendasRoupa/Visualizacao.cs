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
    public partial class Visualizacao : Form
    {
        public Visualizacao()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vendasRoupaDataSet);

        }

        private void Visualizacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendasRoupaDataSet.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.vendasRoupaDataSet.Produto);

        }

        private void produtoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Venda venda = new Venda();
            venda.Show();
        }

        private void informaçãoDaLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoStore info = new InfoStore();
            info.Show();
        }

        private void ediçãoDosProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProduts edit = new EditProduts();
            edit.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Finalizar Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
