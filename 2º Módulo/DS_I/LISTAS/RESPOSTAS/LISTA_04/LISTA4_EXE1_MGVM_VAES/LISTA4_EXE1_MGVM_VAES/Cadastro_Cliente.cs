using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA4_EXE1_MGVM_VAES
{
    public partial class form_cadastro_cliente : Form
    {
        double valor = 0;
        public form_cadastro_cliente()
        {
            InitializeComponent();
            rdb_30_dias.Enabled = false;
            rdb_60_dias.Enabled = false;
        }

        private void btn_enunciado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crie um novo programa que contenha as seguintes especificações: Alguns pontos deste programa têm que ser levado em consideração: Se for primeira compra o cliente pode comprar somente a vista.Se o valor da compra for maior que 200 reais ele poderá comprar com 60 dias.Logicamente que no campo valor não poderá aparecer letras.Nenhum campo poderá estar em branco. Ao clicar em confirmar deverá ser exibido o nome do cliente, valor da compra e como será o pagamento.");
        }

        private void txt_nome_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void rdb_sim_primeira_compra_CheckedChanged(object sender, EventArgs e)
        {
            rdb_30_dias.Enabled = false;
            rdb_60_dias.Enabled = false;
        }

        private void rdb_nao_primeira_compra_CheckedChanged(object sender, EventArgs e)
        {
            rdb_30_dias.Enabled = true;
            if (valor >= 200 && rdb_nao_primeira_compra.Checked == true)
            {
                rdb_60_dias.Enabled = true;
            }
            else
            {
                rdb_60_dias.Enabled = false;
            }
        }

        private void txt_valor_compra_TextChanged(object sender, EventArgs e)
        {
            if (txt_valor_compra.TextLength > 0)
            {
                valor = Double.Parse(txt_valor_compra.Text);
            }
            if (valor >= 200 && rdb_nao_primeira_compra.Checked == true)
            {
                rdb_60_dias.Enabled = true;
            }
            else
            {
                rdb_60_dias.Enabled = false;
            }
        }

        private void txt_valor_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if ((rdb_vend1.Checked==true || rdb_vend2.Checked==true|| rdb_vend3.Checked==true|| rdb_vend4.Checked==true) && (rdb_avista.Checked==true || rdb_60_dias.Checked==true||rdb_30_dias.Checked==true) && (rdb_sim_primeira_compra.Checked==true || rdb_nao_primeira_compra.Checked==true)&&(txt_nome_cliente.Text!=null)&&(txt_valor_compra.Text!=null || txt_valor_compra.Text != ""))
            {
                String nome = txt_nome_cliente.Text, valorcompra = "" + valor, tipofatura="";
                if (rdb_avista.Checked == true)
                {
                    tipofatura = "A vista";
                }
                else if (rdb_30_dias.Checked == true)
                {
                    tipofatura = "Em 30 dias";
                }
                else
                {
                    tipofatura = "Em 60 dias";
                }
                MessageBox.Show("O nome do cliente é: "+nome+". \n O valor da compra será: R$"+valorcompra+ "\n O tipo da fatura será: "+tipofatura);
            }
            else
            {
                MessageBox.Show("Todos os itens do formulário devem ser preenchidos.");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            rdb_vend1.Checked = false;
            rdb_vend2.Checked = false;
            rdb_vend3.Checked = false;
            rdb_vend4.Checked = false;
            rdb_avista.Checked = false;
            rdb_60_dias.Checked = false;
            rdb_30_dias.Checked = false;
            rdb_sim_primeira_compra.Checked = false;
            rdb_nao_primeira_compra.Checked = false;
            txt_nome_cliente.Text = null;
            txt_valor_compra.Text = null;
        }

        private void form_cadastro_cliente_Load(object sender, EventArgs e)
        {

        }
    }
}

