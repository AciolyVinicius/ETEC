using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA2_EXE7_MGVM_VAES
{
    public partial class lbl_produto : Form
    {
        public lbl_produto()
        {
            InitializeComponent();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Faça um programa para calcular quanto será pago por um produto, sendo que o preço do produto e o desconto são fornecidos pelo usuário. Apresentar o valor a ser pago pelo produto. ");
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            String precot =(txt_preco.Text), descontot = (txt_desconto.Text);
            float preco = float.Parse(precot);
            float desconto = float.Parse(descontot);
            double descontopc = preco * desconto / 100;
            double pagar = preco - descontopc;
            txt_pagar.Text = "" + pagar;
        }
    }
}
