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
    public partial class frm_media : Form
    {
        public frm_media()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            if (txt_1.Text == "" || txt_2.Text == "" || txt_3.Text == "" || txt_4.Text == "" || txt_1.Text == null || txt_2.Text == null || txt_3.Text == null || txt_4.Text == null)
            {

                MessageBox.Show("Todos os campos devem ser preenchidos corretamente!");
            }
            else
            {
                double media = (Double.Parse(txt_1.Text) + Double.Parse(txt_2.Text) + Double.Parse(txt_3.Text) + Double.Parse(txt_4.Text)) / 4;
                if (Double.Parse(txt_1.Text) > 10 || Double.Parse(txt_2.Text) > 10 || Double.Parse(txt_3.Text) > 10 || Double.Parse(txt_4.Text) > 10)
                {
                    MessageBox.Show("Digite valores entre 0 e 10!\n(A média não pode ultrapassar 10)");
                }
                else
                {
                    if (media < 0 || media > 10)
                    {
                        MessageBox.Show("Média inválida! A média deve responder entre 0 e 10");
                    }
                    else
                    {
                        txt_media.Text = "" + media;
                        if (media >= 7)
                        {
                            MessageBox.Show("Aprovado!");
                        }
                        else if (media < 4)
                        {
                            MessageBox.Show("Reprovado!");
                        }
                        else
                        {
                            MessageBox.Show("Recuperação!");
                        }
                    }
                }
            }
        }

        private void txt_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_menu menu = new frm_menu();
            menu.Show();
            this.Hide();
        }
    }
}
