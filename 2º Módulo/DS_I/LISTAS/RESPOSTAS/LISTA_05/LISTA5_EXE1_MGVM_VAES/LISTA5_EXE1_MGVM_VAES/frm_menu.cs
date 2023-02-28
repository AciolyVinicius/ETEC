using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA5_EXE1_MGVM_VAES
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void btn_ordem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_ordem ordem = new frm_ordem();
            ordem.Show();
        }

        private void btn_imc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_imc imc = new frm_imc();
            imc.Show();
        }

        private void btn_media_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_media media = new frm_media();
            media.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Crie um formulário de Menu contendo as opções:\nA – Ordem Crescente -> i.Receba três números e exiba - os em ordem crescente.Se os números forem iguais peça ao usuário para digitar novamente.\nB – Média Final -> ii.Calcule a média aritmética das notas de 4 bimestres de um aluno e exiba o resultado final conforme a tabela: \n Média menor que 0 ou maior que 10 - Média Inválida \n Média maior ou igual a 7 - Aprovado \n Média abaixo de 4 Reprovado \n Outras médias Recuperação\nC – Calculo do IMC -> iii.Entrar com o peso e a altura de uma determinada pessoa. Após a digitação, exibir se esta pessoa está ou não com seu peso ideal. (Procure o calculo de massa corpórea para peso ideal ou calculo do IMC na internet.Apresente a fórmula utilizada em sua tela.)\nOBS: Cada programa deverá ser exibido em um formulário diferente.Todos os formulários terão a opção finalizar(Criada em uma sub - rotina no módulo)");
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
