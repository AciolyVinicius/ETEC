using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA2_EXE1_MGVM_VAES
{
    public partial class lbl_CalcArea : Form
    {
        public lbl_CalcArea()
        {
            InitializeComponent();
        }

        private void txt_n1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            float num1, num2;
            num1 = float.Parse(txt_n1.Text);
            num2 = float.Parse(txt_n2.Text);
            txt_area.Text = Convert.ToString(num1 * num2);
        }

        private void btn_enunciado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solicitar ao usuário entrar com os valores do comprimento das paredes (L e C), calcule a área e apresente.");
        }
    }
}
