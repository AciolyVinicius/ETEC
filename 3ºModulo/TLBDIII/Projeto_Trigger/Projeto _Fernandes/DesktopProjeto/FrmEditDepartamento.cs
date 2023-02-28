using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopProjeto
{
    public partial class FrmEditDepartamento : Form
    {
        public FrmEditDepartamento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals(null) && !txtLocalizacao.Text.Equals(null) || !txtNome.Text.Equals("") && !txtLocalizacao.Text.Equals("")) {
                if (Application.OpenForms.OfType<FrmDepartamentos>().Count() > 0) {
                    Form segundo = Application.OpenForms["FrmDepartamentos"];
                    segundo.Show();
                    this.Hide();
                } else {
                    FrmDepartamentos segundo = new FrmDepartamentos();
                    segundo.Show();
                    this.Hide();
                }
            } else {
                MessageBox.Show("Preencha todos os campos corretamente!");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !(Char.IsWhiteSpace(e.KeyChar))) {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !(Char.IsWhiteSpace(e.KeyChar))) {
                e.Handled = true;
            }
        }
    }
}
