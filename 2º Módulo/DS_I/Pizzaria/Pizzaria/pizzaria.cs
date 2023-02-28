using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class pizzaria : Form
    {
        public pizzaria()
        {
            InitializeComponent();
        }

        private void btn_finalizar_compra_Click(object sender, EventArgs e)
        {
            Boolean stop = false, sabor = true;
            if (lst_pizza1.SelectedItem != null)
            {
                int numberingpizzas = 0;
                if (lst_pizza1.SelectedItem.Equals("Calabresa	R$15,00"))
                {
                    numberingpizzas = 1;
                }
                else if (lst_pizza1.SelectedItem.Equals("Mussarela	R$15,00"))
                {
                    numberingpizzas = 2;
                }
                else if (lst_pizza1.SelectedItem.Equals("Portuguesa	R$16,50"))
                {
                    numberingpizzas = 3;
                }
                else if (lst_pizza1.SelectedItem.Equals("Quatro queijos	R$20,00"))
                {
                    numberingpizzas = 4;
                }
                else if (lst_pizza1.SelectedItem.Equals("Aliche		R$25,00"))
                {
                    numberingpizzas = 5;
                }
                int numberingpizzas2 = 0;
                Boolean verifying = false;
                if (ckb_meia.Checked)
                {
                    verifying = true;
                }
                else
                {
                    verifying = false;
                }
                if (verifying==true)
                {
                    if (lst_pizza2.SelectedItem != null)
                    {
                        if (lst_pizza2.SelectedItem.Equals("Calabresa	R$15,00"))
                        {
                            numberingpizzas2 = 1;
                        }
                        else if (lst_pizza2.SelectedItem.Equals("Mussarela	R$15,00"))
                        {
                            numberingpizzas2 = 2;
                        }
                        else if (lst_pizza2.SelectedItem.Equals("Portuguesa	R$16,50"))
                        {
                            numberingpizzas2 = 3;
                        }
                        else if (lst_pizza2.SelectedItem.Equals("Quatro queijos	R$20,00"))
                        {
                            numberingpizzas2 = 4;
                        }
                        else if (lst_pizza2.SelectedItem.Equals("Aliche		R$25,00"))
                        {
                            numberingpizzas2 = 5;
                        }
                    }
                    else
                    {
                        stop = true;
                    }
                }
                double valor = 0;
                if (ckb_borda.Checked)
                {
                    if (lst_borda_recheada.SelectedItem != null)
                    {
                        valor = valor + 1.5;
                    }
                    else
                    {
                        stop = true;
                    }
                }
                if (numberingpizzas > numberingpizzas2)
                {
                    switch (numberingpizzas) {
                        case 1: valor=valor+15;
                            break;
                        case 2: valor = valor + 15;
                            break;
                        case 3: valor = valor + 16.50;
                            break;
                        case 4: valor = valor + 20;
                            break;
                        case 5: valor = valor + 25;
                            break;
                    }
                }
                else if (numberingpizzas < numberingpizzas2)
                {
                    switch (numberingpizzas2)
                    {
                        case 1:
                            valor = valor + 15;
                            break;
                        case 2:
                            valor = valor + 15;
                            break;
                        case 3:
                            valor = valor + 16.50;
                            break;
                        case 4:
                            valor = valor + 20;
                            break;
                        case 5:
                            valor = valor + 25;
                            break;
                    }
                }
                else
                {
                    stop = true;
                    sabor = false;
                }
                valor = valor + 2;
                if (!stop)
                {
                    MessageBox.Show("Valor a ser pago: R$" + valor + "\n Foi cobrado 2 reais a mais pela entrega, obrigado a compreensão!");
                }
                else
                {
                    String taste = "";
                    if (sabor == false)
                    {
                        taste = "Os sabores, sendo 1/2, não podem ser iguais!";
                    }
                    MessageBox.Show("Preencha tudo corretamente! "+taste);
                }
            }
            else
            {
                MessageBox.Show("Preencha tudo corretamente!");
            }

        }

        private void ckb_meia_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_meia.Checked)
            {
                lst_pizza2.Enabled = true;
            }
            else
            {
                lst_pizza2.Enabled = false;
            }
        }

        private void ckb_borda_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_borda.Checked)
            {
                lst_borda_recheada.Enabled = true;
            }
            else
            {
                lst_borda_recheada.Enabled = false;
            }
        }

        private void btn_nova_pizza_Click(object sender, EventArgs e)
        {
            pizzaria pizzas = new pizzaria();
            pizzas.Show();
            this.Hide();
        }
    }
}
