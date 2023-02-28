using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Separador
{
    public partial class Frm_separador : Form
    {
        public Frm_separador()
        {
            InitializeComponent();
        }

        private void btn_separador_Click(object sender, EventArgs e)
        {
            lst_separar.Items.Clear();
            if (txt_token.Text != "")
            {
                if(txt_input.Text != "")
                {
                    #region separar
                    string input = txt_input.Text;
                    char token = char.Parse(txt_token.Text);
                    String[] output = input.Split(token);
                    foreach(string x in output)
                    {
                        lst_separar.Items.Add(x);
                    }
                    #endregion
                }
                else
                {
                    MessageBox.Show("Preencha o Input!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Preencha o Token!!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
