using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA2_EXE3_MGVM_VAES
{
    public partial class lbl_livraria : Form
    {
        public lbl_livraria()
        {
            InitializeComponent();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            String nmlivro = (txt_livro.Text), atlivro = (txt_autor.Text), vllivro=(txt_valor.Text) ;
            float livro = float.Parse(vllivro);
            float preco = livro - livro * 20/100;

            MessageBox.Show("O livro "+ nmlivro + " do autor " + atlivro + " custa R$ " + vllivro + ", à vista o livro custará R$ " + preco );
            }

        private void btn_enunciado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ipanema proprietária de uma livraria solicitou um programa que: A – Receba o nome do livro(máximo 20 caracteres); B – Receba o nome do autor(máximo 30 caracteres); C – Receba o valor unitário (máximo 5 caracteres); D – Tenha uma caixa de opções com a categoria do livro; E – Tenha uma caixa de verificação para livros existentes em eBook; F – Permita a solicitação do tipo de pagamento G – Calcule o preço do livro com 20 % de desconto á vista. As informações recebidas deverão ser exibidas em uma label da seguinte maneira: O livro < livro > do autor<autor> custa < valor >>, á vista o livro custará < valor com desconto> O formulário não deverá possuir os botões minimizar, maximizar e fechar. Altere a cor do formulário.");
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Finalizar Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
