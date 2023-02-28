using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA2_EXE11_MGVM_VAES
{
    public partial class lbl_tanquecarro : Form
    {
        double vl_gasolina = 25/10;
        double vl_alcool = 19/10;
        public lbl_tanquecarro()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            String capacidadet = txt_capacidade.Text;
            double capacidade = double.Parse(capacidadet);
            double variante=1;
            if (rdb_combustivel.Checked == true)
            {
                variante = vl_gasolina;
            }
            else if (rdb_alcool.Checked==true){
                variante = vl_alcool;
            }
            txt_gasto.Text = ""+capacidade * variante;
        }

        private void btn_enunciado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Construa um programa que determine quanto será gasto para encher o tanque de um carro, sabendo-se que o preço da gasolina é de R$ 2,50 e o preço do álcool é de R$ 1,90. O usuário fornecerá os seguintes dados: Tipo de carro (G – gasolina ou A – álcool) e Capacidade do tanque (CT), em litros. ");
        }
    }
}
