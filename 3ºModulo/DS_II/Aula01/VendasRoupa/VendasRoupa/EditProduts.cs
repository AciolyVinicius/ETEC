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
    public partial class EditProduts : Form
    {
        public EditProduts()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vendasRoupaDataSet);

        }

        private void EditProduts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendasRoupaDataSet.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.vendasRoupaDataSet.Produto);

        }

        private void valorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void informaçãoDaLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoStore info = new InfoStore();
            info.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Venda venda = new Venda();
            venda.Show();
        }

        private void visualizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Visualizacao view = new Visualizacao();
            view.Show();
        }

        private void EditProduts_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Finalizar Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void cd_produtos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar)|| double.IsPositiveInfinity(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
