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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Form voltando = Application.OpenForms["Form1"];
            voltando.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = ClasseAcesso.Str1;
            textBox2.Text = ClasseAcesso.Str2;
        }
    }
}