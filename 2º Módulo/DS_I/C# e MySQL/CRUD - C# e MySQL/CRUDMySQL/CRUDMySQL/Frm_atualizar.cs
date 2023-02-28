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
    public partial class Frm_atualizar : Form
    {
        public Frm_atualizar()
        {
            InitializeComponent();
        }

        private void rdb_nome_CheckedChanged(object sender, EventArgs e)
        {
            // Para mudar o nome da label de acordo com o que se quer atualizar no banco
            if (rdb_nome.Checked)               
                lbl_novo.Text = "Nome novo: ";
            else                           
                lbl_novo.Text = "E-mail novo: ";  
                         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificando se o usuário deseja sair com certeza
            DialogResult resultado = MessageBox.Show("Certeza que deseja sair?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes) // Se sim, então
            {
                // Reabro o formulário principal, que está aberto com certeza
                Form sair = Application.OpenForms["Frm_principal"];
                // Só para poder excluir ele da memória RAM
                sair.Dispose();
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            // Voltar para o formulário frm_principal 

            // Reabro o formulário frm_principal, que está aberto com certeza
            Form voltar = Application.OpenForms["Frm_principal"];
            // Excluo o formulário atual da memória RAM 
            this.Dispose();
            // E exibo o formulário frm_principal
            voltar.Show();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (txt_email.Text != null && txt_email.Text != "") // Se o usuário preencheu a caixa de texto txt_email
            {
                if (txt_novo.Text != null && txt_novo.Text != "") // E preencheu a caixa de texto txt_novo
                {
                    AtualizarDados registro; // Objeto para enviar dados através do formulário para o banco de dados
                    Alterar atualizar; // Objeto responsável pela conexão com o banco de dados, para atualizar os dados
                    bool teste = false; // Verifica se os dados foram atualizados, de fato

                    if (rdb_email.Checked) // Se o usuário deseja atualizar o e-mail
                    {
                        registro = new AtualizarDados(); // Instanciando objeto para envio de dados
                        atualizar = new Alterar(); // Instanciando objeto de conexão com o banco

                        // Enviando dados para o objeto AtualizarDados
                        registro.Email_atual = txt_email.Text.ToUpper(); 
                        registro.Email_novo = txt_novo.Text.ToUpper(); 
                        
                        // Obtendo retorno da execução do Query - retorna true se alguma linha foi afetada pelo Query
                        teste = atualizar.Atualizar(registro);                                              
                    }
                    else // Senão, então ele deseja atualizar o nome
                    {
                        registro = new AtualizarDados(); // Objeto para enviar dados através do formulário para o banco de dados
                        atualizar = new Alterar(); // Objeto responsável pela conexão com o banco de dados, para atualizar os dados
                        
                        // Enviando dados através do objeto registro, da classe AtualizarDados
                        registro.Email_atual = txt_email.Text.ToUpper();
                        registro.Nome_novo = txt_novo.Text.ToUpper();
                        
                        // Obtendo retorno da execução do Query - retorna true se alguma linha foi afetada pelo Query
                        teste = atualizar.Atualizar(registro);
                    }

                    if (teste) // Se o retorno da execução é true, eu informo sucesso de atualização
                        MessageBox.Show("Dado atualizado com sucesso!", "Atualizar Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else // Se não, anuncio que houve um erro
                        MessageBox.Show("Erro ao atualizar dado!", "Atualizar Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
        }
    }
}
