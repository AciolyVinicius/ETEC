using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA3_EXE10_MGVM_VAES
{
    public partial class frm_estacionamento : Form
    {
        public frm_estacionamento()
        {
            InitializeComponent();
        }

        private void btn_enunciado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Construa um programa para calcular o valor a ser pago pelo período de estacionamento do \n automóvel.O usuário entra com os seguintes dados: hora e minuto de entrada, hora e minuto \n de saída.Sabe - se que este estacionamento cobra hora cheia, ou seja, se passar um minuto ele \n cobra a hora inteira.O valor cobrado pelo estacionamento é: \n -R$ 4, 00 para 1 hora de estacionamento \n - R$ 6, 00 para 2 horas de estacionamento \n - R$ 1, 00 por hora adicional(acima de 2 horas) \n Apresentar em tela o valor cobrado.");
        }

        private void txt_hora_entrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txt_minuto_entrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txt_hora_saida_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txt_minuto_saida_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se é um número digitado
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            //pegando as variáveis
            float hrentrada = float.Parse(txt_hora_entrada.Text), minentrada = float.Parse(txt_minuto_entrada.Text), hrsaida = float.Parse(txt_hora_saida.Text), minsaida = float.Parse(txt_minuto_saida.Text);
            //calculando diferenças
            float difhr = hrsaida - hrentrada, difmin = minsaida - minentrada;
            int calcvalor = 0;
            if (hrentrada > 24 || hrsaida > 24 || minentrada > 60 || minsaida > 60)
            {
                MessageBox.Show("Algum campo foi preenchido inadequadamente.");
            }
            else
            {
                if (difhr <= 1)
                {
                    if (difmin < 1)
                    {
                        txt_valor.Text = "R$ 4,00";
                    }
                    else
                    {
                        txt_valor.Text = "R$ 6,00";
                    }
                }
                else if (difhr == 2 && difmin == 0)
                {
                    txt_valor.Text = "R$ 6,00";
                }
                else
                {
                    difhr = difhr - 2;
                    for (int i=0; i<difhr; i++)
                    {
                        calcvalor = 1 + calcvalor;
                    }
                    if (difmin > 0)
                    {
                        calcvalor = calcvalor + 1;
                    }
                    calcvalor = calcvalor + 6;
                    txt_valor.Text = "R$ "+calcvalor+",00";
                }
            }
        }
    }
}
