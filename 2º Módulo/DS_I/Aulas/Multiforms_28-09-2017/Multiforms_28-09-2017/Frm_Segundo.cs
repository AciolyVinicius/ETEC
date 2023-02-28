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
    public partial class Frm_Segundo : Form
    {
        public Frm_Segundo()
        {
            InitializeComponent();
        }

        private void btn_principal_Click(object sender, EventArgs e)
        {
            Form principal = Application.OpenForms["Frm_Principal"];
            principal.Show();
            this.Dispose();
        }

        private void btn_terceiro_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Frm_Terceiro>.Count() > 0)
            {
                Frm_Terceiro terceiro = new Frm_Terceiro();
                terceiro.Show();
                this.Dispose();
            }
            else
            {
                
            }
        }

        private void txt_input_TextChanged(object sender, EventArgs e)
        {
            txt_output.Text = txt_input.Text;
        }
    }
}
