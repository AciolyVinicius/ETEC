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
    public partial class Venda : Form
    {
        public Venda()
        {
            InitializeComponent();
        }

        private void ediçãoDosProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProduts edit = new EditProduts();
            edit.Show();
        }

        private void informaçãoDaLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoStore info = new InfoStore();
            info.Show();
        }

        private void visualizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Visualizacao view = new Visualizacao();
            view.Show();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vendasRoupaDataSet);

        }

        private void Venda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendasRoupaDataSet.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.vendasRoupaDataSet.Produto);

        }

        private void produtoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Finalizar Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txt_qt_KeyPress(object sender, KeyPressEventArgs e)
        {
            int qtd;
            foreach (DataGridViewRow row in produtoDataGridView.Rows)
            {
                qtd = row.Index + 1;
            }
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void btn_vender_Click(object sender, EventArgs e)
        {
            
            int a = 0, verify = 0;
            Boolean ok = false;
            foreach (DataGridViewRow row in produtoDataGridView.Rows)
            {
                a = row.Index + 1;
                verify = Convert.ToInt32(produtoDataGridView.Rows[0].Cells[a].Value.ToString());
                
                int cd = Convert.ToInt32(txt_cd.Text);
                if (cd == verify)
                {
                    ok = true;
                    break;
                }
                else
                {
                    ok = false;
                }
            }
            if (txt_qt != null && txt_nm_comprador != null && txt_cd != null && ok == true)
            {
                MessageBox.Show("Compra efetuada!");
                txt_nm_comprador.Text = "";
                txt_qt.Text = "";
            }
            else
            {
                MessageBox.Show("O código digitado não existe");
            }
        }

        private void txt_cd_KeyPress(object sender, KeyPressEventArgs e)
        {            
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
