using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA2_EXE9_MGVM_VAES
{
    public partial class lbl_turista : Form
    {
        public lbl_turista()
        {
            InitializeComponent();
        }

        private void btn_enunciado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Faça um programa que calcule o valor em Reais, correspondente aos dólares que um turista possui no cofre do hotel. O programa deve solicitar os seguintes dados: Quantidade de dólares guardados no cofre e cotação do dólar no dia. ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dolart = (txt_dolar.Text), cotacaot = (txt_cotacao.Text);
            double dolar = float.Parse(dolart);
            double cotacao = float.Parse(cotacaot);
            double real = dolar * cotacao;
            txt_real.Text = "" + real;
        }
    }
}
