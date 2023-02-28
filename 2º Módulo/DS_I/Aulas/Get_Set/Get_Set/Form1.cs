using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Get_Set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_form2_Click(object sender, EventArgs e)
        {
            Form2 outroform = new Form2();
            outroform.Show();
            this.Hide();

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            String texto = textBox1.Text;
            ClasseAcesso.Str1 = textBox1.Text;
            String text = textBox2.Text;
            ClasseAcesso.Str2 = textBox2.Text;
        }
    }
}
