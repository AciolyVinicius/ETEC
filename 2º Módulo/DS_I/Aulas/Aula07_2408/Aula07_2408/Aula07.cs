using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula07_2408
{
    public partial class lbl_aula07 : Form
    {
        string nome; //Será o local de armazenamento do nome
        int posicao; //Será o local de armazenamento da posição
        public lbl_aula07()
        {
            InitializeComponent();
        }

        private void lbl_aula07_Load(object sender, EventArgs e)
        {
            lst_nome.Items.Add("Rubervinia");
            lst_nome.Items.Add("Virgulina");
            lst_nome.Items.Add("Zovaliana");

            cmb_nome.Items.Add("Abundensem");
            cmb_nome.Items.Add("Gotaskain");
            
        }

        private void lst_nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            posicao = lst_nome.SelectedIndex ;
            //ou nome = Convert.ToString(lst_nome.SelectedItem);
        }

        private void btn_excluirlist_Click(object sender, EventArgs e)
        {
            lst_nome.Items.RemoveAt(posicao);
            //lst_nome.Items.Remove(nome);
        }

        private void cmb_nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            posicao = cmb_nome.SelectedIndex;
            //ou nome = Convert.ToString(cmb_nome.SelectedItem);
        }

        private void btn_excluircombo_Click(object sender, EventArgs e)
        {
            posicao = cmb_nome.SelectedIndex;
            //ou nome = Convert.ToString(cmb_nome.SelectedItem);
        }
    }
}
