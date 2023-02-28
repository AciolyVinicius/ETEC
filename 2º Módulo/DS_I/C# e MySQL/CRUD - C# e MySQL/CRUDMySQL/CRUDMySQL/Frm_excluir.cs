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
    public partial class Frm_excluir : Form
    {
        public Frm_excluir()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            // Para saber se o usuário quer, de fato, sair do aplicativo
            DialogResult resultado = MessageBox.Show("Certeza que deseja sair?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes) // Se sim, então
            {
                // Reabro o formulário principal 
                Form sair = Application.OpenForms["Frm_principal"];
                // e o excluo da memória RAM em seguida
                sair.Dispose();
            }

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            // Caso o usuário queira voltar para o formulário principal

            /* Com certeza, ele ainda está aberto, armazenado na memória RAM. 
            Instancio um objeto de classe Form que representa o formulário frm_principal
            que está ainda aberto*/
            Form voltar = Application.OpenForms["Frm_principal"]; 
            this.Dispose(); // Excluo o formulário atual da memória RAM
            voltar.Show(); // E exibo o formulário frm_principal
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txt_email.Text != null && txt_email.Text != "") // Se  a caixa de texto txt_email contém algum texto, então
            {
                // Pergunto ao usuário se ele deseja excluir o registro, com certeza
                DialogResult resultado = MessageBox.Show("Tem certeza de que quer Excluir o registro?", "Excluir Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resultado == DialogResult.Yes) // Se sim, então
                {
                    ObterDados registro = new ObterDados(); // Instanciando objeto da classe ObterDados
                    Remover excluir = new Remover(); // Instanciando objeto da classe Remover

                    // Enviando o que foi escrito pelo usuário na caixa de texto txt_email para o objeto registro
                    registro.Email = txt_email.Text.ToUpper();
                    // Obtendo retorno do método Excluir, do objeto excluir, da classe Remover - retorna se alguma linha foi afetada pelo Query ;D
                    bool teste = excluir.Excluir(registro);
                                        
                    if (teste) // Se teste retornar true, então
                        MessageBox.Show("Dados excluídos com sucesso!", "Excluir Dados", MessageBoxButtons.OK, MessageBoxIcon.Information); // Informo sucesso na exclusão
                    else // Se não, 
                        MessageBox.Show("Erro ao excluir os dados.", "Excluir Dados", MessageBoxButtons.OK, MessageBoxIcon.Error); // então digo que houve algum erro
                }
            }
        }
    }
}
