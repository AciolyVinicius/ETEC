using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAGA
{
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_login>().Count() > 0) {
                Form login = Application.OpenForms["frm_login"];
                login.Show();
                this.Hide();
            } else {
                frm_login login = new frm_login();
                login.Show();
                this.Hide();
            }            
        }
    }
}
