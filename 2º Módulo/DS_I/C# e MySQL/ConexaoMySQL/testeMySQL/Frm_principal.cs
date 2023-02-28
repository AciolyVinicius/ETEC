using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeMySQL
{
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Modelo mo = new Modelo();
            Acesso ac = new Acesso();

            mo.Nome = txt_nome.Text;
            mo.Email = txt_email.Text;

            ac.Cadastro(mo);

            txt_nome.Text = "";
            txt_email.Text = "";
        }
    }
}
