using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA2_EXE5_MGVM_VAES
{
    public partial class lbl_produto : Form
    {
        public lbl_produto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Receba a descrição de um produto, seu preço e a quantidade vendida. Calcule o total da compra.Exiba o preço do produto em três formas de pagamentos: -Á vista com 20 % de desconto 30 dias com 5 % de desconto -Em até 4 pagamentos de: Exiba o valor da parcela Insira um botão finalizar Insira um botão nova venda (Limpe as informações digitadas e posicione o cursor na descrição do produto).");
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            String descricao = txt_descricao.Text;
            float preco = float.Parse(txt_preco.Text);
            int qtd = int.Parse(txt_qtd.Text);
            float precof = preco * qtd;

            txt_compra.Text = "" + precof;
             
            float precoavista = precof - precof * 20 /100;
            txt_avista.Text = "" + precoavista;

            float preco30 = precof - precof * 5 / 100;
            txt_30dias.Text = "" + preco30;

            float precoparcela = precof/4;
            txt_4parcelas.Text = "" + precoparcela;
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Finalizar Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_novaVenda_Click(object sender, EventArgs e)
        {
            txt_avista.Text = "";
            txt_descricao.Text = "";
            txt_30dias.Text = "";
            txt_4parcelas.Text = "";
            txt_preco.Text = "";
            txt_qtd.Text = "";
            txt_compra.Text = "";
            txt_descricao.Focus();          
        }
    }
}
