using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA5_EXE1_MGVM_VAES
{
    public partial class frm_imc : Form
    {
        public frm_imc()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_menu menu = new frm_menu();
            menu.Show();
            this.Hide();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (txt_altura.Text == null || txt_peso.Text == null || txt_altura.Text == "" || txt_peso.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                Double imc, height = Double.Parse(txt_altura.Text), weight = Double.Parse(txt_peso.Text);
                imc = weight/(height*height);
                String stringimc=String.Format("{0:N2}",imc);
                String according = "";
                if (imc>=40)
                {
                    according = "Obesidade grau III";
                }
                else if (imc >=35 && imc <40)
                {
                    according = "Obesidade grau II";
                }
                else if (imc >= 30 && imc < 35)
                {
                    according = "Obesidade grau I";
                }
                else if (imc >=25 && imc <30)
                {
                    according = "Levemente acima do peso"; 
                }
                else if (imc >= 18.6 && imc < 25)
                {
                    according = "Peso ideal";}
                else
                {
                    according = "Abaixo do peso";
                }
                MessageBox.Show("IMC " + stringimc +"\n"+according);
            }
        }

        private void txt_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)||char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IMC:\n Abaixo de 18,5 - Abaixo do peso \n Entre 18,6 e 24,9 - Peso ideal \n"+
               " Entre 25 e 29,9 - Levemente acima do peso \n Entre 30 e 34,9 - Obesidade grau I \n Entre 35 e 39,9 - Obesidade grau II \n Acima de 40 - Obesidade grau III");
        }
    }
}
