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
    public partial class frm_ordem : Form
    {
        public frm_ordem()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_um_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_dois_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_tres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_menu menu = new frm_menu();
            menu.Show();
            this.Hide();
        }

        private void btn_enter_Click_1(object sender, EventArgs e)
        {
            if (txt_um.Text == "" || txt_dois.Text == "" || txt_tres.Text == "" || txt_um.Text == null || txt_dois.Text == null || txt_tres.Text == null)
            {

                MessageBox.Show("Todos os campos devem ser preenchidos corretamente!");
            }
            else
            {
                if (txt_um.Text.Equals(txt_dois.Text) || txt_um.Text.Equals(txt_tres.Text) || txt_dois.Text.Equals(txt_tres.Text))
                {
                    MessageBox.Show("Os números digitados não podem ser iguais!");
                }
                else
                {
                    double um = double.Parse(txt_um.Text), dois = double.Parse(txt_dois.Text), tres = double.Parse(txt_tres.Text);
                    double first, second, third;
                    if (um != dois && um != tres && dois != tres)
                    {
                        if (um > dois)
                        {
                            if (um > tres)
                            {
                                if (dois > tres)
                                {
                                    first = um;
                                    second = dois;
                                    third = tres;
                                }
                                else
                                {
                                    first = um;
                                    second = tres;
                                    third = dois;
                                }
                            }
                            else
                            {
                                first = tres;
                                second = um;
                                third = dois;
                            }
                        }
                        else
                        {
                            if (dois > tres)
                            {
                                if (tres > um)
                                {
                                    first = dois;
                                    second = tres;
                                    third = um;
                                }
                                else
                                {
                                    first = dois;
                                    second = um;
                                    third = tres;
                                }
                            }
                            else
                            {
                                first = tres;
                                second = dois;
                                third = um;
                            }
                        }
                        MessageBox.Show("Ordem Crescente: \n" + first + "\n" + second + "\n" + third);
                    }
                }
            }
        }
    }
}
