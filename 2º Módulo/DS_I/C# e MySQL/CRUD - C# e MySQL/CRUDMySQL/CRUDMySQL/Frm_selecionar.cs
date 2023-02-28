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
    public partial class Frm_selecionar : Form
    {
        public Frm_selecionar()
        {
            InitializeComponent();
        }

        private void rdb_codigo_CheckedChanged(object sender, EventArgs e)
        {
            // Firula - para mudar o texto da label conforme a opção selecionada para argumento de seleção
            if (rdb_codigo.Checked)            
                lbl_entrada.Text = "Código: ";
    
        }

        private void rdb_nome_CheckedChanged(object sender, EventArgs e)
        {
            // Firula - para mudar o texto da label conforme a opção selecionada para argumento de seleção
            if (rdb_nome.Checked)
                lbl_entrada.Text = "Nome: ";
        }

        private void rdb_email_CheckedChanged(object sender, EventArgs e)
        {
            // Firula - para mudar o texto da label conforme a opção selecionada para argumento de seleção
            if (rdb_email.Checked)
                lbl_entrada.Text = "E-mail: ";
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            // Para voltar ao formulário principal

            // Reabro o formulário Frm_principal solto pela memória RAM
            Form voltar = Application.OpenForms["Frm_principal"];
            // Excluo esse atual da memória RAM
            this.Dispose();
            // Exibo o frm_principal
            voltar.Show();            
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            // Saber se o usuário quer sair com certeza
            DialogResult resultado = MessageBox.Show("Certeza que deseja sair?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes) // Se sim, então
            {
                // Reabro o formulário principal
                Form sair = Application.OpenForms["Frm_principal"];
                // Só pra poder exclui-lo da memória RAM
                sair.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_entrada.Text != null && txt_entrada.Text != "") // Se o usuário preencheu o argumento de seleção
            {
                // Instancio objetos para enviar os dados através do formulário e para conectar com o banco, respectivamente
                ObterDados registro = new ObterDados(); 
                Selecionar pesquisa = new Selecionar();

                String exibir = "P A U"; // Armazena o resultado da Query para exibir na label

                if (rdb_codigo.Checked) // Se ele escolheu o código como argumento de seleção, então
                {
                    int codigo = int.Parse(txt_entrada.Text); // O que ele digita na caixa de texto é o código do usuário

                    registro.Codigo = codigo; // Envio o código digitado através do objeto da classe ObterDados
                    exibir = pesquisa.Pesquisar(registro); /* E armazeno o retorno da execução do Query (o SELECT) que se dá pelo
                    objeto pesquisa, da classe Selecionar, que contém o método Pesquisar */
                }
                else if (rdb_email.Checked) // Senão, se ele escolheu o e-mail como argumento de seleção, então
                {
                    String email = txt_entrada.Text.ToUpper(); 

                    registro.Email = email; // Envio o e-mail digitado através do objeto registro da classe ObterDados
                    exibir = pesquisa.Pesquisar(registro); /* E armazeno o retorno da execução do Query (o SELECT) que se dá pelo
                    objeto pesquisa, da classe Selecionar, que contém o método Pesquisar */
                }
                else if (rdb_nome.Checked) // Senão, se ele escolheu o nome como argumento de seleção, então
                {
                    String nome = txt_entrada.Text.ToUpper();

                    registro.Nome = nome; // Envio o nome digitado através do objeto registro da classe ObterDados
                    exibir = pesquisa.Pesquisar(registro); /* E armazeno o retorno da execução do Query (o SELECT) que se dá pelo
                    objeto pesquisa, da classe Selecionar, que contém o método Pesquisar */
                }

                lbl_resultado.Text = exibir; // Exibo na label lbl_resultado
            }
        }
    }
}
