using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace GetSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                MessageBox.Show("Preencher todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt2.Text == "")
            {
                MessageBox.Show("Preencher todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClasseAcesso.Nome.Add(txt1.Text);
                ClasseAcesso.Numero.Add(txt2.Text);
                //ClasseAcesso.Str2 = txt2.Text;
                MessageBox.Show("Dados enviados");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciação do Form2
            Form2 f = new Form2();
            //Objeto sendo mostrado na tela
            f.Show();
            //Este formulário fica oculto na memória.
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Focus();
        }
    }
}
