using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDMySQL
{
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            // Verificando se o usuário deseja sair com certeza
            DialogResult resultado = MessageBox.Show("Certeza que deseja sair?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes) //Se sim,
                Dispose(); // Excluo o formulário atual da memória RAM

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {            
            // Instancio um objeto da classe Frm_inserir
            Frm_inserir inserir = new Frm_inserir();
            // Exibo ele
            inserir.Show();
            // Escondo esse
            this.Hide();               
        }

        private void btn_selecionar_Click(object sender, EventArgs e)
        {
            // Instancio um objeto da classe Frm_selecionar
            Frm_selecionar selecionar = new Frm_selecionar();
            // Exibo ele
            selecionar.Show();
            // Escondo esse
            this.Hide();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            // Instancio um objeto da classe Frm_atualizar
            Frm_atualizar atualizar = new Frm_atualizar();
            // Exibo ele
            atualizar.Show();
            // Escondo esse
            this.Hide();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            // Instancio um objeto da classe Frm_excluir
            Frm_excluir excluir = new Frm_excluir();
            // Exibo ele
            excluir.Show();
            // Escondo esse
            this.Hide();
            
        }
    }
}
