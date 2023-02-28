using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiforms_28_09_2017
{
    public partial class Frm_Terceiro : Form
    {
        public Frm_Terceiro()
        {
            InitializeComponent();
        }

        private void btn_principal_Click(object sender, EventArgs e)
        {
            Form principal = Application.OpenForms["Frm_Principal"];
            principal.Show();
            this.Close();
        }

        private void btn_segundo_Click(object sender, EventArgs e)
        {
            Frm_Segundo segundo = new Frm_Segundo();
            segundo.Show();
        }

        private void txt_input_TextChanged(object sender, EventArgs e)
        {
            txt_output.Text = txt_input.Text;
        }
    }
}
