using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA4_EXE3_MGVM_VAES
{
    public partial class Exame : Form
    {

        String nome, sexo, gravidez, prostata, sangue, raiox, a;

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            ckb_gravidez.Checked = false;
            ckb_prostata.Checked = false;
            ckb_raio.Checked = false;
            ckb_sangue.Checked = false;
            txt_nome.Text = "";
            rdb_feminino.Checked = false;
            rdb_masculino.Checked = false;
            ckb_prostata.Enabled = false;
            ckb_gravidez.Enabled = false;
            txt_nome.Focus();

        }

        private void rdb_feminino_CheckedChanged(object sender, EventArgs e)
        {
            ckb_gravidez.Enabled = true;
            ckb_prostata.Enabled = false;
            ckb_prostata.Checked = false;
        }

        private void rdb_masculino_CheckedChanged(object sender, EventArgs e)
        {
            ckb_prostata.Enabled = true;
            ckb_gravidez.Enabled = false;
            ckb_gravidez.Checked = false;
        }

        public Exame()
        {
            InitializeComponent();
            ckb_gravidez.Enabled = false;
            ckb_prostata.Enabled = false;
        }

        private void Exame_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text != null && rdb_feminino.Checked == true || rdb_masculino.Checked == true && ckb_gravidez.Checked == true || ckb_prostata.Checked == true || ckb_raio.Checked == true || ckb_sangue.Checked == true)
            {
                nome = txt_nome.Text;
                if (rdb_masculino.Checked)
                {
                    sexo = "Masculino";
                    a = "O senhor";

                }
                else
                {
                    sexo = "Feminino";
                    a = "A senhora";
                }
                if
                    (ckb_gravidez.Checked == true)
                {
                    gravidez = "\n Gravidez";
                }
                else
                {
                    gravidez = "";
                }
                if (ckb_prostata.Checked == true)
                {
                    prostata = "\n Prostata";
                }
                else
                {
                    prostata = "";
                }
                if(ckb_raio.Checked == true)
                {
                    raiox = "\n Raio X";
                }
                else
                {
                    raiox = "";
                }
                if(ckb_sangue.Checked == true)
                {
                    sangue = "\n Sangue";
                }
                else
                {
                    sangue = "";
                }
                MessageBox.Show(""+ a + " cadastrou seu exame corretamente:" + "\n Sexo: "+ sexo + "\n Exame (s):"+
                    sangue + prostata + raiox + gravidez);
            }
            else
            {
                MessageBox.Show("Todos atributos devem ser preenchidos!");
            }
        }
    }
}
