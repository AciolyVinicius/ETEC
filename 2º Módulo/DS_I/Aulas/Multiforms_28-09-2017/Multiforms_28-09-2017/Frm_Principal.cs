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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_segundo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Frm_Segundo>().Count() > 0)
            {
                Form segundo = Application.OpenForms["Frm_Segundo"];
                segundo.Show();
                this.Hide();
            }
            else
            {
                Frm_Segundo segundo = new Frm_Segundo();
                segundo.Show();
                this.Hide();
            }
            
        }

        private void btn_terceiro_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Frm_Terceiro>().Count() > 0)
            {
                Form terceiro= Application.OpenForms["Frm_Terceiro"];
                terceiro.Show();
                this.Hide();
            }
            else
            {
                Frm_Terceiro terceiro = new Frm_Terceiro();
                terceiro.Show();
                this.Hide();
            }
            
        }
    }
}
